using System;
using System.Net;

namespace BT1
{
    public class ThueBao
    {
        string hoTen;
        string soDT;

        public ThueBao(){}

        public ThueBao(string hoTen, string soDT)
        {
            this.hoTen = hoTen;
            this.soDT = soDT;
        }

        public void Input()
        {
            Console.Write("Nhap ho ten: ");
            this.hoTen = Console.ReadLine();
            Console.Write("Nhap sdt: ");
            this.soDT = Console.ReadLine();
        }
        public string getHoTen()
        {
            return hoTen;
        }
        
        public string getSoDT()
        {
            return soDT;
        }

        public void setHoTen(string newhoTen)
        {
            this.hoTen = newhoTen;
        }
        
        public void setSoDT(string newsoDT)
        {
            int d = newsoDT.Length;
            for (int i = 0; i < d; i++)
            {
                if ((d == 10)&&(newsoDT[i] >= '0')&&(newsoDT[i] <= '9'))
                {
                    this.soDT = newsoDT;
                }
                else
                {
                    Console.WriteLine("So dien thoai khong dung");
                    this.soDT = soDT;
                }
            }
        }

        public virtual string toString()
        {
            return $"ThueBao[Ho Ten = {hoTen}, So DT = {soDT}";
        }
    }
}