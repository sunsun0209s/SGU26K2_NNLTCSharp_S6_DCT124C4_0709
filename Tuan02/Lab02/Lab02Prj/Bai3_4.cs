namespace Lab02Prj;

public class ConsoleMenu
{
    protected List<string> menuItems;

    // Sự kiện Choose được kích hoạt khi người dùng nhập lựa chọn
    public event Action<int>? Choose;

    public ConsoleMenu()
    {
        menuItems = new List<string>();
    }

    public void AddMenuItem(string item)
    {
        menuItems.Add(item);
    }

    // Hiển thị menu và nhận lựa chọn
    public void Show()
    {
        Console.WriteLine("\nMenu");
        for (int i = 0; i < menuItems.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {menuItems[i]}");
        }
        Console.WriteLine("0. Thoát chương trình");
    }

    // Vòng lặp điều khiển menu
    public virtual void RunMenu()
    {
        int choice;
        do
        {
            Show();
            Console.Write("Thực hiện: ");
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                choice = -1;
            }

            Console.WriteLine($"Bạn thực hiện chức năng {choice}");

            if (choice != 0)
            {
                // Kích hoạt sự kiện Choose
                Choose?.Invoke(choice);
            }
        } while (choice != 0);
    }
}

// Ứng dụng giải phương trình bậc 2 kế thừa từ ConsoleMenu và mở rộng qua sự kiện
public class PTBac2Console : ConsoleMenu
{
    private double a, b, c;
    private bool daNhap = false;

    public PTBac2Console()
    {
        AddMenuItem("Nhập hệ số a, b, c");
        AddMenuItem("Giải phương trình bậc 2");

        // Đăng ký phương thức xử lý vào sự kiện Choose
        Choose += HandleChoose;
    }

    private void HandleChoose(int choice)
    {
        switch (choice)
        {
            case 1:
                NhapHeSo();
                break;
            case 2:
                GiaiPhuongTrinh();
                break;
            default:
                Console.WriteLine("Chức năng không hợp lệ!");
                break;
        }
    }

    private void NhapHeSo()
    {
        Console.Write("Nhập hệ số a: ");
        a = double.Parse(Console.ReadLine() ?? "0");
        Console.Write("Nhập hệ số b: ");
        b = double.Parse(Console.ReadLine() ?? "0");
        Console.Write("Nhập hệ số c: ");
        c = double.Parse(Console.ReadLine() ?? "0");
        daNhap = true;
        Console.WriteLine($"Đã lưu phương trình: {a}x^2 + {b}x + {c} = 0");
    }

    private void GiaiPhuongTrinh()
    {
        if (!daNhap)
        {
            Console.WriteLine("Vui lòng thực hiện chức năng 1 để nhập hệ số trước!");
            return;
        }

        Console.WriteLine($"Giải phương trình: {a}x^2 + {b}x + {c} = 0");
        if (a == 0)
        {
            if (b == 0)
            {
                Console.WriteLine(c == 0 ? "Phương trình vô số nghiệm." : "Phương trình vô nghiệm.");
            }
            else
            {
                Console.WriteLine($"Phương trình bậc nhất có nghiệm x = {-c / b}");
            }
            return;
        }

        double delta = b * b - 4 * a * c;
        if (delta < 0)
        {
            Console.WriteLine("Phương trình vô nghiệm thực.");
        }
        else if (delta == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine($"Phương trình có nghiệm kép x1 = x2 = {x}");
        }
        else
        {
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine($"Phương trình có 2 nghiệm phân biệt: x1 = {x1}, x2 = {x2}");
        }
    }
}

public class Bai3_4
{
    public static void Run()
    {
        PTBac2Console app = new PTBac2Console();
        app.RunMenu();
    }
}
