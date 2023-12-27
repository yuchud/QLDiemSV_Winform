using DevExpress.XtraBars;
using QLDiemSV_Winform.Form;
using QLDiemSV_Winform.Secure;
using QLDiemSV_Winform.Support;
using QLDiemSV_Winform.Validation;
using System;
using System.Linq;
using System.Windows.Forms;

namespace QLDiemSV_Winform
{
    public partial class FormChinh : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormChinh()
        {
            InitializeComponent();
            ShowMenu();
        }

        private void btn_DangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TabManager.OpenForm(new FormDangNhap(), ConstantValues.TenFormDangNhap);
        }

        private void btn_DangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            SecureStorage.ClearCredentials();
            TabManager.CloseAllForm();
            ShowMenu();
        }

        private void btn_QL_GiangVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            TabManager.OpenForm(new Form_QL_GiangVien(), ConstantValues.TenFormQuanLyGiangVien);
        }



        private void loadDefaultForm()
        {
            btn_DangNhap.Visibility = BarItemVisibility.Always;
            btn_DangXuat.Visibility = BarItemVisibility.Never;
            rbp_QuanLy.Visible = false;
        }

        private void loadQuanLyForm()
        {
            rbp_QuanLy.Visible = true;
            btn_DangNhap.Visibility = BarItemVisibility.Never;
            btn_DangXuat.Visibility = BarItemVisibility.Always;
        }

        public TabControl GetTabControl()
        {
            return tabControl1;
        }


        public void ShowMenu()
        {
            var (tenDangNhap, MatKhau, Quyen) = SecureStorage.GetCredentials();
            tssl_Ma.Text = (tenDangNhap != null) ? tenDangNhap : string.Empty;
            if (Quyen == EnumCode.Decentralization.NhanVien)
            {
                loadQuanLyForm();

            }
            else
            {
                loadDefaultForm();
            }
        }

        private void btn_QL_LopHoc_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btn_QL_LopSinhVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            TabManager.OpenForm(new Form_QL_LopSinhVien(), ConstantValues.TenFormQuanLyLopSinhVien);
        }

        private void btn_QL_MonHoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            TabManager.OpenForm(new Form_QL_MonHoc(), ConstantValues.TenFormQuanLyMonHoc);

        }

        private void btn_QL_SinhVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            TabManager.OpenForm(new Form_QL_SinhVien(), ConstantValues.TenFormQuanLySinhVien);
        }

        private void btn_QL_TaoLopTinChi_ItemClick(object sender, ItemClickEventArgs e)
        {
            TabManager.OpenForm(new Form_Tao_LopTinChi(), ConstantValues.TenFormTaoLopTinChi);
        }
    }
}