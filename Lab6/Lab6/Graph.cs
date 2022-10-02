using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    internal class Graph : GraphIF
    {
        private int id;
        private List<Vertex> vertices;
        private List<Edge> edges;

        public Graph(int id)
        {
            this.id = id;
            vertices = new List<Vertex>();
            edges = new List<Edge>();
        }

        public void AddVertex(Vertex v)
        {
            vertices.Add(v);
        }

        public void AddEdge(Edge e)
        {
            edges.Add(e);
        }        

        public List<Vertex> GetVertices()
        {
            return vertices;
        }

        public List<Edge> GetEdges()
        {
            return edges;
        }

        public void print(int graphID)
        {
            
        }

        public int getID()
        {
            return id;
        }

        public void setID()
        {
            this.id = id;
        }

        public object Clone()
        {
            return new object();
        }
    }
}
