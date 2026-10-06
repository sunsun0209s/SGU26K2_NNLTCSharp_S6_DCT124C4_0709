namespace BaiThucHanhLINQ;

public static class Bai5_TruyVanMonHoc
{
    public static void Bai41()
    {
        Console.WriteLine("\n--- BÀI 4.1: XÂY DỰNG LỚP MONHOC VÀ NGUỒN DỮ LIỆU DS_MON ---");
        var dsMon = DuLieu.DS_Mon();
        Console.WriteLine($"Danh sách {dsMon.Count} môn học khởi tạo ban đầu (List<MonHoc>):");
        foreach (var m in dsMon)
        {
            Console.WriteLine(" - " + m);
        }
    }

    public static void Bai51()
    {
        Console.WriteLine("\n--- BÀI 5.1: TRUY VẤN CƠ BẢN TRÊN LIST<MONHOC> ---");
        var dsMon = DuLieu.DS_Mon();

        // a. Liệt kê tên các môn học bắt đầu bằng "Lập trình"
        Console.WriteLine("\na. Tên các môn học bắt đầu bằng 'Lập trình':");
        var cauA = dsMon.Where(m => m.TenMon.StartsWith("Lập trình")).Select(m => m.TenMon);
        foreach (var ten in cauA) Console.WriteLine(" - " + ten);

        // b. Liệt kê các môn thuộc hệ "CD", sắp xếp số tiết giảm dần rồi mã môn tăng dần
        Console.WriteLine("\nb. Môn thuộc hệ 'CD' (số tiết giảm dần, mã môn tăng dần):");
        var cauB = dsMon.Where(m => m.He == "CD")
                        .OrderByDescending(m => m.SoTiet)
                        .ThenBy(m => m.MaMon);
        foreach (var m in cauB) Console.WriteLine(" - " + m);

        // c. Liệt kê các môn có tên chứa từ "web", chỉ lấy Tên môn và Hệ
        Console.WriteLine("\nc. Môn có tên chứa từ 'web' (chỉ lấy Tên môn và Hệ):");
        var cauC = dsMon.Where(m => m.TenMon.Contains("Web", StringComparison.OrdinalIgnoreCase))
                        .Select(m => new { m.TenMon, m.He });
        foreach (var item in cauC) Console.WriteLine($" - {item.TenMon,-42} | Hệ: {item.He}");

        // d. Liệt kê các môn thuộc hệ "KTV", sắp xếp tăng dần theo Mã môn
        Console.WriteLine("\nd. Môn thuộc hệ 'KTV' (sắp xếp tăng dần theo Mã môn):");
        var cauD = dsMon.Where(m => m.He == "KTV").OrderBy(m => m.MaMon);
        foreach (var m in cauD) Console.WriteLine(" - " + m);
    }

