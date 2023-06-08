namespace FordFulkerson
{
    class Programm
    {
        static int V;  
        static int[,] graph;  

        // Поиск максимального потока в графе
        static int MaxFlow(int[,] rGraph, int s, int t)
        {
            int[] parent = new int[V];  
            int maxFlow = 0;  

            while (BFS(rGraph, s, t, parent))  
            {
                int pathFlow = int.MaxValue;
                for (int v = t; v != s; v = parent[v])
                {
                    int u = parent[v];
                    pathFlow = Math.Min(pathFlow, rGraph[u, v]);  
                }
                for (int v = t; v != s; v = parent[v])
                {
                    int u = parent[v];
                    rGraph[u, v] -= pathFlow;  
                    rGraph[v, u] += pathFlow;  
                }
                maxFlow += pathFlow;  
            }

            return maxFlow;
        }

        // Поиск увеличивающего пути в графе
        static bool BFS(int[,] rGraph, int s, int t, int[] parent)
        {
            bool[] visited = new bool[V];  
            Queue<int> q = new Queue<int>();
            q.Enqueue(s);
            visited[s] = true;
            parent[s] = -1;

            while (q.Count > 0)
            {
                int u = q.Dequeue();
                for (int v = 0; v < V; v++)
                {
                    if (!visited[v] && rGraph[u, v] > 0)
                    {
                        q.Enqueue(v);
                        parent[v] = u;
                        visited[v] = true;
                    }
                }
            }

            return visited[t];  
        }

        static void Main(string[] args)
        {
            V = 6;
            graph = new int[,] { {0, 2, 6, 0, 0, 0},
                             {0, 0, 0, 3, 5, 0},
                             {0, 0, 0, 2, 0, 0},
                             {0, 0, 0, 0, 0, 3},
                             {0, 0, 0, 4, 0, 7},
                             {0, 0, 0, 0, 0, 0} };

            Console.WriteLine("Максимальный поток: " + MaxFlow(graph, 0, 5));
            Console.ReadKey();
        }
    }
}