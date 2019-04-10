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
    public partial class aid_items : Form
    {

        private MySqlConnection connection;
        private string server, database, user, pass;

        public aid_items()
        {
            InitializeComponent();
        }

        private void aid_items_Load(object sender, EventArgs e)
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
            loadMajor();
            loadMark();
            loadType();
            loadSize();
            loadColor();
            loadTrans();
            loadStore();
            loadUnit();
            loadLocation();
            clear();

            //string max_query = "select max(id) from major_gp;";
            //connection.Open();
            //MySqlCommand cmd1 = new MySqlCommand(max_query, connection);

            //var max = cmd1.ExecuteScalar();
            //if(max.ToString() == "") {
            //    string set_autoincrement = "ALTER TABLE major_gp AUTO_INCREMENT = 1; ";
            //    MySqlCommand cmd = new MySqlCommand(set_autoincrement, connection);
            //    cmd.ExecuteNonQuery();
            //}
            //else
            //{
            //    string set_autoincrement = "ALTER TABLE major_gp AUTO_INCREMENT = ?; ";
            //    MySqlCommand cmd = new MySqlCommand(set_autoincrement, connection);
            //    var max_string = (int)(max) + 1 ;
            //    cmd.Parameters.AddWithValue("param1", max_string);
            //    cmd.ExecuteNonQuery();

            //}
            //connection.Close();
        }



        /////////////////////////////////////////////////////
        // Add Buttons
        ///////////////////////////////////////////////////
        private void major_btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                connection.Open();
                insert("major_gp", major_tbName);
                connection.Close();
                clear();
                loadMajor();
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
                connection.Close();
            }

        }


        private void mark_btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                insert("mark", mark_tbName);
                connection.Close();
                clear();
                loadMark();
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }


        private void type_btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                connection.Open();
                insert("type", type_tbName);
                connection.Close();
                clear();
                loadType();
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }

        private void size_btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                connection.Open();
                insert("size", size_tbName);
                connection.Close();
                clear();
                loadSize();
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }

        private void color_btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                connection.Open();
                insert("color", color_tbName);
                connection.Close();
                clear();
                loadColor();
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }

        private void trans_btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                connection.Open();
                insert("trans_type", trans_tbName);
                connection.Close();
                clear();
                loadTrans();
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }

        private void store_btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                connection.Open();
                insert("store", store_tbName);
                connection.Close();
                clear();
                loadStore();
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }


        private void unit_btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                connection.Open();
                insert("unit", unit_tbName);
                connection.Close();
                clear();
                loadUnit();
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }

        private void location_btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                connection.Open();
                insert("location", location_tbName);
                connection.Close();
                clear();
                loadLocation();
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }


        /////////////////////////////////////////////////////
        // Delete Buttons
        ///////////////////////////////////////////////////


        private void major_btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                delete("major_gp", major_dgView);
                set_autoincrement("id", "major_gp");
                connection.Close();
                clear();
                loadMajor();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }


        private void mark_btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                connection.Open();
                delete("mark", major_dgView);
                set_autoincrement("id", "mark");
                connection.Close();
                clear();
                loadMark();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }


        private void type_btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                connection.Open();
                delete("type", major_dgView);
                set_autoincrement("id", "type");
                connection.Close();
                clear();
                loadType();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }

        private void size_btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                connection.Open();
                delete("size", major_dgView);
                set_autoincrement("id", "size");
                connection.Close();
                clear();
                loadSize();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }

        private void color_btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                connection.Open();
                delete("color", major_dgView);
                set_autoincrement("id", "color");
                connection.Close();
                clear();
                loadColor();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }

        private void trans_btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                delete("trans_type", major_dgView);
                set_autoincrement("id", "trans_type");
                connection.Close();
                clear();
                loadTrans();
            }

            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }


        private void store_btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                connection.Open();
                delete("store", major_dgView);
                set_autoincrement("id", "store");
                connection.Close();
                clear();
                loadStore();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }

        private void unit_btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                connection.Open();
                delete("unit", major_dgView);
                set_autoincrement("id", "unit");
                connection.Close();
                clear();
                loadUnit();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }

        private void location_btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                connection.Open();
                delete("location", major_dgView);
                set_autoincrement("id", "location");
                connection.Close();
                clear();
                loadLocation();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }


        /////////////////////////////////////////////////////
        // Edit Buttons
        ///////////////////////////////////////////////////

        private void major_btnEdit_Click(object sender, EventArgs e)
        {

            try
            {
                var selectedRows = major_dgView.SelectedRows
            .OfType<DataGridViewRow>()
            .Where(r => !r.IsNewRow)
            .ToArray();


                string query = "UPDATE major_gp SET name = ? WHERE id = ?;";
                connection.Open();

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("param1", major_tbName.Text);
                cmd.Parameters.AddWithValue("param2", selectedRows[0].Cells[0].Value);


                cmd.ExecuteNonQuery();
                connection.Close();
                clear();
                loadMajor();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }


        private void mark_btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedRows = mark_dgView.SelectedRows
            .OfType<DataGridViewRow>()
            .Where(r => !r.IsNewRow)
            .ToArray();


                string query = "UPDATE mark SET name = ? WHERE id = ?;";
                connection.Open();

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("param1", mark_tbName.Text);
                cmd.Parameters.AddWithValue("param2", selectedRows[0].Cells[0].Value);


                cmd.ExecuteNonQuery();
                connection.Close();
                clear();
                loadMark();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }



        private void type_btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedRows = type_dgView.SelectedRows
            .OfType<DataGridViewRow>()
            .Where(r => !r.IsNewRow)
            .ToArray();


                string query = "UPDATE type SET name = ? WHERE id = ?;";
                connection.Open();

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("param1", type_tbName.Text);
                cmd.Parameters.AddWithValue("param2", selectedRows[0].Cells[0].Value);


                cmd.ExecuteNonQuery();
                connection.Close();
                clear();
                loadType();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }

        private void size_btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedRows = size_dgView.SelectedRows
            .OfType<DataGridViewRow>()
            .Where(r => !r.IsNewRow)
            .ToArray();


                string query = "UPDATE size SET name = ? WHERE id = ?;";
                connection.Open();

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("param1", size_tbName.Text);
                cmd.Parameters.AddWithValue("param2", selectedRows[0].Cells[0].Value);


                cmd.ExecuteNonQuery();
                connection.Close();
                clear();
                loadSize();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }

        private void color_btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedRows = color_dgView.SelectedRows
            .OfType<DataGridViewRow>()
            .Where(r => !r.IsNewRow)
            .ToArray();


                string query = "UPDATE color SET name = ? WHERE id = ?;";
                connection.Open();

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("param1", color_tbName.Text);
                cmd.Parameters.AddWithValue("param2", selectedRows[0].Cells[0].Value);


                cmd.ExecuteNonQuery();
                connection.Close();
                clear();
                loadColor();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }

        private void trans_btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedRows = trans_dgView.SelectedRows
            .OfType<DataGridViewRow>()
            .Where(r => !r.IsNewRow)
            .ToArray();


                string query = "UPDATE trans_type SET name = ? WHERE id = ?;";
                connection.Open();

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("param1", trans_tbName.Text);
                cmd.Parameters.AddWithValue("param2", selectedRows[0].Cells[0].Value);


                cmd.ExecuteNonQuery();
                connection.Close();
                clear();
                loadTrans();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }



        private void store_btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedRows = store_dgView.SelectedRows
            .OfType<DataGridViewRow>()
            .Where(r => !r.IsNewRow)
            .ToArray();


                string query = "UPDATE store SET name = ? WHERE id = ?;";
                connection.Open();

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("param1", store_tbName.Text);
                cmd.Parameters.AddWithValue("param2", selectedRows[0].Cells[0].Value);


                cmd.ExecuteNonQuery();
                connection.Close();
                clear();
                loadStore();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }

        }

        private void unit_btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedRows = unit_dgView.SelectedRows
            .OfType<DataGridViewRow>()
            .Where(r => !r.IsNewRow)
            .ToArray();


                string query = "UPDATE unit SET name = ? WHERE id = ?;";
                connection.Open();

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("param1", unit_tbName.Text);
                cmd.Parameters.AddWithValue("param2", selectedRows[0].Cells[0].Value);


                cmd.ExecuteNonQuery();
                connection.Close();
                clear();
                loadUnit();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }

        private void location_btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedRows = location_dgView.SelectedRows
            .OfType<DataGridViewRow>()
            .Where(r => !r.IsNewRow)
            .ToArray();


                string query = "UPDATE location SET name = ? WHERE id = ?;";
                connection.Open();

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("param1", location_tbName.Text);
                cmd.Parameters.AddWithValue("param2", selectedRows[0].Cells[0].Value);


                cmd.ExecuteNonQuery();
                connection.Close();
                clear();
                loadLocation();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }


        /////////////////////////////////////////////////////
        // Cell Click
        ///////////////////////////////////////////////////
        private void major_dgView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            major_tbName.Text = major_dgView.Rows[e.RowIndex].Cells[1].Value.ToString();
        }


        private void mark_dgView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            mark_tbName.Text = mark_dgView.Rows[e.RowIndex].Cells[1].Value.ToString();
        }


        private void type_dgView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            type_tbName.Text = type_dgView.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void size_dgView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            size_tbName.Text = size_dgView.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void color_dgView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            color_tbName.Text = color_dgView.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void trans_dgView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            trans_tbName.Text = trans_dgView.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void store_dgView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            store_tbName.Text = store_dgView.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void unit_dgView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            unit_tbName.Text = unit_dgView.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void location_dgView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            location_tbName.Text = location_dgView.Rows[e.RowIndex].Cells[1].Value.ToString();
        }



        /////////////////////////////////////////////////////////////////////////////////////////////////////
        // Text Box Key Down
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void major_tbName_KeyDown(object sender, KeyEventArgs e)
        {
          
            if (e.KeyData == Keys.Enter)
            {
                major_btnAdd.PerformClick();
            }
        }

        private void mark_tbName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                major_btnAdd.PerformClick();
            }
        }

        private void type_tbName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                major_btnAdd.PerformClick();
            }
        }

        private void size_tbName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                major_btnAdd.PerformClick();
            }
        }

        private void color_tbName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                major_btnAdd.PerformClick();
            }
        }

        private void trans_tbName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                major_btnAdd.PerformClick();
            }
        }

        private void store_tbName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                major_btnAdd.PerformClick();
            }
        }

        private void unit_tbName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                major_btnAdd.PerformClick();
            }
        }

        private void location_tbName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                major_btnAdd.PerformClick();
            }
        }




        /////////////////////////////////////////////////////////////////////////////////////////////////////
        // DataGrid Key Down
        ////////////////////////////////////////////////////////////////////////////////////////////////////
        private void major_dgView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete)
            {
                major_btnDelete.PerformClick();
            }
        }

        private void mark_dgView_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyData == Keys.Delete)
            {
                mark_btnDelete.PerformClick();
            }
        }

        private void type_dgView_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyData == Keys.Delete)
            {
                type_btnDelete.PerformClick();
            }
        }

        private void size_dgView_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyData == Keys.Delete)
            {
                size_btnDelete.PerformClick();
            }
        }

        private void color_tdgView_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyData == Keys.Delete)
            {
                color_btnDelete.PerformClick();
            }
        }

        private void trans_dgView_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyData == Keys.Delete)
            {
                trans_btnDelete.PerformClick();
            }
        }

        private void store_dgView_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyData == Keys.Delete)
            {
                store_btnDelete.PerformClick();
            }
        }

        private void unit_dgView_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyData == Keys.Delete)
            {
                unit_btnDelete.PerformClick();
            }
        }

        private void location_dgView_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyData == Keys.Delete)
            {
                location_btnDelete.PerformClick();
            }
        }


        /////////////////////////////////////////////////////
        // Load Data
        ///////////////////////////////////////////////////

        private void loadMajor()
        {
            try
            {
                string query = "select id as م , name as الاسم from major_gp;";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);

                connection.Open();

                DataSet ds = new DataSet();
                adapter.Fill(ds, "major_gp");
                major_dgView.DataSource = ds.Tables["major_gp"];

                connection.Close();
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
                connection.Close();
            }

        }

        private void loadMark()
        {
            try
            {
                string query = "select id as م , name as الاسم from mark;";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);

                connection.Open();

                DataSet ds = new DataSet();
                adapter.Fill(ds, "mark");
                mark_dgView.DataSource = ds.Tables["mark"];

                connection.Close();
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }

        private void loadType()
        {
            try
            {
                string query = "select id as م , name as الاسم from type;";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);

                connection.Open();

                DataSet ds = new DataSet();
                adapter.Fill(ds, "type");
                type_dgView.DataSource = ds.Tables["type"];

                connection.Close();
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }



        private void loadSize()
        {
            try
            {
                string query = "select id as م , name as الاسم from size;";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);

                connection.Open();

                DataSet ds = new DataSet();
                adapter.Fill(ds, "size");
                size_dgView.DataSource = ds.Tables["size"];

                connection.Close();
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }


        private void loadColor()
        {
            try
            {
                string query = "select id as م , name as الاسم from color;";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);

                connection.Open();

                DataSet ds = new DataSet();
                adapter.Fill(ds, "color");
                color_dgView.DataSource = ds.Tables["color"];

                connection.Close();
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }


        private void loadTrans()
        {
            try
            {
                string query = "select id as م , name as الاسم from trans_type;";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);

                connection.Open();

                DataSet ds = new DataSet();
                adapter.Fill(ds, "trans_type");
                trans_dgView.DataSource = ds.Tables["trans_type"];

                connection.Close();
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }


        private void loadStore()
        {
            try
            {
                string query = "select id as م , name as الاسم from store;";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);

                connection.Open();

                DataSet ds = new DataSet();
                adapter.Fill(ds, "store");
                store_dgView.DataSource = ds.Tables["store"];

                connection.Close();
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }


        private void loadUnit()
        {
            try
            {
                string query = "select id as م , name as الاسم from unit;";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);

                connection.Open();

                DataSet ds = new DataSet();
                adapter.Fill(ds, "unit");
                unit_dgView.DataSource = ds.Tables["unit"];

                connection.Close();
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }

       
        private void loadLocation()
        {
            try
            {
                string query = "select id as م , name as الاسم from location;";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);

                connection.Open();

                DataSet ds = new DataSet();
                adapter.Fill(ds, "location");
                location_dgView.DataSource = ds.Tables["location"];

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
            major_tbName.Text = "";
            mark_tbName.Text = "";
            type_tbName.Text = "";
            size_tbName.Text = "";
            color_tbName.Text = "";
            trans_tbName.Text = "";
            store_tbName.Text = "";
            unit_tbName.Text = "";
            location_tbName.Text = "";
        }

       

        private void set_autoincrement(string id, string table)
        {

            string max_query = String.Format("select max({0}) from {1} ;", id, table);
            MySqlCommand cmd2 = new MySqlCommand(max_query, connection);

            var max = cmd2.ExecuteScalar();

            if (max.ToString() == "")
            {
                string set_autoincrement = String.Format("ALTER TABLE {0} AUTO_INCREMENT = 1; ", table);
                MySqlCommand cmd1 = new MySqlCommand(set_autoincrement, connection);

                cmd1.ExecuteNonQuery();
            }
            else
            {
                var max_string = (int)(max) + 1;
                string set_autoincrement = String.Format("ALTER TABLE {0} AUTO_INCREMENT = {1};", table, max_string);
                MySqlCommand cmd1 = new MySqlCommand(set_autoincrement, connection);

                cmd1.ExecuteNonQuery();
            }
        }

        private void delete(string table_name, DataGridView dg)
        {
           DialogResult d = MessageBox.Show( "هل تريد المسح", "تأكيد المسح", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (d == DialogResult.Yes)
            {
                var selectedRows = dg.SelectedRows
            .OfType<DataGridViewRow>()
            .Where(r => !r.IsNewRow)
            .ToArray();
                foreach (var i in selectedRows)
                {
                    string query = string.Format("DELETE FROM {0} WHERE id = {1}", table_name, i.Cells[0].Value);
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                }
            }

        }

        private void insert(string table_name, TextBox tb)
        {
            string query = string.Format("INSERT INTO {0} ( name ) VALUES ( ? );", table_name);
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("param1", tb.Text);
            cmd.ExecuteNonQuery();
        }




    }
}


