public static int Dijcstra(int[][] graph, int N, int V, int src){
            double[] d = new double[N];
            for(int i = 0; i < N; i++)
            {
                if (i == V - 1)
                {
                    d[i] = 0;
                }
                else
                {
                    d[i] = 999999999;
                }

            }
            for (int i = 0; i < N; i++)
            {
                foreach (int[] j in graph)
                {
                    d[j[1]] = Math.Min(d[j[1]], d[j[0]] + j[2]);
                }
            }
            for(int i = 0; i < N; i++)
            {
                d[i] /= 100;
                Console.Write("{0} - {1}", i + 1, d[i]);
            }
        }
