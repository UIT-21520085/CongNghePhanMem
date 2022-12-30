using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace SE104
{
    public partial class DongHP : Form
    {
        public DongHP(String MSSV, String Nam, String HocKy, decimal SoTienConLai)
        {
            this.MSSV = MSSV;
            this.Nam = Nam;
            this.HocKy = HocKy;
            this.SoTienConLai = SoTienConLai;
            InitializeComponent();
        }

        private void button_XacNhan_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(textBox_NhapSoTienDong.Text) || string.IsNullOrWhiteSpace(textBox_NhapSoTienDong.Text)))
            {
                decimal SoTienDong = decimal.Parse(textBox_NhapSoTienDong.Text, CultureInfo.InvariantCulture);
                if (SoTienDong > this.SoTienConLai)
                {
                    MessageBox.Show("Số tiền đóng không được vượt quá số tiền còn lại", "Lỗi", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                }
                else
                {
                    this.cnn = new SqlConnection(this.ConnectionString);
                    try
                    {
                        this.cnn.Open();
                        SqlCommand cmd = new SqlCommand("Update DS_PHIEUDKHP set SoTienConLai = SoTienConLai - " + SoTienDong.ToString() + "where MSSV = " + "'" + this.MSSV + "' and Nam = " + Nam + " and HocKy = " + HocKy, this.cnn);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Đóng tiền thành công");
                        this.cnn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    this.Close();
                }
            }
        }

        private void textBox_NhapSoTienDong_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsDigit(e.KeyChar);
        }
    }
}