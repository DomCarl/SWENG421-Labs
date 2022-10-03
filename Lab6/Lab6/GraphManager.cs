/**
 * Jason Cross and Dominick Carlucci
 * GraphManager.cs class
 * Due Date: 10/2/22 11:59 pm
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public class GraphManager
    {
        public List<Graph> graphs;

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
            newGraph.setID(graphs.Count + 1);
            graphs.Add(newGraph);
        }

        public void ReviseGraph(Graph g)
        {
            
        }
    }
}
