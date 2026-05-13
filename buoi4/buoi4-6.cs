using System;
using System.Collections.Generic;
using System.Text;

namespace buoi4
{
    internal class buoi4_6
    {
        static bool CheckPangram(string Cau)
        {
            Cau = Cau.ToLower();
            string bangchucai = "abcdefghijklmnopqrstuvwxyz";
            foreach (char chucai in bangchucai)
            {
                if (!Cau.Contains(chucai))
                { return false; }
            }
            return true;
        }

        public static void Main(string[] args)
        { 
            Console.OutputEncoding=Encoding.UTF8;
            Console.WriteLine("Hãy nhập vào một câu tiếng Anh");
            string nhap = Console.ReadLine();

            if(CheckPangram(nhap))
            { Console.WriteLine("đây là chuỗi pangram"); }
            else 
            { Console.WriteLine("đây không phải là chuỗi pangram"); }
        }
    }
}
