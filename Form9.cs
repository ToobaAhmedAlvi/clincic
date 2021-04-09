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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
            panel1.Hide();

            panel2.Hide();
           
          
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/dell/Documents/Database5.accdb");

        private void Form9_Load(object sender, EventArgs e)
        {
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void button9_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = con;

            string query = "select * from Doctor where ID='" + textBox1.Text + "'";
            command.CommandText = query;
            OleDbDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                textBox2.Text = reader["DName"].ToString();
                textBox3.Text = reader["Email"].ToString();
                textBox4.Text = reader["Password"].ToString();
                textBox5.Text = reader["Address"].ToString();
                textBox6.Text = reader["Phone"].ToString();
                textBox7.Text = reader["Speciality"].ToString();
                textBox8.Text = reader["DOA"].ToString();
                textBox9.Text = reader["Fees"].ToString();
            }
                 else
            {
                textBox2.Text = " ";
                textBox3.Text = " ";
                textBox4.Text = " ";
                textBox5.Text = " ";
                textBox6.Text = " ";
                textBox7.Text = " ";
                textBox8.Text = " ";
                textBox9.Text = " ";
                MessageBox.Show("INCORRECT ID");
                }
            
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Hide();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OleDbCommand com2 = new OleDbCommand("DELETE FROM Appointment where DName = '" + textBox10.Text + " '", con);
            com2.ExecuteNonQuery();
            MessageBox.Show("One record has been deleted ");

        }

        private void button1_Click(object sender, EventArgs e)
        {

            panel1.Show();
 
        }

        private void button3_Click(object sender, EventArgs e)
        {  

        }
    

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
     
        private void button3_Click_1(object sender, EventArgs e)
        {
            panel2.Show();
            
           
                
            }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

            OleDbDataAdapter adapt = new OleDbDataAdapter("select * from Appointment where DName like '" + textBox10.Text + "%'", con);
            DataTable dt = new DataTable("Appointment");
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }
        
    
            


           
        
    
    


