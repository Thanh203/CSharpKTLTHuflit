using System;

namespace BT5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(dem(n));

            Console.ReadKey();
        }

        public static int dem(int n)
        {
            int s = 2;
            if ((n == 1) || (n == 2))
            {
                return 1;
            } 
            else
            {
                return dem(n - 1) + dem(n - 2);
            }
        }
    }
}