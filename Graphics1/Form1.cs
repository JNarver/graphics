using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphics1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public double Func(double x, double eps)
        {
            double sum = 1, t = 1;

            while (Math.Abs(t) >= eps)
            {
                t *= -(x * x);
                sum += t;
            }

            return sum;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            /*Graphics g = pictureBox1.CreateGraphics();
            Pen myPen = new Pen(Color.Blue);
            int interval = 100;
            float xmin = 0; float xmax = 5; float ymin = 0; float ymax = 5;
            float step = (xmax - xmin) / interval;
            float kx = pictureBox1.Width / xmax, ky = pictureBox1.Height / ymax;
            float x1 = xmin, y1 = x1 * x1, x2, y2;
            for (int i = 0; i<interval; i++)
            {
                x2 = x1 + step;
                y2 = x2 * x2;
                g.DrawLine(myPen, kx * x1, pictureBox1.Height - ky * y1, kx * x2, pictureBox1.Height - ky * y2);
                x1 = x2;
                y1 = y2;
            }*/
            Graphics g = pictureBox1.CreateGraphics();
            Brush aBrush = (Brush)Brushes.Black;
            float x = -760;
            float y = (float)Math.Atan(x);
            while (x <= -1.0001)
            {
                y = (float)Math.Atan(x);
                g.FillRectangle(aBrush, x, y, 3, 3);
                x += (float)0.025;
            }
            x = (float)1.0001;
            y = (float)Math.Atan(x);
            while (x <= 760)
            {
                y = (float)Math.Atan(x);
/*                PointF point1 = new PointF(x, y);
                PointF point2 = PointF.Add(point1, new Size(250, 0));*/
                g.FillRectangle(aBrush, x, y, 3, 3);
                x += (float)0.025;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
