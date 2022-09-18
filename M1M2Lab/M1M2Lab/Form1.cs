using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* M1_M2 Lab
 * Jason Cross and Dominic Carlucci
 * SWENG 421
 * 08/28/2022
 */

namespace M1M2Lab
{
    public partial class Form1 : Form
    {              
        public Form1()
        {
            InitializeComponent();
            bm = new Bitmap(picBox.Width, picBox.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            picBox.Image = bm;
            thePen = new Pen(Color.Black, 5);            
        }

        //Variables
        
        private Bitmap bm;
        private Graphics g;
        private Pen thePen;
        bool cursorMoving = false;
        
        int index;
        
        int x, y, endX, endY, startX, startY;
        
        // Choose to draw a line
        private void lineButton_Click(object sender, EventArgs e)
        {
            index = 1;
        }
        
        // Choose to draw a rectangle
        private void rectButton_Click(object sender, EventArgs e)
        {
            index = 2;
        }

        //choose to draw an ellipse
        private void ellipseButton_Click(object sender, EventArgs e)
        {
            index = 3;
        }

        // Captures cursor location when mouse button is pressed
        private void picBox_MouseDown(object sender, MouseEventArgs e)
        {
            cursorMoving = true;            

            startX = e.X;
            startY = e.Y;
            
        }        

        // Checks for mouse movement
        private void picBox_MouseMove(object sender, MouseEventArgs e)
        {
            picBox.Refresh();
            
            x = e.X;
            y = e.Y;
            endX = e.X - startX;
            endY = e.Y - startY;
        }        

        // Captures cursor location when mouse button is released and draws selected shape
        private void picBox_MouseUp(object sender, MouseEventArgs e)
        {
            cursorMoving = false;

            endX = x - startX;
            endY = y - startY;

            if (index == 1)
            {
                g.DrawLine(thePen, startX, startY, x, y);
            }
            if (index == 2)
            {
                g.DrawRectangle(thePen, startX, startY, endX, endY);
            }
            if (index == 3)
            {
                g.DrawEllipse(thePen, startX, startY, endX, endY);
            }
        }

        // Allows more flexibility with shape drawing
        private void picBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            if (cursorMoving)
            {
                if (index == 1)
                {
                    g.DrawLine(thePen, startX, startY, x, y);
                }
                if (index == 2)
                {
                    g.DrawRectangle(thePen, startX, startY, endX, endY);
                }
                if (index == 3)
                {
                    g.DrawEllipse(thePen, startX, startY, endX, endY);
                }
            }
        }

        // Sets the red color channel value and updates pen color
        private void redTB_Scroll(object sender, EventArgs e)
        {
            redLbl.Text = redTB.Value.ToString();
            thePen.Color = Color.FromArgb(redTB.Value, greenTB.Value, blueTB.Value);
        }

        // Sets the green color channel value and updates pen color
        private void greenTB_Scroll(object sender, EventArgs e)
        {
            greenLbl.Text = greenTB.Value.ToString();
            thePen.Color = Color.FromArgb(redTB.Value, greenTB.Value, blueTB.Value);
        }

        // Sets the blue color channel value and updates pen color
        private void blueTB_Scroll(object sender, EventArgs e)
        {
            blueLbl.Text = blueTB.Value.ToString();
            thePen.Color = Color.FromArgb(redTB.Value, greenTB.Value, blueTB.Value);
        }
    }
}
