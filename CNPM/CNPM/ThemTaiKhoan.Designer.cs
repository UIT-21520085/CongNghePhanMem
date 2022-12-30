namespace CNPM
{
    partial class ThemTaiKhoan
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
            this.button_ThemTaiKhoan = new System.Windows.Forms.Button();
            this.textBox_MatKhauMoi = new System.Windows.Forms.TextBox();
            this.textBox_TenDangNhap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_ThemTaiKhoan
            // 
            this.button_ThemTaiKhoan.Location = new System.Drawing.Point(127, 109);
            this.button_ThemTaiKhoan.Name = "button_ThemTaiKhoan";
            this.button_ThemTaiKhoan.Size = new System.Drawing.Size(131, 37);
            this.button_ThemTaiKhoan.TabIndex = 9;
            this.button_ThemTaiKhoan.Text = "Thêm tài khoản";
            this.button_ThemTaiKhoan.UseVisualStyleBackColor = true;
            this.button_ThemTaiKhoan.Click += new System.EventHandler(this.button_ThemTaiKhoan_Click);
            // 
            // textBox_MatKhauMoi
            // 
            this.textBox_MatKhauMoi.Location = new System.Drawing.Point(161, 59);
            this.textBox_MatKhauMoi.MaxLength = 100;
            this.textBox_MatKhauMoi.Name = "textBox_MatKhauMoi";
            this.textBox_MatKhauMoi.Size = new System.Drawing.Size(229, 27);
            this.textBox_MatKhauMoi.TabIndex = 8;
            this.textBox_MatKhauMoi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_MatKhauMoi_KeyPress);
            // 
            // textBox_TenDangNhap
            // 
            this.textBox_TenDangNhap.Location = new System.Drawing.Point(161, 18);
            this.textBox_TenDangNhap.MaxLength = 50;
            this.textBox_TenDangNhap.Name = "textBox_TenDangNhap";
            this.textBox_TenDangNhap.Size = new System.Drawing.Size(229, 27);
            this.textBox_TenDangNhap.TabIndex = 7;
            this.textBox_TenDangNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_TenDangNhap_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(27, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mật khẩu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(27, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tên đăng nhập:";
            // 
            // ThemTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 169);
            this.Controls.Add(this.button_ThemTaiKhoan);
            this.Controls.Add(this.textBox_MatKhauMoi);
            this.Controls.Add(this.textBox_TenDangNhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ThemTaiKhoan";
            this.Text = "Thêm tài khoản";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button_ThemTaiKhoan;
        private TextBox textBox_MatKhauMoi;
        private TextBox textBox_TenDangNhap;
        private Label label2;
        private Label label1;
    }
}