using System;
using System.Collections.Generic;
using System.Text;

namespace giaide3
{
    internal class Bai_7
    {
        public static void Main(string[] arg)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int[] mang = { -1, 2, 3, 4, 5, 6, -4, -9, -7 };
            //
            var ketqua = thongke(mang);

            Console.WriteLine($"Số lượng số dương trong mảng là :{ketqua.cd}  , tổng là :{ketqua.td}  ");
            Console.WriteLine($"Số lượng số âm trong mảng là :{ketqua.ca}  , tổng là :{ketqua.ta}  ");
        }
        static (int cd,int td,int ca,int ta) thongke(int[] mang)
        {
            int countD = 0; int countA = 0;
            int tongD = 0; int tongA = 0;
            for (int i = 0; i < mang.Length; i++)
            {
                if (mang[i]>0)
                {
                    countD++;
                    tongD += mang[i];
                }    
                else if( mang[i]<0)
                {
                    countA++;
                    tongA+=mang[i];
                }    
            }
            return (countD, tongD, countA, tongA);
        }
    }
}
