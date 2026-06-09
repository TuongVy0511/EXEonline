using System;
using System.Collections.Generic;
using System.Text;

namespace giaide2
{
    internal class Bai_4
    {
        public static void Main(string[] arg)
        {
            Console.OutputEncoding=Encoding.UTF8;
            //nhập năm và kiểm tra số liệu bằng do-while
            int nam = 0;
            do
            {
                Console.WriteLine("Nhập vào năm bạn cần kiểm tra"); nam = int.Parse(Console.ReadLine());
                if(nam <= 0 || nam > 3000)
                {
                    Console.WriteLine("Hãy nhập năm trong khoảng từ 0 đến 3000!!!");
                }    
            }
            while (nam <= 0 || nam > 3000);
            //hàm kiểm tra năm nhuận
            string kiemtra = ((nam % 4 == 0 && nam % 100 != 0) || (nam % 400 == 0)) ? "Đây là nam nhuận" : "Đây không là năm nhuận";
            Console.WriteLine(kiemtra);
        }
    }
}
