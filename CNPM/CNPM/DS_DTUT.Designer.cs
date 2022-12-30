using System.Data;
using System.Data.SqlClient;

namespace SE104
{
    partial class DS_DTUT
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
            this.button_ThemDTUT = new System.Windows.Forms.Button();
            this.table_DSDTUT = new System.Windows.Forms.DataGridView();
            this.MaDTUT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiDTUT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TL_MienHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.UpdateColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.table_DSDTUT)).BeginInit();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_title.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_title.Location = new System.Drawing.Point(0, 0);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(509, 52);
            this.label_title.TabIndex = 15;
            this.label_title.Text = "Danh sách các loại đối tượng ưu tiên";
            this.label_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_ThemDTUT
            // 
            this.button_ThemDTUT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_ThemDTUT.FlatAppearance.BorderSize = 0;
            this.button_ThemDTUT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ThemDTUT.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_ThemDTUT.Location = new System.Drawing.Point(0, 529);
            this.button_ThemDTUT.Name = "button_ThemDTUT";
            this.button_ThemDTUT.Size = new System.Drawing.Size(509, 79);
            this.button_ThemDTUT.TabIndex = 13;
            this.button_ThemDTUT.Text = "+ Thêm loại đối tượng";
            this.button_ThemDTUT.UseVisualStyleBackColor = true;
            this.button_ThemDTUT.Click += new System.EventHandler(this.button_ThemDTUT_Click);
            // 
            // table_DSDTUT
            // 
            this.table_DSDTUT.AllowUserToAddRows = false;
            this.table_DSDTUT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.table_DSDTUT.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.table_DSDTUT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_DSDTUT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDTUT,
            this.TenLoaiDTUT,
            this.TL_MienHP,
            this.DeleteColumn,
            this.UpdateColumn});
            this.table_DSDTUT.Dock = System.Windows.Forms.DockStyle.Top;
            this.table_DSDTUT.Location = new System.Drawing.Point(0, 52);
            this.table_DSDTUT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.table_DSDTUT.Name = "table_DSDTUT";
            this.table_DSDTUT.RowHeadersVisible = false;
            this.table_DSDTUT.RowHeadersWidth = 51;
            this.table_DSDTUT.RowTemplate.Height = 25;
            this.table_DSDTUT.Size = new System.Drawing.Size(509, 477);
            this.table_DSDTUT.TabIndex = 12;
            this.table_DSDTUT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellClick);
            // 
            // MaDTUT
            // 
            this.MaDTUT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MaDTUT.DataPropertyName = "MaDTUT";
            this.MaDTUT.HeaderText = "Mã";
            this.MaDTUT.MinimumWidth = 6;
            this.MaDTUT.Name = "MaDTUT";
            this.MaDTUT.ReadOnly = true;
            this.MaDTUT.Width = 59;
            // 
            // TenLoaiDTUT
            // 
            this.TenLoaiDTUT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TenLoaiDTUT.DataPropertyName = "TenLoaiDTUT";
            this.TenLoaiDTUT.HeaderText = "Tên loại đối tượng";
            this.TenLoaiDTUT.MinimumWidth = 6;
            this.TenLoaiDTUT.Name = "TenLoaiDTUT";
            this.TenLoaiDTUT.ReadOnly = true;
            this.TenLoaiDTUT.Width = 110;
            // 
            // TL_MienHP
            // 
            this.TL_MienHP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TL_MienHP.DataPropertyName = "TL_MienHP";
            this.TL_MienHP.HeaderText = "Tỉ lệ miễn giảm học phí";
            this.TL_MienHP.MinimumWidth = 6;
            this.TL_MienHP.Name = "TL_MienHP";
            this.TL_MienHP.ReadOnly = true;
            this.TL_MienHP.Width = 133;
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
            // DS_DTUT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 608);
            this.Controls.Add(this.button_ThemDTUT);
            this.Controls.Add(this.table_DSDTUT);
            this.Controls.Add(this.label_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DS_DTUT";
            this.Text = "Các loại đối tượng ưu tiên";
            ((System.ComponentModel.ISupportInitialize)(this.table_DSDTUT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label_title;
        private Button button_ThemDTUT;
        private DataGridView table_DSDTUT;
        private DataGridViewTextBoxColumn MaDTUT;
        private DataGridViewTextBoxColumn TenLoaiDTUT;
        private DataGridViewTextBoxColumn TL_MienHP;
        private DataGridViewButtonColumn DeleteColumn;
        private DataGridViewButtonColumn UpdateColumn;
        private String ConnectionString = @System.IO.File.ReadAllText(@"ConnectionString.txt");
        private SqlConnection cnn;

        public void insertData()
        {
            var table = new DataTable();
            using (var adapter = new SqlDataAdapter("Select MaDTUT, TenLoaiDTUT, TL_MienHP from DTUT where MaDTUT > 0", this.cnn))
            {
                adapter.Fill(table);
            }
            this.table_DSDTUT.DataSource = table;
        }
    }
}