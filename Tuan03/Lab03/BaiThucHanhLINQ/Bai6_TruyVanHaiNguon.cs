namespace BaiThucHanhLINQ;

public static class Bai6_TruyVanHaiNguon
{
    public static void Bai61()
    {
        Console.WriteLine("\n--- BÀI 6.1: XÂY DỰNG LỚP HE VÀ NGUỒN DỮ LIỆU DS_HE ---");
        var dsHe = DuLieu.DS_He();
        Console.WriteLine("Danh sách các hệ đào tạo trong hệ thống (List<He>):");
        foreach (var he in dsHe)
        {
            Console.WriteLine($" - Mã hệ: {he.MaHe,-5} | Tên hệ: {he.TenHe}");
        }
    }

    public static void Bai62()
    {
        Console.WriteLine("\n--- BÀI 6.2: JOIN VÀ CÁC TOÁN TỬ TẬP HỢP ---");
        var dsMon = DuLieu.DS_Mon();
        var dsHe = DuLieu.DS_He();

        // a. Dùng join để liệt kê: Tên hệ, Mã môn, Tên môn (Inner Join)
        Console.WriteLine("\na. Inner Join (Tên hệ, Mã môn, Tên môn):");
        var cauA = from h in dsHe
                   join m in dsMon on h.MaHe equals m.He
                   select new { h.TenHe, m.MaMon, m.TenMon };
        foreach (var item in cauA)
        {
            Console.WriteLine($" - Hệ: {item.TenHe,-18} | Mã: {item.MaMon,-8} | Tên: {item.TenMon}");
        }

        // b. Liệt kê cả những hệ chưa có môn học (Left Outer Join)
        Console.WriteLine("\nb. Left Outer Join (hiển thị cả hệ chưa có môn học):");
        var cauB = from h in dsHe
                   join m in dsMon on h.MaHe equals m.He into g
                   from subM in g.DefaultIfEmpty()
                   select new {
                       TenHe = h.TenHe,
                       MaMon = subM != null ? subM.MaMon : "(Chưa có môn)",
                       TenMon = subM != null ? subM.TenMon : "(Chưa có môn)"
                   };
        foreach (var item in cauB)
        {
            Console.WriteLine($" - Hệ: {item.TenHe,-18} | Mã: {item.MaMon,-14} | Tên: {item.TenMon}");
        }

        // c. Liệt kê cả hệ chưa có môn học VÀ môn học chưa khai báo hệ (Full Outer Join)
        Console.WriteLine("\nc. Full Outer Join (cả hệ chưa có môn và môn chưa có hệ):");
        var leftJoin = from h in dsHe
                       join m in dsMon on h.MaHe equals m.He into g
                       from subM in g.DefaultIfEmpty()
                       select new {
                           TenHe = h.TenHe,
                           MaMon = subM != null ? subM.MaMon : "(Chưa có môn)",
                           TenMon = subM != null ? subM.TenMon : "(Chưa có môn)"
                       };
        var monKhongHe = from m in dsMon
                         where !dsHe.Any(h => h.MaHe == m.He)
                         select new {
                             TenHe = "(Chưa khai báo hệ)",
                             MaMon = m.MaMon,
                             TenMon = m.TenMon
                         };
        var cauC = leftJoin.Concat(monKhongHe);
        foreach (var item in cauC)
        {
            Console.WriteLine($" - Hệ: {item.TenHe,-20} | Mã: {item.MaMon,-14} | Tên: {item.TenMon}");
        }

        // d. Chỉ liệt kê những hệ chưa có môn học và những môn học chưa khai báo hệ
        Console.WriteLine("\nd. Chỉ liệt kê các hệ chưa có môn và môn chưa có hệ:");
        var heRong = from h in dsHe
                     where !dsMon.Any(m => m.He == h.MaHe)
                     select new { Loai = "Hệ chưa có môn ", Ma = h.MaHe, Ten = h.TenHe };
        var monRong = from m in dsMon
                      where !dsHe.Any(h => h.MaHe == m.He)
                      select new { Loai = "Môn chưa có hệ", Ma = m.MaMon, Ten = m.TenMon };
        var cauD = heRong.Concat(monRong);
        foreach (var item in cauD)
        {
            Console.WriteLine($" - [{item.Loai}] Mã: {item.Ma,-8} | Tên: {item.Ten}");
        }

        // e. Lấy 5 môn học đầu tiên có số tiết giảm dần
        Console.WriteLine("\ne. Top 5 môn có số tiết cao nhất:");
        var cauE = (from m in dsMon
                    join h in dsHe on m.He equals h.MaHe into g
                    from subH in g.DefaultIfEmpty()
                    orderby m.SoTiet descending
                    select new {
                        TenHe = subH != null ? subH.TenHe : "(Chưa có hệ)",
                        m.MaMon,
                        m.TenMon,
                        m.SoTiet
                    }).Take(5);
        foreach (var item in cauE)
        {
            Console.WriteLine($" - Mã: {item.MaMon,-8} | {item.TenMon,-42} | Hệ: {item.TenHe,-15} | Tiết: {item.SoTiet,3}");
        }

        // f. Cho biết tổng số môn học của mỗi hệ: Mã hệ, Tên hệ, Tổng số môn
        Console.WriteLine("\nf. Tổng số môn học của mỗi hệ:");
        var cauF = from h in dsHe
                   join m in dsMon on h.MaHe equals m.He into g
                   select new {
                       h.MaHe,
                       h.TenHe,
                       TongSoMon = g.Count()
                   };
        foreach (var item in cauF)
        {
            Console.WriteLine($" - Mã hệ: {item.MaHe,-5} | Tên hệ: {item.TenHe,-18} | Tổng số môn: {item.TongSoMon}");
        }

        // g. Cho biết có bao nhiêu loại Số tiết khác nhau trong danh sách môn học
        int soLoaiTiet = dsMon.Select(m => m.SoTiet).Distinct().Count();
        var cacLoaiTiet = dsMon.Select(m => m.SoTiet).Distinct().OrderBy(t => t);
        Console.WriteLine($"\ng. Có {soLoaiTiet} loại số tiết khác nhau: {string.Join(", ", cacLoaiTiet)}");

        // h. Tìm môn học đầu tiên có tên bắt đầu bằng "Lập trình"
        var monDauTien = dsMon.FirstOrDefault(m => m.TenMon.StartsWith("Lập trình"));
        Console.WriteLine($"\nh. Môn học đầu tiên có tên bắt đầu bằng 'Lập trình': {monDauTien}");

        // i. Liệt kê các môn theo từng hệ, đánh số thứ tự trong mỗi nhóm
        Console.WriteLine("\ni. Danh sách môn theo từng hệ (có đánh số thứ tự trong mỗi nhóm):");
        var cauI = from h in dsHe
                   join m in dsMon on h.MaHe equals m.He into g
                   select new {
                       TenHe = h.TenHe,
                       DanhSach = g.Select((m, idx) => new { STT = idx + 1, m.MaMon, m.TenMon, m.SoTiet })
                   };
        foreach (var group in cauI)
        {
            Console.WriteLine($"\n * HỆ [{group.TenHe.ToUpper()}]:");
            if (!group.DanhSach.Any())
            {
                Console.WriteLine("    (Hệ này hiện chưa có môn học nào)");
            }
            else
            {
                foreach (var item in group.DanhSach)
                {
                    Console.WriteLine($"    {item.STT,2}. Mã: {item.MaMon,-8} | {item.TenMon,-42} | Tiết: {item.SoTiet,3}");
                }
            }
        }
    }
}
