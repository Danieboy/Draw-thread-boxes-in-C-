using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Draw_thread_boxes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            random = new Random();
        }

        Thread rThread;
        Thread bThread;
        Thread gThread;
        Random random;

        private void button1_Click(object sender, EventArgs e)
        {
            rThread = new Thread(redThread);
            rThread.Start();
        }

        public void redThread()
        {
            for (int i = 0; i < 75; i++)
            {
                    this.CreateGraphics().DrawRectangle(new Pen(Brushes.Red, 4), new Rectangle(random.Next(0, this.Width), (random.Next(0, this.Height)), 20, 20));
                    Thread.Sleep(75);
            }

            MessageBox.Show("Completed Drawing 75 Red Boxes.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bThread = new Thread(blueThread);
            bThread.Start();
        }

        public void blueThread()
        {
            for (int i = 0; i < 100; i++)
            {
                this.CreateGraphics().DrawRectangle(new Pen(Brushes.Blue, 4), new Rectangle(random.Next(0, this.Width), (random.Next(0, this.Height)), 20, 20));
                Thread.Sleep(50);
            }

            MessageBox.Show("Completed Drawing 100 Blue Boxes.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                gThread = new Thread(greenThread);
                gThread.Start();
            }
        }

        public void greenThread()
        {
            for (int i = 0; i < 25; i++)
            {
                this.CreateGraphics().DrawRectangle(new Pen(Brushes.Green, 8), new Rectangle(random.Next(0, this.Width), (random.Next(0, this.Height)), 20, 20));
                Thread.Sleep(200);
            }

            MessageBox.Show("Completed Drawing 25 Green Boxes.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
