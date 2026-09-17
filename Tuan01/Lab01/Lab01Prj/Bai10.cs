namespace Lab01Prj;

public class Bai10
{
    public static bool KiemTraDoiXung(string s)
    {
        int i = 0;
        int j = s.Length - 1;
        while (i < j)
        {
            if (s[i] != s[j])
                return false;
            i++;
            j--;
        }
        return true;
    }

    public static void Run()
    {
        Console.Write("Nhap chuoi: ");
        string s = Console.ReadLine() ?? "";

        if (KiemTraDoiXung(s))
            Console.WriteLine("Chuoi doi xung.");
        else
            Console.WriteLine("Chuoi khong doi xung.");
    }
}
