using System;
using System.Collections.Generic;
using System.Text;

namespace giaide1
{
    internal class Bai_7
    {
        public static void Main(string[] arg)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập và số lượng dòng cột của ma trận vuông nxn");
            int n= int.Parse(Console.ReadLine());
            Console.WriteLine("Ma trận được tạo ngẫu nhiên là");
            int[,] array = MangRandom(n);

            Console.WriteLine("Nhập vào 1 số bất kì");
            int m = int.Parse(Console.ReadLine());


            int soluong = Dem(array, m);
            Console.WriteLine($"Số lượng phần tử chia hết cho {m} là:{soluong} ");

            Console.WriteLine("Các số chia hết cho {m} là");
            In(array, m);


        }

        //logic in ra 1 mảng 2 chiều random
        static int[,] MangRandom(int n)
        {
            int[,] array = new int[n, n];
            Random ngaunhien = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = ngaunhien.Next(0, 100);
                    Console.Write($"{array[i, j]} \t");
                }
                Console.WriteLine();
            }
            return array;

        }
        //logic debai
        static int Dem(int[,] array, int m)
        {
            int count = 0;
            for(int i=0;i<array.GetLength(0);i++)
                for (int j =0; j<array.GetLength(1);j++)
                {
                    if (array[i,j]%m==0)
                    {

                        count++;
                    }   
                }
            return count;
        }
        //logic in ra các số chia hết cho m
        static void In(int[,] array, int m)
        {
            bool tontai = false;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] % m == 0)
                    {
                        Console.Write($"{array[i, j]}\t");
                        tontai = true;
                    }
                }
            }
            if(tontai==false)
            {
                Console.WriteLine($"Không tồn tại số chia hết cho {m} ");
            }
            Console.WriteLine();
            
        }

    }
}
