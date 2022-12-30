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
    public partial class TTSV : Form
    {
        public TTSV(String MSSV)
        {
            this.cnn = new SqlConnection(this.ConnectionString);
            try
            {
                cnn.Open();
                this.MSSV = MSSV;
                InitializeComponent();
                this.add_TTHS();
                this.get_Nam();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TTSV_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                this.cnn.Close();
        }

        private void add_TTHS()
        {
            try
            {
                var cmd = new SqlCommand("Select HoTen, convert(varchar(10), NgaySinh, 101) as Ngay, GioiTinh, MaTinh, MaHuyen, DTUT, MaKhoa, MaNganh from HSSV where MSSV = " + "'" + MSSV + "'", this.cnn);
                String MaTinh = "", MaHuyen = "", MaKhoa = "", MaNganh = "";

                this.textBox_MSSV.Text = this.MSSV;
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

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox_Nam_SelectedIndexChanged(object sender, EventArgs e)
        {
            Object selected_Nam = this.comboBox_Nam.SelectedItem;
            this.get_HocKy(selected_Nam.ToString());
        }

        private void comboBox_HocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.add_TTHP(this.comboBox_Nam.SelectedItem.ToString(), this.comboBox_HocKy.SelectedItem.ToString());
            this.insertData(this.comboBox_HocKy.SelectedItem.ToString(), this.comboBox_Nam.SelectedItem.ToString());
        }

        private void add_TTHP(String Nam, String HocKy)
        {
            try
            {
                var cmd = new SqlCommand("Select SoTienDong, (SoTienDong - SoTienConLai) as SoTienDaDong, SoTienConLai from DS_PHIEUDKHP where MSSV = " + "'" + this.textBox_MSSV.Text + "'and Nam = " + Nam + "and HocKy = " + HocKy, this.cnn);

                SqlDataReader reader = cmd.ExecuteReader();
                bool check = false;
                while (reader.Read())
                {
                    check = true;
                    this.textBox_SoTienThu.Text = reader["SoTienDong"].ToString();
                    this.textBox_SoTienDaDong.Text = reader["SoTienDaDong"].ToString();
                    this.textBox_SoTienConLai.Text = reader["SoTienConLai"].ToString();
                    //this.SoPhieu = reader["SoPhieu"].ToString();
                }
                if (!check)
                {
                    this.textBox_SoTienThu.Text = "0";
                    this.textBox_SoTienDaDong.Text = "0";
                    this.textBox_SoTienConLai.Text = "0";
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
    }
}