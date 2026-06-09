using System;
using System.Collections.Generic;
using System.Text;

namespace giaide2
{
    internal class Bai_10
    {
        public static void Main(string[] arg)
        {
            Console.OutputEncoding=Encoding.UTF8;
            //ghi thông tin cho file
            string thongtin = "thongtin.txt";
            string[] lines = {"Ho ten: Luong Ngoc Tuong Vy" ,
                    "Ma so nhan vien : 31251026827" ,
                    "Chuc vu : Sinh Vien" ,
                    "Ngay vao lam : 05/11/2007"};
            File.WriteAllLines(thongtin, lines);
            //in ra màn hình
            bai10(thongtin);
            //
            Console.ReadLine();
        }
        static void bai10(string path)
        {
            try
            {
                string[] readlines=File.ReadAllLines(path);
                //tính thâm niên
                string chuoingaythangnam = readlines[3].Split(':')[1].Trim();
                DateTime ngaythangnam = DateTime.ParseExact(chuoingaythangnam, "dd/MM/yyyy", null);
                int namhientai = DateTime.Now.Year;
                int thamnien = namhientai - ngaythangnam.Year;
                //in ra
                Console.WriteLine($"\n {readlines[1]}" +
                    $"\n {readlines[0]}" +
                    $"\n {readlines[2]}" +
                    $"\n Tham nien: { thamnien} nam");
            }
            catch(Exception baoloi)
            {
                Console.WriteLine(baoloi.Message);
            }
        }

    }
}
