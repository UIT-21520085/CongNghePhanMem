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
    public partial class NhapHSSV : Form
    {
        public NhapHSSV()
        {
            String connectionString = @System.IO.File.ReadAllText(@"ConnectionString.txt");
            this.cnn = new SqlConnection(connectionString);

            try
            {
                this.cnn.Open();
                InitializeComponent();
                this.get_TenTinh();
                this.get_TenKhoa();
                this.get_TenLoaiDTUT();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void NhapHSSV_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                this.cnn.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_Tinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            Object selected_Tinh = this.comboBox_Tinh.SelectedItem;
            this.get_TenHuyen(selected_Tinh.ToString());
        }

        private void comboBox_Khoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            Object selected_Khoa = this.comboBox_Khoa.SelectedItem;
            this.get_TenNganh(selected_Khoa.ToString());
        }

        private String generate_MSSV()
        {
            String Get_Largest_MSSV = "Select MSSV from HSSV where MSSV >= all (Select MSSV from HSSV)";
            var cmd = new SqlCommand(Get_Largest_MSSV, this.cnn);
            SqlDataReader reader_MSSV = cmd.ExecuteReader();
            String Largest_MSSV = "0000000000";
            if (reader_MSSV.Read())
            {
                Largest_MSSV = reader_MSSV.GetString(0);
            }
            Int64 num;
            Int64.TryParse(Largest_MSSV.Substring((Largest_MSSV.Length - 8), 8), out num);
            String generated_MSSV = "SV" + (num + 1).ToString().PadLeft(8, '0');
            reader_MSSV.Close();

            return generated_MSSV;
        }

        private void button_XacNhan_Click(object sender, EventArgs e)
        {
            try
            {
                String MSSV = generate_MSSV();
                String HoTen = textBox_HoVaTen.Text;
                String NgaySinh = dateTimePicker_NgaySinh.Text;
                String GioiTinh = "Nam";
                String MaTinh = null, MaHuyen = null, DTUT = null, MaKhoa = null, MaNganh = null;
                if (radioButton_Nu.Checked)
                {
                    GioiTinh = "Nữ";
                }
                if (this.comboBox_Tinh.SelectedItem != null)
                {
                    MaTinh = this.get_MaTinh(this.comboBox_Tinh.SelectedItem.ToString());
                }
                if (this.comboBox_Huyen.SelectedItem != null)
                {
                    MaHuyen = this.get_MaHuyen(this.comboBox_Huyen.SelectedItem.ToString(), MaTinh);
                }
                if (this.comboBox_DoiTuong.SelectedItem != null)
                {
                    DTUT = this.get_DTUT(this.comboBox_DoiTuong.SelectedItem.ToString()).ToString();
                }
                if (this.comboBox_Khoa.SelectedItem != null)
                {
                    MaKhoa = this.get_MaKhoa(this.comboBox_Khoa.SelectedItem.ToString());
                }
                if (this.comboBox_Nganh.SelectedItem != null)
                {
                    MaNganh = this.get_MaNganh(this.comboBox_Nganh.SelectedItem.ToString());
                }

                var setDateFormat = new SqlCommand("set dateformat dmy", this.cnn);
                setDateFormat.ExecuteNonQuery();

                var cmd = new SqlCommand(Insert_HSSV_query, this.cnn);
                cmd.Parameters.AddWithValue("@MSSV", MSSV);
                cmd.Parameters.AddWithValue("@HoTen", HoTen);
                cmd.Parameters.AddWithValue("@NgaySinh", NgaySinh);
                cmd.Parameters.AddWithValue("@GioiTinh", GioiTinh);
                cmd.Parameters.AddWithValue("@MaTinh", MaTinh);
                cmd.Parameters.AddWithValue("@MaHuyen", MaHuyen);
                cmd.Parameters.AddWithValue("@DTUT", DTUT);
                cmd.Parameters.AddWithValue("@MaKhoa", MaKhoa);
                cmd.Parameters.AddWithValue("@MaNganh", MaNganh);

                var cmd_insert = new SqlCommand("Insert into LOGIN_SINHVIEN values (@MSSV, '123456789', @MSSV)", this.cnn);
                cmd_insert.Parameters.AddWithValue("@MSSV", MSSV);

                if (string.IsNullOrWhiteSpace(HoTen) || string.IsNullOrWhiteSpace(GioiTinh)
                    || string.IsNullOrWhiteSpace(NgaySinh) || string.IsNullOrWhiteSpace(DTUT)
                    || string.IsNullOrWhiteSpace(MaTinh) || string.IsNullOrWhiteSpace(MaHuyen)
                    || string.IsNullOrWhiteSpace(MaKhoa) || string.IsNullOrWhiteSpace(MaNganh))
                {
                    MessageBox.Show("Bạn phải thêm đầy đủ thông tin", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (DTUT.Equals("5"))
                    {
                        var cmd_getVS = new SqlCommand("Select MaHuyen from HUYEN where MaHuyen = '" + MaHuyen + "' and VungSau = 1", this.cnn);
                        var check = cmd_getVS.ExecuteScalar();
                        if (check != null)
                        {
                            cmd.ExecuteNonQuery();
                            cmd_insert.ExecuteNonQuery();
                            MessageBox.Show("Thêm thành công!");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Huyện được chọn không thuộc danh sách vùng sâu", "Thông tin không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (DTUT.Equals("6"))
                    {
                        var cmd_getVX = new SqlCommand("Select MaHuyen from HUYEN where MaHuyen = '" + MaHuyen + "' and VungXa = 1", this.cnn);
                        var check = cmd_getVX.ExecuteScalar();
                        if (check != null)
                        {
                            cmd.ExecuteNonQuery();
                            cmd_insert.ExecuteNonQuery();
                            MessageBox.Show("Thêm thành công!");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Huyện được chọn không thuộc danh sách vùng xa", "Thông tin không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        cmd.ExecuteNonQuery();
                        cmd_insert.ExecuteNonQuery();
                        MessageBox.Show("Thêm thành công!");
                        this.Close();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox_HoVaTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }
    }
}