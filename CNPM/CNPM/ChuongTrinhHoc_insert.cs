using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace chuongtrinhhoc
{
    public partial class ChuongTrinhHoc_insert : Form
    {
        string connectionString = @System.IO.File.ReadAllText(@"ConnectionString.txt");
        public ChuongTrinhHoc_insert()
        {
            InitializeComponent();

            comboBox_add_khoa.Enabled = false;
            comboBox_add_nganh.Enabled = false;
            comboBox_add_mamh.Enabled = false;
            button_add1cthoc.Enabled = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT DISTINCT(Nam) FROM HOCKY";

                connection.Open();

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    using (SqlDataReader dta = cmd.ExecuteReader())
                    {
                        while (dta.Read() == true)
                        {
                            comboBox_add_nam.Items.Add(dta[0].ToString());
                        }
                    }
                }

                connection.Close();
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT MaKhoa FROM KHOA";

                connection.Open();

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    using (SqlDataReader dta = cmd.ExecuteReader())
                    {
                        while (dta.Read() == true)
                        {
                            comboBox_add_khoa.Items.Add(dta[0].ToString());
                        }
                    }
                }

                connection.Close();
            }
        }

        private void button_dongthemcthoc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_add1cthoc_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO CTHOC (MaNganh,MaKhoa,HocKy,Nam,MaMH, GhiChu) VALUES (@MaNganh, @MaKhoa, @HocKy, @Nam,@MaMH, @GhiChu)";
            string MaNganh = Convert.ToString(comboBox_add_nganh.SelectedItem);
            string MaKhoa = Convert.ToString(comboBox_add_khoa.SelectedItem);
            string HocKy = Convert.ToString(comboBox_add_hocky.SelectedItem);
            string Nam = Convert.ToString(comboBox_add_nam.SelectedItem);
            string MaMH = Convert.ToString(comboBox_add_mamh.SelectedItem);
            string GhiChu = textBox_add_ghichucthoc.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MaNganh", MaNganh);
                    command.Parameters.AddWithValue("@MaKhoa", MaKhoa);
                    command.Parameters.AddWithValue("@HocKy", HocKy);
                    command.Parameters.AddWithValue("@Nam", Nam);
                    command.Parameters.AddWithValue("@MaMH", MaMH);
                    command.Parameters.AddWithValue("@GhiChu", GhiChu);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công");
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Thêm không thành công");
                }
            }
            this.Close();
        }

        private void comboBox_add_khoa_SelectionChangeCommitted(object sender, EventArgs e)
        {
            button_add1cthoc.Enabled = false;

            comboBox_add_nganh.Items.Clear();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT MaNganh FROM NGANH WHERE MaKhoa='" + comboBox_add_khoa.SelectedItem.ToString() + "'";

                connection.Open();

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    using (SqlDataReader dta = cmd.ExecuteReader())
                    {
                        while (dta.Read() == true)
                        {
                            comboBox_add_nganh.Items.Add(dta[0].ToString());
                        }
                    }
                }

                connection.Close();
            }
        }

        private void comboBox_add_nam_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBox_add_khoa.Enabled = false;
            comboBox_add_nganh.Enabled = false;
            comboBox_add_mamh.Enabled = false;
            button_add1cthoc.Enabled = false;

            comboBox_add_khoa.SelectedItem = null;
            comboBox_add_nganh.SelectedItem = null;
            comboBox_add_mamh.SelectedItem = null;

            comboBox_add_hocky.Items.Clear();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT HocKy FROM HOCKY WHERE Nam=" + comboBox_add_nam.SelectedItem.ToString();

                connection.Open();

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    using (SqlDataReader dta = cmd.ExecuteReader())
                    {
                        while (dta.Read() == true)
                        {
                            comboBox_add_hocky.Items.Add(dta[0].ToString());
                        }
                    }
                }

                connection.Close();
            }
        }

        private void comboBox_add_nganh_SelectionChangeCommitted(object sender, EventArgs e)
        {
            button_add1cthoc.Enabled = false;
            comboBox_add_mamh.Enabled = true;

            comboBox_add_mamh.Items.Clear();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT MaMH FROM DSMH EXCEPT SELECT MaMH FROM CTHOC WHERE Nam=" + comboBox_add_nam.SelectedItem.ToString() + " AND HocKy=" + comboBox_add_hocky.SelectedItem.ToString();

                connection.Open();

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    using (SqlDataReader dta = cmd.ExecuteReader())
                    {
                        while (dta.Read() == true)
                        {
                            comboBox_add_mamh.Items.Add(dta[0].ToString());
                        }
                    }
                }

                connection.Close();
            }
        }

        private void comboBox_add_hocky_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBox_add_khoa.Enabled = true;
            comboBox_add_nganh.Enabled = true;
            comboBox_add_mamh.Enabled = false;
            button_add1cthoc.Enabled = false;

            comboBox_add_khoa.SelectedItem = null;
            comboBox_add_nganh.SelectedItem = null;
            comboBox_add_mamh.SelectedItem = null;
        }

        private void comboBox_add_mamh_SelectedIndexChanged(object sender, EventArgs e)
        {
            button_add1cthoc.Enabled = true;
        }

        private void comboBox_add_nam_SelectedIndexChanged(object sender, EventArgs e)
        {
            button_add1cthoc.Enabled = false;
        }

        private void comboBox_add_hocky_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_add_khoa.Enabled = true;
            comboBox_add_nganh.Enabled = true;
            comboBox_add_mamh.Enabled = false;
            button_add1cthoc.Enabled = false;

            comboBox_add_khoa.SelectedItem = null;
            comboBox_add_nganh.SelectedItem = null;
            comboBox_add_mamh.SelectedItem = null;
        }
    }
}