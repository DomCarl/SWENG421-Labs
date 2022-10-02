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
            Graphics g = this.panel1.CreateGraphics();
            Pen blackPen = new Pen(Color.Black, 3);

            PointF p1 = new PointF(100.0F, 100.0F);
            PointF p2 = new PointF(500.0F, 200.0F);

            e.Graphics.DrawLine(blackPen, p1, p2);
        } 
    }
}
