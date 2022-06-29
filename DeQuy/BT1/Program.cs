using System;
//Cho hai số nguyên dương a và n. Tính a ^ n.
namespace BT1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, a;
            var numberList = Console.ReadLine().Split();
            a = int.Parse(numberList[0]);
            n = int.Parse(numberList[1]);
            Console.WriteLine(dequy(a, n));

        }

        public static double dequy(int a, int n)
        {
            if (n == 1)
            {
                return a;
            }
            else
            {
                return a * dequy(a , n - 1);
            }
        }
    }
}