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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
            panel1.Hide();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/dell/Documents/Database5.accdb");
        private void button1_Click(object sender, EventArgs e)
        {
            Random ran = new Random();
            int ranno = ran.Next(0, 10000);
            textBox5.Text = ranno.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
            OleDbCommand com1 = new OleDbCommand("Insert into Appointment(pname,DName,fee,DOA,Speciality,Id) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','"  +comboBox1.Text + "','" + textBox5.Text + "')", con);
            com1.ExecuteNonQuery();
            MessageBox.Show("Your Appointment Has Been Booked..\n ..THANKYOU");
         
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
       
            OleDbCommand command = new OleDbCommand();
            command.Connection = con;
            string query = "select * from Doctor where Speciality='" + comboBox1.Text + "'";
            command.CommandText = query;
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
        
                textBox2.Text = reader["DName"].ToString();
                textBox4.Text = reader["DOA"].ToString();
                textBox3.Text = reader["Fees"].ToString();




            }
           


        }

        private void Form11_Load(object sender, EventArgs e)
        {


            con.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = con;
            string query = "select  Speciality from Doctor ";
            command.CommandText = query;
            OleDbDataReader Reader = command.ExecuteReader();
            while (Reader.Read())
            {
                comboBox1.Items.Add(Reader["Speciality"].ToString());
            }
            
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            comboBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form f4 = new Form4();
            f4.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form f16 = new Form16();
            f16.Show();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
           
            OleDbCommand command = new OleDbCommand();
            command.Connection = con;
            string query = "select * from Patient where puser='" + textBox6.Text + "'";
            command.CommandText = query;
            
            OleDbDataReader Reader = command.ExecuteReader();
            while (Reader.Read())
            {


                textBox1.Text = (Reader["pname"].ToString());
                MessageBox.Show("Correct");

                
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Family Clinic\t\n--------------------------------------------------------------------------------------------------------", new Font("TimesNewRoman", 36, FontStyle.Regular), Brushes.DarkBlue, new Point(25, 100));
            e.Graphics.DrawString("\tPatient Name:\t" + textBox1.Text + "", new Font("TimesNewRoman", 14, FontStyle.Regular), Brushes.Black, new Point(25, 300));
            e.Graphics.DrawString("\tAppointment   ID:\t" + textBox5.Text + "", new Font("TimesNewRoman", 14, FontStyle.Regular), Brushes.Black, new Point(25, 400));
            e.Graphics.DrawString("\tDate:\t" + DateTime.Now + "", new Font("TimesNewRoman", 14, FontStyle.Regular), Brushes.Black, new Point(25, 500));
            e.Graphics.DrawString("\tDoctor Name:\t" + textBox2.Text + "", new Font("TimesNewRoman", 14, FontStyle.Regular), Brushes.Black, new Point(25, 600));
            e.Graphics.DrawString("\tDay of Appointment:\t" + textBox4.Text + "", new Font("TimesNewRoman", 14, FontStyle.Regular), Brushes.Black, new Point(25, 700));
            e.Graphics.DrawString("\tFees:\t" + textBox3.Text + "", new Font("TimesNewRoman", 14, FontStyle.Regular), Brushes.Black, new Point(25, 800));
        }

        private void button9_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
    }
}
