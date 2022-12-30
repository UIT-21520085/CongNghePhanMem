namespace CNPM
{
    partial class TaiKhoan
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
            this.label_LoaiTaiKhoan = new System.Windows.Forms.Label();
            this.comboBox_LoaiTaiKhoan = new System.Windows.Forms.ComboBox();
            this.panel_TaiKhoan = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_title = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_LoaiTaiKhoan
            // 
            this.label_LoaiTaiKhoan.AutoSize = true;
            this.label_LoaiTaiKhoan.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_LoaiTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_LoaiTaiKhoan.Location = new System.Drawing.Point(3, 23);
            this.label_LoaiTaiKhoan.Name = "label_LoaiTaiKhoan";
            this.label_LoaiTaiKhoan.Size = new System.Drawing.Size(151, 28);
            this.label_LoaiTaiKhoan.TabIndex = 0;
            this.label_LoaiTaiKhoan.Text = "Loại tài khoản:";
            // 
            // comboBox_LoaiTaiKhoan
            // 
            this.comboBox_LoaiTaiKhoan.Dock = System.Windows.Forms.DockStyle.Left;
            this.comboBox_LoaiTaiKhoan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_LoaiTaiKhoan.FormattingEnabled = true;
            this.comboBox_LoaiTaiKhoan.Items.AddRange(new object[] {
            "Sinh viên",
            "Phòng đào tạo"});
            this.comboBox_LoaiTaiKhoan.Location = new System.Drawing.Point(154, 23);
            this.comboBox_LoaiTaiKhoan.Name = "comboBox_LoaiTaiKhoan";
            this.comboBox_LoaiTaiKhoan.Size = new System.Drawing.Size(149, 28);
            this.comboBox_LoaiTaiKhoan.TabIndex = 1;
            this.comboBox_LoaiTaiKhoan.SelectionChangeCommitted += new System.EventHandler(this.comboBox_LoaiTaiKhoan_SelectionChangeCommitted);
            // 
            // panel_TaiKhoan
            // 
            this.panel_TaiKhoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_TaiKhoan.Location = new System.Drawing.Point(0, 118);
            this.panel_TaiKhoan.Name = "panel_TaiKhoan";
            this.panel_TaiKhoan.Size = new System.Drawing.Size(800, 485);
            this.panel_TaiKhoan.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_LoaiTaiKhoan);
            this.groupBox1.Controls.Add(this.label_LoaiTaiKhoan);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(0, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 66);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // label_title
            // 
            this.label_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_title.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_title.Location = new System.Drawing.Point(0, 0);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(800, 52);
            this.label_title.TabIndex = 17;
            this.label_title.Text = "Danh sách tài khoản";
            this.label_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 603);
            this.Controls.Add(this.panel_TaiKhoan);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label_title);
            this.Name = "TaiKhoan";
            this.Text = "TaiKhoan";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label_LoaiTaiKhoan;
        private ComboBox comboBox_LoaiTaiKhoan;
        private Panel panel_TaiKhoan;
        private GroupBox groupBox1;
        private Label label_title;
    }
}