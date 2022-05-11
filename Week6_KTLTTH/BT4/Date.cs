using System;

namespace BT4
{
    public class Date
    {
        private int day;
        private int month;
        private int year;
        
        public Date(){ }

        public Date(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public void intput()
        {
            Console.Write("Nhap ngay: ");
            this.day = int.Parse(Console.ReadLine());
            while ((this.day < 1)||(this.day > 31))
            {
                Console.Write("Nhap lai ngay: ");
                this.day = int.Parse(Console.ReadLine());
            }
            
            Console.Write("Nhap thang: ");
            this.month = int.Parse(Console.ReadLine());
            while ((this.month < 1)||(this.month > 12))
            {
                Console.Write("Nhap lai ngay: ");
                this.month = int.Parse(Console.ReadLine());
            }
            
            Console.Write("Nhap nam: ");
            this.year = int.Parse(Console.ReadLine());
            while ((this.year < 1900)||(this.year > 9999))
            {
                Console.Write("Nhap lai nam: ");
                this.year = int.Parse(Console.ReadLine());
            }
        }
        
        public int getDay()
        {
            return day;
        }

        public int getMonth()
        {
            return month;
        }

        public int getYear()
        {
            return year;
        }

        public void setDay(int day)
        {
            this.day = day;
        }
        
        public void setMonth(int month)
        {
            this.month = month;
        }

        public void setYear(int year)
        {
            this.year = year;
        }

        public void setDate(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public string toString()
        {
            string s = "";
            s = $"{day}/{month}/{year}";
            return s;
        }
    }
}