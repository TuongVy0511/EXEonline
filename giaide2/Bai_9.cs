using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace giaide2
{
    internal class Bai_9
    {
        public static void Main(string[] arg)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int[] mang = { 4, 7, 9, 2, 55, 77, 9, 1, 2, 4, 0 };

            var ketqua = ThongKe(mang);
            if (ketqua.max == -1 || ketqua.min == -1 || ketqua.tb == -1)
            { Console.WriteLine("Mảng bạn nhập vào đang rỗng hay có ít hơn 2 phần tử!!!"); }
            else
            {
                Console.WriteLine($"\n Số lớn nhất là : {ketqua.max}" +
                    $"\n Số bé nhất là : {ketqua.min}" +
                    $"\n Trung bình của mảng là : {ketqua.tb:F2}");
            }
            Console.WriteLine();
        }

        static (int max,int min , double tb) ThongKe(int[] array)
        {
            if(array==null|| array.Length<2)
            { return (-1, -1, -1); }

            int max = array[0];
            int min = array[0];
            double tong = 0;
            for(int i=0;i<array.Length;i++)
            {
                if (array[i] > max) max = array[i];
                if (array[i] < min) min = array[i];
                tong += array[i];
            }
            double tb = tong / array.Length;

            return (max, min, tb);
        }

    }
}
