using System.Data.SqlClient;

namespace SE104
{
    partial class NhapHSSV
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
            this.textBox_HoVaTen = new System.Windows.Forms.TextBox();
            this.label_HoVaTen = new System.Windows.Forms.Label();
            this.label_title = new System.Windows.Forms.Label();
            this.label_NgaySinh = new System.Windows.Forms.Label();
            this.dateTimePicker_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label_GioiTinh = new System.Windows.Forms.Label();
            this.radioButton_Nam = new System.Windows.Forms.RadioButton();
            this.radioButton_Nu = new System.Windows.Forms.RadioButton();
            this.label_QueQuan = new System.Windows.Forms.Label();
            this.label_Tinh = new System.Windows.Forms.Label();
            this.label_Huyen = new System.Windows.Forms.Label();
            this.comboBox_Tinh = new System.Windows.Forms.ComboBox();
            this.comboBox_Huyen = new System.Windows.Forms.ComboBox();
            this.label_DoiTuong = new System.Windows.Forms.Label();
            this.label_Nganh = new System.Windows.Forms.Label();
            this.label_Khoa = new System.Windows.Forms.Label();
            this.comboBox_Khoa = new System.Windows.Forms.ComboBox();
            this.comboBox_Nganh = new System.Windows.Forms.ComboBox();
            this.comboBox_DoiTuong = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Huy = new System.Windows.Forms.Button();
            this.button_XacNhan = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_HoVaTen
            // 
            this.textBox_HoVaTen.Location = new System.Drawing.Point(106, 62);
            this.textBox_HoVaTen.MaxLength = 40;
            this.textBox_HoVaTen.Name = "textBox_HoVaTen";
            this.textBox_HoVaTen.Size = new System.Drawing.Size(270, 27);
            this.textBox_HoVaTen.TabIndex = 0;
            this.textBox_HoVaTen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_HoVaTen_KeyPress);
            // 
            // label_HoVaTen
            // 
            this.label_HoVaTen.AutoSize = true;
            this.label_HoVaTen.Location = new System.Drawing.Point(27, 65);
            this.label_HoVaTen.Name = "label_HoVaTen";
            this.label_HoVaTen.Size = new System.Drawing.Size(76, 20);
            this.label_HoVaTen.TabIndex = 1;
            this.label_HoVaTen.Text = "Họ và tên:";
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_title.Location = new System.Drawing.Point(167, 9);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(291, 35);
            this.label_title.TabIndex = 2;
            this.label_title.Text = "NHẬP HỒ SƠ SINH VIÊN";
            // 
            // label_NgaySinh
            // 
            this.label_NgaySinh.AutoSize = true;
            this.label_NgaySinh.Location = new System.Drawing.Point(27, 120);
            this.label_NgaySinh.Name = "label_NgaySinh";
            this.label_NgaySinh.Size = new System.Drawing.Size(77, 20);
            this.label_NgaySinh.TabIndex = 4;
            this.label_NgaySinh.Text = "Ngày sinh:";
            // 
            // dateTimePicker_NgaySinh
            // 
            this.dateTimePicker_NgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_NgaySinh.Location = new System.Drawing.Point(106, 115);
            this.dateTimePicker_NgaySinh.Name = "dateTimePicker_NgaySinh";
            this.dateTimePicker_NgaySinh.Size = new System.Drawing.Size(246, 27);
            this.dateTimePicker_NgaySinh.TabIndex = 5;
            // 
            // label_GioiTinh
            // 
            this.label_GioiTinh.AutoSize = true;
            this.label_GioiTinh.Location = new System.Drawing.Point(415, 65);
            this.label_GioiTinh.Name = "label_GioiTinh";
            this.label_GioiTinh.Size = new System.Drawing.Size(68, 20);
            this.label_GioiTinh.TabIndex = 7;
            this.label_GioiTinh.Text = "Giới tính:";
            // 
            // radioButton_Nam
            // 
            this.radioButton_Nam.AutoSize = true;
            this.radioButton_Nam.Checked = true;
            this.radioButton_Nam.Location = new System.Drawing.Point(489, 65);
            this.radioButton_Nam.Name = "radioButton_Nam";
            this.radioButton_Nam.Size = new System.Drawing.Size(62, 24);
            this.radioButton_Nam.TabIndex = 8;
            this.radioButton_Nam.TabStop = true;
            this.radioButton_Nam.Text = "Nam";
            this.radioButton_Nam.UseVisualStyleBackColor = true;
            // 
            // radioButton_Nu
            // 
            this.radioButton_Nu.AutoSize = true;
            this.radioButton_Nu.Location = new System.Drawing.Point(557, 65);
            this.radioButton_Nu.Name = "radioButton_Nu";
            this.radioButton_Nu.Size = new System.Drawing.Size(50, 24);
            this.radioButton_Nu.TabIndex = 9;
            this.radioButton_Nu.Text = "Nữ";
            this.radioButton_Nu.UseVisualStyleBackColor = true;
            // 
            // label_QueQuan
            // 
            this.label_QueQuan.AutoSize = true;
            this.label_QueQuan.Location = new System.Drawing.Point(27, 173);
            this.label_QueQuan.Name = "label_QueQuan";
            this.label_QueQuan.Size = new System.Drawing.Size(76, 20);
            this.label_QueQuan.TabIndex = 11;
            this.label_QueQuan.Text = "Quê quán:";
            // 
            // label_Tinh
            // 
            this.label_Tinh.AutoSize = true;
            this.label_Tinh.Location = new System.Drawing.Point(106, 173);
            this.label_Tinh.Name = "label_Tinh";
            this.label_Tinh.Size = new System.Drawing.Size(40, 20);
            this.label_Tinh.TabIndex = 12;
            this.label_Tinh.Text = "Tỉnh:";
            // 
            // label_Huyen
            // 
            this.label_Huyen.AutoSize = true;
            this.label_Huyen.Location = new System.Drawing.Point(322, 173);
            this.label_Huyen.Name = "label_Huyen";
            this.label_Huyen.Size = new System.Drawing.Size(54, 20);
            this.label_Huyen.TabIndex = 13;
            this.label_Huyen.Text = "Huyện:";
            this.label_Huyen.Click += new System.EventHandler(this.label7_Click);
            // 
            // comboBox_Tinh
            // 
            this.comboBox_Tinh.AllowDrop = true;
            this.comboBox_Tinh.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_Tinh.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_Tinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Tinh.FormattingEnabled = true;
            this.comboBox_Tinh.Location = new System.Drawing.Point(152, 170);
            this.comboBox_Tinh.Name = "comboBox_Tinh";
            this.comboBox_Tinh.Size = new System.Drawing.Size(151, 28);
            this.comboBox_Tinh.TabIndex = 14;
            this.comboBox_Tinh.SelectedIndexChanged += new System.EventHandler(this.comboBox_Tinh_SelectedIndexChanged);
            // 
            // comboBox_Huyen
            // 
            this.comboBox_Huyen.AllowDrop = true;
            this.comboBox_Huyen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_Huyen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_Huyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Huyen.FormattingEnabled = true;
            this.comboBox_Huyen.Location = new System.Drawing.Point(382, 170);
            this.comboBox_Huyen.Name = "comboBox_Huyen";
            this.comboBox_Huyen.Size = new System.Drawing.Size(151, 28);
            this.comboBox_Huyen.TabIndex = 15;
            // 
            // label_DoiTuong
            // 
            this.label_DoiTuong.AutoSize = true;
            this.label_DoiTuong.Location = new System.Drawing.Point(27, 229);
            this.label_DoiTuong.Name = "label_DoiTuong";
            this.label_DoiTuong.Size = new System.Drawing.Size(80, 20);
            this.label_DoiTuong.TabIndex = 16;
            this.label_DoiTuong.Text = "Đối tượng:";
            // 
            // label_Nganh
            // 
            this.label_Nganh.AutoSize = true;
            this.label_Nganh.Location = new System.Drawing.Point(292, 291);
            this.label_Nganh.Name = "label_Nganh";
            this.label_Nganh.Size = new System.Drawing.Size(84, 20);
            this.label_Nganh.TabIndex = 17;
            this.label_Nganh.Text = "Ngành học:";
            // 
            // label_Khoa
            // 
            this.label_Khoa.AutoSize = true;
            this.label_Khoa.Location = new System.Drawing.Point(27, 291);
            this.label_Khoa.Name = "label_Khoa";
            this.label_Khoa.Size = new System.Drawing.Size(46, 20);
            this.label_Khoa.TabIndex = 18;
            this.label_Khoa.Text = "Khoa:";
            // 
            // comboBox_Khoa
            // 
            this.comboBox_Khoa.AllowDrop = true;
            this.comboBox_Khoa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_Khoa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_Khoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Khoa.FormattingEnabled = true;
            this.comboBox_Khoa.Location = new System.Drawing.Point(106, 288);
            this.comboBox_Khoa.Name = "comboBox_Khoa";
            this.comboBox_Khoa.Size = new System.Drawing.Size(151, 28);
            this.comboBox_Khoa.TabIndex = 19;
            this.comboBox_Khoa.SelectedIndexChanged += new System.EventHandler(this.comboBox_Khoa_SelectedIndexChanged);
            // 
            // comboBox_Nganh
            // 
            this.comboBox_Nganh.AllowDrop = true;
            this.comboBox_Nganh.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_Nganh.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_Nganh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Nganh.FormattingEnabled = true;
            this.comboBox_Nganh.Location = new System.Drawing.Point(382, 288);
            this.comboBox_Nganh.Name = "comboBox_Nganh";
            this.comboBox_Nganh.Size = new System.Drawing.Size(151, 28);
            this.comboBox_Nganh.TabIndex = 20;
            // 
            // comboBox_DoiTuong
            // 
            this.comboBox_DoiTuong.AllowDrop = true;
            this.comboBox_DoiTuong.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_DoiTuong.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_DoiTuong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_DoiTuong.FormattingEnabled = true;
            this.comboBox_DoiTuong.Location = new System.Drawing.Point(106, 226);
            this.comboBox_DoiTuong.Name = "comboBox_DoiTuong";
            this.comboBox_DoiTuong.Size = new System.Drawing.Size(270, 28);
            this.comboBox_DoiTuong.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_Huy);
            this.groupBox1.Controls.Add(this.button_XacNhan);
            this.groupBox1.Location = new System.Drawing.Point(-4, 322);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(633, 68);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // button_Huy
            // 
            this.button_Huy.Location = new System.Drawing.Point(493, 26);
            this.button_Huy.Name = "button_Huy";
            this.button_Huy.Size = new System.Drawing.Size(94, 29);
            this.button_Huy.TabIndex = 1;
            this.button_Huy.Text = "Hủy";
            this.button_Huy.UseVisualStyleBackColor = true;
            this.button_Huy.Click += new System.EventHandler(this.button_Huy_Click);
            // 
            // button_XacNhan
            // 
            this.button_XacNhan.Location = new System.Drawing.Point(386, 26);
            this.button_XacNhan.Name = "button_XacNhan";
            this.button_XacNhan.Size = new System.Drawing.Size(94, 29);
            this.button_XacNhan.TabIndex = 0;
            this.button_XacNhan.Text = "Xác nhận";
            this.button_XacNhan.UseVisualStyleBackColor = true;
            this.button_XacNhan.Click += new System.EventHandler(this.button_XacNhan_Click);
            // 
            // NhapHSSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 389);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox_DoiTuong);
            this.Controls.Add(this.comboBox_Nganh);
            this.Controls.Add(this.comboBox_Khoa);
            this.Controls.Add(this.label_Khoa);
            this.Controls.Add(this.label_Nganh);
            this.Controls.Add(this.label_DoiTuong);
            this.Controls.Add(this.comboBox_Huyen);
            this.Controls.Add(this.comboBox_Tinh);
            this.Controls.Add(this.label_Huyen);
            this.Controls.Add(this.label_Tinh);
            this.Controls.Add(this.label_QueQuan);
            this.Controls.Add(this.radioButton_Nu);
            this.Controls.Add(this.radioButton_Nam);
            this.Controls.Add(this.label_GioiTinh);
            this.Controls.Add(this.dateTimePicker_NgaySinh);
            this.Controls.Add(this.label_NgaySinh);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.label_HoVaTen);
            this.Controls.Add(this.textBox_HoVaTen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NhapHSSV";
            this.Text = "Nhập hồ sơ sinh viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NhapHSSV_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private void get_TenTinh()
        {
            var cmd = new SqlCommand(Get_TINH_query, this.cnn);
            SqlDataReader reader_Tinh = cmd.ExecuteReader();

            while (reader_Tinh.Read())
            {
                this.comboBox_Tinh.Items.Add(reader_Tinh["TenTinh"].ToString());
            }
            reader_Tinh.Close();
        }

        private void get_TenHuyen(String TenTinh)
        {
            this.comboBox_Huyen.Items.Clear();
            var cmd = new SqlCommand(this.Get_HUYEN_query + "N'" + TenTinh + "'", this.cnn);
            SqlDataReader reader_Huyen = cmd.ExecuteReader();
            while (reader_Huyen.Read())
            {
                this.comboBox_Huyen.Items.Add(reader_Huyen["TenHuyen"].ToString());
            }
            reader_Huyen.Close();
        }

        private void get_TenKhoa()
        {
            var cmd = new SqlCommand(Get_KHOA_query, this.cnn);
            SqlDataReader reader_Khoa = cmd.ExecuteReader();

            while (reader_Khoa.Read())
            {
                this.comboBox_Khoa.Items.Add(reader_Khoa["TenKhoa"].ToString());
            }
            reader_Khoa.Close();
        }

        private void get_TenNganh(String TenKhoa)
        {
            this.comboBox_Nganh.Items.Clear();
            var cmd = new SqlCommand(this.Get_NGANH_query + "N'" + TenKhoa + "'", this.cnn);
            SqlDataReader reader_Nganh = cmd.ExecuteReader();
            while (reader_Nganh.Read())
            {
                this.comboBox_Nganh.Items.Add(reader_Nganh["TenNganh"].ToString());
            }
            reader_Nganh.Close();
        }

        private void get_TenLoaiDTUT()
        {
            var cmd = new SqlCommand(this.Get_DTUT_query, this.cnn);
            SqlDataReader reader_DTUT = cmd.ExecuteReader();

            while (reader_DTUT.Read())
            {
                this.comboBox_DoiTuong.Items.Add(reader_DTUT["TenLoaiDTUT"].ToString());
            }
            reader_DTUT.Close();
        }

        private String get_MaTinh(String TenTinh)
        {
            String MaTinh;
            var cmd = new SqlCommand("Select MaTinh from TINH where TenTinh = " + "N'" + TenTinh + "'", this.cnn);
            SqlDataReader reader_MaTinh = cmd.ExecuteReader();
            if (reader_MaTinh.Read())
            {
                MaTinh = reader_MaTinh.GetString(0);
                reader_MaTinh.Close();
                return MaTinh;
            }
            reader_MaTinh.Close();
            return null;
        }

        private String get_MaHuyen(String TenHuyen, String MaTinh)
        {
            String MaHuyen;
            var cmd = new SqlCommand("Select MaHuyen from HUYEN where TenHuyen = " + "N'" + TenHuyen + "' and MaTinh = '" + MaTinh + "'", this.cnn);
            SqlDataReader reader_MaHuyen = cmd.ExecuteReader();
            if (reader_MaHuyen.Read())
            {
                MaHuyen = reader_MaHuyen.GetString(0);
                reader_MaHuyen.Close();
                return MaHuyen;
            }
            reader_MaHuyen.Close();
            return null;
        }

        private Int32 get_DTUT(String TenDTUT)
        {
            Int32 MaDTUT;
            var cmd = new SqlCommand("Select MaDTUT from DTUT where TenLoaiDTUT = " + "N'" + TenDTUT + "'", this.cnn);
            SqlDataReader reader_MaDTUT = cmd.ExecuteReader();
            if (reader_MaDTUT.Read())
            {
                MaDTUT = reader_MaDTUT.GetInt32(0);
                reader_MaDTUT.Close();
                return MaDTUT;
            }
            reader_MaDTUT.Close();
            return 0;
        }
        private String get_MaKhoa(String TenKhoa)
        {
            String MaKhoa;
            var cmd = new SqlCommand("Select MaKhoa from KHOA where TenKhoa = " + "N'" + TenKhoa + "'", this.cnn);
            SqlDataReader reader_MaKhoa = cmd.ExecuteReader();
            if (reader_MaKhoa.Read())
            {
                MaKhoa = reader_MaKhoa.GetString(0);
                reader_MaKhoa.Close();
                return MaKhoa;
            }
            reader_MaKhoa.Close();
            return null;
        }
        private String get_MaNganh(String TenNganh)
        {
            String MaNganh;
            var cmd = new SqlCommand("Select MaNganh from NGANH where TenNganh = " + "N'" + TenNganh + "'", this.cnn);
            SqlDataReader reader_MaNganh = cmd.ExecuteReader();
            if (reader_MaNganh.Read())
            {
                MaNganh = reader_MaNganh.GetString(0);
                reader_MaNganh.Close();
                return MaNganh;
            }
            reader_MaNganh.Close();
            return null;
        }


        private TextBox textBox_HoVaTen;
        private Label label_HoVaTen;
        private Label label_title;
        private Label label_NgaySinh;
        private DateTimePicker dateTimePicker_NgaySinh;
        private Label label_GioiTinh;
        private RadioButton radioButton_Nam;
        private RadioButton radioButton_Nu;
        private Label label_QueQuan;
        private Label label_Tinh;
        private Label label_Huyen;
        private ComboBox comboBox_Tinh;
        private ComboBox comboBox_Huyen;
        private Label label_DoiTuong;
        private Label label_Nganh;
        private Label label_Khoa;
        private ComboBox comboBox_Khoa;
        private ComboBox comboBox_Nganh;
        private ComboBox comboBox_DoiTuong;
        private GroupBox groupBox1;
        private Button button_Huy;
        private Button button_XacNhan;
        private String Get_TINH_query = "Select TenTinh from TINH";
        private String Get_HUYEN_query = "Select TenHuyen from HUYEN h join TINH t on h.MaTinh = t.MaTinh where t.TenTinh = ";
        private String Get_KHOA_query = "Select TenKhoa from KHOA";
        private String Get_NGANH_query = "Select TenNganh from NGANH n join KHOA k on n.MaKhoa = k.MaKhoa where k.TenKhoa = ";
        private String Get_DTUT_query = "Select TenLoaiDTUT from DTUT";
        private String Insert_HSSV_query = "Insert into HSSV values (@MSSV, @HoTen, @NgaySinh, @GioiTinh, @MaHuyen, @MaTinh, @DTUT, @MaKhoa, @MaNganh)";
        private SqlConnection cnn;
    }
}