using System;
using System.Collections.Generic;
using System.Text;

namespace giaide3
{
    internal class Bai_6
    {
        public static void Main(string[] arg)
        {
            Console.OutputEncoding=Encoding.UTF8;
            //tạo số bí mật 
            Random rand=new Random();
            int sobimat = rand.Next(0, 101);
            //
            Console.WriteLine("Hãy đoán số từ 1-100");
            Console.WriteLine("Bạn có 7 lần để đoán");

            bool datrung= false;
            int luot = 1;
            while(luot<=7&&datrung==false)
            {
                Console.WriteLine($"Đây là lượt {luot}/7, hãy nhập số mà bạn đoán: ");
                int sodoan=int.Parse(Console.ReadLine());
                if(sodoan==sobimat)
                {
                    Console.WriteLine("Chúc mừng bạn đã đoán đúng!!");
                    luot++;
                } 
                else if(sodoan>sobimat)
                {
                    Console.WriteLine("Số của bạn lớn hơn số bí mật!!");
                    luot++;
                }    
                else
                {
                    Console.WriteLine("Số của bạn nhỏ hơn số bí mật!!");
                    luot++;
                }    
            }
            if (datrung == false) 
            {
                Console.WriteLine("Bạn đã đoán vượt qua 7 lần. Bạn thua!!!");
                Console.WriteLine($"Số bí mật là : {sobimat}");
            }
            Console.ReadLine();   
        }
    }
}
