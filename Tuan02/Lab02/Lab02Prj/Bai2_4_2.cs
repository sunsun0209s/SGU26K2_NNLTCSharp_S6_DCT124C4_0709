namespace Lab02Prj;

public class DayPhanSo
{
    private PhanSo[] a;

    public int Length
    {
        get { return a.Length; }
    }

    // Hàm tạo mặc định
    public DayPhanSo()
    {
        a = new PhanSo[0];
    }

    // Hàm tạo với số lượng n phân số
    public DayPhanSo(int n)
    {
        int size = n >= 0 ? n : 0;
        a = new PhanSo[size];
        for (int i = 0; i < size; i++)
        {
            a[i] = new PhanSo(0, 1);
        }
    }

    // Hàm tạo từ một mảng phân số có sẵn
    public DayPhanSo(PhanSo[] arr)
    {
        a = new PhanSo[arr.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            a[i] = new PhanSo(arr[i]);
        }
    }

    // Hàm tạo sao chép
    public DayPhanSo(DayPhanSo other)
    {
        a = new PhanSo[other.a.Length];
        for (int i = 0; i < other.a.Length; i++)
        {
            a[i] = new PhanSo(other.a[i]);
        }
    }

    // Indexer truy cập hoặc gán phân số tại vị trí thứ i
    public PhanSo this[int i]
    {
        get
        {
            if (i >= 0 && i < a.Length)
            {
                return a[i];
            }
            throw new IndexOutOfRangeException("Chỉ mục vượt quá phạm vi!");
        }
        set
        {
            if (i >= 0 && i < a.Length)
            {
                a[i] = value;
            }
            else
            {
                throw new IndexOutOfRangeException("Chỉ mục vượt quá phạm vi!");
            }
        }
    }

    // Nhập dãy phân số
    public void Input()
    {
        Console.Write("Nhập số lượng phân số n: ");
        int n = int.Parse(Console.ReadLine() ?? "0");
        if (n < 0) n = 0;

        a = new PhanSo[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"--- Nhập phân số thứ {i + 1} ---");
            a[i] = new PhanSo();
            a[i].Input();
        }
    }

    // Xuất dãy phân số
    public void Output()
    {
        if (a.Length == 0)
        {
            Console.WriteLine("Dãy phân số rỗng!");
            return;
        }

        Console.Write("Dãy phân số: ");
        for (int i = 0; i < a.Length; i++)
        {
            Console.Write(a[i].ToString());
            if (i < a.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
    }

    public override string ToString()
    {
        if (a.Length == 0) return "[]";
        return string.Join(", ", a.Select(ps => ps.ToString()));
    }

    // Tính tổng của n phân số trong dãy
    public PhanSo TinhTong()
    {
        PhanSo tong = new PhanSo(0, 1);
        for (int i = 0; i < a.Length; i++)
        {
            tong = tong + a[i];
        }
        return tong;
    }
}

public class Bai2_4_2
{
    public static void Run()
    {
        DayPhanSo dayPS = new DayPhanSo();
        dayPS.Input();

        Console.WriteLine("\n--- Kết quả xuất dãy phân số ---");
        dayPS.Output();

        // Tính tổng n phân số
        PhanSo tong = dayPS.TinhTong();
        Console.WriteLine($"\nTổng của {dayPS.Length} phân số trong dãy là: {tong}");

        // Kiểm tra Indexer
        if (dayPS.Length > 0)
        {
            Console.WriteLine("\n--- Kiểm tra Indexer ---");
            Console.WriteLine($"Phân số đầu tiên (chỉ mục 0) lấy qua Indexer: {dayPS[0]}");
        }
    }
}
