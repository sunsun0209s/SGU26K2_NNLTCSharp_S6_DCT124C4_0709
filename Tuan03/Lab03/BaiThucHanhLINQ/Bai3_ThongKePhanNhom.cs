namespace BaiThucHanhLINQ;

public static class Bai3_ThongKePhanNhom
{
    public static void Bai31()
    {
        Console.WriteLine("\n--- BÀI 3.1: THỐNG KÊ MẢNG SỐ ---");
        int[] mangSo = { 50, 42, 12, 3, 9, 8, 1, 50, 3, 42, 85 };
        Console.WriteLine("Mảng: " + string.Join(", ", mangSo));

        // a. Cho biết tổng số phần tử, số phần tử chẵn và số phần tử lẻ
        int tongSo = mangSo.Count();
        int soChan = mangSo.Count(n => n % 2 == 0);
        int soLe = mangSo.Count(n => n % 2 != 0);
        Console.WriteLine($"\na. Tổng số phần tử: {tongSo} | Số phần tử chẵn: {soChan} | Số phần tử lẻ: {soLe}");

        // b. Tính tổng các giá trị, giá trị lớn nhất và giá trị nhỏ nhất
        int tongGiaTri = mangSo.Sum();
        int maxVal = mangSo.Max();
        int minVal = mangSo.Min();
        Console.WriteLine($"\nb. Tổng giá trị: {tongGiaTri} | Max: {maxVal} | Min: {minVal}");

        // c. Cho biết có bao nhiêu giá trị khác nhau trong mảng
        int soGiaTriKhacNhau = mangSo.Distinct().Count();
        var dsKhacNhau = mangSo.Distinct();
        Console.WriteLine($"\nc. Số giá trị khác nhau: {soGiaTriKhacNhau} (Các giá trị: {string.Join(", ", dsKhacNhau)})");

        // d. Phân nhóm các phần tử theo số dư khi chia cho 5; in số dư và các phần tử thuộc từng nhóm
        Console.WriteLine("\nd. Phân nhóm theo số dư khi chia cho 5:");
        // Method Syntax
        var nhomDu = mangSo.GroupBy(n => n % 5).OrderBy(g => g.Key);
        foreach (var g in nhomDu)
        {
            Console.WriteLine($" - Số dư {g.Key}: {string.Join(", ", g)} (Tổng: {g.Count()} phần tử)");
        }
    }

    public static void Bai32()
    {
        Console.WriteLine("\n--- BÀI 3.2: THỐNG KÊ MẢNG CHUỖI ---");
        string[] monAn = { "Bún bò Huế", "Hủ tiếu heo", "Bánh canh", "Bánh mì",
                           "Nước Cà phê", "Mì quảng", "Cơm tấm", "Nước Chanh dây", "Mì xào",
                           "Bún riêu", "Bánh cuốn", "Mì gói", "Bún chả", "Hủ tiếu Nam vang" };
        Console.WriteLine("Danh sách món ăn: " + string.Join("; ", monAn));

        // a. Tìm các phần tử có chiều dài ngắn nhất và dài nhất
        int minLen = monAn.Min(s => s.Length);
        int maxLen = monAn.Max(s => s.Length);
        var cacMonNganNhat = monAn.Where(s => s.Length == minLen);
        var cacMonDaiNhat = monAn.Where(s => s.Length == maxLen);
        Console.WriteLine($"\na. Ngắn nhất ({minLen} ký tự): {string.Join(", ", cacMonNganNhat)}");
        Console.WriteLine($"   Dài nhất ({maxLen} ký tự): {string.Join(", ", cacMonDaiNhat)}");

        // b. Phân nhóm theo từ đầu tiên của tên món và liệt kê các phần tử trong từng nhóm
        Console.WriteLine("\nb. Phân nhóm theo từ đầu tiên của tên món:");
        var nhomMon = monAn.GroupBy(s => s.Split(' ')[0]);
        foreach (var g in nhomMon)
        {
            Console.WriteLine($" * Nhóm [{g.Key}] ({g.Count()} món): {string.Join(", ", g)}");
        }

        // c. Đếm số phần tử có từ đầu tiên là "Bánh"
        int soMonBanh = monAn.Count(s => s.Split(' ')[0] == "Bánh");
        Console.WriteLine($"\nc. Số phần tử có từ đầu tiên là 'Bánh': {soMonBanh}");
    }
}
