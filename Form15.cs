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
    public partial class Form15 : Form
    {
        
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/dell/Documents/Database5.accdb");
        public Form15()
        {
            InitializeComponent();
        }
        

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form15_Load(object sender, EventArgs e)
        {
            string[] data = new string[8];
            data[0] = "Antipyretics";
            data[1] = "Cough & Flu";
            data[2] = "Painkiller";
            data[3] = "AntiBiotics";
            data[4] = "Calcium";
            data[5] = "Diarrhea";
            data[6] = "AntiAllergic";
            data[7] = "Multivitamin";
            comboBox1.Items.AddRange(data);
            con.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = con;
            string query = "select Medicine,Type,Availability from Pharmacy";
            command.CommandText = query;
            OleDbDataAdapter adap = new OleDbDataAdapter(command);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            OleDbDataAdapter adapt = new OleDbDataAdapter("select * from Pharmacy where Medicine like '" + textBox1.Text + "%'", con);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand com = new OleDbCommand();
            com.Connection = con;
            string query2 = "select Medicine,Type,Availability from Pharmacy where Type='" + comboBox1.Text + "'";
            com.CommandText = query2;
            OleDbDataAdapter adap1 = new OleDbDataAdapter(com);
            DataTable dt1 = new DataTable();
            adap1.Fill(dt1);
            dataGridView1.DataSource = dt1;
            con.Close();
        }
    }
}
