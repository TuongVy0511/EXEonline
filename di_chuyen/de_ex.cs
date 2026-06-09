using System;
using System.Collections.Generic;
using System.Text;

namespace di_chuyen
{
    internal class de_ex
    {
        public static void Main(string[] args)

        {
            Console.OutputEncoding= Encoding.UTF8;
            Console.SetWindowSize(80, 25);

            Console.WriteLine("Nhập vào 1 ký tự để di chuyển");
            char kytu= Console.ReadLine()[0];
            Console.WriteLine("Nhập x:");
            int xdau=int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập y");
            int ydau=int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập vào chiều rộng hcn");
            int rong = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập vào chiều cao hcn");
            int cao = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập vào tốc độ delay");
            int delay=int.Parse(Console.ReadLine());

            Console.Clear();

            Bai_2(kytu, delay, xdau, ydau, rong, cao);

            Console.ReadKey(true);
        }

        static void Bai_2(char kytu,int delay, int xdau, int ydau, int rong, int cao)
        {
            int x = xdau;
            int y = ydau;
            int huong = 0; //0:phải,1:xuống,2:trái,3:lên

            int bientrai = xdau;
            int bientren = ydau;
            int bienphai = xdau + rong - 1;
            int bienduoi = ydau + cao - 1;

            while(!Console.KeyAvailable)
            {
                Console.SetCursorPosition(x, y);
                Console.Write(kytu);

                Thread.Sleep(delay);

                Console.SetCursorPosition(x, y);
                Console.Write(" ");

                if(huong==0)
                {
                    x++;
                    if(x>=bienphai)
                    {
                        x = bienphai;
                        huong = 1;
                    }    
                } 
                else if(huong==1)
                {
                    y++;
                    if(y>=bienduoi)
                    {
                        y = bienduoi;
                        huong = 2;
                    }    
                }
                else if(huong==2)
                {
                    x--;
                    if(x<=bientrai)
                    {
                        x = bientrai;
                        huong = 3;
                    }    
                } 
                else if(huong==3)
                {
                    y--;
                    if(y<=bientren)
                    {
                        y = bientren;
                        huong = 0;
                    }    
                }    
            }
            Console.SetCursorPosition(x, y);
            Console.Write(kytu);
        }
    }
}
