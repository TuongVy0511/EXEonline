using System;
using System.Collections.Generic;
using System.Text;

namespace giaide3
{
    internal class Bai_8
    {
        public static void Main(string[] arg)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào 1 chuỗi để kiểm tra");
            string chuoi = Console.ReadLine();

            int countchu = 0;
            int countCHU = 0;
            int countso = 0;
            int countkytu = 0;
            foreach (char c in chuoi)
            {
                if (char.IsLower(c))
                {
                    countchu++;
                }
                else if (char.IsUpper(c))
                {
                    countCHU++;

                }
                else if (char.IsDigit(c))
                {
                    countso++;

                }
                else if (!char.IsWhiteSpace(c))
                {
                    countkytu++;

                }
            }
            Console.WriteLine($"Số chữ thường là {countchu}");
            Console.WriteLine($"Số chữ hoa là {countCHU}");
            Console.WriteLine($"Số chữ số là {countso}");
            Console.WriteLine($"Số ký tự đặc biệt là {countkytu}");
        }
    }
}
