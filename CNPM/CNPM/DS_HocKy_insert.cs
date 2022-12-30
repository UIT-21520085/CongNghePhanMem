using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hocky
{
    public partial class DS_HocKy_insert : Form
    {
        string connectionString = @System.IO.File.ReadAllText(@"ConnectionString.txt");
        public DS_HocKy_insert()
        {
            InitializeComponent();
            groupBox1.Hide();
            groupBox2.Hide();
            groupBox3.Hide();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBox_nbd.Text = monthCalendar1.SelectionRange.Start.ToShortDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox2.Hide();
            groupBox3.Hide();
            groupBox1.Show();
        }

        private void button_close_calendar_Click(object sender, EventArgs e)
        {
            groupBox1.Hide();
            groupBox2.Hide();
            groupBox3.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            groupBox1.Hide();
            groupBox2.Hide();
            groupBox3.Hide();
        }

        private void monthCalendar1_DateChanged_1(object sender, DateRangeEventArgs e)
        {
            textBox_nbd.Text = monthCalendar1.SelectionRange.Start.ToShortDateString();
        }

        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBox_ngaykt.Text = monthCalendar2.SelectionRange.Start.ToShortDateString();
        }

        private void buttonhanthuhp_Click(object sender, EventArgs e)
        {
            groupBox3.Show();
            groupBox1.Hide();
            groupBox2.Hide();


        }

        private void button_nkt_Click(object sender, EventArgs e)
        {
            groupBox1.Hide();
            groupBox3.Hide();
            groupBox2.Show();
        }

        private void button_xngroup3_Click(object sender, EventArgs e)
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

        private void monthCalendar4_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBox_hanthuhp.Text = monthCalendar4.SelectionRange.Start.ToShortDateString();
        }

        private void button_add_data_Click(object sender, EventArgs e)
        {
            try
            {
                string HocKy, Nam, NgBatDau, NgKetThuc, HanDongHP;
                string query = "INSERT INTO HOCKY (HocKy,Nam,NgBatDau,NgKetThuc, HanDongHP) VALUES (@HocKy, @Nam, @NgBatDau, @NgKetThuc, @HanDongHP)";

                //HocKy = Convert.ToString(comboBox_hocky.SelectedItem);
                //Nam = Convert.ToString(comboBox_nam.SelectedItem);
                HocKy = numericUpDown2.Value.ToString();
                Nam = numericUpDown1.Value.ToString();
                NgBatDau = textBox_nbd.Text;
                NgKetThuc = textBox_ngaykt.Text;
                HanDongHP = textBox_hanthuhp.Text;
                if (string.IsNullOrWhiteSpace(HocKy) || string.IsNullOrWhiteSpace(Nam) || string.IsNullOrWhiteSpace(NgBatDau) || string.IsNullOrWhiteSpace(NgKetThuc) || string.IsNullOrWhiteSpace(HanDongHP))
                {
                    MessageBox.Show("Bạn phải điền đầy đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (Nam != NgBatDau.Split("/")[2])
                    {
                        MessageBox.Show("Ngày bắt đầu phải thuộc năm học đã được chọn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        String PK_check = null;
                        try
                        {
                            SqlConnection cnn = new SqlConnection(connectionString);
                            cnn.Open();
                            SqlCommand PK = new SqlCommand("Select HocKy from HOCKY where HocKy = @HocKy and Nam = @Nam", cnn);
                            PK.Parameters.AddWithValue("@HocKy", HocKy);
                            PK.Parameters.AddWithValue("@Nam", Nam);
                            if (PK.ExecuteScalar() != null)
                            {
                                PK_check = PK.ExecuteScalar().ToString();
                            }
                            cnn.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        if (string.IsNullOrEmpty(PK_check))
                        {
                            DateTime nbd = Convert.ToDateTime(NgBatDau);
                            DateTime nkt = Convert.ToDateTime(NgKetThuc);
                            DateTime hdhp = Convert.ToDateTime(HanDongHP);
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
                                        SqlCommand command = new SqlCommand(query, connection);
                                        command.Parameters.AddWithValue("@HocKy", HocKy);
                                        command.Parameters.AddWithValue("@Nam", Nam);
                                        command.Parameters.AddWithValue("@NgBatDau", NgBatDau);
                                        command.Parameters.AddWithValue("@NgKetThuc", NgKetThuc);
                                        command.Parameters.AddWithValue("@HanDongHP", HanDongHP);
                                        //var setDateFormat = new SqlCommand("set dateformat dmy", connection);
                                        //setDateFormat.ExecuteNonQuery();
                                        int result = command.ExecuteNonQuery();
                                        if (result > 0)
                                        {
                                            MessageBox.Show("Thêm thành công");
                                            this.Close();
                                        }
                                        else
                                        {
                                            MessageBox.Show("Thêm thành công, vui lòng thử lại");
                                        }

                                        connection.Close();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Hạn đóng học phí phải phải thuộc khoảng thời gian từ ngày bắt đầu đến ngày kết thúc học kỳ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Học kỳ, năm học đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
    }
}