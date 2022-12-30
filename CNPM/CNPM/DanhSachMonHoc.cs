using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace danhsachmonhoc
{
    public partial class DanhSachMonHoc : Form
    {
        string connectionString = @System.IO.File.ReadAllText(@"ConnectionString.txt");
        public DanhSachMonHoc()
        {
            InitializeComponent();
            ResizeTable();
        }

        void ResizeTable()
        {
            // Set your desired AutoSize Mode:
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void load_data()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM DSMH", connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
                connection.Close();
            }

            ResizeTable();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
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
                    string MaMH = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["MaMH"].Value);
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        try
                        {
                            connection.Open();
                            string query = "DELETE FROM DSMH WHERE MaMH=@MaMH";
                            SqlCommand command = new SqlCommand(query, connection);
                            command.Parameters.AddWithValue("@MaMH", MaMH);
                            command.ExecuteNonQuery();
                            connection.Close();
                            MessageBox.Show("Xóa thành công!");
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi: " + ex, "Xóa thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        connection.Close();
                    }
                    load_data();
                }
            }
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Sửa")
            {
                string mamh, tenmh, loaitinchi, sotiet, manganh, makhoa;
                mamh = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["MaMH"].Value);
                tenmh = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["TenMH"].Value);
                loaitinchi = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["LoaiTinChi"].Value);
                sotiet = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["SoTiet"].Value);
                manganh = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["MaNganh"].Value);
                makhoa = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["MaKhoa"].Value);

                DanhSachMonHoc_update form_update = new DanhSachMonHoc_update(mamh, tenmh, loaitinchi, sotiet, manganh, makhoa);
                form_update.ShowDialog();
                load_data();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_themdsmh_Click(object sender, EventArgs e)
        {
            DanhSachMonHoc_insert form_insert = new DanhSachMonHoc_insert();
            form_insert.ShowDialog();
            load_data();

        }
    }
}