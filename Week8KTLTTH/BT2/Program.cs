using System;

namespace BT2
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction F1 = new Fraction();
            Fraction F2 = new Fraction(5, 7);
            F1.Input();
            F1.simplify();
            //F1.GCD(F2);
            Console.WriteLine("a / b = " + F1.ToString());
            Console.WriteLine("Thap phan: " + F1.toDecimal());
            Console.WriteLine("Tong: " + F1.add(F2).ToString());
            Console.WriteLine("Hieu: " + F1.subtract(F2).ToString());
            Console.WriteLine("Tich: " + F1.multiply(F2).ToString());
            Console.WriteLine("Thuong: " + F1.divide(F2).ToString());
            
            MixedFraction M1 = new MixedFraction();
            M1.Input();
            M1.simplify();
            Console.WriteLine($"Hon so la: {M1.ToString()}");
            
            Console.ReadKey();


        }
    }
}