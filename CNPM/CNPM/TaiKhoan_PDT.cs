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
    public partial class TaiKhoan_PDT : Form
    {
        string connetionString = @System.IO.File.ReadAllText(@"ConnectionString.txt");

        public TaiKhoan_PDT()
        {
            InitializeComponent();
            LoadData();
        }

        void ResizeTable()
        {
            // Set your desired AutoSize Mode:
            dataGridView_PDT.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        public void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(connetionString))
            {
                string query = "SELECT TenDangNhap, MatKhau FROM LOGIN_PDT";
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table1 = new DataTable();
                adapter.Fill(table1);
                dataGridView_PDT.DataSource = table1;

                connection.Close();
            }
            ResizeTable();
        }

        private void button_DoiMatKhau_Click(object sender, EventArgs e)
        {
            DoiMatKhau dmk = new DoiMatKhau("LOGIN_PDT");
            dmk.ShowDialog();
            LoadData();
        }

        private void button_ThemTaiKhoan_Click(object sender, EventArgs e)
        {
            ThemTaiKhoan dmk = new ThemTaiKhoan();
            dmk.ShowDialog();
            LoadData();
        }
    }
}
