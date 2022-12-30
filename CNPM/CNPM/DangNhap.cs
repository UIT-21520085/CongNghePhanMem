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
using System.Runtime.InteropServices;

namespace CNPM
{
    public partial class DangNhap : Form
    {
        string connetionString = @System.IO.File.ReadAllText(@"ConnectionString.txt");

        public DangNhap()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconButton_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButton_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button_PDTDangNhap_Click(object sender, EventArgs e)
        {
            string TaiKhoan = textBox_TaiKhoan.Text;
            string MatKhau = textBox_MatKhau.Text;

            using (SqlConnection connection = new SqlConnection(connetionString))
            {
                string query = "SELECT * FROM LOGIN_PDT WHERE TenDangNhap='" + TaiKhoan + "' AND MatKhau='" + MatKhau + "'";

                connection.Open();

                SqlCommand cmd = new SqlCommand(query, connection);
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true) 
                {
                    PhongDaoTao f = new PhongDaoTao(TaiKhoan);
                    f.Show();
                    this.Hide();
                }
                else
                {
                    label_DangNhapThatBai.Visible = true;
                }

                connection.Close();
            }
        }

        private void button_SVDangNhap_Click(object sender, EventArgs e)
        {
            string TaiKhoan = textBox_TaiKhoan.Text;
            string MatKhau = textBox_MatKhau.Text;

            bool DangNhapThanhCong = false;
            string MSSV = "";

            using (SqlConnection connection = new SqlConnection(connetionString))
            {
                string query = "SELECT * FROM LOGIN_SINHVIEN WHERE TenDangNhap='" + TaiKhoan + "' AND MatKhau='" + MatKhau + "'";
                connection.Open();

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    using (SqlDataReader dta = cmd.ExecuteReader())
                    {
                        if (dta.Read() == true)
                        {
                            MSSV = dta.GetString(2);
                            DangNhapThanhCong = true;
                        }
                    }
                }

                if (DangNhapThanhCong)
                {
                    string query_GetHoTen = "SELECT HoTen FROM HSSV WHERE MSSV='" + MSSV + "'";

                    using (SqlCommand cmd1 = new SqlCommand(query_GetHoTen, connection))
                    {
                        using (SqlDataReader dta1 = cmd1.ExecuteReader())
                        {
                            if (dta1.Read())
                            {
                                SinhVien f = new SinhVien(dta1.GetString(0), MSSV);
                                f.Show();
                                this.Hide();
                            }
                        }
                    }
                }
                else
                {
                    label_DangNhapThatBai.Visible = true;
                }

                connection.Close();
            }
        }

        private void textBox_TaiKhoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void textBox_MatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }
    }
}