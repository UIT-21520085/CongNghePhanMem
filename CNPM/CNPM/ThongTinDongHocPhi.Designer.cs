namespace CNPM
{
    partial class ThongTinDongHocPhi
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
            this.Nam1 = new System.Windows.Forms.Label();
            this.HocKy1 = new System.Windows.Forms.Label();
            this.comboBox_Nam = new System.Windows.Forms.ComboBox();
            this.comboBox_HocKy = new System.Windows.Forms.ComboBox();
            this.dataGridView_ThongTinHocPhi = new System.Windows.Forms.DataGridView();
            this.SoPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTienDK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTienDong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTienConLai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XemChiTiet = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_TrangThai = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_TrangThai = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ThongTinHocPhi)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Nam1
            // 
            this.Nam1.AutoSize = true;
            this.Nam1.Dock = System.Windows.Forms.DockStyle.Left;
            this.Nam1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Nam1.Location = new System.Drawing.Point(3, 23);
            this.Nam1.Name = "Nam1";
            this.Nam1.Size = new System.Drawing.Size(104, 30);
            this.Nam1.TabIndex = 11;
            this.Nam1.Text = "Năm Học";
            // 
            // HocKy1
            // 
            this.HocKy1.AutoSize = true;
            this.HocKy1.Dock = System.Windows.Forms.DockStyle.Left;
            this.HocKy1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HocKy1.Location = new System.Drawing.Point(235, 23);
            this.HocKy1.Name = "HocKy1";
            this.HocKy1.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.HocKy1.Size = new System.Drawing.Size(131, 30);
            this.HocKy1.TabIndex = 10;
            this.HocKy1.Text = "Học Kỳ";
            // 
            // comboBox_Nam
            // 
            this.comboBox_Nam.Dock = System.Windows.Forms.DockStyle.Left;
            this.comboBox_Nam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Nam.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox_Nam.FormattingEnabled = true;
            this.comboBox_Nam.Location = new System.Drawing.Point(107, 23);
            this.comboBox_Nam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox_Nam.Name = "comboBox_Nam";
            this.comboBox_Nam.Size = new System.Drawing.Size(128, 36);
            this.comboBox_Nam.TabIndex = 9;
            this.comboBox_Nam.SelectionChangeCommitted += new System.EventHandler(this.comboBox_Nam_SelectionChangeCommitted);
            // 
            // comboBox_HocKy
            // 
            this.comboBox_HocKy.Dock = System.Windows.Forms.DockStyle.Left;
            this.comboBox_HocKy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_HocKy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox_HocKy.FormattingEnabled = true;
            this.comboBox_HocKy.Location = new System.Drawing.Point(366, 23);
            this.comboBox_HocKy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox_HocKy.Name = "comboBox_HocKy";
            this.comboBox_HocKy.Size = new System.Drawing.Size(128, 36);
            this.comboBox_HocKy.TabIndex = 8;
            this.comboBox_HocKy.SelectionChangeCommitted += new System.EventHandler(this.comboBox_HocKy_SelectionChangeCommitted);
            // 
            // dataGridView_ThongTinHocPhi
            // 
            this.dataGridView_ThongTinHocPhi.AllowUserToAddRows = false;
            this.dataGridView_ThongTinHocPhi.AllowUserToDeleteRows = false;
            this.dataGridView_ThongTinHocPhi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_ThongTinHocPhi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ThongTinHocPhi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoPhieu,
            this.MSSV,
            this.NgLap,
            this.SoTienDK,
            this.SoTienDong,
            this.SoTienConLai,
            this.XemChiTiet});
            this.dataGridView_ThongTinHocPhi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_ThongTinHocPhi.Location = new System.Drawing.Point(0, 165);
            this.dataGridView_ThongTinHocPhi.Name = "dataGridView_ThongTinHocPhi";
            this.dataGridView_ThongTinHocPhi.RowHeadersVisible = false;
            this.dataGridView_ThongTinHocPhi.RowHeadersWidth = 51;
            this.dataGridView_ThongTinHocPhi.RowTemplate.Height = 29;
            this.dataGridView_ThongTinHocPhi.Size = new System.Drawing.Size(940, 443);
            this.dataGridView_ThongTinHocPhi.TabIndex = 12;
            this.dataGridView_ThongTinHocPhi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_ThongTinHocPhi_CellClick);
            // 
            // SoPhieu
            // 
            this.SoPhieu.DataPropertyName = "SoPhieu";
            this.SoPhieu.HeaderText = "Số phiếu";
            this.SoPhieu.MinimumWidth = 6;
            this.SoPhieu.Name = "SoPhieu";
            this.SoPhieu.ReadOnly = true;
            this.SoPhieu.Width = 96;
            // 
            // MSSV
            // 
            this.MSSV.DataPropertyName = "MSSV";
            this.MSSV.HeaderText = "MSSV";
            this.MSSV.MinimumWidth = 6;
            this.MSSV.Name = "MSSV";
            this.MSSV.ReadOnly = true;
            this.MSSV.Width = 76;
            // 
            // NgLap
            // 
            this.NgLap.DataPropertyName = "NgLap";
            this.NgLap.HeaderText = "Ngày lập";
            this.NgLap.MinimumWidth = 6;
            this.NgLap.Name = "NgLap";
            this.NgLap.ReadOnly = true;
            this.NgLap.Width = 98;
            // 
            // SoTienDK
            // 
            this.SoTienDK.DataPropertyName = "SoTienDK";
            this.SoTienDK.HeaderText = "Số tiền đăng ký";
            this.SoTienDK.MinimumWidth = 6;
            this.SoTienDK.Name = "SoTienDK";
            this.SoTienDK.ReadOnly = true;
            this.SoTienDK.Width = 140;
            // 
            // SoTienDong
            // 
            this.SoTienDong.DataPropertyName = "SoTienDong";
            this.SoTienDong.HeaderText = "Số tiền đóng";
            this.SoTienDong.MinimumWidth = 6;
            this.SoTienDong.Name = "SoTienDong";
            this.SoTienDong.ReadOnly = true;
            this.SoTienDong.Width = 123;
            // 
            // SoTienConLai
            // 
            this.SoTienConLai.DataPropertyName = "SoTienConLai";
            this.SoTienConLai.HeaderText = "Số tiền còn lại";
            this.SoTienConLai.MinimumWidth = 6;
            this.SoTienConLai.Name = "SoTienConLai";
            this.SoTienConLai.ReadOnly = true;
            this.SoTienConLai.Width = 132;
            // 
            // XemChiTiet
            // 
            this.XemChiTiet.HeaderText = "Xem chi tiết";
            this.XemChiTiet.MinimumWidth = 6;
            this.XemChiTiet.Name = "XemChiTiet";
            this.XemChiTiet.Text = "Xem chi tiết";
            this.XemChiTiet.UseColumnTextForButtonValue = true;
            this.XemChiTiet.Width = 94;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_TrangThai);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox_HocKy);
            this.groupBox1.Controls.Add(this.HocKy1);
            this.groupBox1.Controls.Add(this.comboBox_Nam);
            this.groupBox1.Controls.Add(this.Nam1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(0, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(940, 82);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // comboBox_TrangThai
            // 
            this.comboBox_TrangThai.Dock = System.Windows.Forms.DockStyle.Left;
            this.comboBox_TrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_TrangThai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox_TrangThai.FormattingEnabled = true;
            this.comboBox_TrangThai.Items.AddRange(new object[] {
            "Đã hoàn thành học phí",
            "Chưa hoàn thành học phí"});
            this.comboBox_TrangThai.Location = new System.Drawing.Point(652, 23);
            this.comboBox_TrangThai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox_TrangThai.Name = "comboBox_TrangThai";
            this.comboBox_TrangThai.Size = new System.Drawing.Size(235, 36);
            this.comboBox_TrangThai.TabIndex = 12;
            this.comboBox_TrangThai.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(494, 23);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(158, 30);
            this.label2.TabIndex = 13;
            this.label2.Text = "Trạng thái";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(940, 50);
            this.label1.TabIndex = 14;
            this.label1.Text = "Thông tin đóng học phí";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_TrangThai
            // 
            this.label_TrangThai.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_TrangThai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_TrangThai.Location = new System.Drawing.Point(0, 132);
            this.label_TrangThai.Name = "label_TrangThai";
            this.label_TrangThai.Size = new System.Drawing.Size(940, 33);
            this.label_TrangThai.TabIndex = 15;
            this.label_TrangThai.Text = "label3";
            // 
            // ThongTinDongHocPhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 608);
            this.Controls.Add(this.dataGridView_ThongTinHocPhi);
            this.Controls.Add(this.label_TrangThai);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "ThongTinDongHocPhi";
            this.Text = "ThongTinDongHocPhi";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ThongTinHocPhi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label Nam1;
        private Label HocKy1;
        private ComboBox comboBox_Nam;
        private ComboBox comboBox_HocKy;
        private DataGridView dataGridView_ThongTinHocPhi;
        private DataGridViewTextBoxColumn SoPhieu;
        private DataGridViewTextBoxColumn MSSV;
        private DataGridViewTextBoxColumn NgLap;
        private DataGridViewTextBoxColumn SoTienDK;
        private DataGridViewTextBoxColumn SoTienDong;
        private DataGridViewTextBoxColumn SoTienConLai;
        private DataGridViewButtonColumn XemChiTiet;
        private GroupBox groupBox1;
        private Label label1;
        private ComboBox comboBox_TrangThai;
        private Label label2;
        private Label label_TrangThai;
    }
}