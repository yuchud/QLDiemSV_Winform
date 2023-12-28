using QLDiemSV_Winform.ApiController;
using QLDiemSV_Winform.DTO;
using QLDiemSV_Winform.Support;
using QLDiemSV_Winform.Validation;
using System;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace QLDiemSV_Winform.Form
{
    public partial class Form_QL_LopSinhVien : DevExpress.XtraEditors.XtraForm
    {
        public Form_QL_LopSinhVien()
        {
            InitializeComponent();
            cmb_Khoa_FillData();
            form_LoadInitial();
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            inputField_FillData(Convert.ToInt32(txt_Ma.Text));
            inputField_Close();
        }

        private void btn_Sua_Click(object sender, EventArgs e) => inputField_Open();

        private void btn_Them_Click(object sender, EventArgs e)
        {
            inputField_Open();
            inputField_PrepareForAdd();
        }

        private void btn_Thoat_Click(object sender, EventArgs e) => TabManager.CloseForm(this);

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            bool isNoneEmptyField = inputField_CheckNoneEmpty();
            bool isAdd = txt_Ma.Text == "0";
            string action = (isAdd) ? "thêm" : "chỉnh sửa";
            if (isNoneEmptyField)
            {
                DialogResult dialogResult = MessageBox.Show(
                    $"Bạn có chắc chắn {action} lớp sinh viên này?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (dialogResult == DialogResult.No)
                    return;
                HttpStatusCode httpStatusCode;
                if (isAdd)
                    httpStatusCode = LopSinhVienApiController.PostLopSinhVien(dataLopSinhVien_Create(0));
                else
                    httpStatusCode = LopSinhVienApiController.PutLopSinhVien(
                        dataLopSinhVien_Create(Convert.ToInt32(txt_Ma.Text)));

                if (StatusCodeChecker.GetResponseClass(httpStatusCode) ==
                    EnumCode.HTTPResponseStatusClass.SuccessfulResponses)
                {
                    MessageBox.Show(
                        $"Đã {action} lớp sinh viên thành công!",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    if (isAdd)
                        form_LoadInitial();
                    else
                    {
                        int currentSelectedRow = dgv_LopSinhVien.SelectedRows[0].Index;
                        dgv_LopSinhVien_FillData(dataMaKhoa_Get());
                        dgv_LopSinhVien.Rows[currentSelectedRow].Selected = true;
                    }
                }
                else
                    MessageBox.Show(
                        $"{action} thất bại. Status code: {httpStatusCode}",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                inputField_Close();
            }
        }

        private (bool canDelete, string error) btn_Xoa_CheckBeforeDelete(int maLopSinhVien)
        {
            if (LopSinhVienApiController.GetListLopSinhVienByMaKhoa(maLopSinhVien).Count > 0)
                return (false, "Lớp sinh viên đang có sinh viên");
            return (true, string.Empty);
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            int maLopSinhVien = Convert.ToInt32(txt_Ma.Text);

            (bool canDelete, string error) = btn_Xoa_CheckBeforeDelete(maLopSinhVien);

            if (canDelete == false)
            {
                MessageBox.Show(error);
                return;
            }

            DialogResult dialogResult = MessageBox.Show(
                "Bạn có chắc chắn xóa lớp sinh viên này?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
                return;
            bool isDeletionSuccessful = LopSinhVienApiController.DeleteLopSinhVien(maLopSinhVien) ==
                EnumCode.ApiDeleteResult.Success;

            if (isDeletionSuccessful)
            {
                MessageBox.Show("Xóa lớp sinh viên thành công!");
                form_LoadInitial();
                // Perform additional actions after a successful deletion if needed
            }
            else
                MessageBox.Show("Xóa lớp sinh viên thất bại.");
        }

        private void cmb_Khoa_FillData()
        {
            cmb_Khoa.DataSource = KhoaApiController.GetAllKhoa();
            cmb_Khoa.DisplayMember = "tenKhoa";
            cmb_Khoa.ValueMember = "maKhoa";
        }

        private void cmb_Khoa_SelectedIndexChanged(object sender, EventArgs e) => form_LoadInitial();

        private LopSinhVienDTO dataLopSinhVien_Create(int MaLopSinhVien)
        {
            string ten = txt_Ten.Text;
            int maKhoa = dataMaKhoa_Get();
            return new LopSinhVienDTO(MaLopSinhVien, ten, maKhoa);
        }

        private int dataMaKhoa_Get()
        {
            dynamic khoa = cmb_Khoa.SelectedItem;
            return khoa.MaKhoa;
        }

        private void dgv_LopSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_LopSinhVien.SelectedRows.Count > 0)
            {
                btn_Xoa.Enabled = btn_Sua.Enabled = true;
                int maLopSinhVien = Convert.ToInt32(dgv_LopSinhVien.SelectedRows[0].Cells["maLopSv"].Value);
                inputField_FillData(maLopSinhVien);
            }
        }

        private void dgv_LopSinhVien_FillData(int MaKhoa)
        {
            dgv_LopSinhVien.DataSource = LopSinhVienApiController.GetListLopSinhVienByMaKhoa(MaKhoa);
            DataGridViewManager.HideColumn(dgv_LopSinhVien, "maKhoa");
            lbl_SoLuong.Text = dgv_LopSinhVien.RowCount.ToString();
            dgv_LopSinhVien.ClearSelection();
        }

        private bool inputField_CheckNoneEmpty()
        {
            lbl_error_Ten.Visible = false;
            if (txt_Ten.Text == string.Empty)
            {
                lbl_error_Ten.Text = "Vui lòng nhập Tên";
                lbl_error_Ten.Visible = true;
                return false;
            }
            return true;
        }

        private void inputField_ClearAllData()
        {
            txt_Ma.Enabled = true;
            txt_Ma.Text = txt_Ten.Text = string.Empty;
            txt_Ma.Enabled = false;
        }

        private void inputField_Close()
        {
            if (dgv_LopSinhVien.SelectedRows.Count > 0)
                btn_Sua.Enabled = btn_Xoa.Enabled = true;
            dgv_LopSinhVien.Enabled = true;
            cmb_Khoa.Enabled = true;

            btn_Them.Enabled = btn_Xoa.Enabled = btn_Sua.Enabled = btn_Thoat.Enabled = true;
            btn_XacNhan.Enabled = btn_Huy.Enabled = false;

            lbl_error_Ten.Visible = false;
            txt_Ten.ReadOnly = true;
        }


        private void inputField_FillData(int maLopSinhVien)
        {
            if (maLopSinhVien == 0)
            {
                inputField_ClearAllData();
                return;
            }
            LopSinhVienDTO lopSinhVien = LopSinhVienApiController.GetLopSinhVien(maLopSinhVien);
            txt_Ma.Enabled = true;
            txt_Ma.Text = lopSinhVien.MaLopSv.ToString();
            txt_Ma.Enabled = false;
            txt_Ten.Text = lopSinhVien.TenLopSv;
        }

        private void inputField_Open()
        {
            dgv_LopSinhVien.Enabled = false;
            cmb_Khoa.Enabled = false;

            btn_Them.Enabled = btn_Xoa.Enabled = btn_Sua.Enabled = btn_Thoat.Enabled = false;
            btn_XacNhan.Enabled = btn_Huy.Enabled = true;

            txt_Ten.ReadOnly = false;
        }

        private void inputField_PrepareForAdd()
        {
            inputField_ClearAllData();
            txt_Ma.Enabled = true;
            txt_Ma.Text = "0";
            txt_Ma.Enabled = false;
        }

        private void txt_Ten_KeyPress(object sender, KeyPressEventArgs e) => KeyHandler.CheckErrorKeyPressEvent(sender, txt_Ten, lbl_error_Ten, e, KeyHandler.DigitTextHandler);

        private void txt_Ten_Leave(object sender, EventArgs e)
        {
            lbl_error_Ten.Visible = false;
            txt_Ten.Text = Standardize.StandardizeText(txt_Ten.Text);
        }

        public void form_LoadInitial()
        {
            dgv_LopSinhVien_FillData(dataMaKhoa_Get());
            inputField_ClearAllData();
            inputField_Close();
            btn_Xoa.Enabled = btn_Sua.Enabled = false;
        }
    }
}
