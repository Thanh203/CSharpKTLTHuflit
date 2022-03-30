using System;

public class Program
{
    static void xulixau(out int[,] arr, out int[,] arr1, out int[,] arr2, out int m, out int n, out int p)
    {
        var numberList = Console.ReadLine().Split(' ');
        m = int.Parse(numberList[0]);
        n = int.Parse(numberList[1]);
        p = int.Parse(numberList[2]);
        arr = new int[m, p];
        arr1 = new int[m, n];
        arr2 = new int[n, p];
        for (int i = 0; i < arr1.GetLength(0); i++)
        {
            var numberList2 = Console.ReadLine().Split(' ');
            for (int j = 0; j < arr1.GetLength(1); j++)
            {
                arr1[i, j] = int.Parse(numberList2[j]);
            }
        }
        for (int i = 0; i < arr2.GetLength(0); i++)
        {
            var numberList2 = Console.ReadLine().Split(' ');
            for (int j = 0; j < arr2.GetLength(1); j++)
            {
                arr2[i, j] = int.Parse(numberList2[j]);
            }
        }
    }
    static void SumMatAB(int[,] arr, int[,] arr1, int[,] arr2)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                arr[i, j] = arr1[i, j] * arr2[i, j];
            }
        }
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write(arr[i, j] + " ");
            }
        }
    }
    public static void Main()
    {
        int[,] arr;
        int[,] arr1;
        int[,] arr2;
        int m, n,p;
        xulixau(out arr, out arr1, out arr2, out m, out n,out p);
        SumMatAB(arr, arr1, arr2);

    }
}