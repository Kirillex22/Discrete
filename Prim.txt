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
        int min = 1000;
        int res = 0;
        List<int> v_used = new List<int>();
        int[,] ribs = new int[n,n]; 
        Console.Clear();
        for (int i = 0; i < n; i++)
        {
            k++;
            for(int j = k; j < n; j++)
            {
                Console.WriteLine("ребро {0},{1} / если ребро не существует, введите 1000", i + 1, j + 1);        
                ribs[i, j] = int.Parse(Console.ReadLine());
                ribs[j, i] = ribs[i, j];
            }
        } 
        k = 0;
        for (int i = 0; i < n; i++)
        {
            v_unused.Add(i);
        }
        k = 0;
        v_unused.Remove(k);
        v_used.Add(k);
        while(v_unused.Count > 0)
        {
            for (int i = 0; i < v_unused.Count; i++)
            {
                for (int j = 0; j < v_used.Count; j++)
                {
                    if ((ribs[v_unused[i], v_used[j]] < min) && (ribs[v_unused[i], v_used[j]] != 1000))
                    {
                        if (((ribs[v_unused[i], v_used[j]] < min) && (ribs[v_unused[i], v_used[j]] != 1000)))
                        {
                            min = ribs[v_unused[i], v_used[j]];
                            k = v_unused[i];
                        }
                    }
                } 
            }
            res += min;
            min = 1000;
            v_unused.Remove(k);
            v_used.Add(k);

        }
        Console.WriteLine(res);
    }
}




