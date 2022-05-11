using System;
using System.Runtime.CompilerServices;

namespace BT3
{
    public class Rectangle
    {
        private double width;
        private double height;

        public Rectangle() { }

        public Rectangle(double width, double height)
        {
            this.height = height;
            this.width = width;

        }
        
        public void input()
        {
            Console.Write("Nhap Width: ");
            this.width = int.Parse(Console.ReadLine());
            
            while (width < 0)
            {
                Console.Write("Nhap lai Width: ");
                this.width = int.Parse(Console.ReadLine());
            }
            
            Console.Write("Nhap Height: ");
            
            this.height = int.Parse(Console.ReadLine());
            while (height < 0)
            {
                Console.Write("Nhap lai Height: ");
                this.height = int.Parse(Console.ReadLine());
            }
        }

        public string toString()
        {
            string s = "";
            s = $"Width = {width} \n Height = {height}";
            return s;
        }

        public double getArea()
        {
            return width * height;
        }

        public double getPerimeter()
        {
            return (width + height) * 2;
        }

        public bool isSameArea(Rectangle rect)
        {
            if (rect.getArea() == this.getArea())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}