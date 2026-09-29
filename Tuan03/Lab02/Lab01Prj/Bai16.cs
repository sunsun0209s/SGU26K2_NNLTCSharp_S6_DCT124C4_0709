namespace Lab01Prj;

public class Bai16
{
    public static void Run()
    {
        Console.Write("Nhap so nguoi n: ");
        int n = int.Parse(Console.ReadLine() ?? "0");

        string[] ds = new string[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhap ho ten nguoi thu {i + 1}: ");
            ds[i] = Console.ReadLine() ?? "";
        }

        Array.Sort(ds);

        Console.WriteLine("Danh sach sau khi sap xep tang dan:");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(ds[i]);
        }
    }
}
