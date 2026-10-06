namespace Lab02Prj;

public class DaySo
{
    private int[] a;

    public int Length
    {
        get { return a.Length; }
    }

    // Hàm tạo mặc định
    public DaySo()
    {
        a = new int[0];
    }

    // Hàm tạo với số lượng phần tử
    public DaySo(int n)
    {
        a = new int[n >= 0 ? n : 0];
    }

    // Hàm tạo từ một mảng có sẵn
    public DaySo(int[] arr)
    {
        a = new int[arr.Length];
        Array.Copy(arr, a, arr.Length);
    }

    // Hàm tạo sao chép
    public DaySo(DaySo other)
    {
        a = new int[other.a.Length];
        Array.Copy(other.a, a, other.a.Length);
    }

    // Indexer truy cập phần tử thứ i trong dãy
    public int this[int i]
    {
        get
        {
            if (i >= 0 && i < a.Length)
            {
                return a[i];
            }
            throw new IndexOutOfRangeException("Chi muc vuot qua pham vi!");
        }
        set
        {
            if (i >= 0 && i < a.Length)
            {
                a[i] = value;
            }
            else
            {
                throw new IndexOutOfRangeException("Chi muc vuot qua pham vi!");
            }
        }
    }

    // Nhập dãy số
    public void Input()
    {
        Console.Write("Nhap so luong phan tu n: ");
        int n = int.Parse(Console.ReadLine() ?? "0");
        if (n < 0) n = 0;

        a = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhap a[{i}] = ");
            a[i] = int.Parse(Console.ReadLine() ?? "0");
        }
    }

    // Xuất dãy số
    public void Output()
    {
        if (a.Length == 0)
        {
            Console.WriteLine("Day so trong!");
            return;
        }

        for (int i = 0; i < a.Length; i++)
        {
            Console.Write(a[i] + " ");
        }
        Console.WriteLine();
    }

    public override string ToString()
    {
        return string.Join(" ", a);
    }

    // Tìm và trả về dãy chứa các số chẵn
    public DaySo TimSoChan()
    {
        List<int> dsChan = new List<int>();
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] % 2 == 0)
            {
                dsChan.Add(a[i]);
            }
        }
        return new DaySo(dsChan.ToArray());
    }
}

public class Bai2_3
{
    public static void Run()
    {
        DaySo ds = new DaySo();
        ds.Input();

        Console.Write("Day so vua nhap: ");
        ds.Output();

        if (ds.Length > 0)
        {
            Console.WriteLine($"Thu nghiem Indexer - Phan tu dau tien ds[0] = {ds[0]}");
            Console.WriteLine($"Phan tu cuoi cung ds[{ds.Length - 1}] = {ds[ds.Length - 1]}");
        }

        DaySo cacSoChan = ds.TimSoChan();
        Console.Write("Cac so chan trong day: ");
        cacSoChan.Output();
    }
}
