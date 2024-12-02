using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Graphs
{
    public class Graph
    {
        Dictionary<int, List<int>> adjacencyList;
        public Graph()
        {
            adjacencyList = new Dictionary<int, List<int>>();
        }

        /// <summary>
        /// Add Node to graph
        /// </summary>
        /// <param name="node"></param>
        public void AddNode(int node)
        {
            if (!adjacencyList.ContainsKey(node))
            {
                adjacencyList[node] = new List<int>();

            }

        }

        /// <summary>
        /// Add edge to graph
        /// </summary>
        /// <param name="source"></param>
        /// <param name="destination"></param>
        public void AddEdge(int source, int destination)
        {
            if (!adjacencyList.ContainsKey(source))
            {
                AddNode(source);
            }
            if (!adjacencyList.ContainsKey(destination))
            {
                AddNode(destination);
            }

            //One way garph (directed graph)
            adjacencyList[source].Add(destination);
        }

        public void RemoveNode(int node)
        {
            //Chek the key if it is excist in graph
            if (adjacencyList.ContainsKey(node))
            {
                //remove all the connection with node
                foreach (var keys in adjacencyList.Keys.ToList())
                {
                    adjacencyList[keys].Remove(node);
                }
                //remove the node
                adjacencyList.Remove(node);
            }
        }

        #region ExampleUsage
        /*
       *    
      Graph graph = new Graph();

      // Düğümler ekleniyor
      graph.AddNode(1);
      graph.AddNode(2);
      graph.AddNode(3);
      graph.AddNode(4);

      // Kenarlar ekleniyor
      graph.AddEdge(1, 2);
      graph.AddEdge(1, 3);
      graph.AddEdge(2, 4);

      // Grafı yazdırma
      graph.PrintGraph();

       */
        #endregion

    }
}
