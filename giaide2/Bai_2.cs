using System;
using System.Collections.Generic;
using System.Text;

namespace giaide2
{
    internal class Bai_2
    {
        public static void Main(string[] arg)
        {
            Console.OutputEncoding= Encoding.UTF8;
            //nhập tên
            Console.WriteLine("Nhập tên của bạn");
            string hoten=Console.ReadLine();
            //xử lý điểm với vòng lặp do-while để tránh nhập sai
            double giuaky = 0;
            double cuoiky = 0;
            do
            {
                Console.WriteLine("Nhập điểm giữa kì"); giuaky = double.Parse(Console.ReadLine());
                Console.WriteLine("Nhập điểm cuối kì"); cuoiky=double.Parse(Console.ReadLine());
                if(giuaky <= 0 || giuaky > 10 & cuoiky <= 0 || cuoiky > 10)
                {
                    Console.WriteLine("Nhập điểm nằm trong khoảng từ 0 đến 10!!");
                }    
            }
            while ((giuaky < 0 || giuaky > 10) ||(cuoiky < 0 || cuoiky > 10));
            //xử lý hàm kết quả 
            double dtb = (giuaky * 40 / 100) + (cuoiky * 60 / 100);
            string ketqua = dtb >= 5 ? "Đậu" : "Rớt";

            //xử lý hàm in giao diện
            Console.Clear();
            string giaodien = new string('*', 50);
            Console.WriteLine($"\n{giaodien}" +
                $"\nHọ và tên : {hoten}" +
                $"\nĐiểm giữa kì : {giuaky}" +
                $"\nĐiểm cuối kì:{cuoiky}" +
                $"\nĐiểm trung bình:{dtb}" +
                $"\nKết quả: {ketqua}" +
                $"\n{giaodien}");
        }
    }
}
