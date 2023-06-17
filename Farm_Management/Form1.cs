﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Khachhang kh = new Khachhang();
            //kh.MdiParent = this;
            kh.ShowDialog();
        }

        private void chuồngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nhanvien nv = new Nhanvien();
            //kh.MdiParent = this;
            nv.ShowDialog();
        }

        private void xưởngSảnXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Xuongsx xsx = new Xuongsx();
            //kh.MdiParent = this;
            xsx.ShowDialog();
        private void quảnLýKhoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Quanlykho qlk = new Quanlykho();
            qlk.ShowDialog();
        }

        private void tạoPhiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Taophieunhap tpn = new Taophieunhap();
            tpn.ShowDialog();
        }

        private void tạoPhiếuXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Taophieuxuat tpx = new Taophieuxuat();
            tpx.ShowDialog();
        }

        private void tạoĐơnHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Taodonhang tdh = new Taodonhang();
            tdh.ShowDialog();
        }

        private void xửLýĐơnHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Xulydonhang xldh = new Xulydonhang();
            xldh.ShowDialog();
        }

        private void thốngKêDoanhThuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Thongkedoanhthu tkdt = new Thongkedoanhthu();
            tkdt.ShowDialog();
        }
    }
}
