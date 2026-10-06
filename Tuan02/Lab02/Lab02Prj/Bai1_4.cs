namespace Lab02Prj;

public class PhanSo
{
    private int tuSo; private int mauSo;
    public int TuSo
    {
        get { return tuSo; }
        set { tuSo = value; }
    }
    public int MauSo
    {
        get { return mauSo; }
        set
        {
            if (value != 0) mauSo = value;
            else mauSo = 1;
        }
    }

    // Tìm ước chung lớn nhất để rút gọn
    private static int UCLN(int a, int b)
    {
        a = Math.Abs(a);
        b = Math.Abs(b);
        while (b != 0)
        {
            int r = a % b;
            a = b;
            b = r;
        }
        return a == 0 ? 1 : a;
    }

    // Rút gọn phân số
    public void RutGon()
    {
        if (mauSo < 0)
        {
            tuSo = -tuSo;
            mauSo = -mauSo;
        }
        int ucln = UCLN(tuSo, mauSo);
        tuSo /= ucln;
        mauSo /= ucln;
    }

    // Hàm tạo mặc nhiên
    public PhanSo()
    {
        tuSo = 0;
        mauSo = 1;
    }

    // Hàm tạo với số nguyên
    public PhanSo(int tuSo)
    {
        this.tuSo = tuSo;
        this.mauSo = 1;
    }

    // Hàm tạo với tử số và mẫu số
    public PhanSo(int tuSo, int mauSo)
    {
        this.tuSo = tuSo;
        this.mauSo = mauSo != 0 ? mauSo : 1;
        RutGon();
    }

    // Hàm tạo sao chép
    public PhanSo(PhanSo ps)
    {
        this.tuSo = ps.tuSo;
        this.mauSo = ps.mauSo;
    }

    // Nhập phân số
    public void Input()
    {
        Console.Write("Nhap tu so: ");
        tuSo = int.Parse(Console.ReadLine() ?? "0");

        do
        {
            Console.Write("Nhap mau so (khac 0): ");
            mauSo = int.Parse(Console.ReadLine() ?? "1");
            if (mauSo == 0)
            {
                Console.WriteLine("Mau so phai khac 0, vui long nhap lai!");
            }
        } while (mauSo == 0);

        RutGon();
    }

    // Xuất phân số
    public void Output()
    {
        Console.WriteLine(ToString());
    }

    public override string ToString()
    {
        if (tuSo == 0) return "0";
        if (mauSo == 1) return $"{tuSo}";
        return $"{tuSo}/{mauSo}";
    }

    // Toán tử một ngôi: lấy dương (+) và lấy âm (-)
    public static PhanSo operator +(PhanSo ps)
    {
        return new PhanSo(ps.tuSo, ps.mauSo);
    }

    public static PhanSo operator -(PhanSo ps)
    {
        return new PhanSo(-ps.tuSo, ps.mauSo);
    }

    // Toán tử hai ngôi: cộng, trừ, nhân, chia
    public static PhanSo operator +(PhanSo a, PhanSo b)
    {
        int tu = a.tuSo * b.mauSo + b.tuSo * a.mauSo;
        int mau = a.mauSo * b.mauSo;
        return new PhanSo(tu, mau);
    }

    public static PhanSo operator -(PhanSo a, PhanSo b)
    {
        int tu = a.tuSo * b.mauSo - b.tuSo * a.mauSo;
        int mau = a.mauSo * b.mauSo;
        return new PhanSo(tu, mau);
    }

    public static PhanSo operator *(PhanSo a, PhanSo b)
    {
        int tu = a.tuSo * b.tuSo;
        int mau = a.mauSo * b.mauSo;
        return new PhanSo(tu, mau);
    }

    public static PhanSo operator /(PhanSo a, PhanSo b)
    {
        int tu = a.tuSo * b.mauSo;
        int mau = a.mauSo * b.tuSo;
        return new PhanSo(tu, mau);
    }

    // Toán tử so sánh: >, <, >=, <=, ==, !=
    public static bool operator >(PhanSo a, PhanSo b)
    {
        return a.tuSo * b.mauSo > b.tuSo * a.mauSo;
    }

    public static bool operator <(PhanSo a, PhanSo b)
    {
        return a.tuSo * b.mauSo < b.tuSo * a.mauSo;
    }

    public static bool operator >=(PhanSo a, PhanSo b)
    {
        return a.tuSo * b.mauSo >= b.tuSo * a.mauSo;
    }

    public static bool operator <=(PhanSo a, PhanSo b)
    {
        return a.tuSo * b.mauSo <= b.tuSo * a.mauSo;
    }

    public static bool operator ==(PhanSo? a, PhanSo? b)
    {
        if (ReferenceEquals(a, b)) return true;
        if (a is null || b is null) return false;
        return a.tuSo * b.mauSo == b.tuSo * a.mauSo;
    }

    public static bool operator !=(PhanSo? a, PhanSo? b)
    {
        return !(a == b);
    }

    public override bool Equals(object? obj)
    {
        if (obj is PhanSo other)
        {
            return this == other;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(tuSo, mauSo);
    }
}

public class Bai1_4
{
    public static void Run()
    {
        Console.WriteLine("Nhap phan so thu nhat (ps1):");
        PhanSo ps1 = new PhanSo();
        ps1.Input();

        Console.WriteLine("Nhap phan so thu hai (ps2):");
        PhanSo ps2 = new PhanSo();
        ps2.Input();

        Console.WriteLine($"Phan so 1: {ps1}");
        Console.WriteLine($"Phan so 2: {ps2}");

        Console.WriteLine("Cac phep toan mot ngoi:");
        Console.WriteLine($"+ps1 = {+ps1}");
        Console.WriteLine($"-ps1 = {-ps1}");

        Console.WriteLine("Cac phep toan hai ngoi:");
        Console.WriteLine($"{ps1} + {ps2} = {ps1 + ps2}");
        Console.WriteLine($"{ps1} - {ps2} = {ps1 - ps2}");
        Console.WriteLine($"{ps1} * {ps2} = {ps1 * ps2}");
        Console.WriteLine($"{ps1} / {ps2} = {ps1 / ps2}");

        Console.WriteLine("So sanh hai phan so:");
        Console.WriteLine($"{ps1} > {ps2} : {ps1 > ps2}");
        Console.WriteLine($"{ps1} < {ps2} : {ps1 < ps2}");
        Console.WriteLine($"{ps1} >= {ps2} : {ps1 >= ps2}");
        Console.WriteLine($"{ps1} <= {ps2} : {ps1 <= ps2}");
        Console.WriteLine($"{ps1} == {ps2} : {ps1 == ps2}");
        Console.WriteLine($"{ps1} != {ps2} : {ps1 != ps2}");
    }
}
