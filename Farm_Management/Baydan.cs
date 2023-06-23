using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farm_Management
{
    public partial class Baydan : Form
    {
        public Baydan()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bosunggiong bsg = new Bosunggiong();
            bsg.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Chuyenchuong cc = new Chuyenchuong();
            cc.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Thuhoach th = new Thuhoach();
            th.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Choan ca = new Choan();
            ca.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Ghinhanhaohut gnhh = new Ghinhanhaohut();
            gnhh.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Luuchiphinuoi lcpn = new Luuchiphinuoi();
            lcpn.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Capnhatsuckhoe cnsk = new Capnhatsuckhoe();
            cnsk.Show();
        }
    }
}
