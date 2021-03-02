using System;

namespace Demo01CalculatorOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chuong trinh tinh chu vi va dien tich cua Hinh Hoc!");
			Console.WriteLine("Nhap vao lua chon cua ban:");
			Console.WriteLine("1. Tinh chu vi & dien tich hinh tron : ");
			Console.WriteLine("2. Tinh chu vi & dien tich hinh vuong :");
			Console.WriteLine("3. Tinh chu vi & dien tich hinh chu nhat :");

			Console.WriteLine("6. Thoat Khoi Chuong Trinh :");
            int choice;

            //Kiểm tra lựa chọn có phải là số hay không
            try
            {
                choice = Int32.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Lua chon nhap vao phai la so");
                choice = Int32.Parse(Console.ReadLine());
                
            }


            //Tạo Menu bằng vòng lặp While
            //Vòng lặp while sẽ thoát khi dk == false ; Nếu không có giá trị dừng thì vòng lặp while sẽ chạy đến vô tận
            bool checkMenu = true;
            while (checkMenu) {

                if (choice == 1)
                {
                    Console.WriteLine("Ban Chon Tinh Chu Vi Hinh Tron");
                    Console.WriteLine("Nhap vao ban kinh Hinh Tron :");
                    double r ;
                    try
                    {
                        r = double.Parse(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Ban kinh nhap vao phai la so");
                        r = double.Parse(Console.ReadLine());
                    }
                    HinhTron ht = new HinhTron(r);
                    ht.InThongTinHinh();
                    break;
                }else if (choice == 2)
                {
                    Console.WriteLine("Ban Chon Tinh Chu Vi Hinh Vuong");
                    Console.WriteLine("Nhap vao canh Hinh Vuong :");
                    double canh ;
                    //Kiem tra canh nhap vao co phai la so hay khong
                    try
                    {
                        canh = double.Parse(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Canh hinh vuong nhap vao phai la so");
                        canh = double.Parse(Console.ReadLine());
                    }
                    HinhVuong hv = new HinhVuong(canh);
                    hv.InThongTinHinh();
                    break;
                }else if (choice == 3)
                {
                    Console.WriteLine("Ban Chon Tinh Chu Vi Hinh Chu Nhat");

                    Console.WriteLine("Nhap vao chieu dai Hinh Chu Nhat :");
                    double CDai ;
                    //Kiem tra chieu dai nhap vao co phai la so hay khong
                    try
                    {
                        CDai = double.Parse(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Canh hinh vuong nhap vao phai la so");
                        CDai = double.Parse(Console.ReadLine());
                    }

                    Console.WriteLine("Nhap vao chieu rong Hinh Chu Nhat :");
                    double CRong ;
                    //Kiem tra chieu rộng nhap vao co phai la so hay khong
                    try
                    {
                        CRong = double.Parse(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Canh hinh vuong nhap vao phai la so");
                        CRong = double.Parse(Console.ReadLine());
                    }

                    HinhChuNhat hcn = new HinhChuNhat(CDai,CRong);
                    hcn.InThongTinHinh();
                    break;
                }
                else if (choice == 6) {
                    checkMenu = false;
                }
                else
                {
                    Console.WriteLine("Lua chon cua ban khong co trong menu ");
                    Console.WriteLine("Vui long nhap lai lua chon: ");
                    choice = Int32.Parse(Console.ReadLine());
                }
            }


            //Tạo Menu bằng switch case
            /*switch(choice)
            {
                case 1:
                    {
                        Console.WriteLine("Ban Chon Tinh Chu Vi Hinh Tron");
                        Console.WriteLine("Nhap vao ban kinh Hinh Tron :");
                        double r = double.Parse(Console.ReadLine());
                        HinhTron ht = new HinhTron(r);
                        ht.InThongTinHinh();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Ban Chon Tinh Chu Vi Hinh Vuong");
                        Console.WriteLine("Nhap vao canh Hinh Vuong :");
                        double canh = double.Parse(Console.ReadLine());
                        HinhVuong hv = new HinhVuong(canh);
                        hv.InThongTinHinh();
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Ban Chon Tinh Chu Vi Hinh Chu Nhat");

                        Console.WriteLine("Nhap vao chieu dai Hinh Chu Nhat :");
                        double CDai = double.Parse(Console.ReadLine());

                        Console.WriteLine("Nhap vao chieu rong Hinh Chu Nhat :");
                        double CRong = double.Parse(Console.ReadLine());

                        HinhChuNhat hcn = new HinhChuNhat(CDai,CRong);
                        hcn.InThongTinHinh();
                        break;
                    }
                case 6:
                    {
                        break;
                    }
                default:
                    break;
            }*/
        }
    }
}