using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tiba_Sport_Stock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            aid_items aid_Items = new aid_items();
            aid_Items.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Items items = new Items();
            items.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Stock_balance stock = new Stock_balance();
            stock.Show();
        }
    }
}
