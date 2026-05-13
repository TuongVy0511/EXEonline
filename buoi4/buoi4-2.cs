using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace buoi4
{
    internal class buoi4_2
    {
        static long giaithua(int x)
        {
            if (x < 0) 
            { return -1;
            }
            long ketqua = 1;
            for (int i = 1; i <=x; i++)
            {
                ketqua = ketqua * i; 
             }
            return ketqua;

        }

        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào số muốn tính giai thừa");
            int n=int.Parse(Console.ReadLine());
            long dapan = giaithua(n);
            Console.WriteLine($"Giai thừa của {n} là : {dapan}");


        }
    } 
}
