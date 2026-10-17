using System;
using System.Linq;
using System.Windows.Forms;

namespace Lab05Prj.Forms;

public partial class FrmComboboxUocSo : Form
{
    public FrmComboboxUocSo()
    {
        InitializeComponent();
    }

    private void BtnCapNhat_Click(object? sender, EventArgs e)
    {
        string input = txtNhapSo.Text.Trim();
        if (!int.TryParse(input, out int so) || so <= 0)
        {
            MessageBox.Show("Vui lòng nhập một số nguyên dương hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtNhapSo.Focus();
            return;
        }

        string soStr = so.ToString();
        if (cboSo.Items.Contains(soStr))
        {
            MessageBox.Show($"Số {so} đã tồn tại trong danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cboSo.SelectedItem = soStr;
            txtNhapSo.Clear();
            txtNhapSo.Focus();
            return;
        }

        cboSo.Items.Add(soStr);
        cboSo.SelectedItem = soStr;
        txtNhapSo.Clear();
        txtNhapSo.Focus();
    }

    private void CboSo_SelectedIndexChanged(object? sender, EventArgs e)
    {
        lstUocSo.Items.Clear();
        if (cboSo.SelectedItem == null) return;

        if (int.TryParse(cboSo.SelectedItem.ToString(), out int n) && n > 0)
        {
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    lstUocSo.Items.Add(i);
                }
            }
        }
    }

    private void BtnTongUocSo_Click(object? sender, EventArgs e)
    {
        if (lstUocSo.Items.Count == 0)
        {
            MessageBox.Show("Danh sách ước số đang trống! Hãy chọn một số trước.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        long tong = 0;
        foreach (var item in lstUocSo.Items)
        {
            if (int.TryParse(item.ToString(), out int val))
            {
                tong += val;
            }
        }

        MessageBox.Show($"Tổng các ước số của {cboSo.SelectedItem} là: {tong}", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void BtnSoLuongChan_Click(object? sender, EventArgs e)
    {
        if (lstUocSo.Items.Count == 0)
        {
            MessageBox.Show("Danh sách ước số đang trống! Hãy chọn một số trước.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        int demChan = 0;
        foreach (var item in lstUocSo.Items)
        {
            if (int.TryParse(item.ToString(), out int val) && val % 2 == 0)
            {
                demChan++;
            }
        }

        MessageBox.Show($"Số lượng các ước số chẵn của {cboSo.SelectedItem} là: {demChan}", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private bool KiemTraNguyenTo(int n)
    {
        if (n < 2) return false;
        for (int i = 2; i * i <= n; i++)
        {
            if (n % i == 0) return false;
        }
        return true;
    }

    private void BtnSoLuongNguyenTo_Click(object? sender, EventArgs e)
    {
        if (lstUocSo.Items.Count == 0)
        {
            MessageBox.Show("Danh sách ước số đang trống! Hãy chọn một số trước.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        int demNT = 0;
        foreach (var item in lstUocSo.Items)
        {
            if (int.TryParse(item.ToString(), out int val) && KiemTraNguyenTo(val))
            {
                demNT++;
            }
        }

        MessageBox.Show($"Số lượng các ước số nguyên tố của {cboSo.SelectedItem} là: {demNT}", "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void BtnThoat_Click(object? sender, EventArgs e) => this.Close();

    private void FrmComboboxUocSo_FormClosing(object? sender, FormClosingEventArgs e)
    {
        var result = MessageBox.Show("Bạn có muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (result == DialogResult.No)
        {
            e.Cancel = true;
        }
    }
}
