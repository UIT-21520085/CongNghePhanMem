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
    public partial class DS_LoaiTC : Form
    {
        public DS_LoaiTC()
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
            table_DSLoaiTC.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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

        private void button_ThemLoaiTC_Click(object sender, EventArgs e)
        {
            this.button_ThemLoaiTC.Enabled = false;
            NhapLoaiTC NhapTC = new NhapLoaiTC();
            NhapTC.FormClosed += delegate
            {
                this.button_ThemLoaiTC.Enabled = true;
            };
            NhapTC.ShowDialog();
            Refresh();
        }

        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            if (e.ColumnIndex == table_DSLoaiTC.Columns["DeleteColumn"].Index)
            {
                String LoaiTC = table_DSLoaiTC.Rows[e.RowIndex].Cells["LoaiTinChi"].Value.ToString();
                this.cnn = new SqlConnection(this.ConnectionString);
                DialogResult msg = MessageBox.Show("Bạn có chắc chắn xóa?", "Xóa loại đối tượng", MessageBoxButtons.YesNo);
                if (msg == DialogResult.Yes)
                {
                    try
                    {
                        cnn.Open();
                        var cmd = new SqlCommand("delete from TINCHI where LoaiTinChi = '" + LoaiTC + "'", this.cnn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Xóa thành công!");
                        cnn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không thể xóa loại tín chỉ này", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                Refresh();
            }
            else if (e.ColumnIndex == table_DSLoaiTC.Columns["UpdateColumn"].Index)
            {
                //MessageBox.Show(table_DSNganh.Rows[e.RowIndex].Cells["MaNganh"].Value.ToString());
                NhapLoaiTC updTC = new NhapLoaiTC(table_DSLoaiTC.Rows[e.RowIndex].Cells["LoaiTinChi"].Value.ToString());
                table_DSLoaiTC.Enabled = false;
                updTC.FormClosed += delegate
                {
                    this.table_DSLoaiTC.Enabled = true;
                };
                updTC.ShowDialog();
                Refresh();
            }
        }
    }
}