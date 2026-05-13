using System;
using System.Collections.Generic;
using System.Text;

namespace buoi4
{
    internal class buoi4_4
    {
        static bool songuyento(int x)
        {
            if (x < 2)
                return false;

            for (int i = 2; i * i <= x; i++)
            {
                if (x % i == 0)
                    return false;
            }
            return true;
        }

        static string PrintprimesUnderN(int n)
        {
            string result = "";
            for(int i =2; i<n;i++)
            {
                if (songuyento(i))
                    result += i + " ";
            }
            return result;
        }

        static string PrintFirstNPrimes(int n)
        {
            string result = "";
            int count = 0;
            int number = 2;
            while(count<n)
            {
                if(songuyento(number))
                {
                    result+= number + " ";
                    count++;

                }
                number++;
            }
            return result;
        }

        public static void Main(string[] args)
        {
            Console.OutputEncoding= Encoding.UTF8;
            Console.WriteLine("Nhập vào giới hạn");
            int n=int.Parse(Console.ReadLine());
            Console.WriteLine($"Các số nguyên tố nhỏ hơn {n} là");
            Console.WriteLine(PrintprimesUnderN(n));
            Console.WriteLine($"{n} số nguyên tố đầu tiên là");
            Console.WriteLine(PrintFirstNPrimes(n));
        }


    }
}
