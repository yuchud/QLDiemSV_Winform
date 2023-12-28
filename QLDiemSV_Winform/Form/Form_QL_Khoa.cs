﻿using QLDiemSV_Winform.ApiController;
using QLDiemSV_Winform.Controller;
using QLDiemSV_Winform.DTO;
using QLDiemSV_Winform.Support;
using QLDiemSV_Winform.Validation;
using System;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace QLDiemSV_Winform.Form.FormQuanLy
{
    public partial class Form_QL_Khoa : DevExpress.XtraEditors.XtraForm
    {
        public Form_QL_Khoa()
        {
            InitializeComponent();
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
            if(isNoneEmptyField)
            {
                DialogResult dialogResult = MessageBox.Show(
                    $"Bạn có chắc chắn {action} khoa này?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
                if(dialogResult == DialogResult.No)
                    return;
                HttpStatusCode httpStatusCode;
                if(isAdd)
                    httpStatusCode = KhoaApiController.PostKhoa(dataKhoa_Create(0));
                else
                    httpStatusCode = KhoaApiController.PutKhoa(dataKhoa_Create(Convert.ToInt32(txt_Ma.Text)));

                if(StatusCodeChecker.GetResponseClass(httpStatusCode) ==
                    EnumCode.HTTPResponseStatusClass.SuccessfulResponses)
                {
                    MessageBox.Show(
                        $"Đã {action} khoa thành công!",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    if(isAdd)
                        form_LoadInitial();
                    else
                    {
                        int currentSelectedRow = dgv_Khoa.SelectedRows[0].Index;
                        dgv_Khoa_FillData();
                        dgv_Khoa.Rows[currentSelectedRow].Selected = true;
                    }
                } else
                    MessageBox.Show(
                        $"{action} thất bại. Status code: {httpStatusCode}",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                inputField_Close();
            }
        }

        private (bool canDelete, string error) btn_Xoa_CheckBeforeDelete(int maKhoa)
        {
            if(GiangVienApiController.GetListGiangVienByMaKhoa(maKhoa).Count > 0)
            {
                return (false, "Không thể xóa vì khoa đang có giảng viên");
            }
            if(LopSinhVienApiController.GetListLopSinhVienByMaKhoa(maKhoa).Count > 0)
            {
                return (false, "Không thể xóa vì khoa đang có lớp sinh viên");
            }
            return (true, string.Empty);
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            int maKhoa = Convert.ToInt32(txt_Ma.Text);

            (bool canDelete, string error) = btn_Xoa_CheckBeforeDelete(maKhoa);

            if(canDelete == false)
            {
                MessageBox.Show(error);
                return;
            }

            DialogResult dialogResult = MessageBox.Show(
                "Bạn có chắc chắn xóa khoa này?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if(dialogResult == DialogResult.No)
                return;
            bool isDeletionSuccessful = KhoaApiController.DeleteKhoa(maKhoa) == EnumCode.ApiDeleteResult.Success;

            if(isDeletionSuccessful)
            {
                MessageBox.Show("Xóa khoa thành công!");
                form_LoadInitial();
                // Perform additional actions after a successful deletion if needed
            } else
                MessageBox.Show("Xóa khoa thất bại.");
        }

        private KhoaDTO dataKhoa_Create(int maKhoa)
        {
            string tenKhoa = txt_Ten.Text;
            return new KhoaDTO(maKhoa, tenKhoa);
        }

        private void dgv_Khoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgv_Khoa.SelectedRows.Count > 0)
            {
                btn_Xoa.Enabled = btn_Sua.Enabled = true;
                int maKhoa = Convert.ToInt32(dgv_Khoa.SelectedRows[0].Cells["maKhoa"].Value);
                inputField_FillData(maKhoa);
            }
        }

        private void dgv_Khoa_FillData()
        {
            dgv_Khoa.DataSource = KhoaApiController.GetAllKhoa();
            lbl_SoLuong.Text = dgv_Khoa.RowCount.ToString();
            dgv_Khoa.ClearSelection();
        }

        private void form_LoadInitial()
        {
            dgv_Khoa_FillData();
            inputField_ClearAllData();
            inputField_Close();
            btn_Xoa.Enabled = btn_Sua.Enabled = false;
        }

        private bool inputField_CheckNoneEmpty()
        {
            lbl_error_Ten.Visible = false;
            if(txt_Ten.Text == string.Empty)
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
            if(dgv_Khoa.SelectedRows.Count > 0)
                btn_Sua.Enabled = btn_Xoa.Enabled = true;
            dgv_Khoa.Enabled = true;
            btn_Them.Enabled = btn_Xoa.Enabled = btn_Sua.Enabled = btn_Thoat.Enabled = true;
            btn_XacNhan.Enabled = btn_Huy.Enabled = false;

            txt_Ten.ReadOnly = true;
        }

        private void inputField_FillData(int maKhoa)
        {
            if(maKhoa == 0)
            {
                inputField_ClearAllData();
                return;
            }
            KhoaDTO Khoa = KhoaApiController.GetKhoa(maKhoa);
            txt_Ma.Enabled = true;
            txt_Ma.Text = Khoa.MaKhoa.ToString();
            txt_Ma.Enabled = false;
            txt_Ten.Text = Khoa.TenKhoa;
        }

        private void inputField_Open()
        {
            dgv_Khoa.Enabled = false;

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

        private void txt_Ten_KeyPress(object sender, KeyPressEventArgs e)
        { KeyHandler.CheckErrorKeyPressEvent(sender, txt_Ten, lbl_error_Ten, e, KeyHandler.DigitTextHandler); }


        private void txt_Ten_Leave(object sender, EventArgs e)
        {
            lbl_error_Ten.Visible = false;
            txt_Ten.Text = Standardize.StandardizeText(txt_Ten.Text);
        }
    }
}