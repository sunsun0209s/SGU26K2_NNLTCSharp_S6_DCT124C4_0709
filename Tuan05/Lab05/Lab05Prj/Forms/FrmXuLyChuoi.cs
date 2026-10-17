using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Lab05Prj.Forms;

public partial class FrmXuLyChuoi : Form
{
    private static readonly string[] HO = { "Lê", "Nguyễn", "Lý", "Trần", "Lâm", "Hồ", "Lai", "Huỳnh", "La" };
    private static readonly string[] TENLOT = { "Quang", "Thành", "Ngọc", "Anh", "Xuân", "Bảo", "Cẩm", "Thị", "Kim", "Thái", "Hồng" };
    private static readonly string[] TEN = { "Hà", "Danh", "Sơn", "Mai", "Thắng", "Kỳ", "Thành", "Lâm", "Tâm", "Phụng", "Thắm" };

    public FrmXuLyChuoi()
    {
        InitializeComponent();
    }

    private void BtnNgauNhien_Click(object? sender, EventArgs e)
    {
        lstHoTen.Items.Clear();
        var rnd = new Random();
        for (int i = 0; i < 50; i++)
        {
            string h = HO[rnd.Next(HO.Length)];
            string l = TENLOT[rnd.Next(TENLOT.Length)];
            string t = TEN[rnd.Next(TEN.Length)];
            lstHoTen.Items.Add($"{h} {l} {t}");
        }
    }

    private void BtnXoaDangChon_Click(object? sender, EventArgs e)
    {
        var selectedList = lstHoTen.SelectedIndices.Cast<int>().OrderByDescending(idx => idx).ToList();
        if (selectedList.Count == 0)
        {
            MessageBox.Show("Vui lòng chọn ít nhất một phần tử để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        foreach (int idx in selectedList)
        {
            lstHoTen.Items.RemoveAt(idx);
        }
    }

    private void BtnXoaTenSon_Click(object? sender, EventArgs e)
    {
        int count = 0;
        for (int i = lstHoTen.Items.Count - 1; i >= 0; i--)
        {
            string item = lstHoTen.Items[i]?.ToString()?.Trim() ?? string.Empty;
            if (item.EndsWith("Sơn", StringComparison.OrdinalIgnoreCase))
            {
                lstHoTen.Items.RemoveAt(i);
                count++;
            }
        }
        MessageBox.Show($"Đã xóa {count} người có tên là 'Sơn'!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void BtnXoaHoLe_Click(object? sender, EventArgs e)
    {
        int count = 0;
        for (int i = lstHoTen.Items.Count - 1; i >= 0; i--)
        {
            string item = lstHoTen.Items[i]?.ToString()?.Trim() ?? string.Empty;
            if (item.StartsWith("Lê ", StringComparison.OrdinalIgnoreCase))
            {
                lstHoTen.Items.RemoveAt(i);
                count++;
            }
        }
        MessageBox.Show($"Đã xóa {count} người có họ là 'Lê'!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void BtnInHoa_Click(object? sender, EventArgs e)
    {
        var indices = lstHoTen.SelectedIndices.Cast<int>().ToList();
        if (indices.Count == 0)
        {
            MessageBox.Show("Vui lòng chọn các phần tử cần in HOA!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        foreach (int idx in indices)
        {
            string text = lstHoTen.Items[idx]?.ToString() ?? string.Empty;
            lstHoTen.Items[idx] = text.ToUpper();
        }
    }

    private void BtnInThuong_Click(object? sender, EventArgs e)
    {
        var indices = lstHoTen.SelectedIndices.Cast<int>().ToList();
        if (indices.Count == 0)
        {
            MessageBox.Show("Vui lòng chọn các phần tử cần in thường!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        foreach (int idx in indices)
        {
            string text = lstHoTen.Items[idx]?.ToString() ?? string.Empty;
            lstHoTen.Items[idx] = text.ToLower();
        }
    }

    private void BtnTitleCase_Click(object? sender, EventArgs e)
    {
        var indices = lstHoTen.SelectedIndices.Cast<int>().ToList();
        if (indices.Count == 0)
        {
            MessageBox.Show("Vui lòng chọn các phần tử cần viết hoa đầu mỗi từ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        var textInfo = CultureInfo.CurrentCulture.TextInfo;
        foreach (int idx in indices)
        {
            string text = lstHoTen.Items[idx]?.ToString() ?? string.Empty;
            lstHoTen.Items[idx] = textInfo.ToTitleCase(text.ToLower());
        }
    }

    private void BtnXoaTatCa_Click(object? sender, EventArgs e)
    {
        if (lstHoTen.Items.Count == 0) return;

        var result = MessageBox.Show("Bạn có chắc muốn xóa tất cả các phần tử?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (result == DialogResult.Yes)
        {
            lstHoTen.Items.Clear();
        }
    }

    private void LstHoTen_DoubleClick(object? sender, EventArgs e)
    {
        int index = lstHoTen.SelectedIndex;
        if (index >= 0)
        {
            string currentName = lstHoTen.Items[index]?.ToString() ?? string.Empty;
            using var dlg = new FrmInputNameDialog(currentName);
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                lstHoTen.Items[index] = dlg.TenNhap;
            }
        }
    }

    private void FrmXuLyChuoi_FormClosing(object? sender, FormClosingEventArgs e)
    {
        var result = MessageBox.Show("Bạn có muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (result == DialogResult.No)
        {
            e.Cancel = true;
        }
    }
}
