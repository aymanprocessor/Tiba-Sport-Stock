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
    public partial class Stock_balance : Form
    {
        Utils utils;
        private MySqlConnection connection;
        private string server, database, user, pass;


        public Stock_balance()
        {
            InitializeComponent();
        }

        private void Stock_balance_Load(object sender, EventArgs e)
        {
            utils = new Utils();
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
           
            clear();
            loadBalance();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //string query = "INSERT INTO stock_balance (`item_id`,`year`,`item_desc`,`store`,`count`,`avg_cost`)VALUES(?,?,?,?,?,?);";
                string query = "INSERT INTO stock_balance (`item_id`,`year`,`item_desc`,`store`,`count`,`avg_cost`)VALUES(?,?,?,?,?);";
                connection.Open();

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("param1", cbCode.Text);
                cmd.Parameters.AddWithValue("param2", cbYear.Text);
                cmd.Parameters.AddWithValue("param3", cbDesc.Text);
                cmd.Parameters.AddWithValue("param4", cbStore.Text);
                cmd.Parameters.AddWithValue("param5", tbCount.Text);
                //cmd.Parameters.AddWithValue("param6", tbAvgCost.Text);

                cmd.ExecuteNonQuery();
                connection.Close();
                clear();
                loadBalance();
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                DialogResult d = MessageBox.Show("هل تريد المسح", "تأكيد المسح", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (d == DialogResult.Yes)
                {
                    var selectedRows = dgView.SelectedRows
                .OfType<DataGridViewRow>()
                .Where(r => !r.IsNewRow)
                .ToArray();
                    foreach (var i in selectedRows)
                    {
                        string query = string.Format("DELETE FROM {0} WHERE item_id = {1}", "stock_balance", i.Cells[0].Value);
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        cmd.ExecuteNonQuery();
                    }
                }
               
                connection.Close();
                loadBalance();
                clear();
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedRows = dgView.SelectedRows
            .OfType<DataGridViewRow>()
            .Where(r => !r.IsNewRow)
            .ToArray();


                //string query = "UPDATE stock_balance SET `item_id` = ?,`year` = ?,`item_desc` = ?,`store` = ?,`count` = ?,`avg_cost` = ? WHERE `item_id` = ? AND `year` = ?;";
                string query = "UPDATE stock_balance SET `item_id` = ?,`year` = ?,`item_desc` = ?,`store` = ?,`count` = ? WHERE `item_id` = ? AND `year` = ?;";
                connection.Open();

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("param1", cbCode.Text);
                cmd.Parameters.AddWithValue("param2", cbYear.Text);
                cmd.Parameters.AddWithValue("param3", cbDesc.Text);
                cmd.Parameters.AddWithValue("param4", cbStore.Text);
                cmd.Parameters.AddWithValue("param5", tbCount.Text);
               // cmd.Parameters.AddWithValue("param6", tbAvgCost.Text);
                cmd.Parameters.AddWithValue("param7",selectedRows[0].Cells[0].Value.ToString());
                cmd.Parameters.AddWithValue("param8", selectedRows[0].Cells[5].Value.ToString());
                cmd.ExecuteNonQuery();
                connection.Close();
                loadBalance();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }

        private void dgView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
            
            cbCode.Text = dgView.Rows[e.RowIndex].Cells[0].Value.ToString();
            cbDesc.Text = dgView.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbCount.Text = dgView.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbAvgCost.Text = dgView.Rows[e.RowIndex].Cells[3].Value.ToString();
            cbStore.Text = dgView.Rows[e.RowIndex].Cells[4].Value.ToString();
            cbYear.Text = dgView.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
        }

        private void cbCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            utils.loadIntoCombo("item_desc", "item_master", cbDesc, "code", cbCode.Text);
            utils.loadIntoCombo("store", "item_master", cbStore, "code", cbCode.Text);
        }

        private void loadBalance()
        {
            try
            {
                connection.Open();
                string query = "select item_id as الكود ,item_desc as 'وصف الصنف',count as 'العدد',avg_cost as 'متوسط السعر',store as المخزن , year as السنة from stock_balance;";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "stock_balance");
                dgView.DataSource = ds.Tables["stock_balance"];
                connection.Close();
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }

        private void clear()
        {
            cbCode.Text = "";
            cbYear.Text = DateTime.Now.Year.ToString();
            cbDesc.Text = "";
            cbStore.Text = "";
            tbCount.Text = "";
            tbAvgCost.Text = "";
        }
    }
}
