using System;
using System.Collections.Generic;
using System.Text;

namespace buoi4
{
    internal class exthem
    { 
        public static void Main(string[] args)
        { 
                Console.OutputEncoding = System.Text.Encoding.UTF8;

                // Bài 1
                Console.WriteLine($"Bài 1: Tổng của 5 và 7 là = {TinhTong(5, 7)}");

                // Bài 2
                Console.WriteLine($"Bài 2: Số 10 là số chẵn? = {KiemTraChan(10)}");

            // Bài 3
            int[] array = { 4, 9, 2 };

            int Max = TimMax(array);
                Console.WriteLine($"Bài 3: Số lớn nhất giữa {array} là ={Max} ");

                // Bài 4
                Console.WriteLine($"Bài 4: Giai thừa của 5 (5!) là = {TinhGiaiThua(5)}");

                // Bài 5
                Console.WriteLine($"Bài 5: Đảo ngược chuỗi 'hello' = {DaoNguocChuoi("hello")}");

                // Bài 6
                Console.WriteLine($"Bài 6: Số 7 có phải số nguyên tố? = {KiemTraNguyenTo(7)}");

                // Bài 7
                Console.Write("Bài 7: Dãy Fibonacci với n = 6 là: ");
                InFibonacci(6);

                // Bài 8
                Console.WriteLine($"Bài 8: Số nguyên âm trong 'Hello World' là = {DemNguyenAm("Hello World")}");

                // Bài 9
                Console.WriteLine($"Bài 9: Lũy thừa 2 mũ 3 là = {TinhLuyThua(2, 3)}");

                // Bài 10
                int[] mangBai10 = { 4, 5, 6, 7 };
                Console.WriteLine($"Bài 10: Điểm trung bình của mảng [4, 5, 6, 7] là = {TinhTrungBinh(mangBai10)}");

                // Bài 11
                Console.WriteLine($"Bài 11: Chuỗi 'radar' đối xứng? = {KiemTraDoiXung("radar")}");

                // Bài 12
                Console.WriteLine($"Bài 12: 25 độ C chuyển sang độ F là = {CelsiusToFahrenheit(25)}");

                // Bài 13
                int[] mangBai13 = { 10, 5, 8, 2, 9 };
                Console.WriteLine($"Bài 13: Phần tử nhỏ nhất trong mảng là = {TimMin(mangBai13)}");

                // Bài 14
                Console.WriteLine($"Bài 14: Tổng các chữ số của 1234 là = {TongCacChuSo(1234)}");

                // Bài 15
                int[] mangBai15 = { 3, 1, 4, 2 };
                Console.Write("Bài 15: Sắp xếp mảng [3, 1, 4, 2] tăng dần: ");
                SapXepMang(mangBai15);

                // Bài 16
                Console.WriteLine($"Bài 16: Xóa lặp ký tự chuỗi 'programming' = {XoaTrungLap("programming")}");

                // Bài 17
                Console.WriteLine($"Bài 17: Ước chung lớn nhất của 12 và 18 là = {UCLN(12, 18)}");

                // Bài 18
                Console.WriteLine($"Bài 18: Thập phân 10 sang nhị phân là = {DecimalToBinary(10)}");

                // Bài 19
                Console.WriteLine($"Bài 19: Năm 2024 có phải năm nhuận? = {KiemTraNamNhuan(2024)}");

                // Bài 20
                string cauHoc = "Học lập trình C# rất thú vị";
                Console.WriteLine($"Bài 20: Số từ trong câu '{cauHoc}' là = {DemSoTu(cauHoc)}");

                Console.ReadLine();
            }


            // Bài 1: Tính tổng hai số nguyên
            static int TinhTong(int a, int b)
            {
                return a + b;
            }

            // Bài 2: Kiểm tra số chẵn lẻ
            static bool KiemTraChan(int n)
            {
                return n % 2 == 0;
            }

            // Bài 3: Tìm số lớn nhất trong ba số
            static int TimMax(int[] array)
            {
            int max = array[0];
            foreach(int i in array)
            {
                if (array[i]>max)
                {
                    max = array[i];
                }    
            }
            return max;
            }

            // Bài 4: Tính giai thừa của một số
            static long TinhGiaiThua(int n)
            {
                long ketQua = 1;
                for (int i = 1; i <= n; i++)
                {
                    ketQua *= i;
                }
                return ketQua;
            }

            // Bài 5: Đảo ngược chuỗi ký tự
            static string DaoNguocChuoi(string input)
            {
                char[] charArray = input.ToCharArray();
                Array.Reverse(charArray);
                return new string(charArray);
            }

