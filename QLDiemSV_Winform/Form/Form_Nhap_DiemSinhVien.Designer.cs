namespace QLDiemSV_Winform.SubForm
{
    partial class Form_Nhap_DiemSinhVien
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
            this.btn_CapNhat = new System.Windows.Forms.Button();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_error_Diem = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_XacNhan = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Ky = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_MonHoc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Chon = new System.Windows.Forms.Button();
            this.txt_Nam = new System.Windows.Forms.TextBox();
            this.lbl_SoLuong = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_BangDiem = new System.Windows.Forms.DataGridView();
            this.MaSv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chuyenCan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baiTap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kiemTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thucHanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongKet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BangDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Thoat);
            this.panel1.Controls.Add(this.btn_CapNhat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 32);
            this.panel1.TabIndex = 10;
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
            // btn_CapNhat
            // 
            this.btn_CapNhat.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_CapNhat.Location = new System.Drawing.Point(0, 0);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(75, 32);
            this.btn_CapNhat.TabIndex = 0;
            this.btn_CapNhat.Text = "Cập Nhật";
            this.btn_CapNhat.UseVisualStyleBackColor = true;
            this.btn_CapNhat.Click += new System.EventHandler(this.btn_CapNhat_Click);
            // 
            // btn_Huy
            // 
            this.btn_Huy.Location = new System.Drawing.Point(226, 36);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(75, 32);
            this.btn_Huy.TabIndex = 3;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.UseVisualStyleBackColor = true;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.lbl_error_Diem);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txt_Ky);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txt_MonHoc);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btn_Chon);
            this.panel2.Controls.Add(this.txt_Nam);
            this.panel2.Controls.Add(this.lbl_SoLuong);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(954, 74);
            this.panel2.TabIndex = 11;
            // 
            // lbl_error_Diem
            // 
            this.lbl_error_Diem.AutoSize = true;
            this.lbl_error_Diem.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lbl_error_Diem.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_Diem.Location = new System.Drawing.Point(366, 3);
            this.lbl_error_Diem.Name = "lbl_error_Diem";
            this.lbl_error_Diem.Size = new System.Drawing.Size(76, 13);
            this.lbl_error_Diem.TabIndex = 15;
            this.lbl_error_Diem.Text = "lbl_error_Diem";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MistyRose;
            this.panel3.Controls.Add(this.btn_XacNhan);
            this.panel3.Controls.Add(this.btn_Huy);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(650, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(304, 74);
            this.panel3.TabIndex = 14;
            // 
            // btn_XacNhan
            // 
            this.btn_XacNhan.Location = new System.Drawing.Point(3, 36);
            this.btn_XacNhan.Name = "btn_XacNhan";
            this.btn_XacNhan.Size = new System.Drawing.Size(75, 32);
            this.btn_XacNhan.TabIndex = 13;
            this.btn_XacNhan.Text = "Xác Nhận";
            this.btn_XacNhan.UseVisualStyleBackColor = true;
            this.btn_XacNhan.Click += new System.EventHandler(this.btn_XacNhan_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(156, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Kỳ:";
            // 
            // txt_Ky
            // 
            this.txt_Ky.Location = new System.Drawing.Point(185, 29);
            this.txt_Ky.Name = "txt_Ky";
            this.txt_Ky.ReadOnly = true;
            this.txt_Ky.Size = new System.Drawing.Size(25, 21);
            this.txt_Ky.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Môn học:";
            // 
            // txt_MonHoc
            // 
            this.txt_MonHoc.Location = new System.Drawing.Point(69, 6);
            this.txt_MonHoc.Name = "txt_MonHoc";
            this.txt_MonHoc.ReadOnly = true;
            this.txt_MonHoc.Size = new System.Drawing.Size(207, 21);
            this.txt_MonHoc.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Năm:";
            // 
            // btn_Chon
            // 
            this.btn_Chon.Location = new System.Drawing.Point(282, 4);
            this.btn_Chon.Name = "btn_Chon";
            this.btn_Chon.Size = new System.Drawing.Size(78, 23);
            this.btn_Chon.TabIndex = 7;
            this.btn_Chon.Text = "Chọn Lớp TC";
            this.btn_Chon.UseVisualStyleBackColor = true;
            this.btn_Chon.Click += new System.EventHandler(this.btn_Chon_Click);
            // 
            // txt_Nam
            // 
            this.txt_Nam.Location = new System.Drawing.Point(69, 29);
            this.txt_Nam.Name = "txt_Nam";
            this.txt_Nam.ReadOnly = true;
            this.txt_Nam.Size = new System.Drawing.Size(81, 21);
            this.txt_Nam.TabIndex = 6;
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
            // dgv_BangDiem
            // 
            this.dgv_BangDiem.AllowUserToOrderColumns = true;
            this.dgv_BangDiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_BangDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_BangDiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSv,
            this.tenSv,
            this.chuyenCan,
            this.baiTap,
            this.kiemTra,
            this.thucHanh,
            this.thi,
            this.tongKet});
            this.dgv_BangDiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_BangDiem.Location = new System.Drawing.Point(0, 106);
            this.dgv_BangDiem.MultiSelect = false;
            this.dgv_BangDiem.Name = "dgv_BangDiem";
            this.dgv_BangDiem.ReadOnly = true;
            this.dgv_BangDiem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_BangDiem.Size = new System.Drawing.Size(954, 397);
            this.dgv_BangDiem.TabIndex = 12;
            this.dgv_BangDiem.TabStop = false;
            this.dgv_BangDiem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_BangDiem_CellClick);
            this.dgv_BangDiem.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_BangDiem_CellValueChanged);
            this.dgv_BangDiem.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgv_BangDiem_DataError);
            this.dgv_BangDiem.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgv_BangDiem_EditingControlShowing);
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
            // tenSv
            // 
            this.tenSv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenSv.DataPropertyName = "tenSv";
            this.tenSv.HeaderText = "Họ và tên";
            this.tenSv.MaxInputLength = 20;
            this.tenSv.Name = "tenSv";
            this.tenSv.ReadOnly = true;
            this.tenSv.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // chuyenCan
            // 
            this.chuyenCan.DataPropertyName = "chuyenCan";
            this.chuyenCan.HeaderText = "Chuyên cần";
            this.chuyenCan.Name = "chuyenCan";
            this.chuyenCan.ReadOnly = true;
            this.chuyenCan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // baiTap
            // 
            this.baiTap.DataPropertyName = "baiTap";
            this.baiTap.HeaderText = "Bài Tập";
            this.baiTap.Name = "baiTap";
            this.baiTap.ReadOnly = true;
            this.baiTap.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // kiemTra
            // 
            this.kiemTra.DataPropertyName = "kiemTra";
            this.kiemTra.HeaderText = "Kiểm Tra";
            this.kiemTra.Name = "kiemTra";
            this.kiemTra.ReadOnly = true;
            this.kiemTra.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // thucHanh
            // 
            this.thucHanh.DataPropertyName = "thucHanh";
            this.thucHanh.HeaderText = "Thực Hành";
            this.thucHanh.Name = "thucHanh";
            this.thucHanh.ReadOnly = true;
            this.thucHanh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // thi
            // 
            this.thi.DataPropertyName = "thi";
            this.thi.HeaderText = "Thi";
            this.thi.Name = "thi";
            this.thi.ReadOnly = true;
            this.thi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tongKet
            // 
            this.tongKet.DataPropertyName = "tongKet";
            this.tongKet.HeaderText = "Tổng kết";
            this.tongKet.Name = "tongKet";
            this.tongKet.ReadOnly = true;
            this.tongKet.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Form_Nhap_DiemSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 503);
            this.Controls.Add(this.dgv_BangDiem);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form_Nhap_DiemSinhVien";
            this.Text = "Form_Nhap_DiemSinhVien";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BangDiem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_CapNhat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Ky;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_MonHoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Chon;
        private System.Windows.Forms.TextBox txt_Nam;
        private System.Windows.Forms.Label lbl_SoLuong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_BangDiem;
        private System.Windows.Forms.Button btn_XacNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSv;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSv;
        private System.Windows.Forms.DataGridViewTextBoxColumn chuyenCan;
        private System.Windows.Forms.DataGridViewTextBoxColumn baiTap;
        private System.Windows.Forms.DataGridViewTextBoxColumn kiemTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn thucHanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn thi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongKet;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_error_Diem;
    }
}