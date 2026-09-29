namespace Lab02Prj;

public class PersonList
{
    private List<Person> ds;

    public int Count
    {
        get { return ds.Count; }
    }

    // Hàm tạo mặc định
    public PersonList()
    {
        ds = new List<Person>();
    }

    // Hàm tạo sao chép
    public PersonList(PersonList other)
    {
        ds = new List<Person>();
        for (int i = 0; i < other.ds.Count; i++)
        {
            ds.Add(new Person(other.ds[i]));
        }
    }

    // Indexer truy cập phần tử thứ index
    public Person this[int index]
    {
        get { return ds[index]; }
        set { ds[index] = value; }
    }

    // Thêm một Person vào danh sách
    public void Add(Person x)
    {
        ds.Add(x);
    }

    // Nhập danh sách nhân khẩu
    public void Input()
    {
        Console.Write("Nhap so luong nguoi can quan ly: ");
        int n = int.Parse(Console.ReadLine() ?? "0");

        ds.Clear();
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Nhap thong tin nguoi thu {i + 1}:");
            Person p = new Person();
            p.Input();
            ds.Add(p);
        }
    }

    // Xuất danh sách nhân khẩu
    public void Output()
    {
        if (ds.Count == 0)
        {
            Console.WriteLine("Danh sach trong!");
            return;
        }

        for (int i = 0; i < ds.Count; i++)
        {
            Console.WriteLine($"Nguoi thu {i + 1}: {ds[i]}");
        }
    }

    // Trả về một PersonList gom nhung nguoi con song (yod == 0)
    public PersonList LivingPeople()
    {
        PersonList ketQua = new PersonList();
        for (int i = 0; i < ds.Count; i++)
        {
            if (ds[i].IsLiving())
            {
                ketQua.Add(ds[i]);
            }
        }
        return ketQua;
    }
}

public class Bai2_2
{
    public static void Run()
    {
        PersonList quanLy = new PersonList();
        quanLy.Input();

        Console.WriteLine("Toan bo danh sach nhan khau:");
        quanLy.Output();

        PersonList danhSachConSong = quanLy.LivingPeople();
        Console.WriteLine("Danh sach nhung nguoi con song:");
        danhSachConSong.Output();
    }
}
