//bài 1
namespace EXEonline
{
    internal class buoi4
    {
        static int MaxNumbers(params int[] a)
        {
            int max = a[0];
            foreach (int x in a)
            {
                if (x > max)
                    max = x;
            }
            return max;
        }

        public static void Main(string[] args)
        {

            int x = 5, y = 8, z = 15, t = 9;
            int m = MaxNumbers(x, y, z,t);
            Console.WriteLine($"max of {x},{y},{z},{t} is {m}");

        }
    }
}


