using System;
using System.Threading;

namespace BT2
{
    class Program
    {
        public static int d = 0;
        static void Main(string[] args)
        {
            var numberList = Console.ReadLine().Split();
            int n = int.Parse(numberList[0]);
            int k = int.Parse(numberList[1]);
            int[] a = new int[n];
            int[] b = new int[n];
            for (int i = 0; i < n; i++)
            {
                b[i] = 0;
            }
            Try(1, k, n, a, b);
            

            Console.ReadKey();
        }
        public static void Try(int i, int k, int n, int[] a,int[] b)
        {
            for (int j = 1; j <= n; j++)
            {
                if (b[j - 1] == 0)
                {
                    a[i - 1] = j;
                    if ((i == k))
                    {
                        for (i = 0; i < k; i++)
                        {
                            d++;
                            Console.Write($"{a[i]} ");
                        }

                        Console.WriteLine();
                    }
                    else
                    {
                        b[j - 1] = 1;
                        Try(i + 1, k, n, a, b);
                        b[j - 1] = 0;
                    }
                    
                }
                

            }
        }
    }
}
