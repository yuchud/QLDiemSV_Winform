namespace QLDiemSV_Winform.SubForm
{
    partial class SubForm_Lay_GiangVien
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
            this.btn_XacNhan = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_SoLuong = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_Khoa = new System.Windows.Forms.ComboBox();
            this.dgv_GiangVien = new System.Windows.Forms.DataGridView();
            this.maGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GiangVien)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Thoat);
            this.panel1.Controls.Add(this.btn_XacNhan);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(755, 32);
            this.panel1.TabIndex = 3;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Thoat.Location = new System.Drawing.Point(680, 0);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(75, 32);
            this.btn_Thoat.TabIndex = 2;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            // 
            // btn_XacNhan
            // 
            this.btn_XacNhan.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_XacNhan.Location = new System.Drawing.Point(0, 0);
            this.btn_XacNhan.Name = "btn_XacNhan";
            this.btn_XacNhan.Size = new System.Drawing.Size(75, 32);
            this.btn_XacNhan.TabIndex = 0;
            this.btn_XacNhan.Text = "Xác Nhận";
            this.btn_XacNhan.UseVisualStyleBackColor = true;
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
            this.panel2.Size = new System.Drawing.Size(755, 50);
            this.panel2.TabIndex = 5;
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
            // cmb_Khoa
            // 
            this.cmb_Khoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Khoa.FormattingEnabled = true;
            this.cmb_Khoa.Location = new System.Drawing.Point(53, 6);
            this.cmb_Khoa.Name = "cmb_Khoa";
            this.cmb_Khoa.Size = new System.Drawing.Size(138, 21);
            this.cmb_Khoa.TabIndex = 3;
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
            this.dgv_GiangVien.Location = new System.Drawing.Point(0, 82);
            this.dgv_GiangVien.MultiSelect = false;
            this.dgv_GiangVien.Name = "dgv_GiangVien";
            this.dgv_GiangVien.ReadOnly = true;
            this.dgv_GiangVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_GiangVien.Size = new System.Drawing.Size(755, 352);
            this.dgv_GiangVien.TabIndex = 7;
            this.dgv_GiangVien.TabStop = false;
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
            // SubForm_Lay_GiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 434);
            this.Controls.Add(this.dgv_GiangVien);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "SubForm_Lay_GiangVien";
            this.Text = "SubForm_Lay_GiangVien";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GiangVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_XacNhan;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_SoLuong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_Khoa;
        private System.Windows.Forms.DataGridView dgv_GiangVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn maGv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ho;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChucVu;
    }
}