namespace Lab02Prj;

// Định nghĩa delegate so sánh 2 phần tử kiểu T
public delegate int SoSanh<T>(T a, T b);

public class SinhVien33
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

    public SinhVien33()
    {
        maSV = "";
        hoTen = "";
        dtb = 0;
    }

    public SinhVien33(string maSV, string hoTen, double dtb)
    {
        this.maSV = maSV;
        this.hoTen = hoTen;
        this.dtb = dtb;
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

public class MangDelegate
{
    // Phương thức sắp xếp mảng tổng quát nhận tiêu chí so sánh thông qua delegate
    public static void SortByDelegate<T>(T[] arr, SoSanh<T> compare)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                // Gọi delegate để kiểm tra thứ tự
                if (compare(arr[i], arr[j]) > 0)
                {
                    T temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }
    }
}

public class Bai3_3
{
    public static void Run()
    {
        Console.Write("Nhập số lượng sinh viên: ");
        int n = int.Parse(Console.ReadLine() ?? "0");
        if (n <= 0) return;

        SinhVien33[] ds = new SinhVien33[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\n--- Nhập sinh viên thứ {i + 1} ---");
            ds[i] = new SinhVien33();
            ds[i].Input();
        }

        Console.WriteLine("\nDanh sách sinh viên ban đầu:");
        foreach (var sv in ds)
        {
            sv.Output();
        }

        // Sắp xếp tăng dần theo điểm trung bình bằng delegate
        MangDelegate.SortByDelegate(ds, (a, b) => a.Dtb.CompareTo(b.Dtb));
        Console.WriteLine("\nDanh sách sau khi sắp xếp theo ĐTB tăng dần (dùng delegate):");
        foreach (var sv in ds)
        {
            sv.Output();
        }

        // Sắp xếp theo họ tên bằng delegate
        MangDelegate.SortByDelegate(ds, (a, b) => string.Compare(a.HoTen, b.HoTen, StringComparison.OrdinalIgnoreCase));
        Console.WriteLine("\nDanh sách sau khi sắp xếp theo Họ tên (dùng delegate):");
        foreach (var sv in ds)
        {
            sv.Output();
        }
    }
}
