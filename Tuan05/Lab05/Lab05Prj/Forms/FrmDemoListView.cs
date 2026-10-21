using System;
using System.Windows.Forms;

namespace Lab05Prj.Forms;

public partial class FrmDemoListView : Form
{
    public FrmDemoListView()
    {
        InitializeComponent();
    }

    private bool KiemTraTrungMaSV(string maSV)
    {
        foreach (ListViewItem item in lstv1.Items)
        {
            if (string.Equals(item.Text.Trim(), maSV.Trim(), StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
        }
        return false;
    }

    private void BtnThem_Click(object? sender, EventArgs e)
    {
        string maSV = txtMSSV.Text.Trim();
        string hoTen = txtHoTen.Text.Trim();

        if (string.IsNullOrWhiteSpace(maSV) || string.IsNullOrWhiteSpace(hoTen))
        {
            MessageBox.Show("Vui lòng nhập đầy đủ mã sinh viên và họ tên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtMSSV.Focus();
            return;
        }

        if (KiemTraTrungMaSV(maSV))
        {
            MessageBox.Show("Mã sinh viên đã tồn tại trong danh sách!", "Cảnh báo trùng mã", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtMSSV.Focus();
            txtMSSV.SelectAll();
            return;
        }

        ListViewItem item = new ListViewItem(maSV);
        item.SubItems.Add(hoTen);
        lstv1.Items.Add(item);

        txtMSSV.Clear();
        txtHoTen.Clear();
        txtMSSV.Focus();
    }

    private void BtnXoa_Click(object? sender, EventArgs e)
    {
        if (lstv1.SelectedItems.Count == 0)
        {
            MessageBox.Show("Vui lòng chọn ít nhất một sinh viên để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        foreach (ListViewItem item in lstv1.SelectedItems)
        {
            item.Remove();
        }

        txtMSSV.Clear();
        txtHoTen.Clear();
    }

    private void BtnSua_Click(object? sender, EventArgs e)
    {
        if (lstv1.FocusedItem != null && lstv1.FocusedItem.Index >= 0)
        {
            string maSV = txtMSSV.Text.Trim();
            string hoTen = txtHoTen.Text.Trim();

            if (string.IsNullOrWhiteSpace(maSV) || string.IsNullOrWhiteSpace(hoTen))
            {
                MessageBox.Show("Vui lòng nhập thông tin để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ListViewItem item = lstv1.FocusedItem;

            // Kiểm tra nếu đổi mã SV thì mã mới không được trùng với sinh viên khác
            if (!string.Equals(item.Text.Trim(), maSV, StringComparison.OrdinalIgnoreCase) && KiemTraTrungMaSV(maSV))
            {
                MessageBox.Show("Mã sinh viên mới bị trùng với sinh viên khác trong danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            item.SubItems[0].Text = maSV;
            item.SubItems[1].Text = hoTen;
        }
        else
        {
            MessageBox.Show("Vui lòng chọn sinh viên cần sửa trong danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    private void Lstv1_SelectedIndexChanged(object? sender, EventArgs e)
    {
        if (lstv1.SelectedItems.Count > 0)
        {
            ListViewItem item = lstv1.SelectedItems[0];
            txtMSSV.Text = item.SubItems[0].Text;
            txtHoTen.Text = item.SubItems.Count > 1 ? item.SubItems[1].Text : string.Empty;
        }
    }
}
