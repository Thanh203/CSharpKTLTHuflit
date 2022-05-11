using System;

namespace BT2BTT
{
    class Program
    {
        static void Main(string[] args)
        {
            NhanVien NV1 = new NhanVien();
            NV1.input();
            Console.WriteLine(NV1.toString() + $" -- Luong: {NV1.pay()}");

            Console.ReadKey();
        }
    }
}