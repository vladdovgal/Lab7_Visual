using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;

namespace Lab7
{
    public partial class Form1 : Form
    {
        private FigureSettings settings;
        private readonly SvgService svgService = new SvgService();

        public Form1()
        {
            InitializeComponent();
            settings = FigureSettings.Empty(pictureBox1.Bounds.Size);

            numericUpDown1.Maximum = pictureBox1.Width;
            numericUpDown1.Value = settings.Dimensions.Width;
            numericUpDown2.Maximum = pictureBox1.Height;
            numericUpDown2.Value = settings.Dimensions.Height;
            colourbox1.BackColor = settings.ColorFrom;
            colourbox2.BackColor = settings.ColorTo;
        }
 

        private void button1_Click(object sender, EventArgs e)
        {
            using (Graphics gr = pictureBox1.CreateGraphics())
            {
                var rectangleSvg = svgService.RectangleToSVG(settings, pictureBox1.Width, pictureBox1.Height);
                svgService.RenderRectangle(gr, rectangleSvg);
            }
        }

        private void colourbtn1_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
            {
                colourbox1.BackColor = colorDialog1.Color;
                settings.ColorFrom = colorDialog1.Color;
            }
        }

        private void colourbtn2_Click(object sender, EventArgs e)
        {
            if (colorDialog2.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
            {
                colourbox2.BackColor = colorDialog2.Color;
                settings.ColorTo = colorDialog2.Color;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            settings.Dimensions.Width = Convert.ToInt32(numericUpDown1.Value);
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            settings.Dimensions.Height = Convert.ToInt32(numericUpDown2.Value);
        }
    }
}
