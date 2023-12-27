namespace QLDiemSV_Winform.Form
{
    partial class Form_QL_MonHoc
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_SoLuong = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgv_MonHoc = new System.Windows.Forms.DataGridView();
            this.maMh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenMh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tschuyenCan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsbaiTap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tskiemTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsthucHanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsthi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soTc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_TongTrongSo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_error_SoTinChi = new System.Windows.Forms.Label();
            this.txt_SoTinChi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_error_TS = new System.Windows.Forms.Label();
            this.txt_Thi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_TH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_KT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_BT = new System.Windows.Forms.TextBox();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.btn_XacNhan = new System.Windows.Forms.Button();
            this.lbl_Ma = new System.Windows.Forms.Label();
            this.txt_Ma = new System.Windows.Forms.TextBox();
            this.lbl_Ten = new System.Windows.Forms.Label();
            this.txt_Ten = new System.Windows.Forms.TextBox();
            this.lbl_error_Ten = new System.Windows.Forms.Label();
            this.lb_Ten = new System.Windows.Forms.Label();
            this.txt_CC = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.lbl_error_XacNhan = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MonHoc)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Thoat);
            this.panel1.Controls.Add(this.btn_Them);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 32);
            this.panel1.TabIndex = 3;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Thoat.Location = new System.Drawing.Point(879, 0);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(75, 32);
            this.btn_Thoat.TabIndex = 2;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Them.Location = new System.Drawing.Point(0, 0);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(75, 32);
            this.btn_Them.TabIndex = 0;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.lbl_SoLuong);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(954, 22);
            this.panel2.TabIndex = 6;
            // 
            // lbl_SoLuong
            // 
            this.lbl_SoLuong.AutoSize = true;
            this.lbl_SoLuong.Location = new System.Drawing.Point(67, 3);
            this.lbl_SoLuong.Name = "lbl_SoLuong";
            this.lbl_SoLuong.Size = new System.Drawing.Size(64, 13);
            this.lbl_SoLuong.TabIndex = 7;
            this.lbl_SoLuong.Text = "lbl_SoLuong";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Số Lượng:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgv_MonHoc);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 54);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(954, 449);
            this.panel3.TabIndex = 8;
            // 
            // dgv_MonHoc
            // 
            this.dgv_MonHoc.AllowUserToOrderColumns = true;
            this.dgv_MonHoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_MonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_MonHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maMh,
            this.tenMh,
            this.tschuyenCan,
            this.tsbaiTap,
            this.tskiemTra,
            this.tsthucHanh,
            this.tsthi,
            this.soTc});
            this.dgv_MonHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_MonHoc.Location = new System.Drawing.Point(0, 0);
            this.dgv_MonHoc.MultiSelect = false;
            this.dgv_MonHoc.Name = "dgv_MonHoc";
            this.dgv_MonHoc.ReadOnly = true;
            this.dgv_MonHoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_MonHoc.Size = new System.Drawing.Size(657, 449);
            this.dgv_MonHoc.TabIndex = 11;
            this.dgv_MonHoc.TabStop = false;
            this.dgv_MonHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_MonHoc_CellClick);
            // 
            // maMh
            // 
            this.maMh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maMh.DataPropertyName = "maMh";
            this.maMh.HeaderText = "Mã môn học";
            this.maMh.MaxInputLength = 10;
            this.maMh.Name = "maMh";
            this.maMh.ReadOnly = true;
            this.maMh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // tenMh
            // 
            this.tenMh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tenMh.DataPropertyName = "tenMh";
            this.tenMh.HeaderText = "Tên môc học";
            this.tenMh.MaxInputLength = 10;
            this.tenMh.Name = "tenMh";
            this.tenMh.ReadOnly = true;
            this.tenMh.Width = 92;
            // 
            // tschuyenCan
            // 
            this.tschuyenCan.DataPropertyName = "tschuyenCan";
            this.tschuyenCan.HeaderText = "TS chuyên cần";
            this.tschuyenCan.Name = "tschuyenCan";
            this.tschuyenCan.ReadOnly = true;
            // 
            // tsbaiTap
            // 
            this.tsbaiTap.DataPropertyName = "tsbaiTap";
            this.tsbaiTap.HeaderText = "TS bài tập";
            this.tsbaiTap.Name = "tsbaiTap";
            this.tsbaiTap.ReadOnly = true;
            // 
            // tskiemTra
            // 
            this.tskiemTra.DataPropertyName = "tskiemTra";
            this.tskiemTra.HeaderText = "TS kiểm tra";
            this.tskiemTra.Name = "tskiemTra";
            this.tskiemTra.ReadOnly = true;
            // 
            // tsthucHanh
            // 
            this.tsthucHanh.DataPropertyName = "tsthucHanh";
            this.tsthucHanh.HeaderText = "TS thực hành";
            this.tsthucHanh.Name = "tsthucHanh";
            this.tsthucHanh.ReadOnly = true;
            // 
            // tsthi
            // 
            this.tsthi.DataPropertyName = "tsthi";
            this.tsthi.HeaderText = "TS thi";
            this.tsthi.Name = "tsthi";
            this.tsthi.ReadOnly = true;
            // 
            // soTc
            // 
            this.soTc.DataPropertyName = "soTc";
            this.soTc.HeaderText = "Số tín chỉ";
            this.soTc.Name = "soTc";
            this.soTc.ReadOnly = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lbl_error_XacNhan);
            this.panel4.Controls.Add(this.lbl_TongTrongSo);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.lbl_error_SoTinChi);
            this.panel4.Controls.Add(this.txt_SoTinChi);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.lbl_error_TS);
            this.panel4.Controls.Add(this.txt_Thi);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.txt_TH);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.txt_KT);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.txt_BT);
            this.panel4.Controls.Add(this.btn_Huy);
            this.panel4.Controls.Add(this.btn_XacNhan);
            this.panel4.Controls.Add(this.lbl_Ma);
            this.panel4.Controls.Add(this.txt_Ma);
            this.panel4.Controls.Add(this.lbl_Ten);
            this.panel4.Controls.Add(this.txt_Ten);
            this.panel4.Controls.Add(this.lbl_error_Ten);
            this.panel4.Controls.Add(this.lb_Ten);
            this.panel4.Controls.Add(this.txt_CC);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(657, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(297, 449);
            this.panel4.TabIndex = 10;
            // 
            // lbl_TongTrongSo
            // 
            this.lbl_TongTrongSo.AutoSize = true;
            this.lbl_TongTrongSo.Location = new System.Drawing.Point(109, 221);
            this.lbl_TongTrongSo.Name = "lbl_TongTrongSo";
            this.lbl_TongTrongSo.Size = new System.Drawing.Size(87, 13);
            this.lbl_TongTrongSo.TabIndex = 56;
            this.lbl_TongTrongSo.Text = "lbl_TongTrongSo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 55;
            this.label3.Text = "Tổng trọng số:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 266);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 52;
            this.label10.Text = "Số tín chỉ:";
            // 
            // lbl_error_SoTinChi
            // 
            this.lbl_error_SoTinChi.AutoSize = true;
            this.lbl_error_SoTinChi.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_SoTinChi.Location = new System.Drawing.Point(18, 287);
            this.lbl_error_SoTinChi.Name = "lbl_error_SoTinChi";
            this.lbl_error_SoTinChi.Size = new System.Drawing.Size(94, 13);
            this.lbl_error_SoTinChi.TabIndex = 54;
            this.lbl_error_SoTinChi.Text = "lbl_error_SoTinChi";
            this.lbl_error_SoTinChi.Visible = false;
            // 
            // txt_SoTinChi
            // 
            this.txt_SoTinChi.Location = new System.Drawing.Point(78, 263);
            this.txt_SoTinChi.MaxLength = 1;
            this.txt_SoTinChi.Name = "txt_SoTinChi";
            this.txt_SoTinChi.Size = new System.Drawing.Size(39, 21);
            this.txt_SoTinChi.TabIndex = 53;
            this.txt_SoTinChi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SoTinChi_KeyPress);
            this.txt_SoTinChi.Leave += new System.EventHandler(this.txt_SoTinChi_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(201, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 49;
            this.label8.Text = "Thi";
            // 
            // lbl_error_TS
            // 
            this.lbl_error_TS.AutoSize = true;
            this.lbl_error_TS.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_TS.Location = new System.Drawing.Point(21, 204);
            this.lbl_error_TS.Name = "lbl_error_TS";
            this.lbl_error_TS.Size = new System.Drawing.Size(65, 13);
            this.lbl_error_TS.TabIndex = 51;
            this.lbl_error_TS.Text = "lbl_error_TS";
            this.lbl_error_TS.Visible = false;
            // 
            // txt_Thi
            // 
            this.txt_Thi.Location = new System.Drawing.Point(201, 180);
            this.txt_Thi.MaxLength = 3;
            this.txt_Thi.Name = "txt_Thi";
            this.txt_Thi.Size = new System.Drawing.Size(40, 21);
            this.txt_Thi.TabIndex = 50;
            this.txt_Thi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Thi_KeyPress);
            this.txt_Thi.Leave += new System.EventHandler(this.txt_Thi_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(158, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "TH";
            // 
            // txt_TH
            // 
            this.txt_TH.Location = new System.Drawing.Point(156, 180);
            this.txt_TH.MaxLength = 3;
            this.txt_TH.Name = "txt_TH";
            this.txt_TH.Size = new System.Drawing.Size(40, 21);
            this.txt_TH.TabIndex = 47;
            this.txt_TH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_TH_KeyPress);
            this.txt_TH.Leave += new System.EventHandler(this.txt_TH_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(113, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "KT";
            // 
            // txt_KT
            // 
            this.txt_KT.Location = new System.Drawing.Point(111, 180);
            this.txt_KT.MaxLength = 3;
            this.txt_KT.Name = "txt_KT";
            this.txt_KT.Size = new System.Drawing.Size(40, 21);
            this.txt_KT.TabIndex = 44;
            this.txt_KT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KT_KeyPress);
            this.txt_KT.Leave += new System.EventHandler(this.txt_KT_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "BT";
            // 
            // txt_BT
            // 
            this.txt_BT.Location = new System.Drawing.Point(66, 180);
            this.txt_BT.MaxLength = 3;
            this.txt_BT.Name = "txt_BT";
            this.txt_BT.Size = new System.Drawing.Size(40, 21);
            this.txt_BT.TabIndex = 41;
            this.txt_BT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_BT_KeyPress);
            this.txt_BT.Leave += new System.EventHandler(this.txt_BT_Leave);
            // 
            // btn_Huy
            // 
            this.btn_Huy.Location = new System.Drawing.Point(107, 324);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(75, 23);
            this.btn_Huy.TabIndex = 39;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.UseVisualStyleBackColor = true;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // btn_XacNhan
            // 
            this.btn_XacNhan.Location = new System.Drawing.Point(21, 324);
            this.btn_XacNhan.Name = "btn_XacNhan";
            this.btn_XacNhan.Size = new System.Drawing.Size(75, 23);
            this.btn_XacNhan.TabIndex = 38;
            this.btn_XacNhan.Text = "Xác Nhận";
            this.btn_XacNhan.UseVisualStyleBackColor = true;
            this.btn_XacNhan.Click += new System.EventHandler(this.btn_XacNhan_Click);
            // 
            // lbl_Ma
            // 
            this.lbl_Ma.AutoSize = true;
            this.lbl_Ma.Location = new System.Drawing.Point(18, 71);
            this.lbl_Ma.Name = "lbl_Ma";
            this.lbl_Ma.Size = new System.Drawing.Size(68, 13);
            this.lbl_Ma.TabIndex = 36;
            this.lbl_Ma.Text = "Mã môn học:";
            // 
            // txt_Ma
            // 
            this.txt_Ma.Location = new System.Drawing.Point(114, 68);
            this.txt_Ma.MaxLength = 20;
            this.txt_Ma.Name = "txt_Ma";
            this.txt_Ma.ReadOnly = true;
            this.txt_Ma.Size = new System.Drawing.Size(100, 21);
            this.txt_Ma.TabIndex = 37;
            // 
            // lbl_Ten
            // 
            this.lbl_Ten.AutoSize = true;
            this.lbl_Ten.Location = new System.Drawing.Point(18, 112);
            this.lbl_Ten.Name = "lbl_Ten";
            this.lbl_Ten.Size = new System.Drawing.Size(72, 13);
            this.lbl_Ten.TabIndex = 24;
            this.lbl_Ten.Text = "Tên môn học:";
            // 
            // txt_Ten
            // 
            this.txt_Ten.Location = new System.Drawing.Point(114, 114);
            this.txt_Ten.MaxLength = 50;
            this.txt_Ten.Name = "txt_Ten";
            this.txt_Ten.Size = new System.Drawing.Size(165, 21);
            this.txt_Ten.TabIndex = 25;
            this.txt_Ten.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Ten_KeyPress);
            this.txt_Ten.Leave += new System.EventHandler(this.txt_Ten_Leave);
            // 
            // lbl_error_Ten
            // 
            this.lbl_error_Ten.AutoSize = true;
            this.lbl_error_Ten.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_Ten.Location = new System.Drawing.Point(111, 138);
            this.lbl_error_Ten.Name = "lbl_error_Ten";
            this.lbl_error_Ten.Size = new System.Drawing.Size(71, 13);
            this.lbl_error_Ten.TabIndex = 33;
            this.lbl_error_Ten.Text = "lbl_error_Ten";
            this.lbl_error_Ten.Visible = false;
            // 
            // lb_Ten
            // 
            this.lb_Ten.AutoSize = true;
            this.lb_Ten.Location = new System.Drawing.Point(19, 164);
            this.lb_Ten.Name = "lb_Ten";
            this.lb_Ten.Size = new System.Drawing.Size(21, 13);
            this.lb_Ten.TabIndex = 26;
            this.lb_Ten.Text = "CC";
            // 
            // txt_CC
            // 
            this.txt_CC.Location = new System.Drawing.Point(21, 180);
            this.txt_CC.MaxLength = 3;
            this.txt_CC.Name = "txt_CC";
            this.txt_CC.Size = new System.Drawing.Size(40, 21);
            this.txt_CC.TabIndex = 27;
            this.txt_CC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CC_KeyPress);
            this.txt_CC.Leave += new System.EventHandler(this.txt_CC_Leave);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btn_Xoa);
            this.panel6.Controls.Add(this.btn_Sua);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(297, 38);
            this.panel6.TabIndex = 21;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Xoa.Location = new System.Drawing.Point(147, 0);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 38);
            this.btn_Xoa.TabIndex = 2;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Sua.Location = new System.Drawing.Point(222, 0);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 38);
            this.btn_Sua.TabIndex = 1;
            this.btn_Sua.Text = "Chỉnh Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // lbl_error_XacNhan
            // 
            this.lbl_error_XacNhan.AutoSize = true;
            this.lbl_error_XacNhan.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_XacNhan.Location = new System.Drawing.Point(18, 350);
            this.lbl_error_XacNhan.Name = "lbl_error_XacNhan";
            this.lbl_error_XacNhan.Size = new System.Drawing.Size(95, 13);
            this.lbl_error_XacNhan.TabIndex = 57;
            this.lbl_error_XacNhan.Text = "lbl_error_XacNhan";
            this.lbl_error_XacNhan.Visible = false;
            // 
            // Form_QL_MonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 503);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form_QL_MonHoc";
            this.Text = "Form_QL_MonHoc";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MonHoc)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_SoLuong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgv_MonHoc;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.Button btn_XacNhan;
        private System.Windows.Forms.Label lbl_Ma;
        private System.Windows.Forms.TextBox txt_Ma;
        private System.Windows.Forms.Label lbl_Ten;
        private System.Windows.Forms.TextBox txt_Ten;
        private System.Windows.Forms.Label lbl_error_Ten;
        private System.Windows.Forms.Label lb_Ten;
        private System.Windows.Forms.TextBox txt_CC;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_error_SoTinChi;
        private System.Windows.Forms.TextBox txt_SoTinChi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_error_TS;
        private System.Windows.Forms.TextBox txt_Thi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_TH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_KT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_BT;
        private System.Windows.Forms.Label lbl_TongTrongSo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn maMh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenMh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tschuyenCan;
        private System.Windows.Forms.DataGridViewTextBoxColumn tsbaiTap;
        private System.Windows.Forms.DataGridViewTextBoxColumn tskiemTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn tsthucHanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tsthi;
        private System.Windows.Forms.DataGridViewTextBoxColumn soTc;
        private System.Windows.Forms.Label lbl_error_XacNhan;
    }
}