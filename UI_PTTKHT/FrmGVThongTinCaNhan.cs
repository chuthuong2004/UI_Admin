﻿using System;
using System.Threading;
using System.Windows.Forms;

namespace UI_PTTKHT
{
    public partial class FrmGVThongTinCaNhan : Form
    {
        public FrmGVThongTinCaNhan()
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

        private void label12_Click(object sender, EventArgs e)
        {
            FrmGVLichDay frm = new FrmGVLichDay();
            ShowForm(frm);
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
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

        private void flowLayoutPanel1_Click(object sender, EventArgs e)
        {
            lsbAdmin.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmGVChinhSuaThongTinGiaoVien frm = new FrmGVChinhSuaThongTinGiaoVien();
            ShowForm(frm);
        }
    }
}