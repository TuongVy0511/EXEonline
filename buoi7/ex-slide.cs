using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Security.AccessControl;
using System.Text;

namespace buoi7
{
    internal class ex_slide
    {
        public static void Main(string[] args)

        {
            //1.Nhập và in chuỗi ra màn hình
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào 1 chuỗi");
            string chuoi = Console.ReadLine();



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
            int tongsotu = countwords(chuoi);
            Console.WriteLine($"Số từ có trong câu là : {tongsotu}");
            //6.so sánh 2 chuỗi với nhau mà không sử dụng hàm
            Console.WriteLine("Nhập vào chuỗi mới để so sánh ");
            string chuoi1 = Console.ReadLine();

            int kqasosanh = sosanh(chuoi, chuoi1);
            Console.WriteLine("Kết quả so sánh");
            if (kqasosanh == 0)
            {
                Console.WriteLine("2 chuỗi giống nhau y hệt");
            }

            else if (kqasosanh < 0)
            {
                Console.WriteLine("Chuỗi đầu nhỏ hơn chuỗi sau");
                Console.WriteLine($"Trong từ điển, {chuoi} sẽ đứng trước {chuoi1}");
            }
            else
            {
                Console.WriteLine("Chuỗi đầu lớn hơn chuỗi sau");
                Console.WriteLine($"Trong từ điển , {chuoi} sẽ đứng sau {chuoi1}");
            }
            //7.đếm số lượng chữ cái , chữ số và kí tự đặc biệt
            //char.IsLetter, char.IsDigit
            Console.WriteLine("Phân loại kí tự");
            phanloai(chuoi);

            //8.đếm số nguyên âm , phụ âm trong chuỗi
            Console.WriteLine();
            demnguynphu(chuoi);

            //9 10 và 12.Kiểm tra 1 chuỗi con xem có tồn tại trong chuỗi ban đầu không, nêu vị trí và xem xuất hiện bao nhiêu lần
            //chuoi.Contains(chuoicon);
            Console.WriteLine("Nhập vào 1 từ cần tìm trong chuỗi");
            string chuoi2 = Console.ReadLine();
            Console.WriteLine("Dò tìm");
            chuoicon(chuoi, chuoi2);

            //11.Kiểm tra xem 1 kí tự có phải là chữ cái hay không , nếu là chữ cái kiểm tra là chữ hoa hay thường
            Console.WriteLine("Nhập vào 1 ký tự để kí tự để kiểm tra");
            char nhap = (char)Console.Read();
            kiemtrathuongin(nhap);
            Console.ReadLine();
            //13.Chèn 1 chuỗi con vào trước vị trí xuất hiện đầu tiên của 1 chuỗi con khác
            Console.WriteLine();
            Console.WriteLine("Nhập vào chuỗi cần chèn");
            string chuoichen = Console.ReadLine();
            Console.WriteLine("Chèn chuỗi này vào trước từ nào");
            string vitrichen = Console.ReadLine();

            Console.WriteLine("Chuỗi sau khi được chèn là");
            string chuoiafter = chenchuoi(chuoi, chuoichen, vitrichen);
            Console.WriteLine($"{chuoiafter}");
        }
        //logic 2
        static int dodai(string chuoi)
        {
            int lenght = 0;
            foreach (char c in chuoi)
            {
                lenght++;
            }
            return lenght;
        }

        //logic3
        static void in_mỗi_chữ(string chuoi)
        {
            for (int i = 0; i < chuoi.Length; i++)
            {
                Console.Write(chuoi[i] + " ");
            }
        }

