using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Tiba_Sport_Stock
{
    public partial class Add_Permission : Form
    {

        private MySqlConnection connection;
        private string server, database, user, pass;
        Utils utils;


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
            utils = new Utils();
            utils.loadIntoCombo("name", "client", cbName, "type", "المشتري");
            utils.loadIntoCombo("name", "trans_type", cbType, "type", "in");
            utils.loadIntoCombo("item_id", "stock_balance", cbCode);
            utils.loadIntoCombo("item_desc", "stock_balance", cbDesc);


        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void cbDesc_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*try
            {
                if (connection.State.ToString() == "Closed")
                {

                    connection.Open();
                }

                string query = string.Format(@"select item_id from stock_balance where item_desc = ""{0}"";", cbDesc.Text);
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cbCode.Text = reader["item_id"].ToString();
                }
                if (connection.State.ToString() == "Open")
                {

                    connection.Close();
                }

            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
                if (connection.State.ToString() == "Open")
                {

                    connection.Close();
                }
            }*/
        }

        private void cbCode_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {

                connection.Open();
                string query = string.Format(@"select item_desc from stock_balance where item_id = ""{0}"";", cbCode.Text);
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cbDesc.Text = reader["item_desc"].ToString();
                }
                connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void loadData()
        {
            //try
            //{
            //    connection.Open();
            //    string query = "select id as م , name as الاسم ,address as 'العنوان',phone as 'الموبايل',email as 'الايميل',type as النوع from client;";
            //    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
            //    DataSet ds = new DataSet();
            //    adapter.Fill(ds, "client");
            //    customer_dgView.DataSource = ds.Tables["client"];
            //    connection.Close();
            //}
            //catch (MySqlException ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    connection.Close();
            //}
        }

    }
}
