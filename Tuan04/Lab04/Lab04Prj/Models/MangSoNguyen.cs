namespace Lab04Prj.Models;

public class MangSoNguyen
{
    private List<int> _elements = new();

    public IReadOnlyList<int> Elements => _elements.AsReadOnly();
    public int Length => _elements.Count;

    public MangSoNguyen() { }

    public MangSoNguyen(IEnumerable<int> items)
    {
        _elements = new List<int>(items);
    }

    public void NhapTuChuoi(string chuoi)
    {
        _elements.Clear();
        if (string.IsNullOrWhiteSpace(chuoi)) return;

        // Cho phép phân tách bởi dấu cách, dấu phẩy, chấm phẩy
        var tokens = chuoi.Split(new[] { ' ', ',', ';', '\t' }, StringSplitOptions.RemoveEmptyEntries);
        foreach (var t in tokens)
        {
            if (int.TryParse(t.Trim(), out int val))
            {
                _elements.Add(val);
            }
        }
    }

    public string XuatChuoi()
    {
        return string.Join(" ", _elements);
    }

    public void SapXepTang()
    {
        _elements.Sort();
    }

    public void SapXepGiam()
    {
        _elements.Sort((a, b) => b.CompareTo(a));
    }

    public int TimGiaTri(int giaTri)
    {
        return _elements.IndexOf(giaTri);
    }

    public int? LayTaiViTri(int index)
    {
        if (index >= 0 && index < _elements.Count)
            return _elements[index];
        return null;
    }

    public bool ThemPhanTu(int giaTri, int viTri)
    {
        if (viTri < 0 || viTri > _elements.Count) return false;
        _elements.Insert(viTri, giaTri);
        return true;
    }

    public bool XoaTheoGiaTri(int giaTri)
    {
        return _elements.Remove(giaTri);
    }

    public bool XoaTheoViTri(int viTri)
    {
        if (viTri >= 0 && viTri < _elements.Count)
        {
            _elements.RemoveAt(viTri);
            return true;
        }
        return false;
    }

    public long Tong() => _elements.Sum(x => (long)x);
    public long TongChan() => _elements.Where(x => x % 2 == 0).Sum(x => (long)x);
    public long TongLe() => _elements.Where(x => x % 2 != 0).Sum(x => (long)x);

    public int? Max() => _elements.Count > 0 ? _elements.Max() : null;
    public int? Min() => _elements.Count > 0 ? _elements.Min() : null;

    public bool ThayTheTheoGiaTri(int giaTriCu, int giaTriMoi)
    {
        int idx = _elements.IndexOf(giaTriCu);
        if (idx >= 0)
        {
            _elements[idx] = giaTriMoi;
            return true;
        }
        return false;
    }

    public bool ThayTheTheoViTri(int viTri, int giaTriMoi)
    {
        if (viTri >= 0 && viTri < _elements.Count)
        {
            _elements[viTri] = giaTriMoi;
            return true;
        }
        return false;
    }
}
