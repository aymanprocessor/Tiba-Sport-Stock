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
    public partial class Clients : Form
    {
        private MySqlConnection connection;
        private string server, database, user, pass;
        Utils utils;
        public Clients()
        {
            InitializeComponent();
        }

        
        private void Supplier_Load(object sender, EventArgs e)
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
            loadCustomers();
          
            utils = new Utils();
        }


        private void customer_btnAdd_Click(object sender, EventArgs e)
        {

            try
            {
                string query = "INSERT INTO client ( name,address,phone,email,type ) VALUES ( ?,?,?,?,? );";
                connection.Open();

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("param1", customer_tbName.Text);
                cmd.Parameters.AddWithValue("param2", customer_tbAddress.Text);
                cmd.Parameters.AddWithValue("param3", customer_tbMobile.Text);
                cmd.Parameters.AddWithValue("param4", customer_tbEmail.Text);
                cmd.Parameters.AddWithValue("param5", customer_cbType.Text);
            
                cmd.ExecuteNonQuery();
                connection.Close();
                utils.set_autoincrement("id", "client");
                clear();
                loadCustomers();
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }

        private void customer_btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                DialogResult d = MessageBox.Show("هل تريد المسح", "تأكيد المسح", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (d == DialogResult.Yes)
                {
                    var selectedRows = customer_dgView.SelectedRows
                .OfType<DataGridViewRow>()
                .Where(r => !r.IsNewRow)
                .ToArray();
                    foreach (var i in selectedRows)
                    {
                        string query = string.Format("DELETE FROM {0} WHERE id = {1}", "client", i.Cells[0].Value);
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        cmd.ExecuteNonQuery();
                    }
                }
                connection.Close();
                utils.set_autoincrement("id", "client");
                loadCustomers();
                clear();
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }

        private void customer_btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedRows = customer_dgView.SelectedRows
            .OfType<DataGridViewRow>()
            .Where(r => !r.IsNewRow)
            .ToArray();


                string query = "UPDATE client SET `name` = ?, `address` = ?, `phone` = ?, `email` = ?, type = ? WHERE id = ?;";
                connection.Open();

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("param1", customer_tbName.Text);
                cmd.Parameters.AddWithValue("param2", customer_tbAddress.Text);
                cmd.Parameters.AddWithValue("param3", customer_tbMobile.Text);
                cmd.Parameters.AddWithValue("param4", customer_tbEmail.Text);
                cmd.Parameters.AddWithValue("param5", customer_cbType.Text);
                cmd.Parameters.AddWithValue("param6", selectedRows[0].Cells[0].Value.ToString());
                



                cmd.ExecuteNonQuery();
                connection.Close();
                loadCustomers();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }

        private void customer_dgView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
            customer_tbName.Text = customer_dgView.Rows[e.RowIndex].Cells[1].Value.ToString();
            customer_tbAddress.Text = customer_dgView.Rows[e.RowIndex].Cells[2].Value.ToString();
            customer_tbMobile.Text = customer_dgView.Rows[e.RowIndex].Cells[3].Value.ToString();
            customer_tbEmail.Text = customer_dgView.Rows[e.RowIndex].Cells[4].Value.ToString();
            customer_cbType.Text = customer_dgView.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
            
        }

      

        private void clear()
        {
            customer_tbName.Text = "";
            customer_tbAddress.Text = "";
            customer_tbMobile.Text = "";
            customer_tbEmail.Text = "";
            customer_cbType.Text = "";

     
        }

        private void loadCustomers()
        {
            try
            {
                connection.Open();
                string query = "select id as م , name as الاسم ,address as 'العنوان',phone as 'الموبايل',email as 'الايميل',type as النوع from client;";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "client");
                customer_dgView.DataSource = ds.Tables["client"];
                connection.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }

       
    }
}
