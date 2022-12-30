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
    public partial class TaiKhoan_SinhVien : Form
    {
        string connetionString = @System.IO.File.ReadAllText(@"ConnectionString.txt");

        public TaiKhoan_SinhVien()
        {
            InitializeComponent();
            LoadData();
        }

        void ResizeTable()
        {
            // Set your desired AutoSize Mode:
            dataGridView_SinhVien.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        public void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(connetionString))
            {
                string query = "SELECT MSSV, TenDangNhap, MatKhau FROM LOGIN_SINHVIEN";
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table1 = new DataTable();
                adapter.Fill(table1);
                dataGridView_SinhVien.DataSource = table1;

                connection.Close();
            }
            ResizeTable();
        }

        private void button_DoiMatKhau_Click(object sender, EventArgs e)
        {
            DoiMatKhau dmk = new DoiMatKhau();
            dmk.ShowDialog();
            LoadData();
        }
    }
}