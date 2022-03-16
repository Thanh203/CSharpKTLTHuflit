using System;

namespace BT2
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, n, k;
            int[,] a;
            xulixau(out m,out n,out k,out a);
            incotthuk(k,m,a);
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

        public static void incotthuk(int k, int m, int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                Console.Write(a[i, k- 1]+ " ");
            }
        }
    }
}