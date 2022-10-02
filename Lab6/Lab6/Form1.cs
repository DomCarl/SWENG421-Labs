using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            /**
             * 
            int s = 25;
            int v = 1;
            Graphics g = this.panel1.CreateGraphics();
            Pen blackPen = new Pen(Color.Black, 3);
            SolidBrush sb = new SolidBrush(Color.Red);

            Rectangle r1 = new Rectangle(200, 130, 2 * s, 2 * s);
            Rectangle r2 = new Rectangle(100, 330, 2 * s, 2 * s);

            e.Graphics.DrawEllipse(blackPen, r1.X, r1.Y, r1.Width, r1.Height);
            e.Graphics.DrawEllipse(blackPen, r2.X, r2.Y, r2.Width, r2.Height);

            if (r1.Y > r2.Y)
            {
                v = -1;
            }

            double d = Cosine(new Point(r2.X - r1.X, r2.Y - r1.Y), new Point(v, 0));

            double x = r1.X + s + v * s * d;
            double y = r1.Y + s + v * s * Math.Sqrt(1 - d * d);

            double x2 = r2.X + s - v * s * d;
            double y2 = r2.Y + s - v * s * Math.Sqrt(1 - d * d);

            e.Graphics.DrawLine(blackPen, (int)x, (int)y, (int)x2, (int)y2);
            e.Graphics.FillEllipse(sb, (int)(x - 5), (int)(y - 5), 10, 10);

            Point p = Compute(new Point(r2.X - r1.X, r2.Y - r1.Y), Math.PI / 6);
            e.Graphics.DrawLine(blackPen, (int)x2, (int)y2, (int)x2 + p.X, (int)y2 + p.Y);
            p = Compute(new Point(r2.X - r1.X, r2.Y - r1.Y), - Math.PI / 6);
            e.Graphics.DrawLine(blackPen, (int)x2, (int)y2, (int)x2 + p.X, (int)y2 + p.Y);
            *
            */
        }
        
        public double Cosine(Point p1, Point p2)
        {
            double d0 = p1.X * p2.X + p1.Y * p2.Y;
            double d1 = Math.Sqrt(p1.X * p1.X + p1.Y * p1.Y);

            return d0 / d1;
        }

        public Point Compute(Point p1, double angle)
        {
            double d1 = Math.Sqrt(p1.X * p1.X + p1.Y * p1.Y);

            double x = -20 * p1.X / d1;
            double y = -20 * p1.Y / d1;

            double nx = x * Math.Cos(angle) - y * Math.Sin(angle);
            double ny = x * Math.Sin(angle) + y * Math.Cos(angle);

            return new Point((int)nx, (int)ny);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
