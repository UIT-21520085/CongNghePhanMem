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
    public partial class NhapLoaiTC : Form
    {
        public NhapLoaiTC(String LoaiTC = null)
        {
            InitializeComponent();
            if (string.IsNullOrEmpty(LoaiTC))
            {
                this.Text = "Thêm loại tín chỉ mới";
                this.textBox_LoaiTinChi.ReadOnly = false;
                this.button_XacNhan.Click += new System.EventHandler(this.button_XacNhan_Click_insert);
            }
            else
            {
                this.LoaiTC = LoaiTC;
                this.textBox_LoaiTinChi.ReadOnly = true;
                this.Text = "Sửa loại tín chỉ";
                this.button_XacNhan.Click += new System.EventHandler(this.button_XacNhan_Click_update);

                this.cnn = new SqlConnection(this.ConnectionString);

                try
                {
                    this.cnn.Open();
                    SqlCommand cmd = new SqlCommand("Select LoaiTinChi from TINCHI where LoaiTinChi = '" + this.LoaiTC + "'", this.cnn);
                    this.textBox_LoaiTinChi.Text = cmd.ExecuteScalar().ToString();
                    SqlCommand cmd_Tien = new SqlCommand("Select SoTienTinChi from TINCHI where LoaiTinChi = '" + this.LoaiTC + "'", this.cnn);
                    this.numericUpDown_SoTienTinChi.Value = Convert.ToInt64(cmd_Tien.ExecuteScalar());
                    SqlCommand cmd_Tiet = new SqlCommand("Select SoTietTinChi from TINCHI where LoaiTinChi = '" + this.LoaiTC + "'", this.cnn);
                    this.numericUpDown_SoTietTinChi.Value = Convert.ToInt64(cmd_Tiet.ExecuteScalar());
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

        private void button_XacNhan_Click_insert(object sender, EventArgs e)
        {
            this.cnn = new SqlConnection(this.ConnectionString);

            try
            {
                if (string.IsNullOrWhiteSpace(textBox_LoaiTinChi.Text))
                {
                    MessageBox.Show("Bạn chưa nhập thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    String LoaiTC = textBox_LoaiTinChi.Text;
                    if (LoaiTC.Length > 3)
                    {
                        MessageBox.Show("Loại tín chỉ không được vượt quá 3 ký tự! (Nên viết tắt và dùng chữ in hoa)", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        this.cnn.Open();
                        var cmd = new SqlCommand("Insert into TINCHI values ('" + LoaiTC + "', " + Math.Round(this.numericUpDown_SoTietTinChi.Value).ToString() + ", " + Math.Round(this.numericUpDown_SoTienTinChi.Value).ToString() + ")", this.cnn);
                        cmd.ExecuteNonQuery();
                        this.cnn.Close();
                        MessageBox.Show("Thêm thành công!");
                        this.Close();
                    }
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
                this.cnn.Open();
                var cmd = new SqlCommand("Update TINCHI set SoTietTinChi = " + Math.Round(this.numericUpDown_SoTietTinChi.Value).ToString() + ", SoTienTinChi = " + Math.Round(this.numericUpDown_SoTienTinChi.Value).ToString() + " where LoaiTinChi = '" + this.LoaiTC + "'", this.cnn);
                cmd.ExecuteNonQuery();
                this.cnn.Close();
                MessageBox.Show("Sửa thành công!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox_LoaiTinChi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }
    }
}