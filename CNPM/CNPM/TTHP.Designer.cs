using System.Data.SqlClient;

namespace SE104
{
    partial class TTHP
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
            this.groupBox_TTHP = new System.Windows.Forms.GroupBox();
            this.textBox_SoTienConLai = new System.Windows.Forms.TextBox();
            this.textBox_SoTienThu = new System.Windows.Forms.TextBox();
            this.textBox_SoTienDaDong = new System.Windows.Forms.TextBox();
            this.label_SoTienConLai = new System.Windows.Forms.Label();
            this.label_SoTienDaDong = new System.Windows.Forms.Label();
            this.label_SoTienThu = new System.Windows.Forms.Label();
            this.comboBox_HocKy = new System.Windows.Forms.ComboBox();
            this.label_HocKy = new System.Windows.Forms.Label();
            this.comboBox_Nam = new System.Windows.Forms.ComboBox();
            this.label_NamHoc = new System.Windows.Forms.Label();
            this.groupBox_HoTenMSSV = new System.Windows.Forms.GroupBox();
            this.textBox_MSSV = new System.Windows.Forms.TextBox();
            this.textBox_HoTen = new System.Windows.Forms.TextBox();
            this.label_MSSV = new System.Windows.Forms.Label();
            this.label_HoVaTen = new System.Windows.Forms.Label();
            this.button_DongHP = new System.Windows.Forms.Button();
            this.groupBox_TTHP.SuspendLayout();
            this.groupBox_HoTenMSSV.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_title.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_title.Location = new System.Drawing.Point(0, 0);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(432, 46);
            this.label_title.TabIndex = 3;
            this.label_title.Text = "THÔNG TIN HỌC PHÍ";
            this.label_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox_TTHP
            // 
            this.groupBox_TTHP.Controls.Add(this.textBox_SoTienConLai);
            this.groupBox_TTHP.Controls.Add(this.textBox_SoTienThu);
            this.groupBox_TTHP.Controls.Add(this.textBox_SoTienDaDong);
            this.groupBox_TTHP.Controls.Add(this.label_SoTienConLai);
            this.groupBox_TTHP.Controls.Add(this.label_SoTienDaDong);
            this.groupBox_TTHP.Controls.Add(this.label_SoTienThu);
            this.groupBox_TTHP.Controls.Add(this.comboBox_HocKy);
            this.groupBox_TTHP.Controls.Add(this.label_HocKy);
            this.groupBox_TTHP.Controls.Add(this.comboBox_Nam);
            this.groupBox_TTHP.Controls.Add(this.label_NamHoc);
            this.groupBox_TTHP.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_TTHP.Location = new System.Drawing.Point(0, 199);
            this.groupBox_TTHP.Name = "groupBox_TTHP";
            this.groupBox_TTHP.Size = new System.Drawing.Size(432, 240);
            this.groupBox_TTHP.TabIndex = 6;
            this.groupBox_TTHP.TabStop = false;
            // 
            // textBox_SoTienConLai
            // 
            this.textBox_SoTienConLai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_SoTienConLai.Location = new System.Drawing.Point(168, 157);
            this.textBox_SoTienConLai.Name = "textBox_SoTienConLai";
            this.textBox_SoTienConLai.ReadOnly = true;
            this.textBox_SoTienConLai.Size = new System.Drawing.Size(258, 34);
            this.textBox_SoTienConLai.TabIndex = 18;
            // 
            // textBox_SoTienThu
            // 
            this.textBox_SoTienThu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_SoTienThu.Location = new System.Drawing.Point(168, 67);
            this.textBox_SoTienThu.Name = "textBox_SoTienThu";
            this.textBox_SoTienThu.ReadOnly = true;
            this.textBox_SoTienThu.Size = new System.Drawing.Size(258, 34);
            this.textBox_SoTienThu.TabIndex = 17;
            // 
            // textBox_SoTienDaDong
            // 
            this.textBox_SoTienDaDong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_SoTienDaDong.Location = new System.Drawing.Point(168, 112);
            this.textBox_SoTienDaDong.Name = "textBox_SoTienDaDong";
            this.textBox_SoTienDaDong.ReadOnly = true;
            this.textBox_SoTienDaDong.Size = new System.Drawing.Size(258, 34);
            this.textBox_SoTienDaDong.TabIndex = 16;
            // 
            // label_SoTienConLai
            // 
            this.label_SoTienConLai.AutoSize = true;
            this.label_SoTienConLai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_SoTienConLai.Location = new System.Drawing.Point(6, 160);
            this.label_SoTienConLai.Name = "label_SoTienConLai";
            this.label_SoTienConLai.Size = new System.Drawing.Size(139, 28);
            this.label_SoTienConLai.TabIndex = 12;
            this.label_SoTienConLai.Text = "Số tiền còn lại:";
            // 
            // label_SoTienDaDong
            // 
            this.label_SoTienDaDong.AutoSize = true;
            this.label_SoTienDaDong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_SoTienDaDong.Location = new System.Drawing.Point(6, 112);
            this.label_SoTienDaDong.Name = "label_SoTienDaDong";
            this.label_SoTienDaDong.Size = new System.Drawing.Size(156, 28);
            this.label_SoTienDaDong.TabIndex = 11;
            this.label_SoTienDaDong.Text = "Số tiền đã đóng:";
            // 
            // label_SoTienThu
            // 
            this.label_SoTienThu.AutoSize = true;
            this.label_SoTienThu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_SoTienThu.Location = new System.Drawing.Point(6, 67);
            this.label_SoTienThu.Name = "label_SoTienThu";
            this.label_SoTienThu.Size = new System.Drawing.Size(111, 28);
            this.label_SoTienThu.TabIndex = 10;
            this.label_SoTienThu.Text = "Số tiền thu:";
            // 
            // comboBox_HocKy
            // 
            this.comboBox_HocKy.AllowDrop = true;
            this.comboBox_HocKy.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_HocKy.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_HocKy.Dock = System.Windows.Forms.DockStyle.Left;
            this.comboBox_HocKy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_HocKy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox_HocKy.FormattingEnabled = true;
            this.comboBox_HocKy.Location = new System.Drawing.Point(302, 23);
            this.comboBox_HocKy.Name = "comboBox_HocKy";
            this.comboBox_HocKy.Size = new System.Drawing.Size(124, 36);
            this.comboBox_HocKy.TabIndex = 17;
            this.comboBox_HocKy.SelectedIndexChanged += new System.EventHandler(this.comboBox_HocKy_SelectedIndexChanged);
            // 
            // label_HocKy
            // 
            this.label_HocKy.AutoSize = true;
            this.label_HocKy.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_HocKy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_HocKy.Location = new System.Drawing.Point(206, 23);
            this.label_HocKy.Name = "label_HocKy";
            this.label_HocKy.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.label_HocKy.Size = new System.Drawing.Size(96, 28);
            this.label_HocKy.TabIndex = 9;
            this.label_HocKy.Text = "Học kỳ:";
            // 
            // comboBox_Nam
            // 
            this.comboBox_Nam.AllowDrop = true;
            this.comboBox_Nam.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_Nam.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_Nam.Dock = System.Windows.Forms.DockStyle.Left;
            this.comboBox_Nam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Nam.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox_Nam.FormattingEnabled = true;
            this.comboBox_Nam.Location = new System.Drawing.Point(98, 23);
            this.comboBox_Nam.Name = "comboBox_Nam";
            this.comboBox_Nam.Size = new System.Drawing.Size(108, 36);
            this.comboBox_Nam.TabIndex = 16;
            this.comboBox_Nam.SelectedIndexChanged += new System.EventHandler(this.comboBox_Nam_SelectedIndexChanged);
            // 
            // label_NamHoc
            // 
            this.label_NamHoc.AutoSize = true;
            this.label_NamHoc.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_NamHoc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_NamHoc.Location = new System.Drawing.Point(3, 23);
            this.label_NamHoc.Name = "label_NamHoc";
            this.label_NamHoc.Size = new System.Drawing.Size(95, 28);
            this.label_NamHoc.TabIndex = 8;
            this.label_NamHoc.Text = "Năm học:";
            // 
            // groupBox_HoTenMSSV
            // 
            this.groupBox_HoTenMSSV.Controls.Add(this.textBox_MSSV);
            this.groupBox_HoTenMSSV.Controls.Add(this.textBox_HoTen);
            this.groupBox_HoTenMSSV.Controls.Add(this.label_MSSV);
            this.groupBox_HoTenMSSV.Controls.Add(this.label_HoVaTen);
            this.groupBox_HoTenMSSV.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_HoTenMSSV.Location = new System.Drawing.Point(0, 46);
            this.groupBox_HoTenMSSV.Name = "groupBox_HoTenMSSV";
            this.groupBox_HoTenMSSV.Size = new System.Drawing.Size(432, 153);
            this.groupBox_HoTenMSSV.TabIndex = 7;
            this.groupBox_HoTenMSSV.TabStop = false;
            // 
            // textBox_MSSV
            // 
            this.textBox_MSSV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_MSSV.Location = new System.Drawing.Point(105, 61);
            this.textBox_MSSV.Name = "textBox_MSSV";
            this.textBox_MSSV.ReadOnly = true;
            this.textBox_MSSV.Size = new System.Drawing.Size(321, 34);
            this.textBox_MSSV.TabIndex = 9;
            // 
            // textBox_HoTen
            // 
            this.textBox_HoTen.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBox_HoTen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_HoTen.Location = new System.Drawing.Point(103, 23);
            this.textBox_HoTen.Name = "textBox_HoTen";
            this.textBox_HoTen.ReadOnly = true;
            this.textBox_HoTen.Size = new System.Drawing.Size(323, 34);
            this.textBox_HoTen.TabIndex = 8;
            // 
            // label_MSSV
            // 
            this.label_MSSV.AutoSize = true;
            this.label_MSSV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_MSSV.Location = new System.Drawing.Point(6, 64);
            this.label_MSSV.Name = "label_MSSV";
            this.label_MSSV.Size = new System.Drawing.Size(68, 28);
            this.label_MSSV.TabIndex = 7;
            this.label_MSSV.Text = "MSSV:";
            // 
            // label_HoVaTen
            // 
            this.label_HoVaTen.AutoSize = true;
            this.label_HoVaTen.Dock = System.Windows.Forms.DockStyle.Left;
            this.label_HoVaTen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_HoVaTen.Location = new System.Drawing.Point(3, 23);
            this.label_HoVaTen.Name = "label_HoVaTen";
            this.label_HoVaTen.Size = new System.Drawing.Size(100, 28);
            this.label_HoVaTen.TabIndex = 6;
            this.label_HoVaTen.Text = "Họ và tên:";
            // 
            // button_DongHP
            // 
            this.button_DongHP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_DongHP.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_DongHP.Location = new System.Drawing.Point(0, 439);
            this.button_DongHP.Name = "button_DongHP";
            this.button_DongHP.Size = new System.Drawing.Size(432, 64);
            this.button_DongHP.TabIndex = 13;
            this.button_DongHP.Text = "Đóng học phí";
            this.button_DongHP.UseVisualStyleBackColor = true;
            this.button_DongHP.Click += new System.EventHandler(this.button1_Click);
            // 
            // TTHP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 503);
            this.Controls.Add(this.button_DongHP);
            this.Controls.Add(this.groupBox_TTHP);
            this.Controls.Add(this.groupBox_HoTenMSSV);
            this.Controls.Add(this.label_title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TTHP";
            this.Text = "Thông tin học phí";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TTHP_FormClosing);
            this.groupBox_TTHP.ResumeLayout(false);
            this.groupBox_TTHP.PerformLayout();
            this.groupBox_HoTenMSSV.ResumeLayout(false);
            this.groupBox_HoTenMSSV.PerformLayout();
            this.ResumeLayout(false);

        }

        private void TTHP_FormClosed(object sender, FormClosedEventArgs e)
        {
            throw new NotImplementedException();
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

        private Label label_title;
        private GroupBox groupBox_TTHP;
        private Label label_SoTienConLai;
        private Label label_SoTienDaDong;
        private Label label_SoTienThu;
        private Label label_HocKy;
        private Label label_NamHoc;
        private GroupBox groupBox_HoTenMSSV;
        private Label label_MSSV;
        private Label label_HoVaTen;
        private Button button_DongHP;
        private TextBox textBox_SoTienConLai;
        private TextBox textBox_SoTienThu;
        private TextBox textBox_SoTienDaDong;
        private TextBox textBox_MSSV;
        private TextBox textBox_HoTen;
        private ComboBox comboBox_HocKy;
        private ComboBox comboBox_Nam;
        private SqlConnection cnn;
        private String ConnectionString = @System.IO.File.ReadAllText(@"ConnectionString.txt");
        private String mssv;
        private String HoTen;
        private String SoPhieu;
    }
}