using System;

namespace BT6
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, n, k;
            int[,] a,b,c, d;
            xulixau(out m, out n, out k, out a, out b, out c, out d);
            Console.WriteLine();

            xuatmang(sxdt(a, k));
            
            xuatmang(sxcg(b, k));
            
            xuatmang(doidong(c));
            
            xuatmang(sxdmax(d));
            
            Console.ReadKey();
        }

        public static void xulixau(out int m, out int n, out int k, out int[,] a, out int[,] b, out int[,] c, out int[,] d)
        {
            var numberList = Console.ReadLine().Split(' ');
            m = int.Parse(numberList[0]);
            n = int.Parse(numberList[1]);
            k = int.Parse(numberList[2]);
            a = new int[m, n];
            b = new int[m, n];
            c = new int[m, n];
            d = new int[m, n];


            for (int i = 0; i < a.GetLength(0); i++)
            {
                var numberList2 = Console.ReadLine().Split(' ');
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = int.Parse(numberList2[j]);
                    b[i, j] = a[i, j];
                    c[i, j] = a[i, j];
                    d[i, j] = a[i, j];

                }
            }
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
            Console.WriteLine();
        }
        public static int[,] sxdt(int[,] a, int k)
        {
            int d = a.GetLength(1);
            int[] b = new int[a.GetLength(1)];
            for (int i = 0; i < a.GetLength(1); i++)
            {
                b[i] = a[k, i];
            }
            for (int i = 0; i < d; i++)
            {
                for (int j = i + 1; j < d; j++)
                {
                    if (b[j] < b[i])
                    {
                        int t = b[i];
                        b[i] = b[j];
                        b[j] = t;
                    }
                }
            }
            for (int i = 0; i < a.GetLength(1); i++)
            {
                a[k, i] = b[i];
            }
            return a;
        }

        public static int[,] sxcg(int[,] a, int k)
        {
            int d = a.GetLength(0);
            int[] b = new int[a.GetLength(0)];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                b[i] = a[i, k];
            }
            for (int i = 0; i < d; i++)
            {
                for (int j = i + 1; j < d; j++)
                {
                    if (b[j] > b[i])
                    {
                        int t = b[i];
                        b[i] = b[j];
                        b[j] = t;
                    }
                }
            }
            for (int i = 0; i < a.GetLength(0); i++)
            {
                a[i, k] = b[i];
            }
            return a;
        }

        public static int[,] doidong(int[,] a)
        {
            Console.Write("Nhap 2 dong can doi: ");
            var numberList = Console.ReadLine().Split(' ');
            int c = int.Parse(numberList[0]);
            int d = int.Parse(numberList[1]);
            int[] e = new int[a.GetLength(1)];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    e[j] = a[c, j];
                    a[c, j] = a[d, j];
                    a[d, j] = e[j];
                }
            }
            return a;
        }

        public static int[,] sxdmax(int[,] a)
        {
            int[] b = new int[a.GetLength(0)];
            for (int i = 0; i < a.GetLength(0) - 1; i++)
            {
                int s1 = 0;
                int s2 = 0;
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    s1 += a[i, j];
                    s2 += a[i + 1, j];
                }

                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (s1 < s2)
                    {
                        b[i] = a[i, j];
                        a[i, j] = a[i + 1, j];
                        a[i + 1, j] = b[i];
                    }
                }
            }

            return a;
        }
    }
}

