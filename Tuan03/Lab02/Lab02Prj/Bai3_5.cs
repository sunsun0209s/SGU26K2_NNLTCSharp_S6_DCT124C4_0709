namespace Lab02Prj;

// Lớp cha trừu tượng đại diện cho nhân viên công ty
public abstract class NhanVienCT
{
    protected string maNV;
    protected string hoTen;

    public string MaNV
    {
        get { return maNV; }
        set { maNV = value; }
    }

    public string HoTen
    {
        get { return hoTen; }
        set { hoTen = value; }
    }

    public NhanVienCT()
    {
        maNV = "";
        hoTen = "";
    }

    public NhanVienCT(string maNV, string hoTen)
    {
        this.maNV = maNV;
        this.hoTen = hoTen;
    }

    // Phương thức trừu tượng tính lương (đa hình)
    public abstract double TinhLuong();

    public virtual void Input()
    {
        Console.Write("Nhập mã nhân viên: ");
        maNV = Console.ReadLine() ?? "";
        Console.Write("Nhập họ tên: ");
        hoTen = Console.ReadLine() ?? "";
    }

    public virtual void Output()
    {
        Console.Write($"Mã: {maNV,-8} | Họ tên: {hoTen,-20}");
    }
}

// Lớp nhân viên kinh doanh
public class NhanVienKinhDoanh : NhanVienCT
{
    private double luongCoBan;
    private int soHopDong;

    public double LuongCoBan
    {
        get { return luongCoBan; }
        set { luongCoBan = value >= 0 ? value : 0; }
    }

    public int SoHopDong
    {
        get { return soHopDong; }
        set { soHopDong = value >= 0 ? value : 0; }
    }

    public NhanVienKinhDoanh() : base()
    {
        luongCoBan = 0;
        soHopDong = 0;
    }

    public NhanVienKinhDoanh(string maNV, string hoTen, double luongCoBan, int soHopDong)
        : base(maNV, hoTen)
    {
        this.luongCoBan = luongCoBan;
        this.soHopDong = soHopDong;
    }

    public override double TinhLuong()
    {
        return luongCoBan + soHopDong * 500000;
    }

    public override void Input()
    {
        base.Input();
        Console.Write("Nhập lương cơ bản: ");
        luongCoBan = double.Parse(Console.ReadLine() ?? "0");
        Console.Write("Nhập số hợp đồng ký kết: ");
        soHopDong = int.Parse(Console.ReadLine() ?? "0");
    }

    public override void Output()
    {
        base.Output();
        Console.WriteLine($" | Bộ phận: Kinh doanh | Hợp đồng: {soHopDong,2} | Lương: {TinhLuong(),12:N0} VNĐ");
    }
}

// Lớp nhân viên sản xuất
public class NhanVienSanXuat : NhanVienCT
{
    private int soSanPham;

    public int SoSanPham
    {
        get { return soSanPham; }
        set { soSanPham = value >= 0 ? value : 0; }
    }

    public NhanVienSanXuat() : base()
    {
        soSanPham = 0;
    }

    public NhanVienSanXuat(string maNV, string hoTen, int soSanPham)
        : base(maNV, hoTen)
    {
        this.soSanPham = soSanPham;
    }

    public override double TinhLuong()
    {
        double luong = soSanPham * 1000;
        if (soSanPham > 3000)
        {
            luong += luong * 0.05; // Thưởng thêm 5% nếu trên 3000 sản phẩm
        }
        return luong;
    }

    public override void Input()
    {
        base.Input();
        Console.Write("Nhập số lượng sản phẩm: ");
        soSanPham = int.Parse(Console.ReadLine() ?? "0");
    }

    public override void Output()
    {
        base.Output();
        Console.WriteLine($" | Bộ phận: Sản xuất  | Sản phẩm: {soSanPham,4} | Lương: {TinhLuong(),12:N0} VNĐ");
    }
}

public class CongTy
{
    private List<NhanVienCT> ds = new List<NhanVienCT>();

    public void Input()
    {
        Console.Write("Nhập số lượng nhân viên toàn công ty: ");
        int n = int.Parse(Console.ReadLine() ?? "0");

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\n--- Nhập thông tin nhân viên thứ {i + 1} ---");
            Console.Write("Chọn loại nhân viên (1: Kinh doanh, 2: Sản xuất): ");
            int loai = int.Parse(Console.ReadLine() ?? "1");

            NhanVienCT nv;
            if (loai == 1)
            {
                nv = new NhanVienKinhDoanh();
            }
            else
            {
                nv = new NhanVienSanXuat();
            }

            nv.Input();
            ds.Add(nv);
        }
    }

    public void Output()
    {
        Console.WriteLine("\nDanh sách bảng lương nhân viên công ty:");
        foreach (var nv in ds)
        {
            nv.Output();
        }
    }

    public double TinhTongLuong()
    {
        double tong = 0;
        foreach (var nv in ds)
        {
            tong += nv.TinhLuong();
        }
        return tong;
    }
}

public class Bai3_5
{
    public static void Run()
    {
        CongTy cty = new CongTy();
        cty.Input();
        cty.Output();

        double tongLuong = cty.TinhTongLuong();
        Console.WriteLine($"\nTổng tiền lương toàn công ty: {tongLuong:N0} VNĐ");
    }
}
