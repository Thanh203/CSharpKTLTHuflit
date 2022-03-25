using System;

namespace BT1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a, b;
            dulieuvao(out a, out b);
            xuatmang(sumAB(a, b));
        }

        public static void dulieuvao(out int[,] a, out int[,] b)
        {
            var numberList = Console.ReadLine().Split();
            int m = int.Parse(numberList[0]);
            int n = int.Parse(numberList[1]);
            a = new int[m, n];
            b = new int[m, n];
            
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

        public static int[,] sumAB(int[,] a, int[,] b)
        {
            int[,] c = new int[a.GetLength(0), a.GetLength(1)];
            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    c[i, j] = a[i, j] + b[i, j];
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