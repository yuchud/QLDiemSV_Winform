using DevExpress.XtraEditors;
using QLDiemSV_Winform.Controller;
using QLDiemSV_Winform.Secure;
using QLDiemSV_Winform.Support;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDiemSV_Winform.Form.FormQuanLy
{
    public partial class Form_Doi_MatKhau : DevExpress.XtraEditors.XtraForm
    {
        public Form_Doi_MatKhau()
        {
            InitializeComponent();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            TabManager.CloseForm(this);
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {

            lb_error_MatKhau.Visible = false;
            if (txt_MatKhau.Text == string.Empty)
            {
                lb_error_MatKhau.Text = "Vui lòng nhập mật khẩu";
                lb_error_MatKhau.Visible = true;
                return;
            }

            DialogResult dialogResult = MessageBox.Show(
                "Bạn có chắc chắn đổi mật khẩu?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            if (SecureStorage.ChangePassword(txt_MatKhau.Text) == true)
            {
                MessageBox.Show("Đổi mật khẩu thành công");
                txt_MatKhau.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Đổi mật khẩu thất bại");
            }
        }

        private void txt_MatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btn_TogglePwd_Click(object sender, EventArgs e)
        {
            txt_MatKhau.UseSystemPasswordChar = !txt_MatKhau.UseSystemPasswordChar;
        }
    }
}