using System.Data.SqlClient;

namespace SE104
{
    partial class DongHP
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
            this.textBox_NhapSoTienDong = new System.Windows.Forms.TextBox();
            this.label_NhapSoTienDong = new System.Windows.Forms.Label();
            this.button_XacNhan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_NhapSoTienDong
            // 
            this.textBox_NhapSoTienDong.Location = new System.Drawing.Point(12, 40);
            this.textBox_NhapSoTienDong.MaxLength = 10;
            this.textBox_NhapSoTienDong.Name = "textBox_NhapSoTienDong";
            this.textBox_NhapSoTienDong.Size = new System.Drawing.Size(255, 27);
            this.textBox_NhapSoTienDong.TabIndex = 0;
            this.textBox_NhapSoTienDong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_NhapSoTienDong_KeyPress);
            // 
            // label_NhapSoTienDong
            // 
            this.label_NhapSoTienDong.AutoSize = true;
            this.label_NhapSoTienDong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_NhapSoTienDong.Location = new System.Drawing.Point(53, 9);
            this.label_NhapSoTienDong.Name = "label_NhapSoTienDong";
            this.label_NhapSoTienDong.Size = new System.Drawing.Size(175, 28);
            this.label_NhapSoTienDong.TabIndex = 1;
            this.label_NhapSoTienDong.Text = "Nhập số tiền đóng";
            // 
            // button_XacNhan
            // 
            this.button_XacNhan.Location = new System.Drawing.Point(90, 73);
            this.button_XacNhan.Name = "button_XacNhan";
            this.button_XacNhan.Size = new System.Drawing.Size(94, 29);
            this.button_XacNhan.TabIndex = 2;
            this.button_XacNhan.Text = "Xác nhận";
            this.button_XacNhan.UseVisualStyleBackColor = true;
            this.button_XacNhan.Click += new System.EventHandler(this.button_XacNhan_Click);
            // 
            // DongHP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 109);
            this.Controls.Add(this.button_XacNhan);
            this.Controls.Add(this.label_NhapSoTienDong);
            this.Controls.Add(this.textBox_NhapSoTienDong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DongHP";
            this.Text = "Đóng học phí";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox_NhapSoTienDong;
        private Label label_NhapSoTienDong;
        private Button button_XacNhan;
        private SqlConnection cnn;
        private String ConnectionString = @System.IO.File.ReadAllText(@"ConnectionString.txt");
        private decimal SoTienConLai;
        private String MSSV;
        private String Nam;
        private String HocKy;
    }
}