using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication38
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
                graph[i] = new int[vertices];
                string[] line = Console.ReadLine().Split();
                for (int j = 0; j < vertices; j++)
                {
                    graph[i][j] = int.Parse(line[j]);
                }
            }
            int start = 0;
            List<int> visited = new List<int>();
            List<Tuple<int, int>> mst = new List<Tuple<int, int>>();
            int weight = 0;

            visited.Add(start);

            while (visited.Count < vertices)
            {
                int minWeight = int.MaxValue;
                Tuple<int, int> edge = null;

                foreach (int v in visited)
                {
                    for (int i = 0; i < vertices; i++)
                    {
                        if (!visited.Contains(i) && graph[v][i] != 0 && graph[v][i] < minWeight)
                        {
                            minWeight = graph[v][i];
                            edge = new Tuple<int, int>(v, i);
                        }
                    }
                }
                mst.Add(edge);
                weight += minWeight;
                visited.Add(edge.Item2);
            }
            Console.WriteLine("Minimum Spanning Tree: ");
            foreach (Tuple<int, int> e in mst)
            {
                Console.WriteLine("{0} - {1}", e.Item1+1, e.Item2+1);
            }
            Console.WriteLine("Minimum weight of MST: {0}", weight);
            Console.ReadKey();
        }
    }
}
