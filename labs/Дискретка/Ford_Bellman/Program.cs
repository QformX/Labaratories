using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication45
{
    class Program
    {
        public static int inf = int.MaxValue;

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int tmp;
                    Console.Write((i+1) + " " + (j+1) + ": ");
                    if (int.TryParse(Console.ReadLine(), out tmp))
                    {
                        matrix[i, j] = tmp; 
                    }
                    else
                    {
                        matrix[i, j] = inf;
                    }
                }
            }
            int source = 0;
            Console.WriteLine(String.Join(", ", Ford_Bellman(matrix, n, source)));

            Console.ReadKey();
        }

        public static int[] Ford_Bellman(int[,] graph, int n, int source)
        {
            int[] dist = new int[n];
            for (int i = 0; i < n; i++)
            {
                dist[i] = inf;
            }

            dist[source] = 0;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        if (graph[j,k] != inf && dist[j] != inf && dist[j] + graph[j,k] < dist[k])
                        {
                            dist[k] = dist[j] + graph[j, k];
                        }
                    }
                }
            }

            return dist;

        }
    }
}
