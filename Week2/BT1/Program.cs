using System;

namespace Week2
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, n, k;
            int[,] a;
            var numberList = Console.ReadLine().Split(' ');
            m = int.Parse(numberList[0]);
            n = int.Parse(numberList[1]);
            k = int.Parse(numberList[2]);
            a = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                var numberList2 = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = int.Parse(numberList2[j]);
                }
            }
            
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[k -1, i]+ " ");
            }

        }
    }
}