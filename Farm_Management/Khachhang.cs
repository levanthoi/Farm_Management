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
    public partial class Khachhang : Form
    {
        public Khachhang()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Khachhang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyTrangTraiDataSet1.KhachHang' table. You can move, or remove it, as needed.
            this.khachHangTableAdapter1.Fill(this.quanLyTrangTraiDataSet1.KhachHang);
            // TODO: This line of code loads data into the 'quanLyTrangTraiDataSet.KhachHang' table. You can move, or remove it, as needed.
            this.khachHangTableAdapter.Fill(this.quanLyTrangTraiDataSet.KhachHang);
            BindingSource bs = new BindingSource();
            dgv_khachhang.DataSource = bs;
            bdn_KH.BindingSource = bs;

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
