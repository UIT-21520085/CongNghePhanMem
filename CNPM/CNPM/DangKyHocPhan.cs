using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace CNPM
{
    public partial class DangKyHocPhan : Form
    {
        string connetionString = @System.IO.File.ReadAllText(@"ConnectionString.txt");
        int SoMonHocDaChon = 0;
        int ThanhTien = 0;
        int SoPhieu = 0;
        int HocKy = 1;
        int Nam = 2022;
        string MSSV = "";
        bool DangKy_init = false;
        bool ExistMSSV = false;

        bool CheckSelected()
        {

            foreach (DataGridViewRow row in dataGridView_DanhSachMonHocMo.Rows)
            {
                if (Convert.ToBoolean(row.Cells["DangKy"].Value))
                    return true;
            }

            return false;
        }

        void ResizeTable()
        {
            // Set your desired AutoSize Mode:
            dataGridView_DanhSachMonHocMo.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        public void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(connetionString))
            {
                string query = "SELECT DSMH.MaMH, TenMH, DSMH.LoaiTinChi, SoTiet, MaNganh, MaKhoa, SoTiet / SoTietTinChi * SoTienTinChi AS SoTien\r\nFROM DSMH_Mo, DSMH, TINCHI WHERE DSMH_Mo.MaMH=DSMH.MaMH AND DSMH.LoaiTinChi=TINCHI.LoaiTinChi AND HocKy=" + HocKy.ToString() + " AND Nam=" + Nam.ToString() + " AND DSMH.MaMH NOT IN (SELECT MaMH FROM DS_PHIEUDKHP, CT_PHIEUDK WHERE DS_PHIEUDKHP.SoPhieu=CT_PHIEUDK.SoPhieu AND MSSV='" + MSSV + "' AND Nam=" + Nam.ToString() + "AND HocKy=" + HocKy.ToString() + ")";

                connection.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table1 = new DataTable();
                adapter.Fill(table1);

                dataGridView_DanhSachMonHocMo.DataSource = table1;

                connection.Close();
            }
            ResizeTable();
        }
        public DangKyHocPhan(string MSSV = "SV00000001")
        {
            InitializeComponent();

            this.MSSV = MSSV;

            label_ThanhCong.Visible = false;
            string Today = DateTime.Today.ToString("yyyy-MM-dd");

            using (SqlConnection connection = new SqlConnection(connetionString))
            {
                string query = "SELECT DISTINCT(DSMH_MO.Nam) FROM DSMH_MO, HOCKY WHERE DSMH_MO.Nam = HOCKY.Nam AND HOCKY.HanDongHP > '" + Today + "'";

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
            ResizeTable();
        }

        private void dataGridView_DanhSachMonHocMo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView_DanhSachMonHocMo.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dataGridView_DanhSachMonHocMo_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_DanhSachMonHocMo.Columns[e.ColumnIndex].Name == "DangKy")
            {
                string DangKyState = dataGridView_DanhSachMonHocMo.Rows[e.RowIndex].Cells["DangKy"].Value.ToString();
                string SoTienValue = dataGridView_DanhSachMonHocMo.Rows[e.RowIndex].Cells["SoTien"].Value.ToString();

                if (DangKyState == "True")
                {
                    SoMonHocDaChon++;
                    ThanhTien += (int)float.Parse(SoTienValue);
                }
                else
                {
                    SoMonHocDaChon--;
                    ThanhTien -= (int)float.Parse(SoTienValue);
                }

                label_SoMonHocDaChon.Text = "Số môn học đã chọn: " + SoMonHocDaChon.ToString();
                label_ThanhTien.Text = "Thành tiền: " + ThanhTien.ToString();
            }
        }

        private void button_DangKy_Click(object sender, EventArgs e)
        {
            if (!CheckSelected())
            {
                MessageBox.Show("Bạn chưa chọn môn học", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection connection = new SqlConnection(connetionString))
            {
                connection.Open();

                string query_GetSoPhieu = "SELECT SoPhieu FROM DS_PHIEUDKHP WHERE Nam=" + Nam.ToString() + " AND HocKy=" + HocKy.ToString() + " AND MSSV='" + MSSV + "'";

                using (SqlCommand cmd = new SqlCommand(query_GetSoPhieu, connection))
                {
                    using (SqlDataReader dta = cmd.ExecuteReader())
                    {
                        if (dta.Read() == true)
                        {
                            if (!dta.IsDBNull(0))
                            {
                                SoPhieu = dta.GetInt32(0);
                                ExistMSSV = true;
                            }
                        }
                    }
                }

                string query_GetSoPhieu1 = "SELECT MAX(SoPhieu) MaxSoPhieu FROM DS_PHIEUDKHP";
                if (!ExistMSSV)
                {
                    using (SqlCommand cmd = new SqlCommand(query_GetSoPhieu1, connection))
                    {
                        using (SqlDataReader dta = cmd.ExecuteReader())
                        {
                            if (dta.Read() == true)
                            {
                                if (!dta.IsDBNull(0))
                                {
                                    SoPhieu = dta.GetInt32(0) + 1;
                                }
                            }
                        }
                    }

                    string insert_PhieuMoi = "INSERT INTO DS_PHIEUDKHP VALUES (@SoPhieu, @MSSV, @NgLap, @HocKy, @Nam, @SoTienDK, @SoTienDong, @SoTienConLai)";

                    using (SqlCommand cmd = new SqlCommand(insert_PhieuMoi, connection))
                    {
                        cmd.Parameters.AddWithValue("@SoPhieu", SoPhieu);
                        cmd.Parameters.AddWithValue("@MSSV", MSSV);
                        cmd.Parameters.AddWithValue("@NgLap", DateTime.Today);
                        cmd.Parameters.AddWithValue("@HocKy", HocKy);
                        cmd.Parameters.AddWithValue("@Nam", Nam);
                        cmd.Parameters.AddWithValue("@SoTienDK", 0);
                        cmd.Parameters.AddWithValue("@SoTienDong", 0);
                        cmd.Parameters.AddWithValue("@SoTienConLai", 0);

                        int result = cmd.ExecuteNonQuery();

                        // Check Error
                        if (result < 0)
                            MessageBox.Show("Error inserting data into Database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    string insert_PhieuThuMoi = "INSERT INTO DS_PHIEUTHU VALUES (@SoPhieuThu, @SoPhieuDK, @NgLap, @SoTienDong)";
                    int SoPhieuThu = SoPhieu;

                    using (SqlCommand cmd = new SqlCommand(insert_PhieuThuMoi, connection))
                    {
                        cmd.Parameters.AddWithValue("@SoPhieuThu", SoPhieuThu);
                        cmd.Parameters.AddWithValue("@SoPhieuDK", SoPhieu);
                        cmd.Parameters.AddWithValue("@MSSV", MSSV);
                        cmd.Parameters.AddWithValue("@NgLap", DateTime.Today);
                        cmd.Parameters.AddWithValue("@SoTienDong", 0);

                        int result = cmd.ExecuteNonQuery();

                        // Check Error
                        if (result < 0)
                            MessageBox.Show("Error inserting data into Database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                foreach (DataGridViewRow row in dataGridView_DanhSachMonHocMo.Rows)
                {
                    DataGridViewCheckBoxCell cell = (DataGridViewCheckBoxCell)row.Cells[0];

                    if (Convert.ToBoolean(cell.Value))
                    {
                        string MaMH = row.Cells[1].Value.ToString();
                        string LoaiTC = row.Cells[3].Value.ToString();
                        int SoTiet = Int32.Parse(row.Cells[4].Value.ToString());
                        int SoTC = 0;

                        string query_GetSoTietTinChi = "SELECT SoTietTinChi FROM TINCHI WHERE LoaiTinChi='" + LoaiTC + "'";

                        using (SqlCommand cmd = new SqlCommand(query_GetSoTietTinChi, connection))
                        {
                            using (SqlDataReader dta = cmd.ExecuteReader())
                            {
                                if (dta.Read() == true)
                                {
                                    if (!dta.IsDBNull(0))
                                        SoTC = SoTiet / dta.GetInt32(0);
                                }
                            }
                        }

                        string insert_CTPhieuMoi = "INSERT INTO CT_PHIEUDK VALUES (@SoPhieu, @MaMH, @SoTC)";

                        using (SqlCommand cmd = new SqlCommand(insert_CTPhieuMoi, connection))
                        {
                            cmd.Parameters.AddWithValue("@SoPhieu", SoPhieu);
                            cmd.Parameters.AddWithValue("@MaMH", MaMH);
                            cmd.Parameters.AddWithValue("@SoTC", SoTC);

                            int result = cmd.ExecuteNonQuery();

                            // Check Error
                            if (result < 0)
                                MessageBox.Show("Error inserting data into Database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                connection.Close();

                label_ThanhCong.Visible = true;
                label_ThanhCong.Text = "Đăng ký thành công, số phiếu: " + SoPhieu.ToString();

                // Reset
                LoadData();
                SoMonHocDaChon = 0;
                ThanhTien = 0;
                label_SoMonHocDaChon.Text = "Số môn học đã chọn: " + SoMonHocDaChon.ToString();
                label_ThanhTien.Text = "Thành tiền: " + ThanhTien.ToString();
            }
        }

        private void comboBox_Nam_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Nam = Int32.Parse(comboBox_Nam.GetItemText(comboBox_Nam.SelectedItem));

            comboBox_HocKy.Items.Clear();

            string Today = DateTime.Today.ToString("yyyy-MM-dd");
            using (SqlConnection connection = new SqlConnection(connetionString))
            {
                string query = "SELECT DISTINCT(DSMH_Mo.HocKy) FROM DSMH_Mo, HOCKY WHERE DSMH_Mo.Nam=" + Nam.ToString() + " AND DSMH_Mo.Nam = HocKy.Nam AND HOCKY.HocKy = DSMH_Mo.HocKy AND HOCKY.HanDongHP > '" + Today + "'";

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
            HocKy = Int32.Parse(comboBox_HocKy.GetItemText(comboBox_HocKy.SelectedItem));

            ExistMSSV = false;
            LoadData();
        }
    }
}