namespace Lab02Prj;

// Lớp trừu tượng quản lý thông tin chung của thí sinh
public abstract class ThiSinh
{
    protected string sbd;
    protected string hoTen;
    protected double bai1;
    protected double bai2;
    protected double bai3;

    public string Sbd
    {
        get { return sbd; }
        set { sbd = value; }
    }

    public string HoTen
    {
        get { return hoTen; }
        set { hoTen = value; }
    }

    public double Bai1
    {
        get { return bai1; }
        set { bai1 = value >= 0 && value <= 10 ? value : 0; }
    }

    public double Bai2
    {
        get { return bai2; }
        set { bai2 = value >= 0 && value <= 10 ? value : 0; }
    }

    public double Bai3
    {
        get { return bai3; }
        set { bai3 = value >= 0 && value <= 10 ? value : 0; }
    }

    public double TongDiem
    {
        get { return TinhTongDiem(); }
    }

    public ThiSinh()
    {
        sbd = "";
        hoTen = "";
        bai1 = 0;
        bai2 = 0;
        bai3 = 0;
    }

    public ThiSinh(string sbd, string hoTen, double bai1, double bai2, double bai3)
    {
        this.sbd = sbd;
        this.hoTen = hoTen;
        this.bai1 = bai1;
        this.bai2 = bai2;
        this.bai3 = bai3;
    }

    // Phương thức trừu tượng tính tổng điểm theo từng đối tượng thí sinh
    public abstract double TinhTongDiem();

    public virtual void Input()
    {
        Console.Write("Nhập số báo danh: ");
        sbd = Console.ReadLine() ?? "";
        Console.Write("Nhập họ tên: ");
        hoTen = Console.ReadLine() ?? "";
        Console.Write("Nhập điểm bài 1: ");
        bai1 = double.Parse(Console.ReadLine() ?? "0");
        Console.Write("Nhập điểm bài 2: ");
        bai2 = double.Parse(Console.ReadLine() ?? "0");
        Console.Write("Nhập điểm bài 3: ");
        bai3 = double.Parse(Console.ReadLine() ?? "0");
    }

    public virtual void Output()
    {
        Console.Write($"SBD: {sbd,-8} | Họ tên: {hoTen,-20} | B1: {bai1,4:N1} | B2: {bai2,4:N1} | B3: {bai3,4:N1}");
    }
}

// Đối tượng thí sinh Chuyên
public class ThiSinhChuyen : ThiSinh
{
    private double tiengAnh;

    public double TiengAnh
    {
        get { return tiengAnh; }
        set { tiengAnh = value >= 0 && value <= 10 ? value : 0; }
    }

    public ThiSinhChuyen() : base()
    {
        tiengAnh = 0;
    }

    public ThiSinhChuyen(string sbd, string hoTen, double bai1, double bai2, double bai3, double tiengAnh)
        : base(sbd, hoTen, bai1, bai2, bai3)
    {
        this.tiengAnh = tiengAnh;
    }

    public override double TinhTongDiem()
    {
        double diemThuong = 0;
        if (tiengAnh >= 9 && tiengAnh <= 10)
        {
            diemThuong = 2;
        }
        else if (tiengAnh >= 7 && tiengAnh <= 8)
        {
            diemThuong = 1;
        }

        return bai1 + bai2 + bai3 + diemThuong;
    }

    public override void Input()
    {
        base.Input();
        Console.Write("Nhập điểm Tiếng Anh: ");
        tiengAnh = double.Parse(Console.ReadLine() ?? "0");
    }

    public override void Output()
    {
        base.Output();
        Console.WriteLine($" | Tiếng Anh: {tiengAnh,4:N1} | Khối: Chuyên   | Tổng điểm: {TongDiem,5:N1}");
    }
}

// Đối tượng thí sinh Siêu cúp
public class ThiSinhSieuCup : ThiSinh
{
    private double csdl;

    public double Csdl
    {
        get { return csdl; }
        set { csdl = value >= 0 && value <= 10 ? value : 0; }
    }

    public ThiSinhSieuCup() : base()
    {
        csdl = 0;
    }

    public ThiSinhSieuCup(string sbd, string hoTen, double bai1, double bai2, double bai3, double csdl)
        : base(sbd, hoTen, bai1, bai2, bai3)
    {
        this.csdl = csdl;
    }

    public override double TinhTongDiem()
    {
        return bai1 + bai2 + bai3 + csdl;
    }

    public override void Input()
    {
        base.Input();
        Console.Write("Nhập điểm CSDL: ");
        csdl = double.Parse(Console.ReadLine() ?? "0");
    }

    public override void Output()
    {
        base.Output();
        Console.WriteLine($" | CSDL: {csdl,9:N1} | Khối: Siêu cúp | Tổng điểm: {TongDiem,5:N1}");
    }
}

public class CuocThi
{
    private List<ThiSinh> ds = new List<ThiSinh>();

    public void Input()
    {
        Console.Write("Nhập số lượng thí sinh tham gia cuộc thi: ");
        int n = int.Parse(Console.ReadLine() ?? "0");

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\n--- Nhập thông tin thí sinh thứ {i + 1} ---");
            Console.Write("Chọn đối tượng thí sinh (1: Chuyên, 2: Siêu cúp): ");
            int loai = int.Parse(Console.ReadLine() ?? "1");

            ThiSinh ts;
            if (loai == 1)
            {
                ts = new ThiSinhChuyen();
            }
            else
            {
                ts = new ThiSinhSieuCup();
            }

            ts.Input();
            ds.Add(ts);
        }
    }

    public void Output()
    {
        Console.WriteLine("\nDanh sách kết quả thi của các thí sinh:");
        foreach (var ts in ds)
        {
            ts.Output();
        }
    }
}

public class Bai3_6
{
    public static void Run()
    {
        CuocThi cuocThi = new CuocThi();
        cuocThi.Input();
        cuocThi.Output();
    }
}
