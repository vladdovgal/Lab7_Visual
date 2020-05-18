using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Graphics g;
        Pen p;

        Point p1;
        Point p2;

        int y_start = 100;
        int y_length = 200;

        double increment = 0;
        double current = 255;

        private void Form1_load(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            p = new Pen(Brushes.Red);

            p1 = Point.Empty;
            p2 = Point.Empty;

            p1.X = 100;
            p2.X = 500;

            increment = current / (double)y_length;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i = y_start; i < y_start + y_length; i++)
            {
                p1.Y = i;
                p2.Y = i;

                g.DrawLine(p, p1, p2);

                p.Color = Color.FromArgb((int)current, p.Color);
                current -= increment;
            }
        }

        private void colourbtn1_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
            {
                colourbox1.BackColor = colorDialog1.Color;
            }
        }

        private void colourbtn2_Click(object sender, EventArgs e)
        {
            if (colorDialog2.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
            {
                colourbox2.BackColor = colorDialog2.Color;
            }
        }
    }
}
