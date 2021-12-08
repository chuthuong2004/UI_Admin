﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace UI_PTTKHT
{
    public partial class FrmHSTrangChu : Form
    {
        public FrmHSTrangChu()
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

        private void label7_Click(object sender, EventArgs e)
        {
            lsbAdmin.Visible = true;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            lsbAdmin.Visible = true;

        }

        private void FrmHSTrangChu_Load(object sender, EventArgs e)
        {
            lsbAdmin.Visible = false;
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
                Thread thread = new Thread(new ThreadStart(() =>
                {
                    FrmDangNhap frm = new FrmDangNhap();
                    frm.ShowDialog();
                }));
                thread.Start();
                Thread.Sleep(10);
                this.Close();
            }
        }

        private void btnThoiKhoaBieu_Click(object sender, EventArgs e)
        {
            FrmHSTKB frmHSTKB = new FrmHSTKB();
            ShowForm(frmHSTKB);
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            FrmHSXemDiem frm = new FrmHSXemDiem();
            ShowForm(frm);
        }

        private void btnXemDiem_Click(object sender, EventArgs e)
        {
            FrmHSXemDiem frm = new FrmHSXemDiem();
            ShowForm(frm);
        }

        private void btnThongBao_Click(object sender, EventArgs e)
        {
            FrmHSThongBao frm = new FrmHSThongBao();
            ShowForm(frm);
        }

        private void btnTTCaNhan_Click(object sender, EventArgs e)
        {

        }
    }
}
