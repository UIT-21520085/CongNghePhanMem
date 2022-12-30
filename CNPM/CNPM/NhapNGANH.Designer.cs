using System.Data.SqlClient;

namespace SE104
{
    partial class NhapNGANH
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
            this.label_NhapTenMoi = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Huy = new System.Windows.Forms.Button();
            this.button_XacNhan = new System.Windows.Forms.Button();
            this.label_TenNganhMoi = new System.Windows.Forms.Label();
            this.textBox_NhapTenNganh = new System.Windows.Forms.TextBox();
            this.comboBox_Khoa = new System.Windows.Forms.ComboBox();
            this.label_Khoa = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_NhapTenMoi
            // 
            this.label_NhapTenMoi.AutoSize = true;
            this.label_NhapTenMoi.Location = new System.Drawing.Point(54, 20);
            this.label_NhapTenMoi.Name = "label_NhapTenMoi";
            this.label_NhapTenMoi.Size = new System.Drawing.Size(103, 20);
            this.label_NhapTenMoi.TabIndex = 28;
            this.label_NhapTenMoi.Text = "Nhập tên mới:";
            this.label_NhapTenMoi.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_Huy);
            this.groupBox1.Controls.Add(this.button_XacNhan);
            this.groupBox1.Location = new System.Drawing.Point(0, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 68);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // button_Huy
            // 
            this.button_Huy.Location = new System.Drawing.Point(339, 27);
            this.button_Huy.Name = "button_Huy";
            this.button_Huy.Size = new System.Drawing.Size(94, 29);
            this.button_Huy.TabIndex = 1;
            this.button_Huy.Text = "Hủy";
            this.button_Huy.UseVisualStyleBackColor = true;
            this.button_Huy.Click += new System.EventHandler(this.button_Huy_Click);
            // 
            // button_XacNhan
            // 
            this.button_XacNhan.Location = new System.Drawing.Point(239, 27);
            this.button_XacNhan.Name = "button_XacNhan";
            this.button_XacNhan.Size = new System.Drawing.Size(94, 29);
            this.button_XacNhan.TabIndex = 0;
            this.button_XacNhan.Text = "Xác nhận";
            this.button_XacNhan.UseVisualStyleBackColor = true;
            // 
            // label_TenNganhMoi
            // 
            this.label_TenNganhMoi.AutoSize = true;
            this.label_TenNganhMoi.Location = new System.Drawing.Point(9, 20);
            this.label_TenNganhMoi.Name = "label_TenNganhMoi";
            this.label_TenNganhMoi.Size = new System.Drawing.Size(148, 20);
            this.label_TenNganhMoi.TabIndex = 26;
            this.label_TenNganhMoi.Text = "Nhập tên ngành mới:";
            // 
            // textBox_NhapTenNganh
            // 
            this.textBox_NhapTenNganh.Location = new System.Drawing.Point(163, 17);
            this.textBox_NhapTenNganh.MaxLength = 30;
            this.textBox_NhapTenNganh.Name = "textBox_NhapTenNganh";
            this.textBox_NhapTenNganh.Size = new System.Drawing.Size(270, 27);
            this.textBox_NhapTenNganh.TabIndex = 25;
            this.textBox_NhapTenNganh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_NhapTenNganh_KeyPress);
            // 
            // comboBox_Khoa
            // 
            this.comboBox_Khoa.AllowDrop = true;
            this.comboBox_Khoa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_Khoa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_Khoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Khoa.FormattingEnabled = true;
            this.comboBox_Khoa.Location = new System.Drawing.Point(163, 51);
            this.comboBox_Khoa.Name = "comboBox_Khoa";
            this.comboBox_Khoa.Size = new System.Drawing.Size(151, 28);
            this.comboBox_Khoa.TabIndex = 30;
            // 
            // label_Khoa
            // 
            this.label_Khoa.AutoSize = true;
            this.label_Khoa.Location = new System.Drawing.Point(111, 53);
            this.label_Khoa.Name = "label_Khoa";
            this.label_Khoa.Size = new System.Drawing.Size(46, 20);
            this.label_Khoa.TabIndex = 29;
            this.label_Khoa.Text = "Khoa:";
            // 
            // NhapNGANH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 147);
            this.Controls.Add(this.comboBox_Khoa);
            this.Controls.Add(this.label_Khoa);
            this.Controls.Add(this.label_NhapTenMoi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label_TenNganhMoi);
            this.Controls.Add(this.textBox_NhapTenNganh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NhapNGANH";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_NhapTenMoi;
        private GroupBox groupBox1;
        private Button button_Huy;
        private Button button_XacNhan;
        private Label label_TenNganhMoi;
        private TextBox textBox_NhapTenNganh;
        private ComboBox comboBox_Khoa;
        private Label label_Khoa;
        private SqlConnection cnn;
        private String ConnectionString = @System.IO.File.ReadAllText(@"ConnectionString.txt");
        private String MaNganh = null;

        private void get_TenKhoa()
        {
            this.cnn = new SqlConnection(ConnectionString);
            try
            {
                this.cnn.Open();
                var cmd = new SqlCommand("Select TenKhoa from KHOA", this.cnn);
                SqlDataReader reader_Khoa = cmd.ExecuteReader();

                while (reader_Khoa.Read())
                {
                    this.comboBox_Khoa.Items.Add(reader_Khoa["TenKhoa"].ToString());
                }
                reader_Khoa.Close();
                this.cnn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private String get_MaKhoa(String TenKhoa)
        {
            this.cnn = new SqlConnection(ConnectionString);
            try
            {
                this.cnn.Open();
                String MaKhoa;
                var cmd = new SqlCommand("Select MaKhoa from KHOA where TenKhoa = " + "N'" + TenKhoa + "'", this.cnn);
                SqlDataReader reader_MaKhoa = cmd.ExecuteReader();
                if (reader_MaKhoa.Read())
                {
                    MaKhoa = reader_MaKhoa.GetString(0);
                    reader_MaKhoa.Close();
                    this.cnn.Close();
                    return MaKhoa;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return null;
        }
    }
}