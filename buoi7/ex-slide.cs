using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace buoi7
{
    internal class ex_slide
    {
        public static void Main(string[] args)

        {
            //1.Nhập và in chuỗi ra màn hình
            Console.OutputEncoding=Encoding.UTF8;
            string chuoi = " Hello word. My name is Vy. I love everyone. Thank you so much!";
            Console.WriteLine($"{chuoi}");

            //2.Tìm độ dài của chuỗi bằng hàm/không hàm
            Console.WriteLine();
            int dodai1 = dodai(chuoi);
            Console.WriteLine($"Độ dài của chuỗi là {dodai1}");

            //3.tách và in các kí tự riêng lẻ của một chuỗi
            Console.WriteLine("In mỗi kí tự của chuỗi");
            in_mỗi_chữ(chuoi);

            //4. In các kí tự của chuỗi đảo ngược
            Console.WriteLine();
            Console.WriteLine("Chuỗi sau khi đảo ngược là:");
            indaonguoc(chuoi);

            //5.Tổng số từ có trong 1 chuỗi


            //6.so sánh 2 chuỗi với nhau mà không sử dụng hàm
           

            //7.đếm số lượng chữ cái , chữ số và kí tự đặc biệt
            //8.đếm số nguyên âm , phụ âm trong chuỗi
            //9.Kiểm tra 1 chuỗi con xem có tồn tại trong chuỗi ban đầu không
            //10.Tìm kiếm vị trí xuất hiện của 1 chuỗi con trong chuỗi ban đầu
            //11.Kiểm tra xem 1 kí tự có phải là chữ cái hay không , nếu là chữ cái kiểm tra là chữ hoa hay thường
            //12.Tìm số lần xuất hiện của chuỗi con trong chuỗi ban đầu
            //13.Chèn 1 chuỗi con vào trước vị trí xuất hiện đầu tiên của 1 chuỗi con khác
        }
        //logic 2
        static int dodai(string chuoi)
        {
            int lenght = 0;
            foreach(char c in chuoi)
            {
                lenght++;
            }
            return lenght;
        }

        //logic3
        static void in_mỗi_chữ(string chuoi)
        {
            for(int i=0;i<chuoi.Length;i++)
            {
                Console.Write(chuoi[i]+" ");
            }    
        }
        
        //logic4
        static void indaonguoc(string chuoi)
        {
            for(int i=chuoi.Length-1;i>=0;i--)
            {
                Console.Write($"{chuoi[i]}");
            }    
        }
        //logic5
        
    }
}
