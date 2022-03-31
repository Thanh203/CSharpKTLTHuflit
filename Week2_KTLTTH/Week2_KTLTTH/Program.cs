using System;

public class Program
{
    static void Main(string[] args)
    {
        int[,] a, b;
        dulieuvao(out a, out b);
        Console.ReadKey();
    }

    public static void dulieuvao(out int[,] a, out int[,] b)
    {
        var numberList = Console.ReadLine().Split();
        int m = int.Parse(numberList[0]);
        int n = int.Parse(numberList[1]);
        int p = int.Parse(numberList[2]);

            
        a = new int[m, n];
        b = new int[n, p];
            
        for (int i = 0; i < a.GetLength(0); i++)
        {
            var numberList2 = Console.ReadLine().Split();
            for (int j = 0; j < a.GetLength(1); j++)
            {
                a[i, j] = int.Parse(numberList2[j]);
            }
        }
        for (int i = 0; i < b.GetLength(0); i++)
        {
            var numberList3 = Console.ReadLine().Split();
            for (int j = 0; j < b.GetLength(1); j++)
            {
                b[i, j] = int.Parse(numberList3[j]);
            }
        }
    }
}
