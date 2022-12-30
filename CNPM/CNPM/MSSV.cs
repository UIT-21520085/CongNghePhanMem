using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE104
{
    public partial class MSSV : Form
    {
        public MSSV(String mssv)
        {
            this.mssv = mssv;
            InitializeComponent();
            this.label_title.Text += this.mssv;
            add_TTHS();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            UpdateHSSV udp = new UpdateHSSV(this.mssv);
            this.IconButton_ChinhSua.Enabled = false;
            udp.FormClosed += delegate
            {
                this.IconButton_ChinhSua.Enabled = true;
            };
            udp.ShowDialog();
            add_TTHS();
        }

        private void add_TTHS()
        {
            this.cnn = new SqlConnection(this.ConnectionString);
            try
            {
                cnn.Open();
                var cmd = new SqlCommand("Select HoTen, convert(varchar(10), NgaySinh, 101) as Ngay, GioiTinh, MaTinh, MaHuyen, DTUT, MaKhoa, MaNganh from HSSV where MSSV = " + "'" + this.mssv + "'", this.cnn);
                String MaTinh = "", MaHuyen = "", MaKhoa = "", MaNganh = "";

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    this.textBox_HoVaTen.Text = reader["HoTen"].ToString();
                    this.textBox_NgaySinh.Text = reader["Ngay"].ToString();
                    MaTinh = reader["MaTinh"].ToString();
                    MaHuyen = reader["MaHuyen"].ToString();
                    this.textBox_DoiTuong.Text = reader["DTUT"].ToString();
                    MaKhoa = reader["MaKhoa"].ToString();
                    MaNganh = reader["MaNganh"].ToString();
                    if (reader["GioiTinh"].ToString() == "Nam")
                    {
                        this.radioButton_Nam.Checked = true;
                    }
                    else
                    {
                        this.radioButton_Nu.Checked = true;
                    }
                }
                reader.Close();
                var cmd_Tinh = new SqlCommand("Select TenTinh from TINH where MaTinh = " + "'" + MaTinh + "'", this.cnn);
                SqlDataReader reader_Tinh = cmd_Tinh.ExecuteReader();

                while (reader_Tinh.Read())
                {
                    this.textBox_Tinh.Text = reader_Tinh["TenTinh"].ToString();
                }
                reader_Tinh.Close();

                var cmd_Huyen = new SqlCommand("Select TenHuyen from HUYEN where MaHuyen = " + "'" + MaHuyen + "'", this.cnn);
                SqlDataReader reader_Huyen = cmd_Huyen.ExecuteReader();

                while (reader_Huyen.Read())
                {
                    this.textBox_Huyen.Text = reader_Huyen["TenHuyen"].ToString();
                }
                reader_Huyen.Close();

                var cmd_Khoa = new SqlCommand("Select TenKhoa from KHOA where MaKhoa = " + "'" + MaKhoa + "'", this.cnn);
                SqlDataReader reader_Khoa = cmd_Khoa.ExecuteReader();

                while (reader_Khoa.Read())
                {
                    this.textBox_Khoa.Text = reader_Khoa["TenKhoa"].ToString();
                }
                reader_Khoa.Close();

                var cmd_Nganh = new SqlCommand("Select TenNganh from NGANH where MaNganh = " + "'" + MaNganh + "'", this.cnn);
                SqlDataReader reader_Nganh = cmd_Nganh.ExecuteReader();

                while (reader_Nganh.Read())
                {
                    this.textBox_Nganh.Text = reader_Nganh["TenNganh"].ToString();
                }
                reader_Nganh.Close();

                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            add_TTHS();
        }
    }
}