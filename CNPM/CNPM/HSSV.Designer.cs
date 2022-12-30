using System.Data.SqlClient;
using System.Data;

namespace SE104
{
    partial class HSSV
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.table_DSHSSV = new System.Windows.Forms.DataGridView();
            this.MSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTUT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.UpdateColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button_ThemHS = new System.Windows.Forms.Button();
            this.label_title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.table_DSHSSV)).BeginInit();
            this.SuspendLayout();
            // 
            // table_DSHSSV
            // 
            this.table_DSHSSV.AllowUserToAddRows = false;
            this.table_DSHSSV.AllowUserToDeleteRows = false;
            this.table_DSHSSV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.table_DSHSSV.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.table_DSHSSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_DSHSSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MSSV,
            this.HoTen,
            this.NgaySinh,
            this.GioiTinh,
            this.MaHuyen,
            this.MaTinh,
            this.DTUT,
            this.MaKhoa,
            this.MaNganh,
            this.DeleteColumn,
            this.UpdateColumn});
            this.table_DSHSSV.Dock = System.Windows.Forms.DockStyle.Top;
            this.table_DSHSSV.Location = new System.Drawing.Point(0, 35);
            this.table_DSHSSV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.table_DSHSSV.Name = "table_DSHSSV";
            this.table_DSHSSV.RowHeadersVisible = false;
            this.table_DSHSSV.RowHeadersWidth = 51;
            this.table_DSHSSV.RowTemplate.Height = 25;
            this.table_DSHSSV.Size = new System.Drawing.Size(982, 520);
            this.table_DSHSSV.TabIndex = 0;
            this.table_DSHSSV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellClick);
            // 
            // MSSV
            // 
            this.MSSV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MSSV.DataPropertyName = "MSSV";
            this.MSSV.HeaderText = "MSSV";
            this.MSSV.MinimumWidth = 6;
            this.MSSV.Name = "MSSV";
            this.MSSV.ReadOnly = true;
            this.MSSV.Width = 76;
            // 
            // HoTen
            // 
            this.HoTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Họ và tên";
            this.HoTen.MinimumWidth = 6;
            this.HoTen.Name = "HoTen";
            this.HoTen.ReadOnly = true;
            this.HoTen.Width = 102;
            // 
            // NgaySinh
            // 
            this.NgaySinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày sinh";
            this.NgaySinh.MinimumWidth = 6;
            this.NgaySinh.Name = "NgaySinh";
            this.NgaySinh.ReadOnly = true;
            this.NgaySinh.Width = 103;
            // 
            // GioiTinh
            // 
            this.GioiTinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.MinimumWidth = 6;
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.ReadOnly = true;
            this.GioiTinh.Width = 94;
            // 
            // MaHuyen
            // 
            this.MaHuyen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MaHuyen.DataPropertyName = "MaHuyen";
            this.MaHuyen.HeaderText = "Mã Huyện";
            this.MaHuyen.MinimumWidth = 6;
            this.MaHuyen.Name = "MaHuyen";
            this.MaHuyen.ReadOnly = true;
            this.MaHuyen.Width = 105;
            // 
            // MaTinh
            // 
            this.MaTinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MaTinh.DataPropertyName = "MaTinh";
            this.MaTinh.HeaderText = "Mã Tỉnh";
            this.MaTinh.MinimumWidth = 6;
            this.MaTinh.Name = "MaTinh";
            this.MaTinh.ReadOnly = true;
            this.MaTinh.Width = 91;
            // 
            // DTUT
            // 
            this.DTUT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DTUT.DataPropertyName = "DTUT";
            this.DTUT.HeaderText = "Đối tượng";
            this.DTUT.MinimumWidth = 6;
            this.DTUT.Name = "DTUT";
            this.DTUT.ReadOnly = true;
            this.DTUT.Width = 106;
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
            // DeleteColumn
            // 
            this.DeleteColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DeleteColumn.HeaderText = "Xóa";
            this.DeleteColumn.MinimumWidth = 6;
            this.DeleteColumn.Name = "DeleteColumn";
            this.DeleteColumn.Text = "Xóa";
            this.DeleteColumn.UseColumnTextForButtonValue = true;
            this.DeleteColumn.Width = 41;
            // 
            // UpdateColumn
            // 
            this.UpdateColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.UpdateColumn.HeaderText = "Cập nhật";
            this.UpdateColumn.MinimumWidth = 6;
            this.UpdateColumn.Name = "UpdateColumn";
            this.UpdateColumn.Text = "Cập nhật";
            this.UpdateColumn.UseColumnTextForButtonValue = true;
            this.UpdateColumn.Width = 74;
            // 
            // button_ThemHS
            // 
            this.button_ThemHS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_ThemHS.FlatAppearance.BorderSize = 0;
            this.button_ThemHS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ThemHS.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_ThemHS.Location = new System.Drawing.Point(0, 555);
            this.button_ThemHS.Name = "button_ThemHS";
            this.button_ThemHS.Size = new System.Drawing.Size(982, 53);
            this.button_ThemHS.TabIndex = 1;
            this.button_ThemHS.Text = "+ Thêm hồ sơ";
            this.button_ThemHS.UseVisualStyleBackColor = true;
            this.button_ThemHS.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_title
            // 
            this.label_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_title.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_title.Location = new System.Drawing.Point(0, 0);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(982, 35);
            this.label_title.TabIndex = 3;
            this.label_title.Text = "Danh sách hồ sơ sinh viên";
            this.label_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HSSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 608);
            this.Controls.Add(this.button_ThemHS);
            this.Controls.Add(this.table_DSHSSV);
            this.Controls.Add(this.label_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HSSV";
            this.Text = "Danh sách hồ sơ sinh viên";
            ((System.ComponentModel.ISupportInitialize)(this.table_DSHSSV)).EndInit();
            this.ResumeLayout(false);

        }

        public void insertData()
        {
            var table = new DataTable();
            using (var adapter = new SqlDataAdapter(this.LoadDataQuery, this.cnn))
            {
                adapter.Fill(table);
            }
            this.table_DSHSSV.DataSource = table;
        }

        private SqlConnection cnn;
        private DataGridView table_DSHSSV;
        private Button button_ThemHS;
        private String LoadDataQuery = "select * from HSSV";
        private Label label_title;
        private String ConnectionString = @System.IO.File.ReadAllText(@"ConnectionString.txt");
        private DataGridViewTextBoxColumn MSSV;
        private DataGridViewTextBoxColumn HoTen;
        private DataGridViewTextBoxColumn NgaySinh;
        private DataGridViewTextBoxColumn GioiTinh;
        private DataGridViewTextBoxColumn MaHuyen;
        private DataGridViewTextBoxColumn MaTinh;
        private DataGridViewTextBoxColumn DTUT;
        private DataGridViewTextBoxColumn MaKhoa;
        private DataGridViewTextBoxColumn MaNganh;
        private DataGridViewButtonColumn DeleteColumn;
        private DataGridViewButtonColumn UpdateColumn;
    }
}
#endregion