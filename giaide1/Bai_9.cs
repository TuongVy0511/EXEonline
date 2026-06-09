using System;
using System.Collections.Generic;
using System.Text;

namespace giaide1
{
    internal class Bai_9
    {
        public static void Main(string[] arg)
        {
            Console.OutputEncoding=Encoding.UTF8;
            int solanchophep = 5;
            double x;
            if(TrySoThuc(solanchophep,out x))
            {
                Console.WriteLine($"Bạn nhập đúng số thực , số thực là {x}");
            }    
            else
            {
                Console.WriteLine($"Bạn đã nhập quá {solanchophep} lần được phép");
            }    


        }
        static bool TrySoThuc(int n, out double x)
        {
            int demsai = 0;
            x = 0;
            while(demsai<=n)
            {
                Console.Write("Nhap vao 1 so thuc:");
                string input = Console.ReadLine();

                if(double.TryParse(input, out x))
                {
                    return true;
                }
                else 
                {
                    demsai++;
                    if(demsai<=n)
                    { Console.WriteLine("Sai rồi vui lòng nhập lại!!"); }    
                } 
                    

            }
            return false;
        }    
    }
}
