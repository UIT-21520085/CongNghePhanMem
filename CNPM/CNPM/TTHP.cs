using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE104
{
    public partial class TTHP : Form
    {
        public TTHP(String mssv, String HoTen)
        {
            this.mssv = mssv;
            this.HoTen = HoTen;
            this.cnn = new SqlConnection(ConnectionString);
            try
            {
                this.cnn = new SqlConnection(ConnectionString);
                this.cnn.Open();
                InitializeComponent();
                this.textBox_HoTen.Text = HoTen;
                this.textBox_MSSV.Text = mssv;
                this.get_Nam();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TTHP_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                this.cnn.Close();
        }

        private bool check_HanDongHP(String Nam, String HocKy)
        {
            DateTime date = DateTime.Now;
            SqlCommand cmd = new SqlCommand("Select HanDongHP from HOCKY where HocKy = " + HocKy + "and Nam = " + Nam, this.cnn);
            DateTime expireTime = Convert.ToDateTime(cmd.ExecuteScalar());
            if (expireTime >= date)
                return true;
            else return false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.comboBox_HocKy.SelectedItem != null && this.SoPhieu != null)
            {
                if (check_HanDongHP(this.comboBox_Nam.SelectedItem.ToString(), this.comboBox_HocKy.SelectedItem.ToString()))
                {
                    this.button_DongHP.Enabled = false;
                    DongHP dhp = new DongHP(this.textBox_MSSV.Text, this.comboBox_Nam.SelectedItem.ToString(), this.comboBox_HocKy.SelectedItem.ToString(), decimal.Parse(textBox_SoTienConLai.Text, CultureInfo.InvariantCulture));
                    dhp.FormClosed += delegate
                    {
                        this.button_DongHP.Enabled = true;
                    };
                    dhp.ShowDialog();
                    Refresh();
                    //PhieuThuHP pthp = new PhieuThuHP(this.textBox_MSSV.Text, this.SoPhieu, this.textBox_SoTienThu.Text);
                    //pthp.Show();

                }
                else
                {
                    MessageBox.Show("Đã quá hạn đóng học phí của học kỳ " + this.comboBox_HocKy.SelectedItem.ToString() + ", năm học " + this.comboBox_Nam.SelectedItem.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void comboBox_Nam_SelectedIndexChanged(object sender, EventArgs e)
        {
            Object selected_Nam = this.comboBox_Nam.SelectedItem;
            this.get_HocKy(selected_Nam.ToString());
        }

        private void comboBox_HocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            add_TTHP(this.comboBox_Nam.SelectedItem.ToString(), this.comboBox_HocKy.SelectedItem.ToString());
        }

        private void add_TTHP(String Nam, String HocKy)
        {
            try
            {
                var cmd = new SqlCommand("Select SoPhieu, SoTienDong, (SoTienDong - SoTienConLai) as SoTienDaDong, SoTienConLai from DS_PHIEUDKHP where MSSV = " + "'" + this.mssv + "'and Nam = " + Nam + "and HocKy = " + HocKy, this.cnn);

                SqlDataReader reader = cmd.ExecuteReader();
                bool check = false;
                while (reader.Read())
                {
                    check = true;
                    this.textBox_SoTienThu.Text = reader["SoTienDong"].ToString();
                    this.textBox_SoTienDaDong.Text = reader["SoTienDaDong"].ToString();
                    this.textBox_SoTienConLai.Text = reader["SoTienConLai"].ToString();
                    this.SoPhieu = reader["SoPhieu"].ToString();
                }
                if (!check)
                {
                    this.textBox_SoTienThu.Text = null;
                    this.textBox_SoTienDaDong.Text = null;
                    this.textBox_SoTienConLai.Text = null;
                    this.SoPhieu = null;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void Refresh()
        {
            if (this.comboBox_HocKy.SelectedItem != null)
                this.add_TTHP(this.comboBox_Nam.SelectedItem.ToString(), this.comboBox_HocKy.SelectedItem.ToString());
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            if (this.comboBox_HocKy.SelectedItem != null)
                this.add_TTHP(this.comboBox_Nam.SelectedItem.ToString(), this.comboBox_HocKy.SelectedItem.ToString());
        }
    }
}