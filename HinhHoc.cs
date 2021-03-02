using System;
using System.Collections.Generic;
using System.Text;

namespace Demo01CalculatorOOP
{
    public abstract class HinhHoc
    {

       /* public static string TenHinh;*/

        public abstract double ChuVi();
        public abstract double DienTich();

        public virtual void InThongTinHinh() {
            Console.WriteLine("In thông tin hình học");
        }

        /*
         Về bản chất thì abstract method và virtual method là 2 phương thức viết ra để lớp con có thể kế thừa được.
            
            Điểm khác biệt:
            abstract method: Thì không có nội dung bên trong. Và nó chỉ được khai báo bên trong class abstract.
            virtual method: thì có nội dung bên trong. class chứa nó không cần phải là class abstract.
            Khi một class con kế thừa lại thì từ class cha: 
                Bắt buộc phải override abstract method() nếu có.
                Không bắt buộc override virtual method().*
         */
    }
}
