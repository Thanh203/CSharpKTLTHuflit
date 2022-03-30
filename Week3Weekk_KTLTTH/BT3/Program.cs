using System;

namespace BT3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("nhap a =");
            int a = int.Parse(Console.ReadLine());
            Console.Write("nhap b =");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(ucln(a, b));

            Console.ReadKey();
        }

        public static int ucln(int a, int b)
        {
            if (a % b == 0)
            {
                return b;
            }
            else
            {
                return ucln(b, a % b);
            }
        }
    }
}