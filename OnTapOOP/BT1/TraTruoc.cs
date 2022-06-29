using System;

namespace BT1
{
    public class TraTruoc: ThueBao
    {
        private double soTienTK;
        
        public TraTruoc(){}

        public TraTruoc(string hoTen, string soDT, double soTienTK)
            : base(hoTen, soDT)
        {
            this.soTienTK = soTienTK;
        }

        public void NhapThongTin()
        {
            base.Input();
            Console.Write("Nhap so tien trong tk: ");
            this.soTienTK = double.Parse(Console.ReadLine());
        }

        public void NapTien(double soTien)
        {
            this.soTienTK = soTienTK + soTien;
        }

        public double TinhCuoc(int soGiay)
        {
            if (soGiay > 6)
            {
                this.soTienTK = soTienTK - (soGiay - 6) * 20;
                return TinhCuoc(soGiay - 6);
            }
            else
            {
                this.soTienTK = soTienTK - 500;
            }

            return soTienTK;
        }

        public override string toString()
        {
            return base.toString() + $", So tien trong TK: {soTienTK}";
        }
    }
}