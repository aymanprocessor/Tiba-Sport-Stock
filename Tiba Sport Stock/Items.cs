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

        private void cbMajor_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblDesc.Text = cbMajor.Text + " " + cbSub.Text + " " + cbSize.Text + " " + cbColor.Text;


        }

        private void cbSub_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblDesc.Text = cbMajor.Text + " " + cbSub.Text + " " + cbSize.Text + " " + cbColor.Text;
        }

        private void cbSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblDesc.Text = cbMajor.Text + " " + cbSub.Text + " " + cbSize.Text + " " + cbColor.Text;
        }

        private void cbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblDesc.Text = cbMajor.Text + " " + cbSub.Text + " " + cbSize.Text + " " + cbColor.Text;
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





            loadIntoCombo();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "INSERT INTO color ( major_gp,sub_gp,color,size,item_desc,store,unit,reorder,avg,location,code ) VALUES ( ?,?,?,?,?,?,?,?,?,?,? );";
                connection.Open();

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("param1", cbMajor.Text);
                cmd.Parameters.AddWithValue("param2", cbSub.Text);
                cmd.Parameters.AddWithValue("param3", cbColor.Text);
                cmd.Parameters.AddWithValue("param4", cbSize.Text);
                cmd.Parameters.AddWithValue("param5", lblDesc.Text);
                cmd.Parameters.AddWithValue("param6", cbStore.Text);
                cmd.Parameters.AddWithValue("param7", cbUnit.Text);
                cmd.Parameters.AddWithValue("param8", tbReorder.Text);
                cmd.Parameters.AddWithValue("param9", lblAvg.Text);
                cmd.Parameters.AddWithValue("param10",cbLocation.Text);

                cmd.Parameters.AddWithValue("param11",cbLocation.Text);



                cmd.ExecuteNonQuery();


                string query1 = "select id from major_gp where name = ?";
                MySqlCommand cmd1 = new MySqlCommand(query1, connection);
                cmd.Parameters.AddWithValue("param1", cbMajor.Text);

                cmd.ExecuteScalar();

                connection.Close();
              //  clear();
               // loadColor();
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }




        private void loadIntoCombo()
        {
            string query_major = "SELECT name FROM major_gp;";
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

                cbMajor.Items.Add(reader.GetString("name"));
            }
            reader.Dispose();


            reader = cmd2.ExecuteReader();
            List<string> mark = new List<string>();
            while (reader.Read())
            {

                mark.Add(reader.GetString("name"));

            }
            reader.Dispose();




            reader = cmd3.ExecuteReader();
            List<string> type = new List<string>();
            while (reader.Read())
            {
                type.Add(reader.GetString("name"));
            }
            reader.Dispose();


            for(int i = 0; i < mark.Count; i++)
            {
                for (int q = 0; q < type.Count; q++)
                {
                    cbSub.Items.Add(mark[i] + " " + type[q]);
                }
            }


            reader = cmd4.ExecuteReader();
            while (reader.Read())
            {
                cbSize.Items.Add(reader.GetString("name"));
            }
            reader.Dispose();



            reader = cmd5.ExecuteReader();
            while (reader.Read())
            {
                cbColor.Items.Add(reader.GetString("name"));
            }
            reader.Dispose();




            reader = cmd7.ExecuteReader();
            while (reader.Read())
            {
                cbStore.Items.Add(reader.GetString("name"));
            }
            reader.Dispose();


            reader = cmd8.ExecuteReader();
            while (reader.Read())
            {
                cbUnit.Items.Add(reader.GetString("name"));
            }
            reader.Dispose();



            reader = cmd9.ExecuteReader();
            while (reader.Read())
            {
                cbLocation.Items.Add(reader.GetString("name"));
            }
            reader.Dispose();


            connection.Close();
        }
    }

}
