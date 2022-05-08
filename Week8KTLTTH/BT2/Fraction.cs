using System;


namespace BT2
{
    public class Fraction
    {
        public int numertor;
        public int denominator;
        
        public Fraction() { }

        public Fraction(int numertor, int denominator)
        {
            this.numertor = numertor;
            this.denominator = denominator;
        }

        public Fraction(int numertor)
        {
            this.numertor = numertor;
        }
        public void Input()
        {
            Console.Write("Tu: ");
            this.numertor = int.Parse(Console.ReadLine());
            Console.Write("Mau: ");
            this.denominator = int.Parse(Console.ReadLine());
        }

        public void GCD(int a, int b)
        {
            int t = 1;
            int min = Math.Min(a, b);
            for (int i = 1; i <= min; i++)
            {
                if ((a % i == 0) &&(b % i == 0))
                {
                    t = i;
                }
            }
            Console.WriteLine(t);
        }

        public void simplify()
        {
            int t = 1;
            int min = Math.Min(numertor, denominator);
            for (int i = 1; i <= min; i++)
            {
                if ((numertor % i == 0) &&(denominator % i == 0))
                {
                    t = i;
                }
            }

            for (int i = 1; i <= numertor; i++)
            {
                if (i * t == numertor)
                {
                    this.numertor = i;
                }
            }
            for (int i = 1; i <= denominator; i++)
            {
                if (i * t == denominator)
                {
                    this.denominator = i;
                }
            }
            
            Console.WriteLine($"{this.numertor} / {this.denominator}");
        }

        public virtual string ToString()
        {
            return $"{numertor} / {denominator}";
        }

        public double toDecimal()
        {
            return numertor / (double) denominator;
        }

        public Fraction add(Fraction f)
        {
            Fraction result = new Fraction();
            if (this.denominator == f.denominator)
            {
                result.denominator = this.denominator;
                result.numertor = this.numertor + f.numertor;
            }
            else
            {
                result.numertor = this.numertor * f.denominator + this.denominator * f.numertor;
                result.denominator = f.denominator * this.denominator;
            }
            return result;
        }
        
        public Fraction subtract(Fraction f)
        {
            Fraction result = new Fraction();
            if (this.denominator == f.denominator)
            {
                result.denominator = this.denominator;
                result.numertor = this.numertor - f.numertor;
            }
            else
            {
                result.numertor = this.numertor * f.denominator - this.denominator * f.numertor;
                result.denominator = f.denominator * this.denominator;
            }
            return result;
        }
        
        public Fraction multiply(Fraction f)
        {
            Fraction result = new Fraction();
            result.numertor = this.numertor * f.numertor;
            result.denominator = f.denominator * this.denominator;
            return result;
        }
        
        public Fraction divide(Fraction f)
        {
            Fraction result = new Fraction();
            result.numertor = this.numertor * f.denominator;
            result.denominator = f.numertor * this.denominator;
            return result;
        }
    }
}