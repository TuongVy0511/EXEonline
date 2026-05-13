using System;
using System.Collections.Generic;
using System.Text;

namespace buoi4
{
    internal class buoi4_5
    {
        static bool sohoanhao(int n)
        {
            if (n <= 1)
                return false;

            int tong = 0;
            for(int i=1;i<n;i++)
            {
                if(n%i==0)
                {
                    tong += i;
                }   
            }
            return tong == n;
        }

        static string PrintPerfectNumbersUnder1000()
        {
            string result = "";
            for(int i=1;i<1000;i++)
            {
                if(sohoanhao(i))
                {
                    result += i + " "; 
                }    
            }
            return result;
        }

        public static void Main(string[] args)
        {
            Console.OutputEncoding=Encoding.UTF8;
            Console.WriteLine("Nhập một số để kiểm tra");
            int x=int.Parse(Console.ReadLine());
            bool ketqua = sohoanhao(x);
            if(ketqua)
                Console.WriteLine($"{x} là số hoàn hảo");
            else
                Console.WriteLine($"{x} không là số hoàn hảo");

            Console.WriteLine("In ra các số hoàn hảo dưới 1000");
            Console.WriteLine(PrintPerfectNumbersUnder1000());
        }
    }
}
