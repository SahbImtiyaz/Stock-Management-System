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
    public partial class Stock : Form
    {
        public Stock()
        {
            InitializeComponent();
        }

        private void Stock_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Stock;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter(@"select * from [Stock].[dbo].[Stock]", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item["ProductCode"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["ProductName"].ToString();                
                dataGridView1.Rows[n].Cells[2].Value = item["Quantity"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item["TransDate"].ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Stock;Integrated Security=True");
            conn.Open();
            
            var sqlQuery = "";
            if (IfProductExists(conn, textBox1.Text))
            {
                sqlQuery = @"UPDATE [Stock]SET[ProductName] = '" + textBox2.Text.Trim() + "',[Quantity] = '" + Convert.ToDouble(textBox3.Text.Trim()) +"', [TransDate] = "+ dateTimePicker1.Text + "' WHERE [ProductCode] = " + Convert.ToInt32(textBox1.Text.Trim());
                MessageBox.Show("Data Updated Successfully", "Successful Entry", MessageBoxButtons.OK);
                textBox1.Enabled = true;
            }

            else
            {
                sqlQuery = @"INSERT INTO [Stock].[dbo].[Stock]([ProductCode],[ProductName],[Quantity],[TransDate]) VALUES
                        (" + Convert.ToInt32(textBox1.Text.Trim()) + ",'" + textBox2.Text.Trim() + "','" + Convert.ToDouble(textBox3.Text.Trim()) + "','" + dateTimePicker1.Text + "')";
                MessageBox.Show("Data inserted Successfully", "Successful Entry", MessageBoxButtons.OK);
            }

            SqlCommand cmd = new SqlCommand(sqlQuery, conn);
            cmd.ExecuteNonQuery();
            button3_Click(sender, e);
            conn.Close();
            LoadData();
        }
        private bool IfProductExists(SqlConnection conn, string productcode)
        {
            SqlDataAdapter sda = new SqlDataAdapter(@"select * from [Stock] where [ProductCode] =" + Convert.ToInt32(productcode), conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to exit the Programe?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                if (isEmpty())
                {
                    MessageBox.Show("Nothing to detete please check again???", "ERROR?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Focus();
                }
                else
                {
                    SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Stock;Integrated Security=True");
                    conn.Open();

                    var sqlQuery = "";
                    sqlQuery = @"DELETE FROM [Stock].[dbo].[Stock] WHERE ProductCode=" + textBox1.Text;
                    MessageBox.Show("Data Deleted Successfully", "Successful Entry", MessageBoxButtons.OK);
                    SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                    cmd.ExecuteNonQuery();
                    button3_Click(sender, e);
                    textBox1.Enabled = true;
                    conn.Close();
                    LoadData();
                }
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            dateTimePicker1.Text = DateTime.Now.ToString();
            textBox1.Focus();
            textBox1.Enabled = true;
        }
        private bool isEmpty()
        {
            if (textBox1.Text == "")
            {
                return true;
            }
            else
                return false;

        }

    }
}
