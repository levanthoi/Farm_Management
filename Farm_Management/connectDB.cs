using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farm_Management
{
    internal class connectDB
    {
        SqlConnection conn;
        public connectDB() {
            const string DATABASE = @"Data Source=DESKTOP-L5SLI0J\SQLEXPRESS;Initial Catalog=quanLyTrangTrai;Integrated Security=True";
            conn = new SqlConnection(DATABASE);
        }

        // select du lieu
        public DataTable GetData(string query)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;

            }catch (Exception ex) {
                MessageBox.Show(ex.Message);
                return null;
            }finally { conn.Close(); }
        }

        // update, delete
        public void excute(string query)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Thành công");
                }
                else MessageBox.Show("Thất bại");

            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }finally { conn.Close(); }
        }

    }
}
