using System;

namespace BT3
{
    public class Computer
    {
        protected string cpu;
        protected int ram;
        protected int storage;
        protected double price;

        public Computer(){}

        public Computer(string cpu, int ram, int storage, double price)
        {
            this.cpu = cpu;
            this.ram = ram;
            this.storage = storage;
            this.price = price;
        }

        public void overide Input()
        {
            Console.Write("Nhap cpu = ");
            this.cpu = Console.ReadLine();
            Console.Write("Nhap ram = ");
            this.ram = int.Parse(Console.ReadLine());
            Console.Write("Nhap storage = ");
            this.storage = int.Parse(Console.ReadLine());
            Console.Write("Nhap price = ");
            this.price = double.Parse(Console.ReadLine());
        }

        public double Getprice()
        {
            return this.price;
        }

        public void Setprive(double newprive)
        {
            if (newprive < 0)
            {
                Console.WriteLine("Invalid price");
            }
            else
            {
                this.price = newprive;
            }
        }
        public virtual string ToString()
         {
             return $"CPU: {cpu}, Ram: {ram}, Storage: {storage}, Price: {price} ";
         }
    }
}