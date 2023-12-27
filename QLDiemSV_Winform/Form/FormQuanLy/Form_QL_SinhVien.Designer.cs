namespace QLDiemSV_Winform.Form
{
    partial class Form_QL_SinhVien
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
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Khoa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Chon = new System.Windows.Forms.Button();
            this.txt_Lop = new System.Windows.Forms.TextBox();
            this.lbl_SoLuong = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgv_SinhVien = new System.Windows.Forms.DataGridView();
            this.MaSv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pn_FormNhap = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.btn_XacNhan = new System.Windows.Forms.Button();
            this.lbl_Ma = new System.Windows.Forms.Label();
            this.txt_Ma = new System.Windows.Forms.TextBox();
            this.lbl_error_SDT = new System.Windows.Forms.Label();
            this.lb_Ho = new System.Windows.Forms.Label();
            this.lbl_error_DiaChi = new System.Windows.Forms.Label();
            this.txt_Ho = new System.Windows.Forms.TextBox();
            this.lbl_error_Ten = new System.Windows.Forms.Label();
            this.lb_Ten = new System.Windows.Forms.Label();
            this.lbl_error_Ho = new System.Windows.Forms.Label();
            this.txt_Ten = new System.Windows.Forms.TextBox();
            this.lb_DiaChi = new System.Windows.Forms.Label();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.lb_SDT = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SinhVien)).BeginInit();
            this.pn_FormNhap.SuspendLayout();
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
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txt_Khoa);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btn_Chon);
            this.panel2.Controls.Add(this.txt_Lop);
            this.panel2.Controls.Add(this.lbl_SoLuong);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(954, 74);
            this.panel2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Khoa:";
            // 
            // txt_Khoa
            // 
            this.txt_Khoa.Location = new System.Drawing.Point(46, 6);
            this.txt_Khoa.Name = "txt_Khoa";
            this.txt_Khoa.ReadOnly = true;
            this.txt_Khoa.Size = new System.Drawing.Size(207, 21);
            this.txt_Khoa.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Lớp:";
            // 
            // btn_Chon
            // 
            this.btn_Chon.Location = new System.Drawing.Point(259, 27);
            this.btn_Chon.Name = "btn_Chon";
            this.btn_Chon.Size = new System.Drawing.Size(75, 23);
            this.btn_Chon.TabIndex = 7;
            this.btn_Chon.Text = "Chọn Lớp";
            this.btn_Chon.UseVisualStyleBackColor = true;
            this.btn_Chon.Click += new System.EventHandler(this.btn_Chon_Click);
            // 
            // txt_Lop
            // 
            this.txt_Lop.Location = new System.Drawing.Point(46, 29);
            this.txt_Lop.Name = "txt_Lop";
            this.txt_Lop.ReadOnly = true;
            this.txt_Lop.Size = new System.Drawing.Size(207, 21);
            this.txt_Lop.TabIndex = 6;
            // 
            // lbl_SoLuong
            // 
            this.lbl_SoLuong.AutoSize = true;
            this.lbl_SoLuong.Location = new System.Drawing.Point(73, 53);
            this.lbl_SoLuong.Name = "lbl_SoLuong";
            this.lbl_SoLuong.Size = new System.Drawing.Size(64, 13);
            this.lbl_SoLuong.TabIndex = 5;
            this.lbl_SoLuong.Text = "lbl_SoLuong";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Số Lượng:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 106);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(954, 397);
            this.panel3.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgv_SinhVien);
            this.panel4.Controls.Add(this.pn_FormNhap);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(954, 397);
            this.panel4.TabIndex = 9;
            // 
            // dgv_SinhVien
            // 
            this.dgv_SinhVien.AllowUserToOrderColumns = true;
            this.dgv_SinhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_SinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSv,
            this.Ho,
            this.Ten,
            this.DiaChi,
            this.SDT});
            this.dgv_SinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_SinhVien.Location = new System.Drawing.Point(0, 0);
            this.dgv_SinhVien.MultiSelect = false;
            this.dgv_SinhVien.Name = "dgv_SinhVien";
            this.dgv_SinhVien.ReadOnly = true;
            this.dgv_SinhVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_SinhVien.Size = new System.Drawing.Size(617, 397);
            this.dgv_SinhVien.TabIndex = 7;
            this.dgv_SinhVien.TabStop = false;
            this.dgv_SinhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SinhVien_CellClick);
            // 
            // MaSv
            // 
            this.MaSv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaSv.DataPropertyName = "maSv";
            this.MaSv.HeaderText = "Mã Sinh Viên";
            this.MaSv.MaxInputLength = 10;
            this.MaSv.Name = "MaSv";
            this.MaSv.ReadOnly = true;
            this.MaSv.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaSv.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Ho
            // 
            this.Ho.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ho.DataPropertyName = "ho";
            this.Ho.HeaderText = "Họ";
            this.Ho.MaxInputLength = 20;
            this.Ho.Name = "Ho";
            this.Ho.ReadOnly = true;
            this.Ho.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Ten
            // 
            this.Ten.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ten.DataPropertyName = "ten";
            this.Ten.HeaderText = "Tên";
            this.Ten.MaxInputLength = 10;
            this.Ten.Name = "Ten";
            this.Ten.ReadOnly = true;
            this.Ten.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DiaChi
            // 
            this.DiaChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DiaChi.DataPropertyName = "diaChi";
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.ReadOnly = true;
            this.DiaChi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // SDT
            // 
            this.SDT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SDT.DataPropertyName = "sdt";
            this.SDT.HeaderText = "SDT";
            this.SDT.MaxInputLength = 14;
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            this.SDT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // pn_FormNhap
            // 
            this.pn_FormNhap.Controls.Add(this.panel6);
            this.pn_FormNhap.Controls.Add(this.btn_Huy);
            this.pn_FormNhap.Controls.Add(this.btn_XacNhan);
            this.pn_FormNhap.Controls.Add(this.lbl_Ma);
            this.pn_FormNhap.Controls.Add(this.txt_Ma);
            this.pn_FormNhap.Controls.Add(this.lbl_error_SDT);
            this.pn_FormNhap.Controls.Add(this.lb_Ho);
            this.pn_FormNhap.Controls.Add(this.lbl_error_DiaChi);
            this.pn_FormNhap.Controls.Add(this.txt_Ho);
            this.pn_FormNhap.Controls.Add(this.lbl_error_Ten);
            this.pn_FormNhap.Controls.Add(this.lb_Ten);
            this.pn_FormNhap.Controls.Add(this.lbl_error_Ho);
            this.pn_FormNhap.Controls.Add(this.txt_Ten);
            this.pn_FormNhap.Controls.Add(this.lb_DiaChi);
            this.pn_FormNhap.Controls.Add(this.txt_DiaChi);
            this.pn_FormNhap.Controls.Add(this.txt_SDT);
            this.pn_FormNhap.Controls.Add(this.lb_SDT);
            this.pn_FormNhap.Dock = System.Windows.Forms.DockStyle.Right;
            this.pn_FormNhap.Location = new System.Drawing.Point(617, 0);
            this.pn_FormNhap.Name = "pn_FormNhap";
            this.pn_FormNhap.Size = new System.Drawing.Size(337, 397);
            this.pn_FormNhap.TabIndex = 20;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btn_Xoa);
            this.panel6.Controls.Add(this.btn_Sua);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(337, 38);
            this.panel6.TabIndex = 24;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Xoa.Location = new System.Drawing.Point(187, 0);
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
            this.btn_Sua.Location = new System.Drawing.Point(262, 0);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 38);
            this.btn_Sua.TabIndex = 1;
            this.btn_Sua.Text = "Chỉnh Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Huy
            // 
            this.btn_Huy.Location = new System.Drawing.Point(99, 327);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(75, 23);
            this.btn_Huy.TabIndex = 22;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.UseVisualStyleBackColor = true;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // btn_XacNhan
            // 
            this.btn_XacNhan.Location = new System.Drawing.Point(7, 327);
            this.btn_XacNhan.Name = "btn_XacNhan";
            this.btn_XacNhan.Size = new System.Drawing.Size(75, 23);
            this.btn_XacNhan.TabIndex = 21;
            this.btn_XacNhan.Text = "Xác Nhận";
            this.btn_XacNhan.UseVisualStyleBackColor = true;
            this.btn_XacNhan.Click += new System.EventHandler(this.btn_XacNhan_Click);
            // 
            // lbl_Ma
            // 
            this.lbl_Ma.AutoSize = true;
            this.lbl_Ma.Location = new System.Drawing.Point(3, 82);
            this.lbl_Ma.Name = "lbl_Ma";
            this.lbl_Ma.Size = new System.Drawing.Size(71, 13);
            this.lbl_Ma.TabIndex = 19;
            this.lbl_Ma.Text = "Mã Sinh Viên:";
            // 
            // txt_Ma
            // 
            this.txt_Ma.Location = new System.Drawing.Point(99, 79);
            this.txt_Ma.MaxLength = 20;
            this.txt_Ma.Name = "txt_Ma";
            this.txt_Ma.ReadOnly = true;
            this.txt_Ma.Size = new System.Drawing.Size(100, 21);
            this.txt_Ma.TabIndex = 20;
            // 
            // lbl_error_SDT
            // 
            this.lbl_error_SDT.AutoSize = true;
            this.lbl_error_SDT.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_SDT.Location = new System.Drawing.Point(98, 299);
            this.lbl_error_SDT.Name = "lbl_error_SDT";
            this.lbl_error_SDT.Size = new System.Drawing.Size(72, 13);
            this.lbl_error_SDT.TabIndex = 18;
            this.lbl_error_SDT.Text = "lbl_error_SDT";
            this.lbl_error_SDT.Visible = false;
            // 
            // lb_Ho
            // 
            this.lb_Ho.AutoSize = true;
            this.lb_Ho.Location = new System.Drawing.Point(3, 123);
            this.lb_Ho.Name = "lb_Ho";
            this.lb_Ho.Size = new System.Drawing.Size(24, 13);
            this.lb_Ho.TabIndex = 4;
            this.lb_Ho.Text = "Họ:";
            // 
            // lbl_error_DiaChi
            // 
            this.lbl_error_DiaChi.AutoSize = true;
            this.lbl_error_DiaChi.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_DiaChi.Location = new System.Drawing.Point(98, 250);
            this.lbl_error_DiaChi.Name = "lbl_error_DiaChi";
            this.lbl_error_DiaChi.Size = new System.Drawing.Size(83, 13);
            this.lbl_error_DiaChi.TabIndex = 17;
            this.lbl_error_DiaChi.Text = "lbl_error_DiaChi";
            this.lbl_error_DiaChi.Visible = false;
            // 
            // txt_Ho
            // 
            this.txt_Ho.Location = new System.Drawing.Point(99, 125);
            this.txt_Ho.MaxLength = 20;
            this.txt_Ho.Name = "txt_Ho";
            this.txt_Ho.Size = new System.Drawing.Size(165, 21);
            this.txt_Ho.TabIndex = 5;
            this.txt_Ho.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Ho_KeyPress);
            this.txt_Ho.Leave += new System.EventHandler(this.txt_Ho_Leave);
            // 
            // lbl_error_Ten
            // 
            this.lbl_error_Ten.AutoSize = true;
            this.lbl_error_Ten.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_Ten.Location = new System.Drawing.Point(96, 199);
            this.lbl_error_Ten.Name = "lbl_error_Ten";
            this.lbl_error_Ten.Size = new System.Drawing.Size(71, 13);
            this.lbl_error_Ten.TabIndex = 16;
            this.lbl_error_Ten.Text = "lbl_error_Ten";
            this.lbl_error_Ten.Visible = false;
            // 
            // lb_Ten
            // 
            this.lb_Ten.AutoSize = true;
            this.lb_Ten.Location = new System.Drawing.Point(4, 178);
            this.lb_Ten.Name = "lb_Ten";
            this.lb_Ten.Size = new System.Drawing.Size(29, 13);
            this.lb_Ten.TabIndex = 6;
            this.lb_Ten.Text = "Tên:";
            // 
            // lbl_error_Ho
            // 
            this.lbl_error_Ho.AutoSize = true;
            this.lbl_error_Ho.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_Ho.Location = new System.Drawing.Point(96, 149);
            this.lbl_error_Ho.Name = "lbl_error_Ho";
            this.lbl_error_Ho.Size = new System.Drawing.Size(66, 13);
            this.lbl_error_Ho.TabIndex = 15;
            this.lbl_error_Ho.Text = "lbl_error_Ho";
            this.lbl_error_Ho.Visible = false;
            // 
            // txt_Ten
            // 
            this.txt_Ten.Location = new System.Drawing.Point(99, 175);
            this.txt_Ten.MaxLength = 10;
            this.txt_Ten.Name = "txt_Ten";
            this.txt_Ten.Size = new System.Drawing.Size(100, 21);
            this.txt_Ten.TabIndex = 7;
            this.txt_Ten.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Ten_KeyPress);
            this.txt_Ten.Leave += new System.EventHandler(this.txt_Ten_Leave);
            // 
            // lb_DiaChi
            // 
            this.lb_DiaChi.AutoSize = true;
            this.lb_DiaChi.Location = new System.Drawing.Point(3, 229);
            this.lb_DiaChi.Name = "lb_DiaChi";
            this.lb_DiaChi.Size = new System.Drawing.Size(43, 13);
            this.lb_DiaChi.TabIndex = 8;
            this.lb_DiaChi.Text = "Địa chỉ:";
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(99, 226);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(165, 21);
            this.txt_DiaChi.TabIndex = 9;
            this.txt_DiaChi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_DiaChi_KeyPress);
            this.txt_DiaChi.Leave += new System.EventHandler(this.txt_DiaChi_Leave);
            // 
            // txt_SDT
            // 
            this.txt_SDT.Location = new System.Drawing.Point(99, 275);
            this.txt_SDT.MaxLength = 14;
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(100, 21);
            this.txt_SDT.TabIndex = 11;
            this.txt_SDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SDT_KeyPress);
            // 
            // lb_SDT
            // 
            this.lb_SDT.AutoSize = true;
            this.lb_SDT.Location = new System.Drawing.Point(4, 278);
            this.lb_SDT.Name = "lb_SDT";
            this.lb_SDT.Size = new System.Drawing.Size(30, 13);
            this.lb_SDT.TabIndex = 10;
            this.lb_SDT.Text = "SDT:";
            // 
            // Form_QL_SinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 503);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form_QL_SinhVien";
            this.Text = "Form_QL_SinhVien";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SinhVien)).EndInit();
            this.pn_FormNhap.ResumeLayout(false);
            this.pn_FormNhap.PerformLayout();
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
        private System.Windows.Forms.Button btn_Chon;
        private System.Windows.Forms.TextBox txt_Lop;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgv_SinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ho;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel pn_FormNhap;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.Button btn_XacNhan;
        private System.Windows.Forms.Label lbl_Ma;
        private System.Windows.Forms.TextBox txt_Ma;
        private System.Windows.Forms.Label lbl_error_SDT;
        private System.Windows.Forms.Label lb_Ho;
        private System.Windows.Forms.Label lbl_error_DiaChi;
        private System.Windows.Forms.TextBox txt_Ho;
        private System.Windows.Forms.Label lbl_error_Ten;
        private System.Windows.Forms.Label lb_Ten;
        private System.Windows.Forms.Label lbl_error_Ho;
        private System.Windows.Forms.TextBox txt_Ten;
        private System.Windows.Forms.Label lb_DiaChi;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.Label lb_SDT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Khoa;
    }
}