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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace danhsachmonhoc
{
    public partial class DanhSachMonHoc_insert : Form
    {
        string connectionString = @System.IO.File.ReadAllText(@"ConnectionString.txt");
        public DanhSachMonHoc_insert()
        {
            InitializeComponent();

            // Thêm giá trị TinChi
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT LoaiTinChi FROM TINCHI";

                connection.Open();

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    using (SqlDataReader dta = cmd.ExecuteReader())
                    {
                        while (dta.Read() == true)
                        {
                            comboBox_upd_loaitinchi.Items.Add(dta[0].ToString());
                        }
                    }
                }

                connection.Close();
            }

            // Thêm giá trị Khoa
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
                            comboBox_upd_khoa.Items.Add(dta[0].ToString());
                        }
                    }
                }

                connection.Close();
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query_GetMaMH = "SELECT MAX(MaMH) MaxMaMH FROM DSMH";
                using (SqlCommand cmd = new SqlCommand(query_GetMaMH, connection))
                {
                    using (SqlDataReader dta = cmd.ExecuteReader())
                    {
                        int MaMH = 0;
                        if (dta.Read() == true)
                        {
                            if (!dta.IsDBNull(0))
                            {
                                string[] RawMaMH = dta.GetString(0).Split('M');
                                MaMH = Int32.Parse(RawMaMH[1]);
                                MaMH = MaMH + 1;
                            }
                        }
                        textBox_MaMonHoc.Text = "M" + MaMH.ToString("D3");
                    }
                }

                connection.Close();
            }
        }

        private void button_dongthemdsmh_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_themdsmh_Click(object sender, EventArgs e)
        {
            string MaMH1, TenMH1, LoaiTinChi1, SoTiet1, MaNganh1, MaKhoa1;
            MaMH1 = textBox_MaMonHoc.Text;
            TenMH1 = textBox_TenMonHoc.Text;
            LoaiTinChi1 = Convert.ToString(comboBox_upd_loaitinchi.SelectedItem);
            SoTiet1 = numericUpDown1.Value.ToString();
            MaNganh1 = Convert.ToString(comboBox_upd_nganh.SelectedItem);
            MaKhoa1 = Convert.ToString(comboBox_upd_khoa.SelectedItem);

            string query;

            if (MaNganh1 != "")
                query = "INSERT INTO DSMH VALUES (@MaMH, @TenMH, @LoaiTinChi, @SoTiet, '" + MaNganh1 + "', @MaKhoa)";
            else
                query = "INSERT INTO DSMH VALUES (@MaMH, @TenMH, @LoaiTinChi, @SoTiet, null, @MaKhoa)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MaMH", MaMH1);
                    command.Parameters.AddWithValue("@TenMH", TenMH1);
                    command.Parameters.AddWithValue("@LoaiTinChi", LoaiTinChi1);
                    command.Parameters.AddWithValue("@SoTiet", SoTiet1);
                    command.Parameters.AddWithValue("@MaKhoa", MaKhoa1);
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Thêm thành công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thêm thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void comboBox_upd_khoa_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBox_upd_nganh.Items.Clear();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT MaNganh FROM NGANH WHERE MaKhoa='" + comboBox_upd_khoa.SelectedItem.ToString() + "'";

                connection.Open();

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    using (SqlDataReader dta = cmd.ExecuteReader())
                    {
                        while (dta.Read() == true)
                        {
                            comboBox_upd_nganh.Items.Add(dta[0].ToString());
                        }
                    }
                }

                connection.Close();
            }
        }

        private void textBox_TenMonHoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }
    }
}