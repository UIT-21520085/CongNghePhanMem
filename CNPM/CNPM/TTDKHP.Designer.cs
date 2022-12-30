using System.Data;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;

namespace SE104
{
    partial class TTDKHP
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
            this.table_DS_MonHocDaDK = new System.Windows.Forms.DataGridView();
            this.MaMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiTinChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_HocKy = new System.Windows.Forms.ComboBox();
            this.comboBox_Nam = new System.Windows.Forms.ComboBox();
            this.label_HocKy = new System.Windows.Forms.Label();
            this.label_NamHoc = new System.Windows.Forms.Label();
            this.textBox_MSSV = new System.Windows.Forms.TextBox();
            this.label_MSSV = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.table_DS_MonHocDaDK)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_title.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_title.Location = new System.Drawing.Point(0, 0);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(739, 39);
            this.label_title.TabIndex = 5;
            this.label_title.Text = "Thông tin đăng ký học phần\r\n";
            this.label_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // table_DS_MonHocDaDK
            // 
            this.table_DS_MonHocDaDK.AllowUserToAddRows = false;
            this.table_DS_MonHocDaDK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.table_DS_MonHocDaDK.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.table_DS_MonHocDaDK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_DS_MonHocDaDK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaMH,
            this.TenMH,
            this.LoaiTinChi,
            this.SoTC,
            this.MaKhoa,
            this.MaNganh});
            this.table_DS_MonHocDaDK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table_DS_MonHocDaDK.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.table_DS_MonHocDaDK.Location = new System.Drawing.Point(0, 101);
            this.table_DS_MonHocDaDK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.table_DS_MonHocDaDK.Name = "table_DS_MonHocDaDK";
            this.table_DS_MonHocDaDK.ReadOnly = true;
            this.table_DS_MonHocDaDK.RowHeadersVisible = false;
            this.table_DS_MonHocDaDK.RowHeadersWidth = 51;
            this.table_DS_MonHocDaDK.RowTemplate.Height = 25;
            this.table_DS_MonHocDaDK.Size = new System.Drawing.Size(739, 402);
            this.table_DS_MonHocDaDK.TabIndex = 4;
            // 
            // MaMH
            // 
            this.MaMH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MaMH.DataPropertyName = "MaMH";
            this.MaMH.HeaderText = "Mã môn học";
            this.MaMH.MinimumWidth = 6;
            this.MaMH.Name = "MaMH";
            this.MaMH.ReadOnly = true;
            this.MaMH.Width = 121;
            // 
            // TenMH
            // 
            this.TenMH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TenMH.DataPropertyName = "TenMH";
            this.TenMH.HeaderText = "Tên môn học";
            this.TenMH.MinimumWidth = 6;
            this.TenMH.Name = "TenMH";
            this.TenMH.ReadOnly = true;
            this.TenMH.Width = 123;
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
            // SoTC
            // 
            this.SoTC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SoTC.DataPropertyName = "SoTC";
            this.SoTC.HeaderText = "Số tín chỉ";
            this.SoTC.MinimumWidth = 6;
            this.SoTC.Name = "SoTC";
            this.SoTC.ReadOnly = true;
            this.SoTC.Width = 99;
            // 
            // MaKhoa
            // 
            this.MaKhoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MaKhoa.DataPropertyName = "MaKhoa";
            this.MaKhoa.HeaderText = "Mã Khoa";
            this.MaKhoa.MinimumWidth = 6;
            this.MaKhoa.Name = "MaKhoa";
            this.MaKhoa.ReadOnly = true;
            this.MaKhoa.Width = 97;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_HocKy);
            this.groupBox1.Controls.Add(this.comboBox_Nam);
            this.groupBox1.Controls.Add(this.label_HocKy);
            this.groupBox1.Controls.Add(this.label_NamHoc);
            this.groupBox1.Controls.Add(this.textBox_MSSV);
            this.groupBox1.Controls.Add(this.label_MSSV);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(739, 62);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // comboBox_HocKy
            // 
            this.comboBox_HocKy.AllowDrop = true;
            this.comboBox_HocKy.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_HocKy.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_HocKy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_HocKy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox_HocKy.FormattingEnabled = true;
            this.comboBox_HocKy.Location = new System.Drawing.Point(621, 20);
            this.comboBox_HocKy.Name = "comboBox_HocKy";
            this.comboBox_HocKy.Size = new System.Drawing.Size(106, 28);
            this.comboBox_HocKy.TabIndex = 21;
            this.comboBox_HocKy.SelectedIndexChanged += new System.EventHandler(this.comboBox_HocKy_SelectedIndexChanged);
            // 
            // comboBox_Nam
            // 
            this.comboBox_Nam.AllowDrop = true;
            this.comboBox_Nam.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_Nam.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_Nam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Nam.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox_Nam.FormattingEnabled = true;
            this.comboBox_Nam.Location = new System.Drawing.Point(405, 20);
            this.comboBox_Nam.Name = "comboBox_Nam";
            this.comboBox_Nam.Size = new System.Drawing.Size(106, 28);
            this.comboBox_Nam.TabIndex = 20;
            this.comboBox_Nam.SelectedIndexChanged += new System.EventHandler(this.comboBox_Nam_SelectedIndexChanged);
            // 
            // label_HocKy
            // 
            this.label_HocKy.AutoSize = true;
            this.label_HocKy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_HocKy.Location = new System.Drawing.Point(558, 23);
            this.label_HocKy.Name = "label_HocKy";
            this.label_HocKy.Size = new System.Drawing.Size(57, 20);
            this.label_HocKy.TabIndex = 19;
            this.label_HocKy.Text = "Học kỳ:";
            // 
            // label_NamHoc
            // 
            this.label_NamHoc.AutoSize = true;
            this.label_NamHoc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_NamHoc.Location = new System.Drawing.Point(327, 23);
            this.label_NamHoc.Name = "label_NamHoc";
            this.label_NamHoc.Size = new System.Drawing.Size(72, 20);
            this.label_NamHoc.TabIndex = 18;
            this.label_NamHoc.Text = "Năm học:";
            // 
            // textBox_MSSV
            // 
            this.textBox_MSSV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_MSSV.Location = new System.Drawing.Point(73, 20);
            this.textBox_MSSV.Name = "textBox_MSSV";
            this.textBox_MSSV.ReadOnly = true;
            this.textBox_MSSV.Size = new System.Drawing.Size(214, 27);
            this.textBox_MSSV.TabIndex = 1;
            // 
            // label_MSSV
            // 
            this.label_MSSV.AutoSize = true;
            this.label_MSSV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_MSSV.Location = new System.Drawing.Point(17, 23);
            this.label_MSSV.Name = "label_MSSV";
            this.label_MSSV.Size = new System.Drawing.Size(50, 20);
            this.label_MSSV.TabIndex = 0;
            this.label_MSSV.Text = "MSSV:";
            // 
            // TTDKHP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 503);
            this.Controls.Add(this.table_DS_MonHocDaDK);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TTDKHP";
            this.Text = "Thông tin đăng ký học phần";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TTDKHP_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.table_DS_MonHocDaDK)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private void get_Nam()
        {
            var cmd = new SqlCommand("Select distinct Nam from HOCKY", this.cnn);
            SqlDataReader reader_Nam = cmd.ExecuteReader();

            while (reader_Nam.Read())
            {
                this.comboBox_Nam.Items.Add(reader_Nam["Nam"].ToString());
            }
            reader_Nam.Close();
        }

        private void get_HocKy(String Nam)
        {
            this.comboBox_HocKy.Items.Clear();
            var cmd = new SqlCommand("Select distinct HocKy from HOCKY where Nam = " + Nam, this.cnn);
            SqlDataReader reader_Huyen = cmd.ExecuteReader();
            while (reader_Huyen.Read())
            {
                this.comboBox_HocKy.Items.Add(reader_Huyen["HocKy"].ToString());
            }
            reader_Huyen.Close();
        }

        public void insertData(String HocKy, String Nam)
        {
            var table = new DataTable();
            using (var adapter = new SqlDataAdapter("select mh.MaMH, mh.TenMH, mh.LoaiTinChi, ct.SoTC, mh.MaKhoa, mh.MaNganh from DS_PHIEUDKHP ds inner join CT_PHIEUDK ct on ds.SoPhieu = ct.SoPhieu inner join DSMH mh on ct.MaMH = mh.MaMH where MSSV = '" + this.MSSV + "' and HocKy = " + HocKy + " and Nam = " + Nam, this.cnn))
            {
                adapter.Fill(table);
            }
            this.table_DS_MonHocDaDK.DataSource = table;
        }

        private Label label_title;
        private DataGridView table_DS_MonHocDaDK;
        private DataGridViewTextBoxColumn MaMH;
        private DataGridViewTextBoxColumn TenMH;
        private DataGridViewTextBoxColumn LoaiTinChi;
        private DataGridViewTextBoxColumn SoTC;
        private DataGridViewTextBoxColumn MaKhoa;
        private DataGridViewTextBoxColumn MaNganh;
        private SqlConnection cnn;
        private String ConnectionString = @System.IO.File.ReadAllText(@"ConnectionString.txt");
        private String MSSV;
        private GroupBox groupBox1;
        private TextBox textBox_MSSV;
        private Label label_MSSV;
        private ComboBox comboBox_HocKy;
        private ComboBox comboBox_Nam;
        private Label label_HocKy;
        private Label label_NamHoc;
    }
}