using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security.Principal;

namespace BT1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int row = 0;
            int col = 0;
            int[,] A = new int[row, col];
            Input(A, row, col);
            Console.WriteLine(Print(A));

            Console.ReadKey();
        }

        public static void Input(int[,] A, int row, int col)
        {
            Console.Write("Nhap row = ");
            row = int.Parse(Console.ReadLine());
            Console.Write("Nhap col = ");
            col = int.Parse(Console.ReadLine());
            A = new int[row, col];
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Console.Write($"A[{i},{j}]= ");
                    A[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        public static int Print(int[,] A)
        {
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    for (int k = 1; k <= Math.Sqrt(A[i, j]); k++)
                    {
                        if (A[i, j] == k * k)
                        {
                            return A[i, j];
                        }
                    }
                }
            }

            return 0;
        }
    }
}