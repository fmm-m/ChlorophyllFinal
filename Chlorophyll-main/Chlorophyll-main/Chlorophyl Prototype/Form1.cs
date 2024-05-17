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
    public partial class Form1 : Form
    {
        private void loadForm(Form f)
        {
            f.Owner = this;
            f.StartPosition = FormStartPosition.Manual;
            f.Location = this.Location;
            f.Show();
            this.Hide();
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            loadForm(f2);
        }
            
        private void button3_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            loadForm(f3);
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            loadForm(f4);
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
