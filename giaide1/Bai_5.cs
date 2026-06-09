using System;
using System.Collections.Generic;
using System.Text;

namespace giaide1
{
    internal class Bai_5
    {
        public static void Main(string[] arg)
        {
            Console.OutputEncoding=Encoding.UTF8;
            Console.WriteLine("Nhap ten cua ban");
            string ten = Console.ReadLine(); 
            Console.WriteLine("Nhap toa do y bat dau:");
            int y = int.Parse(Console.ReadLine());

            Console.Clear();
            bai_6(ten, y);
            Console.ReadKey();
        }
        static void bai_6(string ten,int y)
        {
            for(int x=0; x<=Console.WindowWidth-ten.Length; x++)
            {
                Console.SetCursorPosition(x, y);
                Console.Write(ten);

                Thread.Sleep(500);

                if(x<Console.WindowWidth-ten.Length)
                {
                    Console.SetCursorPosition(x, y);
                    Console.Write(new string(' ', ten.Length));
                }    
            }    


        }
    }
}
