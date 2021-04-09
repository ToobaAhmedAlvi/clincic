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

namespace GOClinic
{
    public partial class Form10 : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/dell/Documents/Database5.accdb");
        public Form10()
        {
            
            InitializeComponent();
            panel1.Hide();
            panel2.Hide();
        }

        private void Form10_Load(object sender, EventArgs e)
        { }


        private void button9_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = con;

            string query = "select * from Patient where puser='" + textBox1.Text + "'";
            command.CommandText = query;
            OleDbDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                textBox2.Text = reader["pname"].ToString();
                textBox3.Text = reader["pphone"].ToString();
                textBox4.Text = reader["ppass"].ToString();
                textBox5.Text = reader["DOB"].ToString();
              
            }
            else
            {
                textBox2.Text = " ";
                textBox3.Text = " ";
                textBox4.Text = " ";
                textBox5.Text = " ";
              
                MessageBox.Show("INCORRECT ID");
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Show();
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Hide();
            panel1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form f11 = new Form11();
            f11.Show();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {    
            OleDbDataAdapter adapt = new OleDbDataAdapter("select * from Appointment where pname like '" + textBox6.Text + "%'", con);
            DataTable dt = new DataTable("Appointment");
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
    }

