using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Рисунок_3
{
    public partial class Form1 : Form
    {
        int kx = 50;
        int ky = 50;
        int dy;
        int dx;
        Bitmap graphBitmap;
        Graphics graphGraphics;
        public Form1()
        {

            InitializeComponent();
            dy = pictureBox1.Height / 2;
            dx = pictureBox1.Width / 2;
            pictureBox1.Paint += new PaintEventHandler(pictureBox1_Paint);

        }





        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (radioButtonHyperbola.Checked)
            {
                pictureBox1.Refresh();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            graphGraphics = e.Graphics;
            SolidBrush solidBrush = new SolidBrush(Color.White);
            graphGraphics.FillRectangle(solidBrush, 0, 0, pictureBox1.Width, pictureBox1.Height);
            Pen p3 = new Pen(Color.Black);
            p3.Width = 2;
            graphGraphics.DrawLine(p3, 0, dy, pictureBox1.Width, dy);
            graphGraphics.DrawLine(p3, dx, 0, dx, pictureBox1.Height);

            if (radioButtonSqrt.Checked)
            {
                DrawSqrtFunction();
            }
            else if (radioButtonHyperbola.Checked)
            {
                DrawHyperbola();
            }
        }

        private void DrawHyperbola()
        {
            double a = Convert.ToDouble(numericUpDown1.Value);
            Pen pen = new Pen(Color.Red);
            pen.Width = 3;
            Point[] points = new Point[0];
            int i = 0;
            for (double x = 0.1; x <= 10; x += 0.1)
            {
                Array.Resize(ref points, i + 1);
                double y = a / x;
                points[i] = new Point(Convert.ToInt32(x * kx) + dx, Convert.ToInt32(-y * ky) + dy);
                i++;
            }
            graphGraphics.DrawLines(pen, points);
        }

        private void DrawSqrtFunction()
        {
            Pen pen = new Pen(Color.Blue);
            pen.Width = 3;
            Point[] points = new Point[0];
            int i = 0;
            for (double x = 0.1; x <= 10; x += 0.1) 
            {
                Array.Resize(ref points, i + 1);
                double y = x * x; 
                points[i] = new Point(Convert.ToInt32(x * kx) + dx, Convert.ToInt32(-y * ky) + dy);
                i++;
            }
            graphGraphics.DrawLines(pen, points);
        }

    

        private void radioButtonHyperbola_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonSqrt_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonSqrt.Checked)
            {
                pictureBox1.Refresh();
            }
        }
    }
}
