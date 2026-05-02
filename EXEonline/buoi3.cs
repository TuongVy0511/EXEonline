using System;
using System.Linq;

namespace ExercisesCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // --- BÀI 1: MÁY TÍNH CƠ BẢN ---
            Console.WriteLine("BÀI 1: MÁY TÍNH CƠ BẢN");
            Console.Write("Nhập số thứ nhất: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhập toán tử (+, -, *, /): ");
            char op = Convert.ToChar(Console.ReadLine());
            Console.Write("Nhập số thứ hai: ");
            double b = Convert.ToDouble(Console.ReadLine());

            if (op == '+') Console.WriteLine($"Kết quả: {a} + {b} = {a + b}");
            else if (op == '-') Console.WriteLine($"Kết quả: {a} - {b} = {a - b}");
            else if (op == '*') Console.WriteLine($"Kết quả: {a} * {b} = {a * b}");
            else if (op == '/') Console.WriteLine(b != 0 ? $"Kết quả: {a} / {b} = {a / b}" : "Lỗi: Không thể chia cho 0.");

            // --- BÀI 2: HÀM SỐ x = y² + 2y + 1 ---
            Console.WriteLine("\n BÀI 2: GIÁ TRỊ HÀM SỐ (y từ -5 đến 5)");
            Console.WriteLine("y\t x");
            for (int y = -5; y <= 5; y++)
            {
                Console.WriteLine($"{y}\t {y * y + 2 * y + 1}");
            }

            // --- BÀI 3: TÍNH VẬN TỐC ---
            Console.WriteLine("\n BÀI 3: TÍNH VẬN TỐC ");
            Console.Write("Nhập khoảng cách (m): ");
            float dist = Convert.ToSingle(Console.ReadLine());
            Console.Write("Giờ: "); float h = Convert.ToSingle(Console.ReadLine());
            Console.Write("Phút: "); float m = Convert.ToSingle(Console.ReadLine());
            Console.Write("Giây: "); float s = Convert.ToSingle(Console.ReadLine());

            float totalHours = h + (m / 60) + (s / 3600);
            float kph = (dist / 1000) / totalHours;
            Console.WriteLine($"Vận tốc: {kph:F2} km/h | {kph / 1.609f:F2} miles/h");

            // --- BÀI 4: HÌNH CẦU ---
            Console.WriteLine("\nBÀI 4: DIỆN TÍCH & THỂ TÍCH HÌNH CẦU ");
            Console.Write("Nhập bán kính r: ");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Diện tích: {4 * Math.PI * r * r:F2}");
            Console.WriteLine($"Thể tích: {(4.0 / 3.0) * Math.PI * Math.Pow(r, 3):F2}");

            // --- BÀI 5: KIỂM TRA KÝ TỰ ---
            Console.WriteLine("\nBÀI 5: KIỂM TRA KÝ TỰ ");
            Console.Write("Nhập 1 ký tự: ");
            char ch = char.ToLower(Convert.ToChar(Console.ReadLine()));

            if (char.IsDigit(ch)) Console.WriteLine("Đây là chữ số.");
            else if ("aeiou".Contains(ch)) Console.WriteLine("Đây là nguyên âm.");
            else Console.WriteLine("Đây là ký tự khác hoặc phụ âm.");

            Console.WriteLine("\n=== HOÀN THÀNH TẤT CẢ BÀI TẬP ===");
            Console.ReadKey();
        }
    }
}