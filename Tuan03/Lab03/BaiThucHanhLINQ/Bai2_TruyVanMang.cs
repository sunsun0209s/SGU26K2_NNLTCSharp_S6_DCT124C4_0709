namespace BaiThucHanhLINQ;

public static class Bai2_TruyVanMang
{
    public static void Bai21()
    {
        Console.WriteLine("--- BÀI 2.1: TRUY VẤN MẢNG SỐ NGUYÊN ---");
        int[] mangSo = { 50, 42, 16, 3, 9, 8, 12, 7, 24, 0 };
        Console.WriteLine("Mảng ban đầu: " + string.Join(", ", mangSo));

        // a. Liệt kê các phần tử chia hết cho 4 và 3
        Console.WriteLine("\na. Các phần tử chia hết cho 4 và 3:");
        // Query Syntax
        var cauA_Query = from n in mangSo
                         where n % 4 == 0 && n % 3 == 0
                         select n;
        // Method Syntax
        var cauA_Method = mangSo.Where(n => n % 4 == 0 && n % 3 == 0);
        Console.WriteLine("[Query Syntax] : " + string.Join(", ", cauA_Query));
        Console.WriteLine("[Method Syntax]: " + string.Join(", ", cauA_Method));

        // b. Liệt kê các phần tử nhỏ hơn hoặc bằng 3
        Console.WriteLine("\nb. Các phần tử nhỏ hơn hoặc bằng 3:");
        // Query Syntax
        var cauB_Query = from n in mangSo
                         where n <= 3
                         select n;
        // Method Syntax
        var cauB_Method = mangSo.Where(n => n <= 3);
        Console.WriteLine("[Query Syntax] : " + string.Join(", ", cauB_Query));
        Console.WriteLine("[Method Syntax]: " + string.Join(", ", cauB_Method));

        // c. Tạo một dãy mới: số chẵn chia đôi, số lẻ giữ nguyên giá trị
        Console.WriteLine("\nc. Dãy mới (chẵn chia đôi, lẻ giữ nguyên):");
        // Query Syntax
        var cauC_Query = from n in mangSo
                         select (n % 2 == 0 ? n / 2 : n);
        // Method Syntax
        var cauC_Method = mangSo.Select(n => n % 2 == 0 ? n / 2 : n);
        Console.WriteLine("[Query Syntax] : " + string.Join(", ", cauC_Query));
        Console.WriteLine("[Method Syntax]: " + string.Join(", ", cauC_Method));
    }

    public static void Bai22()
    {
        Console.WriteLine("\n--- BÀI 2.2: TRUY VẤN MẢNG CHUỖI ---");
        string[] mangChuoi = { "đầu", "lòng", "hai", "ả", "tố", "nga",
                               "Thúy", "Kiều", "là", "chị", "em", "là", "Thúy", "Vân" };
        Console.WriteLine("Mảng chuỗi ban đầu: " + string.Join(" ", mangChuoi));

        // a. Liệt kê các phần tử có 4 ký tự và sắp xếp tăng dần theo ký tự đầu tiên
        Console.WriteLine("\na. Các phần tử có 4 ký tự, sắp xếp tăng dần theo ký tự đầu:");
        // Query Syntax
        var cauA_Query = from s in mangChuoi
                         where s.Length == 4
                         orderby s[0]
                         select s;
        // Method Syntax
        var cauA_Method = mangChuoi.Where(s => s.Length == 4).OrderBy(s => s[0]);
        Console.WriteLine("[Query Syntax] : " + string.Join(", ", cauA_Query));
        Console.WriteLine("[Method Syntax]: " + string.Join(", ", cauA_Method));

        // b. Biến đổi mỗi phần tử thành dạng: <chữ thường> - <CHỮ HOA>
        Console.WriteLine("\nb. Biến đổi phần tử thành <chữ thường> - <CHỮ HOA>:");
        // Query Syntax
        var cauB_Query = from s in mangChuoi
                         select $"{s.ToLower()} - {s.ToUpper()}";
        // Method Syntax
        var cauB_Method = mangChuoi.Select(s => $"{s.ToLower()} - {s.ToUpper()}");
        foreach (var item in cauB_Method)
        {
            Console.WriteLine(item);
        }

        // c. Liệt kê các phần tử có chứa ký tự "u"
        Console.WriteLine("\nc. Các phần tử có chứa ký tự 'u':");
        // Query Syntax
        var cauC_Query = from s in mangChuoi
                         where s.Contains("u")
                         select s;
        // Method Syntax
        var cauC_Method = mangChuoi.Where(s => s.Contains("u"));
        Console.WriteLine("[Query Syntax] : " + string.Join(", ", cauC_Query));
        Console.WriteLine("[Method Syntax]: " + string.Join(", ", cauC_Method));

        // d. Liệt kê các từ bắt đầu bằng chữ in hoa ("Thúy Kiều Thúy Vân")
        Console.WriteLine("\nd. Các từ bắt đầu bằng chữ in hoa:");
        // Query Syntax
        var cauD_Query = from s in mangChuoi
                         where char.IsUpper(s[0])
                         select s;
        // Method Syntax
        var cauD_Method = mangChuoi.Where(s => char.IsUpper(s[0]));
        Console.WriteLine("[Query Syntax] : " + string.Join(" ", cauD_Query));
        Console.WriteLine("[Method Syntax]: " + string.Join(" ", cauD_Method));
    }
}
