using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//array arraylist hash таблицы

namespace ConsoleApplication39
{
    class Program
    {
        static int[][] graph;
        static int vertices;

        static void Main(string[] args)
        {
            vertices = int.Parse(Console.ReadLine());
            graph = new int[vertices][];
            for (int i = 0; i < vertices; i++)
            {
                graph[i] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            }
            int[] minDistances = new int[vertices];
            int[] parents = new int[vertices];
            bool[] visited = new bool[vertices];

            for (int i = 1; i < vertices; i++)
            {
                minDistances[i] = int.MaxValue;
            }

            minDistances[0] = 0;
            parents[0] = -1;

            for (int i = 0; i < vertices - 1; i++)
            {
                int u = GetMinDistanceVertex(minDistances, visited);
                visited[u] = true;
                for (int v = 0; v < vertices; v++)
                {
                    if (graph[u][v] != 0 && !visited[v] && graph[u][v] < minDistances[v])
                    {
                        minDistances[v] = graph[u][v];
                        parents[v] = u;
                    }
                }

            }
            int minWeight = 0;
            for (int i = 1; i < vertices; i++) {
                minWeight += minDistances[i];
            }

            Console.WriteLine("Минимальные рёбра: ");
            
            for (int i = 1; i < vertices; i++)
            {
                Console.WriteLine("{1}-{2}", parents[i], i);
            }
            Console.WriteLine("Минимальное основное древо имеет вес: " + minWeight);
            Console.ReadKey();
        }
        static int GetMinDistanceVertex(int[] minDistances, bool[] visited)
        {
            int minDistance = int.MaxValue;
            int minDistanceVertex = -1;

            for (int v = 0; v < vertices; v++)
            {
                if (!visited[v] && minDistances[v] < minDistance)
                {
                    minDistance = minDistances[v];
                    minDistanceVertex = v;
                }
            }
            return minDistanceVertex;
        }
    }
}
