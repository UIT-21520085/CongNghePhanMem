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

namespace CNPM
{
    public partial class DoiMatKhau : Form
    {
        string connetionString = @System.IO.File.ReadAllText(@"ConnectionString.txt");
        string TableName = "";

        public DoiMatKhau(string tableName="LOGIN_SINHVIEN")
        {
            InitializeComponent();
            TableName = tableName;
        }

        private void button_DoiMatKhau_Click(object sender, EventArgs e)
        {
            string TenDangNhap = textBox_TenDangNhap.Text;
            string MatKhauMoi = textBox_MatKhauMoi.Text;

            using (SqlConnection connection = new SqlConnection(connetionString))
            {
                connection.Open();

                string query = "UPDATE " + TableName + " SET MatKhau=@MatKhauMoi WHERE TenDangNhap=@TenDangNhap";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@TenDangNhap", TenDangNhap);
                command.Parameters.AddWithValue("@MatKhauMoi", MatKhauMoi);

                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Cập nhật thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
