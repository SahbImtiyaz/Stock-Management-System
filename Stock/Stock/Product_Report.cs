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
    public partial class Product_Report : Form
    {
        public Product_Report()
        {
            InitializeComponent();
        }

        private void Product_Report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'StockDataSet2.Products' table. You can move, or remove it, as needed.
            this.ProductsTableAdapter.Fill(this.StockDataSet2.Products);

            this.reportViewer1.RefreshReport();
        }
    }
}
