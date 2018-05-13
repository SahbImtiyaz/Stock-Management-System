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
    public partial class Supplairs : Form
    {
        public Supplairs()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Stock;Integrated Security=True");
        
        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            var sqlQuery = "";
            if (isEmpty())
            {
                MessageBox.Show("Please Enter all the fields", "ERROR?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
            }
            else
            {
                if (IfDataExists(conn, textBox2.Text))
                {
                    sqlQuery = @"UPDATE [Supplier] SET [Name] = '" + textBox1.Text.Trim() + "',[Phone] = " + textBox2.Text.Trim() + ",[Email] ='" + textBox3.Text.Trim() + "',[Address] ='" + textBox4.Text.Trim() + "'WHERE [Phone] = " + textBox2.Text.Trim();
                    MessageBox.Show("Data Updated Successfully", "Successful Entry", MessageBoxButtons.OK);
                    textBox1.Enabled = true;
                }

                else
                {
                    sqlQuery = @"INSERT INTO [Stock].[dbo].[Supplier]([Name],[Phone],[Email],[Address]) VALUES ('" + textBox1.Text.Trim() + "'," + textBox2.Text.Trim() + ",'" + textBox3.Text.Trim() + "','" + textBox4.Text.Trim() + "')";
                    MessageBox.Show("Data inserted Successfully", "Successful Entry", MessageBoxButtons.OK);
                }

                SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                cmd.ExecuteNonQuery();
                button3_Click(sender, e);
                conn.Close();
                LoadData();
            }
        }
        private bool IfDataExists(SqlConnection conn, String phoneno)
        {
            SqlDataAdapter sda = new SqlDataAdapter(@"select * from [Supplier] where [Phone] = " + phoneno, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }

        public void LoadData()
        {
            SqlDataAdapter sda = new SqlDataAdapter(@"select * from [Stock].[dbo].[Supplier]", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item["Name"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["Phone"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item["Email"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item["Address"].ToString();
            }
        }
        private bool isEmpty()
        {
            if (textBox2.Text == "")
            {
                return true;
            }
            else
                return false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox1.Focus();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void Supplairs_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
