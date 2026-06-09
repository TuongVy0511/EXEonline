using System;
using System.Collections.Generic;
using System.Text;

namespace giaide1
{
    internal class Bai_3
    {
        public static void Main(string[] arg)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //kiểm tra số dương
            int so = 0;
            do
            {
                Console.WriteLine("Hay nhap vao 1 so nguyen duong:");
                so = int.Parse(Console.ReadLine());
                if(so<=0)
                {
                    Console.WriteLine("Hay nhap vao 1 so > 0!!");
                }    
            }
            while (so <=0);

            //kiểm tra chẵn lẻ
            if(so%2==0)
            {
                Console.WriteLine($"{so}la so chan");
            }
            else { Console.WriteLine($"{so} la so le"); }

            Console.ReadKey();
        }
    }
}
