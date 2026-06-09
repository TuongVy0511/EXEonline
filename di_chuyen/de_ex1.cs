using System;
using System.Collections.Generic;
using System.Text;

namespace di_chuyen
{
    internal class de_ex1
    {
      
            static void Main(string[] args)
            {
                // Cấu hình in được tiếng Việt
                Console.OutputEncoding = System.Text.Encoding.UTF8;

                // 1. Nhập chiều cao và chiều rộng từ bàn phím
                Console.Write("Nhập chiều cao (số dòng): ");
                int chieuCao = int.Parse(Console.ReadLine());

                Console.Write("Nhập chiều rộng (số cột): ");
                int chieuRong = int.Parse(Console.ReadLine());

                Console.Clear();
                Console.WriteLine("KẾT QUẢ VẼ HÌNH CHỮ NHẬT:\n");

                // 2. Hai vòng lặp for lồng nhau để vẽ hình
                for (int i = 0; i < chieuCao; i++) // Vòng lặp quản lý từng DÒNG
                {
                    for (int j = 0; j < chieuRong; j++) // Vòng lặp quản lý từng CỘT trên dòng đó
                    {
                        Console.Write("*"); // In liên tục các dấu * trên cùng 1 hàng
                    }

                    Console.WriteLine(); // Sau khi in xong 1 hàng, bắt buộc phải xuống dòng
                }

                Console.ReadKey();
            }
        }
    }

