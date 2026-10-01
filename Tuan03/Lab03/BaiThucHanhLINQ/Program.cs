using System;
using System.Collections.Generic;
using System.Linq;

namespace BaiThucHanhLINQ;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        while (true)
        {
            Console.WriteLine("1. Bài 2.1: Truy vấn mảng số nguyên");
            Console.WriteLine("2. Bài 2.2: Truy vấn mảng chuỗi");
            Console.WriteLine("3. Bài 3.1: Thống kê mảng số");
            Console.WriteLine("4. Bài 3.2: Thống kê mảng chuỗi (Món ăn)");
            Console.WriteLine("5. Bài 4.1: Xây dựng lớp MonHoc và nguồn dữ liệu DS_Mon");
            Console.WriteLine("6. Bài 5.1: Truy vấn cơ bản List<MonHoc>");
            Console.WriteLine("7. Bài 5.2: Thống kê List<MonHoc>");
            Console.WriteLine("8. Bài 6.1: Xây dựng lớp He và nguồn dữ liệu DS_He");
            Console.WriteLine("9. Bài 6.2: Join và các toán tử tập hợp");
            Console.WriteLine("10. Chạy TẤT CẢ các bài");
            Console.WriteLine("0. Thoát");
            Console.Write("Chọn chức năng (0-10): ");
            string? chon = Console.ReadLine()?.Trim();

            if (chon == "0") break;

            Console.WriteLine();
            switch (chon)
            {
                case "1":
                    Bai2_TruyVanMang.Bai21();
                    break;
                case "2":
                    Bai2_TruyVanMang.Bai22();
                    break;
                case "3":
                    Bai3_ThongKePhanNhom.Bai31();
                    break;
                case "4":
                    Bai3_ThongKePhanNhom.Bai32();
                    break;
                case "5":
                    Bai5_TruyVanMonHoc.Bai41();
                    break;
                case "6":
                    Bai5_TruyVanMonHoc.Bai51();
                    break;
                case "7":
                    Bai5_TruyVanMonHoc.Bai52();
                    break;
                case "8":
                    Bai6_TruyVanHaiNguon.Bai61();
                    break;
                case "9":
                    Bai6_TruyVanHaiNguon.Bai62();
                    break;
                case "10":
                    Bai2_TruyVanMang.Bai21();
                    Bai2_TruyVanMang.Bai22();
                    Bai3_ThongKePhanNhom.Bai31();
                    Bai3_ThongKePhanNhom.Bai32();
                    Bai5_TruyVanMonHoc.Bai41();
                    Bai5_TruyVanMonHoc.Bai51();
                    Bai5_TruyVanMonHoc.Bai52();
                    Bai6_TruyVanHaiNguon.Bai61();
                    Bai6_TruyVanHaiNguon.Bai62();
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ, vui lòng chọn lại!");
                    break;
            }
        }
    }
}
