using System;
using System.Collections.Generic;

namespace BT5
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, n, k;
            int[,] a;
            xulixau(out m, out n, out k, out a);
            Console.WriteLine($"Phan tu lon nhat dong {k} la: {maxRowsK(k, a)}");
            Console.WriteLine($"Phan tu be nhat cot {k} la: {minColsK(k, a)}");
            insnt(a);

            Console.ReadKey();
        }

        public static void xulixau(out int m, out int n, out int k, out int[,] a)
        {
            var numberList = Console.ReadLine().Split(' ');
            m = int.Parse(numberList[0]);
            n = int.Parse(numberList[1]);
            k = int.Parse(numberList[2]);
            a = new int[m, n];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                var numberList2 = Console.ReadLine().Split(' ');
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = int.Parse(numberList2[j]);
                }
            }
        }

        public static int maxRowsK(int k, int[,] a)
        {
            int max = a[k, 0];
            for (int i = 0; i < a.GetLength(1); i++)
            {
                if (max < a[k, i])
                {
                    max = a[k, i];
                }
            }

            return max;
        }
        public static int minColsK(int k, int[,] a)
        {
            int min = a[0, k];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                if (min > a[k, i])
                {
                    min = a[k, i];
                }
            }

            return min;
        }

        public static int maxAll(int[,] a)
        {
            int max = a[0, 0];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (max < a[i, j])
                    {
                        max = a[i, j];
                    }
                }
            }

            return max;
        }
        public static void insnt(int[,] a)
        {
            int max = maxAll(a);
            int[] b = new int[max + 1];
            for (int h = 0; h <= max; h++)
            {
                b[h] = 0;
            }
            for (int h = 0; h <= max; h++)
            {
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        if (h == a[i, j])
                        {
                            b[h] = 1;
                        }
                    }
                }
            }
            for (int h = 0; h <= max; h++)
            {
                if (b[h] == 1)
                {
                    for (int i = 2; i <= Math.Sqrt(h); i++)
                    {
                        if (h % i == 0)
                        {
                            b[h]++;
                        }
                    }
                }
            }

            Console.WriteLine("So nguyen to:");
            for (int i = 0; i <= max; i++)
            {
                if (b[i] == 1)
                {
                    Console.WriteLine(i);
                }
            }
        }
        
    }
}