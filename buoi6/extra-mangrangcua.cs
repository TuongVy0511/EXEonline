using System;
using System.Collections.Generic;
using System.Text;

namespace buoi6
{
    internal class extra_mangrangcua
    {
        //nắm cách khởi tạo mảng răng cưa thôi không cần làm các bài tập khó vì răng cưa không co trong đề thi
       public static void Main(string[] arg)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào số hàng bạn muốn tạo mảng");
            int dong = int.Parse(Console.ReadLine());
            int[][] a = Mangrandom(dong);
            Console.WriteLine("Mảng sau khi nhập là ");
            inmangrangcua(a);
        }
        //logic in mảng
        static void inmangrangcua(int[][]a)
        {
            for(int i=0;i<a.Length;i++)
            {
                for(int j = 0; j < a[i].Length;j++)
                {
                    Console.Write($"{a[i][j]}\t");
                }
                Console.WriteLine();
            }    
        }

        //logic random mảng
        static int[][] Mangrandom(int dong)
        {
            int[][] a= new int[dong][];
            Random ngaunhien = new Random();
            for(int i=0;i<dong;i++)
            {
                Console.WriteLine($"Nhập và số phần tử của hàng {i}");
                int cotcuahang = int.Parse(Console.ReadLine());
                a[i] = new int[cotcuahang];
                for(int j=0;j<cotcuahang;j++)
                { a[i][j] = ngaunhien.Next(0, 100); }    
            }
            return a;
        }
    }
}
