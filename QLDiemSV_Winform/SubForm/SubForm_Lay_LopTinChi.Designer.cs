namespace QLDiemSV_Winform.SubForm
{
    partial class SubForm_Lay_LopTinChi
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
            this.dgv_LopTinChi = new System.Windows.Forms.DataGridView();
            this.maLopTc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenMh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_Ky = new System.Windows.Forms.ComboBox();
            this.lbl_Nam = new System.Windows.Forms.Label();
            this.lbl_SoLuong = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_Nam = new System.Windows.Forms.ComboBox();
            this.lbl_YeuCau = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_XacNhan = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LopTinChi)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.Controls.Add(this.dgv_LopTinChi);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lbl_YeuCau);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10, 50, 10, 10);
            this.panel1.Size = new System.Drawing.Size(755, 434);
            this.panel1.TabIndex = 1;
            // 
            // dgv_LopTinChi
            // 
            this.dgv_LopTinChi.AllowUserToOrderColumns = true;
            this.dgv_LopTinChi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_LopTinChi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_LopTinChi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maLopTc,
            this.tenMh});
            this.dgv_LopTinChi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_LopTinChi.Location = new System.Drawing.Point(10, 132);
            this.dgv_LopTinChi.MultiSelect = false;
            this.dgv_LopTinChi.Name = "dgv_LopTinChi";
            this.dgv_LopTinChi.ReadOnly = true;
            this.dgv_LopTinChi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_LopTinChi.Size = new System.Drawing.Size(735, 292);
            this.dgv_LopTinChi.TabIndex = 15;
            this.dgv_LopTinChi.TabStop = false;
            this.dgv_LopTinChi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_LopTinChi_CellClick);
            // 
            // maLopTc
            // 
            this.maLopTc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.maLopTc.DataPropertyName = "maLopTc";
            this.maLopTc.HeaderText = "Mã Lớp Tín Chỉ";
            this.maLopTc.MaxInputLength = 10;
            this.maLopTc.Name = "maLopTc";
            this.maLopTc.ReadOnly = true;
            this.maLopTc.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.maLopTc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.maLopTc.Width = 82;
            // 
            // tenMh
            // 
            this.tenMh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenMh.DataPropertyName = "tenMh";
            this.tenMh.HeaderText = "Tên Môn Học";
            this.tenMh.MaxInputLength = 10;
            this.tenMh.Name = "tenMh";
            this.tenMh.ReadOnly = true;
            this.tenMh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cmb_Ky);
            this.panel2.Controls.Add(this.lbl_Nam);
            this.panel2.Controls.Add(this.lbl_SoLuong);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cmb_Nam);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(10, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(735, 50);
            this.panel2.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Kỳ:";
            // 
            // cmb_Ky
            // 
            this.cmb_Ky.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Ky.FormattingEnabled = true;
            this.cmb_Ky.Location = new System.Drawing.Point(232, 6);
            this.cmb_Ky.Name = "cmb_Ky";
            this.cmb_Ky.Size = new System.Drawing.Size(138, 21);
            this.cmb_Ky.TabIndex = 9;
            this.cmb_Ky.SelectedIndexChanged += new System.EventHandler(this.cmb_Ky_SelectedIndexChanged);
            // 
            // lbl_Nam
            // 
            this.lbl_Nam.AutoSize = true;
            this.lbl_Nam.Location = new System.Drawing.Point(12, 9);
            this.lbl_Nam.Name = "lbl_Nam";
            this.lbl_Nam.Size = new System.Drawing.Size(32, 13);
            this.lbl_Nam.TabIndex = 8;
            this.lbl_Nam.Text = "Năm:";
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
            // cmb_Nam
            // 
            this.cmb_Nam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Nam.FormattingEnabled = true;
            this.cmb_Nam.Location = new System.Drawing.Point(50, 6);
            this.cmb_Nam.Name = "cmb_Nam";
            this.cmb_Nam.Size = new System.Drawing.Size(138, 21);
            this.cmb_Nam.TabIndex = 3;
            this.cmb_Nam.SelectedIndexChanged += new System.EventHandler(this.cmb_Nam_SelectedIndexChanged);
            // 
            // lbl_YeuCau
            // 
            this.lbl_YeuCau.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_YeuCau.AutoSize = true;
            this.lbl_YeuCau.Font = new System.Drawing.Font("Tahoma", 16.25F);
            this.lbl_YeuCau.Location = new System.Drawing.Point(12, 9);
            this.lbl_YeuCau.Name = "lbl_YeuCau";
            this.lbl_YeuCau.Size = new System.Drawing.Size(244, 27);
            this.lbl_YeuCau.TabIndex = 13;
            this.lbl_YeuCau.Text = "Vui lòng chọn lớp tín chỉ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btn_Thoat);
            this.panel3.Controls.Add(this.btn_XacNhan);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(10, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(735, 32);
            this.panel3.TabIndex = 10;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Thoat.Location = new System.Drawing.Point(660, 0);
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
            // SubForm_Lay_LopTinChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 434);
            this.Controls.Add(this.panel1);
            this.Name = "SubForm_Lay_LopTinChi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SubForm_Lay_LopTinChi";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LopTinChi)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_YeuCau;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_XacNhan;
        private System.Windows.Forms.DataGridView dgv_LopTinChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLopTc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenMh;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_Ky;
        private System.Windows.Forms.Label lbl_Nam;
        private System.Windows.Forms.Label lbl_SoLuong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_Nam;
    }
}