using System;
using System.Collections.Generic;
using System.Text;

namespace giaide3
{
    internal class Bai_5
    {
        public static void Main(string[] arg)
        {
            Console.OutputEncoding=Encoding.UTF8;
            Console.WriteLine("Nhập vào chiều dài hình chữ nhật");
            int a= int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập vào chiều rộng hình chữ nhật");
            int b=int.Parse(Console.ReadLine());

            Console.WriteLine("Hình chữ nhật được in ra là:");
            Bai5(a, b);

            Console.ReadLine();
        }
        static void Bai5(int a, int b)
        {
            for(int i = 0; i < a; i++)
            {
                    string In = new string('*', b);
                    Console.WriteLine($"{In}");
            }    
        }
    }
}
