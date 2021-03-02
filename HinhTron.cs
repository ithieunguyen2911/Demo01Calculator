using System;
using System.Collections.Generic;
using System.Text;

namespace Demo01CalculatorOOP
{
    public class HinhTron : HinhHoc
    {
        const double PI = 3.14159;
        private double r;
        private string TenHinh = "Tron";


        public HinhTron(double r)
        {
            this.r = r;
        }

        //Cong thu tinh chu vi Hinh Tron = r * 2 * pi
        public override double ChuVi()
        {
            double cv = r * 2 * PI;
            return cv;
        }

        //Cong thuc tinh dien tich Hinh Tron  = r * r * pi
        public override double DienTich()
        {
            return r * r * PI;
        }



        public override void InThongTinHinh()
        {

            string cv = "Day la chu vi hinh " + TenHinh + " co gia tri chu vi la :" + ChuVi().ToString();
            Console.WriteLine(cv);
            string dt = "Day la chu vi hinh " + TenHinh + " co gia tri chu vi la :" + DienTich().ToString();
            Console.WriteLine(dt);
        }
    }
}
