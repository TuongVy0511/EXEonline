using System;
using System.Collections.Generic;
using System.Text;

namespace giaide2
{
    internal class Bai_7
    {
        public static void Main(string[] arg)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập số dòng của ma trận:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập vào số cột của ma trận:");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Ma trận được tạo ngẫu nhiên là:");
            int[,] mang = inmang(n, m);

            List<int> songt = bai7(mang);
            Console.WriteLine("Những số nguyên tố có trong ma trận trên là");
            Console.WriteLine(string.Join(' ',songt));

            Console.WriteLine();


        }
        //logic in random 1 mảng ma trận 2 chiều bất kì
        static int[,] inmang(int n, int m)
        {
            int[,] mang = new int[n, m];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mang[i, j] = rand.Next(0, 100);
                    Console.Write($"\t{mang[i, j]}");
                }
                Console.WriteLine();
            }
            return mang;
        }
        //logic tìm số nguyên tố
        static bool songuyento(int n)
        {
            if (n < 2) return false;
            for(int i=2;i<n;i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        //logic  in ra số nguyên tố có trong mảng
        static List<int> bai7(int[,] array)
        {
            List<int> ketqua = new List<int>();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (songuyento(array[i,j])==true)
                    {
                        ketqua.Add(array[i, j]);
                    }    
                }
            }
            return ketqua;
        }
    }
}
