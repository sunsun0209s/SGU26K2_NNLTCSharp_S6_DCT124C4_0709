namespace Lab01Prj;

public class Bai3
{
	public static void Run()
	{
		int x, y;
		Console.Write("Nhap so nguyen x: ");
		x = Convert.ToInt32(Console.ReadLine());
		Console.Write("Nhap so nguyen y: ");
		y = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine($"Ket qua cua {x} mu {y} la : {Math.Pow(x, y)}");
	}
}