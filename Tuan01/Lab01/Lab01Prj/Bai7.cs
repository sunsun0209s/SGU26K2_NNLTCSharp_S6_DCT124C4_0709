namespace Lab01Prj;

public class Bai7
{
    public static bool KiemTraNguyenTo(int n)
    {
        if (n < 2) return false;
        for (int i = 2; i * i <= n; i++)
        {
            if (n % i == 0) return false;
        }
        return true;
    }

    public static void Run()
    {
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine() ?? "0");

        if (KiemTraNguyenTo(n))
            Console.WriteLine($"{n} la so nguyen to.");
        else
            Console.WriteLine($"{n} khong phai la so nguyen to.");
    }
}
