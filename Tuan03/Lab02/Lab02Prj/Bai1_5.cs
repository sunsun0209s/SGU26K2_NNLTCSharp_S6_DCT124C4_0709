namespace Lab02Prj;

public class DonThuc
{
    private double a;
    private int n;

    public double A
    {
        get { return a; }
        set { a = value; }
    }

    public int N
    {
        get { return n; }
        set { n = value >= 0 ? value : 0; }
    }

    // Hàm tạo mặc định
    public DonThuc()
    {
        a = 0;
        n = 0;
    }

    // Hàm tạo có tham số
    public DonThuc(double a, int n)
    {
        this.a = a;
        this.n = n >= 0 ? n : 0;
    }

    // Hàm tạo sao chép
    public DonThuc(DonThuc dt)
    {
        this.a = dt.a;
        this.n = dt.n;
    }

    // Nhập đơn thức
    public void Input()
    {
        Console.Write("Nhap he so a: ");
        a = double.Parse(Console.ReadLine() ?? "0");

        do
        {
            Console.Write("Nhap bac n (n >= 0): ");
            n = int.Parse(Console.ReadLine() ?? "0");
            if (n < 0)
            {
                Console.WriteLine("Bac phai la so nguyen khong am, vui long nhap lai!");
            }
        } while (n < 0);
    }

    // Xuất đơn thức
    public void Output()
    {
        Console.WriteLine(ToString());
    }

    public override string ToString()
    {
        if (a == 0) return "0";
        if (n == 0) return $"{a}";
        if (n == 1)
        {
            if (a == 1) return "x";
            if (a == -1) return "-x";
            return $"{a}x";
        }

        if (a == 1) return $"x^{n}";
        if (a == -1) return $"-x^{n}";
        return $"{a}x^{n}";
    }

    // Tính giá trị của đơn thức tại giá trị x cho trước
    public double TinhGiaTri(double x)
    {
        return a * Math.Pow(x, n);
    }

    // Tính đạo hàm của đơn thức: P'(x) = a * n * x^(n - 1)
    public DonThuc DaoHam()
    {
        if (n == 0)
        {
            return new DonThuc(0, 0);
        }
        return new DonThuc(a * n, n - 1);
    }
}

public class Bai1_5
{
    public static void Run()
    {
        DonThuc p = new DonThuc();
        p.Input();

        Console.Write("Don thuc vua nhap P(x) = ");
        p.Output();

        Console.Write("Nhap gia tri x: ");
        double x = double.Parse(Console.ReadLine() ?? "0");

        double giaTri = p.TinhGiaTri(x);
        Console.WriteLine($"Gia tri cua P({x}) = {giaTri}");

        DonThuc q = p.DaoHam();
        Console.Write("Dao ham Q(x) = P'(x) = ");
        q.Output();

        double giaTriDaoHam = q.TinhGiaTri(x);
        Console.WriteLine($"Gia tri dao ham tai x = {x}: Q({x}) = {giaTriDaoHam}");
    }
}
