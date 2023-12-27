namespace QLDiemSV_Winform
{
    partial class FormDangNhap
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
            this.txt_TenDangNhap = new System.Windows.Forms.TextBox();
            this.lb_TenDangNhap = new System.Windows.Forms.Label();
            this.lb_MatKhau = new System.Windows.Forms.Label();
            this.txt_MatKhau = new System.Windows.Forms.TextBox();
            this.btn_DangNhap = new System.Windows.Forms.Button();
            this.lb_error_TenDangNhap = new System.Windows.Forms.Label();
            this.lb_error_MatKhau = new System.Windows.Forms.Label();
            this.lb_error_DangNhap = new System.Windows.Forms.Label();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_TogglePwd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(138, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(501, 244);
            this.panel1.TabIndex = 0;
            // 
            // txt_TenDangNhap
            // 
            this.txt_TenDangNhap.Location = new System.Drawing.Point(107, 61);
            this.txt_TenDangNhap.Name = "txt_TenDangNhap";
            this.txt_TenDangNhap.Size = new System.Drawing.Size(215, 21);
            this.txt_TenDangNhap.TabIndex = 1;
            this.txt_TenDangNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_TenDangNhap_KeyPress);
            // 
            // lb_TenDangNhap
            // 
            this.lb_TenDangNhap.AutoSize = true;
            this.lb_TenDangNhap.Location = new System.Drawing.Point(15, 64);
            this.lb_TenDangNhap.Name = "lb_TenDangNhap";
            this.lb_TenDangNhap.Size = new System.Drawing.Size(86, 13);
            this.lb_TenDangNhap.TabIndex = 0;
            this.lb_TenDangNhap.Text = "Tên Đăng Nhập:";
            // 
            // lb_MatKhau
            // 
            this.lb_MatKhau.AutoSize = true;
            this.lb_MatKhau.Location = new System.Drawing.Point(45, 108);
            this.lb_MatKhau.Name = "lb_MatKhau";
            this.lb_MatKhau.Size = new System.Drawing.Size(56, 13);
            this.lb_MatKhau.TabIndex = 2;
            this.lb_MatKhau.Text = "Mật Khẩu:";
            // 
            // txt_MatKhau
            // 
            this.txt_MatKhau.Location = new System.Drawing.Point(107, 105);
            this.txt_MatKhau.Name = "txt_MatKhau";
            this.txt_MatKhau.Size = new System.Drawing.Size(215, 21);
            this.txt_MatKhau.TabIndex = 3;
            this.txt_MatKhau.UseSystemPasswordChar = true;
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.Location = new System.Drawing.Point(100, 168);
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.Size = new System.Drawing.Size(75, 23);
            this.btn_DangNhap.TabIndex = 4;
            this.btn_DangNhap.Text = "Đăng Nhập";
            this.btn_DangNhap.UseVisualStyleBackColor = true;
            this.btn_DangNhap.Click += new System.EventHandler(this.btn_DangNhap_Click);
            // 
            // lb_error_TenDangNhap
            // 
            this.lb_error_TenDangNhap.AutoSize = true;
            this.lb_error_TenDangNhap.ForeColor = System.Drawing.Color.Red;
            this.lb_error_TenDangNhap.Location = new System.Drawing.Point(104, 85);
            this.lb_error_TenDangNhap.Name = "lb_error_TenDangNhap";
            this.lb_error_TenDangNhap.Size = new System.Drawing.Size(101, 13);
            this.lb_error_TenDangNhap.TabIndex = 5;
            this.lb_error_TenDangNhap.Text = "lb_error_DangNhap";
            this.lb_error_TenDangNhap.Visible = false;
            // 
            // lb_error_MatKhau
            // 
            this.lb_error_MatKhau.AutoSize = true;
            this.lb_error_MatKhau.ForeColor = System.Drawing.Color.Red;
            this.lb_error_MatKhau.Location = new System.Drawing.Point(104, 129);
            this.lb_error_MatKhau.Name = "lb_error_MatKhau";
            this.lb_error_MatKhau.Size = new System.Drawing.Size(93, 13);
            this.lb_error_MatKhau.TabIndex = 6;
            this.lb_error_MatKhau.Text = "lb_error_MatKhau";
            this.lb_error_MatKhau.Visible = false;
            // 
            // lb_error_DangNhap
            // 
            this.lb_error_DangNhap.AutoSize = true;
            this.lb_error_DangNhap.ForeColor = System.Drawing.Color.Red;
            this.lb_error_DangNhap.Location = new System.Drawing.Point(97, 195);
            this.lb_error_DangNhap.Name = "lb_error_DangNhap";
            this.lb_error_DangNhap.Size = new System.Drawing.Size(101, 13);
            this.lb_error_DangNhap.TabIndex = 7;
            this.lb_error_DangNhap.Text = "lb_error_DangNhap";
            this.lb_error_DangNhap.Visible = false;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(247, 168);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_Thoat.TabIndex = 8;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_TogglePwd
            // 
            this.btn_TogglePwd.Location = new System.Drawing.Point(328, 103);
            this.btn_TogglePwd.Name = "btn_TogglePwd";
            this.btn_TogglePwd.Size = new System.Drawing.Size(41, 23);
            this.btn_TogglePwd.TabIndex = 9;
            this.btn_TogglePwd.Text = "<O>";
            this.btn_TogglePwd.UseVisualStyleBackColor = true;
            this.btn_TogglePwd.Click += new System.EventHandler(this.btn_TogglePwd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.btn_TogglePwd);
            this.groupBox1.Controls.Add(this.btn_Thoat);
            this.groupBox1.Controls.Add(this.lb_error_DangNhap);
            this.groupBox1.Controls.Add(this.lb_error_MatKhau);
            this.groupBox1.Controls.Add(this.lb_error_TenDangNhap);
            this.groupBox1.Controls.Add(this.btn_DangNhap);
            this.groupBox1.Controls.Add(this.txt_MatKhau);
            this.groupBox1.Controls.Add(this.lb_MatKhau);
            this.groupBox1.Controls.Add(this.lb_TenDangNhap);
            this.groupBox1.Controls.Add(this.txt_TenDangNhap);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 244);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đăng nhập";
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 485);
            this.Controls.Add(this.panel1);
            this.Name = "FormDangNhap";
            this.Text = "Đăng nhập";
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
        private System.Windows.Forms.Label lb_error_DangNhap;
        private System.Windows.Forms.Label lb_error_MatKhau;
        private System.Windows.Forms.Label lb_error_TenDangNhap;
        private System.Windows.Forms.Button btn_DangNhap;
        private System.Windows.Forms.TextBox txt_MatKhau;
        private System.Windows.Forms.Label lb_MatKhau;
        private System.Windows.Forms.Label lb_TenDangNhap;
        private System.Windows.Forms.TextBox txt_TenDangNhap;
    }
}