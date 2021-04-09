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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/dell/Documents/Database5.accdb");

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = con;
            string query = "select * from Doctor ";
            command.CommandText = query;
            OleDbDataReader Reader = command.ExecuteReader();
            while (Reader.Read())
            {
                ListViewItem item = new ListViewItem(Reader["ID"].ToString());
                item.SubItems.Add(Reader["DName"].ToString());
                item.SubItems.Add(Reader["Speciality"].ToString());
                item.SubItems.Add(Reader["DOA"].ToString());
                item.SubItems.Add(Reader["Fees"].ToString());
                listView1.Items.Add(item);
            }
            con.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
