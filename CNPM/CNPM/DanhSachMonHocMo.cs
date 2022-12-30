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

namespace danhsachmonhoc_mo
{
    public partial class DanhSachMonHocMo : Form
    {
        string connectionString = @System.IO.File.ReadAllText(@"ConnectionString.txt");
        public DanhSachMonHocMo()
        {
            InitializeComponent();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT DISTINCT(Nam) FROM HOCKY";

                connection.Open();

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    using (SqlDataReader dta = cmd.ExecuteReader())
                    {
                        while (dta.Read() == true)
                        {
                            comboBox_filter_nam.Items.Add(dta[0].ToString());
                        }
                    }
                }

                connection.Close();
            }

            ResizeTable();
        }

        void ResizeTable()
        {
            // Set your desired AutoSize Mode:
            //dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void load_data(string HocKy, string Nam)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT HocKy, Nam, DSMH_Mo.MaMH, TenMH FROM DSMH_Mo, DSMH WHERE DSMH_Mo.MaMH = DSMH.MaMH AND HocKy=" + HocKy + " AND Nam=" + Nam;
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            ResizeTable();
        }

        private void button_dongdsmhmo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_themdsmhmo_Click(object sender, EventArgs e)
        {
            DanhSachMonHocMo_insert form_insert_dsmh_mo = new DanhSachMonHocMo_insert();

            var result = form_insert_dsmh_mo.ShowDialog();
            if (result == DialogResult.OK)
            {
                string HocKy = form_insert_dsmh_mo.ReturnValueHocKy.ToString();
                string Nam = form_insert_dsmh_mo.ReturnValueNam.ToString();
                bool Check = form_insert_dsmh_mo.Check;

                if (Check)
                {
                    comboBox_filter_nam.SelectedItem = Nam;
                    comboBox_filter_hk.Items.Clear();

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string query = "SELECT HocKy FROM HOCKY WHERE Nam=" + comboBox_filter_nam.SelectedItem.ToString();

                        connection.Open();

                        using (SqlCommand cmd = new SqlCommand(query, connection))
                        {
                            using (SqlDataReader dta = cmd.ExecuteReader())
                            {
                                while (dta.Read() == true)
                                {
                                    comboBox_filter_hk.Items.Add(dta[0].ToString());
                                }
                            }
                        }

                        connection.Close();
                    }

                    comboBox_filter_hk.SelectedItem = HocKy;

                    load_data(HocKy, Nam);
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Xóa")
            {
                DialogResult confirm = MessageBox.Show("Bạn có chắc chắn xóa?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    string hocky = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["HocKy"].Value);
                    string nam = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Nam"].Value);
                    string mamh = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["MaMH"].Value);
                    //MessageBox.Show(name_khoa);
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();
                            string query = "DELETE FROM DSMH_Mo WHERE HocKy=@HocKy AND Nam=@Nam AND MaMH=@MaMH";
                            SqlCommand command = new SqlCommand(query, connection);
                            command.Parameters.AddWithValue("@HocKy", hocky);
                            command.Parameters.AddWithValue("@Nam", nam);
                            command.Parameters.AddWithValue("@MaMH", mamh);
                            command.ExecuteNonQuery();
                            MessageBox.Show("Xóa thành công");
                            connection.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Xóa thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    load_data(hocky, nam);
                }
            }
            // code for update

            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Sửa")
            {
                string hocky, nam, mamh;
                hocky = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["HocKy"].Value);
                nam = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["Nam"].Value);
                mamh = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["MaMH"].Value);

                DanhSachMonHocMo_update form_update = new DanhSachMonHocMo_update(hocky, nam, mamh);
                form_update.ShowDialog();

            }
        }

        private void comboBox_filter_nam_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBox_filter_hk.Items.Clear();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT HocKy FROM HOCKY WHERE Nam=" + comboBox_filter_nam.SelectedItem.ToString();

                connection.Open();

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    using (SqlDataReader dta = cmd.ExecuteReader())
                    {
                        while (dta.Read() == true)
                        {
                            comboBox_filter_hk.Items.Add(dta[0].ToString());
                        }
                    }
                }

                connection.Close();
            }
        }

        private void comboBox_filter_hk_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string HocKy, Nam;
            HocKy = Convert.ToString(comboBox_filter_hk.SelectedItem);
            Nam = Convert.ToString(comboBox_filter_nam.SelectedItem);
            load_data(HocKy, Nam);
        }
    }
}