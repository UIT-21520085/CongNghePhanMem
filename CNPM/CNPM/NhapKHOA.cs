using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE104
{
    public partial class NhapKHOA : Form
    {
        public NhapKHOA(String MaKhoa = null)
        {
            InitializeComponent();
            if (string.IsNullOrEmpty(MaKhoa))
            {
                this.label_NhapTenMoi.Visible = false;
                this.label_TenKhoaMoi.Visible = true;
                this.Text = "Thêm khoa mới";
                this.button_XacNhan.Click += new System.EventHandler(this.button_XacNhan_Click_insert);
            }
            else
            {
                this.MaKhoa = MaKhoa;
                this.label_NhapTenMoi.Visible = true;
                this.label_TenKhoaMoi.Visible = false;
                this.Text = "Sửa tên khoa";
                this.button_XacNhan.Click += new System.EventHandler(this.button_XacNhan_Click_update);

                this.cnn = new SqlConnection(this.ConnectionString);

                try
                {
                    this.cnn.Open();
                    SqlCommand cmd = new SqlCommand("Select TenKhoa from KHOA where MaKhoa = '" + this.MaKhoa + "'", this.cnn);
                    this.textBox_NhapTenKhoa.Text = cmd.ExecuteScalar().ToString();
                    this.cnn.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }

        private String generate_MaKhoa()
        {
            String Get_Largest_MaKhoa = "Select MaKhoa from KHOA where MaKhoa >= all (Select MaKhoa from KHOA)";
            var cmd = new SqlCommand(Get_Largest_MaKhoa, this.cnn);
            SqlDataReader reader_MaKhoa = cmd.ExecuteReader();
            String Largest_MaKhoa = "000";
            if (reader_MaKhoa.Read())
            {
                Largest_MaKhoa = reader_MaKhoa.GetString(0);
            }
            Int64 num = 0;
            Int64.TryParse(Largest_MaKhoa.Substring((Largest_MaKhoa.Length - 3), 3), out num);
            String generated = "K" + (num + 1).ToString().PadLeft(3, '0');
            reader_MaKhoa.Close();

            return generated;
        }

        private void button_XacNhan_Click_insert(object sender, EventArgs e)
        {
            this.cnn = new SqlConnection(this.ConnectionString);

            try
            {
                if (string.IsNullOrWhiteSpace(textBox_NhapTenKhoa.Text))
                {
                    MessageBox.Show("Bạn chưa nhập thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    this.cnn.Open();
                    String MaKhoa = generate_MaKhoa();
                    var cmd = new SqlCommand("Insert into KHOA values (@MaKhoa, @TenKhoa)", this.cnn);
                    cmd.Parameters.AddWithValue("@MaKhoa", MaKhoa);
                    cmd.Parameters.AddWithValue("@TenKhoa", this.textBox_NhapTenKhoa.Text);
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

        private void button_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_XacNhan_Click_update(object sender, EventArgs e)
        {
            this.cnn = new SqlConnection(this.ConnectionString);

            try
            {
                if (string.IsNullOrWhiteSpace(textBox_NhapTenKhoa.Text))
                {
                    MessageBox.Show("Bạn chưa nhập thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    this.cnn.Open();
                    var cmd = new SqlCommand("Update KHOA set TenKhoa = @TenKhoa where MaKhoa = '" + this.MaKhoa + "'", this.cnn);
                    cmd.Parameters.AddWithValue("@TenKhoa", this.textBox_NhapTenKhoa.Text);
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

        private void textBox_NhapTenKhoa_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }
    }
}