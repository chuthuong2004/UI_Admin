using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_PTTKHT
{
    public partial class FrmGVCTNhapDiem : Form
    {
        public FrmGVCTNhapDiem()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        int counter = 1;
        private void button3_Click(object sender, EventArgs e)
        {
            if (counter>9)
            {
                MessageBox.Show("Đã hết hàng thêm !");
            }
            if(counter ==1 )
                pn1.Visible = true;
            else if (counter ==2 )
                pn33.Visible = true;
            else if (counter ==3)
                pn3.Visible = true;
            else if (counter==4)
                pn4.Visible = true;
            else if (counter ==5)
                pn5.Visible = true;
            else if (counter == 6)
                pn6.Visible = true;
            else if (counter == 7)
                pn7.Visible = true;
            else if (counter == 8)
                pn8.Visible = true;
            else if (counter == 9)
                pn9.Visible = true;
            counter++;
        }
        int counterChuNhiem = 11;
        private void button6_Click(object sender, EventArgs e)
        {
            if (counterChuNhiem > 19)
            {
                MessageBox.Show("Đã hết hàng thêm !");
            }
            if (counterChuNhiem == 11)
                pn11.Visible = true;
            else if (counterChuNhiem == 12)
                pn12.Visible = true;
            else if (counterChuNhiem ==13)
                pn13.Visible = true;
            else if (counterChuNhiem == 14)
                pn14.Visible = true;
            else if (counterChuNhiem == 15)
                pn15.Visible = true;
            else if (counterChuNhiem == 16)
                pn16.Visible = true;
            else if (counterChuNhiem == 17)
                pn17.Visible = true;
            else if (counterChuNhiem ==18)
                pn18.Visible = true;
            else if (counterChuNhiem == 19)
                pn19.Visible = true;
            counterChuNhiem++;
        }

        private void radChuNhiem_Click(object sender, EventArgs e)
        {
            radChuNhiem.Checked = true;
            radMon.Checked = false;
            pnBoMon.Visible = false;
            pnChuNhiem.Visible = true;
            cbLop.Text = " 12A6";
        }

        private void radMon_Click(object sender, EventArgs e)
        {
            radChuNhiem.Checked = false;
            radMon.Checked = true;
            pnBoMon.Visible = true;
            pnChuNhiem.Visible = false;
            cbLop.Text = " 10A1";
        }

        private void FrmGVCTNhapDiem_Load(object sender, EventArgs e)
        {
            pnChuNhiem.Visible = true;
            pnBoMon.Visible = false;
            radChuNhiem.Checked = true;
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
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lưu thông tin điểm học sinh thành công");
            FrmGVNhapDiem frmGVNhapDiem = new FrmGVNhapDiem();
            ShowForm(frmGVNhapDiem);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 0)
            {
                MessageBox.Show("Phần sửa thông tin admin chưa được cập nhật !");
                listBox1.Visible = false;
            }
            else if (listBox1.SelectedIndex == 1)
            {
                MessageBox.Show("Phần đổi mật khẩu chưa được cập nhật !");
                listBox1.Visible = false;
            }
            else if (listBox1.SelectedIndex == 2)
            {
                FrmDangNhap frm = new FrmDangNhap();
                ShowForm(frm);
            }
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            listBox1.Visible = false;
        }

        private void pn2_Click(object sender, EventArgs e)
        {
            listBox1.Visible = false;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            listBox1.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            listBox1.Visible = true;
        }
    }
}
