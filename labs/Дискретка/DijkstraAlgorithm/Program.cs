namespace DijkstraAlgorithm
{
    internal class Program
    {
        static void Main()
        {   
            var graph = FillMatrix();
            Console.Write("Выберите начальную координату:\t");
            int n = Int32.Parse(Console.ReadLine());
            FindMinPath(n, graph);
            Console.ReadKey();
        }

        static void FindMinPath(int n, int[,] graph)
        {
            int inf = int.MaxValue;
            int v = graph.GetLength(0);
            int[] dist = new int[v];
            bool[] visited = new bool[v];
            for (int i = 0; i < v; i++)
            {
                dist[i] = inf;
                visited[i] = false;
            }

            dist[n - 1] = 0;
            for (int i = 0; i < v; i++)
            {
                int minD = inf;
                int minI = -1;
                for (int j = 0; j < v; j++)
                {
                    if (!visited[j] && dist[j] < minD)
                    {
                        minD = dist[j];
                        minI = j;
                    }
                }

                visited[minI] = true;
                for (int j = 0; j < v; j++)
                {
                    if (!visited[j] && graph[minI, j] != 0 && dist[minI] != inf && dist[minI] + graph[minI, j] < dist[j])
                    {
                        dist[j] = dist[minI] + graph[minI, j];
                    }
                }
            }

            Console.WriteLine("Кратчайшие пути");
            for (int i = 0; i < v; i++)
            {
                Console.WriteLine($"{i + 1}\t{dist[i]}");
            }
        }

        static int[,] FillMatrix()
        {
            Console.Write("кол-во вершин:\t");
            int n = Int32.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{i + 1}, {j + 1}\t");
                    if (!Int32.TryParse(Console.ReadLine(), out int tmp))
                    {
                        tmp = 0;
                        matrix[i, j] = tmp;
                    }

                    matrix[i, j] = tmp;
                }
            }

            return matrix;

        }

    }
}