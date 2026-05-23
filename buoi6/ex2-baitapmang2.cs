using System;
using System.Collections.Generic;
using System.Text;

namespace buoi6
{
    internal class ex2_baitapmang2
    {
        public static void Main(string[] arg)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //CƠ BẢN
            //21.Nhập và in ma trận
            Console.WriteLine("Nhập số dòng"); int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số cột"); int m = int.Parse(Console.ReadLine());
            int[,] a = Mangrandom(n, m);
            Console.WriteLine($"\n Mảng sau khi nhập là");
            inmang(a);

            //22.Tổng các phần tử trên dòng và cột bất kì

            //23.Tìm phần tử lớn nhất và vị trí của nó
            (int, int, int) max = Timmax(a);
            Console.WriteLine($"Giá trị lớn nhất của ma trận và vị trí của nó là {max}");
            //24.Phần tử trên phần chéo chính
            int[] đcc = duongcheochinh(a);
            Console.WriteLine("Đường chéo chính của ma trận là");
            Console.WriteLine(string.Join(" ", đcc));
            //25.Phần tử trên đường chéo phụ
            int[] đcp = duongcheophu(a);
            Console.WriteLine("Đường chéo phụ của ma trận là");
            Console.WriteLine(string.Join(" ", đcp));
            //26.Tìm kiếm 1 số trong ma trận
            //27. Đếm số lượng số âm trong ma trận/biên của ma trận

            //TRUNG BÌNH
            //28.Cộng 2 ma trận
            //29.Tìm ma trận chuyển vị
            int[,] dachuyenvi = Chuyenvi(a);
            Console.WriteLine("Ma trận sau khi chuyển vị là");
            inmang(dachuyenvi);
            //30.Kiểm tra ma trận có đối xứng không (thông qua đường chéo chính )
            //31.sx tăng dần trên dòng
            //32.đổi chỗ 2 dòng của ma trận
            //33.Kiểm tra ma trận tam giá trên/ dưới
            //34.Tìm dòng có tổng số phần tử lớn nhất
        }
            //Logic in ma trận để không tốn phần giao diện
            static void inmang(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"{a[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
        //Logic21(random)
        static int[,] Mangrandom(int dong, int cot)
        {
            int[,] a = new int[dong, cot];
            Random ngaunhien = new Random();

            for (int i = 0; i < dong; i++)
            {
                for (int j = 0; j < cot; j++)
                {
                    a[i, j] = ngaunhien.Next(0, 100);
                }
            }
            return a;
        }
            //logic22 dòng
            //logic22 cột
            //logic23
            static (int,int,int) Timmax(int[,] a)
            {
                int max = a[0, 0];
                int dong = 0;
                int cot = 0;
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    for (int j = 0; j < a.GetLength(1); j++)
                    {
                        if (a[i, j] > a[0, 0])
                        {
                            max = a[i, j];
                            dong = i;
                            cot = j;
                        }
                    }
                }
                return (max,dong,cot);
            }

        //logic24
        static int[] duongcheochinh(int[,] a)
        {
            int[] ketqua = new int[a.GetLength(0)];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                ketqua[i] = a[i, i];
            }
            return ketqua;
        }

        //logic25
        static int[] duongcheophu(int[,] a)
        {
            int[] ketqua1 = new int[a.GetLength(0)];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                ketqua1[i] = a[i, a.GetLength(0) - 1 - i];
            }
            return ketqua1;
        }
        //logic26
        //logic27 toàn ma trận
        //logic27 biên ma trận
        //logic28
        //logic29
        static int[,] Chuyenvi(int[,] a)
        {
            int dong = a.GetLength(0);
            int cot = a.GetLength(1);
            int[,] matranchuyenvi = new int[cot, dong];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    matranchuyenvi[j, i] = a[i, j];
                }
            }
            return matranchuyenvi;
        }

        //logic30
        //logic31
        //logic32
        //logic 33 trên
        //logic33 dưới
        //loic 34

    }
}
    
