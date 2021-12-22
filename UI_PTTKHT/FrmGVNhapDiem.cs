using System;
using System.Threading;
using System.Windows.Forms;

namespace UI_PTTKHT
{
    public partial class FrmGVNhapDiem : Form
    {
        public FrmGVNhapDiem()
        {
            InitializeComponent();
        }

        private void radChuNhiem_Click(object sender, EventArgs e)
        {
            radChuNhiem.Checked = true;
            radMon.Checked = false;
            tblChuNhiem.Visible = true;
            tblBoMon.Visible = false;
            label287.Visible = false;
            label286.Visible = false;
            label285.Visible = false;
            cbLop.Text = " 12A6";
        }

        private void radMon_Click(object sender, EventArgs e)
        {
            radMon.Checked = true;
            radChuNhiem.Checked = false;
            tblChuNhiem.Visible = false;

            label287.Visible = true;
            label286.Visible = true;
            label285.Visible = true;
            tblBoMon.Visible = true;
            cbLop.Text = " 10A1";
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
            FrmGVXemLuong frm = new FrmGVXemLuong();
            ShowForm(frm);
        }

        private void label58_Click(object sender, EventArgs e)
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

        private void panel2_Click(object sender, EventArgs e)
        {
            lsbAdmin.Visible = false;
        }

        private void tblBoMon_Click(object sender, EventArgs e)
        {
            lsbAdmin.Visible = false;
        }

        private void flowLayoutPanel1_Click(object sender, EventArgs e)
        {
            lsbAdmin.Visible = false;
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
           MessageBox.Show("Chức năng chỉnh sửa điểm đang bảo trì !");
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
           MessageBox.Show("Chức năng chỉnh sửa điểm đang bảo trì !");
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
           MessageBox.Show("Chức năng chỉnh sửa điểm đang bảo trì !");
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng chỉnh sửa điểm đang bảo trì !");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng chỉnh sửa điểm đang bảo trì !");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmGVCTNhapDiem frmGVCTNhapDiem = new FrmGVCTNhapDiem();
            ShowForm(frmGVCTNhapDiem);
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng chỉnh sửa điểm đang bảo trì !");

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng chỉnh sửa điểm đang bảo trì !");

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng chỉnh sửa điểm đang bảo trì !");

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng chỉnh sửa điểm đang bảo trì !");

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng chỉnh sửa điểm đang bảo trì !");

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng chỉnh sửa điểm đang bảo trì !");

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng chỉnh sửa điểm đang bảo trì !");

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng chỉnh sửa điểm đang bảo trì !");

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng chỉnh sửa điểm đang bảo trì !");

        }
    }
}
