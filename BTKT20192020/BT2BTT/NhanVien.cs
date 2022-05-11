using System;
using System.Runtime.CompilerServices;

namespace BT2BTT
{
    public class NhanVien
    {
        private string staffID;
        private string name;
        private double payRate;
        private double baseRate;
        
        public NhanVien() { }

        public NhanVien(string staffId, string name, double payRate, double baseRate)
        {
            this.staffID = staffId;
            this.name = name;
            this.payRate = payRate;
            this.baseRate = baseRate;
            
        }

        static void setBaseRate(double baseRate)
        {
            baseRate = 1500;
        }
        
        public void input()
        {
            Console.Write("Nhap StaffID: ");
            this.staffID = Console.ReadLine();
            
            Console.Write("Nhap name: ");
            this.name = Console.ReadLine();
            
            Console.Write("Nhap PayRate: ");
            this.payRate = double.Parse(Console.ReadLine());

            while (payRate <= 0)
            {
                Console.Write("Nhap lai PayRate (payRate > 0): ");
                this.payRate = double.Parse(Console.ReadLine());
            }
            
            /*Console.Write("Nhap BaseRate: ");
            this.baseRate = double.Parse(Console.ReadLine());*/
        }

        public string toString()
        {
            string s = "";
            s = $"NhanVien[MaNV = {this.staffID}, HoTen = {this.name}, HS Luong = {this.payRate}]";
            return s;
        }

        public double pay()
        {
            return this.baseRate * this.payRate;
        }
    }
}