using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Stock
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Stock;Integrated Security=True");
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter(@"select * from [Stock].[dbo].[Login] where UserName= '" + textBox1.Text+"' and Password ='"+textBox2.Text+"'",conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                this.Hide();
                StockMain obj = new StockMain();
                obj.Show();
            }
            else 
            {
                MessageBox.Show("Invalid Username Or Password........", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                button1_Click(sender, e);
            }
            conn.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = "TIME is: " + " " + DateTime.Now.Hour.ToString() + "  : " + DateTime.Now.Minute.ToString() + " : " + DateTime.Now.Second.ToString();
            label4.Text = "Today is: " + DateTime.Now.DayOfWeek.ToString() + "   " + DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year.ToString();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Password obj = new Password();
            obj.Show();
        }
    }
}
