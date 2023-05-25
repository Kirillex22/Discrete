static int BellmanFord(int[,] graph, int V, int src, int destination){
            int[] dis = new int[V];
            int E = 2 * (V - 1);

            for (int i = 0; i < V; i++)
                dis[i] = 9999999;

            dis[src] = 0;
            for (int i = 0; i < V - 1; i++){
                for (int j = 0; j < E; j++){
                    dis[graph[j, 1]] = Math.Min(dis[graph[j, 1]], dis[graph[j, 0]] + graph[j, 2]);
                    dis[graph[j, 0]] = Math.Min(dis[graph[j, 0]], dis[graph[j, 1]] + graph[j, 2]);
                }
            }
            return dis[destination];
