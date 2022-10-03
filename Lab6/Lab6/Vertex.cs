/**
 * Jason Cross and Dominick Carlucci
 * Vertex.cs class
 * Due Date: 10/2/22 11:59 pm
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public class Vertex
    {
        public int vertexNo;
        public int x_coord;
        public int y_coord;

        public Vertex(int vertexNo, int x_coord, int y_coord)
        {
            this.vertexNo = vertexNo;
            this.x_coord = x_coord;
            this.y_coord = y_coord;
        }

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
