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
    public partial class DS_DTUT : Form
    {
        public DS_DTUT()
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
            table_DSDTUT.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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

        private void button_ThemDTUT_Click(object sender, EventArgs e)
        {
            this.button_ThemDTUT.Enabled = false;
            NhapDTUT NhapDT = new NhapDTUT();
            NhapDT.FormClosed += delegate
            {
                this.button_ThemDTUT.Enabled = true;
            };
            NhapDT.ShowDialog();
            Refresh();
        }

        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            if (e.ColumnIndex == table_DSDTUT.Columns["DeleteColumn"].Index)
            {
                String MaDT = table_DSDTUT.Rows[e.RowIndex].Cells["MaDTUT"].Value.ToString();
                this.cnn = new SqlConnection(this.ConnectionString);
                DialogResult msg = MessageBox.Show("Bạn có chắc chắn xóa?", "Xóa loại đối tượng", MessageBoxButtons.YesNo);
                if (msg == DialogResult.Yes)
                {
                    try
                    {
                        cnn.Open();
                        var cmd = new SqlCommand("delete from DTUT where MaDTUT = " + MaDT, this.cnn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Xóa thành công!");
                        cnn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không thể xóa đối tượng này", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                Refresh();
            }
            else if (e.ColumnIndex == table_DSDTUT.Columns["UpdateColumn"].Index)
            {
                //MessageBox.Show(table_DSNganh.Rows[e.RowIndex].Cells["MaNganh"].Value.ToString());
                NhapDTUT updDTUT = new NhapDTUT(table_DSDTUT.Rows[e.RowIndex].Cells["MaDTUT"].Value.ToString());
                table_DSDTUT.Enabled = false;
                updDTUT.FormClosed += delegate
                {
                    this.table_DSDTUT.Enabled = true;
                };
                updDTUT.ShowDialog();
                Refresh();
            }
        }
    }
}