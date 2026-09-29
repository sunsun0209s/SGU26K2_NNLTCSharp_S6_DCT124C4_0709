namespace Lab02Prj;

public class SinhVien32 : IComparable<SinhVien32>
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

    public SinhVien32()
    {
        maSV = "";
        hoTen = "";
        dtb = 0;
    }

    public SinhVien32(string maSV, string hoTen, double dtb)
    {
        this.maSV = maSV;
        this.hoTen = hoTen;
        this.dtb = dtb;
    }

    public SinhVien32(SinhVien32 other)
    {
        this.maSV = other.maSV;
        this.hoTen = other.hoTen;
        this.dtb = other.dtb;
    }

    public int CompareTo(SinhVien32? other)
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
}

public class MangGeneric
{
    // Phương thức sắp xếp tổng quát mô phỏng Array.Sort dựa trên interface IComparable<T>
    public static void MySort<T>(T[] arr) where T : IComparable<T>
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                // Gọi phương thức CompareTo thông qua ràng buộc interface IComparable<T>
                if (arr[i].CompareTo(arr[j]) > 0)
                {
                    T temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }
    }
}

public class Bai3_2
{
    public static void Run()
    {
        Console.Write("Nhập số lượng sinh viên: ");
        int n = int.Parse(Console.ReadLine() ?? "0");
        if (n <= 0) return;

        SinhVien32[] ds = new SinhVien32[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\n--- Nhập sinh viên thứ {i + 1} ---");
            ds[i] = new SinhVien32();
            ds[i].Input();
        }

        Console.WriteLine("\nDanh sách sinh viên ban đầu:");
        foreach (var sv in ds)
        {
            sv.Output();
        }

        // Gọi hàm sắp xếp tổng quát MySort sử dụng interface
        MangGeneric.MySort(ds);

        Console.WriteLine("\nDanh sách sinh viên sau khi sắp xếp bằng MySort (Interface):");
        foreach (var sv in ds)
        {
            sv.Output();
        }
    }
}
