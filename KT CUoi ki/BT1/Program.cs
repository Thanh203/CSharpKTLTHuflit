using System;

namespace BT1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a;
            ReadMatrix(out a);
            PrintMatrix(a);
            Console.WriteLine(CountMatrix(a));
            
            
        }

        static void ReadMatrix(out int[,] a)
        {
            int m, n;
            Console.WriteLine("Nhap so dong m = ");
            m = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so dong n = ");
            n = int.Parse(Console.ReadLine());
            a = new int[m, n];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"a[{i}, {j}] = ");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        
        static void PrintMatrix(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"{a[i, j]} ");
                }
                Console.WriteLine();
            }
        }
        
        static int CountMatrix(int[,] a, int k)
        {
            int d = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] > k)
                    {
                        d++;
                    }
                }
            }

            return d;
        }
    }
}