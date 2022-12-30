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

namespace CNPM
{
    public partial class ThemTaiKhoan : Form
    {
        string connetionString = @System.IO.File.ReadAllText(@"ConnectionString.txt");

        public ThemTaiKhoan()
        {
            InitializeComponent();
        }

        private void button_ThemTaiKhoan_Click(object sender, EventArgs e)
        {
            string TenDangNhap = textBox_TenDangNhap.Text;
            string MatKhauMoi = textBox_MatKhauMoi.Text;

            using (SqlConnection connection = new SqlConnection(connetionString))
            {
                connection.Open();

                string query = "INSERT INTO LOGIN_PDT VALUES (@TenDangNhap, @Matkhaumoi)";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@TenDangNhap", TenDangNhap);
                command.Parameters.AddWithValue("@MatKhauMoi", MatKhauMoi);

                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Thêm thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                connection.Close();
            }
        }

        private void textBox_TenDangNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void textBox_MatKhauMoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }
    }
}
