using System;

namespace BT1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, n, k;
            int[,] a;
            xulixau(out m,out n,out k,out a);
            indongthuk(k,n,a);
            Console.ReadKey();
        }

        public static void xulixau(out int m, out int n, out int k, out int[,] a)
        {
            var numberList = Console.ReadLine().Split(' ');
            m = int.Parse(numberList[0]);
            n = int.Parse(numberList[1]);
            k = int.Parse(numberList[2]);
            a = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                var numberList2 = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = int.Parse(numberList2[j]);
                }
            }
        }

        public static void indongthuk(int k, int n, int[,] a)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[k - 1, i]+ " ");
            }
        }
    }
}