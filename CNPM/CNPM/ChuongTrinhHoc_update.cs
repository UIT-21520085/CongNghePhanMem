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

namespace chuongtrinhhoc
{
    public partial class ChuongTrinhHoc_update : Form
    {
        string connectionString = @System.IO.File.ReadAllText(@"ConnectionString.txt");

        string HocKy1, MaNganh1, MaKhoa1, Nam1, GhiChu1, MaMH1;

        private void comboBox_upd_nam_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void comboBox_upd_khoa_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void button_upd_cth_done_Click(object sender, EventArgs e)
        {
            GhiChu1 = textBox_upd_ghichu.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE CTHOC SET GhiChu=@GhiChu WHERE MaMH=@MaMH AND HocKy=@HocKy AND Nam=@Nam AND MaNganh=@MaNganh AND MaKhoa=@MaKhoa";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaMH", MaMH1);
                command.Parameters.AddWithValue("@HocKy", HocKy1);
                command.Parameters.AddWithValue("@Nam", Nam1);
                command.Parameters.AddWithValue("@GhiChu", GhiChu1);
                command.Parameters.AddWithValue("@MaNganh", MaNganh1);
                command.Parameters.AddWithValue("@MaKhoa", MaKhoa1);
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Cập nhật thành công.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công.");
                }

                connection.Close();
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            textBox_Nganh.Text = MaNganh1;
            textBox_Khoa.Text = MaKhoa1;
            textBox_upd_ghichu.Text = GhiChu1;
            textBox_HocKy.Text = HocKy1;
            textBox_Nam.Text = Nam1;
            textBox_MonHoc.Text = MaMH1;
            //comboBox_upd_mamh.SelectedItem = MaMH1;
        }

        public ChuongTrinhHoc_update(string HocKy, string Nam, string MaMH, string MaNganh, string MaKhoa, string GhiChu)
        {
            InitializeComponent();

            MaNganh1 = MaNganh;
            MaKhoa1 = MaKhoa;
            HocKy1 = HocKy;
            Nam1 = Nam;
            GhiChu1 = GhiChu;
            MaMH1 = MaMH;
        }

        private void button_dongthemcthoc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}