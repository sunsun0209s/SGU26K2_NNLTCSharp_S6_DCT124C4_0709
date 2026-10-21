using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab05Prj.Forms;

public partial class FrmQuanLyHocVien : Form
{
    public FrmQuanLyHocVien()
    {
        InitializeComponent();
    }

    private void FrmQuanLyHocVien_Load(object? sender, EventArgs e)
    {
        // Nạp dữ liệu mẫu ban đầu theo hình minh họa trong tài liệu
        lstLopA.Items.AddRange(new object[] { "Trần Hùng", "Nguyễn Hưng", "Lâm Tứ" });
        lstLopB.Items.AddRange(new object[] { "Tuấn Hưng", "Hồng Ngọc", "Anh Minh", "Bảo Lâm" });
    }

    private void MnuNhapHocVien_Click(object? sender, EventArgs e)
    {
        using var dlg = new FrmNhapHocVienDialog();
        if (dlg.ShowDialog(this) == DialogResult.OK)
        {
            if (dlg.TenLop == "Lớp A")
            {
                lstLopA.Items.Add(dlg.HoTen);
            }
            else
            {
                lstLopB.Items.Add(dlg.HoTen);
            }
            MessageBox.Show($"Đã thêm học viên '{dlg.HoTen}' vào {dlg.TenLop} thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    private void MnuChuyenSangLopB_Click(object? sender, EventArgs e)
    {
        // Yêu cầu: Chuyển các mục đang chọn trong Lớp A sang Lớp B
        // Lưu ý: Nếu không có học viên nào được chọn thì thông báo yêu cầu chọn trước
        if (lstLopA.SelectedItems.Count == 0)
        {
            MessageBox.Show("Vui lòng chọn học viên trong Lớp A trước khi thực hiện chuyển sang Lớp B!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        List<object> itemsToMove = new List<object>();
        foreach (var item in lstLopA.SelectedItems)
        {
            itemsToMove.Add(item);
        }

        foreach (var item in itemsToMove)
        {
            lstLopB.Items.Add(item);
            lstLopA.Items.Remove(item);
        }
    }

    private void MnuChuyenSangLopA_Click(object? sender, EventArgs e)
    {
        // Yêu cầu: Chuyển các mục đang chọn trong Lớp B sang Lớp A
        // Lưu ý: Nếu không có học viên nào được chọn thì thông báo yêu cầu chọn trước
        if (lstLopB.SelectedItems.Count == 0)
        {
            MessageBox.Show("Vui lòng chọn học viên trong Lớp B trước khi thực hiện chuyển sang Lớp A!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        List<object> itemsToMove = new List<object>();
        foreach (var item in lstLopB.SelectedItems)
        {
            itemsToMove.Add(item);
        }

        foreach (var item in itemsToMove)
        {
            lstLopA.Items.Add(item);
            lstLopB.Items.Remove(item);
        }
    }

    private void MnuXoaHocVien_Click(object? sender, EventArgs e)
    {
        // Yêu cầu: Xóa tất cả các học viên đang chọn trong Lớp A và Lớp B
        if (lstLopA.SelectedItems.Count == 0 && lstLopB.SelectedItems.Count == 0)
        {
            MessageBox.Show("Vui lòng chọn ít nhất một học viên trong Lớp A hoặc Lớp B để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var r = MessageBox.Show("Bạn có chắc chắn muốn xóa các học viên đang chọn?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (r == DialogResult.Yes)
        {
            List<object> listA = new List<object>();
            foreach (var item in lstLopA.SelectedItems) listA.Add(item);
            foreach (var item in listA) lstLopA.Items.Remove(item);

            List<object> listB = new List<object>();
            foreach (var item in lstLopB.SelectedItems) listB.Add(item);
            foreach (var item in listB) lstLopB.Items.Remove(item);

            MessageBox.Show("Đã xóa các học viên được chọn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    private void MnuKetThuc_Click(object? sender, EventArgs e)
    {
        // Yêu cầu: Khi click vào mục kết thúc thì xuất hiện một MessageBox hỏi người sử dụng sau đó mới quyết định có dừng chương trình hay không
        var result = MessageBox.Show("Bạn có thực sự muốn kết thúc chương trình quản lý học viên không?", "Xác nhận kết thúc", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (result == DialogResult.Yes)
        {
            this.Close();
        }
    }
}
