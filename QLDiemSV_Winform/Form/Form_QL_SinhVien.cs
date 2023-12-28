using QLDiemSV_Winform.ApiController;
using QLDiemSV_Winform.DTO;
using QLDiemSV_Winform.SubForm;
using QLDiemSV_Winform.Support;
using QLDiemSV_Winform.Validation;
using System;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace QLDiemSV_Winform.Form
{
    public partial class Form_QL_SinhVien : DevExpress.XtraEditors.XtraForm
    {
        private int maLopSinhVien;

        public Form_QL_SinhVien()
        {
            InitializeComponent();
            form_LoadInitial();
        }

        private void btn_Chon_Click(object sender, EventArgs e)
        {
            using (SubForm_Lay_LopSinhVien subForm_Lay_LopSinhVien = new SubForm_Lay_LopSinhVien())
            {
                subForm_Lay_LopSinhVien.FormBorderStyle = FormBorderStyle.None;
                subForm_Lay_LopSinhVien.ShowDialog();
                int currentMaLopSinhVien = subForm_Lay_LopSinhVien.MaLopSinhVien;
                if (currentMaLopSinhVien != 0)
                {
                    maLopSinhVien = currentMaLopSinhVien;
                    txt_Khoa.ReadOnly = txt_Lop.ReadOnly = false;
                    txt_Lop.Text = subForm_Lay_LopSinhVien.TenLopSinhVien;
                    txt_Khoa.Text = subForm_Lay_LopSinhVien.TenKhoa;
                    txt_Khoa.ReadOnly = txt_Lop.ReadOnly = true;
                    form_LoadInitial();
                }
            }
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
                    $"Bạn có chắc chắn {action} sinh viên này?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if (dialogResult == DialogResult.No)
                    return;
                HttpStatusCode httpStatusCode;
                if (isAdd)
                    httpStatusCode = SinhVienApiController.PostSinhVien(dataSinhVien_Create(0));
                else
                    httpStatusCode = SinhVienApiController.PutSinhVien(
                        dataSinhVien_Create(Convert.ToInt32(txt_Ma.Text)));

                if (StatusCodeChecker.GetResponseClass(httpStatusCode) ==
                    EnumCode.HTTPResponseStatusClass.SuccessfulResponses)
                {
                    MessageBox.Show(
                        $"Đã {action} sinh viên thành công!",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    if (isAdd)
                        form_LoadInitial();
                    else
                    {
                        int currentSelectedRow = dgv_SinhVien.SelectedRows[0].Index;
                        dgv_SinhVien_FillData();
                        dgv_SinhVien.Rows[currentSelectedRow].Selected = true;
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

        private (bool canDelete, string error) btn_Xoa_CheckBeforeDelete(int maSinhVien)
        {
            if (BangDiemApiController.GetListBangDiemByMaSinhVien(maSinhVien).Count > 0)
                return (false, "Không thể xóa sinh viên có bảng điểm");
            return (true, string.Empty);
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            int maSinhVien = Convert.ToInt32(txt_Ma.Text);

            (bool canDelete, string error) = btn_Xoa_CheckBeforeDelete(maSinhVien);

            if (canDelete == false)
            {
                MessageBox.Show(error);
                return;
            }

            DialogResult dialogResult = MessageBox.Show(
                "Bạn có chắc chắn xóa sinh viên này?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
                return;
            bool isDeletionSuccessful = SinhVienApiController.DeleteSinhVien(maSinhVien) ==
                EnumCode.ApiDeleteResult.Success;

            if (isDeletionSuccessful)
            {
                MessageBox.Show("Xóa sinh viên thành công!");
                form_LoadInitial();
                // Perform additional actions after a successful deletion if needed
            }
            else
                MessageBox.Show("Xóa sinh viên thất bại.");
        }

        private SinhVienDTO dataSinhVien_Create(int MaSinhVien)
        {
            string ho = txt_Ho.Text;
            string ten = txt_Ten.Text;
            string diaChi = txt_DiaChi.Text;
            string sdt = txt_SDT.Text;
            return new SinhVienDTO(MaSinhVien, ho, ten, diaChi, sdt, maLopSinhVien);
        }

        private void dgv_SinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_SinhVien.SelectedRows.Count > 0)
            {
                btn_Xoa.Enabled = btn_Sua.Enabled = true;
                int maSinhVien = Convert.ToInt32(dgv_SinhVien.SelectedRows[0].Cells["maSv"].Value);
                inputField_FillData(maSinhVien);
            }
        }


        private void dgv_SinhVien_FillData()
        {
            dgv_SinhVien.DataSource = SinhVienApiController.GetListSinhVienByMaLopSinhVien(maLopSinhVien);
            DataGridViewManager.HideColumn(dgv_SinhVien, "maLopSv");
            lbl_SoLuong.Text = dgv_SinhVien.RowCount.ToString();
            dgv_SinhVien.ClearSelection();
        }

        private bool inputField_CheckNoneEmpty()
        {
            lbl_error_Ho.Visible = lbl_error_Ten.Visible = lbl_error_DiaChi.Visible = lbl_error_SDT.Visible = false;
            if (txt_Ho.Text == string.Empty)
            {
                lbl_error_Ho.Text = "Vui lòng nhập Họ";
                lbl_error_Ho.Visible = true;
                return false;
            } else if (txt_Ten.Text == string.Empty)
            {
                lbl_error_Ten.Text = "Vui lòng nhập Tên";
                lbl_error_Ten.Visible = true;
                return false;
            } else if (txt_DiaChi.Text == string.Empty)
            {
                lbl_error_DiaChi.Text = "Vui lòng nhập Địa chỉ";
                lbl_error_DiaChi.Visible = true;
                return false;
            } else if (txt_SDT.Text.Length < 6)
            {
                lbl_error_SDT.Text = "Số điện thoại cần ít nhất 6 kí tự";
                lbl_error_SDT.Visible = true;
                return false;
            }
            return true;
        }

        private void inputField_ClearAllData()
        {
            txt_Ma.Enabled = true;
            txt_Ma.Text = txt_Ho.Text = txt_Ten.Text = txt_DiaChi.Text = txt_SDT.Text = string.Empty;
            txt_Ma.Enabled = false;
        }


        private void inputField_Close()
        {
            if (dgv_SinhVien.SelectedRows.Count > 0)
                btn_Sua.Enabled = btn_Xoa.Enabled = true;
            dgv_SinhVien.Enabled = true;

            btn_Them.Enabled = btn_Xoa.Enabled = btn_Sua.Enabled = btn_Thoat.Enabled = true;
            btn_XacNhan.Enabled = btn_Huy.Enabled = false;

            lbl_error_Ho.Visible = lbl_error_Ten.Visible = lbl_error_DiaChi.Visible = lbl_error_SDT.Visible = false;
            txt_Ho.ReadOnly = txt_Ten.ReadOnly = txt_SDT.ReadOnly = txt_DiaChi.ReadOnly = true;
        }

        private void inputField_FillData(int maSinhVien)
        {
            if (maSinhVien == 0)
            {
                inputField_ClearAllData();
                return;
            }
            SinhVienDTO SinhVien = SinhVienApiController.GetSinhVien(maSinhVien);
            txt_Ma.Enabled = true;
            txt_Ma.Text = SinhVien.MaSv.ToString();
            txt_Ma.Enabled = false;
            txt_Ho.Text = SinhVien.Ho;
            txt_Ten.Text = SinhVien.Ten;
            txt_DiaChi.Text = SinhVien.DiaChi;
            txt_SDT.Text = SinhVien.Sdt;
        }

        private void inputField_Open()
        {
            dgv_SinhVien.Enabled = false;

            btn_Them.Enabled = btn_Xoa.Enabled = btn_Sua.Enabled = btn_Thoat.Enabled = false;
            btn_XacNhan.Enabled = btn_Huy.Enabled = true;

            txt_Ho.ReadOnly = txt_Ten.ReadOnly = txt_SDT.ReadOnly = txt_DiaChi.ReadOnly = false;
        }

        private void inputField_PrepareForAdd()
        {
            inputField_ClearAllData();
            txt_Ma.Enabled = true;
            txt_Ma.Text = "0";
            txt_Ma.Enabled = false;
        }

        private void txt_DiaChi_KeyPress(object sender, KeyPressEventArgs e) => KeyHandler.CheckErrorKeyPressEvent(sender, txt_DiaChi, lbl_error_DiaChi, e, KeyHandler.AddressHandler);

        private void txt_DiaChi_Leave(object sender, EventArgs e)
        {
            lbl_error_DiaChi.Visible = false;
            txt_DiaChi.Text = Standardize.StandardizeText(txt_DiaChi.Text);
        }

        private void txt_Ho_KeyPress(object sender, KeyPressEventArgs e) => KeyHandler.CheckErrorKeyPressEvent(sender, txt_Ho, lbl_error_Ho, e, KeyHandler.TextHandler);

        private void txt_Ho_Leave(object sender, EventArgs e)
        {
            lbl_error_Ho.Visible = false;
            txt_Ho.Text = Standardize.StandardizeText(txt_Ho.Text);
        }

        private void txt_SDT_KeyPress(object sender, KeyPressEventArgs e) => KeyHandler.CheckErrorKeyPressEvent(sender, txt_SDT, lbl_error_SDT, e, KeyHandler.NoneSpaceTeleNumberHandler);

        private void txt_Ten_KeyPress(object sender, KeyPressEventArgs e) => KeyHandler.CheckErrorKeyPressEvent(sender, txt_Ten, lbl_error_Ten, e, KeyHandler.TextHandler);

        private void txt_Ten_Leave(object sender, EventArgs e)
        {
            lbl_error_Ten.Visible = false;
            txt_Ten.Text = Standardize.StandardizeText(txt_Ten.Text);
        }

        public void form_LoadInitial()
        {
            dgv_SinhVien_FillData();
            inputField_ClearAllData();
            inputField_Close();
            if (maLopSinhVien == 0)
                btn_Them.Enabled = false;
            btn_Xoa.Enabled = btn_Sua.Enabled = false;
        }
    }
}