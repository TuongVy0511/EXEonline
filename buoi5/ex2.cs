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
            Console.WriteLine("Nhập một câu vào để thực hiện");
            string cau= Console.ReadLine();

            Console.WriteLine("Nhập vào 1 từ cần tìm kiếm");
            string tu = Console.ReadLine();
            bool ketqua = timkiem(cau, tu);
            if(ketqua)
            {
                Console.WriteLine($"Tìm thấy {tu} trong {cau}");
            }    
            else
            {
                Console.WriteLine($"Không tìm thấy {tu}trong {cau}");
            }
            
           

        }

        //logic1
        static List<int> noibottangdan(int[] array)
        {
            List<int> saukhixep=new List<int>(array);
            for(int i=0;i<saukhixep.Count-1;i++)
            {
                for(int j=0;j<saukhixep.Count-i-1;j++)
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
        static bool timkiem(string cau, string tu)
        { 
            if(string.IsNullOrWhiteSpace(cau)||string.IsNullOrWhiteSpace(tu))
            { return false; }

            int dodaicau = cau.Length;
            int dodaitu = tu.Length;
            
            for(int i=0; i<=dodaicau-dodaitu;i++)
            {
                string duyetphantu = cau.Substring(i,tu.Length);
                if (duyetphantu.Equals(tu, StringComparison.OrdinalIgnoreCase)) ;
                {
                    return true;
                }
            }
            return false;
        }

    }
}
