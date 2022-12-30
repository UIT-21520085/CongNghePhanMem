using System.Data.SqlClient;

namespace SE104
{
    partial class MSSV
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
            this.label_title = new System.Windows.Forms.Label();
            this.label_HoVaTen = new System.Windows.Forms.Label();
            this.textBox_HoVaTen = new System.Windows.Forms.TextBox();
            this.textBox_NgaySinh = new System.Windows.Forms.TextBox();
            this.textBox_Tinh = new System.Windows.Forms.TextBox();
            this.textBox_Huyen = new System.Windows.Forms.TextBox();
            this.textBox_Nganh = new System.Windows.Forms.TextBox();
            this.textBox_Khoa = new System.Windows.Forms.TextBox();
            this.textBox_DoiTuong = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.IconButton_ChinhSua = new FontAwesome.Sharp.IconButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Khoa
            // 
            this.label_Khoa.AutoSize = true;
            this.label_Khoa.Location = new System.Drawing.Point(13, 291);
            this.label_Khoa.Name = "label_Khoa";
            this.label_Khoa.Size = new System.Drawing.Size(46, 20);
            this.label_Khoa.TabIndex = 38;
            this.label_Khoa.Text = "Khoa:";
            // 
            // label_Nganh
            // 
            this.label_Nganh.AutoSize = true;
            this.label_Nganh.Location = new System.Drawing.Point(278, 291);
            this.label_Nganh.Name = "label_Nganh";
            this.label_Nganh.Size = new System.Drawing.Size(84, 20);
            this.label_Nganh.TabIndex = 37;
            this.label_Nganh.Text = "Ngành học:";
            // 
            // label_DoiTuong
            // 
            this.label_DoiTuong.AutoSize = true;
            this.label_DoiTuong.Location = new System.Drawing.Point(13, 229);
            this.label_DoiTuong.Name = "label_DoiTuong";
            this.label_DoiTuong.Size = new System.Drawing.Size(80, 20);
            this.label_DoiTuong.TabIndex = 36;
            this.label_DoiTuong.Text = "Đối tượng:";
            // 
            // label_Huyen
            // 
            this.label_Huyen.AutoSize = true;
            this.label_Huyen.Location = new System.Drawing.Point(308, 173);
            this.label_Huyen.Name = "label_Huyen";
            this.label_Huyen.Size = new System.Drawing.Size(54, 20);
            this.label_Huyen.TabIndex = 33;
            this.label_Huyen.Text = "Huyện:";
            // 
            // label_Tinh
            // 
            this.label_Tinh.AutoSize = true;
            this.label_Tinh.Location = new System.Drawing.Point(92, 173);
            this.label_Tinh.Name = "label_Tinh";
            this.label_Tinh.Size = new System.Drawing.Size(40, 20);
            this.label_Tinh.TabIndex = 32;
            this.label_Tinh.Text = "Tỉnh:";
            // 
            // label_QueQuan
            // 
            this.label_QueQuan.AutoSize = true;
            this.label_QueQuan.Location = new System.Drawing.Point(13, 173);
            this.label_QueQuan.Name = "label_QueQuan";
            this.label_QueQuan.Size = new System.Drawing.Size(76, 20);
            this.label_QueQuan.TabIndex = 31;
            this.label_QueQuan.Text = "Quê quán:";
            // 
            // radioButton_Nu
            // 
            this.radioButton_Nu.AutoSize = true;
            this.radioButton_Nu.Checked = true;
            this.radioButton_Nu.Enabled = false;
            this.radioButton_Nu.Location = new System.Drawing.Point(543, 65);
            this.radioButton_Nu.Name = "radioButton_Nu";
            this.radioButton_Nu.Size = new System.Drawing.Size(50, 24);
            this.radioButton_Nu.TabIndex = 30;
            this.radioButton_Nu.TabStop = true;
            this.radioButton_Nu.Text = "Nữ";
            this.radioButton_Nu.UseVisualStyleBackColor = true;
            // 
            // radioButton_Nam
            // 
            this.radioButton_Nam.AutoSize = true;
            this.radioButton_Nam.Enabled = false;
            this.radioButton_Nam.Location = new System.Drawing.Point(475, 65);
            this.radioButton_Nam.Name = "radioButton_Nam";
            this.radioButton_Nam.Size = new System.Drawing.Size(62, 24);
            this.radioButton_Nam.TabIndex = 29;
            this.radioButton_Nam.Text = "Nam";
            this.radioButton_Nam.UseVisualStyleBackColor = true;
            // 
            // label_GioiTinh
            // 
            this.label_GioiTinh.AutoSize = true;
            this.label_GioiTinh.Location = new System.Drawing.Point(401, 65);
            this.label_GioiTinh.Name = "label_GioiTinh";
            this.label_GioiTinh.Size = new System.Drawing.Size(68, 20);
            this.label_GioiTinh.TabIndex = 28;
            this.label_GioiTinh.Text = "Giới tính:";
            // 
            // label_NgaySinh
            // 
            this.label_NgaySinh.AutoSize = true;
            this.label_NgaySinh.Location = new System.Drawing.Point(13, 120);
            this.label_NgaySinh.Name = "label_NgaySinh";
            this.label_NgaySinh.Size = new System.Drawing.Size(77, 20);
            this.label_NgaySinh.TabIndex = 26;
            this.label_NgaySinh.Text = "Ngày sinh:";
            // 
            // label_title
            // 
            this.label_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_title.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_title.Location = new System.Drawing.Point(0, 0);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(597, 48);
            this.label_title.TabIndex = 25;
            this.label_title.Text = "MSSV: ";
            this.label_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_HoVaTen
            // 
            this.label_HoVaTen.AutoSize = true;
            this.label_HoVaTen.Location = new System.Drawing.Point(13, 65);
            this.label_HoVaTen.Name = "label_HoVaTen";
            this.label_HoVaTen.Size = new System.Drawing.Size(76, 20);
            this.label_HoVaTen.TabIndex = 24;
            this.label_HoVaTen.Text = "Họ và tên:";
            // 
            // textBox_HoVaTen
            // 
            this.textBox_HoVaTen.Location = new System.Drawing.Point(92, 62);
            this.textBox_HoVaTen.Name = "textBox_HoVaTen";
            this.textBox_HoVaTen.ReadOnly = true;
            this.textBox_HoVaTen.Size = new System.Drawing.Size(270, 27);
            this.textBox_HoVaTen.TabIndex = 23;
            // 
            // textBox_NgaySinh
            // 
            this.textBox_NgaySinh.Location = new System.Drawing.Point(92, 117);
            this.textBox_NgaySinh.Name = "textBox_NgaySinh";
            this.textBox_NgaySinh.ReadOnly = true;
            this.textBox_NgaySinh.Size = new System.Drawing.Size(197, 27);
            this.textBox_NgaySinh.TabIndex = 42;
            // 
            // textBox_Tinh
            // 
            this.textBox_Tinh.Location = new System.Drawing.Point(138, 170);
            this.textBox_Tinh.Name = "textBox_Tinh";
            this.textBox_Tinh.ReadOnly = true;
            this.textBox_Tinh.Size = new System.Drawing.Size(151, 27);
            this.textBox_Tinh.TabIndex = 43;
            // 
            // textBox_Huyen
            // 
            this.textBox_Huyen.Location = new System.Drawing.Point(368, 170);
            this.textBox_Huyen.Name = "textBox_Huyen";
            this.textBox_Huyen.ReadOnly = true;
            this.textBox_Huyen.Size = new System.Drawing.Size(151, 27);
            this.textBox_Huyen.TabIndex = 44;
            // 
            // textBox_Nganh
            // 
            this.textBox_Nganh.Location = new System.Drawing.Point(368, 288);
            this.textBox_Nganh.Name = "textBox_Nganh";
            this.textBox_Nganh.ReadOnly = true;
            this.textBox_Nganh.Size = new System.Drawing.Size(151, 27);
            this.textBox_Nganh.TabIndex = 45;
            // 
            // textBox_Khoa
            // 
            this.textBox_Khoa.Location = new System.Drawing.Point(92, 288);
            this.textBox_Khoa.Name = "textBox_Khoa";
            this.textBox_Khoa.ReadOnly = true;
            this.textBox_Khoa.Size = new System.Drawing.Size(151, 27);
            this.textBox_Khoa.TabIndex = 46;
            // 
            // textBox_DoiTuong
            // 
            this.textBox_DoiTuong.Location = new System.Drawing.Point(92, 226);
            this.textBox_DoiTuong.Name = "textBox_DoiTuong";
            this.textBox_DoiTuong.ReadOnly = true;
            this.textBox_DoiTuong.Size = new System.Drawing.Size(270, 27);
            this.textBox_DoiTuong.TabIndex = 47;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.IconButton_ChinhSua);
            this.groupBox1.Location = new System.Drawing.Point(-7, 333);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(610, 61);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            // 
            // IconButton_ChinhSua
            // 
            this.IconButton_ChinhSua.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IconButton_ChinhSua.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.IconButton_ChinhSua.IconColor = System.Drawing.Color.Black;
            this.IconButton_ChinhSua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconButton_ChinhSua.IconSize = 25;
            this.IconButton_ChinhSua.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IconButton_ChinhSua.Location = new System.Drawing.Point(237, 26);
            this.IconButton_ChinhSua.Name = "IconButton_ChinhSua";
            this.IconButton_ChinhSua.Size = new System.Drawing.Size(122, 29);
            this.IconButton_ChinhSua.TabIndex = 0;
            this.IconButton_ChinhSua.Text = "Chỉnh sửa";
            this.IconButton_ChinhSua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IconButton_ChinhSua.UseVisualStyleBackColor = true;
            this.IconButton_ChinhSua.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // MSSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 403);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox_DoiTuong);
            this.Controls.Add(this.textBox_Khoa);
            this.Controls.Add(this.textBox_Nganh);
            this.Controls.Add(this.textBox_Huyen);
            this.Controls.Add(this.textBox_Tinh);
            this.Controls.Add(this.textBox_NgaySinh);
            this.Controls.Add(this.label_Khoa);
            this.Controls.Add(this.label_Nganh);
            this.Controls.Add(this.label_DoiTuong);
            this.Controls.Add(this.label_Huyen);
            this.Controls.Add(this.label_Tinh);
            this.Controls.Add(this.label_QueQuan);
            this.Controls.Add(this.radioButton_Nu);
            this.Controls.Add(this.radioButton_Nam);
            this.Controls.Add(this.label_GioiTinh);
            this.Controls.Add(this.label_NgaySinh);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.label_HoVaTen);
            this.Controls.Add(this.textBox_HoVaTen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MSSV";
            this.Text = "MSSV: ";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private Label label_title;
        private Label label_HoVaTen;
        private TextBox textBox_HoVaTen;
        private TextBox textBox_NgaySinh;
        private TextBox textBox_Tinh;
        private TextBox textBox_Huyen;
        private TextBox textBox_Nganh;
        private TextBox textBox_Khoa;
        private TextBox textBox_DoiTuong;
        private GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton IconButton_ChinhSua;
        private String mssv;
        private SqlConnection cnn;
        private String ConnectionString = @System.IO.File.ReadAllText(@"ConnectionString.txt");
    }
}