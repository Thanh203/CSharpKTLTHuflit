using System;
using System.Xml.Xsl;

namespace kiemtra1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static void InputMatrix(int[,] a)
        {
            var numberList1 = Console.ReadLine().Split();
            int m = int.Parse(numberList1[0]);
            int n = int.Parse(numberList1[1]);
            int x = int.Parse(numberList1[2]);
            int k = int.Parse(numberList1[3]);
            a = new int[m, n];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    var numberLisr2 = Console.ReadLine().Split();
                    a[i, j] = int.Parse(numberLisr2[j]);
                }
            }
        }

        static void PrintMatrixByRow(int[,] a)
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

        static int CountX(int[,] a, int x)
        {
            int d = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (x == a[i, j])
                    {
                        d++;
                    }
                }
            }
            return d;
        }

        static int sum(int[,] a, int left, int right)
        {
            
        }
    }
}