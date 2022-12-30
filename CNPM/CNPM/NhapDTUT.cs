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
    public partial class NhapDTUT : Form
    {
        public NhapDTUT(String MaDTUT = null)
        {
            InitializeComponent();
            if (string.IsNullOrEmpty(MaDTUT))
            {
                this.label_NhapTenMoi.Visible = false;
                this.label_TenDTMoi.Visible = true;
                this.Text = "Thêm loại đối tượng mới";
                this.button_XacNhan.Click += new System.EventHandler(this.button_XacNhan_Click_insert);
            }
            else
            {
                this.MaDTUT = MaDTUT;
                this.label_NhapTenMoi.Visible = true;
                this.label_TenDTMoi.Visible = false;
                this.Text = "Sửa loại đối tượng";
                this.button_XacNhan.Click += new System.EventHandler(this.button_XacNhan_Click_update);

                this.cnn = new SqlConnection(this.ConnectionString);

                try
                {
                    this.cnn.Open();
                    SqlCommand cmd = new SqlCommand("Select TenLoaiDTUT from DTUT where MaDTUT = " + this.MaDTUT, this.cnn);
                    this.textBox_NhapTenLoaiDoiTuong.Text = cmd.ExecuteScalar().ToString();
                    SqlCommand cmd_TL_MienHP = new SqlCommand("Select TL_MienHP from DTUT where MaDTUT = " + this.MaDTUT, this.cnn);
                    this.numericUpDown_TL_MienHP.Value = Convert.ToDecimal(cmd_TL_MienHP.ExecuteScalar());
                    this.cnn.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private String generate_MaDTUT()
        {
            String Get_Largest_MaKhoa = "Select MaDTUT from DTUT where MaDTUT >= all (Select MaDTUT from DTUT)";
            var cmd = new SqlCommand(Get_Largest_MaKhoa, this.cnn);
            String Largest_MaDTUT = "0";
            Largest_MaDTUT = cmd.ExecuteScalar().ToString();
            Int64 num = 0;
            Int64.TryParse(Largest_MaDTUT, out num);
            String generated = (num + 1).ToString();

            return generated;
        }

        private void button_XacNhan_Click_insert(object sender, EventArgs e)
        {
            this.cnn = new SqlConnection(this.ConnectionString);

            try
            {
                if (string.IsNullOrWhiteSpace(textBox_NhapTenLoaiDoiTuong.Text))
                {
                    MessageBox.Show("Bạn chưa nhập thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    this.cnn.Open();
                    String MaDTUT = generate_MaDTUT();
                    var cmd = new SqlCommand("Insert into DTUT values (" + MaDTUT + ", @TenLoaiDTUT, @TL_MienHP)", this.cnn);
                    cmd.Parameters.AddWithValue("@TenLoaiDTUT", this.textBox_NhapTenLoaiDoiTuong.Text);
                    cmd.Parameters.AddWithValue("@TL_MienHP", this.numericUpDown_TL_MienHP.Value.ToString());
                    cmd.ExecuteNonQuery();
                    this.cnn.Close();
                    MessageBox.Show("Thêm thành công!");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_XacNhan_Click_update(object sender, EventArgs e)
        {
            this.cnn = new SqlConnection(this.ConnectionString);

            try
            {
                if (string.IsNullOrWhiteSpace(textBox_NhapTenLoaiDoiTuong.Text))
                {
                    MessageBox.Show("Bạn chưa nhập thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    this.cnn.Open();
                    var cmd = new SqlCommand("Update DTUT set TenLoaiDTUT = @TenLoaiDTUT, TL_MienHP = @TL_MienHP where MaDTUT = " + this.MaDTUT, this.cnn);
                    cmd.Parameters.AddWithValue("@TenLoaiDTUT", this.textBox_NhapTenLoaiDoiTuong.Text);
                    cmd.Parameters.AddWithValue("@TL_MienHP", this.numericUpDown_TL_MienHP.Value.ToString());
                    cmd.ExecuteNonQuery();
                    this.cnn.Close();
                    MessageBox.Show("Sửa thành công!");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox_NhapTenLoaiDoiTuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }
    }
}