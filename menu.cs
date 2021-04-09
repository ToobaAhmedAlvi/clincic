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
    public partial class Form2 : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/dell/Documents/Database5.accdb");
       
        public Form2()
        {
            InitializeComponent();
            panel1.Hide();
            panel2.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Hide();
            panel1.Show();
          
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Show();
            string id = maskedTextBox1.Text;
            string password = maskedTextBox2.Text;
            if (id == "i25" && password == "123")
            {
                MessageBox.Show("Login Successful!");
                Form f3 = new Form3();
                f3.Show();
            }
            else MessageBox.Show("SORRY~Incorrect Id or Password");
            maskedTextBox1.Text="";
            maskedTextBox2.Text="";
        }
                private void button5_Click(object sender, EventArgs e)
        {
           
       
            Form15 f15 = new Form15();
            f15.Show();
            
           
    
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            panel1.Hide();
            panel2.Show();
        }
        int counter = 0;
        private void Form2_Load(object sender, EventArgs e)
        {
            con.Open();
            
         

        }

        private void button7_Click(object sender, EventArgs e)
        {

                OleDbCommand command = new OleDbCommand();
                command.Connection = con;
               // command.CommandText = "select * from Table where Dmail='" + maskedTextBox4.Text+ "' and dpass='" + maskedTextBox3.Text + "'";
               command.CommandText="select * from Doctor where ID='" + maskedTextBox4.Text + "'and Password='" + maskedTextBox3.Text + "'";
                OleDbDataReader reader = command.ExecuteReader();
                int counter = 0;
                while (reader.Read())
                {
                    counter = counter + 1;


                }
                if (counter == 1)
                {
                    MessageBox.Show("\tLogin successful!!\nYou ve been Logged in As DOCTOR ");
                    Form f9 = new Form9();
                    f9.Show();
                }
            
            else if (counter != 1)
            {
                
                if (reader.Read() == false)
                {
                    OleDbCommand command1 = new OleDbCommand();
                    command1.Connection = con;
                    command1.CommandText = "select * from Patient  where puser='" + maskedTextBox4.Text + "' and ppass='" + maskedTextBox3.Text + "'";

                    OleDbDataReader reader1 = command1.ExecuteReader();
                    int counter1 = 0;
                    while (reader1.Read())
                    {
                        counter1 = counter1 + 1;


                    }
                    if (counter1 == 1)
                    {
                        MessageBox.Show("\tLogin successful\nYou ve been Logged in As PATIENT ");
                        Form f10 = new Form10();
                        f10.Show();
                    }
                    else if (counter != 1)
                        MessageBox.Show("Incorrect ID or Password");
                }
            }
            maskedTextBox3.Text = "";
            maskedTextBox4.Text = "";
            panel2.Hide();
           
                
           }
        
        

       
        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form f4 = new Form4();
            f4.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form f5 = new Form5();
            f5.Show();

        }
    }
}
