namespace CNPM
{
    partial class DoiMatKhau
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_TenDangNhap = new System.Windows.Forms.TextBox();
            this.textBox_MatKhauMoi = new System.Windows.Forms.TextBox();
            this.button_DoiMatKhau = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(33, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(33, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu mới:";
            // 
            // textBox_TenDangNhap
            // 
            this.textBox_TenDangNhap.Location = new System.Drawing.Point(167, 31);
            this.textBox_TenDangNhap.MaxLength = 50;
            this.textBox_TenDangNhap.Name = "textBox_TenDangNhap";
            this.textBox_TenDangNhap.Size = new System.Drawing.Size(229, 27);
            this.textBox_TenDangNhap.TabIndex = 2;
            this.textBox_TenDangNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_TenDangNhap_KeyPress);
            // 
            // textBox_MatKhauMoi
            // 
            this.textBox_MatKhauMoi.Location = new System.Drawing.Point(167, 72);
            this.textBox_MatKhauMoi.MaxLength = 100;
            this.textBox_MatKhauMoi.Name = "textBox_MatKhauMoi";
            this.textBox_MatKhauMoi.Size = new System.Drawing.Size(229, 27);
            this.textBox_MatKhauMoi.TabIndex = 3;
            this.textBox_MatKhauMoi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_MatKhauMoi_KeyPress);
            // 
            // button_DoiMatKhau
            // 
            this.button_DoiMatKhau.Location = new System.Drawing.Point(167, 125);
            this.button_DoiMatKhau.Name = "button_DoiMatKhau";
            this.button_DoiMatKhau.Size = new System.Drawing.Size(131, 37);
            this.button_DoiMatKhau.TabIndex = 4;
            this.button_DoiMatKhau.Text = "Đổi mật khẩu";
            this.button_DoiMatKhau.UseVisualStyleBackColor = true;
            this.button_DoiMatKhau.Click += new System.EventHandler(this.button_DoiMatKhau_Click);
            // 
            // DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 174);
            this.Controls.Add(this.button_DoiMatKhau);
            this.Controls.Add(this.textBox_MatKhauMoi);
            this.Controls.Add(this.textBox_TenDangNhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DoiMatKhau";
            this.Text = "Đổi mật khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox_TenDangNhap;
        private TextBox textBox_MatKhauMoi;
        private Button button_DoiMatKhau;
    }
}