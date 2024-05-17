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
    public partial class Form4 : Form
    {
        Dictionary<int, string> lessonHeaders = new Dictionary<int, string>();
        Dictionary<int, string> lessonContent = new Dictionary<int, string>();
        int imageReference = 0;
        List<string> imagesList = new List<string>();



        private void loadForm(Form f)
        {
            f.Owner = this;
            f.StartPosition = FormStartPosition.Manual;
            f.Location = this.Location;
            f.Show();
            this.Hide();
            
        }
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
            lessonHeaders.Add(1, "Lesson #1. What is programming?");
            lessonHeaders.Add(2, "Lesson #2. Interacting with the world");
            lessonHeaders.Add(3, "Lesson #3. Vegetables and Variables!");
            lessonHeaders.Add(4, "Lesson #4. Conditional statements: Don't kill anyone.");
            lessonHeaders.Add(5, "Lesson #5. Looping and Planting");


            lessonTitle.Text = lessonHeaders[Form2.lessonNumber];

            lessonContent.Add(1, "Welcome to Chlorophyll! And welcome to your very first Garden. Through the course of 6 lessons, you will learn how to quickly and efficiently plant, sort, and manage your Garden! \nWhen broken down into its core components, programming is a lot like gardening. \n\n To the right, there is a big ol' area, allowing you to drag and drop code blocks wherever you want. But for now, it just has some diagrams. Feel free to click through them!");
            lessonContent.Add(2, "When we want the computer to talk to you, we tell it to write something. This is like a plant fruiting, or leaves falling. It’s the plant saying ‘Hey, I’m ready to eat!’. When a computer does this, it simply writes out to the display. Everything you’re seeing here is the computer talking to the display to tell it what to output. It can do this in a variety of ways, same as a plant. It can show shapes or text, play sounds, or even be hooked up to motors to make them spin!\n");
            lessonContent.Add(3, "Imagine you have 5 packets of seeds. Carrot, Potato, Celery, Onion, and Cucumber. Each seed bag contains a different amount of seeds, maybe half-a-dozen carrot seeds, and 27 cucumber seeds! Finally, there's a little tag on it saying whether or not it's a root vegetable. Each of these parts represent a different type of data that a computer can interpret. \n\nThe Name of the vegetable is called a STRING (str). A string is any amount of text, from a single letter to an entire paragraph!\n\nThe Amount of seeds is called an INTEGER (int). An integer is a fancy computer term for any whole number, negative or positive.\n\nFinally, whether or not it's a root vegetable is called a BOOLEAN (bool). A Boolean value is either True or False, no inbetween.\nWhen we’re programming, we’re managing variables like these. Numbers or text that we can change and even send to the user if we want. If you wanted to make a counter that showed how many carrots you got, you could create a variable and store an integer showing the amount of carrots you received, increasing it’s value by one for each carrot you harvest.\n");
            lessonContent.Add(4, "Picture this: You’ve been preparing an amazing dinner. Meat and vegetables from all over the globe. Unfortunately, shortly after taking the first bite - everyone drops down dead. This is because you forgot to check IF these plants were edible, and sadly they weren’t. \nA main part of programming is making decisions based off of information you receive. You get used to reframing everything in terms of IF x happens, what do we do? If not, what do we do then?\n\nFor example. Imagine you have a massive table filled with a variety of objects to cook with. You could pick up something, double check its an edible vegetable, and if it is - chuck it in the stew! This could be framed as\n\nIF the object i picked up is a vegetable, then we check\n    IF the vegetable is edible, and if it is we put it in the stew.\nIf it wasn’t edible, or it wasn’t a vegetable, we decided not to. Try reframing a couple actions or decisions in your day-to-day life this way! It’s a good way to practise.\n");
            lessonContent.Add(5, "You have to plant 100 seeds before the end of the day, and you’re running low on time. Sure you could manually dig a hundred holes, separate a hundred seeds, fill in a hundred holes, etcetera, or you could make something to do all that for you, a hundred times.\nFor loops are a powerful tool in programming. There’s a concept in code where you aim to repeat the same thing as little as possible. Instead of, for example, writing\ndig_hole(1);\ndig_hole(2);\n, etcetera, you’d make a loop to do it all for you. This is phrased as doing something FOR every thing, in something else. For example, you can dig a hole, for every hole you’ve been asked to dig. Or, you could output to the screen a colour that gets brighter every second. There are heaps of opportunities!\n");


            content.Text = lessonContent[Form2.lessonNumber];

            if (Form2.lessonNumber == 1)
            {
                imagesList.Add(@"C:\Users\tobyb\Downloads\Chlorophyll-main\Chlorophyll-main\Chlorophyl Prototype\Resources\L1_diagram2.png");
                imagesList.Add(@"C:\Users\tobyb\Downloads\Chlorophyll-main\Chlorophyll-main\Chlorophyl Prototype\Resources\L1_diagram.png");
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            loadForm(f1);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            imageReference++;
            if (imageReference == imagesList.Count)
            {
                imageReference = 0;
            }
            if (imagesList.Count > 0)
            {
                pictureBox1.Image = Image.FromFile(imagesList[imageReference]);
            }

        }
    }
}
