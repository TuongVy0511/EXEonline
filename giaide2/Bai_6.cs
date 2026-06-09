using System;
using System.Collections.Generic;
using System.Text;

namespace giaide2
{
    internal class Bai_6
    {
        public static void Main(string[] arg)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //tạo 1 số bí mật từ máy tính
            Random rand =new Random();
            int sobimat = rand.Next(1, 101);

            //đề bài cho 7 lượt
            Console.WriteLine("Số bí mật nằm trong khoảng từ 1 đến 100");
            Console.WriteLine("Bạn có 7 lần để đoán!!");

            //logic của bài
            bool doantrung = false;
            int luot = 1;
            while (luot <= 7&&doantrung==false)
            {
                Console.WriteLine($"Lượt {luot}, mời bạn nhập số đoán:");
                int sodoan=int.Parse(Console.ReadLine());
                if(sodoan==sobimat)
                {
                    Console.WriteLine("Chúc mừng bạn đã đoán trúng!!");
                    doantrung = true;
                }    
                else if(sodoan<sobimat)
                {
                    Console.WriteLine("Gợi ý: số bạn nhập nhỏ hơn số bí mật!!");
                    luot++;
                } 
                else if(sodoan>sobimat)
                {
                    Console.WriteLine("Gợi ý: số bạn nhập lớn hơn số bí mật");
                    luot++;
                }
                
                
            }
            if (doantrung == false)
            {
                Console.WriteLine("Bạn hết lượt. Bạn thua cuộc !!!");
                Console.WriteLine($"Số bí mật là :{sobimat}");
            }
            Console.ReadLine();
        }

    }
}
