using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNPM
{
    public partial class TaiKhoan : Form
    {
        private Form CurrentChildForm;

        public TaiKhoan()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form ChildForm)
        {
            if (CurrentChildForm != null)
            {
                CurrentChildForm.Close();
            }

            CurrentChildForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panel_TaiKhoan.Controls.Add(ChildForm);
            panel_TaiKhoan.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void comboBox_LoaiTaiKhoan_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBox_LoaiTaiKhoan.SelectedItem.ToString() == "Sinh viên")
            {
                OpenChildForm(new TaiKhoan_SinhVien());
            }
            else
            {
                OpenChildForm(new TaiKhoan_PDT());
            }
        }
    }
}
