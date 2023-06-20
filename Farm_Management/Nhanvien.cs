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
    public partial class Nhanvien : Form
    {
        public Nhanvien()
        {
            InitializeComponent();
            display();
        }

        connectDB db = new connectDB();

        private void display()
        {
            string query = "select EmployeeID, Name, Email, Phone, Role, Position, Status from Account";
            dgvNhanvien.DataSource = db.getData(query);
            dgvNhanvien.Columns[0].HeaderText = "Mã nhân viên";
            dgvNhanvien.Columns[1].HeaderText = "Họ và tên";
            dgvNhanvien.Columns[2].HeaderText = "Email";
            dgvNhanvien.Columns[3].HeaderText = "Số điện thoại";
            dgvNhanvien.Columns[4].HeaderText = "Chức vụ";
            dgvNhanvien.Columns[5].HeaderText = "Vị trí";
            dgvNhanvien.Columns[6].HeaderText = "Tình trạng";
        }

        private void Clear()
        {
            txtMaNV.Clear();
            txtTen.Clear();
            txtEmail.Clear();
            txtSDT.Clear();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int tinhtrang;
            if (radio1.Checked)
            {
                tinhtrang = 1;
            }
            else tinhtrang = 0;
                string query = "insert into Account (EmployeeID, Name, Email, Phone, Role, Position, Status) values('" + txtMaNV.Text + "', '" + txtTen.Text + "', '" + txtEmail.Text + "', '" + txtSDT.Text + "', N'" + cbChucvu.SelectedItem.ToString() + "',  N'" + cbVitri.SelectedItem.ToString() + "', '" + tinhtrang + "')";
                db.update(query);
                display();
        
        }

        private void cbTaoTk_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTaoTk.Checked)
            {
            }
            else
            {
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string query = "update Account Set Name = N'"+txtTen.Text+"', Role = N'"+cbChucvu.SelectedItem.ToString()+"', Position = N'"+cbVitri.SelectedItem.ToString()+"' where EmployeeID = '" + txtMaNV.Text + "'";
            db.update(query);
            display();
        }

        private void dgvNhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaNV.Text = dgvNhanvien.CurrentRow.Cells[0].Value.ToString();
            txtTen.Text = dgvNhanvien.CurrentRow.Cells[1].Value.ToString();
            txtEmail.Text = dgvNhanvien.CurrentRow.Cells[2].Value.ToString();
            txtSDT.Text = dgvNhanvien.CurrentRow.Cells[3].Value.ToString();
            cbChucvu.Text = dgvNhanvien.CurrentRow.Cells[4].Value.ToString();
            cbVitri.Text = dgvNhanvien.CurrentRow.Cells[5].Value.ToString();

            //MessageBox.Show("a" + dgvNhanvien.CurrentRow.Cells[6].Value.ToString() + "");

            string tinhtrang = dgvNhanvien.CurrentRow.Cells[6].Value.ToString();

            if (tinhtrang == "True")
            {
                radio1.Checked = true;
            }else if (tinhtrang == "False")
            {
                radio0.Checked = true; 
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string query = " delete from Account where EmployeeID = '"+txtMaNV.Text+"'";
            db.update(query);
            display();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void cbChucvu_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbChucvu.Text == "Nhân viên")
            {
                cbVitri.Enabled = true;
            }
            else
            {
                cbVitri.Enabled = false;
            }
        }
    }
}
