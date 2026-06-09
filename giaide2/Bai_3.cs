using System;
using System.Collections.Generic;
using System.Text;

namespace giaide2
{
    internal class Bai_3
    {
        public static void Main(string[] arg)
        {
            Console.OutputEncoding=Encoding.UTF8;
            //nhập số ( điều kiện là số nguyên dương->phải bỏ trong vòng lặp do-while)
            int so = 0;
            do
            {
                Console.WriteLine("Nhập vào 1 số để kiểm tra"); so=int.Parse(Console.ReadLine());
                if(so<=0)
                {
                    Console.WriteLine("Nhập vào 1 số lớn hơn 0!!");
                }    

            }    
            while(so<=0);
            //kiểm tra điều kiện bài toán
            string ketqua = (so % 7 == 0 && so % 9 == 0) ? "Là bội số của 9 và 7" : "Không phải bội số của 9 và 7";
            Console.WriteLine(ketqua);
        }
    }
}
