using System;
using System.Security.Cryptography.X509Certificates;

namespace BT7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int[,] a;
            dulieuvao(out n, out a);
            incc(n, a);
            Console.WriteLine();
            incp(n, a);
            Console.WriteLine();
            intg(n, a);

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

        public static void incc(int n, int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        Console.WriteLine(a[i, j]);
                    }
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
            } while (d >= 0);
        }
        public static void intg(int n, int[,] a)
        {
            int k = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                k = i;
                for (int j = 0 ; j < a.GetLength(1); j++)
                {
                    if (k < (a.GetLength(1)))
                    {
                        Console.Write(a[i, k] + " ");
                        k++;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
