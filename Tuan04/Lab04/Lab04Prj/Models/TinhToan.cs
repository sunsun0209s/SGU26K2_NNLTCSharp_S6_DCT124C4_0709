namespace Lab04Prj.Models;

public class TinhToan
{
    private float _a;
    private float _b;

    public float A
    {
        get => _a;
        set => _a = value;
    }

    public float B
    {
        get => _b;
        set => _b = value;
    }

    public TinhToan()
    {
        _a = 0;
        _b = 0;
    }

    public TinhToan(float a, float b)
    {
        _a = a;
        _b = b;
    }

    public float Cong() => _a + _b;
    public float Tru() => _a - _b;
    public float Nhan() => _a * _b;
    public float Chia()
    {
        if (_b == 0) throw new DivideByZeroException("Không thể chia cho số 0!");
        return _a / _b;
    }
}
