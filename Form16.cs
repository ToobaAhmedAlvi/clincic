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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/dell/Documents/Database5.accdb");
        OleDbDataAdapter adap = new OleDbDataAdapter("select * from BMI", "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/dell/Documents/Database5.accdb");
        DataSet d1 = new DataSet("BMI");
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();

        }


        private void button9_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand com1 = new OleDbCommand("Insert into BMI(Weight,Height,Pname) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox4.Text + "')", con);
            com1.ExecuteNonQuery();

            OleDbCommand command = new OleDbCommand();
            command.Connection = con;

            string query = "select BMIval from BMI where  Weight='" + textBox1.Text + "'";
            command.CommandText = query;
            OleDbDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {

                textBox3.Text = reader["BMIval"].ToString();
            }
        }
        
        private void Form16_Load(object sender, EventArgs e)
        {
      
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
