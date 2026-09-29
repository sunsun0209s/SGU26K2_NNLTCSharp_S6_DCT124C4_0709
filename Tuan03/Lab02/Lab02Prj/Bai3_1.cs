namespace Lab02Prj;

public class SinhVien31 : IComparable<SinhVien31>
{
    private string maSV;
    private string hoTen;
    private double dtb;

    public string MaSV
    {
        get { return maSV; }
        set { maSV = value; }
    }

    public string HoTen
    {
        get { return hoTen; }
        set { hoTen = value; }
    }

    public double Dtb
    {
        get { return dtb; }
        set { dtb = value >= 0 && value <= 10 ? value : 0; }
    }

    public SinhVien31()
    {
        maSV = "";
        hoTen = "";
        dtb = 0;
    }

    public SinhVien31(string maSV, string hoTen, double dtb)
    {
        this.maSV = maSV;
        this.hoTen = hoTen;
        this.dtb = dtb;
    }

    public SinhVien31(SinhVien31 other)
    {
        this.maSV = other.maSV;
        this.hoTen = other.hoTen;
        this.dtb = other.dtb;
    }

    // Cài đặt phương thức CompareTo của IComparable<SinhVien31> để sắp xếp theo điểm trung bình tăng dần
    public int CompareTo(SinhVien31? other)
    {
        if (other == null) return 1;
        return this.dtb.CompareTo(other.dtb);
    }

    public void Input()
    {
        Console.Write("Nhập mã sinh viên: ");
        maSV = Console.ReadLine() ?? "";
        Console.Write("Nhập họ tên: ");
        hoTen = Console.ReadLine() ?? "";
        Console.Write("Nhập điểm trung bình: ");
        dtb = double.Parse(Console.ReadLine() ?? "0");
    }

    public void Output()
    {
        Console.WriteLine($"Mã SV: {maSV,-10} | Họ tên: {hoTen,-20} | ĐTB: {dtb,4:N1}");
    }

    public override string ToString()
    {
        return $"Mã SV: {maSV,-10} | Họ tên: {hoTen,-20} | ĐTB: {dtb,4:N1}";
    }
}

public class Bai3_1
{
    public static void Run()
    {
        Console.Write("Nhập số lượng sinh viên: ");
        int n = int.Parse(Console.ReadLine() ?? "0");
        if (n <= 0) return;

        SinhVien31[] ds = new SinhVien31[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\n--- Nhập sinh viên thứ {i + 1} ---");
            ds[i] = new SinhVien31();
            ds[i].Input();
        }

        Console.WriteLine("\nDanh sách sinh viên ban đầu:");
        foreach (var sv in ds)
        {
            sv.Output();
        }

        // Sử dụng Array.Sort nhờ lớp SinhVien31 đã hiện thực interface IComparable
        Array.Sort(ds);

        Console.WriteLine("\nDanh sách sinh viên sau khi sắp xếp theo ĐTB tăng dần:");
        foreach (var sv in ds)
        {
            sv.Output();
        }
    }
}
