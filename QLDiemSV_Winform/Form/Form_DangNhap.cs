using Newtonsoft.Json;
using QLDiemSV_Winform.ApiController;
using QLDiemSV_Winform.DTO;
using QLDiemSV_Winform.Secure;
using QLDiemSV_Winform.Support;
using QLDiemSV_Winform.Validation;
using System;
using System.Linq;
using System.Net.Http;
using System.Windows.Forms;

namespace QLDiemSV_Winform
{
    public partial class Form_DangNhap : DevExpress.XtraEditors.XtraForm
    {
        private static readonly string Action = ConstantValues.ActionLogin;
        private static readonly string Target = "";
        public static readonly string FormName = Action + (Action.Length > 0 && Target.Length > 0 ? " " : "") + Target;
        public Form_DangNhap() { InitializeComponent(); }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            lb_error_TenDangNhap.Visible = lb_error_MatKhau.Visible = lb_error_DangNhap.Visible = false;
            try
            {
                string tenDangNhap = txt_TenDangNhap.Text;
                string matKhau = txt_MatKhau.Text;

                if(tenDangNhap.Length == 0)
                {
                    lb_error_TenDangNhap.Visible = true;
                    lb_error_TenDangNhap.Text = "Vui lòng nhập tên đăng nhập";
                    return;
                } else if(tenDangNhap.Length == 0)
                {
                    lb_error_MatKhau.Visible = true;
                    lb_error_MatKhau.Text = "Vui lòng nhập mật khẩu";
                    return;
                }

                bool isLoginSucessful = DangNhapController.PostDangNhap(tenDangNhap, matKhau) == "true";
                if(isLoginSucessful)
                {
                    SecureStorage.SaveCredentials(tenDangNhap, matKhau);
                    TabManager.CloseAllForm();
                    Program.formChinh.ShowMenu();
                } else
                {
                    lb_error_DangNhap.Visible = true;
                    lb_error_DangNhap.Text = "Nhập sai tài khoản hoặc mật khẩu";
                }
            } catch(Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btn_Thoat_Click(object sender, EventArgs e) => TabManager.CloseForm(this);

        private void btn_TogglePwd_Click(object sender, EventArgs e)
        { txt_MatKhau.UseSystemPasswordChar = !txt_MatKhau.UseSystemPasswordChar; }

        private void txt_TenDangNhap_KeyPress(object sender, KeyPressEventArgs e)
        { KeyHandler.CheckErrorKeyPressEvent(sender, lb_error_TenDangNhap, e, KeyHandler.NoneSpaceDigitHandler); }
    }
}