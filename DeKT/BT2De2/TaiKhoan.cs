using System;

namespace BT2De2
{
    public class TaiKhoan
    {
        private string soTK;
        private string tenTK;
        private double soDu;
        private double laiSuat;
        
        public TaiKhoan(){}

        public TaiKhoan(string tenTK, string soTK, double soDu, double laiSuat)
        {
            this.soTK = soTK;
            this.tenTK = tenTK;
            this.soDu = soDu;
            this.laiSuat = laiSuat;
        }

        public void setLaiSuat(double newLaiSuat)
        {
            while ((laiSuat < 0) || (laiSuat > 20))
            {
                this.laiSuat = newLaiSuat;
            }
        }
        
        public void NapTien(double soTien)
        {
            if (soTien < 0)
            {
                Console.WriteLine("So tien chua dung");
            }
            else
            {
                this.soDu = soDu + soTien;
            }
        }

        public void RutTien(double soTien)
        {
            if (soTien > soDu)
            {
                Console.WriteLine("So tien muon rut vuot qua so du cua tia khoan");
            }
            else
            {
                this.soDu = soDu - soTien;
            }
        }

        public string ThongTinTK()
        {
            return $"Ten TK: {tenTK}, So TK: {soTK}, So du: {soDu}";
        }

        public void TinhLai()
        {
            this.soDu = soDu * laiSuat /(int) 100 + soDu;
        }
    }
}