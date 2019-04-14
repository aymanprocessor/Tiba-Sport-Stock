using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tiba_Sport_Stock
{
    class Utils
    {
        private MySqlConnection connection;
        private string server, database, user, pass;
        public void DB_Connection_Init()
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

        public void loadIntoCombo(string col,string table,ComboBox cb)
        {
            try
            {
                DB_Connection_Init();
                connection.Open();
                string query = string.Format("SELECT {0} FROM {1};",col,table);
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    cb.Items.Add(reader.GetString(col));
                }
                reader.Dispose();
                connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
           
        }

        public void loadIntoCombo(string col, string table, ComboBox cb,string where_clause,string value)
        {
            connection.Open();
            string query = string.Format("SELECT * FROM {0} where {1} = {2};", table,where_clause,value);
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cb.Text = reader.GetString(col);
            }
            connection.Close();
        }

        public void set_autoincrement(string id, string table)
        {

            string max_query = string.Format("select max({0}) from {1} ;", id, table);
            MySqlCommand cmd2 = new MySqlCommand(max_query, connection);

            var max = cmd2.ExecuteScalar();

            if (max.ToString() == "")
            {
                string set_autoincrement = string.Format("ALTER TABLE {0} AUTO_INCREMENT = 1; ", table);
                MySqlCommand cmd1 = new MySqlCommand(set_autoincrement, connection);

                cmd1.ExecuteNonQuery();
            }
            else
            {
                var max_string = (int)(max) + 1;
                string set_autoincrement = string.Format("ALTER TABLE {0} AUTO_INCREMENT = {1};", table, max_string);
                MySqlCommand cmd1 = new MySqlCommand(set_autoincrement, connection);

                cmd1.ExecuteNonQuery();
            }
        }


    }
}
