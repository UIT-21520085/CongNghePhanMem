using System.Data.SqlClient;

namespace SE104
{
    partial class NhapKHOA
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
            this.label_TenKhoaMoi = new System.Windows.Forms.Label();
            this.textBox_NhapTenKhoa = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Huy = new System.Windows.Forms.Button();
            this.button_XacNhan = new System.Windows.Forms.Button();
            this.label_NhapTenMoi = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_TenKhoaMoi
            // 
            this.label_TenKhoaMoi.AutoSize = true;
            this.label_TenKhoaMoi.Location = new System.Drawing.Point(11, 21);
            this.label_TenKhoaMoi.Name = "label_TenKhoaMoi";
            this.label_TenKhoaMoi.Size = new System.Drawing.Size(139, 20);
            this.label_TenKhoaMoi.TabIndex = 3;
            this.label_TenKhoaMoi.Text = "Nhập tên khoa mới:";
            // 
            // textBox_NhapTenKhoa
            // 
            this.textBox_NhapTenKhoa.Location = new System.Drawing.Point(157, 19);
            this.textBox_NhapTenKhoa.MaxLength = 30;
            this.textBox_NhapTenKhoa.Name = "textBox_NhapTenKhoa";
            this.textBox_NhapTenKhoa.Size = new System.Drawing.Size(270, 27);
            this.textBox_NhapTenKhoa.TabIndex = 2;
            this.textBox_NhapTenKhoa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_NhapTenKhoa_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_Huy);
            this.groupBox1.Controls.Add(this.button_XacNhan);
            this.groupBox1.Location = new System.Drawing.Point(1, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(451, 68);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // button_Huy
            // 
            this.button_Huy.Location = new System.Drawing.Point(331, 27);
            this.button_Huy.Name = "button_Huy";
            this.button_Huy.Size = new System.Drawing.Size(94, 29);
            this.button_Huy.TabIndex = 1;
            this.button_Huy.Text = "Hủy";
            this.button_Huy.UseVisualStyleBackColor = true;
            this.button_Huy.Click += new System.EventHandler(this.button_Huy_Click);
            // 
            // button_XacNhan
            // 
            this.button_XacNhan.Location = new System.Drawing.Point(232, 27);
            this.button_XacNhan.Name = "button_XacNhan";
            this.button_XacNhan.Size = new System.Drawing.Size(94, 29);
            this.button_XacNhan.TabIndex = 0;
            this.button_XacNhan.Text = "Xác nhận";
            this.button_XacNhan.UseVisualStyleBackColor = true;
            // 
            // label_NhapTenMoi
            // 
            this.label_NhapTenMoi.AutoSize = true;
            this.label_NhapTenMoi.Location = new System.Drawing.Point(27, 21);
            this.label_NhapTenMoi.Name = "label_NhapTenMoi";
            this.label_NhapTenMoi.Size = new System.Drawing.Size(103, 20);
            this.label_NhapTenMoi.TabIndex = 24;
            this.label_NhapTenMoi.Text = "Nhập tên mới:";
            this.label_NhapTenMoi.Visible = false;
            // 
            // NhapKHOA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 119);
            this.Controls.Add(this.label_NhapTenMoi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label_TenKhoaMoi);
            this.Controls.Add(this.textBox_NhapTenKhoa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NhapKHOA";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private SqlConnection cnn;
        private String ConnectionString = @System.IO.File.ReadAllText(@"ConnectionString.txt");
        private Label label_TenKhoaMoi;
        private TextBox textBox_NhapTenKhoa;
        private GroupBox groupBox1;
        private Button button_Huy;
        private Button button_XacNhan;
        private Label label_NhapTenMoi;
        private String MaKhoa = null;
    }
}