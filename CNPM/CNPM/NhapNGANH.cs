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
    public partial class NhapNGANH : Form
    {
        public NhapNGANH(String MaNganh = null)
        {
            InitializeComponent();
            get_TenKhoa();
            if (string.IsNullOrEmpty(MaNganh))
            {
                this.label_NhapTenMoi.Visible = false;
                this.label_TenNganhMoi.Visible = true;
                this.Text = "Thêm ngành mới";
                this.button_XacNhan.Click += new System.EventHandler(this.button_XacNhan_Click_insert);
            }
            else
            {
                this.MaNganh = MaNganh;
                this.label_NhapTenMoi.Visible = true;
                this.label_TenNganhMoi.Visible = false;
                this.Text = "Sửa ngành";
                this.button_XacNhan.Click += new System.EventHandler(this.button_XacNhan_Click_update);

                this.cnn = new SqlConnection(this.ConnectionString);

                try
                {
                    this.cnn.Open();
                    SqlCommand cmd = new SqlCommand("Select TenNganh from NGANH where MaNganh = '" + this.MaNganh + "'", this.cnn);
                    this.textBox_NhapTenNganh.Text = cmd.ExecuteScalar().ToString();
                    this.cnn.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private String generate_MaNganh()
        {
            String Get_Largest_MaNganh = "Select MaNganh from NGANH where MaNganh >= all (Select MaNganh from NGANH)";
            var cmd = new SqlCommand(Get_Largest_MaNganh, this.cnn);
            SqlDataReader reader_MaNganh = cmd.ExecuteReader();
            String Largest_MaNganh = "000";
            if (reader_MaNganh.Read())
            {
                Largest_MaNganh = reader_MaNganh.GetString(0);
            }
            Int64 num = 0;
            Int64.TryParse(Largest_MaNganh.Substring((Largest_MaNganh.Length - 3), 3), out num);
            String generated = "N" + (num + 1).ToString().PadLeft(3, '0');
            reader_MaNganh.Close();

            return generated;
        }

        private void button_XacNhan_Click_insert(object sender, EventArgs e)
        {
            this.cnn = new SqlConnection(this.ConnectionString);

            try
            {
                String MaKhoa = null;
                if (this.comboBox_Khoa.SelectedItem != null)
                {
                    MaKhoa = this.get_MaKhoa(this.comboBox_Khoa.SelectedItem.ToString());
                }
                if (string.IsNullOrWhiteSpace(textBox_NhapTenNganh.Text) || string.IsNullOrWhiteSpace(MaKhoa))
                {
                    MessageBox.Show("Bạn phải nhập đầy đủ thông tin", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    this.cnn.Open();
                    String MaNganh = generate_MaNganh();
                    var cmd = new SqlCommand("Insert into NGANH values (@MaNganh, @TenNganh, @MaKhoa)", this.cnn);
                    cmd.Parameters.AddWithValue("@MaNganh", MaNganh);
                    cmd.Parameters.AddWithValue("@TenNganh", this.textBox_NhapTenNganh.Text);
                    cmd.Parameters.AddWithValue("@MaKhoa", MaKhoa);
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
                String MaKhoa = null;
                if (this.comboBox_Khoa.SelectedItem != null)
                {
                    MaKhoa = this.get_MaKhoa(this.comboBox_Khoa.SelectedItem.ToString());
                }
                if (string.IsNullOrWhiteSpace(textBox_NhapTenNganh.Text) || string.IsNullOrWhiteSpace(MaKhoa))
                {
                    MessageBox.Show("Bạn phải nhập đầy đủ thông tin", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    this.cnn.Open();
                    var cmd = new SqlCommand("Update NGANH set TenNganh = @TenNganh, MaKhoa = @MaKhoa WHERE MaNganh='" + MaNganh + "'", this.cnn);
                    cmd.Parameters.AddWithValue("@TenNganh", this.textBox_NhapTenNganh.Text);
                    cmd.Parameters.AddWithValue("@MaKhoa", MaKhoa);
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

        private void textBox_NhapTenNganh_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }
    }
}