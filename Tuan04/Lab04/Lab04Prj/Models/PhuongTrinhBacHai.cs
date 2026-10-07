namespace Lab04Prj.Models;

public class PhuongTrinhBacHai
{
    public double A { get; set; }
    public double B { get; set; }
    public double C { get; set; }

    public PhuongTrinhBacHai() { }

    public PhuongTrinhBacHai(double a, double b, double c = 0)
    {
        A = a;
        B = b;
        C = c;
    }

    public string GiaiBacNhat()
    {
        // Xét dạng ax + b = 0
        if (A == 0)
        {
            if (B == 0) return "Phương trình vô số nghiệm";
            return "Phương trình vô nghiệm";
        }
        double x = -B / A;
        return $"Phương trình có nghiệm x = {x:F2}";
    }

    public string GiaiBacHai()
    {
        // Xét dạng ax^2 + bx + c = 0
        if (A == 0)
        {
            // Suy biến về bx + c = 0
            if (B == 0)
            {
                if (C == 0) return "Phương trình vô số nghiệm";
                return "Phương trình vô nghiệm";
            }
            double x = -C / B;
            return $"Phương trình bậc nhất có nghiệm x = {x:F2}";
        }

        double delta = B * B - 4 * A * C;
        if (delta < 0)
        {
            return "Phương trình vô nghiệm";
        }
        if (Math.Abs(delta) < 1e-9)
        {
            double x = -B / (2 * A);
            return $"Phương trình có nghiệm kép x1 = x2 = {x:F2}";
        }
        else
        {
            double x1 = (-B + Math.Sqrt(delta)) / (2 * A);
            double x2 = (-B - Math.Sqrt(delta)) / (2 * A);
            return $"Phương trình có 2 nghiệm phân biệt: x1 = {x1:F2}, x2 = {x2:F2}";
        }
    }
}
