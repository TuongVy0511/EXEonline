using System;
using System.Collections.Generic;
using System.Text;

namespace buoi3
{
    internal class buoi31
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("ex1");
            Console.Write("Enter side a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter side b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter side c: ");
            double c = double.Parse(Console.ReadLine());

            if (a == b && b == c)
                Console.WriteLine("Equilateral triangle.");
            else if (a == b || b == c || a == c)
                Console.WriteLine("Isosceles triangle.");
            else
                Console.WriteLine("Scalene triangle.");

            Console.WriteLine("ex2");
            double sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"Enter number {i}: ");
                sum += double.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Average: {sum / 10}");

            Console.WriteLine("ex3");
            Console.Write("Enter an integer: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{n} x {i} = {n * i}");
            }
        }
    }
}
