using System;

namespace BT2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a, b;
            dulieuvao(out a, out b);
            xuatmang(tichAB(a, b));
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

        public static int[,] tichAB(int[,] a, int[,] b)
        {
            int[,] c = new int[a.GetLength(0), b.GetLength(1)];
            
            for (int i = 0; i < c.GetLength(0); i++)
            {
                for (int j = 0; j < c.GetLength(1); j++)
                {
                    for (int k = 0; k < a.GetLength(1); k++)
                    {
                        c[i, j] += a[i, k] * b[k, j];
                    }
                    
                }
            }

            return c;
        }

        public static void xuatmang(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"{a[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}