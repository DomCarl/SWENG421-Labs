/**
 * Jason Cross and Dominick Carlucci
 * Form1.cs class
 * Due Date: 10/2/22 11:59 pm
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Lab6
{
    public partial class Form1 : Form
    {
        public Graph g;
        public Edge ed;
        public GraphManager gm = new GraphManager();
        int graphID;

        public Form1()
        {
            InitializeComponent();
            //gm = new GraphManager();

            button6.Hide();
            button7.Hide();
            button8.Hide();
            button9.Hide();
        }        

        private void button1_Click(object sender, EventArgs e)
        {
            int graphID = int.Parse(textBox1.Text);

            g = new Graph(graphID);
            gm.CreateGraph(g);

            for (int i = 0; i < gm.graphs.Count; i++)
            {
                MessageBox.Show("Graph ID: " + gm.graphs[i].id);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            graphID = int.Parse(textBox1.Text);

            for(int i = 0; i < gm.graphs.Count; i++)
            {
                if (gm.graphs[i].id == graphID)
                {
                    gm.CopyGraph(gm.graphs[i]);
                }
            }

            for (int i = 0; i < gm.graphs.Count; i++)
            {
                MessageBox.Show("Graph ID: " + gm.graphs[i].id);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button4.Hide();
            button5.Hide();
            button6.Hide();
            button7.Show();
            button8.Show();
            button9.Show();

            graphID = int.Parse(textBox1.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int vertID = int.Parse(textBox2.Text);
            int x = int.Parse(textBox3.Text);
            int y = int.Parse(textBox4.Text);
            Vertex v = new Vertex(vertID, x, y);
            g.AddVertex(v);

            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            int edgeID = int.Parse(textBox5.Text);
            int startID = int.Parse(textBox6.Text);
            int endID = int.Parse(textBox7.Text);
            Vertex startVert = null;
            Vertex endVert = null;

            foreach (Vertex v in g.GetVertices())
            {
                if (v.vertexNo == startID)
                {
                    startVert = v;
                }
                else if (v.vertexNo == endID)
                {
                    endVert = v;
                }
            }
            ed = new Edge(edgeID, startVert, endVert);
            g.AddEdge(ed);

            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            button6.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {            
            PaintEventArgs pea = new PaintEventArgs(panel1.CreateGraphics(), panel1.ClientRectangle);
            int s = 1;
            int v = 1;
            graphID = int.Parse(textBox1.Text);
            List<Rectangle> recs = new List<Rectangle>();
            Graphics gra = panel1.CreateGraphics();
            Pen blackPen = new Pen(Color.Black, 3);
            SolidBrush sb = new SolidBrush(Color.Red);

            for (int i = 0; i < gm.graphs.Count; i++)
            {
                if (gm.graphs[i].id == graphID)
                {
                    g = gm.graphs[i];
                }
            }

            for (int i = 0; i < g.vertices.Count; i++)
            {
                recs.Add(new Rectangle(g.vertices[i].x_coord, g.vertices[i].y_coord, 1, 1)); 
            }
            
            pea.Graphics.DrawEllipse(blackPen, recs[0].X, recs[0].Y, recs[0].Width, recs[0].Height);
            pea.Graphics.DrawEllipse(blackPen, recs[1].X, recs[1].Y, recs[1].Width, recs[1].Height);
            

            if (recs[0].Y > recs[1].Y)
            {
                v = -1;
            }

            double d = Cosine(new Point(recs[1].X - recs[0].X, recs[1].Y - recs[0].Y), new Point(v, 0));

            double x = recs[0].X + s + v * s * d;
            double y = recs[0].Y + s + v * s * Math.Sqrt(1 - d * d);

            double x2 = recs[1].X + s - v * s * d;
            double y2 = recs[1].Y + s - v * s * Math.Sqrt(1 - d * d);

            pea.Graphics.DrawLine(blackPen, (int)x, (int)y, (int)x2, (int)y2);
            pea.Graphics.FillEllipse(sb, (int)(x - 5), (int)(y - 5), 10, 10);

            Point p = Compute(new Point(recs[1].X - recs[0].X, recs[1].Y - recs[0].Y), Math.PI / 6);
            pea.Graphics.DrawLine(blackPen, (int)x2, (int)y2, (int)x2 + p.X, (int)y2 + p.Y);
            p = Compute(new Point(recs[1].X - recs[0].X, recs[1].Y - recs[0].Y), -Math.PI / 6);
            pea.Graphics.DrawLine(blackPen, (int)x2, (int)y2, (int)x2 + p.X, (int)y2 + p.Y);
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

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Text = "Enter vertex ID: ";
            label4.Text = "Enter vertex X: ";
            label5.Text = "Enter vertex Y: ";
            label6.Text = "Enter edge ID: ";
            label7.Text = "Enter edge start vertex ID: ";
            label8.Text = "Enter edge end vertex ID: ";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int VertNo = int.Parse(textBox2.Text);
            int newX = int.Parse(textBox3.Text);
            int newY = int.Parse(textBox4.Text);

            for (int i = 0; i < gm.graphs.Count; i++)
            {
                if (gm.graphs[i].id == graphID)
                {
                    g = gm.graphs[i];
                }
            }

            for(int i = 0; i < g.vertices.Count; i++)
            {
                if (g.vertices[i].vertexNo == VertNo)
                {
                    g.vertices[i].x_coord = newX;
                    g.vertices[i].y_coord = newY;
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int EdgeNo = int.Parse(textBox5.Text);
            int newStartID = int.Parse(textBox6.Text);
            int newEndID = int.Parse(textBox7.Text);
            Vertex newVertStart = null, newVertEnd = null;

            for (int i = 0;i < g.vertices.Count; i++)
            {
                if (g.vertices[i].vertexNo == newStartID)
                {
                    newVertStart = g.vertices[i];
                }

                else if (g.vertices[i].vertexNo == newEndID)
                {
                    newVertEnd = g.vertices[i];
                }
            }

            for (int i = 0; i < g.vertices.Count; i++)
            {
                if (g.edges[i].edgeNo == EdgeNo)
                {
                    g.edges[i].fromVert = newVertStart;
                    g.edges[i].toVert = newVertEnd;
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Hide();
            button6.Show();
        }
    }
}
