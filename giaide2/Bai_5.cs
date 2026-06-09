using System;
using System.Collections.Generic;
using System.Text;

namespace giaide2
{
    internal class Bai_5
    {
        public static void Main(string[] arg)
        {
            Console.OutputEncoding= Encoding.UTF8;
            //nhập tên
            Console.WriteLine("Nhập tên của bạn");
            string ten= Console.ReadLine();
            //nhập tọa độ x, vì y chỉ có việc đi thẳng lên trên
            Console.WriteLine("Nhập tọa độ x bất kì để bắt đầu");
            int x= int.Parse(Console.ReadLine());
            //xóa màn hình
            Console.Clear();
            //hàm chạy
            bai5(ten, x);
            //
            Console.ReadKey();
        }

        static void bai5(string ten, int x)
        {
            for (int y = Console.WindowHeight - 1; y >= 0; y--)
            {
                Console.SetCursorPosition(x, y);
                Console.Write(ten);

                Thread.Sleep(500);
                if (y > 0)
                {
                    Console.SetCursorPosition(x, y);
                    Console.Write(new string(' ', 100));
                }
            }
        }
        

    }
}
