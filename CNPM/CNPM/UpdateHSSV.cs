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
    public partial class UpdateHSSV : Form
    {
        public UpdateHSSV(String MSSV)
        {
            String connectionString = @System.IO.File.ReadAllText(@"ConnectionString.txt");
            this.cnn = new SqlConnection(connectionString);
            this.MSSV = MSSV;
            try
            {
                this.cnn.Open();
                InitializeComponent();
                this.textBox_MSSV.Text = this.MSSV;
                var cmd_Tinh = new SqlCommand("Select TenTinh from HSSV hs inner join TINH t on hs.MaTinh = t.MaTinh where MSSV = '" + this.MSSV + "'", this.cnn);
                var cmd_Huyen = new SqlCommand("Select TenHuyen from HSSV hs inner join HUYEN h on hs.MaHuyen = h.MaHuyen where MSSV = '" + this.MSSV + "'", this.cnn);
                var cmd_DTUT = new SqlCommand("Select TenLoaiDTUT from HSSV hs inner join DTUT dt on hs.DTUT = dt.MaDTUT where MSSV = '" + this.MSSV + "'", this.cnn);
                var cmd_Khoa = new SqlCommand("Select TenKhoa from HSSV hs inner join KHOA k on hs.MaKhoa = k.MaKhoa where MSSV = '" + this.MSSV + "'", this.cnn);
                var cmd_Nganh = new SqlCommand("Select TenNganh from HSSV hs inner join NGANH n on hs.MaNganh = n.MaNganh where MSSV = '" + this.MSSV + "'", this.cnn);
                String Tinh, Huyen, Khoa, Nganh, DTUT;
                Tinh = cmd_Tinh.ExecuteScalar().ToString();
                Huyen = cmd_Huyen.ExecuteScalar().ToString();
                DTUT = cmd_DTUT.ExecuteScalar().ToString();
                Khoa = cmd_Khoa.ExecuteScalar().ToString();
                Nganh = cmd_Nganh.ExecuteScalar().ToString();
                this.get_TenTinh();
                comboBox_Tinh.SelectedItem = Tinh;
                this.get_TenHuyen(Tinh);
                comboBox_Huyen.SelectedItem = Huyen;
                this.get_TenKhoa();
                comboBox_Khoa.SelectedItem = Khoa;
                this.get_TenNganh(Khoa);
                comboBox_Nganh.SelectedItem = Nganh;
                this.get_TenLoaiDTUT();
                comboBox_DoiTuong.SelectedItem = DTUT;
                this.GetData();
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

        private void button_XacNhan_Click(object sender, EventArgs e)
        {
            try
            {
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
                var cmd = new SqlCommand(Update_HSSV_query, this.cnn);
                cmd.Parameters.AddWithValue("@MSSV", MSSV);
                cmd.Parameters.AddWithValue("@HoTen", HoTen);
                cmd.Parameters.AddWithValue("@NgaySinh", NgaySinh);
                cmd.Parameters.AddWithValue("@GioiTinh", GioiTinh);
                cmd.Parameters.AddWithValue("@MaTinh", MaTinh);
                cmd.Parameters.AddWithValue("@MaHuyen", MaHuyen);
                cmd.Parameters.AddWithValue("@DTUT", DTUT);
                cmd.Parameters.AddWithValue("@MaKhoa", MaKhoa);
                cmd.Parameters.AddWithValue("@MaNganh", MaNganh);
                if (string.IsNullOrWhiteSpace(HoTen) || string.IsNullOrWhiteSpace(GioiTinh)
                    || string.IsNullOrWhiteSpace(NgaySinh) || string.IsNullOrWhiteSpace(DTUT)
                    || string.IsNullOrWhiteSpace(MaTinh) || string.IsNullOrWhiteSpace(MaHuyen)
                    || string.IsNullOrWhiteSpace(MaKhoa) || string.IsNullOrWhiteSpace(MaNganh))
                {
                    MessageBox.Show("Bạn phải thêm đầy đủ thông tin", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (HoTen.Length > 40)
                    {
                        MessageBox.Show("Họ và tên quá dài", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                                MessageBox.Show("Cập nhật thành công!");
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
                                MessageBox.Show("Cập nhật thành công!");
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
                            MessageBox.Show("Cập nhật thành công!");
                            this.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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