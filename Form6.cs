using System;
using System.Drawing.Imaging;
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
using Microsoft.VisualBasic;

namespace GOClinic
{
    public partial class Form6 : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/dell/Documents/Database5.accdb");
        public Form6()
        { 
            InitializeComponent();
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            BackgroundImageLayout = ImageLayout.Stretch;
           
        }


       
            private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
            private void button6_Click(object sender, EventArgs e)
        {
            byte[] imagebt = null;
            FileStream fs = new FileStream(this.textloc.Text, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            imagebt = br.ReadBytes((int)fs.Length);

            con.Open();
            //OleDbCommand com1 = new OleDbCommand("Insert into Appointment(pname,DName,fee,DOA,Speciality,Id) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + comboBox1.Text + "','" + textBox5.Text + "')", con);
            OleDbCommand com3 = new OleDbCommand("INSERT INTO Doctor(ID,DName,Email,[Password],Phone,Speciality,DOA,Fees,Address,Pic) values('" + textBox8.Text + "','" + textBox1.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox2.Text + "','" + comboBox1.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox3.Text + "',@IMG)", con);
            com3.Parameters.Add(new OleDbParameter("@IMG", imagebt));
            com3.ExecuteNonQuery();
            MessageBox.Show("Dear Doctor,You re now registered at Family CLinic..You now can login to see your Id and take Appointments.THANKYOU");
            con.Close();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            con.Open();
           
           //student-> table name in stud.accdb/stud.mdb file
  
            
            OleDbCommand command = new OleDbCommand();
            command.Connection = con;
            string query = "select Speciality from Doctor ";
            command.CommandText = query;
            OleDbDataReader Reader = command.ExecuteReader();
            while (Reader.Read())
            {
                comboBox1.Items.Add(Reader["Speciality"].ToString());
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random ran = new Random();
            int ranno = ran.Next(0, 10000);
            textBox8.Text = ranno.ToString();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
