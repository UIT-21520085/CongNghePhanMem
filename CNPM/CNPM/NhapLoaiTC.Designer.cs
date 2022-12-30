using System.Data.SqlClient;

namespace SE104
{
    partial class NhapLoaiTC
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
            this.numericUpDown_SoTietTinChi = new System.Windows.Forms.NumericUpDown();
            this.label_SoTietTinChi = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Huy = new System.Windows.Forms.Button();
            this.button_XacNhan = new System.Windows.Forms.Button();
            this.label_LoaiTC = new System.Windows.Forms.Label();
            this.textBox_LoaiTinChi = new System.Windows.Forms.TextBox();
            this.numericUpDown_SoTienTinChi = new System.Windows.Forms.NumericUpDown();
            this.label_SoTienTinChi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SoTietTinChi)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SoTienTinChi)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown_SoTietTinChi
            // 
            this.numericUpDown_SoTietTinChi.Location = new System.Drawing.Point(119, 40);
            this.numericUpDown_SoTietTinChi.Name = "numericUpDown_SoTietTinChi";
            this.numericUpDown_SoTietTinChi.Size = new System.Drawing.Size(57, 27);
            this.numericUpDown_SoTietTinChi.TabIndex = 43;
            // 
            // label_SoTietTinChi
            // 
            this.label_SoTietTinChi.AutoSize = true;
            this.label_SoTietTinChi.Location = new System.Drawing.Point(12, 42);
            this.label_SoTietTinChi.Name = "label_SoTietTinChi";
            this.label_SoTietTinChi.Size = new System.Drawing.Size(101, 20);
            this.label_SoTietTinChi.TabIndex = 42;
            this.label_SoTietTinChi.Text = "Số tiết/tín chỉ:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_Huy);
            this.groupBox1.Controls.Add(this.button_XacNhan);
            this.groupBox1.Location = new System.Drawing.Point(-3, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 68);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            // 
            // button_Huy
            // 
            this.button_Huy.Location = new System.Drawing.Point(153, 21);
            this.button_Huy.Name = "button_Huy";
            this.button_Huy.Size = new System.Drawing.Size(94, 29);
            this.button_Huy.TabIndex = 1;
            this.button_Huy.Text = "Hủy";
            this.button_Huy.UseVisualStyleBackColor = true;
            this.button_Huy.Click += new System.EventHandler(this.button_Huy_Click);
            // 
            // button_XacNhan
            // 
            this.button_XacNhan.Location = new System.Drawing.Point(22, 21);
            this.button_XacNhan.Name = "button_XacNhan";
            this.button_XacNhan.Size = new System.Drawing.Size(94, 29);
            this.button_XacNhan.TabIndex = 0;
            this.button_XacNhan.Text = "Xác nhận";
            this.button_XacNhan.UseVisualStyleBackColor = true;
            // 
            // label_LoaiTC
            // 
            this.label_LoaiTC.AutoSize = true;
            this.label_LoaiTC.Location = new System.Drawing.Point(12, 9);
            this.label_LoaiTC.Name = "label_LoaiTC";
            this.label_LoaiTC.Size = new System.Drawing.Size(84, 20);
            this.label_LoaiTC.TabIndex = 39;
            this.label_LoaiTC.Text = "Loại tín chỉ:";
            // 
            // textBox_LoaiTinChi
            // 
            this.textBox_LoaiTinChi.Location = new System.Drawing.Point(119, 6);
            this.textBox_LoaiTinChi.MaxLength = 3;
            this.textBox_LoaiTinChi.Name = "textBox_LoaiTinChi";
            this.textBox_LoaiTinChi.Size = new System.Drawing.Size(57, 27);
            this.textBox_LoaiTinChi.TabIndex = 38;
            this.textBox_LoaiTinChi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_LoaiTinChi_KeyPress);
            // 
            // numericUpDown_SoTienTinChi
            // 
            this.numericUpDown_SoTienTinChi.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_SoTienTinChi.Location = new System.Drawing.Point(119, 72);
            this.numericUpDown_SoTienTinChi.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDown_SoTienTinChi.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_SoTienTinChi.Name = "numericUpDown_SoTienTinChi";
            this.numericUpDown_SoTienTinChi.Size = new System.Drawing.Size(125, 27);
            this.numericUpDown_SoTienTinChi.TabIndex = 45;
            this.numericUpDown_SoTienTinChi.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // label_SoTienTinChi
            // 
            this.label_SoTienTinChi.AutoSize = true;
            this.label_SoTienTinChi.Location = new System.Drawing.Point(12, 74);
            this.label_SoTienTinChi.Name = "label_SoTienTinChi";
            this.label_SoTienTinChi.Size = new System.Drawing.Size(104, 20);
            this.label_SoTienTinChi.TabIndex = 44;
            this.label_SoTienTinChi.Text = "Số tiền/tín chỉ:";
            // 
            // NhapLoaiTC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 171);
            this.Controls.Add(this.numericUpDown_SoTienTinChi);
            this.Controls.Add(this.label_SoTienTinChi);
            this.Controls.Add(this.numericUpDown_SoTietTinChi);
            this.Controls.Add(this.label_SoTietTinChi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label_LoaiTC);
            this.Controls.Add(this.textBox_LoaiTinChi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NhapLoaiTC";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SoTietTinChi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_SoTienTinChi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown numericUpDown_SoTietTinChi;
        private Label label_SoTietTinChi;
        private GroupBox groupBox1;
        private Button button_Huy;
        private Button button_XacNhan;
        private Label label_LoaiTC;
        private TextBox textBox_LoaiTinChi;
        private NumericUpDown numericUpDown_SoTienTinChi;
        private Label label_SoTienTinChi;
        private String LoaiTC;
        private String ConnectionString = @System.IO.File.ReadAllText(@"ConnectionString.txt");
        private SqlConnection cnn;
    }
}