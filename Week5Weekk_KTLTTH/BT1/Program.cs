using System;

namespace BT1
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberList = Console.ReadLine().Split();
            int n = int.Parse(numberList[0]);
            int k = int.Parse(numberList[1]);
            int[] a = new int[n];
            double d ;
            d = Math.Pow(n, k);
            Console.WriteLine(d);
            Try(1, k, n, a);
            Console.ReadKey();
        }
        public static void Try(int i, int k, int n, int[] a)
        {
            for (int j = 1; j <= n; j++)
            {
                a[i - 1] = j; 
                if (i == k)
                {
                        
                    for (i = 0; i < k; i++)
                    {
                        Console.Write($"{a[i]} ");
                    }
                    Console.WriteLine();
                }
                else
                {

                    Try(i + 1, k, n, a);
                }
                    
            }
        }
    }
}