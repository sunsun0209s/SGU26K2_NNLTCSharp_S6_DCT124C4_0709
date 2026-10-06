namespace Lab02Prj;

public class Mang2Chieu
{
    private int[,] a;
    private int n;
    private int m;

    public int Rows
    {
        get { return n; }
    }

    public int Cols
    {
        get { return m; }
    }

    // Hàm tạo mặc định
    public Mang2Chieu()
    {
        n = 0;
        m = 0;
        a = new int[0, 0];
    }

    // Hàm tạo với kích thước n x m
    public Mang2Chieu(int n, int m)
    {
        this.n = n >= 0 ? n : 0;
        this.m = m >= 0 ? m : 0;
        a = new int[this.n, this.m];
    }

    // Hàm tạo từ một mảng 2 chiều có sẵn
    public Mang2Chieu(int[,] arr)
    {
        n = arr.GetLength(0);
        m = arr.GetLength(1);
        a = new int[n, m];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                a[i, j] = arr[i, j];
            }
        }
    }

    // Hàm tạo sao chép
    public Mang2Chieu(Mang2Chieu other)
    {
        n = other.n;
        m = other.m;
        a = new int[n, m];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                a[i, j] = other.a[i, j];
            }
        }
    }

    // Indexer 2 chỉ mục truy cập phần tử tại vị trí (i, j)
    public int this[int i, int j]
    {
        get
        {
            if (i >= 0 && i < n && j >= 0 && j < m)
            {
                return a[i, j];
            }
            throw new IndexOutOfRangeException("Chi muc vuot qua pham vi!");
        }
        set
        {
            if (i >= 0 && i < n && j >= 0 && j < m)
            {
                a[i, j] = value;
            }
            else
            {
                throw new IndexOutOfRangeException("Chi muc vuot qua pham vi!");
            }
        }
    }

    // Nhập mảng 2 chiều
    public void Input()
    {
        Console.Write("Nhap so dong n: ");
        n = int.Parse(Console.ReadLine() ?? "0");
        if (n < 0) n = 0;

        Console.Write("Nhap so cot m: ");
        m = int.Parse(Console.ReadLine() ?? "0");
        if (m < 0) m = 0;

        a = new int[n, m];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write($"Nhap a[{i},{j}] = ");
                a[i, j] = int.Parse(Console.ReadLine() ?? "0");
            }
        }
    }

    // Xuất mảng 2 chiều
    public void Output()
    {
        if (n == 0 || m == 0)
        {
            Console.WriteLine("Mang 2 chieu trong!");
            return;
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(a[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    // Hàm phụ kiểm tra số nguyên tố
    private static bool KiemTraNguyenTo(int k)
    {
        if (k < 2) return false;
        for (int i = 2; i * i <= k; i++)
        {
            if (k % i == 0) return false;
        }
        return true;
    }

    // Tìm và trả về mảng các số nguyên tố trong ma trận
    public int[] TimSoNguyenTo()
    {
        List<int> ds = new List<int>();
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (KiemTraNguyenTo(a[i, j]))
                {
                    ds.Add(a[i, j]);
                }
            }
        }
        return ds.ToArray();
    }
}

public class Bai2_4
{
    public static void Run()
    {
        Mang2Chieu m = new Mang2Chieu();
        m.Input();

        Console.WriteLine("Mang 2 chieu vua nhap:");
        m.Output();

        if (m.Rows > 0 && m.Cols > 0)
        {
            Console.WriteLine($"Thu nghiem Indexer - Phan tu goc m[0,0] = {m[0, 0]}");
        }

        int[] nt = m.TimSoNguyenTo();
        Console.Write("Cac so nguyen to co trong mang: ");
        if (nt.Length == 0)
        {
            Console.WriteLine("Khong co so nguyen to nao!");
        }
        else
        {
            for (int i = 0; i < nt.Length; i++)
            {
                Console.Write(nt[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
