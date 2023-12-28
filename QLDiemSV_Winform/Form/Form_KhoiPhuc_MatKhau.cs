using QLDiemSV_Winform.Controller;
using QLDiemSV_Winform.Support;
using QLDiemSV_Winform.Validation;
using System;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace QLDiemSV_Winform.Form
{
    public partial class Form_KhoiPhuc_MatKhau : DevExpress.XtraEditors.XtraForm
    {
        public Form_KhoiPhuc_MatKhau() { InitializeComponent(); }

        private void btn_Thoat_Click(object sender, EventArgs e) { TabManager.CloseForm(this); }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            lbl_error_TenDangNhap.Visible = lbl_error_XacNhan.Visible = false;
            if(txt_TenDangNhap.Text == string.Empty)
            {
                lbl_error_TenDangNhap.Text = "Vui lòng nhập tên đăng nhập";
                lbl_error_TenDangNhap.Visible = true;
                return;
            }
            string tenDangNhap = txt_TenDangNhap.Text;
            if(GiangVienApiController.GetGiangVien(Convert.ToInt32(tenDangNhap)) == null)
            {
                lbl_error_XacNhan.Text = "Không tìm thấy tên đăng nhập";
                lbl_error_XacNhan.Visible = true;
                return;
            }


            DialogResult dialogResult = MessageBox.Show(
                "Bạn có chắc chắn khôi phục mật khẩu?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if(dialogResult == DialogResult.No)
                return;

            HttpStatusCode httpStatusCode = GiangVienApiController.PutMatKhau(
                new DTO.TaiKhoanDTO(tenDangNhap, tenDangNhap));

            if(StatusCodeChecker.GetResponseClass(httpStatusCode) ==
                EnumCode.HTTPResponseStatusClass.SuccessfulResponses)
            {
                MessageBox.Show(
                    $"Đã khôi phục mật khẩu thành công!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txt_TenDangNhap.Text = string.Empty;
            }
        }

        private void txt_MatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyHandler.CheckErrorKeyPressEvent(
                sender,
                txt_TenDangNhap,
                lbl_error_TenDangNhap,
                e,
                KeyHandler.NoneSpaceDigitHandler);
        }
    }
}