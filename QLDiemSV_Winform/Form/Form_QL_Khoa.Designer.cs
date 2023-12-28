namespace QLDiemSV_Winform.Form.FormQuanLy
{
    partial class Form_QL_Khoa
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
            this.dgv_Khoa = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_Ma = new System.Windows.Forms.Label();
            this.txt_Ma = new System.Windows.Forms.TextBox();
            this.lbl_Ten = new System.Windows.Forms.Label();
            this.txt_Ten = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.btn_XacNhan = new System.Windows.Forms.Button();
            this.maKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_error_Ten = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Khoa)).BeginInit();
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
            this.panel2.Size = new System.Drawing.Size(954, 24);
            this.panel2.TabIndex = 5;
            // 
            // lbl_SoLuong
            // 
            this.lbl_SoLuong.AutoSize = true;
            this.lbl_SoLuong.Location = new System.Drawing.Point(64, 3);
            this.lbl_SoLuong.Name = "lbl_SoLuong";
            this.lbl_SoLuong.Size = new System.Drawing.Size(64, 13);
            this.lbl_SoLuong.TabIndex = 5;
            this.lbl_SoLuong.Text = "lbl_SoLuong";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Số Lượng:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.dgv_Khoa);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 56);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(954, 447);
            this.panel3.TabIndex = 6;
            // 
            // dgv_Khoa
            // 
            this.dgv_Khoa.AllowUserToOrderColumns = true;
            this.dgv_Khoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Khoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Khoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maKhoa,
            this.tenKhoa});
            this.dgv_Khoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Khoa.Location = new System.Drawing.Point(0, 0);
            this.dgv_Khoa.MultiSelect = false;
            this.dgv_Khoa.Name = "dgv_Khoa";
            this.dgv_Khoa.ReadOnly = true;
            this.dgv_Khoa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Khoa.Size = new System.Drawing.Size(954, 447);
            this.dgv_Khoa.TabIndex = 8;
            this.dgv_Khoa.TabStop = false;
            this.dgv_Khoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Khoa_CellClick);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lbl_error_Ten);
            this.panel4.Controls.Add(this.btn_Huy);
            this.panel4.Controls.Add(this.btn_XacNhan);
            this.panel4.Controls.Add(this.lbl_Ma);
            this.panel4.Controls.Add(this.txt_Ma);
            this.panel4.Controls.Add(this.lbl_Ten);
            this.panel4.Controls.Add(this.txt_Ten);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(660, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(294, 447);
            this.panel4.TabIndex = 9;
            // 
            // lbl_Ma
            // 
            this.lbl_Ma.AutoSize = true;
            this.lbl_Ma.Location = new System.Drawing.Point(21, 72);
            this.lbl_Ma.Name = "lbl_Ma";
            this.lbl_Ma.Size = new System.Drawing.Size(51, 13);
            this.lbl_Ma.TabIndex = 41;
            this.lbl_Ma.Text = "Mã khoa:";
            // 
            // txt_Ma
            // 
            this.txt_Ma.Location = new System.Drawing.Point(92, 69);
            this.txt_Ma.MaxLength = 20;
            this.txt_Ma.Name = "txt_Ma";
            this.txt_Ma.ReadOnly = true;
            this.txt_Ma.Size = new System.Drawing.Size(100, 21);
            this.txt_Ma.TabIndex = 42;
            // 
            // lbl_Ten
            // 
            this.lbl_Ten.AutoSize = true;
            this.lbl_Ten.Location = new System.Drawing.Point(21, 113);
            this.lbl_Ten.Name = "lbl_Ten";
            this.lbl_Ten.Size = new System.Drawing.Size(55, 13);
            this.lbl_Ten.TabIndex = 39;
            this.lbl_Ten.Text = "Tên khoa:";
            // 
            // txt_Ten
            // 
            this.txt_Ten.Location = new System.Drawing.Point(92, 110);
            this.txt_Ten.MaxLength = 50;
            this.txt_Ten.Name = "txt_Ten";
            this.txt_Ten.Size = new System.Drawing.Size(165, 21);
            this.txt_Ten.TabIndex = 40;
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
            this.panel6.Size = new System.Drawing.Size(294, 38);
            this.panel6.TabIndex = 38;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Xoa.Location = new System.Drawing.Point(144, 0);
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
            this.btn_Sua.Location = new System.Drawing.Point(219, 0);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 38);
            this.btn_Sua.TabIndex = 1;
            this.btn_Sua.Text = "Chỉnh Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Huy
            // 
            this.btn_Huy.Location = new System.Drawing.Point(117, 158);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(75, 23);
            this.btn_Huy.TabIndex = 44;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.UseVisualStyleBackColor = true;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // btn_XacNhan
            // 
            this.btn_XacNhan.Location = new System.Drawing.Point(25, 158);
            this.btn_XacNhan.Name = "btn_XacNhan";
            this.btn_XacNhan.Size = new System.Drawing.Size(75, 23);
            this.btn_XacNhan.TabIndex = 43;
            this.btn_XacNhan.Text = "Xác Nhận";
            this.btn_XacNhan.UseVisualStyleBackColor = true;
            this.btn_XacNhan.Click += new System.EventHandler(this.btn_XacNhan_Click);
            // 
            // maKhoa
            // 
            this.maKhoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.maKhoa.DataPropertyName = "maKhoa";
            this.maKhoa.HeaderText = "Mã Khoa";
            this.maKhoa.MaxInputLength = 10;
            this.maKhoa.Name = "maKhoa";
            this.maKhoa.ReadOnly = true;
            this.maKhoa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.maKhoa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.maKhoa.Width = 54;
            // 
            // tenKhoa
            // 
            this.tenKhoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenKhoa.DataPropertyName = "tenKhoa";
            this.tenKhoa.HeaderText = "Tên Khoa";
            this.tenKhoa.MaxInputLength = 10;
            this.tenKhoa.Name = "tenKhoa";
            this.tenKhoa.ReadOnly = true;
            this.tenKhoa.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // lbl_error_Ten
            // 
            this.lbl_error_Ten.AutoSize = true;
            this.lbl_error_Ten.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_Ten.Location = new System.Drawing.Point(89, 134);
            this.lbl_error_Ten.Name = "lbl_error_Ten";
            this.lbl_error_Ten.Size = new System.Drawing.Size(71, 13);
            this.lbl_error_Ten.TabIndex = 45;
            this.lbl_error_Ten.Text = "lbl_error_Ten";
            this.lbl_error_Ten.Visible = false;
            // 
            // Form_QL_Khoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 503);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form_QL_Khoa";
            this.Text = "Form_QL_Khoa";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Khoa)).EndInit();
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
        private System.Windows.Forms.DataGridView dgv_Khoa;
        private System.Windows.Forms.Label lbl_Ma;
        private System.Windows.Forms.TextBox txt_Ma;
        private System.Windows.Forms.Label lbl_Ten;
        private System.Windows.Forms.TextBox txt_Ten;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.Button btn_XacNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKhoa;
        private System.Windows.Forms.Label lbl_error_Ten;
    }
}