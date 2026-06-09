using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters;
using System.Text;

namespace di_chuyen
{
    internal class de1
    {
        public static void Main(string[] args)
        {

            Console.Write("Nhap ten cua ban:");
            string ten = Console.ReadLine();
            Console.Write($"Nhap vao toa do y ");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap toc do delay (ms):");
            int delay = int.Parse(Console.ReadLine());

            Console.Clear();

            Bai_3(ten, y, delay);

            Console.ReadKey();
        }
             static void Bai_3(string ten, int y, int delay )
             {
                 for (int x = 0; x <= Console.WindowWidth - ten.Length; x++)
                 {
                     Console.SetCursorPosition(x, y);
                     Console.Write(ten);

                     Thread.Sleep(delay);

                     if (x < Console.WindowWidth - ten.Length)
                     {
                         Console.SetCursorPosition(x, y);
                         Console.Write(new string(' ', ten.Length));
                     }
                 }
             }
         }
        /*public static void Main(string[] arg)
        {
            Console.WriteLine("Nhap ten cua ban");
            string ten = Console.ReadLine();
            Console.WriteLine("Nhap toa do y:");
            int y = int.Parse(Console.ReadLine());

            Console.Clear();

            Bai_3(ten, y);

            Console.ReadKey();
        }
        static void Bai_3(string ten, int y)
        { 
            for(int x=0;x<Console.WindowWidth-ten.Length;x++)
            {
                Console.SetCursorPosition(x, y);
                Console.Write(ten);
                Thread.Sleep(100);
            }    
        }*/
    }
