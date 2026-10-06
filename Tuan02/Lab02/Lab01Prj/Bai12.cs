namespace Lab01Prj;

public class Bai12
{
    public static void Run()
    {
        Console.Write("Nhap chuoi: ");
        string s = Console.ReadLine() ?? "";

        Console.WriteLine("Chuoi chu thuong: " + s.ToLower());
        Console.WriteLine("Chuoi chu hoa: " + s.ToUpper());

        string[] tu = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine("So tu trong chuoi: " + tu.Length);
    }
}
