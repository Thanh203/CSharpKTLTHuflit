using System;

namespace BT2BTT
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x;
            int[] a;
            dulieuvao(out n, out x, out a);
            int left = 0;
            int right = a.Length - 1;
            Console.WriteLine(srch(n, x, a, left, right));

            Console.ReadKey();
        }
        public static void dulieuvao(out int n,out int x, out int[] a)
        {
            var numberList = Console.ReadLine().Split();
            n = int.Parse(numberList[0]);
            x = int.Parse(numberList[1]);
            numberList = Console.ReadLine().Split();
            a = new int[n];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(numberList[i]);
            }
        }

        public static int srch(int n, int x, int[] a, int left, int right)
        {
            int mid = (left + right) / 2;
            if (left > right)
            {
                return -1;
            } 
            else if (a[mid] == x)
            {
                return mid;
            } else if (a[mid] > x)
            {
                return srch(n, x, a, left, mid - 1);
            }
            else
            {
                return srch(n, x, a, mid - 1, right);
            }
        }
    }
}