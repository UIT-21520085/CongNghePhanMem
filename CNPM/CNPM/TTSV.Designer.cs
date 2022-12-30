using System.Data.SqlClient;

namespace SE104
{
    partial class TTSV
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
            this.groupBox_TTHS = new System.Windows.Forms.GroupBox();
            this.label_MSSV = new System.Windows.Forms.Label();
            this.textBox_MSSV = new System.Windows.Forms.TextBox();
            this.textBox_DoiTuong = new System.Windows.Forms.TextBox();
            this.textBox_Khoa = new System.Windows.Forms.TextBox();
            this.textBox_Nganh = new System.Windows.Forms.TextBox();
            this.textBox_Huyen = new System.Windows.Forms.TextBox();
            this.textBox_Tinh = new System.Windows.Forms.TextBox();
            this.textBox_NgaySinh = new System.Windows.Forms.TextBox();
            this.label_Khoa = new System.Windows.Forms.Label();
            this.label_Nganh = new System.Windows.Forms.Label();
            this.label_DoiTuong = new System.Windows.Forms.Label();
            this.label_Huyen = new System.Windows.Forms.Label();
            this.label_Tinh = new System.Windows.Forms.Label();
            this.label_QueQuan = new System.Windows.Forms.Label();
            this.radioButton_Nu = new System.Windows.Forms.RadioButton();
            this.radioButton_Nam = new System.Windows.Forms.RadioButton();
            this.label_GioiTinh = new System.Windows.Forms.Label();
            this.label_NgaySinh = new System.Windows.Forms.Label();
            this.label_HoVaTen = new System.Windows.Forms.Label();
            this.textBox_HoVaTen = new System.Windows.Forms.TextBox();
            this.groupBox_TT_DKHP = new System.Windows.Forms.GroupBox();
            this.groupBox_TTHP = new System.Windows.Forms.GroupBox();
            this.table_DS_MonHocDaDK = new System.Windows.Forms.DataGridView();
            this.MaMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiTinChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox_HocKy = new System.Windows.Forms.ComboBox();
            this.comboBox_Nam = new System.Windows.Forms.ComboBox();
            this.label_HocKy = new System.Windows.Forms.Label();
            this.label_Nam = new System.Windows.Forms.Label();
            this.textBox_SoTienConLai = new System.Windows.Forms.TextBox();
            this.textBox_SoTienThu = new System.Windows.Forms.TextBox();
            this.textBox_SoTienDaDong = new System.Windows.Forms.TextBox();
            this.label_SoTienThu = new System.Windows.Forms.Label();
            this.label_SoTienDaDong = new System.Windows.Forms.Label();
            this.label_SoTienConLai = new System.Windows.Forms.Label();
            this.groupBox_TTHS.SuspendLayout();
            this.groupBox_TTHP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_DS_MonHocDaDK)).BeginInit();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_title.Location = new System.Drawing.Point(127, 9);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(373, 35);
            this.label_title.TabIndex = 26;
            this.label_title.Text = "THÔNG TIN SINH VIÊN CHI TIẾT";
            // 
            // groupBox_TTHS
            // 
            this.groupBox_TTHS.Controls.Add(this.label_MSSV);
            this.groupBox_TTHS.Controls.Add(this.textBox_MSSV);
            this.groupBox_TTHS.Controls.Add(this.textBox_DoiTuong);
            this.groupBox_TTHS.Controls.Add(this.textBox_Khoa);
            this.groupBox_TTHS.Controls.Add(this.textBox_Nganh);
            this.groupBox_TTHS.Controls.Add(this.textBox_Huyen);
            this.groupBox_TTHS.Controls.Add(this.textBox_Tinh);
            this.groupBox_TTHS.Controls.Add(this.textBox_NgaySinh);
            this.groupBox_TTHS.Controls.Add(this.label_Khoa);
            this.groupBox_TTHS.Controls.Add(this.label_Nganh);
            this.groupBox_TTHS.Controls.Add(this.label_DoiTuong);
            this.groupBox_TTHS.Controls.Add(this.label_Huyen);
            this.groupBox_TTHS.Controls.Add(this.label_Tinh);
            this.groupBox_TTHS.Controls.Add(this.label_QueQuan);
            this.groupBox_TTHS.Controls.Add(this.radioButton_Nu);
            this.groupBox_TTHS.Controls.Add(this.radioButton_Nam);
            this.groupBox_TTHS.Controls.Add(this.label_GioiTinh);
            this.groupBox_TTHS.Controls.Add(this.label_NgaySinh);
            this.groupBox_TTHS.Controls.Add(this.label_HoVaTen);
            this.groupBox_TTHS.Controls.Add(this.textBox_HoVaTen);
            this.groupBox_TTHS.Location = new System.Drawing.Point(12, 57);
            this.groupBox_TTHS.Name = "groupBox_TTHS";
            this.groupBox_TTHS.Size = new System.Drawing.Size(616, 384);
            this.groupBox_TTHS.TabIndex = 27;
            this.groupBox_TTHS.TabStop = false;
            this.groupBox_TTHS.Text = "Thông tin hồ sơ";
            // 
            // label_MSSV
            // 
            this.label_MSSV.AutoSize = true;
            this.label_MSSV.Location = new System.Drawing.Point(20, 48);
            this.label_MSSV.Name = "label_MSSV";
            this.label_MSSV.Size = new System.Drawing.Size(50, 20);
            this.label_MSSV.TabIndex = 67;
            this.label_MSSV.Text = "MSSV:";
            // 
            // textBox_MSSV
            // 
            this.textBox_MSSV.Location = new System.Drawing.Point(99, 45);
            this.textBox_MSSV.Name = "textBox_MSSV";
            this.textBox_MSSV.ReadOnly = true;
            this.textBox_MSSV.Size = new System.Drawing.Size(197, 27);
            this.textBox_MSSV.TabIndex = 66;
            // 
            // textBox_DoiTuong
            // 
            this.textBox_DoiTuong.Location = new System.Drawing.Point(99, 263);
            this.textBox_DoiTuong.Name = "textBox_DoiTuong";
            this.textBox_DoiTuong.ReadOnly = true;
            this.textBox_DoiTuong.Size = new System.Drawing.Size(270, 27);
            this.textBox_DoiTuong.TabIndex = 65;
            // 
            // textBox_Khoa
            // 
            this.textBox_Khoa.Location = new System.Drawing.Point(99, 325);
            this.textBox_Khoa.Name = "textBox_Khoa";
            this.textBox_Khoa.ReadOnly = true;
            this.textBox_Khoa.Size = new System.Drawing.Size(151, 27);
            this.textBox_Khoa.TabIndex = 64;
            // 
            // textBox_Nganh
            // 
            this.textBox_Nganh.Location = new System.Drawing.Point(375, 325);
            this.textBox_Nganh.Name = "textBox_Nganh";
            this.textBox_Nganh.ReadOnly = true;
            this.textBox_Nganh.Size = new System.Drawing.Size(151, 27);
            this.textBox_Nganh.TabIndex = 63;
            // 
            // textBox_Huyen
            // 
            this.textBox_Huyen.Location = new System.Drawing.Point(375, 207);
            this.textBox_Huyen.Name = "textBox_Huyen";
            this.textBox_Huyen.ReadOnly = true;
            this.textBox_Huyen.Size = new System.Drawing.Size(151, 27);
            this.textBox_Huyen.TabIndex = 62;
            // 
            // textBox_Tinh
            // 
            this.textBox_Tinh.Location = new System.Drawing.Point(145, 207);
            this.textBox_Tinh.Name = "textBox_Tinh";
            this.textBox_Tinh.ReadOnly = true;
            this.textBox_Tinh.Size = new System.Drawing.Size(151, 27);
            this.textBox_Tinh.TabIndex = 61;
            // 
            // textBox_NgaySinh
            // 
            this.textBox_NgaySinh.Location = new System.Drawing.Point(99, 154);
            this.textBox_NgaySinh.Name = "textBox_NgaySinh";
            this.textBox_NgaySinh.ReadOnly = true;
            this.textBox_NgaySinh.Size = new System.Drawing.Size(197, 27);
            this.textBox_NgaySinh.TabIndex = 60;
            // 
            // label_Khoa
            // 
            this.label_Khoa.AutoSize = true;
            this.label_Khoa.Location = new System.Drawing.Point(20, 328);
            this.label_Khoa.Name = "label_Khoa";
            this.label_Khoa.Size = new System.Drawing.Size(46, 20);
            this.label_Khoa.TabIndex = 59;
            this.label_Khoa.Text = "Khoa:";
            // 
            // label_Nganh
            // 
            this.label_Nganh.AutoSize = true;
            this.label_Nganh.Location = new System.Drawing.Point(285, 328);
            this.label_Nganh.Name = "label_Nganh";
            this.label_Nganh.Size = new System.Drawing.Size(84, 20);
            this.label_Nganh.TabIndex = 58;
            this.label_Nganh.Text = "Ngành học:";
            // 
            // label_DoiTuong
            // 
            this.label_DoiTuong.AutoSize = true;
            this.label_DoiTuong.Location = new System.Drawing.Point(20, 266);
            this.label_DoiTuong.Name = "label_DoiTuong";
            this.label_DoiTuong.Size = new System.Drawing.Size(80, 20);
            this.label_DoiTuong.TabIndex = 57;
            this.label_DoiTuong.Text = "Đối tượng:";
            // 
            // label_Huyen
            // 
            this.label_Huyen.AutoSize = true;
            this.label_Huyen.Location = new System.Drawing.Point(315, 210);
            this.label_Huyen.Name = "label_Huyen";
            this.label_Huyen.Size = new System.Drawing.Size(54, 20);
            this.label_Huyen.TabIndex = 56;
            this.label_Huyen.Text = "Huyện:";
            // 
            // label_Tinh
            // 
            this.label_Tinh.AutoSize = true;
            this.label_Tinh.Location = new System.Drawing.Point(99, 210);
            this.label_Tinh.Name = "label_Tinh";
            this.label_Tinh.Size = new System.Drawing.Size(40, 20);
            this.label_Tinh.TabIndex = 55;
            this.label_Tinh.Text = "Tỉnh:";
            // 
            // label_QueQuan
            // 
            this.label_QueQuan.AutoSize = true;
            this.label_QueQuan.Location = new System.Drawing.Point(20, 210);
            this.label_QueQuan.Name = "label_QueQuan";
            this.label_QueQuan.Size = new System.Drawing.Size(76, 20);
            this.label_QueQuan.TabIndex = 54;
            this.label_QueQuan.Text = "Quê quán:";
            // 
            // radioButton_Nu
            // 
            this.radioButton_Nu.AutoSize = true;
            this.radioButton_Nu.Checked = true;
            this.radioButton_Nu.Enabled = false;
            this.radioButton_Nu.Location = new System.Drawing.Point(550, 102);
            this.radioButton_Nu.Name = "radioButton_Nu";
            this.radioButton_Nu.Size = new System.Drawing.Size(50, 24);
            this.radioButton_Nu.TabIndex = 53;
            this.radioButton_Nu.TabStop = true;
            this.radioButton_Nu.Text = "Nữ";
            this.radioButton_Nu.UseVisualStyleBackColor = true;
            // 
            // radioButton_Nam
            // 
            this.radioButton_Nam.AutoSize = true;
            this.radioButton_Nam.Enabled = false;
            this.radioButton_Nam.Location = new System.Drawing.Point(482, 102);
            this.radioButton_Nam.Name = "radioButton_Nam";
            this.radioButton_Nam.Size = new System.Drawing.Size(62, 24);
            this.radioButton_Nam.TabIndex = 52;
            this.radioButton_Nam.Text = "Nam";
            this.radioButton_Nam.UseVisualStyleBackColor = true;
            // 
            // label_GioiTinh
            // 
            this.label_GioiTinh.AutoSize = true;
            this.label_GioiTinh.Location = new System.Drawing.Point(408, 102);
            this.label_GioiTinh.Name = "label_GioiTinh";
            this.label_GioiTinh.Size = new System.Drawing.Size(68, 20);
            this.label_GioiTinh.TabIndex = 51;
            this.label_GioiTinh.Text = "Giới tính:";
            // 
            // label_NgaySinh
            // 
            this.label_NgaySinh.AutoSize = true;
            this.label_NgaySinh.Location = new System.Drawing.Point(20, 157);
            this.label_NgaySinh.Name = "label_NgaySinh";
            this.label_NgaySinh.Size = new System.Drawing.Size(77, 20);
            this.label_NgaySinh.TabIndex = 50;
            this.label_NgaySinh.Text = "Ngày sinh:";
            // 
            // label_HoVaTen
            // 
            this.label_HoVaTen.AutoSize = true;
            this.label_HoVaTen.Location = new System.Drawing.Point(20, 102);
            this.label_HoVaTen.Name = "label_HoVaTen";
            this.label_HoVaTen.Size = new System.Drawing.Size(76, 20);
            this.label_HoVaTen.TabIndex = 49;
            this.label_HoVaTen.Text = "Họ và tên:";
            // 
            // textBox_HoVaTen
            // 
            this.textBox_HoVaTen.Location = new System.Drawing.Point(99, 99);
            this.textBox_HoVaTen.Name = "textBox_HoVaTen";
            this.textBox_HoVaTen.ReadOnly = true;
            this.textBox_HoVaTen.Size = new System.Drawing.Size(270, 27);
            this.textBox_HoVaTen.TabIndex = 48;
            // 
            // groupBox_TT_DKHP
            // 
            this.groupBox_TT_DKHP.Location = new System.Drawing.Point(633, 559);
            this.groupBox_TT_DKHP.Name = "groupBox_TT_DKHP";
            this.groupBox_TT_DKHP.Size = new System.Drawing.Size(250, 125);
            this.groupBox_TT_DKHP.TabIndex = 28;
            this.groupBox_TT_DKHP.TabStop = false;
            this.groupBox_TT_DKHP.Text = "Thông tin đăng ký học phần";
            // 
            // groupBox_TTHP
            // 
            this.groupBox_TTHP.Controls.Add(this.table_DS_MonHocDaDK);
            this.groupBox_TTHP.Controls.Add(this.comboBox_HocKy);
            this.groupBox_TTHP.Controls.Add(this.comboBox_Nam);
            this.groupBox_TTHP.Controls.Add(this.label_HocKy);
            this.groupBox_TTHP.Controls.Add(this.label_Nam);
            this.groupBox_TTHP.Controls.Add(this.textBox_SoTienConLai);
            this.groupBox_TTHP.Controls.Add(this.textBox_SoTienThu);
            this.groupBox_TTHP.Controls.Add(this.textBox_SoTienDaDong);
            this.groupBox_TTHP.Controls.Add(this.label_SoTienThu);
            this.groupBox_TTHP.Controls.Add(this.label_SoTienDaDong);
            this.groupBox_TTHP.Controls.Add(this.label_SoTienConLai);
            this.groupBox_TTHP.Location = new System.Drawing.Point(12, 450);
            this.groupBox_TTHP.Name = "groupBox_TTHP";
            this.groupBox_TTHP.Size = new System.Drawing.Size(616, 302);
            this.groupBox_TTHP.TabIndex = 29;
            this.groupBox_TTHP.TabStop = false;
            this.groupBox_TTHP.Text = "Thông tin đăng ký học phần và học phí";
            // 
            // table_DS_MonHocDaDK
            // 
            this.table_DS_MonHocDaDK.AllowUserToAddRows = false;
            this.table_DS_MonHocDaDK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.table_DS_MonHocDaDK.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.table_DS_MonHocDaDK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_DS_MonHocDaDK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaMH,
            this.TenMH,
            this.LoaiTinChi,
            this.SoTC,
            this.MaKhoa,
            this.MaNganh});
            this.table_DS_MonHocDaDK.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.table_DS_MonHocDaDK.Location = new System.Drawing.Point(0, 139);
            this.table_DS_MonHocDaDK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.table_DS_MonHocDaDK.Name = "table_DS_MonHocDaDK";
            this.table_DS_MonHocDaDK.ReadOnly = true;
            this.table_DS_MonHocDaDK.RowHeadersWidth = 51;
            this.table_DS_MonHocDaDK.RowTemplate.Height = 25;
            this.table_DS_MonHocDaDK.Size = new System.Drawing.Size(615, 156);
            this.table_DS_MonHocDaDK.TabIndex = 44;
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
            // comboBox_HocKy
            // 
            this.comboBox_HocKy.AllowDrop = true;
            this.comboBox_HocKy.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_HocKy.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_HocKy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_HocKy.FormattingEnabled = true;
            this.comboBox_HocKy.Location = new System.Drawing.Point(256, 45);
            this.comboBox_HocKy.Name = "comboBox_HocKy";
            this.comboBox_HocKy.Size = new System.Drawing.Size(76, 28);
            this.comboBox_HocKy.TabIndex = 43;
            this.comboBox_HocKy.SelectedIndexChanged += new System.EventHandler(this.comboBox_HocKy_SelectedIndexChanged);
            // 
            // comboBox_Nam
            // 
            this.comboBox_Nam.AllowDrop = true;
            this.comboBox_Nam.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_Nam.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_Nam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Nam.FormattingEnabled = true;
            this.comboBox_Nam.Location = new System.Drawing.Point(106, 45);
            this.comboBox_Nam.Name = "comboBox_Nam";
            this.comboBox_Nam.Size = new System.Drawing.Size(81, 28);
            this.comboBox_Nam.TabIndex = 42;
            this.comboBox_Nam.SelectedIndexChanged += new System.EventHandler(this.comboBox_Nam_SelectedIndexChanged);
            // 
            // label_HocKy
            // 
            this.label_HocKy.AutoSize = true;
            this.label_HocKy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_HocKy.Location = new System.Drawing.Point(193, 48);
            this.label_HocKy.Name = "label_HocKy";
            this.label_HocKy.Size = new System.Drawing.Size(57, 20);
            this.label_HocKy.TabIndex = 41;
            this.label_HocKy.Text = "Học kỳ:";
            // 
            // label_Nam
            // 
            this.label_Nam.AutoSize = true;
            this.label_Nam.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Nam.Location = new System.Drawing.Point(28, 48);
            this.label_Nam.Name = "label_Nam";
            this.label_Nam.Size = new System.Drawing.Size(72, 20);
            this.label_Nam.TabIndex = 40;
            this.label_Nam.Text = "Năm học:";
            // 
            // textBox_SoTienConLai
            // 
            this.textBox_SoTienConLai.Location = new System.Drawing.Point(427, 96);
            this.textBox_SoTienConLai.Name = "textBox_SoTienConLai";
            this.textBox_SoTienConLai.ReadOnly = true;
            this.textBox_SoTienConLai.Size = new System.Drawing.Size(147, 27);
            this.textBox_SoTienConLai.TabIndex = 39;
            // 
            // textBox_SoTienThu
            // 
            this.textBox_SoTienThu.Location = new System.Drawing.Point(427, 45);
            this.textBox_SoTienThu.Name = "textBox_SoTienThu";
            this.textBox_SoTienThu.ReadOnly = true;
            this.textBox_SoTienThu.Size = new System.Drawing.Size(147, 27);
            this.textBox_SoTienThu.TabIndex = 38;
            // 
            // textBox_SoTienDaDong
            // 
            this.textBox_SoTienDaDong.Location = new System.Drawing.Point(152, 96);
            this.textBox_SoTienDaDong.Name = "textBox_SoTienDaDong";
            this.textBox_SoTienDaDong.ReadOnly = true;
            this.textBox_SoTienDaDong.Size = new System.Drawing.Size(147, 27);
            this.textBox_SoTienDaDong.TabIndex = 37;
            // 
            // label_SoTienThu
            // 
            this.label_SoTienThu.AutoSize = true;
            this.label_SoTienThu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_SoTienThu.Location = new System.Drawing.Point(338, 48);
            this.label_SoTienThu.Name = "label_SoTienThu";
            this.label_SoTienThu.Size = new System.Drawing.Size(83, 20);
            this.label_SoTienThu.TabIndex = 32;
            this.label_SoTienThu.Text = "Số tiền thu:";
            // 
            // label_SoTienDaDong
            // 
            this.label_SoTienDaDong.AutoSize = true;
            this.label_SoTienDaDong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_SoTienDaDong.Location = new System.Drawing.Point(28, 99);
            this.label_SoTienDaDong.Name = "label_SoTienDaDong";
            this.label_SoTienDaDong.Size = new System.Drawing.Size(118, 20);
            this.label_SoTienDaDong.TabIndex = 33;
            this.label_SoTienDaDong.Text = "Số tiền đã đóng:";
            // 
            // label_SoTienConLai
            // 
            this.label_SoTienConLai.AutoSize = true;
            this.label_SoTienConLai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_SoTienConLai.Location = new System.Drawing.Point(315, 99);
            this.label_SoTienConLai.Name = "label_SoTienConLai";
            this.label_SoTienConLai.Size = new System.Drawing.Size(106, 20);
            this.label_SoTienConLai.TabIndex = 34;
            this.label_SoTienConLai.Text = "Số tiền còn lại:";
            // 
            // TTSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 761);
            this.Controls.Add(this.groupBox_TTHP);
            this.Controls.Add(this.groupBox_TT_DKHP);
            this.Controls.Add(this.groupBox_TTHS);
            this.Controls.Add(this.label_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TTSV";
            this.Text = "Thông tin chi tiết sinh viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TTSV_FormClosing);
            this.groupBox_TTHS.ResumeLayout(false);
            this.groupBox_TTHS.PerformLayout();
            this.groupBox_TTHP.ResumeLayout(false);
            this.groupBox_TTHP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_DS_MonHocDaDK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_title;
        private GroupBox groupBox_TTHS;
        private Label label_MSSV;
        private TextBox textBox_MSSV;
        private TextBox textBox_DoiTuong;
        private TextBox textBox_Khoa;
        private TextBox textBox_Nganh;
        private TextBox textBox_Huyen;
        private TextBox textBox_Tinh;
        private TextBox textBox_NgaySinh;
        private Label label_Khoa;
        private Label label_Nganh;
        private Label label_DoiTuong;
        private Label label_Huyen;
        private Label label_Tinh;
        private Label label_QueQuan;
        private RadioButton radioButton_Nu;
        private RadioButton radioButton_Nam;
        private Label label_GioiTinh;
        private Label label_NgaySinh;
        private Label label_HoVaTen;
        private TextBox textBox_HoVaTen;
        private GroupBox groupBox_TT_DKHP;
        private GroupBox groupBox_TTHP;
        private String MSSV;
        private String ConnectionString = @System.IO.File.ReadAllText(@"ConnectionString.txt");
        private SqlConnection cnn;
        private TextBox textBox_SoTienConLai;
        private TextBox textBox_SoTienThu;
        private TextBox textBox_SoTienDaDong;
        private Label label_SoTienDaDong;
        private Label label_SoTienConLai;
        private ComboBox comboBox_HocKy;
        private ComboBox comboBox_Nam;
        private Label label_HocKy;
        private Label label_Nam;
        private Label label_SoTienThu;
        private DataGridView table_DS_MonHocDaDK;
        private DataGridViewTextBoxColumn MaMH;
        private DataGridViewTextBoxColumn TenMH;
        private DataGridViewTextBoxColumn LoaiTinChi;
        private DataGridViewTextBoxColumn SoTC;
        private DataGridViewTextBoxColumn MaKhoa;
        private DataGridViewTextBoxColumn MaNganh;

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
    }
}