namespace QLDiemSV_Winform.Form
{
    partial class Form_KhoiPhuc_MatKhau
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.lbl_error_XacNhan = new System.Windows.Forms.Label();
            this.lbl_error_TenDangNhap = new System.Windows.Forms.Label();
            this.btn_XacNhan = new System.Windows.Forms.Button();
            this.lb_TenDangNhap = new System.Windows.Forms.Label();
            this.txt_TenDangNhap = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.btn_Thoat);
            this.groupBox1.Controls.Add(this.lbl_error_XacNhan);
            this.groupBox1.Controls.Add(this.lbl_error_TenDangNhap);
            this.groupBox1.Controls.Add(this.btn_XacNhan);
            this.groupBox1.Controls.Add(this.lb_TenDangNhap);
            this.groupBox1.Controls.Add(this.txt_TenDangNhap);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 244);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Khôi phục mật khẩu";
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
            // lbl_error_XacNhan
            // 
            this.lbl_error_XacNhan.AutoSize = true;
            this.lbl_error_XacNhan.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_XacNhan.Location = new System.Drawing.Point(104, 127);
            this.lbl_error_XacNhan.Name = "lbl_error_XacNhan";
            this.lbl_error_XacNhan.Size = new System.Drawing.Size(95, 13);
            this.lbl_error_XacNhan.TabIndex = 7;
            this.lbl_error_XacNhan.Text = "lbl_error_XacNhan";
            this.lbl_error_XacNhan.Visible = false;
            // 
            // lbl_error_TenDangNhap
            // 
            this.lbl_error_TenDangNhap.AutoSize = true;
            this.lbl_error_TenDangNhap.ForeColor = System.Drawing.Color.Red;
            this.lbl_error_TenDangNhap.Location = new System.Drawing.Point(104, 85);
            this.lbl_error_TenDangNhap.Name = "lbl_error_TenDangNhap";
            this.lbl_error_TenDangNhap.Size = new System.Drawing.Size(121, 13);
            this.lbl_error_TenDangNhap.TabIndex = 5;
            this.lbl_error_TenDangNhap.Text = "lbl_error_TenDangNhap";
            this.lbl_error_TenDangNhap.Visible = false;
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
            this.lb_TenDangNhap.Size = new System.Drawing.Size(83, 13);
            this.lb_TenDangNhap.TabIndex = 0;
            this.lb_TenDangNhap.Text = "Tên đăng nhập:";
            // 
            // txt_TenDangNhap
            // 
            this.txt_TenDangNhap.Location = new System.Drawing.Point(107, 61);
            this.txt_TenDangNhap.Name = "txt_TenDangNhap";
            this.txt_TenDangNhap.Size = new System.Drawing.Size(215, 21);
            this.txt_TenDangNhap.TabIndex = 1;
            this.txt_TenDangNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_MatKhau_KeyPress);
            // 
            // Form_KhoiPhuc_MatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 530);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_KhoiPhuc_MatKhau";
            this.Text = "Form_KhoiPhuc_MatKhau";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Label lbl_error_XacNhan;
        private System.Windows.Forms.Label lbl_error_TenDangNhap;
        private System.Windows.Forms.Button btn_XacNhan;
        private System.Windows.Forms.Label lb_TenDangNhap;
        private System.Windows.Forms.TextBox txt_TenDangNhap;
    }
}