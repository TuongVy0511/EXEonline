using System;
using System.Collections.Generic;
using System.Text;

namespace giaide3
{
    internal class Bai_4
    {
        public static void Main(string[] arg)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào số lon nhớt bạn đã mua:");
            int n = int.Parse(Console.ReadLine());
            //hàm giải quyết
            double tongtien = n * 27000;
            int non = (n / 3);
            int but = (n % 3);
            Console.WriteLine($"\nTổng tiền mà bạn phải trả là {tongtien}" +
                $"\n Số nón bạn nhân được là : {non}" +
                $"\n Số bút bạn nhận được là : {but}");

            Console.ReadLine();
        }
       
    }
}
