﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace chuongtrinhhoc
{
    public partial class ChuongTrinhHoc : Form
    {
        string connectionString = @System.IO.File.ReadAllText(@"ConnectionString.txt");

        public ChuongTrinhHoc()
        {
            InitializeComponent();
            load_data();
        }

        void ResizeTable()
        {
            // Set your desired AutoSize Mode:
            dataGridView1.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void load_data()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM CTHOC", connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
                connection.Close();
            }

            ResizeTable();
        }

        private void button_dongcthoc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_addcthoc_Click(object sender, EventArgs e)
        {
            ChuongTrinhHoc_insert form_insert = new ChuongTrinhHoc_insert();
            form_insert.ShowDialog();
            load_data();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Xóa")
            {
                DialogResult confirm = MessageBox.Show("Bạn có thật sự muốn xóa nó?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    string HocKy = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["HocKy"].Value);
                    string Nam = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Nam"].Value);
                    string MaMH = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["MaMH"].Value);
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        try
                        {
                            connection.Open();
                            string query = "DELETE FROM CTHOC WHERE MaMH=@MaMH AND HocKy=@HocKy AND Nam=@Nam";
                            SqlCommand command = new SqlCommand(query, connection);
                            command.Parameters.AddWithValue("@MaMH", MaMH);
                            command.Parameters.AddWithValue("@HocKy", HocKy);
                            command.Parameters.AddWithValue("@Nam", Nam);
                            int result = command.ExecuteNonQuery();
                            if (result > 0)
                            {
                                MessageBox.Show("Xóa thành công");
                            }
                            else
                            {
                                MessageBox.Show("Xóa không thành công");
                            }

                            connection.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Xóa thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    load_data();
                }
            }
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Sửa")
            {
                string hocky, nam, mamh, ghichu, manganh, makhoa;
                mamh = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["MaMH"].Value);
                hocky = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["HocKy"].Value);
                nam = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Nam"].Value);
                ghichu = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["GhiChu"].Value);
                manganh = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["MaNganh"].Value);
                makhoa = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["MaKhoa"].Value);

                ChuongTrinhHoc_update form_update = new ChuongTrinhHoc_update(hocky, nam, mamh, manganh, makhoa, ghichu);
                form_update.ShowDialog();
                load_data();
            }
        }
    }
}