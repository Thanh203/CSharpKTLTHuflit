using System;

namespace LuyThuaMaTran
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a, b, c;
            int n, s;
            input(out a, out n);
            s = a.GetLength(0);
            b = new int[s, s];
            c = new int[s, s];
            c = a;
            //output(b);
            output(LuyThua(a, n, b, c));
            Console.ReadKey();
        }

        public static void input(out int[,] a, out int n)
        {
            var numberList = Console.ReadLine().Split();
            int m = int.Parse(numberList[0]);
            n = int.Parse(numberList[1]);
            a = new int[m, m];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                var numberList2 = Console.ReadLine().Split();
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = int.Parse(numberList2[j]);
                }
            }
        }

        public static void output(int[,] a)
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
        public static int[,] LuyThua(int[,] a, int n, int[,] b, int[,] c)
        {
            int[,] d = new int[a.GetLength(0), a.GetLength(0)];
            int s = a.GetLength(0);
            if (n == 1)
            {
                return b;
            }
            else
            {
                for (int i = 0; i < s; i++)
                {
                    for (int j = 0; j < s; j++)
                    {
                        for (int l = 0; l < s; l++)
                        {
                            d[i, j] += c[i, l] * a[l, j];
                        }
                    }
                }

                for (int i = 0; i < s; i++)
                {
                    for (int j = 0; j < s; j++)
                    {
                        b[i, j] = d[i, j];
                    }
                }
                return LuyThua(a, n - 1, b, b);
            }
        }
    }
}