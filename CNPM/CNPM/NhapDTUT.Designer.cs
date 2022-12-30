using System.Data.SqlClient;

namespace SE104
{
    partial class NhapDTUT
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
            this.label_TL_MienHP = new System.Windows.Forms.Label();
            this.label_NhapTenMoi = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Huy = new System.Windows.Forms.Button();
            this.button_XacNhan = new System.Windows.Forms.Button();
            this.label_TenDTMoi = new System.Windows.Forms.Label();
            this.textBox_NhapTenLoaiDoiTuong = new System.Windows.Forms.TextBox();
            this.numericUpDown_TL_MienHP = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_TL_MienHP)).BeginInit();
            this.SuspendLayout();
            // 
            // label_TL_MienHP
            // 
            this.label_TL_MienHP.AutoSize = true;
            this.label_TL_MienHP.Location = new System.Drawing.Point(6, 56);
            this.label_TL_MienHP.Name = "label_TL_MienHP";
            this.label_TL_MienHP.Size = new System.Drawing.Size(168, 20);
            this.label_TL_MienHP.TabIndex = 35;
            this.label_TL_MienHP.Text = "Tỉ lệ miễn giảm học phí:";
            // 
            // label_NhapTenMoi
            // 
            this.label_NhapTenMoi.AutoSize = true;
            this.label_NhapTenMoi.Location = new System.Drawing.Point(67, 23);
            this.label_NhapTenMoi.Name = "label_NhapTenMoi";
            this.label_NhapTenMoi.Size = new System.Drawing.Size(103, 20);
            this.label_NhapTenMoi.TabIndex = 34;
            this.label_NhapTenMoi.Text = "Nhập tên mới:";
            this.label_NhapTenMoi.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_Huy);
            this.groupBox1.Controls.Add(this.button_XacNhan);
            this.groupBox1.Location = new System.Drawing.Point(-3, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 68);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            // 
            // button_Huy
            // 
            this.button_Huy.Location = new System.Drawing.Point(374, 23);
            this.button_Huy.Name = "button_Huy";
            this.button_Huy.Size = new System.Drawing.Size(94, 29);
            this.button_Huy.TabIndex = 1;
            this.button_Huy.Text = "Hủy";
            this.button_Huy.UseVisualStyleBackColor = true;
            this.button_Huy.Click += new System.EventHandler(this.button_Huy_Click);
            // 
            // button_XacNhan
            // 
            this.button_XacNhan.Location = new System.Drawing.Point(274, 23);
            this.button_XacNhan.Name = "button_XacNhan";
            this.button_XacNhan.Size = new System.Drawing.Size(94, 29);
            this.button_XacNhan.TabIndex = 0;
            this.button_XacNhan.Text = "Xác nhận";
            this.button_XacNhan.UseVisualStyleBackColor = true;
            // 
            // label_TenDTMoi
            // 
            this.label_TenDTMoi.AutoSize = true;
            this.label_TenDTMoi.Location = new System.Drawing.Point(10, 23);
            this.label_TenDTMoi.Name = "label_TenDTMoi";
            this.label_TenDTMoi.Size = new System.Drawing.Size(164, 20);
            this.label_TenDTMoi.TabIndex = 32;
            this.label_TenDTMoi.Text = "Tên loại đối tượng mới:";
            // 
            // textBox_NhapTenLoaiDoiTuong
            // 
            this.textBox_NhapTenLoaiDoiTuong.Location = new System.Drawing.Point(195, 20);
            this.textBox_NhapTenLoaiDoiTuong.MaxLength = 20;
            this.textBox_NhapTenLoaiDoiTuong.Name = "textBox_NhapTenLoaiDoiTuong";
            this.textBox_NhapTenLoaiDoiTuong.Size = new System.Drawing.Size(270, 27);
            this.textBox_NhapTenLoaiDoiTuong.TabIndex = 31;
            this.textBox_NhapTenLoaiDoiTuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_NhapTenLoaiDoiTuong_KeyPress);
            // 
            // numericUpDown_TL_MienHP
            // 
            this.numericUpDown_TL_MienHP.DecimalPlaces = 2;
            this.numericUpDown_TL_MienHP.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numericUpDown_TL_MienHP.Location = new System.Drawing.Point(195, 53);
            this.numericUpDown_TL_MienHP.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_TL_MienHP.Name = "numericUpDown_TL_MienHP";
            this.numericUpDown_TL_MienHP.Size = new System.Drawing.Size(57, 27);
            this.numericUpDown_TL_MienHP.TabIndex = 37;
            // 
            // NhapDTUT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 151);
            this.Controls.Add(this.numericUpDown_TL_MienHP);
            this.Controls.Add(this.label_TL_MienHP);
            this.Controls.Add(this.label_NhapTenMoi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label_TenDTMoi);
            this.Controls.Add(this.textBox_NhapTenLoaiDoiTuong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NhapDTUT";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_TL_MienHP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label_TL_MienHP;
        private Label label_NhapTenMoi;
        private GroupBox groupBox1;
        private Button button_Huy;
        private Button button_XacNhan;
        private Label label_TenDTMoi;
        private TextBox textBox_NhapTenLoaiDoiTuong;
        private String ConnectionString = @System.IO.File.ReadAllText(@"ConnectionString.txt");
        private SqlConnection cnn;
        private NumericUpDown numericUpDown_TL_MienHP;
        private String MaDTUT = null;
    }
}