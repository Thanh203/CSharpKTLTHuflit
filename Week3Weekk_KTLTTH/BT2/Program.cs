using System;

namespace BT2
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberList = Console.ReadLine().Split();
            int a = int.Parse(numberList[0]);
            int n = int.Parse(numberList[1]);
            Console.WriteLine(lt(a, n));

            Console.ReadKey();
        }

        public static int lt(int a, int n)
        {
            if (n == 0)
            {
                return 1;
            } 
            else if (n % 2 == 0)
            {
                return lt(a, n / 2) * lt( a, n / 2);
            }
            else
            {
                return a * lt(a, (n - 1) / 2) * lt(a, (n - 1) / 2);
            }
        }
    }
}