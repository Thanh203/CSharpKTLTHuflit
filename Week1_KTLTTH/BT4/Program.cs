using System;

namespace BT3
{
    class Program
    {
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

        public static int sumRowsK(int k,int[,] a)
        {
            int sum = 0;
            for (int i = 0; i < a.GetLength(1); i++)
            {
                sum += a[k, i];
            }
            return sum;
        }
        public static int sumColsK(int k, int[,] a)
        {
            int sum = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                sum += a[i, k];
            }
            return sum;
        }
        public static int sumAll(int[,] a)
        {
            int sum = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    sum += a[i, j];
                }
            }
            return sum;
        }
        public static int sumChan(int[,] a)
        {
            int sum = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] % 2 == 0)
                    {
                        sum += a[i, j];
                    }
                }
            }
            return sum;
        }
        public static int sumLe(int[,] a)
        {
            int sum = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] % 2 != 0)
                    {
                        sum += a[i, j];
                    }
                }
            }
            return sum;
        }
        public static double AvgAll(int[,] a)
        {
            int sum = sumAll(a);
            double avg;
            avg = sum / (double)(a.GetLength(0) * a.GetLength(1));
            return avg;
        }

        static void Main(string[] args)
        {
            int m, n, k;
            int[,] a;
            xulixau(out m, out n, out k, out a);
            Console.WriteLine($"Tong cac phan tu dong {k} la: {sumRowsK(k, a)}");
            Console.WriteLine($"Tong cac phan tu cot {k} la: {sumColsK(k, a)}");
            Console.WriteLine($"Tong cac phan tu la: {sumAll(a)}");
            Console.WriteLine($"Tong cac phan tu chan la: {sumChan(a)}");
            Console.WriteLine($"Tong cac phan tu le la: {sumLe(a)}");
            Console.WriteLine($"Tong trung binh cac phan tu la: {AvgAll(a)}");

            Console.ReadKey();
        }
    }
}
