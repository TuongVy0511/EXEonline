using System.Transactions;

internal class Program
{
    public static void Main(string[] args)
    {
        int[] array = { 10, 12, 5, 4, 6, 7, 8, 11, 50, 66, 34, 2, 34, };
        //bài1
        double tb = average(array);
        Console.WriteLine($"Giá trị trung trình của array là: {tb}");
        //bài2
        Console.WriteLine("Nhập vào 1 số y để kiểm tra");
        int y = int.Parse(Console.ReadLine());
        bool check = kiemtratontai(array, y);
        if (check)
            Console.WriteLine($"{y} tồn tại trong mảng");
        else
            Console.WriteLine($"{y} không tồn tại trên mảng ");
        //bài3
        Console.WriteLine("Nhập vào 1 số x để kiểm tra");
        int x = int.Parse(Console.ReadLine());
        int check1 = find(array, x);
        Console.WriteLine($"Vị trí của {x} trong mảng là {check1}");
        //bài5
        int[] lnnn = findmaxmin(array);
        Console.WriteLine($"Giá trị lớn nhất trong mảng là {lnnn[0]}");
        Console.WriteLine($"Giá trị nhỏ nhất trong mảng là {lnnn[1]}");
        //bài6



    }
    //logic1
    static double average(int[] array)
    {
        double sum = 0, trungbinh = 0;
        foreach (int i in array)
            sum += i;
        trungbinh = sum / array.Length;
        return trungbinh;
    }

    //logic2
    static bool kiemtratontai(int[] array, int n)
    {
        foreach (int x in array)
            if (x == n)
            { return true; }
        return false;
    }

    //logic3
    static int find(int[] array, int n)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == n)
            {
                return i;
            }
        }
        return -1;
    }

    //logic5
    static int[] findmaxmin(int[] array)
    {
        int max = array[0];
        int min = array[0];

        for(int i=1;  i< array.Length; i++)
        {
            if (array[i] > max)
                max = array[i];
            if (array[i] < min)
                min = array[i];
        }
        return new int[] { max, min };
    }

    //logic6

}