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
    public partial class AddUsers : Form
    {
        public AddUsers()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Stock;Integrated Security=True");

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            var sqlQuery = "";
            if (IfExists(conn, textBox1.Text))
            {
                MessageBox.Show("User Already exists", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                button2_Click(sender, e);
            }
            else
            {
                if (textBox2.Text.Trim() == textBox3.Text.Trim())
                {
                    sqlQuery = @"INSERT INTO [Stock].[dbo].[Login]([UserName],[Password]) VALUES ('" + textBox1.Text.Trim() + "','" + textBox2.Text.Trim() + "')";
                    MessageBox.Show("User Registered Successfully", "Successful Entry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                    cmd.ExecuteNonQuery();
                    textBox1.Enabled = true;
                    button2_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Password Did not Match!!!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    button2_Click(sender, e);
                }
            }
            conn.Close();
        }
        private bool IfExists(SqlConnection conn, string user)
        {
            SqlDataAdapter sda = new SqlDataAdapter(@"select * from [Login] where [UserName] ='" + user + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }
    }
}
