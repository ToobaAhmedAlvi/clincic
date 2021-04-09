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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            label9.Hide();
            textBox6.Hide();
            button9.Hide();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/dell/Documents/Database5.accdb");
        OleDbDataAdapter adap = new OleDbDataAdapter("select * from Others", "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/dell/Documents/Database5.accdb;");
        DataSet d1 = new DataSet("Others");

        private void button8_Click(object sender, EventArgs e)
        {
            panel1.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Show();
            textBox4.Text = "400";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Show();
            textBox4.Text = "500";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel1.Show();
            textBox4.Text = "600";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Show();
            textBox4.Text = "700";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Show();
            textBox4.Text = "800";
        }

        private void button4_Click(object sender, EventArgs e)
        {

            this.Close();
           
            Form1 f1 = new Form1();
            Form2 f2 = new Form2();
            //Form f3 = new Form3();
         
            f1.Show();
            
            f2.Close();
            
            

        }

        private void button7_Click(object sender, EventArgs e)
        {

       
            if (textBox4.Text == textBox5.Text)
            {
                OleDbCommand com1 = new OleDbCommand("Insert into Others(Oname,AccNo,Omail,Opayment) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox5.Text + "')", con);
                com1.ExecuteNonQuery();
                MessageBox.Show("The Payment is Charged From Yr Account..\n Yr Reports will be soon mailed at your given id..THANKYOU");
            }
            else
                MessageBox.Show("Please Enter the Correct Amount");
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            panel1.Hide();
            con.Open();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            
            OleDbCommand command = new OleDbCommand();
            command.Connection = con;
            string query = "select pname,puser from Patient where puser='" + textBox6.Text + "'";
            command.CommandText = query;
           OleDbDataReader Reader = command.ExecuteReader();
            while (Reader.Read())
            {
                textBox3.Text = (Reader["puser"].ToString());

                textBox1.Text = (Reader["pname"].ToString());
                MessageBox.Show("Correct");
                
                
            }
            
            
            
        }

        private void label8_Click(object sender, EventArgs e)
        {
            label9.Show();
            textBox6.Show();
            button9.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
