namespace QuanLyTaiKhoanNganHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDangNhap));
            this.btnThoatChuongTrinh = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtQuenMatKhau = new System.Windows.Forms.Label();
            this.HienThiMatKhau = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLinkĐangKy = new System.Windows.Forms.LinkLabel();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.Thoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HienThiMatKhau)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoatChuongTrinh
            // 
            this.btnThoatChuongTrinh.FlatAppearance.BorderSize = 0;
            this.btnThoatChuongTrinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoatChuongTrinh.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoatChuongTrinh.Location = new System.Drawing.Point(484, 2);
            this.btnThoatChuongTrinh.Name = "btnThoatChuongTrinh";
            this.btnThoatChuongTrinh.Size = new System.Drawing.Size(35, 39);
            this.btnThoatChuongTrinh.TabIndex = 40;
            this.btnThoatChuongTrinh.Text = "X";
            this.btnThoatChuongTrinh.UseVisualStyleBackColor = true;
            this.btnThoatChuongTrinh.Click += new System.EventHandler(this.btnThoatChuongTrinh_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(71, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(288, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.Blue;
            this.btnDangNhap.FlatAppearance.BorderSize = 0;
            this.btnDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangNhap.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.ForeColor = System.Drawing.Color.White;
            this.btnDangNhap.Location = new System.Drawing.Point(124, 332);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(154, 39);
            this.btnDangNhap.TabIndex = 51;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            this.btnDangNhap.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnDangNhap_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(68, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 46;
            this.label5.Text = "Mật Khẩu:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(68, 206);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 20);
            this.label9.TabIndex = 45;
            this.label9.Text = "Tài Khoản:";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(69, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(262, 2);
            this.label4.TabIndex = 42;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaiKhoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtTaiKhoan.Location = new System.Drawing.Point(71, 230);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(258, 15);
            this.txtTaiKhoan.TabIndex = 44;
            // 
            // txtQuenMatKhau
            // 
            this.txtQuenMatKhau.AutoSize = true;
            this.txtQuenMatKhau.BackColor = System.Drawing.Color.Transparent;
            this.txtQuenMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuenMatKhau.ForeColor = System.Drawing.Color.Blue;
            this.txtQuenMatKhau.Location = new System.Drawing.Point(61, 394);
            this.txtQuenMatKhau.Name = "txtQuenMatKhau";
            this.txtQuenMatKhau.Size = new System.Drawing.Size(131, 20);
            this.txtQuenMatKhau.TabIndex = 49;
            this.txtQuenMatKhau.Text = "Quên mật khẩu ?";
            this.txtQuenMatKhau.Click += new System.EventHandler(this.txtQuenMatKhau_Click);
            // 
            // HienThiMatKhau
            // 
            this.HienThiMatKhau.BackColor = System.Drawing.Color.Transparent;
            this.HienThiMatKhau.Image = ((System.Drawing.Image)(resources.GetObject("HienThiMatKhau.Image")));
            this.HienThiMatKhau.Location = new System.Drawing.Point(338, 288);
            this.HienThiMatKhau.Name = "HienThiMatKhau";
            this.HienThiMatKhau.Size = new System.Drawing.Size(31, 28);
            this.HienThiMatKhau.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HienThiMatKhau.TabIndex = 54;
            this.HienThiMatKhau.TabStop = false;
            this.HienThiMatKhau.Click += new System.EventHandler(this.HienThiMatKhau_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(69, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 2);
            this.label2.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 31);
            this.label1.TabIndex = 58;
            this.label1.Text = "Đăng Nhập";
            // 
            // lblLinkĐangKy
            // 
            this.lblLinkĐangKy.AutoSize = true;
            this.lblLinkĐangKy.BackColor = System.Drawing.Color.Transparent;
            this.lblLinkĐangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinkĐangKy.Location = new System.Drawing.Point(250, 394);
            this.lblLinkĐangKy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLinkĐangKy.Name = "lblLinkĐangKy";
            this.lblLinkĐangKy.Size = new System.Drawing.Size(105, 20);
            this.lblLinkĐangKy.TabIndex = 60;
            this.lblLinkĐangKy.TabStop = true;
            this.lblLinkĐangKy.Text = "Tạo tài khoản";
            this.lblLinkĐangKy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLinkĐangKy_LinkClicked);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BackColor = System.Drawing.Color.White;
            this.txtMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.ForeColor = System.Drawing.Color.Black;
            this.txtMatKhau.Location = new System.Drawing.Point(71, 295);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(260, 15);
            this.txtMatKhau.TabIndex = 44;
            this.txtMatKhau.TextChanged += new System.EventHandler(this.txtMatKhau_TextChanged_2);
            // 
            // Thoat
            // 
            this.Thoat.BackColor = System.Drawing.Color.Transparent;
            this.Thoat.FlatAppearance.BorderSize = 0;
            this.Thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Thoat.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thoat.ForeColor = System.Drawing.Color.Black;
            this.Thoat.Location = new System.Drawing.Point(391, 11);
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(42, 45);
            this.Thoat.TabIndex = 61;
            this.Thoat.Text = "x";
            this.Thoat.UseVisualStyleBackColor = false;
            this.Thoat.Click += new System.EventHandler(this.Thoat_Click_1);
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = global::QuanLyTaiKhoanNganHang.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(436, 462);
            this.Controls.Add(this.Thoat);
            this.Controls.Add(this.lblLinkĐangKy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HienThiMatKhau);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.txtQuenMatKhau);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.btnThoatChuongTrinh);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FormDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDangNhap";
            this.Load += new System.EventHandler(this.FormDangNhap_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormDangNhap_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HienThiMatKhau)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnThoatChuongTrinh;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.Label txtQuenMatKhau;
        private System.Windows.Forms.PictureBox HienThiMatKhau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lblLinkĐangKy;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Button Thoat;
    }
}