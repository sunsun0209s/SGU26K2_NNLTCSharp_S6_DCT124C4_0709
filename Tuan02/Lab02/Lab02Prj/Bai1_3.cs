namespace Lab02Prj;

public class Person
{
    private string id;
    private string name;
    private int yob;
    private int yod;

    public string Id
    {
        get { return id; }
        set { id = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Yob
    {
        get { return yob; }
        set { yob = value; }
    }

    public int Yod
    {
        get { return yod; }
        set { yod = value; }
    }

    // Hàm tạo mặc định
    public Person()
    {
        id = "";
        name = "";
        yob = DateTime.Now.Year;
        yod = 0;
    }

    // Hàm tạo có tham số
    public Person(string id, string name, int yob, int yod)
    {
        this.id = id;
        this.name = name;
        this.yob = yob;
        this.yod = yod;
    }

    // Hàm tạo sao chép
    public Person(Person p)
    {
        id = p.id;
        name = p.name;
        yob = p.yob;
        yod = p.yod;
    }

    // Kiểm tra còn sống hay không
    public bool IsLiving()
    {
        return yod == 0;
    }

    // Nhập thông tin
    public void Input()
    {
        Console.Write("Nhap ma dinh danh (ID): ");
        id = Console.ReadLine() ?? "";

        Console.Write("Nhap ho ten: ");
        name = Console.ReadLine() ?? "";

        Console.Write("Nhap nam sinh: ");
        yob = int.Parse(Console.ReadLine() ?? "0");

        Console.Write("Nhap nam mat (nhap 0 neu con song): ");
        yod = int.Parse(Console.ReadLine() ?? "0");
    }

    // Xuất thông tin
    public void Output()
    {
        Console.WriteLine($"ID: {id}");
        Console.WriteLine($"Ho ten: {name}");
        Console.WriteLine($"Nam sinh: {yob}");
        Console.WriteLine(IsLiving() ? "Tinh trang: Con song" : $"Tinh trang: Da mat nam {yod}");
    }

    public override string ToString()
    {
        string tinhTrang = IsLiving() ? "Con song" : $"Da mat ({yod})";
        return $"{id} - {name} - Sinh: {yob} - {tinhTrang}";
    }
}

public class Bai1_3
{
    public static void Run()
    {
        Person p = new Person();
        p.Input();
        Console.WriteLine("Thong tin vua nhap:");
        p.Output();
    }
}
