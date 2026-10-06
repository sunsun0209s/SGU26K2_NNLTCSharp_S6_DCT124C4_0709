namespace Lab02Prj;

public class Point
{
    private double x;
    private double y;

    public double X
    {
        get { return x; }
        set { x = value; }
    }

    public double Y
    {
        get { return y; }
        set { y = value; }
    }

    public Point()
    {
        x = 0;
        y = 0;
    }

    public Point(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    public Point(Point p)
    {
        x = p.x;
        y = p.y;
    }

    public void Input()
    {
        Console.Write("Nhap x: ");
        x = double.Parse(Console.ReadLine() ?? "0");

        Console.Write("Nhap y: ");
        y = double.Parse(Console.ReadLine() ?? "0");
    }

    public void Output()
    {
        Console.WriteLine($"({x}, {y})");
    }

    public override string ToString()
    {
        return $"({x}, {y})";
    }

    public static Point operator +(Point a, Point b)
    {
        return new Point(a.x + b.x, a.y + b.y);
    }

    public static Point operator -(Point a, Point b)
    {
        return new Point(a.x - b.x, a.y - b.y);
    }

    public static Point operator -(Point a)
    {
        return new Point(-a.x, -a.y);
    }

    // Khoảng cách theo phương thức thành viên
    public double KhoangCach(Point b)
    {
        return Math.Sqrt(Math.Pow(b.x - this.x, 2) + Math.Pow(b.y - this.y, 2));
    }

    // Khoảng cách theo phương thức tĩnh
    public static double KhoangCach(Point a, Point b)
    {
        return Math.Sqrt(Math.Pow(b.x - a.x, 2) + Math.Pow(b.y - a.y, 2));
    }

    // Trung điểm theo phương thức thành viên
    public Point TrungDiem(Point b)
    {
        return new Point((this.x + b.x) / 2.0, (this.y + b.y) / 2.0);
    }

    // Trung điểm theo phương thức tĩnh
    public static Point TrungDiem(Point a, Point b)
    {
        return new Point((a.x + b.x) / 2.0, (a.y + b.y) / 2.0);
    }
}

public class Bai1_2
{
    public static void Run()
    {
        Console.WriteLine("Nhap toa do diem A:");
        Point A = new Point();
        A.Input();

        Console.WriteLine("Nhap toa do diem B:");
        Point B = new Point();
        B.Input();

        Console.WriteLine($"Diem A: {A}");
        Console.WriteLine($"Diem B: {B}");

        Point tong = A + B;
        Point hieu = A - B;
        Point amA = -A;
        Console.WriteLine($"A + B = {tong}");
        Console.WriteLine($"A - B = {hieu}");
        Console.WriteLine($"Lay am cua A (-A) = {amA}");

        Console.WriteLine("Khoang cach giua 2 diem A va B:");
        Console.WriteLine($"Phuong thuc thanh vien: {A.KhoangCach(B)}");
        Console.WriteLine($"Phuong thuc tinh: {Point.KhoangCach(A, B)}");

        Console.WriteLine("Trung diem I cua 2 diem A va B:");
        Console.WriteLine($"Phuong thuc thanh vien: {A.TrungDiem(B)}");
        Console.WriteLine($"Phuong thuc tinh: {Point.TrungDiem(A, B)}");
    }
}
