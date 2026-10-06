namespace Lab02Prj;

public class DaThuc
{
    private DonThuc[] ds;
    private int bac;

    public int Bac
    {
        get { return bac; }
    }

    // Hàm tạo mặc định
    public DaThuc()
    {
        bac = 0;
        ds = new DonThuc[1];
        ds[0] = new DonThuc(0, 0);
    }

    // Hàm tạo với bậc n
    public DaThuc(int n)
    {
        bac = n >= 0 ? n : 0;
        ds = new DonThuc[bac + 1];
        for (int i = 0; i <= bac; i++)
        {
            ds[i] = new DonThuc(0, i);
        }
    }

    // Hàm tạo sao chép
    public DaThuc(DaThuc other)
    {
        bac = other.bac;
        ds = new DonThuc[bac + 1];
        for (int i = 0; i <= bac; i++)
        {
            ds[i] = new DonThuc(other.ds[i]);
        }
    }

    // Indexer truy cập đơn thức thứ i
    public DonThuc this[int i]
    {
        get
        {
            if (i >= 0 && i <= bac)
            {
                return ds[i];
            }
            throw new IndexOutOfRangeException("Chi muc vuot qua pham vi!");
        }
        set
        {
            if (i >= 0 && i <= bac)
            {
                ds[i] = value;
            }
            else
            {
                throw new IndexOutOfRangeException("Chi muc vuot qua pham vi!");
            }
        }
    }

    // Nhập đa thức
    public void Input()
    {
        do
        {
            Console.Write("Nhap bac cua da thuc n (n >= 0): ");
            bac = int.Parse(Console.ReadLine() ?? "0");
            if (bac < 0)
            {
                Console.WriteLine("Bac cua da thuc phai khong am, vui long nhap lai!");
            }
        } while (bac < 0);

        ds = new DonThuc[bac + 1];
        for (int i = 0; i <= bac; i++)
        {
            Console.Write($"Nhap he so a{i} cho don thuc bac {i}: ");
            double heSo = double.Parse(Console.ReadLine() ?? "0");
            ds[i] = new DonThuc(heSo, i);
        }
    }

    // Xuất đa thức
    public void Output()
    {
        List<string> cacSoHang = new List<string>();
        for (int i = bac; i >= 0; i--)
        {
            if (ds[i].A != 0)
            {
                cacSoHang.Add(ds[i].ToString());
            }
        }

        if (cacSoHang.Count == 0)
        {
            Console.WriteLine("0");
        }
        else
        {
            Console.WriteLine(string.Join(" + ", cacSoHang).Replace("+ -", "- "));
        }
    }

    // Tính giá trị của đa thức với giá trị x
    public double TinhGiaTri(double x)
    {
        double tong = 0;
        for (int i = 0; i <= bac; i++)
        {
            tong += ds[i].TinhGiaTri(x);
        }
        return tong;
    }
}

public class Bai2_3_2
{
    public static void Run()
    {

        DaThuc p = new DaThuc();
        p.Input();

        Console.Write("Da thuc vua nhap P(x) = ");
        p.Output();

        if (p.Bac >= 0)
        {
            Console.WriteLine($"Thu nghiem Indexer - Don thuc bac 0 p[0] = {p[0]}");
            Console.WriteLine($"Don thuc bac cao nhat p[{p.Bac}] = {p[p.Bac]}");
        }

        Console.Write("Nhap gia tri x can tinh: ");
        double x = double.Parse(Console.ReadLine() ?? "0");

        double ketQua = p.TinhGiaTri(x);
        Console.WriteLine($"Gia tri cua da thuc P({x}) = {ketQua}");
    }
}
