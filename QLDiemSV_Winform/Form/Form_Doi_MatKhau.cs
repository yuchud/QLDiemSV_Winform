using QLDiemSV_Winform.Secure;
using QLDiemSV_Winform.Support;
using System;
using System.Linq;
using System.Windows.Forms;

namespace QLDiemSV_Winform.Form.FormQuanLy
{
    public partial class Form_Doi_MatKhau : DevExpress.XtraEditors.XtraForm
    {
        private static readonly string Action = ConstantValues.ActionChange;
        private static readonly string Target = ConstantValues.TargetPassword;
        public static readonly string FormName = Action + (Action.Length > 0 && Target.Length > 0 ? " " : "") + Target;
        public Form_Doi_MatKhau() { InitializeComponent(); }

        private void btn_Thoat_Click(object sender, EventArgs e) { TabManager.CloseForm(this); }

        private void btn_TogglePwd_Click(object sender, EventArgs e) => txt_MatKhau.UseSystemPasswordChar =
            !txt_MatKhau.UseSystemPasswordChar;

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            lb_error_MatKhau.Visible = false;
            if(txt_MatKhau.Text == string.Empty)
            {
                lb_error_MatKhau.Text = $"Vui lòng nhập {Target}";
                lb_error_MatKhau.Visible = true;
                return;
            }

            if(MessageBoxManager.OpenMessageBox(Action, Target) == false)
                return;

            bool isSuccessful = MessageBoxManager.ShowResult(SecureStorage.ChangePassword(txt_MatKhau.Text), Action, Target);
            if (isSuccessful) txt_MatKhau.Text = string.Empty;
        }
    }
}