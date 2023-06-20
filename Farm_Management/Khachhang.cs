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
            display();
        }

        private void Khachhang_Load(object sender, EventArgs e)
        {

        }
        connectDB db = new connectDB();

        private void display()
        {
            string query = "select * from Customer";
            dgvKhachhang.DataSource = db.getData(query);
            dgvKhachhang.Columns[0].HeaderText = "Mã khách hàng";
            dgvKhachhang.Columns[1].HeaderText = "Tên khách hàng";
            dgvKhachhang.Columns[2].HeaderText = "Địa chỉ";
            dgvKhachhang.Columns[3].HeaderText = "Số điện thoại";
            dgvKhachhang.Columns[4].HeaderText = "Email";
        }

        private void Clear()
        {
            txtMaKH.Clear();
            txtTen.Clear();
            txtDiachi.Clear();
            txtSDT.Clear();
            txtEmail.Clear();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string query = "insert into Customer (CustomerID, Name, Address, Phone, Email) values('" + txtMaKH.Text + "', N'" + txtTen.Text + "', N'" + txtDiachi.Text + "', '" + txtSDT.Text + "','" + txtEmail.Text + "')";
            db.update(query);
            display();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string query = "update Customer Set CustomerID = '" + txtMaKH.Text + "', Name = N'" + txtTen.Text + "', Address = N'" + txtDiachi.Text + "', Phone = '" + txtSDT.Text + "', Email = '" + txtEmail.Text + "' where CustomerID = '" + txtMaKH.Text + "'";
            db.update(query);
            display();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string query = "delete from Customer where CustomerID = '" + txtMaKH.Text + "'";
            db.update(query);
            display();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dgvKhachhang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnThem.Enabled = false;
            txtMaKH.Text = dgvKhachhang.CurrentRow.Cells[0].Value.ToString();
            txtTen.Text = dgvKhachhang.CurrentRow.Cells[1].Value.ToString();
            txtDiachi.Text = dgvKhachhang.CurrentRow.Cells[2].Value.ToString();
            txtSDT.Text = dgvKhachhang.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = dgvKhachhang.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
