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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
            timer2.Stop();
            timer1.Start();
        }

        private void Form14_Load(object sender, EventArgs e)
        {        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(20);
            if (this.progressBar1.Value == 20)
            {
                label1.ForeColor = Color.DarkOliveGreen;
                label1.Text = "Loading modules...";
            }
            if (this.progressBar1.Value == 40)
            {
                label1.ForeColor = Color.Red;
                label1.Text = "Loading Data... ";
            }
            if (this.progressBar1.Value == 60)
            {
                label1.ForeColor = Color.Blue;
                label1.Text = "Loading MainPage...";
            }
            if (this.progressBar1.Value == 80)
            {
                label1.ForeColor = Color.Maroon;
                label1.Text = "Please Wait...\n>>Things Are getting Ready!!";

            }

            if (this.progressBar1.Value == 100)
            {
                {
                    label1.ForeColor = Color.Black;
                    label1.Text = "LOAD COMPLETED!!";
                    timer1.Stop();
                    timer2.Start();
                }

            }
           
           

        }
    
        
        

    


        

        private void Form14_Enter(object sender, EventArgs e)
        { 
            
        }

        private void label1_load(object sender, EventArgs e)
        {
            
        }

        private void Form14_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void label1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Form f1 = new Form1();
            f1.Show();
            base.Hide();
            timer2.Stop();

        }
    }
}
