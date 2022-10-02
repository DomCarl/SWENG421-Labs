using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    internal class Edge
    {
        private int edgeNo;
        private Vertex fromVert;
        private Vertex toVert;

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
