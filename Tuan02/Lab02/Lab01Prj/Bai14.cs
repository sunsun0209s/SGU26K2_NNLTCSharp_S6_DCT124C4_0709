namespace Lab01Prj;

public class NhanVien
{
    public string HoTen = "";
    public double MucLuong;
    public int SoNgayVang;

    public void Nhap()
    {
        Console.Write("Nhap ho ten: ");
        HoTen = Console.ReadLine() ?? "";
        Console.Write("Nhap muc luong: ");
        MucLuong = double.Parse(Console.ReadLine() ?? "0");
        Console.Write("Nhap so ngay vang: ");
        SoNgayVang = int.Parse(Console.ReadLine() ?? "0");
    }

    public double TinhLuong()
    {
        return MucLuong - SoNgayVang * 100000;
    }

    public void Xuat()
    {
        Console.WriteLine($"Ho ten: {HoTen}");
        Console.WriteLine($"Luong thuc linh: {TinhLuong()}");
    }
}

public class Bai14
{
    public static void Run()
    {
        NhanVien nv = new NhanVien();
        nv.Nhap();
        nv.Xuat();
    }
}
