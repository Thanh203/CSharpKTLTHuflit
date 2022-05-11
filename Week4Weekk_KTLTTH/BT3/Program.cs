using System;

namespace BT3
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = 'A';
            char b = 'B';
            char c = 'C';
            int n = int.Parse(Console.ReadLine());
            thaphanoi(n, a, b, c);
            
        }

        public static void thaphanoi(int n, char a, char b, char c)
        {
            if (n == 1)
            {
                Console.WriteLine($"Chuyen tu {a} sang {c}");
            }
            else
            {
                thaphanoi(n - 1, a, c, b);
                thaphanoi(1, a, b, c);
                thaphanoi(n - 1, b, a, c);
            }
        }

        
    }
}