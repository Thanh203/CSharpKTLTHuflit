using System;

namespace BT6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a, b;
            dulieuvao(out a, out b);
            Console.WriteLine(tich(a, b));
        }

        public static void dulieuvao(out int[,] a, out int[,] b)
        {
            int n = int.Parse(Console.ReadLine());

            a = new int[n, n];
            b = new int[n, n];
            
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

        public static int tich(int[,] a, int[,] b)
        {
            int sum = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    sum += a[i, j] * b[i, j];
                }
            }

            return sum;
        }
    }
}