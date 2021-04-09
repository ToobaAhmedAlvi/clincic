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
    public partial class Form13 : Form
    {
        public Form13()
        { 
            InitializeComponent();
            panel2.Hide();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/dell/Documents/Database5.accdb");
        private void Form13_Load(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = con;
            string query = "select * from Patient";

            command.CommandText = query;
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader["puser"].ToString());


            }
            

         
            OleDbCommand command1 = new OleDbCommand();
            command1.Connection = con;
            string query1 = "select * from Appointment " ;

            command1.CommandText = query1;
            OleDbDataReader reader1 = command1.ExecuteReader();
            while (reader1.Read())
            {
                comboBox2.Items.Add(reader1["Id"].ToString());


            }
          


        }

    

     
        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            OleDbCommand command = new OleDbCommand();
            command.Connection = con;
            string query = "select * from Patient where puser='" + comboBox1.Text + "'";
        
            command.CommandText = query;
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())  //you can use if(condition) also instead of while loop
            {
                textBox5.Text = reader["pname"].ToString(); 
                textBox2.Text = reader["pphone"].ToString();
                textBox3.Text = reader["DOB"].ToString();
                textBox4.Text = reader["puser"].ToString();
         


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
            string query = "delete from Patient where puser='" + comboBox1.Text + "'";
            command.CommandText = query;
            command.ExecuteNonQuery();
            MessageBox.Show(" THE PATIENT HAS BEEN TERMINATED FROM FAMILY CLINIC");
           

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
         
            OleDbCommand command = new OleDbCommand();
            command.Connection = con;
            string query = "select * from Appointment where Id='"+comboBox2.Text+"'";

            command.CommandText = query;
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())  //you can use if(condition) also instead of while loop
            {
                textBox6.Text = reader["DOA"].ToString();
                textBox1.Text = reader["pname"].ToString();
                textBox7.Text = reader["DName"].ToString();
            }
           
            }

        private void label8_Click(object sender, EventArgs e)
        {
            panel2.Show();
        }
    }
}
