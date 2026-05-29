using System;
using System.Collections.Generic;
using System.Text;

namespace buoi7
{
    internal class ex_string
    {
        public static void Main(string[] arg)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào 1 chuỗi gốc để thực hiện");
            string s = Console.ReadLine();
            //Câu 10: Tìm ký tự xuất hiện với tần suất nhiều lần nhất (xuất hiện nhiều nhất) trong một chuỗi.
            Console.WriteLine("Xét trong chuỗi");
            tansuat(s);
            //Câu 11: Sắp xếp một mảng các chuỗi theo thứ tự bảng chữ cái tăng dần (Ascending order).
            Console.WriteLine("Nhập số lượng chuỗi trong mảng");
            int n = int.Parse(Console.ReadLine());
            string[] array = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhập chuỗi thứ {i}");
                array[i] = Console.ReadLine();
            }
            // sxarray(array);
            sxarray1(array);
            Console.WriteLine("Mảng đã sắp xếp các chuỗi là");
            Console.WriteLine(string.Join(" ", array));

            //Câu 12: Nhập vào một danh sách các chuỗi từ bàn phím và sắp xếp chúng bằng thuật toán sắp xếp nổi bọt (Bubble Sort).
            bubarray(array);
            Console.WriteLine("Mảng đã sắp xếp các chuỗi bằng bubble sort là");
            Console.WriteLine(string.Join(" ", array));

            //Câu 13: Trích xuất (cắt) một chuỗi con từ chuỗi gốc dựa vào vị trí bắt đầu và độ dài cho trước, không dùng hàm thư viện.
            Console.WriteLine("Nhập vào từ mà bạn muốn cắt từ chuỗi");
            string cat = Console.ReadLine();
            string kqacat = catchuoi(s, cat);
            Console.WriteLine("Chuỗi sau khi mà cắt là ");
            Console.WriteLine(kqacat);
            //Câu 15: Đọc một câu và tiến hành đổi chữ thường thành chữ hoa, chữ hoa thành chữ thường.
            //Câu 16: Viết chương trình mô phỏng đăng nhập để kiểm tra tính chính xác của Username và Password.
            Console.WriteLine();
            bool dangnhap = false;
            while (dangnhap == false)
            {
                Console.Write("Nhập username:"); string user = Console.ReadLine();
                Console.Write("Nhập password:"); string pass = Console.ReadLine();
                dangnhap = kiemtra(user, pass);
                if (dangnhap == false)
                {
                    Console.WriteLine("fail, nhập lại");
                }
            }
            Console.WriteLine("Bạn đã đăng nhập thành công");
           
            //Câu 24: Nhập vào tên của mọi người và tiến hành sắp xếp danh sách đó theo thứ tự bảng chữ cái của Họ (Last name). 
        }
        //logic bài 10 , đếm tần xuất max
        static void tansuat(string s)
        {
            int maxtansuat = 0;
            char maxkytu = ' ';
            for(int i=0;i<s.Length; i++)
            {
                if (s[i] == ' ') continue;

                int demsolan = 0;
                int vitri = 0;
                while ((vitri = s.IndexOf(s[i],vitri))!=-1)
                {
                    demsolan++;
                    vitri++;
                }    
                if(demsolan>maxtansuat)
                {
                    maxtansuat = demsolan;
                    maxkytu = s[i];
                }    
            }
            Console.WriteLine($"Ký tự xuất hiện nhiều lần nhất là '{maxkytu}' với số lần xuất hiện là '{maxtansuat}'");
        }
        //logic11 sắp xếp vị trí của các chuỗi trong mảng dùng tools
        static void sxarray(string[] array)
        {
            Array.Sort(array);
        }

        //logic11 sắp xếp vị trí của các chuỗi trong mảng không dùng tools 
        static void sxarray1(string[] array)
        {
            for(int i=0; i<array.Length;i++)
            {
                for(int j =i+1;j<array.Length;j++)
                {
                    if (array[i].CompareTo(array[j])>0)
                    {
                        string temp = array[i];
                        array[i] = array[j];
                        array[j]=temp;
                    }    
                }    
            }    
        }
        //logic 12 sx theo pubble sort
        static void bubarray(string[] array)
        {
            for (int i=0;i<array.Length-1;i++)
            {
                for(int j=0; j< array.Length - 1-i;j++)
                {
                    if (array[j].CompareTo(array[j+1])>0)
                    {
                        string temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }    
                }    
            }    
        }

        //logic 13 cắt ký tự bằng tools
        static string catchuoi(string s, string s1)
        {
            int vitri = s.IndexOf(s1);
            if(vitri==-1)
            {
                return "Không tìm thấy từ này trong chuỗi";
            }
            int dodai = s1.Length;
            return s.Remove(vitri, dodai);
        }

        //logic 16 mật khẩu và tên
        static bool kiemtra(string user, string pass)
        {
            string usertrue = "tuongvy0511";
            string passtrue = "01091997Jk*";
            if(user==usertrue && pass==passtrue)
            {
                return true;
            }
            else { return false; }
        }

    }
}
