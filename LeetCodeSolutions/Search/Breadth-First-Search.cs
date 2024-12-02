namespace LeetCodeSolutions.Search;

public class Breadth_First_Search
{
    public void Search(Dictionary<int,List<int>> graph, int start)
    {
        // Ziyaret edilen düğümleri takip eden bir set
        HashSet<int> visited = new HashSet<int>();
        // BFS kuyruğu
        Queue<int> queue = new Queue<int>();

        // Başlangıç düğümünü kuyruk ve ziyaret listesine ekle
        queue.Enqueue(start);
        visited.Add(start);

        Console.WriteLine("BFS Ziyaret Sırası:");

        while (queue.Count > 0)
        {
            // Kuyruktan bir düğüm al
            int current = queue.Dequeue();

            // Komşularını ziyaret et
            if (graph.ContainsKey(current))
            {
                foreach (var neigbor in graph[current])
                {
                    if (!visited.Contains(neigbor))
                    {
                        queue.Enqueue(neigbor);
                        visited.Add(neigbor);

                    }
                }

            }
        }

    }

}
/*
 kullanim
static void Main(string[] args)
{
    // Grafı tanımla (komşuluk listesi)
    Dictionary<int, List<int>> graph = new Dictionary<int, List<int>>
        {
            { 0, new List<int> { 1, 2 } },
            { 1, new List<int> { 0, 3, 4 } },
            { 2, new List<int> { 0, 5, 6 } },
            { 3, new List<int> { 1 } },
            { 4, new List<int> { 1 } },
            { 5, new List<int> { 2 } },
            { 6, new List<int> { 2 } }
        };

    // BFS başlat
    BFS(graph, 0);
}
*/
