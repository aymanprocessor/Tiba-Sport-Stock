using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using System.Threading;
using System.Data;

namespace Tiba_Sport_Stock
{
    public partial class Add_Permission : Form
    {

        private MySqlConnection connection;
        MySqlDataAdapter adapter;
        MySqlCommandBuilder CommandBuilder;
        DataTable dt;
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
            //string query = "select * from trans_detail;";

            utils.set_autoincrement("trans_no", "trans_header");
            lblTransNo.Text = utils.loadFromDatabase("max(trans_no)", "trans_header");

            string query = "select item_id as م , quantity as الكمية ,price as 'السعر',item_total as 'الاجمالي',store as 'الرف' from trans_detail;";
            adapter = new MySqlDataAdapter(query,connection);
            dt = new DataTable();
            adapter.Fill(dt);
            dgView.DataSource = dt;

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataColumn dc_trans_no = new DataColumn("trans_no", typeof(int));
            DataColumn dc_trans_date = new DataColumn("trans_date");
            dt.Columns.Add(dc_trans_no);
            dt.Columns.Add(dc_trans_date);
            foreach(DataRow dr in dt.Rows)
            {
                //dr["trans_no"] = lblTransNo.Text;
                dr["trans_date"] = date.Value;
            }
            CommandBuilder = new MySqlCommandBuilder(adapter);
            adapter.Update(dt);

            /*try
            {
                string id = "";
                string query = string.Format(@"select id from client where name = ""{0}"";",cbName.SelectedItem);
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    id = reader["id"].ToString();
                }
                connection.Close();


                string query1 = "INSERT INTO trans_header (`trans_date`,`client_id`,`trans_type`,`total`)VALUES(?,?,?,?);";
                connection.Open();

                MySqlCommand cmd1 = new MySqlCommand(query1, connection);
                cmd1.Parameters.AddWithValue("param1", date.Text);
                cmd1.Parameters.AddWithValue("param2", id);
                cmd1.Parameters.AddWithValue("param3", cbType.SelectedItem);
                cmd1.Parameters.AddWithValue("param4", lblTotalCost.Text);
                   

                cmd1.ExecuteNonQuery();
                connection.Close();


                string store = "";
                string query3 = string.Format(@"select store from item_master where code = ""{0}"";", cbCode.SelectedItem);
                connection.Open();
                MySqlCommand cmd3 = new MySqlCommand(query3, connection);
                MySqlDataReader reader3 = cmd3.ExecuteReader();

                while (reader3.Read())
                {
                    store = reader3["id"].ToString();
                }
                connection.Close();



                string query2 = "INSERT INTO trans_detail (`trans_date`,`trans_type`,`item_id`,`quantity`,`price`,`item_total`,`store`)VALUES(?,?,?,?,?,?,?);";
                connection.Open();

                MySqlCommand cmd2 = new MySqlCommand(query2, connection);
                cmd2.Parameters.AddWithValue("param1", date.Text);
                cmd2.Parameters.AddWithValue("param2", cbType.SelectedItem);
                cmd2.Parameters.AddWithValue("param3", cbCode.SelectedItem);
                cmd2.Parameters.AddWithValue("param4", tbQuantity.Text);
                cmd2.Parameters.AddWithValue("param5", tbCost.Text);
                cmd2.Parameters.AddWithValue("param6", lblTotalCost.Text);
                cmd2.Parameters.AddWithValue("param7", store);


                cmd2.ExecuteNonQuery();
                connection.Close();

            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
                connection.Close();
            }*/
        }


        private void cbDesc_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (connection.State.ToString() == "Open")
                {
                    connection.Close();
                }

                connection.Open();

                string query = string.Format(@"select item_id from stock_balance where item_desc = ""{0}"";", cbDesc.SelectedItem);
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cbCode.Text = reader["item_id"].ToString();
                }


                connection.Close();


            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);


                connection.Close();

            }
        }

        private void cbCode_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {

                
               
                if (connection.State.ToString() == "Open")
                {
                    connection.Close();
                }

                connection.Open();

                string query = string.Format(@"select item_desc from stock_balance where item_id = ""{0}"";", cbCode.SelectedItem);
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read() )
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