            // Bài 6: Kiểm tra số nguyên tố
            static bool KiemTraNguyenTo(int n)
            {
                if (n < 2) return false;
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0) return false;
                }
                return true;
            }

            // Bài 7: In dãy Fibonacci
            static void InFibonacci(int n)
            {
                int a = 0, b = 1;
                for (int i = 0; i < n; i++)
                {
                    Console.Write(a + " ");
                    int temp = a + b;
                    a = b;
                    b = temp;
                }
                Console.WriteLine();
            }

            // Bài 8: Đếm số lượng nguyên âm trong chuỗi
            static int DemNguyenAm(string s)
            {
                int count = 0;
                string nguyenAm = "aeiouAEIOU"; // Tính cả chữ hoa và chữ thường
                foreach (char c in s)
                {
                    if (nguyenAm.Contains(c.ToString()))
                    {
                        count++;
                    }
                }
                return count;
            }

            // Bài 9: Tính lũy thừa (Không dùng Math.Pow)
            static double TinhLuyThua(double x, int y)
            {
                double ketQua = 1;
                for (int i = 0; i < y; i++)
                {
                    ketQua *= x;
                }
                return ketQua;
            }

            // Bài 10: Tính điểm trung bình của mảng
            static double TinhTrungBinh(int[] arr)
            {
                if (arr.Length == 0) return 0;
                int tong = 0;
                foreach (int so in arr)
                {
                    tong += so;
                }
                return (double)tong / arr.Length; // Ép kiểu để ra số thập phân
            }

            // Bài 11: Kiểm tra chuỗi đối xứng (Palindrome)
            static bool KiemTraDoiXung(string s)
            {
                int dau = 0;
                int cuoi = s.Length - 1;
                while (dau < cuoi)
                {
                    if (s[dau] != s[cuoi]) return false;
                    dau++;
                    cuoi--;
                }
                return true;
            }

            // Bài 12: Chuyển đổi nhiệt độ
            static double CelsiusToFahrenheit(double c)
            {
                return c * 1.8 + 32;
            }

            // Bài 13: Tìm giá trị nhỏ nhất trong mảng
            static int TimMin(int[] arr)
            {
                int min = arr[0];
                for (int i = 1; i < arr.Length; i++)
                {
                    if (arr[i] < min)
                    {
                        min = arr[i];
                    }
                }
                return min;
            }

            // Bài 14: Tính tổng các chữ số của một số nguyên
            static int TongCacChuSo(int n)
            {
                int tong = 0;
                n = Math.Abs(n); // Xử lý nếu người dùng nhập số âm
                while (n > 0)
                {
                    tong += n % 10; // Lấy chữ số hàng đơn vị
                    n /= 10;        // Bỏ chữ số hàng đơn vị đã lấy
                }
                return tong;
            }

            // Bài 15: Sắp xếp mảng tăng dần
            static void SapXepMang(int[] arr)
            {
                // Thuật toán đổi chỗ trực tiếp
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (arr[i] > arr[j])
                        {
                            int temp = arr[i];
                            arr[i] = arr[j];
                            arr[j] = temp;
                        }
                    }
                }
                // In kết quả sau khi xếp
                Console.WriteLine(string.Join(" ", arr));
            }

            // Bài 16: Xóa ký tự trùng lặp
            static string XoaTrungLap(string s)
            {
                string ketQua = "";
                foreach (char c in s)
                {
                    if (!ketQua.Contains(c.ToString()))
                    {
                        ketQua += c; // Chỉ cộng vào chuỗi nếu ký tự chưa xuất hiện
                    }
                }
                return ketQua;
            }

            // Bài 17: Tìm ước chung lớn nhất (UCLN) bằng thuật toán Euclid
            static int UCLN(int a, int b)
            {
                while (b != 0)
                {
                    int temp = b;
                    b = a % b;
                    a = temp;
                }
                return Math.Abs(a);
            }

            // Bài 18: Chuyển đổi hệ thập phân sang nhị phân
            static string DecimalToBinary(int n)
            {
                if (n == 0) return "0";
                string nhiPhan = "";
                while (n > 0)
                {
                    nhiPhan = (n % 2) + nhiPhan; // Thêm số dư vào đầu chuỗi kết quả
                    n /= 2;
                }
                return nhiPhan;
            }

            // Bài 19: Kiểm tra năm nhuận
            static bool KiemTraNamNhuan(int year)
            {
                // Năm chia hết cho 400 HOẶC (chia hết cho 4 và không chia hết cho 100)
                return (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
            }

            // Bài 20: Đếm số từ trong câu
            static int DemSoTu(string sentence)
            {
                if (string.IsNullOrWhiteSpace(sentence)) return 0;

                // Tách các từ dựa trên khoảng trắng, tự động loại bỏ khoảng trắng thừa
                string[] tu = sentence.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                return tu.Length;
            }
        }
    }
