using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace giaide3
{
    internal class Bai_2
    {
        public static void Main(string[] arg)
        {
            Console.OutputEncoding=Encoding.UTF8;
            Console.WriteLine("Nhập họ và tên của bạn:");
            string ten=Console.ReadLine();
            double chisocu = 0;
            double chisomoi = 0;
            do
            {
                Console.WriteLine("Nhập chỉ số cũ:"); chisocu =double.Parse( Console.ReadLine());
                Console.WriteLine("Nhập chỉ số mới"); chisomoi=double.Parse(Console.ReadLine());

                if(chisomoi<chisocu)
                {
                    Console.WriteLine("Nhập lại chỉ số mới và cũ (chỉ số mới > chỉ số cũ)!!!");
                }    
            }
            while (chisomoi < chisocu);

            double tieuthu = chisomoi - chisocu;
            double tiendien = tieuthu * 452.45;
            double phuthu = tiendien * (10 / 100);
            double thue = 12426;

            string giaodien = new string('-', 50);

            Console.Clear();
            Console.WriteLine($"\n{giaodien}" +
                $"\nKhach hang:{ten}" +
                $"\nChi so cu:{chisocu}" +
                $"\nChi so moi:{chisomoi}" +
                $"\nTieu thu:{tieuthu}" +
                $"\nTien dien:{tiendien}" +
                $"\nTien thue dien ke 12426 đ/thang." +
                $"\nTien phu thu bang 10% tien dien." +
                $"\nTong tien phai tra:{tiendien+phuthu+thue}" +
                $"\nYeu cau tiet kiem dien." +
                $"\n{giaodien}");
        }
    }
}
