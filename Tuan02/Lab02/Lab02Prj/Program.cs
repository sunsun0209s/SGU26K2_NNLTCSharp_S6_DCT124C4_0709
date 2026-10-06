namespace Lab02Prj;

public class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\n--- MENU CHỌN BÀI LAB 02 ---");
            Console.WriteLine("Phần 1: 1.1, 1.2, 1.3, 1.4, 1.5");
            Console.WriteLine("Phần 2: 2.1, 2.2, 2.3, 2.4, 2.3.2, 2.4.2, 2.5");
            Console.WriteLine("Phần 3: 3.1, 3.2, 3.3, 3.4, 3.5, 3.6");
            Console.WriteLine("0. Thoát");
            Console.Write("Nhập mã bài muốn chạy (ví dụ 1.1, 2.5, 3.6): ");
            string? choice = Console.ReadLine()?.Trim();

            if (choice == "0")
            {
                break;
            }

            Console.WriteLine();
            switch (choice)
            {
                case "1.1":
                    Bai1_1.Run();
                    break;
                case "1.2":
                    Bai1_2.Run();
                    break;
                case "1.3":
                    Bai1_3.Run();
                    break;
                case "1.4":
                    Bai1_4.Run();
                    break;
                case "1.5":
                    Bai1_5.Run();
                    break;
                case "2.1":
                    Bai2_1.Run();
                    break;
                case "2.2":
                    Bai2_2.Run();
                    break;
                case "2.3":
                    Bai2_3.Run();
                    break;
                case "2.4":
                    Bai2_4.Run();
                    break;
                case "2.3.2":
                case "2.3_2":
                    Bai2_3_2.Run();
                    break;
                case "2.4.2":
                case "2.4_2":
                    Bai2_4_2.Run();
                    break;
                case "2.5":
                    Bai2_5.Run();
                    break;
                case "3.1":
                    Bai3_1.Run();
                    break;
                case "3.2":
                    Bai3_2.Run();
                    break;
                case "3.3":
                    Bai3_3.Run();
                    break;
                case "3.4":
                    Bai3_4.Run();
                    break;
                case "3.5":
                    Bai3_5.Run();
                    break;
                case "3.6":
                    Bai3_6.Run();
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ, vui lòng chọn lại!");
                    break;
            }
        }
    }
}
