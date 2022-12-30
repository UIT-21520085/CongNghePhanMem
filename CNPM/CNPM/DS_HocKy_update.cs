using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace hocky
{
    public partial class DS_HocKy_update : Form
    {
        string connectionString = @System.IO.File.ReadAllText(@"ConnectionString.txt");
        string HocKy1, Nam1, NgBatDau1, NgKetThuc1, HanDongHP1;

        private void button_nkt_Click(object sender, EventArgs e)
        {
            groupBox1.Hide();
            groupBox3.Hide();
            groupBox2.Show();
        }

        private void buttonhanthuhp_Click(object sender, EventArgs e)
        {
            groupBox1.Hide();
            groupBox2.Hide();
            groupBox3.Show();
        }

        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBox_ngaykt.Text = monthCalendar2.SelectionRange.Start.ToShortDateString();
        }

        private void monthCalendar4_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBox_hanthuhp.Text = monthCalendar4.SelectionRange.Start.ToShortDateString();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBox_nbd.Text = monthCalendar1.SelectionRange.Start.ToShortDateString();
        }

        private void button_xacnhan_Click(object sender, EventArgs e)
        {
            groupBox1.Hide();
            groupBox2.Hide();
            groupBox3.Hide();
        }

        private void button_xn_group2_Click(object sender, EventArgs e)
        {
            groupBox1.Hide();
            groupBox2.Hide();
            groupBox3.Hide();
        }

        private void button_xngroup3_Click(object sender, EventArgs e)
        {
            groupBox1.Hide();
            groupBox2.Hide();
            groupBox3.Hide();
        }

        private void monthCalendar2_DateSelected(object sender, DateRangeEventArgs e)
        {
            textBox_ngaykt.Text = monthCalendar2.SelectionRange.Start.ToShortDateString();
        }

        private void monthCalendar4_DateSelected(object sender, DateRangeEventArgs e)
        {
            textBox_hanthuhp.Text = monthCalendar4.SelectionRange.Start.ToShortDateString();
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            textBox_nbd.Text = monthCalendar1.SelectionRange.Start.ToShortDateString();
        }

        private void numericUpDown2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsDigit(e.KeyChar);
        }

        private void numericUpDown1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsDigit(e.KeyChar);
        }

        private void button_chonnbd_Click(object sender, EventArgs e)
        {
            groupBox2.Hide();
            groupBox3.Hide();
            groupBox1.Show();
        }

        private void button_upd_data_Click(object sender, EventArgs e)
        {
            try
            {
                HocKy1 = numericUpDown2.Value.ToString();
                Nam1 = numericUpDown1.Value.ToString();
                NgBatDau1 = textBox_nbd.Text;
                NgKetThuc1 = textBox_ngaykt.Text;
                HanDongHP1 = textBox_hanthuhp.Text;
                if (string.IsNullOrWhiteSpace(HocKy1) || string.IsNullOrWhiteSpace(Nam1) || string.IsNullOrWhiteSpace(NgBatDau1) || string.IsNullOrWhiteSpace(NgKetThuc1) || string.IsNullOrWhiteSpace(HanDongHP1))
                {
                    MessageBox.Show("Bạn phải điền đầy đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (Nam1 != NgBatDau1.Split("/")[2])
                    {
                        MessageBox.Show("Ngày bắt đầu phải thuộc năm học đã được chọn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        DateTime nbd = Convert.ToDateTime(NgBatDau1);
                        DateTime nkt = Convert.ToDateTime(NgKetThuc1);
                        DateTime hdhp = Convert.ToDateTime(HanDongHP1);
                        if (nbd >= nkt)
                        {
                            MessageBox.Show("Ngày kết thúc phải lớn hơn ngày bắt đầu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (nbd <= hdhp && hdhp <= nkt)
                            {

                                using (SqlConnection connection = new SqlConnection(connectionString))
                                {
                                    connection.Open();
                                    string query = "UPDATE HOCKY SET NgBatDau=@NgBatDau, NgKetThuc=@NgKetThuc, HanDongHP=@HanDongHP WHERE HocKy=@HocKy AND Nam=@Nam";
                                    SqlCommand command = new SqlCommand(query, connection);
                                    command.Parameters.AddWithValue("@HocKy", HocKy1);
                                    command.Parameters.AddWithValue("@Nam", Nam1);
                                    command.Parameters.AddWithValue("@NgBatDau", NgBatDau1);
                                    command.Parameters.AddWithValue("@NgKetThuc", NgKetThuc1);
                                    command.Parameters.AddWithValue("@HanDongHP", HanDongHP1);
                                    int result = command.ExecuteNonQuery();
                                    if (result > 0)
                                    {
                                        MessageBox.Show("Cập nhật thành công");
                                        connection.Close();
                                        this.Close();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Cập nhật không thành công, vui lòng thử lại");
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Hạn đóng học phí phải phải thuộc khoảng thời gian từ ngày bắt đầu đến ngày kết thúc học kỳ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form_update_Load(object sender, EventArgs e)
        {
            numericUpDown2.Value = Convert.ToInt64(HocKy1);
            numericUpDown1.Value = Convert.ToInt64(Nam1);
            numericUpDown1.Enabled = false;
            numericUpDown2.Enabled = false;
            textBox_nbd.Text = NgBatDau1;
            textBox_ngaykt.Text = NgKetThuc1;
            textBox_hanthuhp.Text = HanDongHP1;
        }

        public DS_HocKy_update(string HocKy, string Nam, string NgBatDau, string NgKetThuc, string HanDongHP)
        {
            InitializeComponent();
            HocKy1 = HocKy;
            Nam1 = Nam;
            NgBatDau1 = NgBatDau;
            NgKetThuc1 = NgKetThuc;
            HanDongHP1 = HanDongHP;
            groupBox1.Hide();
            groupBox2.Hide();
            groupBox3.Hide();
        }
    }
}