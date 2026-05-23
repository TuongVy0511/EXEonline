using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace buoi6
{
    internal class ex1
    {
        //Giao diện
        //MẢNG 2 CHIỀU EX
        public static void Main(string[] arg)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //1.Tạo 1 mảng tự nhập
            Console.WriteLine("Nhập số dòng");int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số cột");int m = int.Parse(Console.ReadLine());
            int[,] a = Mangrandom(n, m);
           // int[,] a = Tunhapmang(n, m);
            Console.WriteLine($"\n Mảng sau khi nhập là");
            inmang(a);
            //2.tạo 1 mảng random
            //3.in mảng ra

            //4.in ra 1 dòng/cột bất kì trong mảng 
            Console.WriteLine("Nhập vào dòng mà bạn muốn in");
            int x = int.Parse(Console.ReadLine());
            Indong(a, x);
            Console.WriteLine("\nNhập vào cột mà bạn muốn in");
            int y = int.Parse(Console.ReadLine());
            Incot(a, y);

            //5.giá trị lớn nhất mảng
            int max = Timmax(a);
            Console.WriteLine($"Giá trị lớn nhất của ma trận là {max}");

            //6.giá trị nhỏ nhất của mảng
            int min = Timmin(a);
            Console.WriteLine($"Giá trị nhỏ nhất của ma trận là {min}");


            //7.chuyển dòng thành cột, cột thành dòng
            int[,] dachuyenvi = Chuyenvi(a);
            Console.WriteLine("Ma trận sau khi chuyển vị là");
            inmang(dachuyenvi);


            //8.in ra giá trị nằm trên đường chéo chính và phụ ( điều kiện ma trận vuông )
            //8.1 đường chéo chính
            int[] đcc = duongcheochinh(a);
            Console.WriteLine("Đường chéo chính của ma trận là");
            Console.WriteLine(string.Join(" ",đcc));
            //8.2 đường chéo phụ
            int[] đcp = duongcheophu(a);
            Console.WriteLine("Đường chéo phụ của ma trận là");
            Console.WriteLine(string.Join(" ",đcp));
        }

        //Viết câu lệnh để in mảng để khỏi phải viết trong giao diện
        static void inmang(int[,]a)
        {
            for(int i=0;i<a.GetLength(0);i++)
            {
                for(int j=0;j<a.GetLength(1);j++)
                {
                    Console.Write($"{a[i, j]}\t");
                }
                Console.WriteLine();
            }    
        }
        //logic1
        static int[,] Tunhapmang( int dong, int cot)
        {
            int[,] a = new int[dong, cot];
            for(int i=0; i<dong; i++)
            {
                for(int j=0;j<cot;j++)
                {
                    Console.Write($"Nhập a[{i}][{j}]");
                    a[i, j] = int.Parse(Console.ReadLine());
                }    
            }
            return a;
        }

        //logic 2
        static int[,] Mangrandom(int dong, int cot)
        {
            int[,] a = new int[dong, cot];
            Random ngaunhien = new Random();

            for(int i=0; i<dong;i++)
            {
                for(int j=0;j<cot;j++)
                {
                    a[i, j] = ngaunhien.Next(0, 100);
                }    
            }
            return a;
        }
        //logic4dong
        static void Indong(int[,] a, int vitridong)
        {
            for(int j=0;j<a.GetLength(1);j++)
            {
                Console.Write($"{a[vitridong,j]}\t");
            }
        }
        //logic4cot
        static void Incot(int[,]a, int vitricot)
        {
            for(int i=0;i<a.GetLength(0);i++)
            {
                Console.Write($"{a[i,vitricot]}\n");
            }    
        }

    //logic5
    static int Timmax(int[,]a)
        {
            int max = a[0, 0];
            for(int i=0; i<a.GetLength(0);i++)
            {
                for(int j=0;j<a.GetLength(1);j++)
                {
                    if (a[i, j] > a[0,0])
                    {
                        max = a[i, j];
                    }    
                }    
            }
            return max;
        }


    //logic6
    static int Timmin(int[,]a)
        {
            int min = a[0, 0];
            for(int i=0;i<a.GetLength(0);i++)
            {
                for(int j=0;j<a.GetLength(1);j++)
                {
                    if (a[i, j] < a[0, 0])
                    {
                        min = a[i, j];
                    }    
                        
                }    
            }
            return min;
        }
    //logic7
    static int[,] Chuyenvi(int[,]a)
        {
            int dong = a.GetLength(0);
            int cot = a.GetLength(1);
            int[,] matranchuyenvi = new int[cot, dong];
            for(int i=0;i<a.GetLength(0);i++)
            {
                for(int j=0;j<a.GetLength(1);j++)
                {
                    matranchuyenvi[j, i] = a[i, j];
                }    
            }
            return matranchuyenvi;
        }

    //logic8.1 đường chéo chính
    static int[] duongcheochinh(int[,]a)
        {
            int[] ketqua = new int[a.GetLength(0)];
            for(int i=0;i<a.GetLength(0);i++)
            {
                ketqua[i] = a[i, i];
            }
            return ketqua;
        }
   
     //logic8.2 đường chéo phụ
     static int[] duongcheophu(int[,]a)
        {
            int[] ketqua1 = new int[a.GetLength(0)];
            for(int i=0; i<a.GetLength(0);i++)
            {
                ketqua1[i] = a[i, a.GetLength(0) - 1 - i];
            }
            return ketqua1;
        }
    }
}
