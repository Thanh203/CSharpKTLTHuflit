using System;

namespace BT7
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
            var numberList = Console.ReadLine().Split();
            int m = int.Parse(numberList[0]);
            int n = int.Parse(numberList[1]);
            int k = int.Parse(numberList[2]);
            
            a = new int[m, n];
            b = new int[k, k];
            
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

        public static int[,] tich(int[,] a, int[,] b)
        {
            int sum = 0;
            int[,] c = new int[a.GetLength(0) - b.GetLength(0) + 1, a.GetLength(1) - b.GetLength(1) + 1];
            for (int c1 = 0; c1 < c.GetLength(0); c1++)
            {
                for (int c2 = 0; c2 < c.GetLength(1); c2++)
                {
                    for (int a1 = 0; a1 < a.GetLength(0); a1++)
                    {
                        for (int a2 = 0; a2 < a.GetLength(1); a2++)
                        {
                            for (int b1 = 0; b1 < b.GetLength(0); b1++)
                            {
                                for (int b2 = 0; b2 < b.GetLength(1); b2++)
                                {
                                    if ((a1 <= b1) && (a2 <= b2))
                                    {
                                        sum += a[a1, a2] * b[b1, b2];
                                    }
                                }
                            }
                        }
                    }

                    c[c1, c2] = sum;
                }
            }
//sum += a[b1, b2] * b[b1, b2];
            return c;
        }
    }
}