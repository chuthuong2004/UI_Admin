using System;
using System.Threading;
using System.Windows.Forms;

namespace UI_PTTKHT
{
    public partial class FrmHSXemDiem : Form
    {
        public FrmHSXemDiem()
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
        private void label3_Click(object sender, EventArgs e)
        {
            FrmHSTrangChu frm = new FrmHSTrangChu();
            ShowForm(frm);
        }

        private void label105_Click(object sender, EventArgs e)
        {
            FrmHSThongBao frm = new FrmHSThongBao();
            ShowForm(frm);
        }

        private void label106_Click(object sender, EventArgs e)
        {
            FrmHSTTCaNhan frm = new FrmHSTTCaNhan();
            ShowForm(frm);
        }

        private void label107_Click(object sender, EventArgs e)
        {
            FrmHSTKB frm = new FrmHSTKB();
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

        private void panel3_Click(object sender, EventArgs e)
        {
            lsbAdmin.Visible = false;
        }

        private void panel3_Click_1(object sender, EventArgs e)
        {
            lsbAdmin.Visible = false;
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            radioButton2.Checked = false;
            MessageBox.Show("Xin lỗi hiện tại không thể tải trang này !");
            radioButton3.Checked = true;
            radioButton2.Checked = false;
            radioButton1.Checked = false;
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            MessageBox.Show("Xin lỗi hiện tại không thể tải trang này !");
            radioButton3.Checked = true;
            radioButton2.Checked = false;
            radioButton1.Checked = false;
        }
    }
}
