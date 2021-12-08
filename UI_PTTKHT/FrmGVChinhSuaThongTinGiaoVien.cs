using System;
using System.Threading;
using System.Windows.Forms;

namespace UI_PTTKHT
{
    public partial class FrmGVChinhSuaThongTinGiaoVien : Form
    {
        public FrmGVChinhSuaThongTinGiaoVien()
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
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            FrmGVThongTinCaNhan frmGVThongTinCaNhan = new FrmGVThongTinCaNhan();
            ShowForm(frmGVThongTinCaNhan);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng chỉnh sửa đang bảo trì !");
            FrmGVThongTinCaNhan frmGVThongTinCaNhan = new FrmGVThongTinCaNhan();
            ShowForm(frmGVThongTinCaNhan);
        }

        private void label11_Click(object sender, EventArgs e)
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

        private void panel5_Click(object sender, EventArgs e)
        {
            lsbAdmin.Visible = false;
        }
    }
}
