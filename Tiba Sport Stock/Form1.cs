using System;
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

        private void button2_Click(object sender, EventArgs e)
        {
            Exchange_Permission exchange_Permission = new Exchange_Permission();
            exchange_Permission.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Add_Permission add_Permission = new Add_Permission();
            add_Permission.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
        Clients clients = new Clients();
            clients.Show();
        
    }
    }
}
