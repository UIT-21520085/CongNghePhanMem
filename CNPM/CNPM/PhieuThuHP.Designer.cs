using System.Data.SqlClient;

namespace SE104
{
    partial class PhieuThuHP
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
            this.label_title = new System.Windows.Forms.Label();
            this.label_SoPhieu = new System.Windows.Forms.Label();
            this.label_NgayLap = new System.Windows.Forms.Label();
            this.textBox_SoPhieu = new System.Windows.Forms.TextBox();
            this.textBox_NgayLap = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_SoTienThu = new System.Windows.Forms.TextBox();
            this.textBox_MSSV = new System.Windows.Forms.TextBox();
            this.label_SoTienThu = new System.Windows.Forms.Label();
            this.label_MSSV = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_title.Location = new System.Drawing.Point(140, 9);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(224, 37);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "Phiếu thu học phí";
            this.label_title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_SoPhieu
            // 
            this.label_SoPhieu.AutoSize = true;
            this.label_SoPhieu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_SoPhieu.Location = new System.Drawing.Point(12, 68);
            this.label_SoPhieu.Name = "label_SoPhieu";
            this.label_SoPhieu.Size = new System.Drawing.Size(81, 23);
            this.label_SoPhieu.TabIndex = 1;
            this.label_SoPhieu.Text = "Số phiếu:";
            // 
            // label_NgayLap
            // 
            this.label_NgayLap.AutoSize = true;
            this.label_NgayLap.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_NgayLap.Location = new System.Drawing.Point(282, 71);
            this.label_NgayLap.Name = "label_NgayLap";
            this.label_NgayLap.Size = new System.Drawing.Size(82, 23);
            this.label_NgayLap.TabIndex = 2;
            this.label_NgayLap.Text = "Ngày lập:";
            // 
            // textBox_SoPhieu
            // 
            this.textBox_SoPhieu.Location = new System.Drawing.Point(99, 67);
            this.textBox_SoPhieu.Name = "textBox_SoPhieu";
            this.textBox_SoPhieu.ReadOnly = true;
            this.textBox_SoPhieu.Size = new System.Drawing.Size(128, 27);
            this.textBox_SoPhieu.TabIndex = 5;
            // 
            // textBox_NgayLap
            // 
            this.textBox_NgayLap.Location = new System.Drawing.Point(370, 70);
            this.textBox_NgayLap.Name = "textBox_NgayLap";
            this.textBox_NgayLap.ReadOnly = true;
            this.textBox_NgayLap.Size = new System.Drawing.Size(128, 27);
            this.textBox_NgayLap.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_SoTienThu);
            this.groupBox1.Controls.Add(this.textBox_MSSV);
            this.groupBox1.Controls.Add(this.label_SoTienThu);
            this.groupBox1.Controls.Add(this.label_MSSV);
            this.groupBox1.Location = new System.Drawing.Point(0, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(518, 104);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // textBox_SoTienThu
            // 
            this.textBox_SoTienThu.Location = new System.Drawing.Point(203, 61);
            this.textBox_SoTienThu.Name = "textBox_SoTienThu";
            this.textBox_SoTienThu.ReadOnly = true;
            this.textBox_SoTienThu.Size = new System.Drawing.Size(161, 27);
            this.textBox_SoTienThu.TabIndex = 12;
            // 
            // textBox_MSSV
            // 
            this.textBox_MSSV.Location = new System.Drawing.Point(203, 22);
            this.textBox_MSSV.Name = "textBox_MSSV";
            this.textBox_MSSV.ReadOnly = true;
            this.textBox_MSSV.Size = new System.Drawing.Size(161, 27);
            this.textBox_MSSV.TabIndex = 11;
            // 
            // label_SoTienThu
            // 
            this.label_SoTienThu.AutoSize = true;
            this.label_SoTienThu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_SoTienThu.Location = new System.Drawing.Point(99, 62);
            this.label_SoTienThu.Name = "label_SoTienThu";
            this.label_SoTienThu.Size = new System.Drawing.Size(98, 23);
            this.label_SoTienThu.TabIndex = 10;
            this.label_SoTienThu.Text = "Số tiền thu:";
            // 
            // label_MSSV
            // 
            this.label_MSSV.AutoSize = true;
            this.label_MSSV.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_MSSV.Location = new System.Drawing.Point(99, 23);
            this.label_MSSV.Name = "label_MSSV";
            this.label_MSSV.Size = new System.Drawing.Size(58, 23);
            this.label_MSSV.TabIndex = 9;
            this.label_MSSV.Text = "MSSV:";
            // 
            // PhieuThuHP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 206);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox_NgayLap);
            this.Controls.Add(this.textBox_SoPhieu);
            this.Controls.Add(this.label_NgayLap);
            this.Controls.Add(this.label_SoPhieu);
            this.Controls.Add(this.label_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PhieuThuHP";
            this.Text = "Phiếu thu học phí";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private String MSSV;
        private String SoPhieu;
        private String SoTienThu;
        private String NgLap;
        private SqlConnection cnn;
        private String ConnectionString = @System.IO.File.ReadAllText(@"ConnectionString.txt");
        private Label label_title;
        private Label label_SoPhieu;
        private Label label_NgayLap;
        private TextBox textBox_SoPhieu;
        private TextBox textBox_NgayLap;
        private GroupBox groupBox1;
        private TextBox textBox_SoTienThu;
        private TextBox textBox_MSSV;
        private Label label_SoTienThu;
        private Label label_MSSV;
    }
}