    public static void Bai52()
    {
        Console.WriteLine("\n--- BÀI 5.2: THỐNG KÊ TRÊN LIST<MONHOC> ---");
        var dsMon = DuLieu.DS_Mon();

        // a. Cho biết tổng số môn hiện có
        int tongSoMon = dsMon.Count();
        Console.WriteLine($"\na. Tổng số môn hiện có: {tongSoMon}");

        // b. Đếm số môn có tên bắt đầu bằng "Lập trình"
        int soMonLapTrinh = dsMon.Count(m => m.TenMon.StartsWith("Lập trình"));
        Console.WriteLine($"\nb. Số môn có tên bắt đầu bằng 'Lập trình': {soMonLapTrinh}");

        // c. Tính tổng số tiết của hệ Kỹ thuật viên (KTV)
        int tongTietKTV = dsMon.Where(m => m.He == "KTV").Sum(m => (int)m.SoTiet);
        Console.WriteLine($"\nc. Tổng số tiết hệ KTV: {tongTietKTV}");

        // d. Cho biết tổng số môn của mỗi hệ: Hệ, Tổng số môn
        Console.WriteLine("\nd. Tổng số môn của mỗi hệ:");
        var tongMonMoiHe = dsMon.GroupBy(m => string.IsNullOrEmpty(m.He) ? "(Chưa gán hệ)" : m.He)
                                .Select(g => new { He = g.Key, TongMon = g.Count() });
        foreach (var item in tongMonMoiHe)
        {
            Console.WriteLine($" - Hệ: {item.He,-14} | Tổng số môn: {item.TongMon}");
        }

        // e. Nhóm theo Số tiết; in Số tiết và Tổng số môn, sắp xếp giảm dần theo Số tiết
        Console.WriteLine("\ne. Nhóm theo Số tiết (sắp xếp giảm dần theo Số tiết):");
        var nhomTheoTiet = dsMon.GroupBy(m => m.SoTiet)
                                .OrderByDescending(g => g.Key)
                                .Select(g => new { SoTiet = g.Key, TongSoMon = g.Count() });
        foreach (var item in nhomTheoTiet)
        {
            Console.WriteLine($" - Số tiết: {item.SoTiet,3} | Tổng số môn: {item.TongSoMon}");
        }

        // f. Cho biết thông tin môn học có số tiết cao nhất
        byte maxTiet = dsMon.Max(m => m.SoTiet);
        var monCaoNhat = dsMon.Where(m => m.SoTiet == maxTiet);
        Console.WriteLine($"\nf. Môn học có số tiết cao nhất ({maxTiet} tiết):");
        foreach (var m in monCaoNhat) Console.WriteLine(" - " + m);

        // g. Thống kê theo Hệ: tổng số môn, tổng số tiết, số tiết cao nhất, số tiết thấp nhất
        Console.WriteLine("\ng. Thống kê toàn diện theo Hệ:");
        var thongKeHe = dsMon.GroupBy(m => string.IsNullOrEmpty(m.He) ? "(Chưa gán hệ)" : m.He)
                             .Select(g => new {
                                 He = g.Key,
                                 TongMon = g.Count(),
                                 TongTiet = g.Sum(m => (int)m.SoTiet),
                                 MaxTiet = g.Max(m => m.SoTiet),
                                 MinTiet = g.Min(m => m.SoTiet)
                             });
        foreach (var item in thongKeHe)
        {
            Console.WriteLine($" - Hệ: {item.He,-14} | Môn: {item.TongMon,2} | Tổng tiết: {item.TongTiet,3} | Cao nhất: {item.MaxTiet,3} | Thấp nhất: {item.MinTiet,3}");
        }

        // h. Liệt kê các môn học được phân nhóm theo Hệ
        Console.WriteLine("\nh. Danh sách môn học phân nhóm theo Hệ:");
        var nhomHe = dsMon.GroupBy(m => string.IsNullOrEmpty(m.He) ? "(Chưa gán hệ)" : m.He);
        foreach (var g in nhomHe)
        {
            Console.WriteLine($" * HỆ [{g.Key}] ({g.Count()} môn):");
            foreach (var m in g) Console.WriteLine("    + " + m);
        }

        // i. Liệt kê các môn học được phân nhóm theo Số tiết và tăng dần theo Số tiết
        Console.WriteLine("\ni. Danh sách môn học phân nhóm theo Số tiết (tăng dần):");
        var nhomTietTang = dsMon.GroupBy(m => m.SoTiet).OrderBy(g => g.Key);
        foreach (var g in nhomTietTang)
        {
            Console.WriteLine($" * [{g.Key} TIẾT] ({g.Count()} môn):");
            foreach (var m in g) Console.WriteLine("    + " + m);
        }

        // j. Với hệ KTV, phân nhóm theo học phần HP2, HP3, HP4, HP5; sắp xếp theo Mã môn
        Console.WriteLine("\nj. Hệ KTV phân nhóm theo học phần (HP2, HP3, HP4, HP5):");
        var nhomKTV = dsMon.Where(m => m.He == "KTV")
                           .GroupBy(m => m.MaMon.Contains('_') ? m.MaMon.Split('_')[0] : m.MaMon)
                           .OrderBy(g => g.Key);
        foreach (var g in nhomKTV)
        {
            Console.WriteLine($" * HỌC PHẦN [{g.Key}]:");
            foreach (var m in g.OrderBy(m => m.MaMon))
            {
                Console.WriteLine("    + " + m);
            }
        }

        // k. Phân nhóm theo Hệ, chỉ lấy các môn có Số tiết > 40; trong mỗi nhóm sắp xếp theo Mã môn
        Console.WriteLine("\nk. Phân nhóm theo Hệ với các môn có Số tiết > 40:");
        var nhomHeTietTren40 = dsMon.Where(m => m.SoTiet > 40)
                                    .GroupBy(m => string.IsNullOrEmpty(m.He) ? "(Chưa gán hệ)" : m.He);
        foreach (var g in nhomHeTietTren40)
        {
            Console.WriteLine($" * HỆ [{g.Key}] ({g.Count()} môn > 40 tiết):");
            foreach (var m in g.OrderBy(m => m.MaMon))
            {
                Console.WriteLine("    + " + m);
            }
        }
    }
}
