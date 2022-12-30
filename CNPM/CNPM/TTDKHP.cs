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
    public partial class TTDKHP : Form
    {
        public TTDKHP(String MSSV)
        {
            this.cnn = new SqlConnection(this.ConnectionString);
            try
            {
                cnn.Open();
                InitializeComponent();
                this.MSSV = MSSV;
                this.textBox_MSSV.Text = this.MSSV;
                this.get_Nam();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            ResizeTable();
        }

        void ResizeTable()
        {
            // Set your desired AutoSize Mode:
            table_DS_MonHocDaDK.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void TTDKHP_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                this.cnn.Close();
        }

        private void comboBox_Nam_SelectedIndexChanged(object sender, EventArgs e)
        {
            Object selected_Nam = this.comboBox_Nam.SelectedItem;
            this.get_HocKy(selected_Nam.ToString());
        }

        private void comboBox_HocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.insertData(this.comboBox_HocKy.SelectedItem.ToString(), this.comboBox_Nam.SelectedItem.ToString());
        }
    }
}