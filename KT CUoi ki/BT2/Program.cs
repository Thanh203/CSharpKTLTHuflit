using System;
using System.Diagnostics.CodeAnalysis;

namespace BT2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Tong(n));
        }

        public static int Tong(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n * n + Tong(n - 1);
            }
        }
    }
}