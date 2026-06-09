using System;
using System.Collections.Generic;
using System.Text;

namespace giaide1
{
    internal class Bai_10
    {
        /*public static void Main(string[] arg)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string fileThongtin = "sv.txt";
            bai_10(fileThongtin);
            Console.ReadLine();
        }

        static void bai_10(string path)
        {
            try 
            {
                using(StreamWriter nhapthongtin=new StreamWriter(path))
                {
                    nhapthongtin.WriteLine("Họ và Tên: Lương Ngọc Tường Vy");
                    nhapthongtin.WriteLine("Lớp: IS0002");
                    nhapthongtin.WriteLine("MSSV: 31251026827");
                    nhapthongtin.WriteLine("Ngày sinh: 05/11/2007");

                }    
            }
            catch(Exception baoloi)
            {
                Console.WriteLine(baoloi.Message);
            }
            try 
            {
                string hoten = "";
                string lop = "";
                string mssv = "";
                string namsinh = "";

                using (StreamReader doc=new StreamReader(path))
                {
                    string dong;
                    while((dong=doc.ReadLine())!=null)
                    {
                        if(!string.IsNullOrWhiteSpace(dong))
                        {
                            string[] thanhphan = dong.Split(':');
                            string modau = thanhphan[0].Trim();
                            string noidung = thanhphan[1].Trim();

                            if (modau=="Họ và Tên")
                            {
                                hoten = noidung;
                            }    
                            else if(modau=="Lớp")
                            {
                                lop = noidung;
                            }    
                            else if(modau=="MSSV")
                            {
                                mssv = noidung;
                            }  
                            else if(modau=="Ngày sinh")
                            {
                                namsinh = noidung.Substring(noidung.Length - 4);
                            }    
                        }    
                    }    
                }
                Console.WriteLine($"{mssv}-{hoten}-{lop}-{namsinh}");
            }
            catch(Exception baoloi)
            {
                Console.WriteLine(baoloi.Message);
            }
        }*/

        static void Main(string[] arg)
        {
            // Cấu hình hiển thị tiếng Việt có dấu trên Console không bị lỗi font
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            string file = "mssv.txt";

            string[] lines = {
            "Ho ten: Lương Ngọc Tường Vy",
            "Lop: IS0002",
            "MSSV: 31251026827",
            "Ngay sinh: 05/11/2007" };
        
            File.WriteAllLines(file,lines);

            
            InThongTinSinhVien(file);

            Console.ReadLine(); 
        }

        
        static void InThongTinSinhVien(string Path)
        {
            try
            {
                // Đọc toàn bộ các dòng từ file
                string[] readLines = File.ReadAllLines(Path);

                string hoTen = readLines[0].Split(':')[1].Trim();
                string lop = readLines[1].Split(':')[1].Trim();
                string mssv = readLines[2].Split(':')[1].Trim();
                string ngaySinh = readLines[3].Split(':')[1].Trim();
                string namSinh = ngaySinh.Split('/')[2];

                Console.WriteLine($"Kết quả bóc tách: {mssv} – {hoTen} – {lop} – {namSinh}");
            }
            catch (Exception baoloi)
            {
                Console.WriteLine(baoloi.Message);
            }
        }

    }
}
