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
using FontAwesome.Sharp;
using SE104;
using danhsachmonhoc;
using danhsachmonhoc_mo;
using chuongtrinhhoc;
using hocky;

namespace CNPM
{
    public partial class PhongDaoTao : Form
    {
        private IconButton CurrentButton;
        private IconButton CurrentButton1;
        private Panel LeftBorderButton;
        private Form CurrentChildForm;

        public PhongDaoTao(string TaiKhoan)
        {
            InitializeComponent();

            panel_ThayDoiKhac.Visible = false;
            
            if (TaiKhoan != "admin")
                iconButton_ThayDoiKhac.Visible = false;

            LeftBorderButton = new Panel();
            LeftBorderButton.Size = new Size(7, 60);

            panel_ManHinhChinh.Controls.Add(LeftBorderButton);

            this.label_XinChao.Text = "Xin chào, " + TaiKhoan;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconButton_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void iconButton_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ActivateButton(object sender, Color color)
        {
            if (sender != null)
            {
                DisableButton();

                CurrentButton = (IconButton)sender;
                CurrentButton.BackColor = Color.FromArgb(255, 221, 180);
                CurrentButton.ForeColor = color;
                CurrentButton.TextAlign = ContentAlignment.MiddleRight;
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
                DisableButton1();
                CurrentButton.BackColor = Color.FromArgb(255, 230, 248);
                CurrentButton.ForeColor = Color.FromArgb(68, 70, 85);
                CurrentButton.TextAlign = ContentAlignment.MiddleLeft;
                CurrentButton.IconColor = Color.FromArgb(68, 70, 85);
                CurrentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                CurrentButton.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void ActivateButton1(object sender, Color color)
        {
            if (sender != null)
            {
                DisableButton1();

                CurrentButton1 = (IconButton)sender;
                CurrentButton1.BackColor = Color.FromArgb(255, 221, 180);
                CurrentButton1.ForeColor = color;
                CurrentButton1.TextAlign = ContentAlignment.MiddleLeft;
                CurrentButton1.IconColor = color;
            }
        }

        private void DisableButton1()
        {
            if (CurrentButton1 != null)
            {
                CurrentButton1.BackColor = Color.FromArgb(255, 230, 248);
                CurrentButton1.ForeColor = Color.FromArgb(68, 70, 85);
                CurrentButton1.TextAlign = ContentAlignment.MiddleLeft;
                CurrentButton1.IconColor = Color.FromArgb(68, 70, 85);
            }
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
            panel_Desktop.Controls.Add(ChildForm);
            panel_Desktop.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        void ResizeWindow(Size s)
        {
            this.Size = s;
        }

        public Color color1 = Color.FromArgb(196, 132, 0);

        private void iconButton_HoSoSinhVien_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, color1);
            OpenChildForm(new HSSV());
            panel_ThayDoiKhac.Visible = false;
            ResizeWindow(new Size(1400, 650));
        }

        private void iconButton_DanhSachMonHoc_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, color1);
            OpenChildForm(new DanhSachMonHoc());
            panel_ThayDoiKhac.Visible = false;
            ResizeWindow(new Size(1300, 650));
        }

        private void iconButton_ChuongTrinhHoc_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, color1);
            OpenChildForm(new ChuongTrinhHoc());
            panel_ThayDoiKhac.Visible = false;
            ResizeWindow(new Size(1200, 650));
        }

        private void iconButton_DanhSachMonHocMo_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, color1);
            OpenChildForm(new DanhSachMonHocMo());
            panel_ThayDoiKhac.Visible = false;
            ResizeWindow(new Size(800, 650));
        }

        private void iconButton_ThongTinDongHocPhi_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, color1);
            OpenChildForm(new ThongTinDongHocPhi());
            panel_ThayDoiKhac.Visible = false;
            ResizeWindow(new Size(1200, 650));
        }

        private void iconButton_DangXuat_Click(object sender, EventArgs e)
        {
            DangNhap f = new DangNhap();
            f.Show();
            this.Close();
        }

        private void iconButton_ThayDoiKhac_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, color1);
            panel_ThayDoiKhac.Visible = true;
        }

        private void iconButton_DTUT_Click(object sender, EventArgs e)
        {
            ActivateButton1(sender, color1);
            OpenChildForm(new DS_DTUT());
            ResizeWindow(new Size(800, 650));
        }

        private void iconButton_Khoa_Click(object sender, EventArgs e)
        {
            ActivateButton1(sender, color1);
            OpenChildForm(new DS_KHOA());
            ResizeWindow(new Size(800, 650));
        }

        private void iconButton_Nganh_Click(object sender, EventArgs e)
        {
            ActivateButton1(sender, color1);
            OpenChildForm(new DS_NGANH());
            ResizeWindow(new Size(800, 650));
        }

        private void iconButton_TinChi_Click(object sender, EventArgs e)
        {
            ActivateButton1(sender, color1);
            OpenChildForm(new DS_LoaiTC());
            ResizeWindow(new Size(800, 650));
        }

        private void iconButton_HocKy_Click(object sender, EventArgs e)
        {
            ActivateButton1(sender, color1);
            OpenChildForm(new DS_HocKy());
            ResizeWindow(new Size(1000, 650));
        }

        private void iconButton_TaiKhoan_Click(object sender, EventArgs e)
        {
            ActivateButton1(sender, color1);
            OpenChildForm(new TaiKhoan());
            ResizeWindow(new Size(800, 650));
        }
    }
}
