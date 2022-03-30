using System;

namespace BT4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());
            Console.WriteLine(bin(chuyendoi(n)));
            
            Console.ReadKey();
        }

        public static string chuyendoi(int n)
        {
            string s = "";
            if (n == 0)
            {
                return s;
            }
            else if (n == 1)
            {
                n = 0;
                s += '1';
                return s + chuyendoi(n);
            }
            else
            {
                if (n % 2 == 0)
                {
                    s += '0';
                    n = n / 2;
                    return s + chuyendoi(n);
                }
                else
                {
                    s += '1';
                    n = n / 2;
                    return s + chuyendoi(n);
                }
            }
        }

        public static string bin(string s)
        {
            string s2 = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                s2 += s[i];
            }

            return s2;
        }
    }
}