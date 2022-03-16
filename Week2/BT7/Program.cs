using System;
using System.Security.Cryptography.X509Certificates;

namespace BT7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int[,] a;
            dulieuvao(out n, out a);
            intg(n, a);
            Console.ReadKey();
        }

        public static void dulieuvao(out int n, out int[,] a)
        {
            n = int.Parse(Console.ReadLine());
            a = new int[n, n];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                var numberList = Console.ReadLine().Split(' ');
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = int.Parse(numberList[j]);
                }
            }
            
        }

        public static void intg(int n, int[,] a)
        {
            int j = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (j ; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + " ");
                }

                j++;
                Console.WriteLine();
            }
        }
    }
}