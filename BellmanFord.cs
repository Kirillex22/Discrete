
class Program{
    static void BellmanFord(int[,] graph, int V, int E, int src){
        int[] dis = new int[V];
        for (int i = 0; i < V; i++){
            dis[i] = 1000000000;
        }  
        dis[src] = 0;
        for (int i = 0; i < V - 1; i++){
            for (int j = 0; j < E; j++){
                 dis[graph[j, 1]] = Math.Min(dis[graph[j, 1]], dis[graph[j, 0]] + graph[j, 2]);
            }
        }
        for (int i = 0; i < V; i++){
            Console.WriteLine(i + 1 + "  |  " + dis[i]);
        } 
    }
    public static void Main(string[] args){
        Console.WriteLine("введите число вершин");
        int V = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("введите число ребер");
        int E = int.Parse(Console.ReadLine());
        Console.Clear();
        int[,] graph = new int[E, 3];
        for (int i = 0; i < E; i++){
            Console.WriteLine("u,v,w, осталось {0}", E-i);
            for (int j = 0; j < 3; j++){
                int inv = int.Parse(Console.ReadLine());
                graph[i, j] = inv;
            }
            Console.Clear();
        }
        Console.WriteLine("введите желаемую вершину");
        int src = int.Parse(Console.ReadLine());
        Console.Clear();
        BellmanFord(graph, V, E, src);
    }
}



