namespace QLDiemSV_Winform
{
    partial class FormChinh
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChinh));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_QL_LopSinhVien = new DevExpress.XtraBars.BarButtonItem();
            this.btn_QL_MonHoc = new DevExpress.XtraBars.BarButtonItem();
            this.btn_QL_GiangVien = new DevExpress.XtraBars.BarButtonItem();
            this.btn_QL_SinhVien = new DevExpress.XtraBars.BarButtonItem();
            this.btn_DangNhap100 = new DevExpress.XtraBars.BarButtonItem();
            this.btn_QL_TaoLopTinChi = new DevExpress.XtraBars.BarButtonItem();
            this.btn_DangXuat100 = new DevExpress.XtraBars.BarButtonItem();
            this.btn_XepLopTinChi = new DevExpress.XtraBars.BarButtonItem();
            this.btn_DangNhap = new DevExpress.XtraBars.BarButtonItem();
            this.btn_DangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.btn_DoiMatKhau = new DevExpress.XtraBars.BarButtonItem();
            this.rbg_HeThong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.tbgp_TaiKhoan = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpg_MonHoc = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbgp_NhanSu = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpg_Lop = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.btn_XepLop = new DevExpress.XtraBars.BarButtonItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssl_Ma = new System.Windows.Forms.ToolStripStatusLabel();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpg_Diem = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btn_NhapDiem = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btn_QL_LopSinhVien,
            this.btn_QL_MonHoc,
            this.btn_QL_GiangVien,
            this.btn_QL_SinhVien,
            this.btn_DangNhap100,
            this.btn_QL_TaoLopTinChi,
            this.btn_DangXuat100,
            this.btn_XepLopTinChi,
            this.btn_DangNhap,
            this.btn_DangXuat,
            this.btn_DoiMatKhau,
            this.btn_NhapDiem});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 21;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbg_HeThong});
            this.ribbon.Size = new System.Drawing.Size(1364, 158);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btn_QL_LopSinhVien
            // 
            this.btn_QL_LopSinhVien.Caption = "Quản lý lớp sinh viên";
            this.btn_QL_LopSinhVien.Id = 1;
            this.btn_QL_LopSinhVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_QL_LopSinhVien.ImageOptions.Image")));
            this.btn_QL_LopSinhVien.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_QL_LopSinhVien.ImageOptions.LargeImage")));
            this.btn_QL_LopSinhVien.Name = "btn_QL_LopSinhVien";
            this.btn_QL_LopSinhVien.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.btn_QL_LopSinhVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_QL_LopSinhVien_ItemClick);
            // 
            // btn_QL_MonHoc
            // 
            this.btn_QL_MonHoc.Caption = "Quản lý môn học";
            this.btn_QL_MonHoc.Id = 2;
            this.btn_QL_MonHoc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_QL_MonHoc.ImageOptions.Image")));
            this.btn_QL_MonHoc.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_QL_MonHoc.ImageOptions.LargeImage")));
            this.btn_QL_MonHoc.Name = "btn_QL_MonHoc";
            this.btn_QL_MonHoc.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.btn_QL_MonHoc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_QL_MonHoc_ItemClick);
            // 
            // btn_QL_GiangVien
            // 
            this.btn_QL_GiangVien.Caption = "Quản lý giảng viên";
            this.btn_QL_GiangVien.Id = 3;
            this.btn_QL_GiangVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_QL_GiangVien.ImageOptions.Image")));
            this.btn_QL_GiangVien.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_QL_GiangVien.ImageOptions.LargeImage")));
            this.btn_QL_GiangVien.Name = "btn_QL_GiangVien";
            this.btn_QL_GiangVien.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.btn_QL_GiangVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_QL_GiangVien_ItemClick);
            // 
            // btn_QL_SinhVien
            // 
            this.btn_QL_SinhVien.Caption = "Quản lý sinh viên";
            this.btn_QL_SinhVien.Id = 4;
            this.btn_QL_SinhVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_QL_SinhVien.ImageOptions.Image")));
            this.btn_QL_SinhVien.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_QL_SinhVien.ImageOptions.LargeImage")));
            this.btn_QL_SinhVien.Name = "btn_QL_SinhVien";
            this.btn_QL_SinhVien.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.btn_QL_SinhVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_QL_SinhVien_ItemClick);
            // 
            // btn_DangNhap100
            // 
            this.btn_DangNhap100.Caption = "Đăng nhập";
            this.btn_DangNhap100.Id = 11;
            this.btn_DangNhap100.Name = "btn_DangNhap100";
            // 
            // btn_QL_TaoLopTinChi
            // 
            this.btn_QL_TaoLopTinChi.Caption = "Tạo lớp tín chỉ";
            this.btn_QL_TaoLopTinChi.Id = 14;
            this.btn_QL_TaoLopTinChi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_QL_TaoLopTinChi.ImageOptions.Image")));
            this.btn_QL_TaoLopTinChi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_QL_TaoLopTinChi.ImageOptions.LargeImage")));
            this.btn_QL_TaoLopTinChi.Name = "btn_QL_TaoLopTinChi";
            this.btn_QL_TaoLopTinChi.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.btn_QL_TaoLopTinChi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_QL_TaoLopTinChi_ItemClick);
            // 
            // btn_DangXuat100
            // 
            this.btn_DangXuat100.Caption = "Đăng xuất";
            this.btn_DangXuat100.Id = 15;
            this.btn_DangXuat100.Name = "btn_DangXuat100";
            // 
            // btn_XepLopTinChi
            // 
            this.btn_XepLopTinChi.Caption = "Xếp lớp tín chỉ";
            this.btn_XepLopTinChi.Id = 16;
            this.btn_XepLopTinChi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_XepLopTinChi.ImageOptions.Image")));
            this.btn_XepLopTinChi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_XepLopTinChi.ImageOptions.LargeImage")));
            this.btn_XepLopTinChi.Name = "btn_XepLopTinChi";
            this.btn_XepLopTinChi.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.btn_XepLopTinChi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_XepLopTinChi_ItemClick);
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.Caption = "Đăng nhập";
            this.btn_DangNhap.Id = 17;
            this.btn_DangNhap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_DangNhap.ImageOptions.Image")));
            this.btn_DangNhap.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_DangNhap.ImageOptions.LargeImage")));
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.btn_DangNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_DangNhap_ItemClick);
            // 
            // btn_DangXuat
            // 
            this.btn_DangXuat.Caption = "Đăng xuất";
            this.btn_DangXuat.Id = 18;
            this.btn_DangXuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_DangXuat.ImageOptions.Image")));
            this.btn_DangXuat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_DangXuat.ImageOptions.LargeImage")));
            this.btn_DangXuat.Name = "btn_DangXuat";
            this.btn_DangXuat.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.btn_DangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_DangXuat_ItemClick);
            // 
            // btn_DoiMatKhau
            // 
            this.btn_DoiMatKhau.Caption = "Đổi Mật Khẩu";
            this.btn_DoiMatKhau.Id = 19;
            this.btn_DoiMatKhau.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_DoiMatKhau.ImageOptions.Image")));
            this.btn_DoiMatKhau.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_DoiMatKhau.ImageOptions.LargeImage")));
            this.btn_DoiMatKhau.Name = "btn_DoiMatKhau";
            this.btn_DoiMatKhau.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.btn_DoiMatKhau.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_DoiMatKhau_ItemClick);
            // 
            // rbg_HeThong
            // 
            this.rbg_HeThong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.tbgp_TaiKhoan,
            this.rbpg_MonHoc,
            this.rbgp_NhanSu,
            this.rbpg_Lop,
            this.rbpg_Diem});
            this.rbg_HeThong.Name = "rbg_HeThong";
            this.rbg_HeThong.Text = "Hệ thống";
            // 
            // tbgp_TaiKhoan
            // 
            this.tbgp_TaiKhoan.ItemLinks.Add(this.btn_DangNhap);
            this.tbgp_TaiKhoan.ItemLinks.Add(this.btn_DoiMatKhau);
            this.tbgp_TaiKhoan.ItemLinks.Add(this.btn_DangXuat);
            this.tbgp_TaiKhoan.Name = "tbgp_TaiKhoan";
            this.tbgp_TaiKhoan.Text = "Tài Khoản";
            // 
            // rbpg_MonHoc
            // 
            this.rbpg_MonHoc.ItemLinks.Add(this.btn_QL_MonHoc);
            this.rbpg_MonHoc.Name = "rbpg_MonHoc";
            this.rbpg_MonHoc.Text = "Môn Học";
            // 
            // rbgp_NhanSu
            // 
            this.rbgp_NhanSu.ItemLinks.Add(this.btn_QL_GiangVien);
            this.rbgp_NhanSu.ItemLinks.Add(this.btn_QL_SinhVien);
            this.rbgp_NhanSu.Name = "rbgp_NhanSu";
            this.rbgp_NhanSu.Text = "Nhân sự";
            // 
            // rbpg_Lop
            // 
            this.rbpg_Lop.ItemLinks.Add(this.btn_QL_LopSinhVien);
            this.rbpg_Lop.ItemLinks.Add(this.btn_QL_TaoLopTinChi);
            this.rbpg_Lop.ItemLinks.Add(this.btn_XepLopTinChi);
            this.rbpg_Lop.Name = "rbpg_Lop";
            this.rbpg_Lop.Text = "Lớp";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 743);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1364, 24);
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 158);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1364, 585);
            this.tabControl1.TabIndex = 3;
            // 
            // btn_XepLop
            // 
            this.btn_XepLop.Caption = "Xếp lớp tín chỉ";
            this.btn_XepLop.Id = 5;
            this.btn_XepLop.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_XepLop.ImageOptions.Image")));
            this.btn_XepLop.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_XepLop.ImageOptions.LargeImage")));
            this.btn_XepLop.Name = "btn_XepLop";
            this.btn_XepLop.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssl_Ma});
            this.statusStrip1.Location = new System.Drawing.Point(0, 721);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1364, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssl_Ma
            // 
            this.tssl_Ma.Name = "tssl_Ma";
            this.tssl_Ma.Size = new System.Drawing.Size(24, 17);
            this.tssl_Ma.Text = "Mã";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btn_DangNhap100);
            this.ribbonPageGroup4.ItemLinks.Add(this.btn_DangXuat100);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "ribbonPageGroup4";
            // 
            // rbpg_Diem
            // 
            this.rbpg_Diem.ItemLinks.Add(this.btn_NhapDiem);
            this.rbpg_Diem.Name = "rbpg_Diem";
            this.rbpg_Diem.Text = "Điểm";
            // 
            // btn_NhapDiem
            // 
            this.btn_NhapDiem.Caption = "Nhập điểm";
            this.btn_NhapDiem.Id = 20;
            this.btn_NhapDiem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_NhapDiem.ImageOptions.Image")));
            this.btn_NhapDiem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_NhapDiem.ImageOptions.LargeImage")));
            this.btn_NhapDiem.Name = "btn_NhapDiem";
            this.btn_NhapDiem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // FormChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 767);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.MinimumSize = new System.Drawing.Size(1366, 768);
            this.Name = "FormChinh";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Nhân Viên";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbg_HeThong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbgp_MonHoc;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btn_QL_LopSinhVien;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbgp_NhanSu;
        private DevExpress.XtraBars.BarButtonItem btn_QL_MonHoc;
        private DevExpress.XtraBars.BarButtonItem btn_QL_GiangVien;
        private DevExpress.XtraBars.BarButtonItem btn_QL_SinhVien;
        private DevExpress.XtraBars.BarButtonItem btn_DangNhap100;
        private System.Windows.Forms.TabControl tabControl1;
        private DevExpress.XtraBars.BarButtonItem btn_XepLop;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbgp_Lop;
        private DevExpress.XtraBars.BarButtonItem btn_QL_TaoLopTinChi;
        private DevExpress.XtraBars.BarButtonItem btn_DangXuat100;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssl_Ma;
        private DevExpress.XtraBars.BarButtonItem btn_XepLopTinChi;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem btn_DangNhap;
        private DevExpress.XtraBars.BarButtonItem btn_DangXuat;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup tbgp_TaiKhoan;
        private DevExpress.XtraBars.BarButtonItem btn_DoiMatKhau;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbpg_MonHoc;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbpg_Lop;
        private DevExpress.XtraBars.BarButtonItem btn_NhapDiem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbpg_Diem;
    }
}