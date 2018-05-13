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
    public partial class Warehouse : Form
    {
        public Warehouse()
        {
            InitializeComponent();
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
                if (IfDataExists(conn, textBox1.Text))
                {
                    sqlQuery = @"UPDATE [Warehouse] SET [WarehouseName] = '" + textBox1.Text.Trim() + "',[Incharge] ='" + textBox2.Text.Trim() + "',[Phone] = '" + textBox3.Text.Trim() + "',[Email] ='" + textBox4.Text.Trim() + "',[Address] ='" + textBox5.Text.Trim() + "'WHERE [WarehouseName] = '" + textBox1.Text.Trim() + "'";
                    MessageBox.Show("Data Updated Successfully", "Successful Entry", MessageBoxButtons.OK);
                    textBox1.Enabled = true;
                }

                else
                {
                    sqlQuery = @"INSERT INTO [Stock].[dbo].[Warehouse]([WarehouseName],[Incharge],[Phone],[Address],[Email]) VALUES ('" + textBox1.Text.Trim() + "','" + textBox2.Text.Trim() + "','" + textBox3.Text.Trim() + "','" + textBox5.Text.Trim() + "','" + textBox4.Text.Trim() + "')";
                    MessageBox.Show("Data inserted Successfully", "Successful Entry", MessageBoxButtons.OK);
                }

                SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                cmd.ExecuteNonQuery();
                button3_Click(sender, e);
                conn.Close();
                LoadData();
            }
        }
        private bool IfDataExists(SqlConnection conn, String warehousename)
        {
            SqlDataAdapter sda = new SqlDataAdapter(@"select * from [Warehouse] where [WarehouseName] = '" + warehousename +"'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }

        public void LoadData()
        {
            SqlDataAdapter sda = new SqlDataAdapter(@"select * from [Stock].[dbo].[Warehouse]", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item["WarehouseName"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["Incharge"].ToString();                
                dataGridView1.Rows[n].Cells[2].Value = item["Phone"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item["Email"].ToString();
                dataGridView1.Rows[n].Cells[4].Value = item["Address"].ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox1.Enabled = true;
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to Delete the Data?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                if (isEmpty())
                {
                    MessageBox.Show("Nothing to detete please check again?????", "ERROR?", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Focus();
                }
                else
                {
                    conn.Open();
                    var sqlQuery = "";
                    sqlQuery = @"DELETE FROM [Stock].[dbo].[Warehouse] WHERE [WarehouseName] = '" + textBox1.Text.Trim() + "'";
                    MessageBox.Show("Data Deleted Successfully", "Successful Entry", MessageBoxButtons.OK);
                    SqlCommand cmd = new SqlCommand(sqlQuery, conn);
                    cmd.ExecuteNonQuery();
                    textBox1.Enabled = true;
                    button3_Click(sender, e);
                    conn.Close();
                    LoadData();
                }
            }
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

        private void Warehouse_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
        private void dataGridView1_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {

        }
        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBox1.Enabled = false;
        }
    }
}
