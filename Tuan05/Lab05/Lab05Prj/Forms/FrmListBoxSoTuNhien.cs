using System;
using System.Linq;
using System.Windows.Forms;

namespace Lab05Prj.Forms;

public partial class FrmListBoxSoTuNhien : Form
{
    public FrmListBoxSoTuNhien()
    {
        InitializeComponent();
    }

    private void FrmListBoxSoTuNhien_Load(object? sender, EventArgs e)
    {
        lstSo.Items.Clear();
    }

    private void BtnNhap_Click(object? sender, EventArgs e)
    {
        string input = txtNhapSo.Text.Trim();
        if (int.TryParse(input, out int val) && val >= 0)
        {
            lstSo.Items.Add(val);
            txtNhapSo.Clear();
            txtNhapSo.Focus();
        }
        else
        {
            MessageBox.Show("Vui lòng nhập một số tự nhiên hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtNhapSo.SelectAll();
            txtNhapSo.Focus();
        }
    }

    private void BtnTong_Click(object? sender, EventArgs e)
    {
        if (lstSo.Items.Count == 0)
        {
            MessageBox.Show("Danh sách đang trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        long tong = 0;
        foreach (var item in lstSo.Items)
        {
            if (int.TryParse(item.ToString(), out int val))
            {
                tong += val;
            }
        }

        MessageBox.Show($"Tổng các phần tử trong List: {tong}", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void BtnXoaDauCuoi_Click(object? sender, EventArgs e)
    {
        if (lstSo.Items.Count == 0) return;

        if (lstSo.Items.Count == 1)
        {
            lstSo.Items.RemoveAt(0);
        }
        else
        {
            lstSo.Items.RemoveAt(lstSo.Items.Count - 1); // xóa cuối trước để không ảnh hưởng index đầu
            lstSo.Items.RemoveAt(0);
        }
    }

    private void BtnXoaDangChon_Click(object? sender, EventArgs e)
    {
        var indices = lstSo.SelectedIndices.Cast<int>().OrderByDescending(i => i).ToList();
        if (indices.Count == 0)
        {
            MessageBox.Show("Vui lòng chọn ít nhất một phần tử để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        foreach (int idx in indices)
        {
            lstSo.Items.RemoveAt(idx);
        }
    }

    private void BtnTang2_Click(object? sender, EventArgs e)
    {
        for (int i = 0; i < lstSo.Items.Count; i++)
        {
            if (int.TryParse(lstSo.Items[i]?.ToString(), out int val))
            {
                lstSo.Items[i] = val + 2;
            }
        }
    }

    private void BtnBinhPhuong_Click(object? sender, EventArgs e)
    {
        for (int i = 0; i < lstSo.Items.Count; i++)
        {
            if (long.TryParse(lstSo.Items[i]?.ToString(), out long val))
            {
                lstSo.Items[i] = val * val;
            }
        }
    }

    private void BtnChonSoChan_Click(object? sender, EventArgs e)
    {
        lstSo.ClearSelected();
        for (int i = 0; i < lstSo.Items.Count; i++)
        {
            if (int.TryParse(lstSo.Items[i]?.ToString(), out int val) && val % 2 == 0)
            {
                lstSo.SetSelected(i, true);
            }
        }
    }

    private void BtnChonSoLe_Click(object? sender, EventArgs e)
    {
        lstSo.ClearSelected();
        for (int i = 0; i < lstSo.Items.Count; i++)
        {
            if (int.TryParse(lstSo.Items[i]?.ToString(), out int val) && val % 2 != 0)
            {
                lstSo.SetSelected(i, true);
            }
        }
    }

    private void BtnKetThuc_Click(object? sender, EventArgs e) => this.Close();

    private void FrmListBoxSoTuNhien_FormClosing(object? sender, FormClosingEventArgs e)
    {
        var result = MessageBox.Show("Bạn có muốn kết thúc chương trình?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (result == DialogResult.No)
        {
            e.Cancel = true;
        }
    }
}
