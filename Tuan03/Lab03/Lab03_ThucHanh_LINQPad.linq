<Query Kind="Program" />

void Main()
{
    "=== 1. THỬ NGHIỆM BÀI 2.1: MẢNG SỐ NGUYÊN ===".Dump();
    int[] mangSo = { 50, 42, 16, 3, 9, 8, 12, 7, 24, 0 };
    mangSo.Dump("Mảng số ban đầu");
    
    // a. Chia hết cho 4 và 3
    mangSo.Where(n => n % 4 == 0 && n % 3 == 0).Dump("a. Chia hết cho 4 và 3");
    
    // b. Nhỏ hơn hoặc bằng 3
    mangSo.Where(n => n <= 3).Dump("b. Nhỏ hơn hoặc bằng 3");
    
    // c. Chẵn chia đôi, lẻ giữ nguyên
    mangSo.Select(n => n % 2 == 0 ? n / 2 : n).Dump("c. Chẵn chia đôi, lẻ giữ nguyên");


    "=== 2. THỬ NGHIỆM BÀI 3.1: THỐNG KÊ VÀ PHÂN NHÓM ===".Dump();
    int[] mangSoThongKe = { 50, 42, 12, 3, 9, 8, 1, 50, 3, 42, 85 };
    
    new {
        TongSo = mangSoThongKe.Count(),
        SoChan = mangSoThongKe.Count(n => n % 2 == 0),
        SoLe = mangSoThongKe.Count(n => n % 2 != 0),
        TongGiaTri = mangSoThongKe.Sum(),
        Max = mangSoThongKe.Max(),
        Min = mangSoThongKe.Min(),
        SoLuongPhanBiet = mangSoThongKe.Distinct().Count()
    }.Dump("Thống kê mảng số");

    // Phân nhóm theo số dư khi chia cho 5
    // Trong LINQPad, .Dump() sẽ hiển thị từng nhóm có thể click mở rộng xem phần tử con!
    mangSoThongKe.GroupBy(n => n % 5)
                 .OrderBy(g => g.Key)
                 .Select(g => new { SoDu = g.Key, SoLuong = g.Count(), CacPhanTu = g.ToList() })
                 .Dump("Phân nhóm theo số dư chia cho 5");


    "=== 3. THỬ NGHIỆM BÀI 4.1: XÂY DỰNG LỚP MONHOC VÀ DS_MON ===".Dump();
    var dsMon = DuLieu.DS_Mon();
    dsMon.Dump("Danh sách môn học (DS_Mon)");

    "=== 4. THỬ NGHIỆM BÀI 6.1: XÂY DỰNG LỚP HE VÀ DS_HE ===".Dump();
    var dsHe = DuLieu.DS_He();
    dsHe.Dump("Danh sách các hệ đào tạo (DS_He)");

    "=== 5. THỬ NGHIỆM BÀI 6.2: JOIN VÀ GROUPJOIN HAI NGUỒN DỮ LIỆU ===".Dump();

    // Inner Join
    (from h in dsHe
     join m in dsMon on h.MaHe equals m.He
     select new { h.TenHe, m.MaMon, m.TenMon, m.SoTiet })
     .Dump("Inner Join: Môn học và Hệ đào tạo");

    // Left Outer Join: Hiển thị cả hệ chưa có môn nào
    (from h in dsHe
     join m in dsMon on h.MaHe equals m.He into g
     from subM in g.DefaultIfEmpty()
     select new {
         h.TenHe,
         MaMon = subM != null ? subM.MaMon : "(Chưa có môn)",
         TenMon = subM != null ? subM.TenMon : "(Chưa có môn)"
     }).Dump("Left Outer Join: Hệ chưa có môn học");
}

public class MonHoc
{
    public string MaMon { get; set; } = "";
    public string TenMon { get; set; } = "";
    public string He { get; set; } = "";
    public byte SoTiet { get; set; }
}

public class He
{
    public string MaHe { get; set; } = "";
    public string TenHe { get; set; } = "";
}

public static class DuLieu
{
    public static List<MonHoc> DS_Mon()
    {
        return new List<MonHoc>
        {
            new MonHoc { MaMon = "HP2_1", TenMon = "Nền tảng C#", He = "KTV", SoTiet = 64 },
            new MonHoc { MaMon = "HP2_2", TenMon = "Công nghệ ADO.NET", He = "KTV", SoTiet = 64 },
            new MonHoc { MaMon = "HP3_1", TenMon = "Lập trình Windows Forms", He = "KTV", SoTiet = 64 },
            new MonHoc { MaMon = "HP3_2", TenMon = "Xây dựng ứng dụng Windows Forms", He = "KTV", SoTiet = 64 },
            new MonHoc { MaMon = "HP4_1", TenMon = "Lập trình Web với HTML, CSS và JavaScript", He = "KTV", SoTiet = 64 },
            new MonHoc { MaMon = "HP4_2", TenMon = "Xây dựng ứng dụng Web với ASP.NET", He = "KTV", SoTiet = 64 },
            new MonHoc { MaMon = "HP5_1", TenMon = "Lập trình CSDL SQL Server căn bản", He = "KTV", SoTiet = 64 },
            new MonHoc { MaMon = "HP5_2", TenMon = "Lập trình CSDL SQL Server nâng cao", He = "KTV", SoTiet = 64 },
            new MonHoc { MaMon = "JLCB", TenMon = "Joomla cơ bản", He = "CD", SoTiet = 72 },
            new MonHoc { MaMon = "LINQ", TenMon = "Language-Integrated Query", He = "CD", SoTiet = 64 },
            new MonHoc { MaMon = "DAWEB", TenMon = "Đồ án thực tế Web với ASP.NET", He = "CD", SoTiet = 40 },
            new MonHoc { MaMon = "DAWIN", TenMon = "Đồ án thực tế Windows Forms", He = "CD", SoTiet = 40 },
            new MonHoc { MaMon = "CC++", TenMon = "Lập trình hướng đối tượng với C/C++", He = "CD", SoTiet = 128 },
            new MonHoc { MaMon = "JQUE", TenMon = "JQuery", He = "CD", SoTiet = 22 },
            new MonHoc { MaMon = "XML", TenMon = "Công nghệ XML", He = "CD", SoTiet = 32 },
            new MonHoc { MaMon = "CRYS", TenMon = "Crystal Report trong Visual Studio", He = "CD", SoTiet = 32 },
            new MonHoc { MaMon = "BWEB", TenMon = "HTML, CSS và JavaScript", He = "CD", SoTiet = 32 },
            new MonHoc { MaMon = "XYZ", TenMon = "Chưa đặt tên môn", He = "", SoTiet = 0 }
        };
    }

    public static List<He> DS_He()
    {
        return new List<He>
        {
            new He { MaHe = "KTV", TenHe = "Kỹ thuật viên" },
            new He { MaHe = "CD", TenHe = "Chuyên đề" },
            new He { MaHe = "QT", TenHe = "Chứng chỉ quốc tế" }
        };
    }
}
