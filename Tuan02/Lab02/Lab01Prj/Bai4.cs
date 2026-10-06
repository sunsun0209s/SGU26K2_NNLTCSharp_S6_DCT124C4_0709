namespace Lab01Prj;

public class Bai4
{
    public static void Run()
    {
        Console.Write("Nhap so nguyen x: ");
        if (!int.TryParse(Console.ReadLine(), out int x))
        {
            Console.WriteLine("x khong phai la so nguyen hop le.");
            return;
        }

        Console.Write("Nhap so nguyen y: ");
        if (!int.TryParse(Console.ReadLine(), out int y))
        {
            Console.WriteLine("y khong phai la so nguyen hop le.");
            return;
        }

        Console.WriteLine($"Ket qua cua {x} mu {y} la : {Math.Pow(x, y)}");
    }
}