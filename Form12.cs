using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace GOClinic
{


    public partial class Form12 : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/dell/Documents/Database5.accdb");
        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {


            con.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = con;
            string query = "select * from Doctor";

            command.CommandText = query;
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader["DName"].ToString());

            }
            
        }
   




        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            OleDbCommand command = new OleDbCommand();
            command.Connection = con;
            string query = "select * from Doctor where DName='" + comboBox1.Text + "'";
            

            command.CommandText = query;
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())  //you can use if(condition) also instead of while loop
            {
                textBox1.Text = reader["DName"].ToString();
                textBox2.Text = reader["Phone"].ToString();
                textBox3.Text = reader["Speciality"].ToString();
                textBox4.Text = reader["Fees"].ToString();

                byte[] imgg = (byte[])(reader["Pic"]);
                if (imgg == null)
                {
                    pictureBox1.Image = null;
                }
                else
                {
                    MemoryStream ms = new MemoryStream(imgg);
                    pictureBox1.Image = System.Drawing.Image.FromStream(ms);
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            OleDbCommand command = new OleDbCommand();
            command.Connection = con;
            string query = "delete from Doctor where DName='" + comboBox1.Text + "'";
            command.CommandText = query;
            command.ExecuteNonQuery();
            MessageBox.Show(" THE DOCTOR HAS BEEN TERMINATED FROM FAMILY CLINIC");
            con.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
