using System;
using System.Threading;
using System.Windows.Forms;

namespace UI_PTTKHT
{
    public partial class FrmGVXemLuong : Form
    {
        public FrmGVXemLuong()
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
        private void label13_Click(object sender, EventArgs e)
        {
            FrmGVTrangChu frm = new FrmGVTrangChu();
            ShowForm(frm);
        }

        private void label8_Click(object sender, EventArgs e)
        {
            FrmGVThongBao frm = new FrmGVThongBao();
            ShowForm(frm);
        }

        private void label10_Click(object sender, EventArgs e)
        {
            FrmGVThongTinCaNhan frm = new FrmGVThongTinCaNhan();
            ShowForm(frm);
        }

        private void label12_Click(object sender, EventArgs e)
        {
            FrmGVLichDay frm = new FrmGVLichDay();
            ShowForm(frm);
        }

        private void label15_Click(object sender, EventArgs e)
        {
            FrmGVNhapDiem frm = new FrmGVNhapDiem();
            ShowForm(frm);
        }

        private void label67_Click(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Xin lỗi chức năng in bảng lương đang bảo trì !");
        }
    }
}
