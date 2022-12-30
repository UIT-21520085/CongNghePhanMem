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

namespace danhsachmonhoc_mo
{
    public partial class DanhSachMonHocMo_insert : Form
    {
        string connectionString = @System.IO.File.ReadAllText(@"ConnectionString.txt");

        public string ReturnValueHocKy { get; set; }
        public string ReturnValueNam { get; set; }
        public bool Check { get; set; }
        public DanhSachMonHocMo_insert()
        {
            InitializeComponent();
            Check = false;
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
                            comboBox_nam.Items.Add(dta[0].ToString());
                        }
                    }
                }

                connection.Close();
            }
        }

        private void button_dongthemdsmhmo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_themdsmhmo_Click(object sender, EventArgs e)
        {
            string MaMH, HocKy, Nam;
            string query = "INSERT INTO DSMH_Mo (HocKy,Nam,MaMH) VALUES (@HocKy, @Nam, @MaMH)";

            HocKy = Convert.ToString(comboBox_chonhocky.SelectedItem);
            Nam = Convert.ToString(comboBox_nam.SelectedItem);
            MaMH = Convert.ToString(comboBox_MaMonHoc.SelectedItem);

            this.ReturnValueHocKy = HocKy;
            this.ReturnValueNam = Nam;

            //MessageBox.Show(HocKy + Nam + MaMH);
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@HocKy", HocKy);
                    command.Parameters.AddWithValue("@Nam", Nam);
                    command.Parameters.AddWithValue("@MaMH", MaMH);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Thêm thành công");
                    connection.Close();
                    Check = true;
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Thêm thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            this.DialogResult = DialogResult.OK;
        }

        private void comboBox_nam_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBox_chonhocky.Items.Clear();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT HocKy FROM HOCKY WHERE Nam=" + comboBox_nam.SelectedItem.ToString();

                connection.Open();

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    using (SqlDataReader dta = cmd.ExecuteReader())
                    {
                        while (dta.Read() == true)
                        {
                            comboBox_chonhocky.Items.Add(dta[0].ToString());
                        }
                    }
                }

                connection.Close();
            }
        }

        private void comboBox_chonhocky_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBox_MaMonHoc.Items.Clear();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT MaMH FROM CTHOC WHERE Nam=" + comboBox_nam.SelectedItem.ToString() + " AND HocKy=" + comboBox_chonhocky.SelectedItem.ToString() + " EXCEPT SELECT MaMH FROM DSMH_Mo WHERE Nam=" + comboBox_nam.SelectedItem.ToString() + " AND HocKy=" + comboBox_chonhocky.SelectedItem.ToString();

                connection.Open();

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    using (SqlDataReader dta = cmd.ExecuteReader())
                    {
                        while (dta.Read() == true)
                        {
                            comboBox_MaMonHoc.Items.Add(dta[0].ToString());
                        }
                    }
                }

                connection.Close();
            }
        }
    }
}