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

namespace SE104
{
    public partial class DS_KHOA : Form
    {
        public DS_KHOA()
        {
            this.cnn = new SqlConnection(ConnectionString);
            try
            {
                cnn.Open();
                InitializeComponent();
                this.insertData();
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            ResizeTable();
        }

        void ResizeTable()
        {
            // Set your desired AutoSize Mode:
            table_DSKhoa.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        void Refresh()
        {
            this.cnn = new SqlConnection(this.ConnectionString);
            try
            {
                cnn.Open();
                this.insertData();
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            ResizeTable();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            this.cnn = new SqlConnection(this.ConnectionString);
            try
            {
                cnn.Open();
                this.insertData();
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_ThemKHOA_Click(object sender, EventArgs e)
        {
            this.button_ThemKHOA.Enabled = false;
            NhapKHOA NhapKhoa = new NhapKHOA();
            NhapKhoa.FormClosed += delegate
            {
                this.button_ThemKHOA.Enabled = true;
            };
            NhapKhoa.ShowDialog();
            Refresh();
        }

        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            if (e.ColumnIndex == table_DSKhoa.Columns["DeleteColumn"].Index)
            {
                String MaKhoa = table_DSKhoa.Rows[e.RowIndex].Cells["MaKhoa"].Value.ToString();
                this.cnn = new SqlConnection(this.ConnectionString);
                DialogResult msg = MessageBox.Show("Bạn có chắc chắn xóa?", "Xóa khoa", MessageBoxButtons.YesNo);
                if (msg == DialogResult.Yes)
                {
                    try
                    {
                        cnn.Open();
                        var cmd_delete_mh = new SqlCommand("delete from DSMH where MaKHoa = '" + MaKhoa + "'", this.cnn);
                        cmd_delete_mh.ExecuteNonQuery();
                        var cmd_delete_nganh = new SqlCommand("delete from NGANH where MaKHoa = '" + MaKhoa + "'", this.cnn);
                        cmd_delete_nganh.ExecuteNonQuery();
                        var cmd = new SqlCommand("delete from KHOA where MaKhoa = " + "'" + MaKhoa + "'", this.cnn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Xóa thành công!");
                        cnn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không thể xóa khoa này", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                Refresh();
            }
            else if (e.ColumnIndex == table_DSKhoa.Columns["UpdateColumn"].Index)
            {
                // MessageBox.Show(table_DSKhoa.Rows[e.RowIndex].Cells["MaKhoa"].Value.ToString());
                NhapKHOA updKhoa = new NhapKHOA(table_DSKhoa.Rows[e.RowIndex].Cells["MaKhoa"].Value.ToString());
                table_DSKhoa.Enabled = false;
                updKhoa.FormClosed += delegate
                {
                    this.table_DSKhoa.Enabled = true;
                };
                updKhoa.ShowDialog();
                Refresh();
            }
        }
    }
}