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
    public partial class Form3 : Form
    {
        private void loadForm(Form f)
        {
            f.Owner = this;
            f.StartPosition = FormStartPosition.Manual;
            f.Location = this.Location;
            f.Show();
            this.Hide();

        }
        public Form3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            loadForm(f1);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
