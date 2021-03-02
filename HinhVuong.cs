using System;
using System.Collections.Generic;
using System.Text;

namespace Demo01CalculatorOOP
{
    class HinhVuong:HinhHoc
    {
        private double canh;

        public HinhVuong(double Canh)
        {
            canh = Canh;
        }

        //Chu vi hình vuông = cạnh * 4
        public override double ChuVi()
        {
            return canh * 4;
        }

        public override double DienTich()
        {
            return canh * canh;
        }

        // Diện tích hình vuông  = cạnh * cạnh


        //In thông tin hình 
        public override void InThongTinHinh()
        {
            string cv = "Day la chu vi hinh Vuong co gia tri chu vi la :" + ChuVi().ToString();
            Console.WriteLine(cv);
            
            string dt = "Day la dien tich hinh Vuong co gia tri chu vi la :" + DienTich().ToString();
            Console.WriteLine(dt);

        }

      
    }
}
