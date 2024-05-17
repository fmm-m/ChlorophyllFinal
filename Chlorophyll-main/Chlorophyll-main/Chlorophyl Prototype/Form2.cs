using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chlorophyl_Prototype
{
    public partial class Form2 : Form
    {
        public static int lessonNumber = 1;
        private void loadForm(Form f)
        {
            f.Owner = this;
            f.StartPosition = FormStartPosition.Manual;
            f.Location = this.Location;
            f.Show();
            this.Hide();
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Owner = this;
            f1.StartPosition = FormStartPosition.Manual;
            f1.Location = this.Location;
            f1.Show();
            this.Hide();


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            lessonNumber = 1;
            Form4 f4 = new Form4();
            loadForm(f4);
            

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            lessonNumber = 2;
            Form4 f4 = new Form4();
            loadForm(f4);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            lessonNumber = 3;
            Form4 f4 = new Form4();
            loadForm(f4);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            lessonNumber = 4;
            Form4 f4 = new Form4();
            loadForm(f4);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            lessonNumber = 5;
            Form4 f4 = new Form4();
            loadForm(f4);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            lessonNumber = 6;
            Form4 f4 = new Form4();
            loadForm(f4);
        }
    }
}
