using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock
{
    public partial class Password : Form
    {
        public Password()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Stock;Integrated Security=True");
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter(@"select * from [Stock].[dbo].[Login] where UserName= '" + textBox1.Text + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            var sqlQuery="";
            if (dt.Rows.Count == 1)
            {
                if (textBox2.Text.Trim() == textBox3.Text.Trim())
                {
                    sqlQuery = @"UPDATE [Login]SET[Password] = '" + textBox2.Text.Trim() + "'";
                    MessageBox.Show("Password Changed successfully", "Password Changed", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                    cmd.ExecuteNonQuery();
                    this.Close();
                    Login obj = new Login();
                    obj.Show();
                }
                else 
                {
                    MessageBox.Show("Password Does not Match", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    button2_Click(sender,e);
                }
            }
            else
            {
                MessageBox.Show("Invalid Username Please Provide Correct Details........", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                button2_Click(sender, e);
            }
            conn.Close();
        }

        private void Password_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login obj = new Login();
            obj.Enabled = true;
            obj.Show();
        }
    }
}
