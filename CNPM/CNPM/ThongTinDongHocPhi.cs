using SE104;
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
    public partial class ThongTinDongHocPhi : Form
    {
        string connectionString = @System.IO.File.ReadAllText(@"ConnectionString.txt");

        public ThongTinDongHocPhi()
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
                            comboBox_Nam.Items.Add(dta[0].ToString());
                        }
                    }
                }

                connection.Close();
            }

            dataGridView_ThongTinHocPhi.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            label_TrangThai.Visible = false;
        }

        void ResizeTable()
        {
            // Set your desired AutoSize Mode:
            dataGridView_ThongTinHocPhi.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void load_data(string HocKy, string Nam, string TrangThai="> 0")
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT SoPhieu, MSSV, NgLap, SoTienDK, SoTienDong, SoTienConLai FROM DS_PHIEUDKHP WHERE SoTienConlai " + TrangThai + " AND HocKy=" + HocKy + " AND Nam=" + Nam;
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView_ThongTinHocPhi.DataSource = dt;
                connection.Close();
            }

            ResizeTable();

            label_TrangThai.Visible = true;
            if (TrangThai == "> 0")
                label_TrangThai.Text = "Số sinh viên chưa hoàn thành học phí: " + dataGridView_ThongTinHocPhi.RowCount.ToString();
            else
                label_TrangThai.Text = "Số sinh viên đã hoàn thành học phí: " + dataGridView_ThongTinHocPhi.RowCount.ToString();
        }

        private void comboBox_Nam_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBox_HocKy.Items.Clear();
            comboBox_TrangThai.Items.Clear();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT HocKy FROM HOCKY WHERE Nam=" + comboBox_Nam.SelectedItem.ToString();

                connection.Open();

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    using (SqlDataReader dta = cmd.ExecuteReader())
                    {
                        while (dta.Read() == true)
                        {
                            comboBox_HocKy.Items.Add(dta[0].ToString());
                        }
                    }
                }

                connection.Close();
            }
        }

        private void comboBox_HocKy_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBox_TrangThai.Items.Clear();

            comboBox_TrangThai.Items.AddRange(new object[] {
            "Đã hoàn thành học phí",
            "Chưa hoàn thành học phí"});
        }

        private void dataGridView_ThongTinHocPhi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            if (dataGridView_ThongTinHocPhi.Columns[e.ColumnIndex].HeaderText == "Xem chi tiết")
            {
                string SoPhieu = Convert.ToString(dataGridView_ThongTinHocPhi.Rows[e.RowIndex].Cells["SoPhieu"].Value);
                string MSSV = Convert.ToString(dataGridView_ThongTinHocPhi.Rows[e.RowIndex].Cells["MSSV"].Value);
                string SoTienDong = Convert.ToString(dataGridView_ThongTinHocPhi.Rows[e.RowIndex].Cells["SoTienDong"].Value);

                PhieuThuHP phieuthu = new PhieuThuHP(MSSV, SoPhieu, SoTienDong);
                phieuthu.ShowDialog();
            }
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string HocKy, Nam;
            HocKy = Convert.ToString(comboBox_HocKy.SelectedItem);
            Nam = Convert.ToString(comboBox_Nam.SelectedItem);

            string TrangThai;
            if (comboBox_TrangThai.SelectedItem == "Chưa hoàn thành học phí")
                TrangThai = "> 0";
            else
                TrangThai = "= 0";
            load_data(HocKy, Nam, TrangThai);
        }
    }
}
