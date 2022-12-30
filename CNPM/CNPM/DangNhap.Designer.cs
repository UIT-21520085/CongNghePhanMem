namespace CNPM
{
    partial class DangNhap
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            this.iconButton_Close = new FontAwesome.Sharp.IconButton();
            this.iconButton_Minimize = new FontAwesome.Sharp.IconButton();
            this.label_DangNhap = new System.Windows.Forms.Label();
            this.label_TaiKhoan = new System.Windows.Forms.Label();
            this.label_MatKhau = new System.Windows.Forms.Label();
            this.textBox_TaiKhoan = new System.Windows.Forms.TextBox();
            this.textBox_MatKhau = new System.Windows.Forms.TextBox();
            this.button_PDTDangNhap = new System.Windows.Forms.Button();
            this.pictureBox_Logo = new System.Windows.Forms.PictureBox();
            this.button_SVDangNhap = new System.Windows.Forms.Button();
            this.label_DangNhapThatBai = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // iconButton_Close
            // 
            this.iconButton_Close.FlatAppearance.BorderSize = 0;
            this.iconButton_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_Close.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            this.iconButton_Close.IconColor = System.Drawing.Color.Black;
            this.iconButton_Close.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_Close.IconSize = 30;
            this.iconButton_Close.Location = new System.Drawing.Point(376, 2);
            this.iconButton_Close.Name = "iconButton_Close";
            this.iconButton_Close.Size = new System.Drawing.Size(25, 25);
            this.iconButton_Close.TabIndex = 2;
            this.iconButton_Close.UseVisualStyleBackColor = true;
            this.iconButton_Close.Click += new System.EventHandler(this.iconButton_Close_Click);
            // 
            // iconButton_Minimize
            // 
            this.iconButton_Minimize.FlatAppearance.BorderSize = 0;
            this.iconButton_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton_Minimize.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.iconButton_Minimize.IconColor = System.Drawing.Color.Black;
            this.iconButton_Minimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton_Minimize.IconSize = 30;
            this.iconButton_Minimize.Location = new System.Drawing.Point(345, 2);
            this.iconButton_Minimize.Name = "iconButton_Minimize";
            this.iconButton_Minimize.Size = new System.Drawing.Size(25, 25);
            this.iconButton_Minimize.TabIndex = 2;
            this.iconButton_Minimize.UseVisualStyleBackColor = true;
            this.iconButton_Minimize.Click += new System.EventHandler(this.iconButton_Minimize_Click);
            // 
            // label_DangNhap
            // 
            this.label_DangNhap.AutoSize = true;
            this.label_DangNhap.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_DangNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(106)))), ((int)(((byte)(179)))));
            this.label_DangNhap.Location = new System.Drawing.Point(105, 190);
            this.label_DangNhap.Name = "label_DangNhap";
            this.label_DangNhap.Size = new System.Drawing.Size(194, 35);
            this.label_DangNhap.TabIndex = 3;
            this.label_DangNhap.Text = "VNUHCM - UIT";
            // 
            // label_TaiKhoan
            // 
            this.label_TaiKhoan.AutoSize = true;
            this.label_TaiKhoan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_TaiKhoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(97)))));
            this.label_TaiKhoan.Location = new System.Drawing.Point(26, 264);
            this.label_TaiKhoan.Name = "label_TaiKhoan";
            this.label_TaiKhoan.Size = new System.Drawing.Size(103, 28);
            this.label_TaiKhoan.TabIndex = 4;
            this.label_TaiKhoan.Text = "Tài khoản";
            // 
            // label_MatKhau
            // 
            this.label_MatKhau.AutoSize = true;
            this.label_MatKhau.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_MatKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(138)))), ((int)(((byte)(97)))));
            this.label_MatKhau.Location = new System.Drawing.Point(26, 349);
            this.label_MatKhau.Name = "label_MatKhau";
            this.label_MatKhau.Size = new System.Drawing.Size(102, 28);
            this.label_MatKhau.TabIndex = 5;
            this.label_MatKhau.Text = "Mật khẩu";
            // 
            // textBox_TaiKhoan
            // 
            this.textBox_TaiKhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(250)))), ((int)(((byte)(202)))));
            this.textBox_TaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_TaiKhoan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_TaiKhoan.Location = new System.Drawing.Point(26, 306);
            this.textBox_TaiKhoan.MaxLength = 50;
            this.textBox_TaiKhoan.Name = "textBox_TaiKhoan";
            this.textBox_TaiKhoan.Size = new System.Drawing.Size(344, 27);
            this.textBox_TaiKhoan.TabIndex = 6;
            this.textBox_TaiKhoan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_TaiKhoan_KeyPress);
            // 
            // textBox_MatKhau
            // 
            this.textBox_MatKhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(250)))), ((int)(((byte)(202)))));
            this.textBox_MatKhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_MatKhau.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_MatKhau.Location = new System.Drawing.Point(26, 392);
            this.textBox_MatKhau.MaxLength = 100;
            this.textBox_MatKhau.Name = "textBox_MatKhau";
            this.textBox_MatKhau.PasswordChar = '*';
            this.textBox_MatKhau.Size = new System.Drawing.Size(344, 27);
            this.textBox_MatKhau.TabIndex = 7;
            this.textBox_MatKhau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_MatKhau_KeyPress);
            // 
            // button_PDTDangNhap
            // 
            this.button_PDTDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(193)))), ((int)(((byte)(148)))));
            this.button_PDTDangNhap.FlatAppearance.BorderSize = 0;
            this.button_PDTDangNhap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(255)))), ((int)(((byte)(253)))));
            this.button_PDTDangNhap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.button_PDTDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_PDTDangNhap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_PDTDangNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(75)))), ((int)(((byte)(73)))));
            this.button_PDTDangNhap.Location = new System.Drawing.Point(26, 439);
            this.button_PDTDangNhap.Name = "button_PDTDangNhap";
            this.button_PDTDangNhap.Size = new System.Drawing.Size(344, 50);
            this.button_PDTDangNhap.TabIndex = 8;
            this.button_PDTDangNhap.Text = "Phòng đào tạo đăng nhập";
            this.button_PDTDangNhap.UseVisualStyleBackColor = false;
            this.button_PDTDangNhap.Click += new System.EventHandler(this.button_PDTDangNhap_Click);
            // 
            // pictureBox_Logo
            // 
            this.pictureBox_Logo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Logo.Image")));
            this.pictureBox_Logo.Location = new System.Drawing.Point(106, 28);
            this.pictureBox_Logo.Name = "pictureBox_Logo";
            this.pictureBox_Logo.Size = new System.Drawing.Size(193, 159);
            this.pictureBox_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Logo.TabIndex = 9;
            this.pictureBox_Logo.TabStop = false;
            // 
            // button_SVDangNhap
            // 
            this.button_SVDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(193)))), ((int)(((byte)(148)))));
            this.button_SVDangNhap.FlatAppearance.BorderSize = 0;
            this.button_SVDangNhap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(255)))), ((int)(((byte)(253)))));
            this.button_SVDangNhap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(255)))), ((int)(((byte)(249)))));
            this.button_SVDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SVDangNhap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_SVDangNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(75)))), ((int)(((byte)(73)))));
            this.button_SVDangNhap.Location = new System.Drawing.Point(26, 507);
            this.button_SVDangNhap.Name = "button_SVDangNhap";
            this.button_SVDangNhap.Size = new System.Drawing.Size(344, 50);
            this.button_SVDangNhap.TabIndex = 10;
            this.button_SVDangNhap.Text = "Sinh viên đăng nhập";
            this.button_SVDangNhap.UseVisualStyleBackColor = false;
            this.button_SVDangNhap.Click += new System.EventHandler(this.button_SVDangNhap_Click);
            // 
            // label_DangNhapThatBai
            // 
            this.label_DangNhapThatBai.AutoSize = true;
            this.label_DangNhapThatBai.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_DangNhapThatBai.ForeColor = System.Drawing.Color.Red;
            this.label_DangNhapThatBai.Location = new System.Drawing.Point(26, 241);
            this.label_DangNhapThatBai.Name = "label_DangNhapThatBai";
            this.label_DangNhapThatBai.Size = new System.Drawing.Size(336, 23);
            this.label_DangNhapThatBai.TabIndex = 11;
            this.label_DangNhapThatBai.Text = "Tài khoản hoặc Mật khẩu không chính xác!";
            this.label_DangNhapThatBai.Visible = false;
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(402, 584);
            this.Controls.Add(this.label_DangNhapThatBai);
            this.Controls.Add(this.button_SVDangNhap);
            this.Controls.Add(this.pictureBox_Logo);
            this.Controls.Add(this.button_PDTDangNhap);
            this.Controls.Add(this.textBox_MatKhau);
            this.Controls.Add(this.textBox_TaiKhoan);
            this.Controls.Add(this.label_MatKhau);
            this.Controls.Add(this.label_TaiKhoan);
            this.Controls.Add(this.label_DangNhap);
            this.Controls.Add(this.iconButton_Minimize);
            this.Controls.Add(this.iconButton_Close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DangNhap";
            this.Text = "Đăng nhập";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButton_Close;
        private FontAwesome.Sharp.IconButton iconButton_Minimize;
        private Label label_DangNhap;
        private Label label_TaiKhoan;
        private Label label_MatKhau;
        private TextBox textBox_TaiKhoan;
        private TextBox textBox_MatKhau;
        private Button button_PDTDangNhap;
        private PictureBox pictureBox_Logo;
        private Button button_SVDangNhap;
        private Label label_DangNhapThatBai;
    }
}