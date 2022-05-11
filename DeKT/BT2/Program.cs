using System;

namespace BT2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap n = ");
            int n = int.Parse(Console.ReadLine());
            int s = 0;
            Console.WriteLine($"s = {cau2(n, s)}" );
            
            Console.ReadKey();
        }

        public static double cau2(int n, int s)
        {
            if (n == 1)
            {
                return  s ;
            }
            else
            {
                return s + cau2(n - 1, 2 * n - 1);
            }
        }
    }
}