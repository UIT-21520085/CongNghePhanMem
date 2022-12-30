using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.AxHost;
using System.Linq.Expressions;
using System.Data;
using System.Runtime.Intrinsics.Arm;

namespace SE104
{
    public partial class HSSV : Form
    {
        public HSSV()
        {
            String connectionString = @System.IO.File.ReadAllText(@"ConnectionString.txt");
            InitializeComponent();

            Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.button_ThemHS.Enabled = false;
            NhapHSSV NhapHSSV = new NhapHSSV();
            NhapHSSV.FormClosed += delegate
            {
                this.button_ThemHS.Enabled = true;
            };
            NhapHSSV.ShowDialog();
            Refresh();
        }

        void Refresh()
        {
            this.cnn = new SqlConnection(this.ConnectionString);
            try
            {
                cnn.Open();
                this.insertData();
                //InitializeComponent();
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
            Refresh();
        }

        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            if (e.ColumnIndex == table_DSHSSV.Columns["DeleteColumn"].Index)
            {
                String MSSV = table_DSHSSV.Rows[e.RowIndex].Cells["MSSV"].Value.ToString();
                this.cnn = new SqlConnection(this.ConnectionString);
                DialogResult msg = MessageBox.Show("Bạn có chắc chắn xóa?", "Xóa hồ sơ", MessageBoxButtons.YesNo);
                if (msg == DialogResult.Yes)
                {
                    try
                    {
                        cnn.Open();
                        var count = new SqlCommand("select count(SoPhieu) from DS_PHIEUDKHP where MSSV = '" + MSSV + "' and SoTienConLai > 0", this.cnn);
                        long count_SoTienConLai = Int64.Parse(count.ExecuteScalar().ToString());
                        if (count_SoTienConLai == 0)
                        {
                            var cmd_delete_ct = new SqlCommand("delete from CT_PHIEUDK where SoPhieu in (Select SoPhieu from DS_PHIEUDKHP where MSSV = '" + MSSV + "')", this.cnn);
                            cmd_delete_ct.ExecuteNonQuery();

                            var cmd_delete_phieuthu = new SqlCommand("delete from DS_PHIEUTHU where SoPhieuDK in (Select SoPhieu from DS_PHIEUDKHP where MSSV = '" + MSSV + "')", this.cnn);
                            cmd_delete_phieuthu.ExecuteNonQuery();

                            var cmd_delete_dsdkhp = new SqlCommand("delete from DS_PHIEUDKHP where MSSV = '" + MSSV + "'", this.cnn);
                            cmd_delete_dsdkhp.ExecuteNonQuery();

                            var cmd_delete = new SqlCommand("delete from LOGIN_SINHVIEN where MSSV = '" + MSSV + "'", this.cnn);
                            cmd_delete.ExecuteNonQuery();

                            var cmd = new SqlCommand("delete from HSSV where MSSV = " + "'" + MSSV + "'", this.cnn);
                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Xóa thành công");
                        }
                        else
                        {
                            MessageBox.Show("Sinh viên chưa hoàn thành việc đóng học phí, không thể xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        cnn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                Refresh();
            }
            else if (e.ColumnIndex == table_DSHSSV.Columns["UpdateColumn"].Index)
            {
                UpdateHSSV updHSSV = new UpdateHSSV(table_DSHSSV.Rows[e.RowIndex].Cells["MSSV"].Value.ToString());
                table_DSHSSV.Enabled = false;
                updHSSV.FormClosed += delegate
                {
                    this.table_DSHSSV.Enabled = true;
                };
                updHSSV.ShowDialog();
                Refresh();
            }
            else
            {
                if (e.RowIndex >= 0)
                {
                    TTSV ttsv = new TTSV(table_DSHSSV.Rows[e.RowIndex].Cells["MSSV"].Value.ToString());
                    ttsv.ShowDialog();
                    //   MSSV mssv = new MSSV(table_DSHSSV.Rows[e.RowIndex].Cells["MSSV"].Value.ToString());
                    //   mssv.Show();
                    //TTHP tthp = new TTHP(table_DSHSSV.Rows[e.RowIndex].Cells["MSSV"].Value.ToString(), table_DSHSSV.Rows[e.RowIndex].Cells["HoTen"].Value.ToString());
                    //tthp.Show();
                    // MessageBox.Show(table_DSHSSV.Rows[e.RowIndex].Cells["MSSV"].Value.ToString() + table_DSHSSV.Rows[e.RowIndex].Cells["HoTen"].Value.ToString());
                    //TTDKHP ttdkp = new TTDKHP(table_DSHSSV.Rows[e.RowIndex].Cells["MSSV"].Value.ToString());
                    //ttdkp.Show();
                }
            }
        }

        void ResizeTable()
        {
            // Set your desired AutoSize Mode:
            table_DSHSSV.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }

}