using System;

namespace BT4
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, n;
            int[,] a;
            xulixau(out m,out n,out a);
            TBM(a);
            Console.ReadKey();
        }

        public static void xulixau(out int m, out int n, out int[,] a)
        {
            Console.WriteLine("nhap so luong hoc sinh:");
            m = int.Parse(Console.ReadLine());
            n = 3;
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

        public static void TBM(int[,] a)
        {
            
            for (int i = 0; i < a.GetLength(1); i++)
            {
                int sum = 0;
                for (int j = 0; j < a.GetLength(0); j++)
                {
                    sum = sum + a[j, i];
                }

                double dtb = sum / (double) a.GetLength(0);
                Console.WriteLine(dtb);
            }
            for (int i = 0; i < a.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    sum = sum + a[i, j];
                }
                double dtb = sum / (double) a.GetLength(1);
                Console.WriteLine(dtb);
            }
        }
    }
}