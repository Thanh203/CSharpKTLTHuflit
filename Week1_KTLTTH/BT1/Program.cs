using System;

namespace C1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Nhap mang a:");
            int[,] a;
            NhapMang1(out a);
            Console.WriteLine("Mang a vua nhap:");
            XuatMang(a);

            Console.WriteLine("Nhap mang b:");
            int[,] b;
            b = NhapMang2();
            Console.WriteLine("Mang b vua nhap:");
            XuatMang(b);

            Console.WriteLine("Nhap mang c:");
            int m, n;
            m = int.Parse(Console.ReadLine());
            n = int.Parse(Console.ReadLine());
            int[,] c = new int[m, n];
            NhapMang3(c);
            Console.WriteLine("Mang c vua nhap:");
            XuatMang(c);

            Console.ReadKey();
        }
        public static void NhapMang1(out int[,] a)
        {
            Console.Write("Nhap rows = ");
            int r = int.Parse(Console.ReadLine());
            Console.Write("Nhap cols = ");
            int c = int.Parse(Console.ReadLine());
            a = new int[r, c];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"a[{i},{j}]= ");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }

        }
        public static int[,] NhapMang2()
        {
            Console.Write("Nhap rows = ");
            int r = int.Parse(Console.ReadLine());
            Console.Write("Nhap cols = ");
            int c = int.Parse(Console.ReadLine());
            int[,] a = new int[r, c];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"a[{i},{j}]= ");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }

            return a;
        }
        public static int[,] NhapMang3(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"a[{i},{j}]= ");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            return a;
        }
        public static void XuatMang(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"{a[i,j]} ");
                   
                }
                Console.WriteLine();
            }
        }
    }
}
