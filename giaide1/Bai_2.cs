using System;
using System.Collections.Generic;
using System.Text;

namespace giaide1
{
    internal class Bai_2
    {
        public static void Main(string[] arg)
        {
            Console.OutputEncoding=Encoding.UTF8;
            Console.Write("Nhap ten:");
            string ten = Console.ReadLine();
            //xử lý ngày đi và ngày đến
            int di = 0;
            int den=0;
            do
            {
                Console.Write("Nhap ngay den:");
                den = int.Parse(Console.ReadLine());
                Console.Write("Nhap ngay di:");
                di = int.Parse(Console.ReadLine());
                if (di < den)
                {
                    Console.WriteLine("Hay nhap lai ngay di > ngay den!!");
                }
            }
            while (di < den);
            //xử lý giá phòng
            double gia = 100000;
            int songay = di - den;
            double tongtien = songay <= 3 ? songay * gia : songay * gia * 0.9;


            //Xử lý giao diện in
            string giaodien = new string('*', 50);
            Console.Clear();
            Console.WriteLine($"\n{giaodien}" +
                $"\nKhach hang: {ten}" +
                $"\nNgay den : { den}" +
                $"\nNgay di: {di}" +
                $"\nGia phong: {gia}" +
                $"\nSo tien phai tra: {tongtien}" +
                $"\n{giaodien}");

            Console.ReadKey();
        }
       
    }
}
