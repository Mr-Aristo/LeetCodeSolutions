using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Graphs
{
    public class Graph
    {
        // Düğüm ile komşuluk listesini tutan yapı
        private Dictionary<int, List<int>> adjacencyList;

        public Graph()
        {
            adjacencyList = new Dictionary<int, List<int>>();
        }

        // Graf'a düğüm ekleme
        public void AddVertex(int vertex)
        {
            if (!adjacencyList.ContainsKey(vertex))
            {
                adjacencyList[vertex] = new List<int>();

            }
        }

        // Düğümler arası kenar ekleme
        public void AddEdge(int vertex1, int vertex2)
        {
            if (adjacencyList.ContainsKey(vertex1) && adjacencyList.ContainsKey(vertex2))
            {
                adjacencyList[vertex1].Add(vertex2);
                adjacencyList[vertex2].Add(vertex1);// Yönsüz graf olduğu için her iki tarafa da ekliyoruz

            }

        }

        public void PrintGraph()
        {
            foreach (var vertex in adjacencyList)
            {
                Console.WriteLine($"{vertex.Key}");
                foreach (var neighbor in vertex.Value)
                {
                    Console.WriteLine($"{neighbor}");

                }
                Console.WriteLine();
            }
        }

        #region ExampleUsage
        /*
       *    
      Graph graph = new Graph();

      // Düğümler ekleniyor
      graph.AddVertex(1);
      graph.AddVertex(2);
      graph.AddVertex(3);
      graph.AddVertex(4);

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
