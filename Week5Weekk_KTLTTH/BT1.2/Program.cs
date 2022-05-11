using System;
using System.Reflection.Metadata;

namespace BT1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k;
            int[] check, a;
            int d = 0;
            dulieuvao(out n, out k, out a);
            chinhhop(1, n, k, a, d);
            Console.WriteLine(dem(d));
            
            Console.ReadKey();
        }

        public static void dulieuvao(out int n, out int k,out int[] a)
        {
            var numberList = Console.ReadLine().Split();
            n = int.Parse(numberList[0]);
            k = int.Parse(numberList[1]);
            a = new int[k + 1];
        }

        public static void xuat(int k, int[] a)
        {
            for (int i = 1; i <= k ; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }

        public static int dem(int d)
        {
            return d++;
        }
        
        public static void chinhhop(int i, int n, int k, int[] a, int d)
        {
            for (int j = 1; j <= n; j++)
            {
                a[i] = j;
                if (i == k)
                {
                    xuat(k, a);
                }
                else
                {
                    chinhhop(i + 1, n, k, a, d);
                }
            
            }
        }
    }
}