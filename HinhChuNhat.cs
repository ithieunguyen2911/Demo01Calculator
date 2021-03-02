using System;
using System.Collections.Generic;
using System.Text;

namespace Demo01CalculatorOOP
{
    class HinhChuNhat:HinhHoc
    {
        //Khai báo biến
        private double chieuDai;
        private double chieuRong;

        public HinhChuNhat(double ChieuDai, double ChieuRong)
        {
            this.chieuDai = ChieuDai;
            this.chieuRong = ChieuRong;
        }

        //Chu vi hình chu nhat = (dai + rong)*2
        public override double ChuVi()
        {
            return (chieuDai + chieuRong) * 2;
        }

        public override double DienTich()
        {
            return chieuDai * chieuRong;
        }


        // Diện tích hình chu nhat  = dai * rong

        //In thông tin hình 
        public override void InThongTinHinh()
        {

           /* string s = "Day la chu vi hinh Chu Nhat co gia tri chu vi la :" + ChuVi().ToString();*/
           //Dùng nội suy chuỗi trong c#
            string cv = $"Day la chu vi hinh Chu Nhat co gia tri chu vi la : {ChuVi().ToString()}";
            Console.WriteLine(cv);
            string dt = $"Day la dien tich hinh Chu Nhat co gia tri chu vi la : {DienTich().ToString()}";
            Console.WriteLine(dt);
        }
    }
}
