using MySql.Data.MySqlClient;
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
    public partial class Setting : Form
    {

        private MySqlConnection connection;
        public Setting()
        {
            InitializeComponent();
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            tbServer.Text = Properties.Settings.Default.server;
            tbDatabase.Text = Properties.Settings.Default.database;
            tbUser.Text = Properties.Settings.Default.user;
            tbPass.Text = Properties.Settings.Default.pass;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.server = tbServer.Text;
            Properties.Settings.Default.database = tbDatabase.Text;
            Properties.Settings.Default.user = tbUser.Text;
            Properties.Settings.Default.pass = tbPass.Text;
            Properties.Settings.Default.Save();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            

            string ConnectionString =
               "SERVER=" + tbServer.Text + ";" +
               "DATABASE=" + tbDatabase.Text + ";" +
               "UID=" + tbUser.Text + ";" +
               "PASSWORD=" + tbPass.Text + ";";

            connection = new MySqlConnection(ConnectionString);

            try
            {
                connection.Open();
                MessageBox.Show("تم الاتصال بالنجاح");
                connection.Close();
            }
            catch (MySqlException ex)
            {

                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;

                    default:
                        MessageBox.Show(ex.Message);
                        break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
