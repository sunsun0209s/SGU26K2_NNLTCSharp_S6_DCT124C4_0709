namespace Lab05Prj.Models;

public class TuDienItem
{
    public string TiengAnh { get; set; } = string.Empty;
    public string TiengViet { get; set; } = string.Empty;

    public TuDienItem(string en, string vi)
    {
        TiengAnh = en;
        TiengViet = vi;
    }
}
