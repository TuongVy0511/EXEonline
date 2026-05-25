using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
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
            Console.WriteLine("Nhập vị trí dòng mà bạn muốn tính tổng");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập vào vị tri cột mà bạn muốn tính tổng");
            int c = int.Parse(Console.ReadLine());
            int dong = tongdong(a, d);
            int cot = tongcot(a, c);
            Console.WriteLine($"Tổng dong {d} là {dong}");
            Console.WriteLine($"Tổng cột{c} là {cot}");

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
            Console.WriteLine("Nhập vafp 1 số cần tìm trong ma trận");
            int s = int.Parse(Console.ReadLine());
            var timkiem1 = timkiem(a, s);
            if(timkiem1.Item1)
            {
                Console.WriteLine($"{s} có trong ma trận");
                Console.WriteLine($"Vị trí của {s} trong ma trận là :dòng{timkiem1.Item2[0]}, cột{timkiem1.Item2[1]}");
            }
            //27. Đếm số lượng số âm trong ma trận/biên của ma trận
            int soam = demsoam(a);
            Console.WriteLine($"Số lượng số âm trong ma trận a là {soam}");
            int soam1 = demsoam1(a);
            Console.WriteLine($"Số lượng số âm trong biên của ma trận a là {soam1}");

            //TRUNG BÌNH
            //28.Cộng 2 ma trận


            //29.Tìm ma trận chuyển vị
            int[,] dachuyenvi = Chuyenvi(a);
            Console.WriteLine("Ma trận sau khi chuyển vị là");
            inmang(dachuyenvi);
            //30.Kiểm tra ma trận có đối xứng không (thông qua đường chéo chính )
            bool ktradx = kiemtradx(a);
            if(ktradx)
            {
                Console.WriteLine("Ma trận này đối xứng");
            }    
            else
            {
                Console.WriteLine("Ma trận này không đối xứng");
            }

            //31.sx tăng dần trên dòng
            sapxepdong(a);
            Console.WriteLine("Ma trận sau khi sắp xếp dòng là");
            inmang(a);
            //32.đổi chỗ 2 dòng của ma trận
            Console.WriteLine("Nhập dòng 1 muốn đổi chỗ");
            int d1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập dòng 2 muốn đổi chỗ");
            int d2 = int.Parse(Console.ReadLine());
            doicho2dong(a, d1, d2);
            Console.WriteLine("Ma trận sau khi hoán đổi 2 dòng là");
            inmang(a);


            //33.Kiểm tra ma trận tam giá trên/ dưới
            bool ktratren = kiemtratamgiactren(a);
            bool ktraduoi = kiemtratamgiacduoi(a);
            if(ktratren)
            {
                Console.WriteLine("Ma trận a là ma trận tam giác trên");
            }    
            else
            {
                Console.WriteLine("Ma trận a không là ma trận tam giác trên");
            }
            if (ktraduoi)
            {
                Console.WriteLine("Ma trận a là ma trận tam giác dưới");
            }
            else
            {
                Console.WriteLine("Ma trận a không là ma trận tam giác dưới");
            }


            //34.Tìm dòng có tổng số phần tử lớn nhất
            var ketquaphantich = Timdongmax(a); ;
            Console.WriteLine($"Dòng có tổng lớn nhất là {ketquaphantich.Item2} với giá trị là {ketquaphantich.Item1}");

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
            static int tongdong(int[,]a, int vitridong)
        {
            if(vitridong<0||vitridong>a.GetLongLength(0))
            {
                return 0;
            }
            int tong = 0;
            for(int j=0;j<a.GetLength(1);j++)
            {
                tong += a[vitridong, j];
            }
            return tong;

        }
        //logic22 cột
        static int tongcot(int[,] a, int vitricot)
        {
            if (vitricot < 0||vitricot>a.GetLength(1))
            {
                return 0;
            }
            int tong1 = 0;
            for(int i=0; i<a.GetLength(0);i++)
            {
                tong1 += a[i, vitricot];
            }
            return tong1;
        }
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
                        if (a[i, j] > max)
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
        static (bool, int[]) timkiem(int[,] a, int socantim)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] == socantim)
                    {
                        return (true, new int[] { i, j });
                    }
                }
            }
            return (false,new int[0]);
            
        }
        //logic27 toàn ma trận
        static int demsoam(int[,]a)
        {
            int dem = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] < 0)
                    {
                        dem++;
                    }
                }
            }
            return dem;
        }
        //logic27 biên ma trận
        static int demsoam1(int[,]a)
        {
            int dem = 0;
            for(int i=0; i<a.GetLength(0);i++)
            {
                for(int j=0;j<a.GetLength(1);j++)
                {
                    bool bienmatran = (i == 0 || i == a.GetLength(0) - 1 || j == 0 || j == a.GetLength(1) - 1);
                    if(bienmatran && a[i,j]<0)
                    {
                        dem++;
                    }    

                }    
            }
            return dem;
        }
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

        static bool kiemtradx(int[,]a)
        {
            if(a.GetLength(0) != a.GetLength(1))
            {
                return false;
            }    
            for(int i=0; i<a.GetLength(0);i++)
            {
                for(int j=0; j<i;j++)
                {
                    if (a[i, j] != a[j,i])
                    {
                        return false;
                    }    
                }    
            }
            return true;
        }
        //logic31

        static void sapxepdong(int[,]a)
        {
            for(int i=0;i<a.GetLength(0);i++)
            {
                for(int j=0;j<a.GetLength(1)-1;j++)
                {
                    for(int k=j+1;k<a.GetLength(1);k++)
                    {
                        if (a[i, j] > a[i,k])
                        {
                            int temp = a[i, j];
                            a[i, j] = a[i, k];
                            a[i, k] = temp;
                        }    
                    }    
                }    
            }    
        }
        //logic32

        static void doicho2dong(int[,]a, int dong1, int dong2)
        {
            if(dong1<0||dong1>a.GetLength(0)||dong2<0||dong2>a.GetLength(0))
            {
                Console.WriteLine("Vị trí dòng không hợp lệ");
                return;
            }  
            if(dong1==dong2)
            {
                return;
            }  
            for(int j=0; j<a.GetLength(1);j++)
            {
                int temp = a[dong1, j];
                a[dong1, j] = a[dong2, j];
                a[dong2, j] = temp;
            }    

        }
        //logic 33 trên

        static bool kiemtratamgiactren(int[,]a)
        { 
            if(a.GetLength(0)!=a.GetLength(1))
            {
                return false;
            }  
            for(int i=0; i<a.GetLength(0);i++)
            {
                for(int j=0;j<a.GetLength(1);j++)
                {
                    if (j<i||a[i,j]!=0)
                    {
                        return false;
                    }    
                }    
            }
            return true;
        }
        //logic33 dưới
        static bool kiemtratamgiacduoi(int[,] a)
        {
            if (a.GetLength(0) != a.GetLength(1))
            {
                return false;
            }
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (j > i || a[i, j] != 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
            //loic 34
            static (int, int) Timdongmax(int[,]a)
        {
            int vitrimax = 0;
            int tongmax = 0;
             for(int j=0;j<a.GetLength(1);j++)
            {
                tongmax += a[0, j];//tính tổng của dòng 0 rồi mới đi so sánh
            }    
             for(int i=1;i<a.GetLength(0);i++)
            {
                int tonghientai = 0;
                for(int j=0;j<a.GetLength(1);j++)
                {
                    if(tonghientai>tongmax)
                    {
                        tongmax = tonghientai;
                        vitrimax = i;
                    }    
                }    
            }
            return (tongmax, vitrimax);
        }

        }
}
    
