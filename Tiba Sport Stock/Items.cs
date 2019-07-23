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
            connection.Open();
            lblCode.Text = getCode();
            connection.Close();
        }

        private void cbSub_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblDesc.Text = cbMajor.Text + " " + cbSub.Text + " " + cbSize.Text + " " + cbColor.Text;
            connection.Open();
            lblCode.Text = getCode();
            connection.Close();
        }

        private void cbSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblDesc.Text = cbMajor.Text + " " + cbSub.Text + " " + cbSize.Text + " " + cbColor.Text;
            connection.Open();
            lblCode.Text = getCode();
            connection.Close();
        }

        private void cbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblDesc.Text = cbMajor.Text + " " + cbSub.Text + " " + cbSize.Text + " " + cbColor.Text;
            connection.Open();
            lblCode.Text = getCode();
            connection.Close();
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



            clear();
            loadItems();
            loadIntoCombo();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string query = "INSERT INTO item_master ( major_gp,sub_gp,color,size,item_desc,store,unit,reorder,avg,location,code ) VALUES ( ?,?,?,?,?,?,?,?,?,?,? );";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("param1", cbMajor.Text);
                cmd.Parameters.AddWithValue("param2", cbSub.Text);
                cmd.Parameters.AddWithValue("param3", cbColor.Text);
                cmd.Parameters.AddWithValue("param4", cbSize.Text);
                cmd.Parameters.AddWithValue("param5", lblDesc.Text);
                cmd.Parameters.AddWithValue("param6", cbStore.Text);
                cmd.Parameters.AddWithValue("param7", cbUnit.Text);
                cmd.Parameters.AddWithValue("param8", tbReorder.Text);
                cmd.Parameters.AddWithValue("param9", 0);
                cmd.Parameters.AddWithValue("param10", cbLocation.Text);
                cmd.Parameters.AddWithValue("param11", getCode());
                cmd.ExecuteNonQuery();

                string query1 = "INSERT INTO stock_balance ( item_desc,store,item_id,year,count ) VALUES ( ?,?,?,?,? );";
                MySqlCommand cmd1 = new MySqlCommand(query1, connection);
                cmd1.Parameters.AddWithValue("param1", lblDesc.Text);
                cmd1.Parameters.AddWithValue("param2", cbStore.Text);
                cmd1.Parameters.AddWithValue("param3", getCode());
                cmd1.Parameters.AddWithValue("param4", DateTime.Now.Year.ToString());
                cmd1.Parameters.AddWithValue("param5", 0);
                cmd1.ExecuteNonQuery();
                connection.Close();
                clear();
                loadItems();
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
                        string query = string.Format("DELETE FROM {0} WHERE id = {1}", "item_master", i.Cells[0].Value);
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        cmd.ExecuteNonQuery();

                        string query1 = string.Format("DELETE FROM {0} WHERE item_id = {1}", "stock_balance", i.Cells[1].Value);
                        MySqlCommand cmd1 = new MySqlCommand(query1, connection);
                        cmd1.ExecuteNonQuery();
                    }
                }
                set_autoincrement("id", "item_master");
                connection.Close();
                loadItems();
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


                connection.Open();
                string query = "UPDATE item_master SET `code` = ?, `major_gp` = ?, `sub_gp` = ?, `color` = ?, `size` = ?, `item_desc` = ?, `store` = ?, `unit` = ?, `reorder` = ?, `avg` = ?, `location` = ? WHERE id = ?;";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("param1", lblCode.Text);
                cmd.Parameters.AddWithValue("param2", cbMajor.Text);
                cmd.Parameters.AddWithValue("param3", cbSub.Text);
                cmd.Parameters.AddWithValue("param4", cbColor.Text);
                cmd.Parameters.AddWithValue("param5", cbSize.Text);
                cmd.Parameters.AddWithValue("param6", lblDesc.Text);
                cmd.Parameters.AddWithValue("param7", cbStore.Text);
                cmd.Parameters.AddWithValue("param8", cbUnit.Text);
                cmd.Parameters.AddWithValue("param9", tbReorder.Text);
                cmd.Parameters.AddWithValue("param10", lblAvg.Text);
                cmd.Parameters.AddWithValue("param11", cbLocation.Text);
                cmd.Parameters.AddWithValue("param12", selectedRows[0].Cells[0].Value.ToString());



                cmd.ExecuteNonQuery();


                string query1 = "UPDATE stock_balance SET `item_id` = ?, `item_desc` = ?, `store` = ? WHERE item_id = ?;";
                MySqlCommand cmd1 = new MySqlCommand(query1, connection);
                cmd1.Parameters.AddWithValue("param1", lblCode.Text);
                cmd1.Parameters.AddWithValue("param2", lblDesc.Text);
                cmd1.Parameters.AddWithValue("param3", cbStore.Text);
                cmd1.Parameters.AddWithValue("param4", selectedRows[0].Cells[1].Value.ToString());
                   


                cmd1.ExecuteNonQuery();
                connection.Close();
                loadItems();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }

       
        private void loadItems()
        {
            try
            {
                connection.Open();
                string query = "select id as م , code as الكود ,item_desc as 'اسم الصنف',major_gp as 'المجموعة الرئيسية',sub_gp as 'المجموعة الفرعية',color as اللون,size as المقاس,avg as المتوسط,reorder as 'حد الطلب',store as المخزن,location as الرف,unit as الوحدة from item_master;";
                //string query = "select * from item_master;";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);


                DataSet ds = new DataSet();
                adapter.Fill(ds, "item_master");
                dgView.DataSource = ds.Tables["item_master"];

                connection.Close();
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
            lblCode.Text = dgView.Rows[e.RowIndex].Cells[1].Value.ToString();
            lblDesc.Text = dgView.Rows[e.RowIndex].Cells[2].Value.ToString();
            cbMajor.Text = dgView.Rows[e.RowIndex].Cells[3].Value.ToString();
            cbSub.Text = dgView.Rows[e.RowIndex].Cells[4].Value.ToString();
            cbColor.Text = dgView.Rows[e.RowIndex].Cells[5].Value.ToString();
            cbSize.Text = dgView.Rows[e.RowIndex].Cells[6].Value.ToString();
            lblAvg.Text = dgView.Rows[e.RowIndex].Cells[7].Value.ToString();
            tbReorder.Text = dgView.Rows[e.RowIndex].Cells[8].Value.ToString();
            cbStore.Text = dgView.Rows[e.RowIndex].Cells[9].Value.ToString();
            cbLocation.Text = dgView.Rows[e.RowIndex].Cells[10].Value.ToString();
            cbUnit.Text = dgView.Rows[e.RowIndex].Cells[11].Value.ToString();
            }
        }

       
        private void loadIntoCombo()
        {
            string query_major = "SELECT name FROM major_gp;";
            string query_sub = "SELECT name FROM mark;";
            string query_type = "SELECT name FROM type;";
            string query_size = "SELECT name FROM size;";
            string query_color = "SELECT name FROM color;";
            string query_trans = "SELECT name FROM trans;";
            string query_store = "SELECT name FROM store;";
            string query_unit = "SELECT name FROM unit;";
            string query_location = "SELECT name FROM location;";

            connection.Open();
            MySqlCommand cmd1 = new MySqlCommand(query_major, connection);
            MySqlCommand cmd2 = new MySqlCommand(query_sub, connection);
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
                //cbSub.Items.Add(reader.GetString("name"));

            }
            reader.Dispose();




            reader = cmd3.ExecuteReader();
            List<string> type = new List<string>();
            while (reader.Read())
            {
                type.Add(reader.GetString("name"));
            }
            reader.Dispose();


            for (int i = 0; i < mark.Count; i++)
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

        private void clear()
        {
            cbMajor.Text = "";
            cbSub.Text = "";
            cbSize.Text = "";
            cbColor.Text = "";
            cbLocation.Text = "";
            cbStore.Text = "";
            cbUnit.Text = "عدد";
            tbReorder.Text = "";
            lblAvg.Text = "";
            lblCode.Text = "";
            lblDesc.Text = "";
        }

        private string getCode()
        {
            int major_gp_code = 0;
            int sub_gp_code = 0;
            int color_code = 0;
            int size_code = 0;


            string major_gp_code_query = string.Format(@"select id from major_gp where name = ""{0}"";", cbMajor.Text);
            string sub_gp_code_query = string.Format(@"select id from  sub_gp where name = ""{0}"";", cbSub.Text);
            string color_code_query = string.Format(@"select id from color where name = ""{0}"";", cbColor.Text);
            string size_code_query = string.Format(@"SELECT id FROM size WHERE name = ""{0}"";", cbSize.Text);
            MySqlCommand cmd1 = new MySqlCommand(major_gp_code_query, connection);
            MySqlCommand cmd2 = new MySqlCommand(sub_gp_code_query, connection);
            MySqlCommand cmd3 = new MySqlCommand(color_code_query, connection);
            MySqlCommand cmd4 = new MySqlCommand(size_code_query, connection);

            if (cbColor.Text != "")
            {
                color_code = (int)cmd3.ExecuteScalar();
            }
            if (cbSize.Text != "")
            {
                size_code = (int)cmd4.ExecuteScalar();
            }
            if (cbSub.Text != "")
            {
                sub_gp_code = (int)cmd2.ExecuteScalar();
            }
            if (cbMajor.Text != "")
            {
                major_gp_code = (int)cmd1.ExecuteScalar();
            }



            return (color_code.ToString() + size_code.ToString() + sub_gp_code.ToString("00") + major_gp_code.ToString("00"));
        }

        private void set_autoincrement(string id, string table)
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

