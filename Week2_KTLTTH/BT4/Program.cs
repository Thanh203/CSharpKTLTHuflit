using System;

namespace BT4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a;
            dulieuvao(out a);
            xuatmang(chuyenvi(a));
        }

        public static void dulieuvao(out int[,] a)
        {
            var numberList = Console.ReadLine().Split();
            int m = int.Parse(numberList[0]);
            int n = int.Parse(numberList[1]);

            a = new int[m,n];
            
            for (int i = 0; i < a.GetLength(0); i++)
            {
                var numberList2 = Console.ReadLine().Split();
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = int.Parse(numberList2[j]);
                }
            }
        }

        public static int[,] chuyenvi(int[,] a)
        {
            int[,] c = new int[a.GetLength(1), a.GetLength(0)];
            for (int i = 0; i < c.GetLength(0); i++)
            {
                for (int j = 0; j < c.GetLength(1); j++)
                {
                    c[i, j] = a[j, i];
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