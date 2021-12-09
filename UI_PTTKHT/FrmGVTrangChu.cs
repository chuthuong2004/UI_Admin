using System;
using System.Threading;
using System.Windows.Forms;

namespace UI_PTTKHT
{
    public partial class FrmGVTrangChu : Form
    {
        public FrmGVTrangChu()
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
        private void btnThongTinCaNhan_Click(object sender, EventArgs e)
        {
            FrmGVThongTinCaNhan frm = new FrmGVThongTinCaNhan();
            ShowForm(frm);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmGVThongTinCaNhan frm = new FrmGVThongTinCaNhan();
            ShowForm(frm);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FrmGVThongTinCaNhan frm = new FrmGVThongTinCaNhan();
            ShowForm(frm);
        }

        private void btnXemDiem_Click(object sender, EventArgs e)
        {
            FrmGVLichDay frm = new FrmGVLichDay();
            ShowForm(frm);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            FrmGVLichDay frm = new FrmGVLichDay();
            ShowForm(frm);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            FrmGVLichDay frm = new FrmGVLichDay();
            ShowForm(frm);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            FrmGVLichDay frm = new FrmGVLichDay();
            ShowForm(frm);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            FrmGVLichDay frm = new FrmGVLichDay();
            ShowForm(frm);
        }

        private void label25_Click(object sender, EventArgs e)
        {
            FrmGVThongBao frm = new FrmGVThongBao();
            ShowForm(frm);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FrmGVThongBao frm = new FrmGVThongBao();
            ShowForm(frm);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FrmGVThongBao frm = new FrmGVThongBao();
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

        private void panel4_Click(object sender, EventArgs e)
        {
            lsbAdmin.Visible = false;
        }

        private void btnThongBao_Click(object sender, EventArgs e)
        {
            FrmGVNhapDiem frmGVNhapDiem = new FrmGVNhapDiem();
            ShowForm(frmGVNhapDiem);
        }
    }
}
