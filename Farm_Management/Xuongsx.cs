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
    public partial class Xuongsx : Form
    {
        public Xuongsx()
        {
            InitializeComponent();
        }

        private void Xuongsx_Load(object sender, EventArgs e)
        {
            display();
        }
        connectDB db = new connectDB();

        private void display()
        {
            string query = "select * from Supplier";
            dgvXSX.DataSource = db.getData(query);
            dgvXSX.Columns[0].HeaderText = "Mã nhà cung cấp";
            dgvXSX.Columns[1].HeaderText = "Tên nhà cung cấp";
            dgvXSX.Columns[2].HeaderText = "Địa chỉ";
            dgvXSX.Columns[3].HeaderText = "Số điện thoại";
            dgvXSX.Columns[4].HeaderText = "Email";
        }

        private void Clear()
        {
            txtMaXSX.Clear();
            txtTen.Clear();
            txtDiachi.Clear();
            txtSDT.Clear();
            txtEmail.Clear();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string query = "insert into Supplier (SupplierID, Name, Address, Phone, Email) values('" + txtMaXSX.Text + "', N'" + txtTen.Text + "', N'" + txtDiachi.Text + "', '" + txtSDT.Text + "','" + txtEmail.Text + "')";
            db.update(query);
            display();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string query = "update Supplier Set SupplierID = '"+ txtMaXSX.Text +"', Name = N'" + txtTen.Text + "', Address = N'" + txtDiachi.Text + "', Phone = '"+ txtSDT.Text + "', Email = '"+ txtEmail.Text + "' where SupplierID = '" + txtMaXSX.Text + "'";
            db.update(query);
            display();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string query = "delete from Supplier where SupplierID = '" + txtMaXSX.Text + "'";
            db.update(query);
            display();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dgvNhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvXSX_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaXSX.Text = dgvXSX.CurrentRow.Cells[0].Value.ToString();
            txtTen.Text = dgvXSX.CurrentRow.Cells[1].Value.ToString();
            txtDiachi.Text = dgvXSX.CurrentRow.Cells[2].Value.ToString();
            txtSDT.Text = dgvXSX.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = dgvXSX.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
