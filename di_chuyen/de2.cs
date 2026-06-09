using System;
using System.Collections.Generic;
using System.Text;

namespace di_chuyen
{
    internal class de2
    {
        public static void Main(string[] arg)
        {
            Console.Write("Nhap vao ten cua ban:");
            string ten = Console.ReadLine();
            Console.Write("Nhap toa do x:");
            int x= int.Parse(Console.ReadLine());
            Console.Write("Nhap vao toc do di chuyen");
            int delay=int.Parse(Console.ReadLine());

            Console.Clear();

            Bai_5(ten, delay, x);
            Console.ReadKey();
        }

        static void Bai_5(string ten ,int delay ,int x)
        {
            for(int y= Console.WindowHeight-1; y>=0; y--)
            {
                Console.SetCursorPosition(x, y);
                Console.Write(ten);

                Thread.Sleep(delay);
                if(y>0)
                {
                    Console.SetCursorPosition(x, y);
                    Console.Write(new string(' ',ten.Length));
                }
                        


            }    
        }
    }
}
