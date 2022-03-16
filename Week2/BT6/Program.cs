using System;
using System.Security.Cryptography.X509Certificates;

namespace BT6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int[,] a;
            dulieuvao(out n, out a);
            incp(n, a);
            Console.ReadKey();
        }

        public static void dulieuvao(out int n, out int[,] a)
        {
            n = int.Parse(Console.ReadLine());
            a = new int[n, n];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                var numberList = Console.ReadLine().Split(' ');
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = int.Parse(numberList[j]);
                }
            }
            
        }

        public static void incp(int n, int[,] a)
        {
            int d = a.GetLength(0) - 1;
            int c = a.GetLength(1) - 1;
            int t = 0;
            do
            {
                Console.WriteLine(a[t, c]);
                t++;
                c--;
                d--;
            } while (d > = 0);
        }
    }
}