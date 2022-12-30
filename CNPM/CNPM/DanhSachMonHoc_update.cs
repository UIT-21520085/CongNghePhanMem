using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace danhsachmonhoc
{
    public partial class DanhSachMonHoc_update : Form
    {
        string connectionString = @System.IO.File.ReadAllText(@"ConnectionString.txt");
        string MaMH1, TenMH1, LoaiTinChi1, SoTiet1, MaNganh1, MaKhoa1;

        private void textBox_TenMonHoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void button_Dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox_upd_khoa_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBox_upd_nganh.Items.Clear();
            comboBox_upd_nganh.Items.Add("");

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

        private void button_suadsmh_Click(object sender, EventArgs e)
        {
            //MaMH1 = Convert.ToString(comboBox_mamh.SelectedItem);
            TenMH1 = Convert.ToString(textBox_TenMonHoc.Text);
            LoaiTinChi1 = comboBox_upd_loaitinchi.SelectedItem.ToString();
            SoTiet1 = Convert.ToString(numericUpDown1.Value);
            MaNganh1 = Convert.ToString(comboBox_upd_nganh.SelectedItem);
            MaKhoa1 = Convert.ToString(comboBox_upd_khoa.SelectedItem);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query;
                    if (MaNganh1 != "")
                        query = "UPDATE DSMH SET TenMH=@TenMH, LoaiTinChi=@LoaiTinChi, SoTiet=@SoTiet, MaNganh='" + MaNganh1 + "', MaKhoa=@MaKhoa WHERE MaMH=@MaMH";
                    else
                        query = "UPDATE DSMH SET TenMH=@TenMH, LoaiTinChi=@LoaiTinChi, SoTiet=@SoTiet, MaNganh=null, MaKhoa=@MaKhoa WHERE MaMH=@MaMH";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MaMH", MaMH1);
                    command.Parameters.AddWithValue("@TenMH", TenMH1);
                    command.Parameters.AddWithValue("@LoaiTinChi", LoaiTinChi1);
                    command.Parameters.AddWithValue("@SoTiet", SoTiet1);
                    command.Parameters.AddWithValue("@MaKhoa", MaKhoa1);
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Cập nhật thành công!");
                }
                catch (Exception ex)
                {
                    if (comboBox_upd_nganh.SelectedItem == null)
                        MessageBox.Show("Vui lòng chọn ngành.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (textBox_TenMonHoc.Text.Length == 0 || textBox_TenMonHoc.Text == null)
                        MessageBox.Show("Vui lòng nhập tên môn học.");
                    else MessageBox.Show("Cập nhật thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                connection.Close();
            }
            this.Close();
        }

        public DanhSachMonHoc_update(string MaMH, string TenMH, string LoaiTinChi, string SoTiet, string MaNganh, string MaKhoa)
        {
            InitializeComponent();

            MaMH1 = MaMH;
            TenMH1 = TenMH;
            LoaiTinChi1 = LoaiTinChi;
            SoTiet1 = SoTiet;
            MaNganh1 = MaNganh;
            MaKhoa1 = MaKhoa;

            // Thêm giá trị TinChi
            try
            {
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            // Thêm giá trị Nganh
            comboBox_upd_nganh.Items.Add("");
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT MaNganh FROM NGANH WHERE MaKhoa='" + MaKhoa1 + "'";

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


        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox_mamh.SelectedText = MaMH1;
            textBox_TenMonHoc.Text = TenMH1;
            comboBox_upd_loaitinchi.SelectedItem = LoaiTinChi1;
            (numericUpDown1.Value) = Convert.ToInt64(SoTiet1);
            comboBox_upd_nganh.SelectedItem = MaNganh1;
            comboBox_upd_khoa.SelectedItem = MaKhoa1;
        }
    }
}