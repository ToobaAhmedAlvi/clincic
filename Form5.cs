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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            panel1.Hide();
            string[] data = new string[2];
            data[0] = "Nurse";
            data[1] = "Compounder";
            comboBox1.Items.AddRange(data);
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/dell/Documents/Database5.accdb");
        OleDbDataAdapter adap = new OleDbDataAdapter("select * from staff", "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/dell/Documents/Database5.accdb");
        DataSet d1 = new DataSet("staff");

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            panel1.Show();
           
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OleDbCommand com2 = new OleDbCommand("Insert into staff(sname,smail,Occupation,contact) values('" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.Text + "','" + textBox4.Text + "')", con);
            com2.ExecuteNonQuery();
            if (comboBox1.Text == "Nurse")
                MessageBox.Show(" Congratulations!!You Have Now Become a Registered Nurse at FAMILY CLINIC \n\t STAFFMEMBERASSOCIATON");
            else
                MessageBox.Show(" Congratulations!!You Have Now Become a Registered Compounder at FAMILY CLINIC\n\t STAFFMEMBERASSOCIATON ");
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            con.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f6 = new Form6();
            f6.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f7 = new Form7();
            f7.Show();
        }
    }
}
