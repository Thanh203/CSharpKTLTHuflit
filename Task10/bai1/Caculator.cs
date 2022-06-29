using System;

namespace bai1
{
    public class Caculator
    {
        public Caculator(){}
        
        public int Add(int a, int b)
        {
            return a + b;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }
        
        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public int Multyply(int a, int b)
        {
            return a * b;
        }
        
        public double Multyply(double a, double b)
        {
            return a * b;
        }
        
        public double Divide(int a, int b)
        {
            return a /(double) b;
        }
        
        public double Divide(double a, double b)
        {
            return a /(double) b;
        }
        
        public int Min(int a, int b)
        {
            return Math.Min(a,b);
        }
        
        public int Min(int a, int b, int c)
        {
            int t = Math.Min(a, b);
            int t2 = Math.Min(t, c);
            return t2;
        }
        
        public double Min(double a, double b, double c)
        {
            double t = Math.Min(a, b);
            double t2 = Math.Min(t, c);
            return t2;
        }
        
        public int Max(int a, int b)
        {
            return Math.Max(a,b);
        }
        
        public int Max(int a, int b, int c)
        {
            int t = Math.Max(a, b);
            int t2 = Math.Max(t, c);
            return t2;
        }
        
        public double Max(double a, double b, double c)
        {
            double t = Math.Max(a, b);
            double t2 = Math.Max(t, c);
            return t2;
        }
    }
}