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
    public partial class StockMain : Form
    {
        public StockMain()
        {
            InitializeComponent();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Products pro = new Products();
            pro.MdiParent = this;
            pro.Show();
        }

        private void StockMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you really want to exit the Programe?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stock pro = new Stock();
            pro.MdiParent = this;
            pro.Show();
        }

        private void supplairsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Supplairs pro = new Supplairs();
            pro.MdiParent = this;
            pro.Show();
        }

        private void warehouseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Warehouse pro = new Warehouse();
            pro.MdiParent = this;
            pro.Show();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUsers pro = new AddUsers();
            pro.MdiParent = this;
            pro.Show();
        }

        private void searchItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchItems pro = new SearchItems();
            pro.MdiParent = this;
            pro.Show();
        }

        private void productListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product_Report pro = new Product_Report();
            pro.MdiParent = this;
            pro.Show();
        }

        private void stockListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stock_Report pro = new Stock_Report();
            pro.MdiParent = this;
            pro.Show();
        }

        private void supplairsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Supplier_Report pro = new Supplier_Report();
            pro.MdiParent = this;
            pro.Show();
        }

        private void warehouseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Warehouse_Report pro = new Warehouse_Report();
            pro.MdiParent = this;
            pro.Show();
        }

        private void usersToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            User_Report pro = new User_Report();
            pro.MdiParent = this;
            pro.Show();
        }        
    }
}
