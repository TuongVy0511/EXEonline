using System;
using System.Collections.Generic;
using System.Text;

namespace giaide3
{
    internal class Bai_9
    {
        public static void Main(string[] arg)
        {
            Console.OutputEncoding=Encoding.UTF8;
            Console.WriteLine("Nhập vào 1 số a");
            double a=double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập vào 1 số b");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Hai số a và b sau khi hoán vị là:");
            DaoSoThuc(a, b);
        }

        static void DaoSoThuc(double a, double b)
        {
            double temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"a={a},b={b}");
        }
    }
}
