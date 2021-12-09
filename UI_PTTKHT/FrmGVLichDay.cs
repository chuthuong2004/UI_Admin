using System;
using System.Threading;
using System.Windows.Forms;

namespace UI_PTTKHT
{
    public partial class FrmGVLichDay : Form
    {
        public FrmGVLichDay()
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

        private void label14_Click(object sender, EventArgs e)
        {
            FrmGVXemLuong frm = new FrmGVXemLuong();
            ShowForm(frm);
        }

        private void label15_Click(object sender, EventArgs e)
        {
            FrmGVNhapDiem frmGVNhapDiem = new FrmGVNhapDiem();
            ShowForm(frmGVNhapDiem);
        }

        private void label46_Click(object sender, EventArgs e)
        {
            FrmGVDanhSachLop frmGVDanhSachLop = new FrmGVDanhSachLop();
            ShowForm(frmGVDanhSachLop);
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

        private void flowLayoutPanel1_Click(object sender, EventArgs e)
        {
            lsbAdmin.Visible = false;
        }

        private void btnThemGiaoVien_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng thêm lịch dạy đang bảo trì !");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Xin lỗi hiện tại chỉ tải được tuần này !");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Xin lỗi hiện tại chỉ tải được tuần này !");

        }
    }
}
