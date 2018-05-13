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
    public partial class Warehouse_Report : Form
    {
        public Warehouse_Report()
        {
            InitializeComponent();
        }

        private void Warehouse_Report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'StockDataSet6.Warehouse' table. You can move, or remove it, as needed.
            this.WarehouseTableAdapter.Fill(this.StockDataSet6.Warehouse);

            this.reportViewer1.RefreshReport();
        }
    }
}
