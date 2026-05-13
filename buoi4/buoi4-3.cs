using System;
using System.Collections.Generic;
using System.Text;

namespace buoi4
{
    internal class buoi4_3
    {
        static bool songuyento(int x)
        {
            if (x < 2) 
            return false;

            for(int i=2; i*i<= x ; i++)
            {
                if (x % i == 0)
                    return false;
            }
            return true;
        }

        public static void Main(string[] args)
        { 
            Console.OutputEncoding=Encoding.UTF8;
            Console.WriteLine("Nhập vào một số để kiểm tra");
            int n= int.Parse(Console.ReadLine());
            bool ketqua = songuyento(n);
            if (ketqua)
                Console.WriteLine($"{n} là số nguyên tố");
            else
                Console.WriteLine($"{n} không là số nguyên tố");

        }
    }
}
