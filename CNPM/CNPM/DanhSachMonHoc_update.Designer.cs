namespace danhsachmonhoc
{
    partial class DanhSachMonHoc_update
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
            this.MaMH = new System.Windows.Forms.Label();
            this.TenMH = new System.Windows.Forms.Label();
            this.SoTiet = new System.Windows.Forms.Label();
            this.LoaiTinChi = new System.Windows.Forms.Label();
            this.MaNganh = new System.Windows.Forms.Label();
            this.MaKhoa = new System.Windows.Forms.Label();
            this.textBox_SoTiet = new System.Windows.Forms.TextBox();
            this.button_suadsmh = new System.Windows.Forms.Button();
            this.comboBox_upd_khoa = new System.Windows.Forms.ComboBox();
            this.comboBox_mamh = new System.Windows.Forms.ComboBox();
            this.comboBox_upd_loaitinchi = new System.Windows.Forms.ComboBox();
            this.comboBox_upd_nganh = new System.Windows.Forms.ComboBox();
            this.textBox_TenMonHoc = new System.Windows.Forms.TextBox();
            this.button_Dong = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // MaMH
            // 
            this.MaMH.AutoSize = true;
            this.MaMH.Location = new System.Drawing.Point(58, 58);
            this.MaMH.Name = "MaMH";
            this.MaMH.Size = new System.Drawing.Size(92, 20);
            this.MaMH.TabIndex = 0;
            this.MaMH.Text = "Mã Môn học";
            // 
            // TenMH
            // 
            this.TenMH.AutoSize = true;
            this.TenMH.Location = new System.Drawing.Point(58, 159);
            this.TenMH.Name = "TenMH";
            this.TenMH.Size = new System.Drawing.Size(94, 20);
            this.TenMH.TabIndex = 1;
            this.TenMH.Text = "Tên Môn học";
            // 
            // SoTiet
            // 
            this.SoTiet.AutoSize = true;
            this.SoTiet.Location = new System.Drawing.Point(58, 255);
            this.SoTiet.Name = "SoTiet";
            this.SoTiet.Size = new System.Drawing.Size(55, 20);
            this.SoTiet.TabIndex = 2;
            this.SoTiet.Text = "Số Tiết";
            // 
            // LoaiTinChi
            // 
            this.LoaiTinChi.AutoSize = true;
            this.LoaiTinChi.Location = new System.Drawing.Point(423, 58);
            this.LoaiTinChi.Name = "LoaiTinChi";
            this.LoaiTinChi.Size = new System.Drawing.Size(86, 20);
            this.LoaiTinChi.TabIndex = 3;
            this.LoaiTinChi.Text = "Loại Tín Chỉ";
            // 
            // MaNganh
            // 
            this.MaNganh.AutoSize = true;
            this.MaNganh.Location = new System.Drawing.Point(423, 259);
            this.MaNganh.Name = "MaNganh";
            this.MaNganh.Size = new System.Drawing.Size(78, 20);
            this.MaNganh.TabIndex = 4;
            this.MaNganh.Text = "Mã Ngành";
            // 
            // MaKhoa
            // 
            this.MaKhoa.AutoSize = true;
            this.MaKhoa.Location = new System.Drawing.Point(423, 163);
            this.MaKhoa.Name = "MaKhoa";
            this.MaKhoa.Size = new System.Drawing.Size(68, 20);
            this.MaKhoa.TabIndex = 5;
            this.MaKhoa.Text = "Mã Khoa";
            // 
            // textBox_SoTiet
            // 
            this.textBox_SoTiet.Location = new System.Drawing.Point(164, 248);
            this.textBox_SoTiet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_SoTiet.Name = "textBox_SoTiet";
            this.textBox_SoTiet.Size = new System.Drawing.Size(212, 27);
            this.textBox_SoTiet.TabIndex = 8;
            // 
            // button_suadsmh
            // 
            this.button_suadsmh.Location = new System.Drawing.Point(334, 325);
            this.button_suadsmh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_suadsmh.Name = "button_suadsmh";
            this.button_suadsmh.Size = new System.Drawing.Size(148, 45);
            this.button_suadsmh.TabIndex = 13;
            this.button_suadsmh.Text = "Sửa";
            this.button_suadsmh.UseVisualStyleBackColor = true;
            this.button_suadsmh.Click += new System.EventHandler(this.button_suadsmh_Click);
            // 
            // comboBox_upd_khoa
            // 
            this.comboBox_upd_khoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_upd_khoa.FormattingEnabled = true;
            this.comboBox_upd_khoa.Location = new System.Drawing.Point(534, 156);
            this.comboBox_upd_khoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox_upd_khoa.Name = "comboBox_upd_khoa";
            this.comboBox_upd_khoa.Size = new System.Drawing.Size(212, 28);
            this.comboBox_upd_khoa.TabIndex = 16;
            this.comboBox_upd_khoa.SelectionChangeCommitted += new System.EventHandler(this.comboBox_upd_khoa_SelectionChangeCommitted);
            // 
            // comboBox_mamh
            // 
            this.comboBox_mamh.Enabled = false;
            this.comboBox_mamh.FormattingEnabled = true;
            this.comboBox_mamh.Location = new System.Drawing.Point(164, 48);
            this.comboBox_mamh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox_mamh.Name = "comboBox_mamh";
            this.comboBox_mamh.Size = new System.Drawing.Size(212, 28);
            this.comboBox_mamh.TabIndex = 19;
            // 
            // comboBox_upd_loaitinchi
            // 
            this.comboBox_upd_loaitinchi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_upd_loaitinchi.FormattingEnabled = true;
            this.comboBox_upd_loaitinchi.Location = new System.Drawing.Point(534, 48);
            this.comboBox_upd_loaitinchi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox_upd_loaitinchi.Name = "comboBox_upd_loaitinchi";
            this.comboBox_upd_loaitinchi.Size = new System.Drawing.Size(212, 28);
            this.comboBox_upd_loaitinchi.TabIndex = 20;
            // 
            // comboBox_upd_nganh
            // 
            this.comboBox_upd_nganh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_upd_nganh.FormattingEnabled = true;
            this.comboBox_upd_nganh.Location = new System.Drawing.Point(534, 252);
            this.comboBox_upd_nganh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox_upd_nganh.Name = "comboBox_upd_nganh";
            this.comboBox_upd_nganh.Size = new System.Drawing.Size(212, 28);
            this.comboBox_upd_nganh.TabIndex = 21;
            // 
            // textBox_TenMonHoc
            // 
            this.textBox_TenMonHoc.Location = new System.Drawing.Point(164, 152);
            this.textBox_TenMonHoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_TenMonHoc.MaxLength = 100;
            this.textBox_TenMonHoc.Name = "textBox_TenMonHoc";
            this.textBox_TenMonHoc.Size = new System.Drawing.Size(212, 27);
            this.textBox_TenMonHoc.TabIndex = 22;
            this.textBox_TenMonHoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_TenMonHoc_KeyPress);
            // 
            // button_Dong
            // 
            this.button_Dong.Location = new System.Drawing.Point(595, 370);
            this.button_Dong.Name = "button_Dong";
            this.button_Dong.Size = new System.Drawing.Size(94, 29);
            this.button_Dong.TabIndex = 23;
            this.button_Dong.Text = "Đóng";
            this.button_Dong.UseVisualStyleBackColor = true;
            this.button_Dong.Click += new System.EventHandler(this.button_Dong_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(164, 248);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(212, 27);
            this.numericUpDown1.TabIndex = 38;
            // 
            // DanhSachMonHoc_update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 442);
            this.Controls.Add(this.button_Dong);
            this.Controls.Add(this.textBox_TenMonHoc);
            this.Controls.Add(this.comboBox_upd_nganh);
            this.Controls.Add(this.comboBox_upd_loaitinchi);
            this.Controls.Add(this.comboBox_mamh);
            this.Controls.Add(this.comboBox_upd_khoa);
            this.Controls.Add(this.button_suadsmh);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.MaKhoa);
            this.Controls.Add(this.MaNganh);
            this.Controls.Add(this.LoaiTinChi);
            this.Controls.Add(this.SoTiet);
            this.Controls.Add(this.TenMH);
            this.Controls.Add(this.MaMH);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DanhSachMonHoc_update";
            this.Text = "Update danh sách môn học";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MaMH;
        private System.Windows.Forms.Label TenMH;
        private System.Windows.Forms.Label SoTiet;
        private System.Windows.Forms.Label LoaiTinChi;
        private System.Windows.Forms.Label MaNganh;
        private System.Windows.Forms.Label MaKhoa;
        private System.Windows.Forms.TextBox textBox_SoTiet;
        private System.Windows.Forms.Button button_suadsmh;
        private System.Windows.Forms.ComboBox comboBox_upd_khoa;
        private System.Windows.Forms.ComboBox comboBox_mamh;
        private System.Windows.Forms.ComboBox comboBox_upd_loaitinchi;
        private System.Windows.Forms.ComboBox comboBox_upd_nganh;
        private TextBox textBox_TenMonHoc;
        private Button button_Dong;
        private NumericUpDown numericUpDown1;
    }
}