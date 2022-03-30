using System;

namespace BT2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            var numberList = Console.ReadLine().Split();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(numberList[i]);
            }
            int l = 0;
            int r = a.Length - 1;
            
            Console.WriteLine(srch(a,x,l,r));
            
            Console.ReadKey();
        }
        
        public static int srch(int[] a, int x, int l, int r)
        {
            if (l < r)
            {
                int m = (l + r) / 2;
                if (a[m] == x)
                {
                    return m;
                }else if (a[m] > x)
                {
                    return srch(a, x, l, m - 1);
                }
                else
                {
                    return srch(a, x, m + 1, r);
                }
            }

            return -1;
        }
    }
}