using System;
using System.Collections.Generic;

namespace BT1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a;
            input(out a);
            List<int> primeNumbers = findAllPrime(a);
            if (primeNumbers.Count > 0)
                 interchangeSort(primeNumbers);

            Console.ReadKey();
        }
        public static void input(out int[] a)
        {
            int n = int.Parse(Console.ReadLine());
            var numberList = Console.ReadLine().Split();
            a = new int[numberList.Length];
            for (int i = 0; i < numberList.Length; i++)
            {
                a[i] = int.Parse(numberList[i]);
            }
        }
        public static bool isPrime(int x)
        {
            
            for (int i = 2; i <= Math.Sqrt(x); i++)
            {
                if (x % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        
        public static List<int> findAllPrime(int[] a)
        {
            int k = 0;
            List<int> b = new List<int>(1000);
            for (int i = 0; i < a.Length; i++)
            {
                int d = 0;
                for (int j = 2; j <= Math.Sqrt(a[i]); j++)
                {
                    if (a[i] % j == 0)
                    {
                        d++;
                    }
                }
                if (d == 0)
                { 
                    b[i] = a[i];
                    k++;
                }
            }
            return b;
        }

        public static void interchangeSort(List<int> intList)
        {
            
        }
    }
}