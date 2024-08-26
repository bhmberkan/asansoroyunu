using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asansoroyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            stop();
            timer4.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            stop();
            timer3.Start();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            stop();
            timer2.Start();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            stop();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Top<238)
            { pictureBox1.Top += 1;
            if(pictureBox1.Top>238)
                { timer1.Stop(); }      
                        
            }
            if (pictureBox1.Top > 238)
            {
                pictureBox1.Top -= 1;
                if (pictureBox1.Top == 238)
                { timer1.Stop(); }

            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Top < 192)
            {
                pictureBox1.Top += 1;
                if (pictureBox1.Top > 192)
                { timer1.Stop(); }

            }
            if (pictureBox1.Top > 192)
            {
                pictureBox1.Top -= 1;
                if (pictureBox1.Top == 192)
                { timer1.Stop(); }

            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Top < 128)
            {
                pictureBox1.Top += 1;
                if (pictureBox1.Top > 128)
                { timer1.Stop(); }

            }
            if (pictureBox1.Top > 128)
            {
                pictureBox1.Top -= 1;
                if (pictureBox1.Top == 128)
                { timer1.Stop(); }

            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Top < 78)
            {
                pictureBox1.Top += 1;
                if (pictureBox1.Top == 78)
                { timer1.Stop(); }

            }
            if (pictureBox1.Top > 78)
            {
                pictureBox1.Top -= 1;
                if (pictureBox1.Top == 78)
                { timer1.Stop(); }

            }
       }
        private void stop()
        {   timer1.Stop();
            timer2.Stop();
            timer3.Stop();
            timer4.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            stop();
            timer4.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            stop();
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 30;
            timer2.Interval = 30;
            timer3.Interval = 30;
            timer4.Interval = 30;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            stop();
        }
    }
}
