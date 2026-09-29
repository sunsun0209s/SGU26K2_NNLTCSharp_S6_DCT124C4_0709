namespace Lab02Prj;

public class SinhVien
{
    private string hoTen;
    private int namSinh;

    public string HoTen
    {
        get { return hoTen; }
        set { hoTen = value; }
    }

    public int NamSinh
    {
        get { return namSinh; }
        set { namSinh = value; }
    }

    public SinhVien()
    {
        hoTen = "";
        namSinh = DateTime.Now.Year;
    }

    public SinhVien(string hoTen, int namSinh)
    {
        this.hoTen = hoTen;
        this.namSinh = namSinh;
    }

    public SinhVien(SinhVien sv)
    {
        hoTen = sv.hoTen;
        namSinh = sv.namSinh;
    }

    public int TinhTuoi()
    {
        return DateTime.Now.Year - namSinh;
    }

    public void Nhap()
    {
        Console.Write("Nhap ho ten: ");
        hoTen = Console.ReadLine() ?? "";

        Console.Write("Nhap nam sinh: ");
        namSinh = int.Parse(Console.ReadLine() ?? "0");
    }

    public void Xuat()
    {
        Console.WriteLine($"Ho ten: {hoTen}");
        Console.WriteLine($"Nam sinh: {namSinh}");
        Console.WriteLine($"Tuoi: {TinhTuoi()}");
    }

    public override string ToString()
    {
        return $"Ho ten: {hoTen} - Nam sinh: {namSinh} - Tuoi: {TinhTuoi()}";
    }
}

public class Bai1_1
{
    public static void Run()
    {
        SinhVien sv = new SinhVien();
        sv.Nhap();
        Console.WriteLine("Thong tin sinh vien:");
        sv.Xuat();
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        Bai1_1.Run();
    }
}
