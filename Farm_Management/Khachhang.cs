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

        private void btnThem_Click(object sender, EventArgs e)
        {
            //BindingSource source = new BindingSource();
            this.customerBindingSource.AddNew();
        }

        private void Khachhang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyTrangTraiDataSet.Customer' table. You can move, or remove it, as needed.
            this.dgvKhachhang.ClearSelection();
            this.customerTableAdapter.Fill(this.quanLyTrangTraiDataSet.Customer);

        }
    }
}
