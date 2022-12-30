namespace CNPM
{
    partial class TaiKhoan_PDT
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
            this.dataGridView_PDT = new System.Windows.Forms.DataGridView();
            this.TenDangNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_DoiMatKhau = new System.Windows.Forms.Button();
            this.button_ThemTaiKhoan = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PDT)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_PDT
            // 
            this.dataGridView_PDT.AllowUserToAddRows = false;
            this.dataGridView_PDT.AllowUserToDeleteRows = false;
            this.dataGridView_PDT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_PDT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_PDT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenDangNhap,
            this.MatKhau});
            this.dataGridView_PDT.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView_PDT.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_PDT.Name = "dataGridView_PDT";
            this.dataGridView_PDT.RowHeadersVisible = false;
            this.dataGridView_PDT.RowHeadersWidth = 51;
            this.dataGridView_PDT.RowTemplate.Height = 29;
            this.dataGridView_PDT.Size = new System.Drawing.Size(800, 380);
            this.dataGridView_PDT.TabIndex = 2;
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
            this.button_DoiMatKhau.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_DoiMatKhau.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_DoiMatKhau.Location = new System.Drawing.Point(597, 23);
            this.button_DoiMatKhau.Name = "button_DoiMatKhau";
            this.button_DoiMatKhau.Size = new System.Drawing.Size(200, 42);
            this.button_DoiMatKhau.TabIndex = 3;
            this.button_DoiMatKhau.Text = "Đổi mật khẩu";
            this.button_DoiMatKhau.UseVisualStyleBackColor = true;
            this.button_DoiMatKhau.Click += new System.EventHandler(this.button_DoiMatKhau_Click);
            // 
            // button_ThemTaiKhoan
            // 
            this.button_ThemTaiKhoan.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_ThemTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_ThemTaiKhoan.Location = new System.Drawing.Point(3, 23);
            this.button_ThemTaiKhoan.Name = "button_ThemTaiKhoan";
            this.button_ThemTaiKhoan.Size = new System.Drawing.Size(200, 42);
            this.button_ThemTaiKhoan.TabIndex = 4;
            this.button_ThemTaiKhoan.Text = "+ Thêm tài khoản";
            this.button_ThemTaiKhoan.UseVisualStyleBackColor = true;
            this.button_ThemTaiKhoan.Click += new System.EventHandler(this.button_ThemTaiKhoan_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_ThemTaiKhoan);
            this.groupBox1.Controls.Add(this.button_DoiMatKhau);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 380);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 68);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // TaiKhoan_PDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 448);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView_PDT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TaiKhoan_PDT";
            this.Text = "TaiKhoan_PDT";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PDT)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView_PDT;
        private DataGridViewTextBoxColumn TenDangNhap;
        private DataGridViewTextBoxColumn MatKhau;
        private Button button_DoiMatKhau;
        private Button button_ThemTaiKhoan;
        private GroupBox groupBox1;
    }
}