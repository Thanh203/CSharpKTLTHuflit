using System;

namespace Slide11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap n = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(luythua(n, a));

            Console.ReadKey();

        }

        public static double luythua(int n, int a)
        {
            int x = a;
            if (n > 1)
            {
                n--;
                return a * luythua(n, x);
            }

            return a;
        }
    }
}