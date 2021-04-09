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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            dataGridView1.Hide();
            button4.Hide();
            textBox2.Hide();

        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/dell/Documents/Database5.accdb");

        private void button1_Click(object sender, EventArgs e)
        {
            Form f12 = new Form12();
            f12.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f13 = new Form13();
            f13.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Show();
            button4.Show();
            textBox2.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = con;
            
            string query = "select * from staff";
            command.CommandText = query;
            OleDbDataAdapter adap = new OleDbDataAdapter(command);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            dataGridView1.DataSource = dt;
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBox2.Text = row.Cells[0].Value.ToString();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        { 
            OleDbCommand command = new OleDbCommand();
            command.Connection = con;
            string query = "delete from staff where sname='" + textBox2.Text + "'";
            command.CommandText = query;
            command.ExecuteNonQuery();
            MessageBox.Show(" THE STAFF HAS BEEN TERMINATED FROM FAMILY CLINIC");
            con.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
