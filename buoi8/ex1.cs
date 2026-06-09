using System;
using System.Collections.Generic;
using System.Text;

namespace buoi8
{
    internal class ex1
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Kiểm tra xem hiện tại code đang được lưu ở thư mục nào
            string thuMucHienTai = Environment.CurrentDirectory;
            Console.WriteLine(" Thu muc lam viec cua ban đang ở : " + thuMucHienTai);
            //những bài đầu là số nên để nó random
            string filepath = "dayso.txt";
            int n = 10;
            GhiDaySo(filepath, n);
            Console.WriteLine("Kết quả in dãy số là:");
            InDayso(filepath);
            Console.WriteLine();
            Console.WriteLine("Kết quả sau khi xóa những hàng trống là");
            XoaSpace(filepath);
            Console.WriteLine();
            Console.WriteLine("Kết quả in file với những số chẵn là ");
            InSoChan(filepath);
            //những bài sau nhập sẵn câu cho nó luôn

            //nhập file
            string filepath1 = "cau.txt";
            try 
            { 
            using(StreamWriter cau=new StreamWriter(filepath1))
                {
                    cau.WriteLine("Hoc lap trinh C# rất vui.");
                    cau.WriteLine("Lap trinh C# giup ban thong minh hon.");
                    cau.WriteLine("hay cham chi hoc C# nhe.");

                }
            }
            catch(Exception baoloi)
            {
                Console.WriteLine("Lỗi tạo file :"+ baoloi.Message);
            }
            //tiếp tục yêu cầu với file đã tạo
            string word = "C#";
            int solan = DemTuKhoa(filepath1,word);
            Console.WriteLine($"Từ {word} xuất hiện {solan} trong file");
            Console.WriteLine();
            Console.WriteLine("File sau khi chuyển hoa <=> thường là ");
            ChuyenDoiChuHoaThuong(filepath1, true);
            Console.WriteLine("Câu sau khi bị thay thế từ là");
            string cu = "VUI";
            string moi = "KHONG VUI";
            ThayTheTuKhoa(filepath1, cu, moi);
            Console.WriteLine();
            //ghép 2 file 
            string filepathdich = "dich.txt";
            Console.WriteLine("Sau khi ghép 2 file là");
            GhepHaiFile(filepath, filepath1, filepathdich);
        }

        //hàm ghi file , tạo file
        static void GhiDaySo(string path, int n)
        {
            try
            {
                Random x = new Random();
                using (StreamWriter sw = new StreamWriter(path))
                {
                    for (int i = 0; i <= n; i++)
                    {
                        int num = x.Next(1, 101);
                        sw.WriteLine(num);
                    }
                }

            }
            catch (Exception baoloi)
            {
                Console.WriteLine(baoloi.Message);
            }
        }
        //bài1
        //hàm in fie ra màn hình
        static void InDayso(string path)
        {
            try
            {
                using (StreamReader dayso = new StreamReader(path))
                {
                    string dong;
                    while ((dong = dayso.ReadLine()) != null)
                    {
                        xuly(dong);
                    }
                }
            }
            catch (Exception baoloi)
            {
                Console.WriteLine(baoloi.Message);
            }
        }
        //xử lý hàm in bài 1
        static void xuly(string line)
        {
            Console.Write(line + ",");
        }

        //bài 2
        static void XoaSpace(string path)
        {
            try
            {
                using (StreamReader dayso = new StreamReader(path))
                {
                    string dong;
                    while((dong=dayso.ReadLine())!=null)
                    {
                        xuly2(dong);
                    }    
                }
            } 
            catch(Exception baoloi)
            {
                Console.WriteLine(baoloi.Message);
            }
        }
        //hàm xử lý hàm để in bài 2
        static void xuly2(string line)
        {
            if(!string.IsNullOrWhiteSpace(line))
            {
                Console.WriteLine(line);
            }    
        }

        //bài 3
        static void InSoChan(string path)
        {
            try 
            { 
                using(StreamReader dayso=new StreamReader(path))
                {
                    string dong;
                    while((dong=dayso.ReadLine())!=null)
                    {
                        xuly3(dong);
                    }
                }    
            }
            catch(Exception baoloi)
            {
                Console.WriteLine(baoloi.Message);
            }
        }
        //hàm xử lý in bài 3
        static void xuly3(string line)
        {
            if(!string.IsNullOrWhiteSpace(line))
            {
                int so = int.Parse(line);
                if(so%2==0)
                {
                    Console.Write(so+ ",");
                }    
            }    
        }

        //bài4
        static int dem = 0;
        static string tucantim = "";
        static int DemTuKhoa(string path, string keyword)
        {
            try 
            {
                dem = 0;
                tucantim = keyword.ToLower();
                using(StreamReader cau=new StreamReader(path))
                {
                    string dong;
                    while((dong=cau.ReadLine())!= null)
                    {
                        xuly4(dong);
                    }    
                }    
            }
            catch(Exception baoloi)
            {
                Console.WriteLine(baoloi.Message);
            }
            return dem;
        }
        //xử lý bài 4
        static void xuly4(string line)
        {
            if(! string.IsNullOrWhiteSpace(line))
            {
                string[] cattu = line.Split(' ');
                foreach( string tu in cattu)
                {
                    string tusach = tu.Trim('.', ',', '!', '?').ToLower();
                    if(tusach==tucantim)
                    {
                        dem++;
                    }    
                }    
            }    
        }
        //bài 5

        static string filechua = "";
        static bool bienToUpper = true;
        static void ChuyenDoiChuHoaThuong(string path, bool toUpper)
        {
            try 
            {
                filechua = "";
                bienToUpper = toUpper;

                using(StreamReader cau=new StreamReader(path))
                {
                    string dong;
                    while((dong=cau.ReadLine())!=null)
                    {
                        xuly5(dong);
                    }    
                }
                Console.WriteLine(filechua);

                //->>cái using đàu tiên là hàm logic để in ra màn hình cái file đã đổi hoa thành thường
                //->> cái using thứ 2 là hàm logic để cho cái dòng đã biến đổi đã vào lại cái file
                using(StreamWriter ghilai= new StreamWriter(path))
                {
                    ghilai.Write(filechua);
                }    
            }
            catch(Exception baoloi)
            {
                Console.WriteLine(baoloi.Message);
            }

        }

        //hàm xử lý bài 5
        static void xuly5(string line)
        {
            string dongdadoi = bienToUpper ? line.ToUpper() : line.ToLower();
            filechua += dongdadoi ;
        }

        //bài 6
        static string filechua1= "";
        static string  tucu="";
        static string tumoi = "";

        static void ThayTheTuKhoa(string path, string oldword, string newword)
        {
            try 
            {
                filechua1 = "";
                tucu = oldword;
                tumoi = newword;

                using(StreamReader cau= new StreamReader(path))
                {
                    string dong;
                    while((dong=cau.ReadLine())!=null)
                    {
                        xuly6(dong);
                    }    
                }
                Console.WriteLine(filechua1);
            }
            catch(Exception baoloi)
            {
                Console.WriteLine(baoloi.Message);
            }
        }
        //hàm xử lý bài 6
        static void xuly6(string line)
        {
            string dathay = line.Replace(tucu,tumoi);
            filechua1 += dathay;
        }

        //bài 7
        static void GhepHaiFile(string path, string path1, string pathdich)
        {
            try 
            {
                string dong;
                using(StreamReader dayso= new StreamReader(path) )
                using (StreamWriter ghi=new StreamWriter(pathdich))
                {
                    while((dong=dayso.ReadLine())!=null)
                    {
                        ghi.Write(dong);
                        Console.Write(dong);
                    }    
                } 
                using(StreamReader cau=new StreamReader(path1))
                using (StreamWriter ghitiep= new StreamWriter(pathdich,true))
                { 
                while((dong=cau.ReadLine())!=null)
                    {
                        ghitiep.Write(dong);
                        Console.Write(dong);
                    }    
                }    
            
            }
            catch(Exception baoloi)
            {
                Console.WriteLine(baoloi.Message);
            }
        }
    }
}
