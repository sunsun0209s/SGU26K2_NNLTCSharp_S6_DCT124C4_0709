namespace Lab01Prj;

public class Bai5
{
    public static void Run()
    {
        int lc;
        double x = 0, y = 0;

        do
        {
            Console.WriteLine("\nMENU");
            Console.WriteLine("1. Nhap hai gia tri so thuc cho x, y");
            Console.WriteLine("2. Tinh x^y");
            Console.WriteLine("3. Tinh can bac 2 cua x va y");
            Console.WriteLine("4. Thoat");
            Console.Write("Chon chuc nang: ");
            lc = int.Parse(Console.ReadLine() ?? "0");

            if (lc == 1)
            {
                Console.Write("Nhap gia tri x: ");
                x = double.Parse(Console.ReadLine() ?? "0");
                Console.Write("Nhap gia tri y: ");
                y = double.Parse(Console.ReadLine() ?? "0");
            }
            else if (lc == 2)
            {
                Console.WriteLine($"x^y = {Math.Pow(x, y)}");
            }
            else if (lc == 3)
            {
                Console.WriteLine(x >= 0 ? $"Can bac 2 cua x = {Math.Sqrt(x)}" : "x < 0, khong co can bac 2");
                Console.WriteLine(y >= 0 ? $"Can bac 2 cua y = {Math.Sqrt(y)}" : "y < 0, khong co can bac 2");
            }
            else if (lc == 4)
            {
                Console.WriteLine("Thoat chuong trinh.");
            }
            else
            {
                Console.WriteLine("Chuc nang khong hop le. Vui long chon lai.");
            }

        } while (lc != 4); 
    }
}