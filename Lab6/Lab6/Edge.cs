/**
 * Jason Cross and Dominick Carlucci
 * Edge.cs class
 * Due Date: 10/2/22 11:59 pm
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public class Edge
    {
        public int edgeNo;
        public Vertex fromVert;
        public Vertex toVert;

        public Edge(int edgeNo, Vertex fromVert, Vertex toVert)
        {
            this.edgeNo = edgeNo;
            this.fromVert = fromVert;
            this.toVert = toVert;
        }

        public void setEdgeNo(int edgeNo)
        {
            this.edgeNo = edgeNo;
        }

        public int getEdgeNo()
        {
            return edgeNo;
        }

        public void setFromVert(Vertex fromVert)
        {
            this.fromVert = fromVert;
        }

        public Vertex getFromVert()
        {
            return fromVert;
        }

        public void setToVert(Vertex toVert)
        {
            this.toVert = toVert;
        }

        public Vertex getToVert()
        {
            return toVert;
        }

        public void DrawIt()
        {
            Console.WriteLine("Drawing Edge");
        }
    }
}
