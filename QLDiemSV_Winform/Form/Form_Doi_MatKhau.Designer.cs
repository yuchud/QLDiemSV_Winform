namespace QLDiemSV_Winform.Form.FormQuanLy
{
    partial class Form_Doi_MatKhau
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_TogglePwd = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.lb_error_XacNhan = new System.Windows.Forms.Label();
            this.lb_error_MatKhau = new System.Windows.Forms.Label();
            this.btn_XacNhan = new System.Windows.Forms.Button();
            this.lb_TenDangNhap = new System.Windows.Forms.Label();
            this.txt_MatKhau = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 498);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.btn_TogglePwd);
            this.groupBox1.Controls.Add(this.btn_Thoat);
            this.groupBox1.Controls.Add(this.lb_error_XacNhan);
            this.groupBox1.Controls.Add(this.lb_error_MatKhau);
            this.groupBox1.Controls.Add(this.btn_XacNhan);
            this.groupBox1.Controls.Add(this.lb_TenDangNhap);
            this.groupBox1.Controls.Add(this.txt_MatKhau);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 244);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đổi mật khẩu";
            // 
            // btn_TogglePwd
            // 
            this.btn_TogglePwd.Location = new System.Drawing.Point(328, 61);
            this.btn_TogglePwd.Name = "btn_TogglePwd";
            this.btn_TogglePwd.Size = new System.Drawing.Size(41, 23);
            this.btn_TogglePwd.TabIndex = 9;
            this.btn_TogglePwd.Text = "<O>";
            this.btn_TogglePwd.UseVisualStyleBackColor = true;
            this.btn_TogglePwd.Click += new System.EventHandler(this.btn_TogglePwd_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(247, 101);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_Thoat.TabIndex = 8;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // lb_error_XacNhan
            // 
            this.lb_error_XacNhan.AutoSize = true;
            this.lb_error_XacNhan.ForeColor = System.Drawing.Color.Red;
            this.lb_error_XacNhan.Location = new System.Drawing.Point(97, 127);
            this.lb_error_XacNhan.Name = "lb_error_XacNhan";
            this.lb_error_XacNhan.Size = new System.Drawing.Size(93, 13);
            this.lb_error_XacNhan.TabIndex = 7;
            this.lb_error_XacNhan.Text = "lb_error_XacNhan";
            this.lb_error_XacNhan.Visible = false;
            // 
            // lb_error_MatKhau
            // 
            this.lb_error_MatKhau.AutoSize = true;
            this.lb_error_MatKhau.ForeColor = System.Drawing.Color.Red;
            this.lb_error_MatKhau.Location = new System.Drawing.Point(104, 85);
            this.lb_error_MatKhau.Name = "lb_error_MatKhau";
            this.lb_error_MatKhau.Size = new System.Drawing.Size(93, 13);
            this.lb_error_MatKhau.TabIndex = 5;
            this.lb_error_MatKhau.Text = "lb_error_MatKhau";
            this.lb_error_MatKhau.Visible = false;
            // 
            // btn_XacNhan
            // 
            this.btn_XacNhan.Location = new System.Drawing.Point(100, 101);
            this.btn_XacNhan.Name = "btn_XacNhan";
            this.btn_XacNhan.Size = new System.Drawing.Size(75, 23);
            this.btn_XacNhan.TabIndex = 4;
            this.btn_XacNhan.Text = "Xác nhận";
            this.btn_XacNhan.UseVisualStyleBackColor = true;
            this.btn_XacNhan.Click += new System.EventHandler(this.btn_XacNhan_Click);
            // 
            // lb_TenDangNhap
            // 
            this.lb_TenDangNhap.AutoSize = true;
            this.lb_TenDangNhap.Location = new System.Drawing.Point(15, 64);
            this.lb_TenDangNhap.Name = "lb_TenDangNhap";
            this.lb_TenDangNhap.Size = new System.Drawing.Size(74, 13);
            this.lb_TenDangNhap.TabIndex = 0;
            this.lb_TenDangNhap.Text = "Mật khẩu mới:";
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.Location = new System.Drawing.Point(107, 61);
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.Size = new System.Drawing.Size(215, 21);
            this.txt_MatKhau.TabIndex = 1;
            this.txt_MatKhau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_MatKhau_KeyPress);
            // 
            // Form_Doi_MatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 498);
            this.Controls.Add(this.panel1);
            this.Name = "Form_Doi_MatKhau";
            this.Text = "Form_DoiMatKhau";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_TogglePwd;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Label lb_error_XacNhan;
        private System.Windows.Forms.Label lb_error_MatKhau;
        private System.Windows.Forms.Button btn_XacNhan;
        private System.Windows.Forms.Label lb_TenDangNhap;
        private System.Windows.Forms.TextBox txt_MatKhau;
    }
}