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

namespace hocky
{
    public partial class DS_HocKy : Form
    {
        string connectionString = @System.IO.File.ReadAllText(@"ConnectionString.txt");
        public DS_HocKy()
        {
            InitializeComponent();
            load_data();
        }

        void ResizeTable()
        {
            // Set your desired AutoSize Mode:
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void load_data()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM HOCKY", connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
                connection.Close();
            }
            ResizeTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DS_HocKy_insert insert = new DS_HocKy_insert();
            insert.ShowDialog();

            load_data();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                string HocKy, Nam, NgBatDau, NgKetThuc, HanDongHP;
                HocKy = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["HocKy1"].Value);
                Nam = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Nam"].Value);
                NgBatDau = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["NgBatDau"].Value).Split(" ")[0];
                NgKetThuc = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["NgKetThuc"].Value).Split(" ")[0];
                HanDongHP = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["HanDongHP"].Value).Split(" ")[0];

                DS_HocKy_update form_update = new DS_HocKy_update(HocKy, Nam, NgBatDau, NgKetThuc, HanDongHP);
                form_update.ShowDialog();
                load_data();
            }
        }
    }
}
