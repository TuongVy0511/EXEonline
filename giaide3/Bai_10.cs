using System;
using System.Collections.Generic;
using System.Text;

namespace giaide3
{
    internal class Bai_10
    {
        public static void Main(string[] arg)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string file = "ueh.txt";
            string[] lines = { "Cơ sở A: 59c Nguyễn Đình Chiểu", "Cơ sở B: 279 Nguyễn Tri Phương", "Cơ sở C: 91 đường 3/2", "Cơ sở C: 196 Trần Quang Khải", "Cơ sở E: 54 Nguyễn Văn Thủ", "Cơ sở Nguyễn Văn Linh-xã Phong Phú" };
            File.WriteAllLines(file, lines);
            //in ra màn hình
            Bai10(file);
            Console.ReadLine();
        }
        static void Bai10(string path)
        {
            try
            {
                string[] Readlines = File.ReadAllLines(path);
                Console.WriteLine($"\n{Readlines[0]}" +
                    $"\n{Readlines[1]}" +
                    $"\n{Readlines[2]}" +
                    $"\n{Readlines[3]}" +
                    $"\n{Readlines[4]}" +
                    $"\n{Readlines[5]}");
            }
            catch(Exception baoloi)
            {
                Console.WriteLine(baoloi.Message);
            }
        }
    }
}
