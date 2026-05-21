using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace buoi5
{
    internal class ex2
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int[] array = { 10, 12, 5, 4, 6, 7, 8, 11, 50, 66, 34, 2, 34, 7, 8, 4, };
            //bài1
            List<int> dasapxep = noibottangdan(array);
            Console.WriteLine("mảng mới sau khi đã sắp xếp là");
            Console.WriteLine(string.Join(" ",dasapxep));

            //bài2
            Console.WriteLine("Nhập vào 1 số bạn muốn tìm trong mảng");
            int x= int.Parse(Console.ReadLine());

            int vitri = timkiem(array, x);
            if(vitri==-1)
            {
                Console.WriteLine($"số cần tìm không tồn tại trong mảng");
            }
            else 
            {
                Console.WriteLine($"số cần tìm ở vị trí {vitri}");
            }

        }

        //logic1
        static List<int> noibottangdan(int[] array)
        {
            List<int> saukhixep=new List<int>(array);
            for(int i=0;i<saukhixep.Count-1;i++)
            {
                for(int j=0;j<saukhixep.Count-1;j++)
                {
                    if (saukhixep[j] > saukhixep[j+1])
                    {
                        int temp = saukhixep[j];
                        saukhixep[j]=saukhixep[j+1];
                        saukhixep[j + 1] = temp;
                    }    
                }    
            }
            return saukhixep;
        }

        //logic2
        static int timkiem(int[] array, int n)
        {
            for(int i=0;i <array.Length;i++)
            {
                if (array[i]==n)
                {
                    return i;
                }    
            } 
            return -1; 
        }

    }
}
