namespace QLDiemSV_Winform.Form
{
    partial class Form_QL_GiangVien
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
            this.btn_Sua = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.pn_FormNhap = new System.Windows.Forms.Panel();
            this.cb_ChucVu = new System.Windows.Forms.CheckBox();
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
            this.cmb_Khoa = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_SoLuong = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgv_GiangVien = new System.Windows.Forms.DataGridView();
            this.maGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.pn_FormNhap.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GiangVien)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            // panel3
            // 
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.pn_FormNhap);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(617, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(337, 421);
            this.panel3.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btn_Xoa);
            this.panel6.Controls.Add(this.btn_Sua);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(337, 38);
            this.panel6.TabIndex = 20;
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
            // pn_FormNhap
            // 
            this.pn_FormNhap.Controls.Add(this.cb_ChucVu);
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
            this.pn_FormNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_FormNhap.Location = new System.Drawing.Point(0, 0);
            this.pn_FormNhap.Name = "pn_FormNhap";
            this.pn_FormNhap.Size = new System.Drawing.Size(337, 421);
            this.pn_FormNhap.TabIndex = 19;
            // 
            // cb_ChucVu
            // 
            this.cb_ChucVu.AutoSize = true;
            this.cb_ChucVu.Location = new System.Drawing.Point(99, 328);
            this.cb_ChucVu.Name = "cb_ChucVu";
            this.cb_ChucVu.Size = new System.Drawing.Size(74, 17);
            this.cb_ChucVu.TabIndex = 23;
            this.cb_ChucVu.Text = "Nhân viên";
            this.cb_ChucVu.UseVisualStyleBackColor = true;
            // 
            // btn_Huy
            // 
            this.btn_Huy.Location = new System.Drawing.Point(101, 367);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(75, 23);
            this.btn_Huy.TabIndex = 22;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.UseVisualStyleBackColor = true;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // btn_XacNhan
            // 
            this.btn_XacNhan.Location = new System.Drawing.Point(7, 367);
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
            this.lbl_Ma.Size = new System.Drawing.Size(78, 13);
            this.lbl_Ma.TabIndex = 19;
            this.lbl_Ma.Text = "Mã Giảng Viên:";
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
            // cmb_Khoa
            // 
            this.cmb_Khoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Khoa.FormattingEnabled = true;
            this.cmb_Khoa.Location = new System.Drawing.Point(53, 6);
            this.cmb_Khoa.Name = "cmb_Khoa";
            this.cmb_Khoa.Size = new System.Drawing.Size(138, 21);
            this.cmb_Khoa.TabIndex = 3;
            this.cmb_Khoa.SelectedIndexChanged += new System.EventHandler(this.cmb_Khoa_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lbl_SoLuong);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cmb_Khoa);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(954, 50);
            this.panel2.TabIndex = 4;
            // 
            // lbl_SoLuong
            // 
            this.lbl_SoLuong.AutoSize = true;
            this.lbl_SoLuong.Location = new System.Drawing.Point(74, 30);
            this.lbl_SoLuong.Name = "lbl_SoLuong";
            this.lbl_SoLuong.Size = new System.Drawing.Size(64, 13);
            this.lbl_SoLuong.TabIndex = 5;
            this.lbl_SoLuong.Text = "lbl_SoLuong";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Số Lượng:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgv_GiangVien);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 82);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(954, 421);
            this.panel4.TabIndex = 7;
            // 
            // dgv_GiangVien
            // 
            this.dgv_GiangVien.AllowUserToOrderColumns = true;
            this.dgv_GiangVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_GiangVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_GiangVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maGv,
            this.Ho,
            this.Ten,
            this.DiaChi,
            this.SDT,
            this.ChucVu});
            this.dgv_GiangVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_GiangVien.Location = new System.Drawing.Point(0, 0);
            this.dgv_GiangVien.MultiSelect = false;
            this.dgv_GiangVien.Name = "dgv_GiangVien";
            this.dgv_GiangVien.ReadOnly = true;
            this.dgv_GiangVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_GiangVien.Size = new System.Drawing.Size(617, 421);
            this.dgv_GiangVien.TabIndex = 6;
            this.dgv_GiangVien.TabStop = false;
            this.dgv_GiangVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_GiangVien_CellClick);
            // 
            // maGv
            // 
            this.maGv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maGv.DataPropertyName = "maGv";
            this.maGv.HeaderText = "Mã Giảng Viên";
            this.maGv.MaxInputLength = 10;
            this.maGv.Name = "maGv";
            this.maGv.ReadOnly = true;
            this.maGv.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.maGv.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            // ChucVu
            // 
            this.ChucVu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ChucVu.DataPropertyName = "chucVu";
            this.ChucVu.HeaderText = "Chức Vụ";
            this.ChucVu.MaxInputLength = 50;
            this.ChucVu.Name = "ChucVu";
            this.ChucVu.ReadOnly = true;
            this.ChucVu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Khoa:";
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
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Thoat);
            this.panel1.Controls.Add(this.btn_Them);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 32);
            this.panel1.TabIndex = 2;
            // 
            // Form_QL_GiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 503);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form_QL_GiangVien";
            this.Text = "Form_QL_GiangVien";
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.pn_FormNhap.ResumeLayout(false);
            this.pn_FormNhap.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GiangVien)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cmb_Khoa;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txt_Ho;
        private System.Windows.Forms.Label lb_Ho;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.Label lb_SDT;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.Label lb_DiaChi;
        private System.Windows.Forms.TextBox txt_Ten;
        private System.Windows.Forms.Label lb_Ten;
        private System.Windows.Forms.Label lbl_error_Ten;
        private System.Windows.Forms.Label lbl_error_Ho;
        private System.Windows.Forms.Label lbl_error_SDT;
        private System.Windows.Forms.Label lbl_error_DiaChi;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel pn_FormNhap;
        private System.Windows.Forms.Label lbl_Ma;
        private System.Windows.Forms.TextBox txt_Ma;
        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.Button btn_XacNhan;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.CheckBox cb_ChucVu;
        private System.Windows.Forms.DataGridView dgv_GiangVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn maGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ho;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChucVu;
        private System.Windows.Forms.Label lbl_SoLuong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Panel panel1;
    }
}