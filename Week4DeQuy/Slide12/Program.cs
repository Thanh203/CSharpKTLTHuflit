using System;

namespace Slide12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("nhap n =");
            long n = long.Parse(Console.ReadLine());
            Console.WriteLine(fb(n));

            Console.ReadKey();
        }

        public static long fb(long n)
        {
            if ((n == 1) || (n == 2))
            {
                return 1;
            }
            else 
            {
                return fb(n - 1) + fb(n -2);
            }
        }
    }
}