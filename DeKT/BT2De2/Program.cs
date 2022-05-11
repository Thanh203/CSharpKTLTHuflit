using System;

namespace BT2De2
{
    class Program
    {
        static void Main(string[] args)
        {
            TaiKhoan TK1 = new TaiKhoan("Le Minh Thanh","0123456789", 0, 5);
            TK1.NapTien(5000000);
            TK1.RutTien(3000000);
            TK1.TinhLai();
            Console.WriteLine(TK1.ThongTinTK());
        }
    }
}