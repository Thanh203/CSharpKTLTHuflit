using System;

namespace BT1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a;
            int n;
            dulieuvao(out n, out a);
            int r = a.Length - 1;
            int l = 0;
            Console.WriteLine(mina(a,l, r));
        }

        public static void dulieuvao(out int n, out int[] a)
        {
            n = int.Parse(Console.ReadLine());
            var numberList = Console.ReadLine().Split();
            a = new int[n];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(numberList[i]);
            }
        }

        public static int mina(int[] a, int l, int r)
        {
            if (l == r)
            {
                return a[l];
            }
            int k = (l + r) / 2;
            
            int minl = mina(a, l, k);

            int minr = mina(a, k + 1, r);
            
            return Math.Min(minl, minr);
        }
    }
}