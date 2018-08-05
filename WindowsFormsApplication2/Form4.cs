using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace WindowsFormsApplication2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
           TextBox1.Text = (System.Windows.Forms.Application.OpenForms["Form3"] as Form3).Label2.Text;
           ComboBox1.SelectedText = (System.Windows.Forms.Application.OpenForms["Form3"] as Form3).Label4.Text;
           TextBox2.Text = (System.Windows.Forms.Application.OpenForms["Form3"] as Form3).Label6.Text;
           TextBox3.Text = (System.Windows.Forms.Application.OpenForms["Form3"] as Form3).Label8.Text;
           TextBox4.Text = (System.Windows.Forms.Application.OpenForms["Form3"] as Form3).Label13.Text;
           TextBox5.Text = (System.Windows.Forms.Application.OpenForms["Form3"] as Form3).Label14.Text;
           TextBox6.Text = (System.Windows.Forms.Application.OpenForms["Form3"] as Form3).Label15.Text;
           TextBox7.Text = (System.Windows.Forms.Application.OpenForms["Form3"] as Form3).Label16.Text;
           dep.Text = (System.Windows.Forms.Application.OpenForms["Form3"] as Form3).dep.Text;
           dbr.Text = (System.Windows.Forms.Application.OpenForms["Form3"] as Form3).dbr.Text;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MySql.Data.MySqlClient.MySqlConnection conn = new MySqlConnection();
            string myConnectionString;
            myConnectionString = "server=127.0.0.1;"
+ "uid=root;"
+ "pwd=;"
+ "SslMode=none;"
+ "database=db";
            conn.ConnectionString = myConnectionString;
            conn.Open();
           
             
                
                    if (TextBox1.Text == "")
                    {
                        MessageBox.Show("Dont leave name blank.", "Yep it exist. ",
   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        using (MySqlConnection con = new MySqlConnection(myConnectionString))
                        {
                            using (MySqlCommand cmd = new MySqlCommand(" UPDATE `db`.`items` SET `name`='" + TextBox1.Text + "',`stocks`=" + TextBox3.Text + ",`categoryID`=" + ComboBox1.SelectedIndex + 1 + ",`description`=" + TextBox2.Text + ",`isDeployable`=" + TextBox4.Text + ",`isDamaged`=" + TextBox5.Text + ",`isOnrepair`=" + TextBox6.Text + ",`isRented`=" + TextBox7.Text + ",`isDeployed`=" + dep.Text + ",`isDamagedBeyondRepair`=" + dbr.Text + " WHERE (`id` = '" + Form1.sendtext + "');", conn)) 
                            {
                                cmd.CommandType = CommandType.Text;
                                if (cmd.ExecuteNonQuery() > 0)
                                {
                                    MessageBox.Show("Successfully added to database.", "Yep it exist. ",
   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                                    this.Close();
                                    (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).refreshni();
                                }
                            }
                        }
                    }
              


            
            conn.Close();
        }
    }
}
