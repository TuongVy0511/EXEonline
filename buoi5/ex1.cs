using System.ComponentModel.Design;
using System.Text;
using System.Transactions;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        int[] array = { 10, 12, 5, 4, 6, 7, 8, 11, 50, 66, 34, 2, 34, 7,8,4,};
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
        //bài4
        Console.WriteLine("Nhập vào 1 số xần xóa khỏi mảng");
        int z=int.Parse(Console.ReadLine());
        int[] finalarray = delete(array, z);
        if (kiemtratontai(array, z))

        {
            foreach (int z1 in finalarray)
            {
                Console.WriteLine(z1 + " ");
            }
        }
        else { Console.WriteLine($"Số {z} không tồn tại trong mảng"); }
        
            //bài5
            int[] lnnn = findmaxmin(array);
        Console.WriteLine($"Giá trị lớn nhất trong mảng là {lnnn[0]}");
        Console.WriteLine($"Giá trị nhỏ nhất trong mảng là {lnnn[1]}");
        //bài6
        Console.WriteLine($"Mảng sau khi đảo ngược là ");
        array = daonguoc(array);
        Console.WriteLine(string.Join(" ",array));
        //bài7
        int[] cacsotrung = timphantutrunglap(array);
        if(cacsotrung.Length==0)
        {
            Console.WriteLine("Mảng không có phần tử nào giống nhau");
        }    
        else
        {
            Console.WriteLine("các phần tử trùng lặp với nhau là");
            Console.WriteLine(string.Join(" ",cacsotrung));
        }    
        //bài7 dùng list
        List<int> cacsotrung1= timphantutrunglap1(array);
        if(cacsotrung1.Count==0)
        {
            Console.WriteLine("Mảng không có phần tử nào trùng hết");
        }
        else 
        {
            Console.WriteLine("Các phần tử trùng nhau là");
            Console.WriteLine(string.Join(" ",cacsotrung1));
        }
        //bài8
        List<int> mangduynhat = xoaphantutrunglap(array);
        Console.WriteLine("Mảng sau khi đã xóa các phần tử trùng lặp là");
        Console.WriteLine(string.Join(" ",mangduynhat));

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

    //logic4
    static int[] delete(int[] array,int n)
    {
        int conlai = 0;
        foreach(int x in array)
        {
            if (x != n)
                conlai++;
        }
        int[] mangmoi = new int[conlai];
        int j = 0;
        for(int i=0;i<array.Length;i++)
        {
            if(array[i] == n)
            { continue; }
            mangmoi[j]=array[i];
            j++;
        }    
        return mangmoi;
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
    static int[] daonguoc(int[] array)
    {
        int[] mangnguoc=new int[array.Length];
        int j = 0;
        for (int i = array.Length - 1; i >= 0; i--)
        {
            mangnguoc[j] = array[i];
            j++;
        }
        return mangnguoc;
    }
    //logic7
    static int[] timphantutrunglap(int[] array)
    {
        int[] mangchua=new int[array.Length];
        int count = 0;
        for(int i=0; i<array.Length; i++)
        {
            for(int j=i+1; j<array.Length; j++)
            {
                if (array[i]==array[j])
                {
                    if(!mangchua.Contains(array[i]))
                    {
                        mangchua[count] = array[i];
                        count++;
                    }
                }   
            }  
        }
        int[] ketqua = new int[count];
        for (int i = 0; i < count; i++)
        {
            ketqua[i] = mangchua[i];
        }
        return ketqua;
    }
    //logic7-dùng list
    static List<int> timphantutrunglap1(int[] array)
    {
        List<int> mangchua1 = new List<int>();
        for(int i=0;i<array.Length;i++)
        {
            for(int j=i+1; j<array.Length;j++)
            {
                if (array[i] == array[j] && !mangchua1.Contains(array[i]))
                {
                    mangchua1.Add(array[i]);
                    break;
                }    
            }    
        }
        return mangchua1;
    }

    //logic8
    static List<int> xoaphantutrunglap(int[] array)
    {
        List<int> ketquasauxoa=new List<int>();
        foreach(int i in array)
        {
            if(!ketquasauxoa.Contains(i))
            {
                ketquasauxoa.Add(i);
            }    
        }
        return ketquasauxoa;
    }
}