using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
namespace WindowsFormsApplication2
{
    
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
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
                var a = new Form1();
                a.dataGridView1.DefaultCellStyle.SelectionBackColor = a.dataGridView1.DefaultCellStyle.BackColor;
                a.dataGridView1.DefaultCellStyle.SelectionForeColor = a.dataGridView1.DefaultCellStyle.ForeColor;
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
                             
                                a.dataGridView1.DataSource = dt;
                                a.dataGridView1.ReadOnly = false;
                                a.dataGridView1.ClearSelection();
                                a.dataGridView1.Columns[2].Visible = false;
                                a.dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                a.dataGridView1.Columns[3].HeaderCell.Value = "Name";
                                a.dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                a.dataGridView1.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                a.dataGridView1.Columns[4].HeaderCell.Value = "Stock";
                                a.dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                a.dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                a.dataGridView1.Columns[1].HeaderCell.Value = "";
                                a.dataGridView1.Columns[1].Width = 50;
                                a.dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                a.dataGridView1.Columns[0].HeaderCell.Value = "";
                                a.dataGridView1.Columns[0].Width = 50;
                                a.dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                a.dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                a.dataGridView1.Refresh();
                            }
                        }
                    }
                }


            }
        }


      
            private void UserControl1_Load(object sender, EventArgs e)
        {
           
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
            var a = new Form1();
            if (comboBox1.Text.Equals("") && comboBox2.Text.Equals(""))
            {
                MySql.Data.MySqlClient.MySqlConnection conn = new MySqlConnection();
                string myConnectionString;
                myConnectionString = "server=127.0.0.1;"
        + "uid=root;"
        + "pwd=;"
        + "SslMode=none;"
        + "database=db";

                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.DefaultCellStyle.SelectionBackColor = (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.DefaultCellStyle.BackColor;
                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.DefaultCellStyle.SelectionForeColor = (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.DefaultCellStyle.ForeColor;
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
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.DataSource = dt;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.ReadOnly = false;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.ClearSelection();
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[2].Visible = false;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[3].HeaderCell.Value = "Name";
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[4].HeaderCell.Value = "Stock";
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[1].HeaderCell.Value = "";
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[1].Width = 50;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[0].HeaderCell.Value = "";
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[0].Width = 50;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Refresh();
                            }
                        }
                    }
                }

            }


            if (comboBox2.Text.Equals("") && comboBox1.Text != "")
            {
                MySql.Data.MySqlClient.MySqlConnection conn = new MySqlConnection();
                string myConnectionString;
                myConnectionString = "server=127.0.0.1;"
        + "uid=root;"
        + "pwd=;"
        + "SslMode=none;"
        + "database=db";

                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.DefaultCellStyle.SelectionBackColor = (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.DefaultCellStyle.BackColor;
                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.DefaultCellStyle.SelectionForeColor = (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.DefaultCellStyle.ForeColor;
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
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.DataSource = dt;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.ReadOnly = false;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.ClearSelection();
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[2].Visible = false;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[5].Visible = false;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[3].HeaderCell.Value = "Name";
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[4].HeaderCell.Value = "Stock";
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[1].HeaderCell.Value = "";
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[1].Width = 50;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[0].HeaderCell.Value = "";
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[0].Width = 50;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Refresh();
                            }
                        }
                    }
                }

            }


            if (comboBox1.Text.Equals("") && comboBox2.Text!="")
            {
                var a1 = "";
                if (comboBox2.Text.Equals("Damaged Beyond Repair"))
                {
                    a1 = "DamagedBeyondRepair";
                }
                else
                {
                    a1 = comboBox2.Text;
                }
                MySql.Data.MySqlClient.MySqlConnection conn = new MySqlConnection();
                string myConnectionString;
                myConnectionString = "server=127.0.0.1;"
        + "uid=root;"
        + "pwd=;"
        + "SslMode=none;"
        + "database=db";

                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.DefaultCellStyle.SelectionBackColor = (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.DefaultCellStyle.BackColor;
                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.DefaultCellStyle.SelectionForeColor = (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.DefaultCellStyle.ForeColor;
                conn.ConnectionString = myConnectionString;
                conn.Open();
                using (MySqlConnection con = new MySqlConnection(myConnectionString))
                {
                    using (MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("SELECT items.id,items.name,items.is"+a1+" FROM items where items.name like '%" + textBox1.Text + "%' " , conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.DataSource = dt;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.ReadOnly = false;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.ClearSelection();
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[2].Visible = false;

                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[3].HeaderCell.Value = "Name";
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[4].HeaderCell.Value = "Stock";
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[1].HeaderCell.Value = "";
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[1].Width = 50;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[0].HeaderCell.Value = "";
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[0].Width = 50;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Refresh();
                            }
                        }
                    }
                }

            }


            if (comboBox2.Text != "" && comboBox1.Text != "" && textBox1.Text!="")
            {

                var a1 = "";
                if (comboBox2.Text.Equals("Damaged Beyond Repair"))
                {
                    a1 = "DamagedBeyondRepair";
                }
                else
                {
                    a1 = comboBox2.Text;
                }
                MySql.Data.MySqlClient.MySqlConnection conn = new MySqlConnection();
                string myConnectionString;
                myConnectionString = "server=127.0.0.1;"
        + "uid=root;"
        + "pwd=;"
        + "SslMode=none;"
        + "database=db";

                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.DefaultCellStyle.SelectionBackColor = (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.DefaultCellStyle.BackColor;
                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.DefaultCellStyle.SelectionForeColor = (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.DefaultCellStyle.ForeColor;
                conn.ConnectionString = myConnectionString;
                conn.Open();
                using (MySqlConnection con = new MySqlConnection(myConnectionString))
                {
                    using (MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("SELECT items.id,items.name,items.is" + a1 + " FROM items where items.name like '%" + textBox1.Text + "%' and items.tagID=" + comboBox1.SelectedIndex + 1, conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.DataSource = dt;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.ReadOnly = false;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.ClearSelection();
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[2].Visible = false;

                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[3].HeaderCell.Value = "Name";
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[4].HeaderCell.Value = "Stock";
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[1].HeaderCell.Value = "";
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[1].Width = 50;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[0].HeaderCell.Value = "";
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[0].Width = 50;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Refresh();
                            }
                        }
                    }
                }

            }


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var a1 = "";
            if (comboBox2.Text.Equals("Damaged Beyond Repair"))
            {
                a1 = "DamagedBeyondRepair";
            }
            if (comboBox2.Text.Equals(""))
            {
                a1 = "Deployable";
            }
            else
            {
                a1 = comboBox2.Text;
            }
            var a = new Form1();
            if (comboBox1.Text.Equals("") && textBox1.Text.Equals(""))
            {
                MySql.Data.MySqlClient.MySqlConnection conn = new MySqlConnection();
                string myConnectionString;
                myConnectionString = "server=127.0.0.1;"
        + "uid=root;"
        + "pwd=;"
        + "SslMode=none;"
        + "database=db";

                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.DefaultCellStyle.SelectionBackColor = (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.DefaultCellStyle.BackColor;
                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.DefaultCellStyle.SelectionForeColor = (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.DefaultCellStyle.ForeColor;
                conn.ConnectionString = myConnectionString;
                conn.Open();
               
                using (MySqlConnection con = new MySqlConnection(myConnectionString))
                {
                    using (MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("SELECT items.id,items.name,items.is" + a1 + " FROM items  ", conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.DataSource = dt;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.ReadOnly = false;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.ClearSelection();
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[2].Visible = false;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[3].HeaderCell.Value = "Name";
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[4].HeaderCell.Value = "Stock";
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[1].HeaderCell.Value = "";
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[1].Width = 50;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[0].HeaderCell.Value = "";
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[0].Width = 50;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Refresh();
                            }
                        }
                    }
                }

            }



            if (comboBox1.Text.Equals("") && textBox1.Text != "")
            {

                var a1 = "";
                if (comboBox2.Text.Equals("Damaged Beyond Repair"))
                {
                    a1 = "DamagedBeyondRepair";
                }
                if (comboBox2.Text.Equals(""))
                {
                    a1 = "Deployable";
                }
                else
                {
                    a1 = comboBox2.Text;
                }
                MySql.Data.MySqlClient.MySqlConnection conn = new MySqlConnection();
                string myConnectionString;
                myConnectionString = "server=127.0.0.1;"
        + "uid=root;"
        + "pwd=;"
        + "SslMode=none;"
        + "database=db";

                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.DefaultCellStyle.SelectionBackColor = (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.DefaultCellStyle.BackColor;
                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.DefaultCellStyle.SelectionForeColor = (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.DefaultCellStyle.ForeColor;
                conn.ConnectionString = myConnectionString;
                conn.Open();

                using (MySqlConnection con = new MySqlConnection(myConnectionString))
                {
                    using (MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("SELECT items.id,items.name,items.is" + a1 + " FROM items  where items.name like '%" + textBox1.Text + "%' ", conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.DataSource = dt;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.ReadOnly = false;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.ClearSelection();
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[2].Visible = false;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[3].HeaderCell.Value = "Name";
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[4].HeaderCell.Value = "Stock";
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[1].HeaderCell.Value = "";
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[1].Width = 50;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[0].HeaderCell.Value = "";
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[0].Width = 50;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Refresh();
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

                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.DefaultCellStyle.SelectionBackColor = (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.DefaultCellStyle.BackColor;
                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.DefaultCellStyle.SelectionForeColor = (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.DefaultCellStyle.ForeColor;
                conn.ConnectionString = myConnectionString;
                conn.Open();

                using (MySqlConnection con = new MySqlConnection(myConnectionString))
                {
                    using (MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("SELECT items.id,items.name,items.is" + a1 + ",items.tagID FROM items  where  items.tagID=" + comboBox1.SelectedIndex + 1, conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.DataSource = dt;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.ReadOnly = false;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.ClearSelection();
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[2].Visible = false;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[5].Visible = false;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[3].HeaderCell.Value = "Name";
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[4].HeaderCell.Value = "Stock";
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[1].HeaderCell.Value = "";
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[1].Width = 50;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[0].HeaderCell.Value = "";
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[0].Width = 50;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Refresh();
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

                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.DefaultCellStyle.SelectionBackColor = (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.DefaultCellStyle.BackColor;
                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.DefaultCellStyle.SelectionForeColor = (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.DefaultCellStyle.ForeColor;
                conn.ConnectionString = myConnectionString;
                conn.Open();

                using (MySqlConnection con = new MySqlConnection(myConnectionString))
                {
                    using (MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("SELECT items.id,items.name,items.is" + a1 + ",items.tagID FROM items  where items.name like '%" + textBox1.Text + "%' and items.tagID=" + comboBox1.SelectedIndex + 1 , conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.DataSource = dt;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.ReadOnly = false;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.ClearSelection();
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[2].Visible = false;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[5].Visible = false;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[3].HeaderCell.Value = "Name";
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[4].HeaderCell.Value = "Stock";
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[1].HeaderCell.Value = "";
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[1].Width = 50;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[0].HeaderCell.Value = "";
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[0].Width = 50;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Refresh();
                            }
                        }
                    }
                }

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var a1 = "";
            if (comboBox2.Text.Equals("Damaged Beyond Repair"))
            {
                a1 = "DamagedBeyondRepair";
            }
            else
            {
                a1 = comboBox2.Text;
            }
            var a = new Form1();
            if (comboBox2.Text.Equals("") && textBox1.Text.Equals(""))
            {
                MySql.Data.MySqlClient.MySqlConnection conn = new MySqlConnection();
                string myConnectionString;
                myConnectionString = "server=127.0.0.1;"
        + "uid=root;"
        + "pwd=;"
        + "SslMode=none;"
        + "database=db";

                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.DefaultCellStyle.SelectionBackColor = (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.DefaultCellStyle.BackColor;
                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.DefaultCellStyle.SelectionForeColor = (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.DefaultCellStyle.ForeColor;
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
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.DataSource = dt;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.ReadOnly = false;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.ClearSelection();
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[2].Visible = false;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[5].Visible = false;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[3].HeaderCell.Value = "Name";
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[4].HeaderCell.Value = "Stock";
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[1].HeaderCell.Value = "";
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[1].Width = 50;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[0].HeaderCell.Value = "";
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[0].Width = 50;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Refresh();
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

                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.DefaultCellStyle.SelectionBackColor = (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.DefaultCellStyle.BackColor;
                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.DefaultCellStyle.SelectionForeColor = (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.DefaultCellStyle.ForeColor;
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
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.DataSource = dt;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.ReadOnly = false;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.ClearSelection();
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[2].Visible = false;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[5].Visible = false;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[3].HeaderCell.Value = "Name";
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[4].HeaderCell.Value = "Stock";
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[1].HeaderCell.Value = "";
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[1].Width = 50;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[0].HeaderCell.Value = "";
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[0].Width = 50;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Refresh();
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

                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.DefaultCellStyle.SelectionBackColor = (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.DefaultCellStyle.BackColor;
                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.DefaultCellStyle.SelectionForeColor = (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.DefaultCellStyle.ForeColor;
                conn.ConnectionString = myConnectionString;
                conn.Open();

                using (MySqlConnection con = new MySqlConnection(myConnectionString))
                {
                    using (MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("SELECT items.id,items.name,items.is" + a1 + ",items.tagID FROM items  where  items.tagID=" + comboBox1.SelectedIndex + 1, conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.DataSource = dt;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.ReadOnly = false;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.ClearSelection();
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[2].Visible = false;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[5].Visible = false;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[3].HeaderCell.Value = "Name";
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[4].HeaderCell.Value = "Stock";
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[1].HeaderCell.Value = "";
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[1].Width = 50;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[0].HeaderCell.Value = "";
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[0].Width = 50;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Refresh();
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

                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.DefaultCellStyle.SelectionBackColor = (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.DefaultCellStyle.BackColor;
                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.DefaultCellStyle.SelectionForeColor = (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.DefaultCellStyle.ForeColor;
                conn.ConnectionString = myConnectionString;
                conn.Open();

                using (MySqlConnection con = new MySqlConnection(myConnectionString))
                {
                    using (MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("SELECT items.id,items.name,items.is" + a1 + ",items.tagID FROM items  where items.name like '%" + textBox1.Text + "%' and items.tagID=" + comboBox1.SelectedIndex + 1, conn))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                        {
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.DataSource = dt;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.ReadOnly = false;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.ClearSelection();
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[2].Visible = false;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[5].Visible = false;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[3].HeaderCell.Value = "Name";
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[4].HeaderCell.Value = "Stock";
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[1].HeaderCell.Value = "";
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[1].Width = 50;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[0].HeaderCell.Value = "";
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[0].Width = 50;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                                (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).dataGridView1.Refresh();
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

        private void button3_Click_2(object sender, EventArgs e)
        {
           
        }

       

      
    }

    
}
