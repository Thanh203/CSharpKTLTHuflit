using System;

namespace BT4
{
    class Program
    {
        static void Main(string[] args)
        {
            Date DMY = new Date();
            DMY.intput();
            Console.WriteLine(DMY.getDay());
            Console.WriteLine(DMY.getMonth());
            Console.WriteLine(DMY.getYear());
            Console.WriteLine(DMY.toString());

            Console.ReadKey();
        }
    }
}