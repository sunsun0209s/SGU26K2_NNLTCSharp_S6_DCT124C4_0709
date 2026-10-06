using System.Collections;

namespace Lab02Prj;

public class ArrayPoint
{
    private ArrayList ds;

    public int Count
    {
        get { return ds.Count; }
    }

    // Hàm tạo mặc định
    public ArrayPoint()
    {
        ds = new ArrayList();
    }

    // Hàm tạo với sức chứa ban đầu
    public ArrayPoint(int capacity)
    {
        ds = new ArrayList(capacity);
    }

    // Hàm tạo sao chép
    public ArrayPoint(ArrayPoint other)
    {
        ds = new ArrayList(other.ds);
    }

    // Indexer cho phép truy cập Point thứ i của ArrayList
    public Point this[int index]
    {
        get
        {
            if (index >= 0 && index < ds.Count)
            {
                return (Point)ds[index]!;
            }
            throw new IndexOutOfRangeException("Chi muc vuot qua pham vi!");
        }
        set
        {
            if (index >= 0 && index < ds.Count)
            {
                ds[index] = value;
            }
            else if (index == ds.Count)
            {
                ds.Add(value);
            }
            else
            {
                throw new IndexOutOfRangeException("Chi muc vuot qua pham vi!");
            }
        }
    }

    // Thêm một điểm vào mảng
    public void Add(Point p)
    {
        ds.Add(p);
    }

    // Nhập danh sách gồm n điểm
    public void Input(int n)
    {
        ds.Clear();
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Nhap diem thu {i + 1}:");
            Point p = new Point();
            p.Input();
            ds.Add(p);
        }
    }

    // Xuất danh sách điểm ra màn hình
    public void Output()
    {
        for (int i = 0; i < ds.Count; i++)
        {
            Console.WriteLine($"Diem [{i}]: {ds[i]}");
        }
    }
}

public class Bai2_1
{
    public static void Run()
    {
        Console.Write("Nhap so luong diem n: ");
        int n = int.Parse(Console.ReadLine() ?? "0");

        ArrayPoint arr = new ArrayPoint();
        arr.Input(n);

        Console.WriteLine("Danh sach cac diem vua nhap:");
        arr.Output();

        if (arr.Count > 0)
        {
            Console.WriteLine($"Thu nghiem Indexer - Diem dau tien arr[0]: {arr[0]}");
            Console.WriteLine($"Diem cuoi cung arr[{arr.Count - 1}]: {arr[arr.Count - 1]}");
        }
    }
}
