using System.Data.SqlClient;
using System.Data;

namespace SE104
{
    partial class DS_LoaiTC
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
            this.button_ThemLoaiTC = new System.Windows.Forms.Button();
            this.table_DSLoaiTC = new System.Windows.Forms.DataGridView();
            this.LoaiTinChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTietTinChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTienTinChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.UpdateColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label_title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.table_DSLoaiTC)).BeginInit();
            this.SuspendLayout();
            // 
            // button_ThemLoaiTC
            // 
            this.button_ThemLoaiTC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_ThemLoaiTC.FlatAppearance.BorderSize = 0;
            this.button_ThemLoaiTC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ThemLoaiTC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_ThemLoaiTC.Location = new System.Drawing.Point(0, 549);
            this.button_ThemLoaiTC.Name = "button_ThemLoaiTC";
            this.button_ThemLoaiTC.Size = new System.Drawing.Size(577, 59);
            this.button_ThemLoaiTC.TabIndex = 17;
            this.button_ThemLoaiTC.Text = "+ Thêm loại tín chỉ";
            this.button_ThemLoaiTC.UseVisualStyleBackColor = true;
            this.button_ThemLoaiTC.Click += new System.EventHandler(this.button_ThemLoaiTC_Click);
            // 
            // table_DSLoaiTC
            // 
            this.table_DSLoaiTC.AllowUserToAddRows = false;
            this.table_DSLoaiTC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.table_DSLoaiTC.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.table_DSLoaiTC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_DSLoaiTC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LoaiTinChi,
            this.SoTietTinChi,
            this.SoTienTinChi,
            this.DeleteColumn,
            this.UpdateColumn});
            this.table_DSLoaiTC.Dock = System.Windows.Forms.DockStyle.Top;
            this.table_DSLoaiTC.Location = new System.Drawing.Point(0, 46);
            this.table_DSLoaiTC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.table_DSLoaiTC.Name = "table_DSLoaiTC";
            this.table_DSLoaiTC.RowHeadersVisible = false;
            this.table_DSLoaiTC.RowHeadersWidth = 51;
            this.table_DSLoaiTC.RowTemplate.Height = 25;
            this.table_DSLoaiTC.Size = new System.Drawing.Size(577, 503);
            this.table_DSLoaiTC.TabIndex = 16;
            this.table_DSLoaiTC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellClick);
            // 
            // LoaiTinChi
            // 
            this.LoaiTinChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.LoaiTinChi.DataPropertyName = "LoaiTinChi";
            this.LoaiTinChi.HeaderText = "Loại tín chỉ";
            this.LoaiTinChi.MinimumWidth = 6;
            this.LoaiTinChi.Name = "LoaiTinChi";
            this.LoaiTinChi.ReadOnly = true;
            this.LoaiTinChi.Width = 110;
            // 
            // SoTietTinChi
            // 
            this.SoTietTinChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SoTietTinChi.DataPropertyName = "SoTietTinChi";
            this.SoTietTinChi.HeaderText = "Số tiết/tín chỉ";
            this.SoTietTinChi.MinimumWidth = 6;
            this.SoTietTinChi.Name = "SoTietTinChi";
            this.SoTietTinChi.ReadOnly = true;
            this.SoTietTinChi.Width = 127;
            // 
            // SoTienTinChi
            // 
            this.SoTienTinChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SoTienTinChi.DataPropertyName = "SoTienTinChi";
            this.SoTienTinChi.HeaderText = "Số tiền/tín chỉ";
            this.SoTienTinChi.MinimumWidth = 6;
            this.SoTienTinChi.Name = "SoTienTinChi";
            this.SoTienTinChi.ReadOnly = true;
            this.SoTienTinChi.Width = 130;
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
            this.label_title.Size = new System.Drawing.Size(577, 46);
            this.label_title.TabIndex = 18;
            this.label_title.Text = "Danh sách các loại tín chỉ";
            this.label_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DS_LoaiTC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 608);
            this.Controls.Add(this.button_ThemLoaiTC);
            this.Controls.Add(this.table_DSLoaiTC);
            this.Controls.Add(this.label_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DS_LoaiTC";
            this.Text = "Danh sách các loại tín chỉ";
            ((System.ComponentModel.ISupportInitialize)(this.table_DSLoaiTC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button button_ThemLoaiTC;
        private DataGridView table_DSLoaiTC;
        private DataGridViewTextBoxColumn LoaiTinChi;
        private DataGridViewTextBoxColumn SoTietTinChi;
        private DataGridViewTextBoxColumn SoTienTinChi;
        private DataGridViewButtonColumn DeleteColumn;
        private DataGridViewButtonColumn UpdateColumn;
        private String ConnectionString = @System.IO.File.ReadAllText(@"ConnectionString.txt");
        private SqlConnection cnn;

        public void insertData()
        {
            var table = new DataTable();
            using (var adapter = new SqlDataAdapter("Select LoaiTinChi, SoTietTinChi, SoTienTinChi from TINCHI", this.cnn))
            {
                adapter.Fill(table);
            }
            this.table_DSLoaiTC.DataSource = table;
        }

        private Label label_title;
    }
}