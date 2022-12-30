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
    public partial class PhieuThuHP : Form
    {
        public PhieuThuHP(String MSSV, String SoPhieu, String SoTienThu)
        {
            this.MSSV = MSSV;
            this.SoPhieu = SoPhieu;
            this.SoTienThu = SoTienThu;
            InitializeComponent();
            this.cnn = new SqlConnection(this.ConnectionString);
            try
            {
                this.cnn.Open();
                SqlCommand cmd = new SqlCommand("Select convert(varchar(10), NgLap, 103) as Ngay from DS_PHIEUTHU where SoPhieuDK = " + SoPhieu, this.cnn);
                this.NgLap = cmd.ExecuteScalar().ToString();
                this.cnn.Close();
                this.textBox_SoPhieu.Text = SoPhieu;
                this.textBox_MSSV.Text = MSSV;
                this.textBox_SoTienThu.Text = SoTienThu;
                this.textBox_NgayLap.Text = NgLap;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}