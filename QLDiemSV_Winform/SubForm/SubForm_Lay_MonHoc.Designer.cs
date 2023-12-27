namespace QLDiemSV_Winform.SubForm
{
    partial class SubForm_Lay_MonHoc
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
            this.lbl_YeuCau = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_MonHoc = new System.Windows.Forms.DataGridView();
            this.maMh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenMh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tschuyenCan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsbaiTap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tskiemTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsthucHanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsthi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soTc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_SoLuong = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_XacNhan = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MonHoc)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_YeuCau
            // 
            this.lbl_YeuCau.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_YeuCau.AutoSize = true;
            this.lbl_YeuCau.Font = new System.Drawing.Font("Tahoma", 16.25F);
            this.lbl_YeuCau.Location = new System.Drawing.Point(12, 9);
            this.lbl_YeuCau.Name = "lbl_YeuCau";
            this.lbl_YeuCau.Size = new System.Drawing.Size(233, 27);
            this.lbl_YeuCau.TabIndex = 13;
            this.lbl_YeuCau.Text = "Vui lòng chọn môn học";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.Controls.Add(this.dgv_MonHoc);
            this.panel1.Controls.Add(this.lbl_YeuCau);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10, 50, 10, 10);
            this.panel1.Size = new System.Drawing.Size(954, 503);
            this.panel1.TabIndex = 1;
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
            this.dgv_MonHoc.Location = new System.Drawing.Point(10, 108);
            this.dgv_MonHoc.MultiSelect = false;
            this.dgv_MonHoc.Name = "dgv_MonHoc";
            this.dgv_MonHoc.ReadOnly = true;
            this.dgv_MonHoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_MonHoc.Size = new System.Drawing.Size(934, 385);
            this.dgv_MonHoc.TabIndex = 14;
            this.dgv_MonHoc.TabStop = false;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.lbl_SoLuong);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(10, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(934, 26);
            this.panel2.TabIndex = 11;
            // 
            // lbl_SoLuong
            // 
            this.lbl_SoLuong.AutoSize = true;
            this.lbl_SoLuong.Location = new System.Drawing.Point(73, 3);
            this.lbl_SoLuong.Name = "lbl_SoLuong";
            this.lbl_SoLuong.Size = new System.Drawing.Size(64, 13);
            this.lbl_SoLuong.TabIndex = 7;
            this.lbl_SoLuong.Text = "lbl_SoLuong";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Số Lượng:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btn_Thoat);
            this.panel3.Controls.Add(this.btn_XacNhan);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(10, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(934, 32);
            this.panel3.TabIndex = 10;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Thoat.Location = new System.Drawing.Point(859, 0);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(75, 32);
            this.btn_Thoat.TabIndex = 2;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
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
            this.btn_XacNhan.Click += new System.EventHandler(this.btn_XacNhan_Click);
            // 
            // SubForm_Lay_MonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 503);
            this.Controls.Add(this.panel1);
            this.Name = "SubForm_Lay_MonHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SubForm_Lay_MonHoc";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_MonHoc)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_YeuCau;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_SoLuong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_XacNhan;
        private System.Windows.Forms.DataGridView dgv_MonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn maMh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenMh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tschuyenCan;
        private System.Windows.Forms.DataGridViewTextBoxColumn tsbaiTap;
        private System.Windows.Forms.DataGridViewTextBoxColumn tskiemTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn tsthucHanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn tsthi;
        private System.Windows.Forms.DataGridViewTextBoxColumn soTc;
    }
}