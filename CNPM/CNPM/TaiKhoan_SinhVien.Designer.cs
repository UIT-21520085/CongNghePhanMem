namespace CNPM
{
    partial class TaiKhoan_SinhVien
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
            this.dataGridView_SinhVien = new System.Windows.Forms.DataGridView();
            this.MSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDangNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_DoiMatKhau = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_SinhVien
            // 
            this.dataGridView_SinhVien.AllowUserToAddRows = false;
            this.dataGridView_SinhVien.AllowUserToDeleteRows = false;
            this.dataGridView_SinhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_SinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_SinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MSSV,
            this.TenDangNhap,
            this.MatKhau});
            this.dataGridView_SinhVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView_SinhVien.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_SinhVien.Name = "dataGridView_SinhVien";
            this.dataGridView_SinhVien.RowHeadersVisible = false;
            this.dataGridView_SinhVien.RowHeadersWidth = 51;
            this.dataGridView_SinhVien.RowTemplate.Height = 29;
            this.dataGridView_SinhVien.Size = new System.Drawing.Size(806, 400);
            this.dataGridView_SinhVien.TabIndex = 0;
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
            // TenDangNhap
            // 
            this.TenDangNhap.DataPropertyName = "TenDangNhap";
            this.TenDangNhap.HeaderText = "Tên đăng nhập";
            this.TenDangNhap.MinimumWidth = 6;
            this.TenDangNhap.Name = "TenDangNhap";
            this.TenDangNhap.ReadOnly = true;
            this.TenDangNhap.Width = 136;
            // 
            // MatKhau
            // 
            this.MatKhau.DataPropertyName = "MatKhau";
            this.MatKhau.HeaderText = "Mật khẩu";
            this.MatKhau.MinimumWidth = 6;
            this.MatKhau.Name = "MatKhau";
            this.MatKhau.ReadOnly = true;
            this.MatKhau.Width = 99;
            // 
            // button_DoiMatKhau
            // 
            this.button_DoiMatKhau.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_DoiMatKhau.FlatAppearance.BorderSize = 0;
            this.button_DoiMatKhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_DoiMatKhau.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_DoiMatKhau.Location = new System.Drawing.Point(0, 400);
            this.button_DoiMatKhau.Name = "button_DoiMatKhau";
            this.button_DoiMatKhau.Size = new System.Drawing.Size(806, 48);
            this.button_DoiMatKhau.TabIndex = 1;
            this.button_DoiMatKhau.Text = "Đổi mật khẩu";
            this.button_DoiMatKhau.UseVisualStyleBackColor = true;
            this.button_DoiMatKhau.Click += new System.EventHandler(this.button_DoiMatKhau_Click);
            // 
            // TaiKhoan_SinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 448);
            this.Controls.Add(this.button_DoiMatKhau);
            this.Controls.Add(this.dataGridView_SinhVien);
            this.Name = "TaiKhoan_SinhVien";
            this.Text = "TaiKhoan_SinhVien";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SinhVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView_SinhVien;
        private DataGridViewTextBoxColumn MSSV;
        private DataGridViewTextBoxColumn TenDangNhap;
        private DataGridViewTextBoxColumn MatKhau;
        private Button button_DoiMatKhau;
    }
}