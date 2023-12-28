namespace QLDiemSV_Winform.Form
{
    partial class Form_QL_LopSinhVien
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
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmb_Khoa = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_SoLuong = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pn_FormNhap = new System.Windows.Forms.Panel();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.btn_XacNhan = new System.Windows.Forms.Button();
            this.lbl_Ma = new System.Windows.Forms.Label();
            this.txt_Ma = new System.Windows.Forms.TextBox();
            this.lbl_error_Ten = new System.Windows.Forms.Label();
            this.lb_Ten = new System.Windows.Forms.Label();
            this.txt_Ten = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.dgv_LopSinhVien = new System.Windows.Forms.DataGridView();
            this.maLopSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLopSv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pn_FormNhap.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LopSinhVien)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.TabIndex = 3;
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
            this.panel2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Khoa:";
            // 
            // lbl_SoLuong
            // 
            this.lbl_SoLuong.AutoSize = true;
            this.lbl_SoLuong.Location = new System.Drawing.Point(74, 30);
            this.lbl_SoLuong.Name = "lbl_SoLuong";
            this.lbl_SoLuong.Size = new System.Drawing.Size(64, 13);
            this.lbl_SoLuong.TabIndex = 7;
            this.lbl_SoLuong.Text = "lbl_SoLuong";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Số Lượng:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.dgv_LopSinhVien);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 82);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(954, 421);
            this.panel3.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pn_FormNhap);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(673, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(281, 421);
            this.panel4.TabIndex = 9;
            // 
            // pn_FormNhap
            // 
            this.pn_FormNhap.Controls.Add(this.btn_Huy);
            this.pn_FormNhap.Controls.Add(this.btn_XacNhan);
            this.pn_FormNhap.Controls.Add(this.lbl_Ma);
            this.pn_FormNhap.Controls.Add(this.txt_Ma);
            this.pn_FormNhap.Controls.Add(this.lbl_error_Ten);
            this.pn_FormNhap.Controls.Add(this.lb_Ten);
            this.pn_FormNhap.Controls.Add(this.txt_Ten);
            this.pn_FormNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_FormNhap.Location = new System.Drawing.Point(0, 32);
            this.pn_FormNhap.Name = "pn_FormNhap";
            this.pn_FormNhap.Size = new System.Drawing.Size(281, 389);
            this.pn_FormNhap.TabIndex = 23;
            // 
            // btn_Huy
            // 
            this.btn_Huy.Location = new System.Drawing.Point(101, 178);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(75, 23);
            this.btn_Huy.TabIndex = 22;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.UseVisualStyleBackColor = true;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // btn_XacNhan
            // 
            this.btn_XacNhan.Location = new System.Drawing.Point(9, 178);
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
            this.lbl_Ma.Size = new System.Drawing.Size(87, 13);
            this.lbl_Ma.TabIndex = 19;
            this.lbl_Ma.Text = "Mã Lớp Sinh Viên";
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
            // lbl_error_Ten
            // 
            this.lbl_error_Ten.AutoSize = true;
            this.lbl_error_Ten.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_Ten.Location = new System.Drawing.Point(98, 148);
            this.lbl_error_Ten.Name = "lbl_error_Ten";
            this.lbl_error_Ten.Size = new System.Drawing.Size(71, 13);
            this.lbl_error_Ten.TabIndex = 16;
            this.lbl_error_Ten.Text = "lbl_error_Ten";
            this.lbl_error_Ten.Visible = false;
            // 
            // lb_Ten
            // 
            this.lb_Ten.AutoSize = true;
            this.lb_Ten.Location = new System.Drawing.Point(6, 116);
            this.lb_Ten.Name = "lb_Ten";
            this.lb_Ten.Size = new System.Drawing.Size(49, 13);
            this.lb_Ten.TabIndex = 6;
            this.lb_Ten.Text = "Tên Lớp:";
            // 
            // txt_Ten
            // 
            this.txt_Ten.Location = new System.Drawing.Point(99, 113);
            this.txt_Ten.MaxLength = 50;
            this.txt_Ten.Name = "txt_Ten";
            this.txt_Ten.Size = new System.Drawing.Size(100, 21);
            this.txt_Ten.TabIndex = 7;
            this.txt_Ten.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Ten_KeyPress);
            this.txt_Ten.Leave += new System.EventHandler(this.txt_Ten_Leave);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btn_Xoa);
            this.panel6.Controls.Add(this.btn_Sua);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(281, 32);
            this.panel6.TabIndex = 21;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Xoa.Location = new System.Drawing.Point(131, 0);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 32);
            this.btn_Xoa.TabIndex = 2;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Sua.Location = new System.Drawing.Point(206, 0);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 32);
            this.btn_Sua.TabIndex = 1;
            this.btn_Sua.Text = "Chỉnh Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // dgv_LopSinhVien
            // 
            this.dgv_LopSinhVien.AllowUserToOrderColumns = true;
            this.dgv_LopSinhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_LopSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_LopSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maLopSV,
            this.tenLopSv});
            this.dgv_LopSinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_LopSinhVien.Location = new System.Drawing.Point(0, 0);
            this.dgv_LopSinhVien.MultiSelect = false;
            this.dgv_LopSinhVien.Name = "dgv_LopSinhVien";
            this.dgv_LopSinhVien.ReadOnly = true;
            this.dgv_LopSinhVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_LopSinhVien.Size = new System.Drawing.Size(954, 421);
            this.dgv_LopSinhVien.TabIndex = 8;
            this.dgv_LopSinhVien.TabStop = false;
            this.dgv_LopSinhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_LopSinhVien_CellClick);
            // 
            // maLopSV
            // 
            this.maLopSV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.maLopSV.DataPropertyName = "maLopSV";
            this.maLopSV.HeaderText = "Mã Lớp Sinh Viên";
            this.maLopSV.MaxInputLength = 10;
            this.maLopSV.Name = "maLopSV";
            this.maLopSV.ReadOnly = true;
            this.maLopSV.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.maLopSV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.maLopSV.Width = 66;
            // 
            // tenLopSv
            // 
            this.tenLopSv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenLopSv.DataPropertyName = "tenLopSv";
            this.tenLopSv.HeaderText = "Tên Lớp";
            this.tenLopSv.MaxInputLength = 10;
            this.tenLopSv.Name = "tenLopSv";
            this.tenLopSv.ReadOnly = true;
            this.tenLopSv.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Form_QL_LopSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 503);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form_QL_LopSinhVien";
            this.Text = "Form_QL_LopSinhVien";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.pn_FormNhap.ResumeLayout(false);
            this.pn_FormNhap.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LopSinhVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmb_Khoa;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Label lbl_SoLuong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pn_FormNhap;
        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.Button btn_XacNhan;
        private System.Windows.Forms.Label lbl_Ma;
        private System.Windows.Forms.TextBox txt_Ma;
        private System.Windows.Forms.Label lbl_error_Ten;
        private System.Windows.Forms.Label lb_Ten;
        private System.Windows.Forms.TextBox txt_Ten;
        private System.Windows.Forms.DataGridView dgv_LopSinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLopSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLopSv;
    }
}