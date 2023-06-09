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
            chuong ch = new chuong();
            ch.ShowDialog();
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
        }

        private void khoToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
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

        private void thốngKêChiTiêuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Thongkechitieu tkct = new Thongkechitieu();
            tkct.ShowDialog();
        }

        private void thốngKêCôngNợToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Thongkecongno tkcn = new Thongkecongno();
            tkcn.ShowDialog();
        }

        private void thốngKêTồnKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thongketonkho tktk = new Thongketonkho();
            tktk.ShowDialog();
        }
        private void trangTrạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Trangtrai tt = new Trangtrai();
            tt.ShowDialog();
        }

        private void thiếtBịToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trangthietbi tb = new trangthietbi();
            tb.ShowDialog();
        }

        private void thốngKêVụNuôiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thongkevunuoi tkvn = new Thongkevunuoi();
            tkvn.ShowDialog();
        }

        private void bầyĐànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Baydan bd = new Baydan();
            bd.ShowDialog();
        }

        private void chủngLoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Chungloai cl = new Chungloai();
            cl.ShowDialog();
        }
    }
}
