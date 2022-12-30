namespace danhsachmonhoc_mo
{
    partial class DanhSachMonHocMo
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.HocKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button_themdsmhmo = new System.Windows.Forms.Button();
            this.comboBox_filter_hk = new System.Windows.Forms.ComboBox();
            this.comboBox_filter_nam = new System.Windows.Forms.ComboBox();
            this.HocKy1 = new System.Windows.Forms.Label();
            this.Nam1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HocKy,
            this.Nam,
            this.MaMH,
            this.TenMH,
            this.Xoa});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 115);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(842, 438);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // HocKy
            // 
            this.HocKy.DataPropertyName = "HocKy";
            this.HocKy.HeaderText = "Học kỳ";
            this.HocKy.MinimumWidth = 6;
            this.HocKy.Name = "HocKy";
            this.HocKy.Visible = false;
            // 
            // Nam
            // 
            this.Nam.DataPropertyName = "Nam";
            this.Nam.HeaderText = "Năm";
            this.Nam.MinimumWidth = 6;
            this.Nam.Name = "Nam";
            this.Nam.Visible = false;
            // 
            // MaMH
            // 
            this.MaMH.DataPropertyName = "MaMH";
            this.MaMH.HeaderText = "Mã Môn học";
            this.MaMH.MinimumWidth = 6;
            this.MaMH.Name = "MaMH";
            this.MaMH.ReadOnly = true;
            // 
            // TenMH
            // 
            this.TenMH.DataPropertyName = "TenMH";
            this.TenMH.HeaderText = "Tên môn học";
            this.TenMH.MinimumWidth = 6;
            this.TenMH.Name = "TenMH";
            this.TenMH.ReadOnly = true;
            // 
            // Xoa
            // 
            this.Xoa.DataPropertyName = "Xoa";
            this.Xoa.HeaderText = "Xóa";
            this.Xoa.MinimumWidth = 6;
            this.Xoa.Name = "Xoa";
            this.Xoa.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Xoa.Text = "Xóa";
            this.Xoa.UseColumnTextForButtonValue = true;
            // 
            // button_themdsmhmo
            // 
            this.button_themdsmhmo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_themdsmhmo.FlatAppearance.BorderSize = 0;
            this.button_themdsmhmo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_themdsmhmo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_themdsmhmo.Location = new System.Drawing.Point(0, 553);
            this.button_themdsmhmo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_themdsmhmo.Name = "button_themdsmhmo";
            this.button_themdsmhmo.Size = new System.Drawing.Size(842, 55);
            this.button_themdsmhmo.TabIndex = 2;
            this.button_themdsmhmo.Text = "+ Thêm môn học mở";
            this.button_themdsmhmo.UseVisualStyleBackColor = true;
            this.button_themdsmhmo.Click += new System.EventHandler(this.button_themdsmhmo_Click);
            // 
            // comboBox_filter_hk
            // 
            this.comboBox_filter_hk.Dock = System.Windows.Forms.DockStyle.Left;
            this.comboBox_filter_hk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_filter_hk.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox_filter_hk.FormattingEnabled = true;
            this.comboBox_filter_hk.Location = new System.Drawing.Point(328, 23);
            this.comboBox_filter_hk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox_filter_hk.Name = "comboBox_filter_hk";
            this.comboBox_filter_hk.Size = new System.Drawing.Size(128, 36);
            this.comboBox_filter_hk.TabIndex = 4;
            this.comboBox_filter_hk.SelectionChangeCommitted += new System.EventHandler(this.comboBox_filter_hk_SelectionChangeCommitted);
            // 
            // comboBox_filter_nam
            // 
            this.comboBox_filter_nam.Dock = System.Windows.Forms.DockStyle.Left;
            this.comboBox_filter_nam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_filter_nam.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox_filter_nam.FormattingEnabled = true;
            this.comboBox_filter_nam.Location = new System.Drawing.Point(97, 23);
            this.comboBox_filter_nam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox_filter_nam.Name = "comboBox_filter_nam";
            this.comboBox_filter_nam.Size = new System.Drawing.Size(128, 36);
            this.comboBox_filter_nam.TabIndex = 5;
            this.comboBox_filter_nam.SelectionChangeCommitted += new System.EventHandler(this.comboBox_filter_nam_SelectionChangeCommitted);
            // 
            // HocKy1
            // 
            this.HocKy1.AutoSize = true;
            this.HocKy1.Dock = System.Windows.Forms.DockStyle.Left;
            this.HocKy1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HocKy1.Location = new System.Drawing.Point(225, 23);
            this.HocKy1.Name = "HocKy1";
            this.HocKy1.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.HocKy1.Size = new System.Drawing.Size(103, 28);
            this.HocKy1.TabIndex = 6;
            this.HocKy1.Text = "Học Kỳ";
            // 
            // Nam1
            // 
            this.Nam1.AutoSize = true;
            this.Nam1.Dock = System.Windows.Forms.DockStyle.Left;
            this.Nam1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Nam1.Location = new System.Drawing.Point(3, 23);
            this.Nam1.Name = "Nam1";
            this.Nam1.Size = new System.Drawing.Size(94, 28);
            this.Nam1.TabIndex = 7;
            this.Nam1.Text = "Năm Học";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_filter_hk);
            this.groupBox1.Controls.Add(this.HocKy1);
            this.groupBox1.Controls.Add(this.comboBox_filter_nam);
            this.groupBox1.Controls.Add(this.Nam1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(842, 67);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(842, 48);
            this.label1.TabIndex = 9;
            this.label1.Text = "Danh sách môn học mở";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DanhSachMonHocMo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 608);
            this.Controls.Add(this.button_themdsmhmo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DanhSachMonHocMo";
            this.Text = "Danh sách môn học mở";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_themdsmhmo;
        private System.Windows.Forms.ComboBox comboBox_filter_hk;
        private System.Windows.Forms.ComboBox comboBox_filter_nam;
        private System.Windows.Forms.Label HocKy1;
        private System.Windows.Forms.Label Nam1;
        private DataGridViewTextBoxColumn HocKy;
        private DataGridViewTextBoxColumn Nam;
        private DataGridViewTextBoxColumn MaMH;
        private DataGridViewTextBoxColumn TenMH;
        private DataGridViewButtonColumn Xoa;
        private GroupBox groupBox1;
        private Label label1;
    }
}
