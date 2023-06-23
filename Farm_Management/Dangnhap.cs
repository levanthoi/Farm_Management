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
    public partial class Dangnhap : Form
    {
        private string username;
        private string password;
        public Dangnhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.username = tb_username.Text;
            this.password = tb_password.Text;

            if(username == "admin" & password == "admin123")
            {
                this.Hide();
                Form1 newForm = new Form1();
                newForm.Show();
            } else
            {
                MessageBox.Show("Thông tin tài khoản mật khẩu không chính xác.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
