using System;
using System.Threading;
using System.Windows.Forms;

namespace UI_PTTKHT
{
    public partial class FrmHSTTCaNhan : Form
    {
        public FrmHSTTCaNhan()
        {
            InitializeComponent();
        }
        private void ShowForm(Form frm)
        {
            Thread thread = new Thread(new ThreadStart(() =>
            {
                frm.ShowDialog();
            }));
            thread.Start();
            Thread.Sleep(10);
            this.Close();
        }

        private void label32_Click(object sender, EventArgs e)
        {
            FrmHSTrangChu frm = new FrmHSTrangChu();
            ShowForm(frm);
        }

        private void label33_Click(object sender, EventArgs e)
        {
            FrmHSThongBao  frm = new FrmHSThongBao();
            ShowForm(frm);
        }

        private void label35_Click(object sender, EventArgs e)
        {
            FrmHSTKB frm = new FrmHSTKB();
            ShowForm(frm);
        }

        private void label36_Click(object sender, EventArgs e)
        {
            FrmHSXemDiem frm = new FrmHSXemDiem();
            ShowForm(frm);
        }

        private void label7_Click(object sender, EventArgs e)
        {
            lsbAdmin.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            lsbAdmin.Visible = true;
        }

        private void lsbAdmin_SelectedIndexChanged(object sender, EventArgs e)
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

        private void flowLayoutPanel1_Click(object sender, EventArgs e)
        {
            lsbAdmin.Visible = false;
        }
    }
}
