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
    public partial class Items : Form
    {
        private MySqlConnection connection;
        private string server, database, user, pass;
        public Items()
        {
            InitializeComponent();
        }

        private void Items_Load(object sender, EventArgs e)
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

        private void loadIntoCombo()
        {
            string query_major = "SELECT name FROM major;";
            string query_mark = "SELECT name FROM mark;";
            string query_type = "SELECT name FROM type;";
            string query_size = "SELECT name FROM size;";
            string query_color = "SELECT name FROM color;";
            string query_trans = "SELECT name FROM trans;";
            string query_store = "SELECT name FROM store;";
            string query_unit = "SELECT name FROM unit;";
            string query_location = "SELECT `Emp_name` FROM location;";

            connection.Open();
            MySqlCommand cmd1 = new MySqlCommand(query_major, connection);
            MySqlCommand cmd2 = new MySqlCommand(query_mark, connection);
            MySqlCommand cmd3 = new MySqlCommand(query_type, connection);
            MySqlCommand cmd4 = new MySqlCommand(query_size, connection);
            MySqlCommand cmd5 = new MySqlCommand(query_color, connection);
            MySqlCommand cmd6 = new MySqlCommand(query_trans, connection);
            MySqlCommand cmd7 = new MySqlCommand(query_store, connection);
            MySqlCommand cmd8 = new MySqlCommand(query_unit, connection);
            MySqlCommand cmd9 = new MySqlCommand(query_location, connection);



            MySqlDataReader reader = cmd1.ExecuteReader();
            while (reader.Read())
            {

                cbName.Items.Add(reader.GetString("Emp_name"));
            }


            reader.Dispose();
            reader = cmd2.ExecuteReader();
            while (reader.Read())
            {
                cbDoctor.Items.Add(reader.GetString("username"));
            }



            connection.Close();
        }
    }

}
