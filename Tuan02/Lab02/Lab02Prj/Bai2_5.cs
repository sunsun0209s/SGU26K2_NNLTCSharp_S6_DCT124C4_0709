namespace Lab02Prj;

public class NhanVien
{
    private string hoTen;
    private double mucLuong;
    private int soNgayVang;

    public string HoTen
    {
        get { return hoTen; }
        set { hoTen = value; }
    }

    public double MucLuong
    {
        get { return mucLuong; }
        set { mucLuong = value >= 0 ? value : 0; }
    }

    public int SoNgayVang
    {
        get { return soNgayVang; }
        set { soNgayVang = value >= 0 ? value : 0; }
    }

    // Hàm tạo mặc định
    public NhanVien()
    {
        hoTen = "";
        mucLuong = 0;
        soNgayVang = 0;
    }

    // Hàm tạo có tham số
    public NhanVien(string hoTen, double mucLuong, int soNgayVang)
    {
        this.hoTen = hoTen;
        this.mucLuong = mucLuong >= 0 ? mucLuong : 0;
        this.soNgayVang = soNgayVang >= 0 ? soNgayVang : 0;
    }

    // Hàm tạo sao chép
    public NhanVien(NhanVien other)
    {
        this.hoTen = other.hoTen;
        this.mucLuong = other.mucLuong;
        this.soNgayVang = other.soNgayVang;
    }

    // Tính lương thực lĩnh: mỗi ngày vắng trừ 100.000 VNĐ
    public double TinhLuong()
    {
        double luong = mucLuong - soNgayVang * 100000;
        return luong > 0 ? luong : 0;
    }

    // Nhập thông tin nhân viên
    public void Input()
    {
        Console.Write("Nhập họ tên: ");
        hoTen = Console.ReadLine() ?? "";
        Console.Write("Nhập mức lương: ");
        mucLuong = double.Parse(Console.ReadLine() ?? "0");
        Console.Write("Nhập số ngày vắng: ");
        soNgayVang = int.Parse(Console.ReadLine() ?? "0");
    }

    // Xuất thông tin nhân viên
    public void Output()
    {
        Console.WriteLine($"Họ tên: {hoTen,-20} | Mức lương: {mucLuong,12:N0} VNĐ | Vắng: {soNgayVang,2} ngày | Thực lĩnh: {TinhLuong(),12:N0} VNĐ");
    }

    public override string ToString()
    {
        return $"Họ tên: {hoTen} | Mức lương: {mucLuong:N0} VNĐ | Vắng: {soNgayVang} ngày | Thực lĩnh: {TinhLuong():N0} VNĐ";
    }
}

public class PhongBan
{
    private string tenPhongBan;
    private List<NhanVien> ds;

    public string TenPhongBan
    {
        get { return tenPhongBan; }
        set { tenPhongBan = value; }
    }

    public int SoLuongNhanVien
    {
        get { return ds.Count; }
    }

    // Hàm tạo mặc định
    public PhongBan()
    {
        tenPhongBan = "Phòng Kỹ Thuật";
        ds = new List<NhanVien>();
    }

    // Hàm tạo có tham số tên phòng ban
    public PhongBan(string tenPhongBan)
    {
        this.tenPhongBan = tenPhongBan;
        ds = new List<NhanVien>();
    }

    // Hàm tạo sao chép
    public PhongBan(PhongBan other)
    {
        this.tenPhongBan = other.tenPhongBan;
        ds = new List<NhanVien>();
        for (int i = 0; i < other.ds.Count; i++)
        {
            ds.Add(new NhanVien(other.ds[i]));
        }
    }

    // Indexer truy cập nhân viên thứ i
    public NhanVien this[int index]
    {
        get
        {
            if (index >= 0 && index < ds.Count)
            {
                return ds[index];
            }
            throw new IndexOutOfRangeException("Chỉ mục vượt quá phạm vi!");
        }
        set
        {
            if (index >= 0 && index < ds.Count)
            {
                ds[index] = value;
            }
            else
            {
                throw new IndexOutOfRangeException("Chỉ mục vượt quá phạm vi!");
            }
        }
    }

    // Thêm nhân viên
    public void Add(NhanVien nv)
    {
        ds.Add(nv);
    }

    // Nhập danh sách nhân viên phòng ban
    public void Input()
    {
        Console.Write("Nhập tên phòng ban: ");
        string? ten = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(ten)) tenPhongBan = ten;

        Console.Write("Nhập số lượng nhân viên n: ");
        int n = int.Parse(Console.ReadLine() ?? "0");

        ds.Clear();
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\n--- Nhập thông tin nhân viên thứ {i + 1} ---");
            NhanVien nv = new NhanVien();
            nv.Input();
            ds.Add(nv);
        }
    }

    // Xuất danh sách nhân viên phòng ban
    public void Output()
    {
        Console.WriteLine($"\nDanh sách nhân viên phòng ban: {tenPhongBan}");
        if (ds.Count == 0)
        {
            Console.WriteLine("Danh sách rỗng!");
            return;
        }

        for (int i = 0; i < ds.Count; i++)
        {
            Console.Write($"{i + 1,2}. ");
            ds[i].Output();
        }
    }

    // Tính tổng lương của cả phòng ban
    public double TinhTongLuong()
    {
        double tong = 0;
        for (int i = 0; i < ds.Count; i++)
        {
            tong += ds[i].TinhLuong();
        }
        return tong;
    }
}

public class Bai2_5
{
    public static void Run()
    {
        PhongBan pb = new PhongBan();
        pb.Input();

        pb.Output();

        double tongLuong = pb.TinhTongLuong();
        Console.WriteLine($"\nTổng lương thực lĩnh toàn bộ phòng ban {pb.TenPhongBan}: {tongLuong:N0} VNĐ");

        if (pb.SoLuongNhanVien > 0)
        {
            Console.WriteLine($"Nhân viên đầu tiên (chỉ mục 0): {pb[0].HoTen} - Thực lĩnh: {pb[0].TinhLuong():N0} VNĐ");
        }
    }
}
