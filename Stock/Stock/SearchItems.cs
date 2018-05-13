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
    public partial class SearchItems : Form
    {
        public SearchItems()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Stock;Integrated Security=True");
        
        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("Please enter Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
            }
            else
            {
                SqlCommand cmd = new SqlCommand(@"select * from [Warehouse] where [WarehouseName] = '" + textBox1.Text.Trim() + "'", conn);
                SqlDataReader rd = cmd.ExecuteReader();
                rd.Read();
                if (rd.HasRows)
                {
                    textBox15.Visible = true;
                    textBox16.Visible = true;
                    textBox17.Visible = true;
                    textBox18.Visible = true;
                    textBox19.Visible = true;
                    label18.Visible = true;
                    label19.Visible = true;
                    label20.Visible = true;
                    label21.Visible = true;
                    label22.Visible = true;
                    textBox15.Text = rd.GetValue(0).ToString();
                    textBox16.Text = rd.GetValue(1).ToString();
                    textBox17.Text = rd.GetValue(2).ToString();
                    textBox18.Text = rd.GetValue(4).ToString();
                    textBox19.Text = rd.GetValue(3).ToString();
                }
                else
                {
                    MessageBox.Show("Warehouse Does not exist","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    textBox1.Clear();
                    textBox1.Focus();
                }
            }
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (textBox2.Text.Trim() == "")
            {
                MessageBox.Show("Please enter Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
            }
            else
            {
                SqlCommand cmd = new SqlCommand(@"select * from [Products] where [ProductCode] = " + Convert.ToInt32(textBox2.Text.Trim()) , conn);
                SqlDataReader rd = cmd.ExecuteReader();
                rd.Read();
                if (rd.HasRows)
                {
                    textBox14.Visible = true;
                    textBox13.Visible = true;
                    textBox12.Visible = true;
                    comboBox1.Visible = true;
                    dateTimePicker2.Visible = true;
                    label17.Visible = true;
                    label16.Visible = true;
                    label15.Visible = true;
                    label14.Visible = true;
                    label13.Visible = true;
                    textBox14.Text = rd.GetValue(0).ToString();
                    textBox13.Text = rd.GetValue(1).ToString();
                    comboBox1.Text = rd.GetValue(2).ToString();
                    textBox12.Text = rd.GetValue(3).ToString();
                    dateTimePicker2.Text = rd.GetValue(4).ToString();
                }
                else
                {
                    MessageBox.Show("Product Is Not Available", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox2.Clear();
                    textBox2.Focus();
                }
            }
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (textBox3.Text.Trim() == "")
            {
                MessageBox.Show("Please enter Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
            }
            else
            {
                SqlCommand cmd = new SqlCommand(@"select * from [Stock] where [ProductCode] = " + Convert.ToInt32(textBox3.Text.Trim()) , conn);
                SqlDataReader rd = cmd.ExecuteReader();
                rd.Read();
                if (rd.HasRows)
                {
                    textBox11.Visible = true;
                    textBox10.Visible = true;
                    textBox9.Visible = true;
                    dateTimePicker1.Visible = true;
                    label12.Visible = true;
                    label11.Visible = true;
                    label10.Visible = true;
                    label9.Visible = true;
                    textBox11.Text = rd.GetValue(0).ToString();
                    textBox10.Text = rd.GetValue(1).ToString();
                    textBox9.Text = rd.GetValue(3).ToString();
                    dateTimePicker1.Text = rd.GetValue(2).ToString();
                }
                else
                {
                    MessageBox.Show("Product Code Does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox3.Clear();
                    textBox3.Focus();
                }
            }
            conn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            conn.Open();
            if (textBox4.Text.Trim() == "")
            {
                MessageBox.Show("Please enter Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
            }
            else
            {
                
                SqlCommand cmd = new SqlCommand(@"select * from [Supplier] where [Phone] = " + Convert.ToInt64(textBox4.Text.Trim()), conn);
                SqlDataReader rd = cmd.ExecuteReader();
                rd.Read();
                if (rd.HasRows)
                {
                    textBox5.Visible = true;
                    textBox6.Visible = true;
                    textBox7.Visible = true;
                    textBox8.Visible = true;
                    label5.Visible = true;
                    label6.Visible = true;
                    label7.Visible = true;
                    label8.Visible = true;
                    textBox5.Text = rd.GetValue(0).ToString();
                    textBox6.Text = rd.GetValue(1).ToString();
                    textBox7.Text = rd.GetValue(2).ToString();
                    textBox8.Text = rd.GetValue(3).ToString();
                }
                else
                {
                    MessageBox.Show("Supplier Does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox11.Clear();
                    textBox11.Focus();
                }
            }
            conn.Close();
        }
    }
}
