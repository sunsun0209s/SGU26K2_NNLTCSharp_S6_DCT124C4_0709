namespace Lab01Prj;

public class Bai17
{
    public static int[,] SinhMang(int n, int m)
    {
        Random rd = new Random();
        int[,] a = new int[n, m];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                a[i, j] = rd.Next(10, 101);
            }
        }
        return a;
    }

    public static void InMang(int[,] a)
    {
        int n = a.GetLength(0);
        int m = a.GetLength(1);
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(a[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    public static void TachChanLe(int[,] a, out int[] chan, out int[] le)
    {
        List<int> dsChan = new List<int>();
        List<int> dsLe = new List<int>();

        int n = a.GetLength(0);
        int m = a.GetLength(1);
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (a[i, j] % 2 == 0)
                    dsChan.Add(a[i, j]);
                else
                    dsLe.Add(a[i, j]);
            }
        }
        chan = dsChan.ToArray();
        le = dsLe.ToArray();
    }

    public static void Run()
    {
        Console.Write("Nhap n: ");
        int n = int.Parse(Console.ReadLine() ?? "0");
        Console.Write("Nhap m: ");
        int m = int.Parse(Console.ReadLine() ?? "0");

        int[,] a = SinhMang(n, m);
        Console.WriteLine("Mang A:");
        InMang(a);

        TachChanLe(a, out int[] chan, out int[] le);

        Console.Write("Cac so chan: ");
        for (int i = 0; i < chan.Length; i++)
            Console.Write(chan[i] + " ");
        Console.WriteLine();

        Console.Write("Cac so le: ");
        for (int i = 0; i < le.Length; i++)
            Console.Write(le[i] + " ");
        Console.WriteLine();
    }
}
