using System;
using System.Collections.Generic;
using System.Text;

namespace giaide3
{
    internal class Bai_3
    {
        public static void Main(string[] arg)
        {
            Console.OutputEncoding=Encoding.UTF8;
            Console.WriteLine("Nhập hệ số a,b để giải phương trình ax+b=0");
            Console.WriteLine("nhập a");
            double a=double.Parse(Console.ReadLine());
            Console.WriteLine("Nhập b");
            double b=double.Parse(Console.ReadLine());
            //hàm giải
            Bai3(a, b);
            Console.ReadLine();
        }
        static void Bai3(double a, double b)
        {
            if(a==0&&b==0)
            {
                Console.WriteLine("Phương trình vô số nghiệm");
            } 
            else if(a==0&&b!=0)
            {
                Console.WriteLine("Phương trình vô ngiệm");
            }  
            else if(a!=0)
            {
                double ketqua = (-b / a);
                Console.WriteLine($"Phương trình có nghiệm x = {ketqua:F5}");
            }    
        }
    }
}
