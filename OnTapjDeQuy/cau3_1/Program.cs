using System;

namespace cau3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap n = ");
            int n = int.Parse(Console.ReadLine());
            double s = 0;
            Console.WriteLine(tinh(n, s));

            Console.ReadKey();
        }

        public static double tinh(int n, double s)
        {
            int t = 1;
            if (n == 0)
            {
                return s;
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    t = t * i;
                }
                s = s + t /(double) (n * (n + 1));
                return tinh(n - 1, s);
            }
        }
    }
}