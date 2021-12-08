using System;
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
    public partial class FrmHSChinhSua : Form
    {
        public FrmHSChinhSua()
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lsbAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cập nhật thành công !");
            FrmHSTTCaNhan frm = new FrmHSTTCaNhan();
            ShowForm(frm);
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            FrmHSTTCaNhan frm = new FrmHSTTCaNhan();
            ShowForm(frm);
        }
    }
}
