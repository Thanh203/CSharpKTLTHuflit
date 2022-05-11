using System;

namespace BT3
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle H1 = new Rectangle();
            Rectangle R2 = new Rectangle(4, 7);
            H1.input();
            Console.WriteLine($"Thong so hinh chu nhat: \n {H1.toString()}");
            Console.WriteLine($"Chu vi: {H1.getPerimeter()}");
            Console.WriteLine($"Dien tich: {H1.getArea()}");
            Console.WriteLine(H1.isSameArea(R2));

            Console.ReadKey();
        }
    }
}