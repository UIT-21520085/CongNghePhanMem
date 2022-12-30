using System.Data;
using System.Data.SqlClient;

namespace SE104
{
    partial class DS_NGANH
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
            this.button_ThemNGANH = new System.Windows.Forms.Button();
            this.table_DSNganh = new System.Windows.Forms.DataGridView();
            this.MaNganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.UpdateColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label_title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.table_DSNganh)).BeginInit();
            this.SuspendLayout();
            // 
            // button_ThemNGANH
            // 
            this.button_ThemNGANH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_ThemNGANH.FlatAppearance.BorderSize = 0;
            this.button_ThemNGANH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ThemNGANH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_ThemNGANH.Location = new System.Drawing.Point(0, 546);
            this.button_ThemNGANH.Name = "button_ThemNGANH";
            this.button_ThemNGANH.Size = new System.Drawing.Size(586, 62);
            this.button_ThemNGANH.TabIndex = 9;
            this.button_ThemNGANH.Text = "+ Thêm ngành";
            this.button_ThemNGANH.UseVisualStyleBackColor = true;
            this.button_ThemNGANH.Click += new System.EventHandler(this.button_ThemNGANH_Click);
            // 
            // table_DSNganh
            // 
            this.table_DSNganh.AllowUserToAddRows = false;
            this.table_DSNganh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.table_DSNganh.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.table_DSNganh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_DSNganh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNganh,
            this.TenNganh,
            this.MaKhoa,
            this.DeleteColumn,
            this.UpdateColumn});
            this.table_DSNganh.Dock = System.Windows.Forms.DockStyle.Top;
            this.table_DSNganh.Location = new System.Drawing.Point(0, 46);
            this.table_DSNganh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.table_DSNganh.Name = "table_DSNganh";
            this.table_DSNganh.RowHeadersVisible = false;
            this.table_DSNganh.RowHeadersWidth = 51;
            this.table_DSNganh.RowTemplate.Height = 25;
            this.table_DSNganh.Size = new System.Drawing.Size(586, 500);
            this.table_DSNganh.TabIndex = 8;
            this.table_DSNganh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellClick);
            // 
            // MaNganh
            // 
            this.MaNganh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MaNganh.DataPropertyName = "MaNganh";
            this.MaNganh.HeaderText = "Mã Ngành";
            this.MaNganh.MinimumWidth = 6;
            this.MaNganh.Name = "MaNganh";
            this.MaNganh.ReadOnly = true;
            this.MaNganh.Width = 107;
            // 
            // TenNganh
            // 
            this.TenNganh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TenNganh.DataPropertyName = "TenNganh";
            this.TenNganh.HeaderText = "Tên Ngành";
            this.TenNganh.MinimumWidth = 6;
            this.TenNganh.Name = "TenNganh";
            this.TenNganh.ReadOnly = true;
            this.TenNganh.Width = 109;
            // 
            // MaKhoa
            // 
            this.MaKhoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MaKhoa.DataPropertyName = "MaKhoa";
            this.MaKhoa.HeaderText = "Mã khoa";
            this.MaKhoa.MinimumWidth = 6;
            this.MaKhoa.Name = "MaKhoa";
            this.MaKhoa.ReadOnly = true;
            this.MaKhoa.Width = 95;
            // 
            // DeleteColumn
            // 
            this.DeleteColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DeleteColumn.HeaderText = "";
            this.DeleteColumn.MinimumWidth = 6;
            this.DeleteColumn.Name = "DeleteColumn";
            this.DeleteColumn.Text = "Xóa";
            this.DeleteColumn.UseColumnTextForButtonValue = true;
            this.DeleteColumn.Width = 6;
            // 
            // UpdateColumn
            // 
            this.UpdateColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.UpdateColumn.HeaderText = "";
            this.UpdateColumn.MinimumWidth = 6;
            this.UpdateColumn.Name = "UpdateColumn";
            this.UpdateColumn.Text = "Cập nhật";
            this.UpdateColumn.UseColumnTextForButtonValue = true;
            this.UpdateColumn.Width = 6;
            // 
            // label_title
            // 
            this.label_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_title.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_title.Location = new System.Drawing.Point(0, 0);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(586, 46);
            this.label_title.TabIndex = 10;
            this.label_title.Text = "Danh sách các ngành";
            this.label_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DS_NGANH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 608);
            this.Controls.Add(this.button_ThemNGANH);
            this.Controls.Add(this.table_DSNganh);
            this.Controls.Add(this.label_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DS_NGANH";
            this.Text = "Danh sách các ngành";
            ((System.ComponentModel.ISupportInitialize)(this.table_DSNganh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button button_ThemNGANH;
        private DataGridView table_DSNganh;
        private DataGridViewTextBoxColumn MaNganh;
        private DataGridViewTextBoxColumn TenNganh;
        private DataGridViewTextBoxColumn MaKhoa;
        private DataGridViewButtonColumn DeleteColumn;
        private DataGridViewButtonColumn UpdateColumn;
        private String ConnectionString = @System.IO.File.ReadAllText(@"ConnectionString.txt");
        private SqlConnection cnn;

        public void insertData()
        {
            var table = new DataTable();
            using (var adapter = new SqlDataAdapter("Select MaNganh, TenNganh, MaKhoa from NGANH", this.cnn))
            {
                adapter.Fill(table);
            }
            this.table_DSNganh.DataSource = table;
        }

        private Label label_title;
    }
}