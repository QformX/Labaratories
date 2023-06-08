namespace AppleTree
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader Inp = new StreamReader("Input.txt"))
            {
                string[] line = Inp.ReadLine().Split();
                int N = int.Parse(line[0]), M = int.Parse(line[1]);
                int[] C = new int[M], S = new int[M];
                int[,] tree = new int[N + 1, N + 1];
                for (int i = 0; i < N + 1; i++)
                {
                    for (int j = 0; j < N + 1; j++)
                    {
                        tree[i, j] = (i != j) ? int.MaxValue : 0;
                    }
                }
                for (int i = 0; i < N; i++)
                {
                    line = Inp.ReadLine().Split();
                    int K = int.Parse(line[0]), L = int.Parse(line[1]);
                    tree[K, i + 1] = tree[i + 1, K] = L;
                }
                for (int j = 0; j < M; j++)
                {
                    line = Inp.ReadLine().Split();
                    C[j] = int.Parse(line[0]);
                    S[j] = int.Parse(line[1]);
                }
                line = Inp.ReadLine().Split();
                int X = int.Parse(line[0]), Z = int.Parse(line[1]);
                for (int k = 0; k < N + 1; k++)
                {
                    for (int i = 0; i < N + 1; i++)
                    {
                        for (int j = 0; j < N + 1; j++)
                        {
                            tree[i, j] = Math.Min(tree[i, k] + tree[k, j], tree[i, j]);
                        }
                    }
                }
                for (int x = M - 1; x >= 0; x--)
                {
                    if (S[x] < Z)
                    {
                        C = C.Where((val, idx) => idx != x).ToArray();
                    }
                }
                int ans = 0;
                while (C.Length > 0)
                {
                    int[] aim = C.Select(c => new int[] { tree[X, c], c }).OrderBy(a => a[0]).First();
                    ans += aim[0];
                    X = aim[1];
                    C = C.Where(c => c != aim[1]).ToArray();
                }
                using (StreamWriter Outp = new StreamWriter("Output.txt"))
                {
                    Outp.Write(ans);
                }
            }
        }
    }
}