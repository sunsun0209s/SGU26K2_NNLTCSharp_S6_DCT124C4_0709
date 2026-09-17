namespace Lab01Prj;

public class Bai11
{
    public static string DaoChuoi(string s)
    {
        char[] arr = s.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }

    public static void Run()
    {
        Console.Write("Nhap chuoi: ");
        string s = Console.ReadLine() ?? "";

        string kq = DaoChuoi(s);
        Console.WriteLine($"Chuoi dao: {kq}");
    }
}
