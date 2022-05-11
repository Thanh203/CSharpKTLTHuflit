using System;

namespace BT1
{
    class Program
    {
        static int FindMin(int[] a, int left, int right)
        {
            if (left == right)
                return a[left];
            int mid = (left + right) / 2;
            int midL = FindMin(a, left, mid);
            int midR = FindMin(a, mid + 1, right);
            return Math.Min(midL, midR);
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var numberList = Console.ReadLine().Split();
            int[] a = new int[n];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(numberList[i]);
            }

            int left = 0;
            int right = n - 1;
            Console.WriteLine(FindMin(a, left, right));
            Console.ReadKey();
        }
    }
}