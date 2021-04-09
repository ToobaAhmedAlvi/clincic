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
using System.IO;

namespace GOClinic
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            
            InitializeComponent();
            label5.Hide();
            button7.Hide();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/dell/Documents/Database5.accdb");
        OleDbDataAdapter adap = new OleDbDataAdapter("select * from Patient", "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/dell/Documents/Database5.accdb");
        DataSet d1 = new DataSet("Patient");

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] imagebt = null;
            FileStream fs = new FileStream(this.textloc.Text, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            imagebt = br.ReadBytes((int)fs.Length);

            OleDbCommand com1 = new OleDbCommand("Insert into Patient(puser,ppass,pname,pphone,DOB,Pic) values('" + textBox6.Text + "','" + textBox7.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "',@IMG)", con);
            com1.Parameters.Add(new OleDbParameter("@IMG", imagebt));
            com1.ExecuteNonQuery();
            MessageBox.Show("DearPatient,\n\tyou re registered now @FAMILY CLINIC.You are now able to Avail the facilities\n.THANKYOU");
            button7.Show();
            label5.Show();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            con.Open();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form11 f11 = new Form11();
            f11.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select Image";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string picloc = ofd.FileName.ToString();
                textloc.Text = picloc;
                pictureBox1.ImageLocation = picloc;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
