using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using SE104;

namespace CNPM
{
    public partial class SinhVien : Form
    {
        private IconButton CurrentButton;
        private Panel LeftBorderButton;
        private Form CurrentChildForm;

        string MSSV = "";
        string HoTen = "";

        public SinhVien(string TaiKhoan, string MSSV)
        {
            InitializeComponent();

            LeftBorderButton = new Panel();
            LeftBorderButton.Size = new Size(7, 60);

            panel_ManHinhChinh.Controls.Add(LeftBorderButton);

            string[] Ten = TaiKhoan.Split(' ');
            this.label_XinChao.Text = "Xin chào, " + Ten[Ten.GetLength(0) - 1];

            this.MSSV= MSSV;
            this.HoTen = TaiKhoan;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        void ResizeWindow(Size s)
        {
            this.Size = s;
        }

        private void ActivateButton(object sender, Color color)
        {
            if (sender != null)
            {
                DisableButton();

                CurrentButton = (IconButton)sender;
                CurrentButton.BackColor = Color.FromArgb(255, 221, 180);
                CurrentButton.ForeColor = color;
                CurrentButton.TextAlign = ContentAlignment.MiddleCenter;
                CurrentButton.IconColor = color;
                CurrentButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                CurrentButton.ImageAlign = ContentAlignment.MiddleRight;

                LeftBorderButton.BackColor = color;
                LeftBorderButton.Location = new Point(0, CurrentButton.Location.Y);
                LeftBorderButton.Visible = true;
                LeftBorderButton.BringToFront();
            }
        }

        private void DisableButton()
        {
            if (CurrentButton != null)
            {
                CurrentButton.BackColor = Color.FromArgb(255, 230, 248);
                CurrentButton.ForeColor = Color.FromArgb(68, 70, 85);
                CurrentButton.TextAlign = ContentAlignment.MiddleLeft;
                CurrentButton.IconColor = Color.FromArgb(68, 70, 85);
                CurrentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                CurrentButton.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form ChildForm)
        {
            if (CurrentChildForm!= null)
            {
                CurrentChildForm.Close();
            }

            CurrentChildForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panel_Desktop.Controls.Add(ChildForm);
            panel_Desktop.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        public Color color1 = Color.FromArgb(196, 132, 0);

        private void iconButton_ThongTinHocPhi_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, color1);
            OpenChildForm(new TTHP(MSSV, HoTen));
            ResizeWindow(new Size(715, 550));
        }

        private void iconButton_DangKyHocPhan_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, color1);
            OpenChildForm(new DangKyHocPhan(MSSV));
            ResizeWindow(new Size(1300, 550));
        }

        private void iconButton_MonHocDaDangKy_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, color1);
            OpenChildForm(new TTDKHP(MSSV));
            ResizeWindow(new Size(1000, 550));
        }

        private void iconButton_HoSoSinhVien_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, color1);
            OpenChildForm(new MSSV(MSSV));
            ResizeWindow(new Size(615 + 265, 450));
        }

        private void iconButton_DangXuat_Click(object sender, EventArgs e)
        {
            DangNhap f = new DangNhap();
            f.Show();
            this.Close();
        }

        private void iconButton_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButton_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconButton_Resize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