        //logic4
        static void indaonguoc(string chuoi)
        {
            for (int i = chuoi.Length - 1; i >= 0; i--)
            {
                Console.Write($"{chuoi[i]}");
            }
        }
        //logic5 đếm số từ có trong câu
        static int countwords(string s)
        {
            int sotu = 0;
            bool trongtu = false;
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (c == ' ' || c == '\t' || c == '\n' || c == ',' || c == '.' || c == '!' || c == ';')
                {
                    trongtu = false;
                }
                else
                {
                    if (trongtu == false)
                    {
                        sotu++;
                        trongtu = true;
                    }
                }

            }
            return sotu;
        }
        //logic6 so sánh 2 chuỗi
        static int sosanh(string s1, string s2)
        {
            int minlength = s1.Length < s2.Length ? s1.Length : s2.Length;
            for (int i = 0; i < minlength; i++)
            {
                if (s1[i] != s2[i])
                {
                    return s1[i] - s2[i];
                }
            }
            return s1.Length - s2.Length;
        }

        //loic 7 đếm số chữ cái , chữ số và kí tự đặc biệt
        static void phanloai(string s)
        {
            int chu = 0;
            int so = 0;
            int dacbiet = 0;
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
                {
                    chu++;
                }
                else if (c >= '0' && c <= '9')
                {
                    so++;
                }
                else if (c != ' ' && c != '\t' && c != '\n')
                {
                    dacbiet++;
                }
            }
            Console.WriteLine($"Số chữ cái là : {chu}");
            Console.WriteLine($"Số chữ số là : {so}");
            Console.WriteLine($"Số ký tự đặc biệt là : {dacbiet}");
        }

        //logic 8 đếm số nguyên âm và phụ âm
        static void demnguynphu(string s)
        {
            int nguyen = 0;
            int phu = 0;
            for (int i = 0; i < s.Length; i++)
            {
                char C = s[i];
                char c = char.ToLower(C);
                if (c >= 'a' && c <= 'z')
                {
                    if (c == 'u' || c == 'e' || c == 'o' || c == 'a' || c == 'i')
                    {
                        nguyen++;
                    }
                    else
                    {
                        phu++;
                    }
                }

            }
            Console.WriteLine($"Số nguyên âm là :{nguyen}");
            Console.WriteLine($"Số phụ âm là : {phu}");
        }

        //logic 9 10 12 kiểm tra chuỗi con có tồn tại trong chuỗi ban đầu hay không
        static void chuoicon(string s, string s1)
        {
            if (s.Length < s1.Length || string.IsNullOrEmpty(s1))
            {
                Console.WriteLine($"\"{s1}\" không xuất hiện trong chuỗi chính");
                return;
            }
            int solanxuathien = 0;
            int vitrixuathien = 0;
            while ((vitrixuathien = s.IndexOf(s1, vitrixuathien)) != -1)
            {
                solanxuathien++;
                Console.WriteLine($"tìm thấy tại vị trí {vitrixuathien}");

                vitrixuathien += s1.Length;
            }
            if (solanxuathien > 0)
            {
                Console.WriteLine($"Tổng cộng \"{s1}\" xuất hiện {solanxuathien} lần");
            }
            else
            {
                Console.WriteLine($" \"{s1}\" không xuất hiện trong chuỗi gốc");
            }
        }

            //logic11
            static void kiemtrathuongin(char c)
            {
                if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
                {
                    Console.WriteLine($" Ký tự '{c}' là một chữ cái.");
                    if (c >= 'a' && c <= 'z')
                    {
                        Console.WriteLine("  Và đây là CHỮ THƯỜNG");
                    }
                    else
                    {
                        Console.WriteLine(" Và đây là CHỮ HOA ");
                    }
                }
                else
                {
                    Console.WriteLine($"- Ký tự '{c}' KHÔNG PHẢI là chữ cái!");
                }
            }
            //logic bài 13
            static string chenchuoi(string s, string s1, string vitrichen)
            {
                int vitri = s.IndexOf(vitrichen);
                if (vitri == -1)
                {
                    Console.WriteLine($"Không tìm thấy \"{vitrichen}\" để chèn");
                    return s;
                }
                string dau = s.Substring(0, vitri);
                string cuoi = s.Substring(vitri-1);
                return dau + s1 + cuoi;
            }


        }
    }
