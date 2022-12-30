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
    public partial class DS_NGANH : Form
    {
        public DS_NGANH()
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
            table_DSNganh.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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

        private void button_ThemNGANH_Click(object sender, EventArgs e)
        {
            this.button_ThemNGANH.Enabled = false;
            NhapNGANH NhapNganh = new NhapNGANH();
            NhapNganh.FormClosed += delegate
            {
                this.button_ThemNGANH.Enabled = true;
            };
            NhapNganh.ShowDialog();
            Refresh();
        }

        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            if (e.ColumnIndex == table_DSNganh.Columns["DeleteColumn"].Index)
            {
                String MaNganh = table_DSNganh.Rows[e.RowIndex].Cells["MaNganh"].Value.ToString();
                this.cnn = new SqlConnection(this.ConnectionString);
                DialogResult msg = MessageBox.Show("Bạn có chắc chắn xóa?", "Xóa ngành", MessageBoxButtons.YesNo);
                if (msg == DialogResult.Yes)
                {
                    try
                    {
                        cnn.Open();
                        var cmd_delete = new SqlCommand("delete from DSMH where MaNganh = '" + MaNganh + "'", this.cnn);
                        cmd_delete.ExecuteNonQuery();
                        var cmd = new SqlCommand("delete from NGANH where MaNganh = " + "'" + MaNganh + "'", this.cnn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Xóa thành công!");
                        cnn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không thể xóa ngành này", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                Refresh();
            }
            else if (e.ColumnIndex == table_DSNganh.Columns["UpdateColumn"].Index)
            {
                //MessageBox.Show(table_DSNganh.Rows[e.RowIndex].Cells["MaNganh"].Value.ToString());
                NhapNGANH updNganh = new NhapNGANH(table_DSNganh.Rows[e.RowIndex].Cells["MaNganh"].Value.ToString());
                table_DSNganh.Enabled = false;
                updNganh.FormClosed += delegate
                {
                    this.table_DSNganh.Enabled = true;
                };
                updNganh.ShowDialog();
                Refresh();
            }
        }
    }
}