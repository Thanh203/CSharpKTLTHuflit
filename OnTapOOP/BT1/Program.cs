using System;

namespace BT1
{
    class Program
    {
        static void Main(string[] args)
        {
            TraTruoc T = new TraTruoc();
            T.NhapThongTin();
            T.TinhCuoc(10);
            Console.WriteLine(T.toString());
        }
    }
}