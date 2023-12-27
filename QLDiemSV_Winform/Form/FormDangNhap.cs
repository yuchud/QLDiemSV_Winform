using Newtonsoft.Json;
using QLDiemSV_Winform.DTO;
using QLDiemSV_Winform.Secure;
using QLDiemSV_Winform.Validation;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Windows.Forms;

namespace QLDiemSV_Winform
{
    public partial class FormDangNhap : DevExpress.XtraEditors.XtraForm
    {

        private readonly string Api_DangNhap_Url = Program.ApiBaseUrl + "/Login";
        public FormDangNhap()
        {
            InitializeComponent();
        }

        public void CloseForm()
        {
            foreach (TabPage tabPage in Program.formChinh.GetTabControl().TabPages)
            {
                if (tabPage.Controls.Contains(this))
                {
                    Program.formChinh.GetTabControl().TabPages.Remove(tabPage);
                    tabPage.Dispose();
                    break; // Exit the loop once found
                }
            }
            this.Close();
        }


        private string jsonDangNhap_create(string tenDangNhap, string matKhau)
        {
            return JsonConvert.SerializeObject(new TaiKhoanDTO(tenDangNhap, matKhau));
        }

        private string dataDangNhap_PostApi(string tenDangNhap, string matKhau)
        {
            using (var httpClient = new HttpClient())
            {
                string jsonGiangVien = jsonDangNhap_create(tenDangNhap, matKhau);
                HttpResponseMessage response = httpClient.PostAsync($"{Api_DangNhap_Url}/GiangVien", new StringContent(jsonGiangVien, System.Text.Encoding.UTF8, "application/json")).Result;
                return response.Content.ReadAsStringAsync().Result;
            }
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            lb_error_TenDangNhap.Visible = lb_error_MatKhau.Visible = lb_error_DangNhap.Visible = false;
            try
            {
                string tenDangNhap = txt_TenDangNhap.Text;
                string matKhau = txt_MatKhau.Text;

                if (tenDangNhap.Length == 0)
                {
                    lb_error_TenDangNhap.Visible = true;
                    lb_error_TenDangNhap.Text = "Vui lòng nhập tên đăng nhập";
                    return;
                }
                else if (tenDangNhap.Length == 0)
                {
                    lb_error_MatKhau.Visible = true;
                    lb_error_MatKhau.Text = "Vui lòng nhập mật khẩu";
                    return;
                }

                bool isLoginSucessful = dataDangNhap_PostApi(tenDangNhap, matKhau) == "true";
                if (isLoginSucessful)
                {
                    SecureStorage.SaveCredentials(tenDangNhap, matKhau);
                    CloseForm();
                    Program.formChinh.ShowMenu();

                }
                else
                {
                    lb_error_DangNhap.Visible = true;
                    lb_error_DangNhap.Text = "Nhập sai tài khoản hoặc mật khẩu";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        private void txt_TenDangNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyHandler.CheckErrorKeyPressEvent(sender, txt_TenDangNhap, lb_error_TenDangNhap, e, KeyHandler.NoneSpaceDigitHandler);
        }

        private void btn_TogglePwd_Click(object sender, EventArgs e)
        {
            txt_MatKhau.UseSystemPasswordChar = !txt_MatKhau.UseSystemPasswordChar;
        }

        private void txt_MatKhau_TextChanged(object sender, EventArgs e)
        {

        }
    }
}