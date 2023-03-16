using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
class HelloWorld
{
    static void Main()
    {
        List<int> v_unused = new List<int>();
        Console.WriteLine("число вершин");
        int n = int.Parse(Console.ReadLine());
        int k = 0;
        int h = 0;
        int res = 0;
        List<int> v_used = new List<int>();
        int[,] ribs = new int[n,n];
        int[] min_dis = new int[n];
        Console.Clear();
        for (int i = 0; i < n; i++)
        {
            for(int j = 0; j < n; j++)
            {
                if (i == j)
                {
                    ribs[i, j] = 0;
                }
                else
                {
                    Console.WriteLine("ребро {0},{1} / если ребро не существует, введите 1000", i + 1, j + 1);
                    ribs[i, j] = int.Parse(Console.ReadLine());
                }    
            }
        } 
        for (int i = 0; i < n; i++)
        {
            v_unused.Add(i);
        }
        Console.WriteLine("желаемая вершина");
        k = int.Parse(Console.ReadLine());
        Console.Clear();
        v_unused.Remove(k);
        v_used.Add(k);
        min_dis[k] = 999999;
        foreach (int i in v_unused)
        {
            min_dis[i] = ribs[k, i];
        }
        while (v_unused.Count > 0)
        {
            for (int i = 0; i < v_unused.Count; i++)
            {
                if (i == k)
                {
                    continue;
                }
                else
                {
                    min_dis[i] = Math.Min(min_dis[i], min_dis[k] + ribs[k, i]);
                }

            }
            k = Array.IndexOf(min_dis, min_dis.Min());
            Console.WriteLine(k);
            Console.ReadKey();
            Console.WriteLine(k);
            v_unused.Remove(k);
            v_used.Add(k);
        }
        k = 0; 
        foreach(int i in min_dis)
        {
            Console.WriteLine(i);
        }
        

    }
}





        






    





