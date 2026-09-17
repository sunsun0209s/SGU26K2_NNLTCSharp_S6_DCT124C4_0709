namespace Lab01Prj;

public class SinhVien
{
    public string MaSV = "";
    public string HoTen = "";
    public string DiaChi = "";
    public int NamThuMay;

    public void Nhap()
    {
        Console.Write("Nhap ma sinh vien: ");
        MaSV = Console.ReadLine() ?? "";
        Console.Write("Nhap ho ten: ");
        HoTen = Console.ReadLine() ?? "";
        Console.Write("Nhap dia chi: ");
        DiaChi = Console.ReadLine() ?? "";
        Console.Write("Nhap sinh vien nam thu may: ");
        NamThuMay = int.Parse(Console.ReadLine() ?? "1");
    }

    public void Xuat()
    {
        Console.WriteLine($"Ma SV: {MaSV}, Ho ten: {HoTen}, Dia chi: {DiaChi}, Nam thu: {NamThuMay}");
    }
}

public class Bai13
{
    public static void Run()
    {
        SinhVien sv = new SinhVien();
        sv.Nhap();
        sv.Xuat();
    }
}
