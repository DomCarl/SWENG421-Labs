using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    internal class Vertex
    {
        private int vertexNo;
        private int x_coord;
        private int y_coord;

        public void setVertexNo(int vertexNo)
        {
            this.vertexNo = vertexNo;
        }

        public int getVertexNo()
        {
            return vertexNo;
        }

        public void setX(int x)
        {
            x_coord = x;
        }

        public void setY(int y)
        {
            y_coord = y;
        }

        public int getX()
        {
            return x_coord;
        }

        public int getY()
        {
            return y_coord;
        }        

        public void DrawIt()
        {
            Console.WriteLine("Drawing Vertex");
        }
    }
}
