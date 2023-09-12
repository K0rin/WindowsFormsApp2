using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Text = "King of Clubs";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Text = "King of Hearts";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Text = "Jack of Spades";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Text = "Jack of Hearts";
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            pictureBox4.Visible = false;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Text = "Jack of Hearts was hidden";
            button4.Click -= new EventHandler(button4_Click_1);
            button4.Click += new EventHandler(button4_Click_2);
            button4.TextAlign = ContentAlignment.MiddleCenter;
            button4.Text = "Showe me";
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            pictureBox4.Visible = true;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Text = "Jack of Hearts was showned";
            button4.Click += new EventHandler(button4_Click_1);
            button4.Click -= new EventHandler(button4_Click_2);
            button4.TextAlign = ContentAlignment.MiddleCenter;
            button4.Text = "Hide Me";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Text = "Jack of Spades was hidden";
            button3.Click -= new EventHandler(button3_Click);
            button3.Click += new EventHandler(button3_Click2);
            button3.TextAlign = ContentAlignment.MiddleCenter;
            button3.Text = "Showe Me";
        }

        private void button3_Click2(object sender, EventArgs e)
        {
            pictureBox3.Visible = true;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Text = "Jack of Spades was showned";
            button3.Click += new EventHandler(button3_Click);
            button3.Click -= new EventHandler(button3_Click2);
            button3.TextAlign = ContentAlignment.MiddleCenter;
            button3.Text = "Hide Me";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Text = "King of Hearts was hidden";
            button2.Click -= new EventHandler(button2_Click);
            button2.Click += new EventHandler(button2_Click2);
            button2.TextAlign = ContentAlignment.MiddleCenter;
            button2.Text = "Showe Me";
        }

        private void button2_Click2(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Text = "King of Hearts was showned";
            button2.Click += new EventHandler(button2_Click);
            button2.Click -= new EventHandler(button2_Click2);
            button2.TextAlign = ContentAlignment.MiddleCenter;
            button2.Text = "Hide Me";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Text = "King of Clubs was hidden";
            button1.Click -= new EventHandler(button1_Click);
            button1.Click += new EventHandler(button1_Click2);
            button1.TextAlign = ContentAlignment.MiddleCenter;
            button1.Text = "Showe Me";
        }

        private void button1_Click2(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Text = "King of Clubs was showned";
            button1.Click += new EventHandler(button1_Click);
            button1.Click -= new EventHandler(button1_Click2);
            button1.TextAlign = ContentAlignment.MiddleCenter;
            button1.Text = "Hide Me";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
