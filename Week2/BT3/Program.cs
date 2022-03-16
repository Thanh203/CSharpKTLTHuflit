using System;

namespace BT3
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, n;
            int[,] a;
            xulixau(out m,out n,out a);
            Console.WriteLine(sumA(a));
            Console.ReadKey();
        }

        public static void xulixau(out int m, out int n, out int[,] a)
        {
            var numberList = Console.ReadLine().Split(' ');
            m = int.Parse(numberList[0]);
            n = int.Parse(numberList[1]);
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

        public static int sumA(int[,] a)
        {
            int sum = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    sum = sum + a[i, j];
                }
            }

            return sum;
        }
    }
}