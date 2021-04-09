using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GOClinic
{
   
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            pictureBox2.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Show();

            label5.Text = "CLICK TO CONTINUE";
        }
      

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }
        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        { 

        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button7_Click(object sender, EventArgs e)
        { 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {
            label3.Hide();
            label4.Hide();
            label2.BackColor = Color.Purple;
            Form f8 = new Form8();
            f8.ShowDialog();
            label2.BackColor = DefaultBackColor;

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            label3.Show();
            label4.Show();
            label2.Hide();
            label3.Text = button5.Text;
            label4.Text = "\n>Be physically active every day. Eat a healthy diet rich in whole grains, lean protein, vegetables, and fruits.\n.>Reduce or avoid unhealthy saturated fats and trans fats.\n>Instead, use healthier monounsaturated and polyunsaturated fats.Don't drink sugar calories."
        + "Eat nuts\n>Avoid processed junk food(eat real food instead)\n>Don't fear coffee\n>Eat fatty fish\n>Get enough sleep\n>Take care of your gut health with probiotics and fiber\n>Drink some water, especially before meals";


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            label3.Show();
            label4.Show();
            label2.Hide();
            label3.Text = "ABOUT US";
            label4.Text = "Family clinic was founded in the year 1999. It’s been 20 years of our successful service towards the sufferings and diseases of the ailing people. We believe in firm commitment, honesty and devotion towards our patients.These are our core values on which we have led the foundation of family clinic.Family clinic caters to the needs of all the members of your family in a safe, secured and healthy environment, where you could not only come for your regular check - ups or tests but also specialized surgeries.We do not believe in revenue generation, our sole purpose is to earn the smiles and well-being of our patients.Our infrastructure has been designed by renowned engineers supervised by construction management team, and have been located on main M.A.Jinnah road near Child wall and sports academy. For further details and appointment, please log on to www.familyclinic.org.pk.";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            label3.Show();
            label4.Show();
            label2.Hide();
            label3.Text = button2.Text;
            label4.Text = "Our Highly devoted staff is 24/7 available\nCONTACT:0090-121233-34,0800-2334434\nE-mail:go_c@mail.com";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            label3.Show();
            label4.Show();
            label2.Hide();
            label3.Text = button3.Text;
            label4.Text = "Main Facilities include:\n\n>>X-ray Availability\n\n>>CT-Scan Availability\n\n>>BloodTest Availability\n\n>>Urine DR Test Availability\n\nand\n>>Ultrasound Availability  ";

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            label3.Show();
            label4.Show();
            label3.Text = button4.Text;
            label4.Text = "Our Clinics Consists of  renowned Doctors and staff in town";
            label2.Show();
            label2.Text = "VIEW DETAILS About CONSULTANTS";

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            label3.Show();
            label4.Show();
            label2.Hide();
            label3.Text = button6.Text;
            label4.Text = "\n\nNear ChildWall Sports And Academy on main MA Jinnah Road";
            pictureBox2.Show();

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            label2.Hide();
            label3.Text = null;
            label4.Text = null;
            pictureBox2.Hide();

        }

        private void label5_Click(object sender, EventArgs e)
        {
            label3.Hide();
            label4.Hide();
           
            Form f2 = new Form2();
            f2.Show();
        }
        int imageno = 1;
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (imageno == 8)
            {
                imageno = 1;
            }
            pictureBox3.ImageLocation = string.Format(@"C:\Users\dell\Documents\me\{0}.jpg", imageno);
            imageno++;
        }
    }
    }
    

