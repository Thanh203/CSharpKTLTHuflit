using System;
using System.Reflection.Metadata.Ecma335;

namespace OnTapjDeQuy
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        static double tong(int n, int s)
        {
            if (n == 0)
            {
                return s;
            }
            else
            {
                int gt = 1;
                for (int i = 1; i <= n; i++)
                {
                    gt  = gt * i;
                }
                s = s + n! / (n * (n + 1));
            }
        }
    }
}/*
n = 4
i = 1 => gt = 1 * 1 = 1;
i = 2 => gt = 1 * 2 = 2;
i = 3 => gt = 3 * 2 = 6
*/