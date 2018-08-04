using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace WindowsFormsApplication2
{
    
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        public string b;
         private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MySql.Data.MySqlClient.MySqlConnection conn = new MySqlConnection();
            string myConnectionString;
            myConnectionString = "server=127.0.0.1;"
+ "uid=root;"
+ "pwd=;"
+ "SslMode=none;"
+ "database=db";

            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 0)
                {
                    
                    var a = new Form3();
                    b = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                    a.Show();
                 
                }
                if (e.ColumnIndex == 1)
                {
                    conn.ConnectionString = myConnectionString;
                    conn.Open();
                    using (MySqlConnection con = new MySqlConnection(myConnectionString))
                    {
                        using (MySqlCommand cmd = new MySqlCommand("DELETE FROM items WHERE id =" + dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString(), conn))
                        {
                            cmd.CommandType = CommandType.Text;
                            if (cmd.ExecuteNonQuery() > 0 )
                            {
                                MessageBox.Show("Deleted", "Yep it's gone ",
   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                                using (MySqlConnection con1 = new MySqlConnection(myConnectionString))
                                {
                                    using (MySql.Data.MySqlClient.MySqlCommand cmd1 = new MySql.Data.MySqlClient.MySqlCommand("SELECT items.id,items.name,items.stocks FROM items ", conn))
                                    {
                                        cmd1.CommandType = CommandType.Text;
                                        using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd1))
                                        {
                                            using (DataTable dt = new DataTable())
                                            {
                                                sda.Fill(dt);
                                                dataGridView1.DataSource = dt;
                                                dataGridView1.ReadOnly = false;
                                                dataGridView1.ClearSelection();
                                                dataGridView1.Columns[2].Visible = false;
                                                dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                                dataGridView1.Columns[3].HeaderCell.Value = "Name";
                                                dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                                dataGridView1.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                                dataGridView1.Columns[4].HeaderCell.Value = "Stock";
                                                dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                                dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                                dataGridView1.Columns[1].HeaderCell.Value = "";
                                                dataGridView1.Columns[1].Width = 50;
                                                dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                                dataGridView1.Columns[0].HeaderCell.Value = "";
                                                dataGridView1.Columns[0].Width = 50;
                                                dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                                dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    conn.Close();

                }
            }
        }

        public void refresh()
        {
            {
                MySql.Data.MySqlClient.MySqlConnection conn = new MySqlConnection();
                string myConnectionString;
                myConnectionString = "server=127.0.0.1;"
    + "uid=root;"
    + "pwd=;"
    + "SslMode=none;"
    + "database=db";

                dataGridView1.DefaultCellStyle.SelectionBackColor = dataGridView1.DefaultCellStyle.BackColor;
                dataGridView1.DefaultCellStyle.SelectionForeColor = dataGridView1.DefaultCellStyle.ForeColor;
                conn.ConnectionString = myConnectionString;
                conn.Open();
                using (MySqlConnection con = new MySqlConnection(myConnectionString))
                {
                    using (MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("SELECT items.id,items.name,items.stocks FROM items ", conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                dataGridView1.DataSource = dt;
                                dataGridView1.ReadOnly = false;
                                dataGridView1.ClearSelection();
                                dataGridView1.Columns[2].Visible = false;
                                dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                dataGridView1.Columns[3].HeaderCell.Value = "Name";
                                dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                dataGridView1.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                dataGridView1.Columns[4].HeaderCell.Value = "Stock";
                                dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                dataGridView1.Columns[1].HeaderCell.Value = "";
                                dataGridView1.Columns[1].Width = 50;
                                dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                dataGridView1.Columns[0].HeaderCell.Value = "";
                                dataGridView1.Columns[0].Width = 50;
                                dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                dataGridView1.Refresh();
                            }
                        }
                    }
                }


            }
        }


      
            private void UserControl1_Load(object sender, EventArgs e)
        {
            MySql.Data.MySqlClient.MySqlConnection conn = new MySqlConnection();
            string myConnectionString;
            myConnectionString = "server=127.0.0.1;"
+ "uid=root;"
+ "pwd=;"
+ "SslMode=none;"
+ "database=db";

            dataGridView1.DefaultCellStyle.SelectionBackColor = dataGridView1.DefaultCellStyle.BackColor;
            dataGridView1.DefaultCellStyle.SelectionForeColor = dataGridView1.DefaultCellStyle.ForeColor;
            conn.ConnectionString = myConnectionString;
            conn.Open();
              using (MySqlConnection con = new MySqlConnection(myConnectionString)){
                  using (MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("SELECT items.id,items.name,items.stocks FROM items ", conn)){
                    cmd.CommandType = CommandType.Text;
                       using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd)){
                           using (DataTable dt = new DataTable()){
                               sda.Fill(dt);
                               dataGridView1.DataSource = dt;
                               dataGridView1.ReadOnly = false;
                               dataGridView1.ClearSelection();
                                dataGridView1.Columns[2].Visible = false;
    dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
    dataGridView1.Columns[3].HeaderCell.Value = "Name";
    dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
    dataGridView1.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
    dataGridView1.Columns[4].HeaderCell.Value = "Stock";
    dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
    dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
    dataGridView1.Columns[1].HeaderCell.Value = "";
    dataGridView1.Columns[1].Width = 50;
    dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
    dataGridView1.Columns[0].HeaderCell.Value = "";
    dataGridView1.Columns[0].Width = 50;
    dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
    dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                           }
                       }
                }
              }

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var a = new Form2();
            a.Show();

        

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if (comboBox1.Text.Equals("") && comboBox2.Text.Equals(""))
            {
                MySql.Data.MySqlClient.MySqlConnection conn = new MySqlConnection();
                string myConnectionString;
                myConnectionString = "server=127.0.0.1;"
        + "uid=root;"
        + "pwd=;"
        + "SslMode=none;"
        + "database=db";

                dataGridView1.DefaultCellStyle.SelectionBackColor = dataGridView1.DefaultCellStyle.BackColor;
                dataGridView1.DefaultCellStyle.SelectionForeColor = dataGridView1.DefaultCellStyle.ForeColor;
                conn.ConnectionString = myConnectionString;
                conn.Open();
                using (MySqlConnection con = new MySqlConnection(myConnectionString))
                {
                    using (MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("SELECT items.id,items.name,items.stocks FROM items where items.name like '%" + textBox1.Text + "%'", conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                dataGridView1.DataSource = dt;
                                dataGridView1.ReadOnly = false;
                                dataGridView1.ClearSelection();
                                dataGridView1.Columns[2].Visible = false;
                                dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                dataGridView1.Columns[3].HeaderCell.Value = "Name";
                                dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                dataGridView1.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                dataGridView1.Columns[4].HeaderCell.Value = "Stock";
                                dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                dataGridView1.Columns[1].HeaderCell.Value = "";
                                dataGridView1.Columns[1].Width = 50;
                                dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                dataGridView1.Columns[0].HeaderCell.Value = "";
                                dataGridView1.Columns[0].Width = 50;
                                dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                dataGridView1.Refresh();
                            }
                        }
                    }
                }

            }


            if (comboBox2.Text.Equals(""))
            {
                MySql.Data.MySqlClient.MySqlConnection conn = new MySqlConnection();
                string myConnectionString;
                myConnectionString = "server=127.0.0.1;"
        + "uid=root;"
        + "pwd=;"
        + "SslMode=none;"
        + "database=db";

                dataGridView1.DefaultCellStyle.SelectionBackColor = dataGridView1.DefaultCellStyle.BackColor;
                dataGridView1.DefaultCellStyle.SelectionForeColor = dataGridView1.DefaultCellStyle.ForeColor;
                conn.ConnectionString = myConnectionString;
                conn.Open();
                using (MySqlConnection con = new MySqlConnection(myConnectionString))
                {
                    using (MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("SELECT items.id,items.name,items.stocks,items.tagID FROM items where items.name like '%" + textBox1.Text + "%' and items.tagID="+comboBox1.SelectedIndex+1, conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                dataGridView1.DataSource = dt;
                                dataGridView1.ReadOnly = false;
                                dataGridView1.ClearSelection();
                                dataGridView1.Columns[2].Visible = false;
                                dataGridView1.Columns[5].Visible = false;
                                dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                dataGridView1.Columns[3].HeaderCell.Value = "Name";
                                dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                dataGridView1.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                dataGridView1.Columns[4].HeaderCell.Value = "Stock";
                                dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                dataGridView1.Columns[1].HeaderCell.Value = "";
                                dataGridView1.Columns[1].Width = 50;
                                dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                dataGridView1.Columns[0].HeaderCell.Value = "";
                                dataGridView1.Columns[0].Width = 50;
                                dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                dataGridView1.Refresh();
                            }
                        }
                    }
                }

            }


            if (comboBox1.Text.Equals("") && comboBox2.Text!="")
            {
                var a = "";
                if (comboBox2.Text.Equals("Damaged Beyond Repair"))
                {
                    a = "DamagedBeyondRepair";
                }
                else
                {
                    a = comboBox2.Text;
                }
                MySql.Data.MySqlClient.MySqlConnection conn = new MySqlConnection();
                string myConnectionString;
                myConnectionString = "server=127.0.0.1;"
        + "uid=root;"
        + "pwd=;"
        + "SslMode=none;"
        + "database=db";

                dataGridView1.DefaultCellStyle.SelectionBackColor = dataGridView1.DefaultCellStyle.BackColor;
                dataGridView1.DefaultCellStyle.SelectionForeColor = dataGridView1.DefaultCellStyle.ForeColor;
                conn.ConnectionString = myConnectionString;
                conn.Open();
                using (MySqlConnection con = new MySqlConnection(myConnectionString))
                {
                    using (MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("SELECT items.id,items.name,items.is"+a+" FROM items where items.name like '%" + textBox1.Text + "%' " , conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                dataGridView1.DataSource = dt;
                                dataGridView1.ReadOnly = false;
                                dataGridView1.ClearSelection();
                                dataGridView1.Columns[2].Visible = false;
        
                                dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                dataGridView1.Columns[3].HeaderCell.Value = "Name";
                                dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                dataGridView1.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                dataGridView1.Columns[4].HeaderCell.Value = "Stock";
                                dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                dataGridView1.Columns[1].HeaderCell.Value = "";
                                dataGridView1.Columns[1].Width = 50;
                                dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                dataGridView1.Columns[0].HeaderCell.Value = "";
                                dataGridView1.Columns[0].Width = 50;
                                dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                dataGridView1.Refresh();
                            }
                        }
                    }
                }

            }


            if (comboBox2.Text != "" && comboBox1.Text != "" && textBox1.Text!="")
            {
                MySql.Data.MySqlClient.MySqlConnection conn = new MySqlConnection();
                string myConnectionString;
                myConnectionString = "server=127.0.0.1;"
        + "uid=root;"
        + "pwd=;"
        + "SslMode=none;"
        + "database=db";

                dataGridView1.DefaultCellStyle.SelectionBackColor = dataGridView1.DefaultCellStyle.BackColor;
                dataGridView1.DefaultCellStyle.SelectionForeColor = dataGridView1.DefaultCellStyle.ForeColor;
                conn.ConnectionString = myConnectionString;
                conn.Open();
                using (MySqlConnection con = new MySqlConnection(myConnectionString))
                {
                    using (MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("SELECT items.id,items.name,items.is" + comboBox2.Text + " FROM items where items.name like '%" + textBox1.Text + "%' and items.tagID=" + comboBox1.SelectedIndex + 1, conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                dataGridView1.DataSource = dt;
                                dataGridView1.ReadOnly = false;
                                dataGridView1.ClearSelection();
                                dataGridView1.Columns[2].Visible = false;

                                dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                dataGridView1.Columns[3].HeaderCell.Value = "Name";
                                dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                dataGridView1.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                dataGridView1.Columns[4].HeaderCell.Value = "Stock";
                                dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                dataGridView1.Columns[1].HeaderCell.Value = "";
                                dataGridView1.Columns[1].Width = 50;
                                dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                dataGridView1.Columns[0].HeaderCell.Value = "";
                                dataGridView1.Columns[0].Width = 50;
                                dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                dataGridView1.Refresh();
                            }
                        }
                    }
                }

            }


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var a = "";
            if (comboBox2.Text.Equals("Damaged Beyond Repair"))
            {
                a = "DamagedBeyondRepair";
            }
            if (comboBox2.Text.Equals(""))
            {
                a = "Deployable";
            }
            else
            {
                a = comboBox2.Text;
            }

            if (comboBox1.Text.Equals("") && textBox1.Text.Equals(""))
            {
                MySql.Data.MySqlClient.MySqlConnection conn = new MySqlConnection();
                string myConnectionString;
                myConnectionString = "server=127.0.0.1;"
        + "uid=root;"
        + "pwd=;"
        + "SslMode=none;"
        + "database=db";

                dataGridView1.DefaultCellStyle.SelectionBackColor = dataGridView1.DefaultCellStyle.BackColor;
                dataGridView1.DefaultCellStyle.SelectionForeColor = dataGridView1.DefaultCellStyle.ForeColor;
                conn.ConnectionString = myConnectionString;
                conn.Open();
               
                using (MySqlConnection con = new MySqlConnection(myConnectionString))
                {
                    using (MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("SELECT items.id,items.name,items.is" + a + " FROM items  ", conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                dataGridView1.DataSource = dt;
                                dataGridView1.ReadOnly = false;
                                dataGridView1.ClearSelection();
                                dataGridView1.Columns[2].Visible = false;
                                dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                dataGridView1.Columns[3].HeaderCell.Value = "Name";
                                dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                dataGridView1.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                dataGridView1.Columns[4].HeaderCell.Value = "Stock";
                                dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                dataGridView1.Columns[1].HeaderCell.Value = "";
                                dataGridView1.Columns[1].Width = 50;
                                dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                dataGridView1.Columns[0].HeaderCell.Value = "";
                                dataGridView1.Columns[0].Width = 50;
                                dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                dataGridView1.Refresh();
                            }
                        }
                    }
                }

            }



            if (comboBox1.Text.Equals("") && textBox1.Text != "")
            {
                MySql.Data.MySqlClient.MySqlConnection conn = new MySqlConnection();
                string myConnectionString;
                myConnectionString = "server=127.0.0.1;"
        + "uid=root;"
        + "pwd=;"
        + "SslMode=none;"
        + "database=db";

                dataGridView1.DefaultCellStyle.SelectionBackColor = dataGridView1.DefaultCellStyle.BackColor;
                dataGridView1.DefaultCellStyle.SelectionForeColor = dataGridView1.DefaultCellStyle.ForeColor;
                conn.ConnectionString = myConnectionString;
                conn.Open();

                using (MySqlConnection con = new MySqlConnection(myConnectionString))
                {
                    using (MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("SELECT items.id,items.name,items.is" + a + " FROM items  where items.name like '%" + textBox1.Text + "%' ", conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                dataGridView1.DataSource = dt;
                                dataGridView1.ReadOnly = false;
                                dataGridView1.ClearSelection();
                                dataGridView1.Columns[2].Visible = false;
                                dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                dataGridView1.Columns[3].HeaderCell.Value = "Name";
                                dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                dataGridView1.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                dataGridView1.Columns[4].HeaderCell.Value = "Stock";
                                dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                dataGridView1.Columns[1].HeaderCell.Value = "";
                                dataGridView1.Columns[1].Width = 50;
                                dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                dataGridView1.Columns[0].HeaderCell.Value = "";
                                dataGridView1.Columns[0].Width = 50;
                                dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                dataGridView1.Refresh();
                            }
                        }
                    }
                }

            }


            if (textBox1.Text.Equals("") &&comboBox1.Text!="")
            {
                MySql.Data.MySqlClient.MySqlConnection conn = new MySqlConnection();
                string myConnectionString;
                myConnectionString = "server=127.0.0.1;"
        + "uid=root;"
        + "pwd=;"
        + "SslMode=none;"
        + "database=db";

                dataGridView1.DefaultCellStyle.SelectionBackColor = dataGridView1.DefaultCellStyle.BackColor;
                dataGridView1.DefaultCellStyle.SelectionForeColor = dataGridView1.DefaultCellStyle.ForeColor;
                conn.ConnectionString = myConnectionString;
                conn.Open();

                using (MySqlConnection con = new MySqlConnection(myConnectionString))
                {
                    using (MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("SELECT items.id,items.name,items.is" + a + ",items.tagID FROM items  where  items.tagID=" + comboBox1.SelectedIndex + 1, conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                dataGridView1.DataSource = dt;
                                dataGridView1.ReadOnly = false;
                                dataGridView1.ClearSelection();
                                dataGridView1.Columns[2].Visible = false;
                                dataGridView1.Columns[5].Visible = false;
                                dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                dataGridView1.Columns[3].HeaderCell.Value = "Name";
                                dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                dataGridView1.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                dataGridView1.Columns[4].HeaderCell.Value = "Stock";
                                dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                dataGridView1.Columns[1].HeaderCell.Value = "";
                                dataGridView1.Columns[1].Width = 50;
                                dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                dataGridView1.Columns[0].HeaderCell.Value = "";
                                dataGridView1.Columns[0].Width = 50;
                                dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                dataGridView1.Refresh();
                            }
                        }
                    }
                }

            }




         if(comboBox1.Text!="" && comboBox2.Text!="" &&textBox1.Text!="")
            {
                MySql.Data.MySqlClient.MySqlConnection conn = new MySqlConnection();
                string myConnectionString;
                myConnectionString = "server=127.0.0.1;"
        + "uid=root;"
        + "pwd=;"
        + "SslMode=none;"
        + "database=db";

                dataGridView1.DefaultCellStyle.SelectionBackColor = dataGridView1.DefaultCellStyle.BackColor;
                dataGridView1.DefaultCellStyle.SelectionForeColor = dataGridView1.DefaultCellStyle.ForeColor;
                conn.ConnectionString = myConnectionString;
                conn.Open();

                using (MySqlConnection con = new MySqlConnection(myConnectionString))
                {
                    using (MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("SELECT items.id,items.name,items.is" + a + ",items.tagID FROM items  where items.name like '%" + textBox1.Text + "%' and items.tagID=" + comboBox1.SelectedIndex + 1 , conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                dataGridView1.DataSource = dt;
                                dataGridView1.ReadOnly = false;
                                dataGridView1.ClearSelection();
                                dataGridView1.Columns[2].Visible = false;
                                dataGridView1.Columns[5].Visible = false;
                                dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                dataGridView1.Columns[3].HeaderCell.Value = "Name";
                                dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                dataGridView1.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                dataGridView1.Columns[4].HeaderCell.Value = "Stock";
                                dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                dataGridView1.Columns[1].HeaderCell.Value = "";
                                dataGridView1.Columns[1].Width = 50;
                                dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                dataGridView1.Columns[0].HeaderCell.Value = "";
                                dataGridView1.Columns[0].Width = 50;
                                dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                dataGridView1.Refresh();
                            }
                        }
                    }
                }

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var a = "";
            if (comboBox2.Text.Equals("Damaged Beyond Repair"))
            {
                a = "DamagedBeyondRepair";
            }
            else
            {
                a = comboBox2.Text;
            }

            if (comboBox2.Text.Equals("") && textBox1.Text.Equals(""))
            {
                MySql.Data.MySqlClient.MySqlConnection conn = new MySqlConnection();
                string myConnectionString;
                myConnectionString = "server=127.0.0.1;"
        + "uid=root;"
        + "pwd=;"
        + "SslMode=none;"
        + "database=db";

                dataGridView1.DefaultCellStyle.SelectionBackColor = dataGridView1.DefaultCellStyle.BackColor;
                dataGridView1.DefaultCellStyle.SelectionForeColor = dataGridView1.DefaultCellStyle.ForeColor;
                conn.ConnectionString = myConnectionString;
                conn.Open();

                using (MySqlConnection con = new MySqlConnection(myConnectionString))
                {
                    using (MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("SELECT items.id,items.name,items.stocks,items.tagID FROM items where tagID= "+comboBox1.SelectedIndex+1, conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                dataGridView1.DataSource = dt;
                                dataGridView1.ReadOnly = false;
                                dataGridView1.ClearSelection();
                                dataGridView1.Columns[2].Visible = false;
                                dataGridView1.Columns[5].Visible = false;
                                dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                dataGridView1.Columns[3].HeaderCell.Value = "Name";
                                dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                dataGridView1.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                dataGridView1.Columns[4].HeaderCell.Value = "Stock";
                                dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                dataGridView1.Columns[1].HeaderCell.Value = "";
                                dataGridView1.Columns[1].Width = 50;
                                dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                dataGridView1.Columns[0].HeaderCell.Value = "";
                                dataGridView1.Columns[0].Width = 50;
                                dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                dataGridView1.Refresh();
                            }
                        }
                    }
                }

            }



            if (comboBox2.Text.Equals("") && textBox1.Text != "")
            {
                MySql.Data.MySqlClient.MySqlConnection conn = new MySqlConnection();
                string myConnectionString;
                myConnectionString = "server=127.0.0.1;"
        + "uid=root;"
        + "pwd=;"
        + "SslMode=none;"
        + "database=db";

                dataGridView1.DefaultCellStyle.SelectionBackColor = dataGridView1.DefaultCellStyle.BackColor;
                dataGridView1.DefaultCellStyle.SelectionForeColor = dataGridView1.DefaultCellStyle.ForeColor;
                conn.ConnectionString = myConnectionString;
                conn.Open();

                using (MySqlConnection con = new MySqlConnection(myConnectionString))
                {
                    using (MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("SELECT items.id,items.name,items.stocks,items.tagID FROM items  where items.name like '%" + textBox1.Text + "%' and tagID="+comboBox1.SelectedIndex+1, conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                dataGridView1.DataSource = dt;
                                dataGridView1.ReadOnly = false;
                                dataGridView1.ClearSelection();
                                dataGridView1.Columns[2].Visible = false;
                                dataGridView1.Columns[5].Visible = false;
                                dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                dataGridView1.Columns[3].HeaderCell.Value = "Name";
                                dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                dataGridView1.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                dataGridView1.Columns[4].HeaderCell.Value = "Stock";
                                dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                dataGridView1.Columns[1].HeaderCell.Value = "";
                                dataGridView1.Columns[1].Width = 50;
                                dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                dataGridView1.Columns[0].HeaderCell.Value = "";
                                dataGridView1.Columns[0].Width = 50;
                                dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                dataGridView1.Refresh();
                            }
                        }
                    }
                }

            }


            if (textBox1.Text.Equals("") && comboBox2.Text != "")
            {
                MySql.Data.MySqlClient.MySqlConnection conn = new MySqlConnection();
                string myConnectionString;
                myConnectionString = "server=127.0.0.1;"
        + "uid=root;"
        + "pwd=;"
        + "SslMode=none;"
        + "database=db";

                dataGridView1.DefaultCellStyle.SelectionBackColor = dataGridView1.DefaultCellStyle.BackColor;
                dataGridView1.DefaultCellStyle.SelectionForeColor = dataGridView1.DefaultCellStyle.ForeColor;
                conn.ConnectionString = myConnectionString;
                conn.Open();

                using (MySqlConnection con = new MySqlConnection(myConnectionString))
                {
                    using (MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("SELECT items.id,items.name,items.is" + a + ",items.tagID FROM items  where  items.tagID=" + comboBox1.SelectedIndex + 1, conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                dataGridView1.DataSource = dt;
                                dataGridView1.ReadOnly = false;
                                dataGridView1.ClearSelection();
                                dataGridView1.Columns[2].Visible = false;
                                dataGridView1.Columns[5].Visible = false;
                                dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                dataGridView1.Columns[3].HeaderCell.Value = "Name";
                                dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                dataGridView1.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                dataGridView1.Columns[4].HeaderCell.Value = "Stock";
                                dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                dataGridView1.Columns[1].HeaderCell.Value = "";
                                dataGridView1.Columns[1].Width = 50;
                                dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                dataGridView1.Columns[0].HeaderCell.Value = "";
                                dataGridView1.Columns[0].Width = 50;
                                dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                dataGridView1.Refresh();
                            }
                        }
                    }
                }

            }




            if (comboBox1.Text != "" && comboBox2.Text != "" && textBox1.Text != "")
            {
                MySql.Data.MySqlClient.MySqlConnection conn = new MySqlConnection();
                string myConnectionString;
                myConnectionString = "server=127.0.0.1;"
        + "uid=root;"
        + "pwd=;"
        + "SslMode=none;"
        + "database=db";

                dataGridView1.DefaultCellStyle.SelectionBackColor = dataGridView1.DefaultCellStyle.BackColor;
                dataGridView1.DefaultCellStyle.SelectionForeColor = dataGridView1.DefaultCellStyle.ForeColor;
                conn.ConnectionString = myConnectionString;
                conn.Open();

                using (MySqlConnection con = new MySqlConnection(myConnectionString))
                {
                    using (MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("SELECT items.id,items.name,items.is" + a + ",items.tagID FROM items  where items.name like '%" + textBox1.Text + "%' and items.tagID=" + comboBox1.SelectedIndex + 1, conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                dataGridView1.DataSource = dt;
                                dataGridView1.ReadOnly = false;
                                dataGridView1.ClearSelection();
                                dataGridView1.Columns[2].Visible = false;
                                dataGridView1.Columns[5].Visible = false;
                                dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                dataGridView1.Columns[3].HeaderCell.Value = "Name";
                                dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                dataGridView1.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                dataGridView1.Columns[4].HeaderCell.Value = "Stock";
                                dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                dataGridView1.Columns[1].HeaderCell.Value = "";
                                dataGridView1.Columns[1].Width = 50;
                                dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                dataGridView1.Columns[0].HeaderCell.Value = "";
                                dataGridView1.Columns[0].Width = 50;
                                dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                dataGridView1.Refresh();
                            }
                        }
                    }
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            refresh();
            textBox1.Text = "";
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
        }

       

      
    }

    
}
