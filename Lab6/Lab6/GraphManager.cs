using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    internal class GraphManager
    {
        private List<Graph> graphs;

        public GraphManager()
        {
            graphs = new List<Graph>();
        }

        public void CreateGraph(Graph g)
        {
            graphs.Add(g);
        }

        public void CopyGraph(Graph g)
        {
            Graph newGraph = (Graph)g.Clone();
            graphs.Add(newGraph);
        }

        public void ReviseGraph(Graph g)
        {
            
        }
    }
}
