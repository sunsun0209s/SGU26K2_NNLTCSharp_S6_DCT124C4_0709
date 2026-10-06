namespace Lab01Prj;

public class Bai15
{
    public static int[] NhapMang(int n)
    {
        int[] a = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"a[{i}] = ");
            a[i] = int.Parse(Console.ReadLine() ?? "0");
        }
        return a;
    }

    public static void InMang(int[] a)
    {
        for (int i = 0; i < a.Length; i++)
        {
            Console.Write(a[i] + " ");
        }
        Console.WriteLine();
    }

    public static void TimMinMax(int[] a, out int min, out int max)
    {
        min = a[0];
        max = a[0];
        for (int i = 1; i < a.Length; i++)
        {
            if (a[i] < min) min = a[i];
            if (a[i] > max) max = a[i];
        }
    }

    private static bool KiemTraNguyenTo(int n)
    {
        if (n < 2) return false;
        for (int i = 2; i * i <= n; i++)
        {
            if (n % i == 0) return false;
        }
        return true;
    }

    public static int[] LaySoNguyenTo(int[] a)
    {
        List<int> list = new List<int>();
        for (int i = 0; i < a.Length; i++)
        {
            if (KiemTraNguyenTo(a[i]))
                list.Add(a[i]);
        }
        return list.ToArray();
    }

    public static void Run()
    {
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine() ?? "0");

        int[] a = NhapMang(n);
        Console.Write("Mang vua nhap: ");
        InMang(a);

        TimMinMax(a, out int min, out int max);
        Console.WriteLine($"Phan tu nho nhat: {min}");
        Console.WriteLine($"Phan tu lon nhat: {max}");

        int[] nt = LaySoNguyenTo(a);
        Console.Write("Cac so nguyen to trong mang: ");
        InMang(nt);
    }
}
