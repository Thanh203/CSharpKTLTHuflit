using System;

namespace BT1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(gt(n));

            Console.ReadKey();
        }

        public static int gt(int n)
        {
            if (n <= 1)
            {
                return 1;
            }
            else
            {
                return n * (gt(n - 1));
            }
        }
    }
}