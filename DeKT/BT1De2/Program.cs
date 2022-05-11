using System;

namespace BT1De2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a;
            Input(out a);
            int[] b = CountFrequency(a);
            for (int i = 0; i < b.Length; i++)
            {
                if (b[i] != 0)
                {
                    Console.WriteLine($"{i}: {b[i]}");
                }
            }
            
            Console.WriteLine($"S = {SumOfElements(b)}");
            
            Console.ReadKey();
        }

        static void Input(out int[] a)
        {
            int n = int.Parse(Console.ReadLine());
            var numberList = Console.ReadLine().Split();
            a = new int[n];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(numberList[i]);
            }
        }

        

        static int[] CountFrequency(int[] a)
        {
            int max = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }
            int[] b = new int[max + 1];
            for (int i = 0; i < a.Length; i++)
            {
                b[a[i]]++;
            }

            return b;
        }

        static int SumOfElements(int[] count)
        {
            int sum = 0;
            for (int i = 0; i < count.Length; i++)
            {
                if ((count[i] != 0) && ((count[i] == i) || (count[i] > i)))
                {
                    sum = sum + i;
                }
            }

            return sum;
        }
    }
}