using System;
using System.Collections.Generic;

namespace Week5Weekk_QuayLui
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] q = new int[n, n];

        }
        
        public static void Try(int i)
        {
            for (int j = 1; j <= 8; j++)
            {
                if ((col[j] == false) && (chinh[i + j] == false) && (phu[i - j + 7] == false))
                {
                    x[i] = j;
                    
                }
                else
                {
                    Try(i+ 1);
                }
            }

        }

        
    }
}