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
    public partial class Add_Permission : Form
    {

        private MySqlConnection connection;
        private string server, database, user, pass;

       
        public Add_Permission()
        {
            InitializeComponent();
        }

        

        private void Add_Permission_Load(object sender, EventArgs e)
        {
            server = Properties.Settings.Default.server;
            database = Properties.Settings.Default.database;
            user = Properties.Settings.Default.user;
            pass = Properties.Settings.Default.pass;


            string ConnectionString =
               "SERVER=" + server + ";" +
               "DATABASE=" + database + ";" +
               "UID=" + user + ";" +
               "PASSWORD=" + pass + ";";

            connection = new MySqlConnection(ConnectionString);

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

        }


        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

    }
}
