namespace danhsachmonhoc_mo
{
    partial class DanhSachMonHocMo_insert
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
            this.HocKy = new System.Windows.Forms.Label();
            this.Nam = new System.Windows.Forms.Label();
            this.MaMH = new System.Windows.Forms.Label();
            this.comboBox_chonhocky = new System.Windows.Forms.ComboBox();
            this.button_themdsmhmo = new System.Windows.Forms.Button();
            this.button_dongthemdsmhmo = new System.Windows.Forms.Button();
            this.comboBox_nam = new System.Windows.Forms.ComboBox();
            this.comboBox_MaMonHoc = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // HocKy
            // 
            this.HocKy.AutoSize = true;
            this.HocKy.Location = new System.Drawing.Point(4, 61);
            this.HocKy.Name = "HocKy";
            this.HocKy.Size = new System.Drawing.Size(54, 20);
            this.HocKy.TabIndex = 0;
            this.HocKy.Text = "Học kỳ";
            // 
            // Nam
            // 
            this.Nam.AutoSize = true;
            this.Nam.Location = new System.Drawing.Point(4, 16);
            this.Nam.Name = "Nam";
            this.Nam.Size = new System.Drawing.Size(69, 20);
            this.Nam.TabIndex = 1;
            this.Nam.Text = "Năm học";
            // 
            // MaMH
            // 
            this.MaMH.AutoSize = true;
            this.MaMH.Location = new System.Drawing.Point(4, 110);
            this.MaMH.Name = "MaMH";
            this.MaMH.Size = new System.Drawing.Size(92, 20);
            this.MaMH.TabIndex = 2;
            this.MaMH.Text = "Mã Môn học";
            // 
            // comboBox_chonhocky
            // 
            this.comboBox_chonhocky.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_chonhocky.FormattingEnabled = true;
            this.comboBox_chonhocky.Location = new System.Drawing.Point(102, 58);
            this.comboBox_chonhocky.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox_chonhocky.Name = "comboBox_chonhocky";
            this.comboBox_chonhocky.Size = new System.Drawing.Size(137, 28);
            this.comboBox_chonhocky.TabIndex = 6;
            this.comboBox_chonhocky.SelectionChangeCommitted += new System.EventHandler(this.comboBox_chonhocky_SelectionChangeCommitted);
            // 
            // button_themdsmhmo
            // 
            this.button_themdsmhmo.Location = new System.Drawing.Point(49, 164);
            this.button_themdsmhmo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_themdsmhmo.Name = "button_themdsmhmo";
            this.button_themdsmhmo.Size = new System.Drawing.Size(100, 40);
            this.button_themdsmhmo.TabIndex = 7;
            this.button_themdsmhmo.Text = "Thêm";
            this.button_themdsmhmo.UseVisualStyleBackColor = true;
            this.button_themdsmhmo.Click += new System.EventHandler(this.button_themdsmhmo_Click);
            // 
            // button_dongthemdsmhmo
            // 
            this.button_dongthemdsmhmo.Location = new System.Drawing.Point(165, 164);
            this.button_dongthemdsmhmo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_dongthemdsmhmo.Name = "button_dongthemdsmhmo";
            this.button_dongthemdsmhmo.Size = new System.Drawing.Size(83, 41);
            this.button_dongthemdsmhmo.TabIndex = 8;
            this.button_dongthemdsmhmo.Text = "Đóng";
            this.button_dongthemdsmhmo.UseVisualStyleBackColor = true;
            this.button_dongthemdsmhmo.Click += new System.EventHandler(this.button_dongthemdsmhmo_Click);
            // 
            // comboBox_nam
            // 
            this.comboBox_nam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_nam.FormattingEnabled = true;
            this.comboBox_nam.Location = new System.Drawing.Point(102, 13);
            this.comboBox_nam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox_nam.Name = "comboBox_nam";
            this.comboBox_nam.Size = new System.Drawing.Size(137, 28);
            this.comboBox_nam.TabIndex = 9;
            this.comboBox_nam.SelectionChangeCommitted += new System.EventHandler(this.comboBox_nam_SelectionChangeCommitted);
            // 
            // comboBox_MaMonHoc
            // 
            this.comboBox_MaMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_MaMonHoc.FormattingEnabled = true;
            this.comboBox_MaMonHoc.Location = new System.Drawing.Point(102, 107);
            this.comboBox_MaMonHoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox_MaMonHoc.Name = "comboBox_MaMonHoc";
            this.comboBox_MaMonHoc.Size = new System.Drawing.Size(137, 28);
            this.comboBox_MaMonHoc.TabIndex = 10;
            // 
            // DanhSachMonHocMo_insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 218);
            this.Controls.Add(this.comboBox_MaMonHoc);
            this.Controls.Add(this.comboBox_nam);
            this.Controls.Add(this.button_dongthemdsmhmo);
            this.Controls.Add(this.button_themdsmhmo);
            this.Controls.Add(this.comboBox_chonhocky);
            this.Controls.Add(this.MaMH);
            this.Controls.Add(this.Nam);
            this.Controls.Add(this.HocKy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DanhSachMonHocMo_insert";
            this.Text = "Thêm môn học mở";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HocKy;
        private System.Windows.Forms.Label Nam;
        private System.Windows.Forms.Label MaMH;
        private System.Windows.Forms.ComboBox comboBox_chonhocky;
        private System.Windows.Forms.Button button_themdsmhmo;
        private System.Windows.Forms.Button button_dongthemdsmhmo;
        private System.Windows.Forms.ComboBox comboBox_nam;
        private ComboBox comboBox_MaMonHoc;
    }
}