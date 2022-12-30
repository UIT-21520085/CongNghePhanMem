using System.Data;
using System.Data.SqlClient;

namespace SE104
{
    partial class DS_KHOA
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
            this.button_ThemKHOA = new System.Windows.Forms.Button();
            this.table_DSKhoa = new System.Windows.Forms.DataGridView();
            this.MaKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.UpdateColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.table_DSKhoa)).BeginInit();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_title.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_title.Location = new System.Drawing.Point(0, 0);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(530, 35);
            this.label_title.TabIndex = 7;
            this.label_title.Text = "Danh sách các khoa";
            this.label_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_ThemKHOA
            // 
            this.button_ThemKHOA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_ThemKHOA.FlatAppearance.BorderSize = 0;
            this.button_ThemKHOA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ThemKHOA.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_ThemKHOA.Location = new System.Drawing.Point(0, 534);
            this.button_ThemKHOA.Name = "button_ThemKHOA";
            this.button_ThemKHOA.Size = new System.Drawing.Size(530, 74);
            this.button_ThemKHOA.TabIndex = 5;
            this.button_ThemKHOA.Text = "+ Thêm khoa";
            this.button_ThemKHOA.UseVisualStyleBackColor = true;
            this.button_ThemKHOA.Click += new System.EventHandler(this.button_ThemKHOA_Click);
            // 
            // table_DSKhoa
            // 
            this.table_DSKhoa.AllowUserToAddRows = false;
            this.table_DSKhoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.table_DSKhoa.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.table_DSKhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_DSKhoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKhoa,
            this.TenKhoa,
            this.DeleteColumn,
            this.UpdateColumn});
            this.table_DSKhoa.Dock = System.Windows.Forms.DockStyle.Top;
            this.table_DSKhoa.Location = new System.Drawing.Point(0, 35);
            this.table_DSKhoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.table_DSKhoa.Name = "table_DSKhoa";
            this.table_DSKhoa.RowHeadersVisible = false;
            this.table_DSKhoa.RowHeadersWidth = 51;
            this.table_DSKhoa.RowTemplate.Height = 25;
            this.table_DSKhoa.Size = new System.Drawing.Size(530, 499);
            this.table_DSKhoa.TabIndex = 4;
            this.table_DSKhoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellClick);
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
            // TenKhoa
            // 
            this.TenKhoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TenKhoa.DataPropertyName = "TenKhoa";
            this.TenKhoa.HeaderText = "Tên khoa";
            this.TenKhoa.MinimumWidth = 6;
            this.TenKhoa.Name = "TenKhoa";
            this.TenKhoa.ReadOnly = true;
            this.TenKhoa.Width = 97;
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
            // DS_KHOA
            // 
            this.ClientSize = new System.Drawing.Size(530, 608);
            this.Controls.Add(this.button_ThemKHOA);
            this.Controls.Add(this.table_DSKhoa);
            this.Controls.Add(this.label_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DS_KHOA";
            this.Text = "Danh sách các khoa";
            ((System.ComponentModel.ISupportInitialize)(this.table_DSKhoa)).EndInit();
            this.ResumeLayout(false);

        }

        private Label label_title;
        private Button button_ThemKHOA;
        private DataGridView table_DSKhoa;
        private DataGridViewTextBoxColumn MaKhoa;
        private DataGridViewTextBoxColumn TenKhoa;
        private DataGridViewButtonColumn DeleteColumn;
        private DataGridViewButtonColumn UpdateColumn;

        #endregion

        public void insertData()
        {
            var table = new DataTable();
            using (var adapter = new SqlDataAdapter("Select MaKhoa, TenKhoa from KHOA", this.cnn))
            {
                adapter.Fill(table);
            }
            this.table_DSKhoa.DataSource = table;
        }

        private String ConnectionString = @System.IO.File.ReadAllText(@"ConnectionString.txt");
        private SqlConnection cnn;
    }
}