using System;
using System.Collections.Generic;
using System.Text;

namespace giaide1
{
    internal class Bai_4
    {
        public static void Main(string[] arg)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //kiểm tra nhập tháng
            int thang = 0;
            do
            {
                Console.WriteLine("Nhap vao thang");
                thang = int.Parse(Console.ReadLine());
                if(thang>12||thang<=0)
                {
                    Console.WriteLine("Hay nhap lai thang tu 1 den 12 de kiem tra!!");
                }    
            }
            while
            (thang > 12 || thang <= 0);

            //Kiểm tra số ngày
            switch(thang)
            {
                case 2:
                    Console.WriteLine($"so ngay trong thang {thang} la 28 hoac 29 ngay !");
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine($"so ngay trong thang {thang} la 30 ngay!");
                    break;
                default:
                    Console.WriteLine($"So ngay trong thang {thang } la 31 ngay!");
                    break;
            }    
        }
    }
}