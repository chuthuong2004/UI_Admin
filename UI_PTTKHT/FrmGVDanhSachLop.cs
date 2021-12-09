using System;
using System.Threading;
using System.Windows.Forms;

namespace UI_PTTKHT
{
    public partial class FrmGVDanhSachLop : Form
    {
        public FrmGVDanhSachLop()
        {
            InitializeComponent();
        }
        private void ShowForm(Form form)
        {
            Thread thread = new Thread(new ThreadStart(() =>
            {
                form.ShowDialog();
            }));
            thread.Start();
            Thread.Sleep(10);
            this.Close();
        }
        private void label13_Click(object sender, EventArgs e)
        {
            FrmGVTrangChu frmGVTrangChu = new FrmGVTrangChu();
            ShowForm(frmGVTrangChu);
        }

        private void label8_Click(object sender, EventArgs e)
        {
            FrmGVThongBao frmGVThongBao = new FrmGVThongBao();
            ShowForm(frmGVThongBao);
        }

        private void label10_Click(object sender, EventArgs e)
        {
            FrmGVThongTinCaNhan frmGVThongTinCaNhan = new FrmGVThongTinCaNhan();
            ShowForm(frmGVThongTinCaNhan);
        }

        private void label12_Click(object sender, EventArgs e)
        {
            FrmGVLichDay frmGVLichDay = new FrmGVLichDay();
            ShowForm(frmGVLichDay);
        }

        private void label14_Click(object sender, EventArgs e)
        {
            FrmGVXemLuong frmGVXemLuong = new FrmGVXemLuong();
            ShowForm(frmGVXemLuong);
        }

        private void label15_Click(object sender, EventArgs e)
        {
            FrmGVNhapDiem frmGVNhapDiem = new FrmGVNhapDiem();
            ShowForm(frmGVNhapDiem);
        }

        private void label7_Click(object sender, EventArgs e)
        {
            lsbAdmin.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            lsbAdmin.Visible = true;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsbAdmin.SelectedIndex == 0)
            {
                MessageBox.Show("Phần sửa thông tin admin chưa được cập nhật !");
                lsbAdmin.Visible = false;
            }
            else if (lsbAdmin.SelectedIndex == 1)
            {
                MessageBox.Show("Phần đổi mật khẩu chưa được cập nhật !");
                lsbAdmin.Visible = false;
            }
            else if (lsbAdmin.SelectedIndex == 2)
            {
                FrmDangNhap frm = new FrmDangNhap();
                ShowForm(frm);
            }
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            lsbAdmin.Visible = false;
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            lsbAdmin.Visible = false;
        }

        private void tableLayoutPanel1_Click(object sender, EventArgs e)
        {
            lsbAdmin.Visible = false;
        }

        private void flowLayoutPanel1_Click(object sender, EventArgs e)
        {
            lsbAdmin.Visible = false;
        }
    }
}
