using DevExpress.XtraBars;
using QLDiemSV_Winform.Form;
using QLDiemSV_Winform.Form.FormQuanLy;
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
            btn_DangXuat.Visibility = btn_DoiMatKhau.Visibility = BarItemVisibility.Never;
            rbgp_NhanSu.Visible = rbpg_MonHoc.Visible = rbpg_Lop.Visible = rbpg_Diem.Visible = false;
        }

        private void loadQuanLyForm()
        {
            loadGiangVienForm();
            rbgp_NhanSu.Visible = rbpg_MonHoc.Visible = rbpg_Lop.Visible = true;
        }

        private void loadGiangVienForm()
        {
            btn_DangNhap.Visibility = BarItemVisibility.Never;
            btn_DangXuat.Visibility = btn_DoiMatKhau.Visibility = BarItemVisibility.Always;
            rbpg_Diem.Visible = true;
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
            else if (Quyen == EnumCode.Decentralization.GiangVien)
            {
                loadGiangVienForm();
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

        private void btn_XepLopTinChi_ItemClick(object sender, ItemClickEventArgs e)
        {
            TabManager.OpenForm(new Form_Xep_LopTinChi(), ConstantValues.TenFormXepLopTinChi);
        }

        private void btn_DoiMatKhau_ItemClick(object sender, ItemClickEventArgs e)
        {
            TabManager.OpenForm(new Form_Doi_MatKhau(), ConstantValues.TenFormDoiMatKhau);
        }
    }
}