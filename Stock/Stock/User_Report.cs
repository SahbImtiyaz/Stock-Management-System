using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock
{
    public partial class User_Report : Form
    {
        public User_Report()
        {
            InitializeComponent();
        }

        private void User_Report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'StockDataSet7.Login' table. You can move, or remove it, as needed.
            this.LoginTableAdapter.Fill(this.StockDataSet7.Login);

            this.reportViewer1.RefreshReport();
        }
    }
}
