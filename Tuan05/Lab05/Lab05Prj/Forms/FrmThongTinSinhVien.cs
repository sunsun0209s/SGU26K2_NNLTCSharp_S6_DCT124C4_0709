using System;
using System.Text;
using System.Windows.Forms;

namespace Lab05Prj.Forms;

public partial class FrmThongTinSinhVien : Form
{
    public FrmThongTinSinhVien()
    {
        InitializeComponent();
    }

    private void FrmThongTinSinhVien_Load(object? sender, EventArgs e)
    {
        // 1. Nạp dữ liệu vào ComboBox dân tộc
        string[] danTocList = { "Kinh", "Hoa", "K'Me", "H'Mông", "Tày", "Dao", "Khác" };
        cboDanToc.Items.Clear();
        cboDanToc.Items.AddRange(danTocList);
        cboDanToc.SelectedIndex = 0;

        // 2. Thêm dữ liệu mẫu ban đầu để dễ quan sát
        ThemDongListView("Nguyễn Văn An", "SV001", "Nam", "Anh", "Kinh");
        ThemDongListView("Trần Thị Hoa", "SV002", "Nữ", "Pháp", "Hoa");
        ThemDongListView("Lê Hoàng Nam", "SV003", "Nam", "Anh, Hoa", "K'Me");
    }

    private void ThemDongListView(string hoTen, string maSV, string gioiTinh, string ngoaiNgu, string danToc)
    {
        ListViewItem item = new ListViewItem(hoTen);
        item.SubItems.Add(maSV);
        item.SubItems.Add(gioiTinh);
        item.SubItems.Add(ngoaiNgu);
        item.SubItems.Add(danToc);
        lsvSinhVien.Items.Add(item);
    }

    private bool KiemTraTrungMaSV(string maSV)
    {
        foreach (ListViewItem item in lsvSinhVien.Items)
        {
            if (string.Equals(item.SubItems[1].Text.Trim(), maSV.Trim(), StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
        }
        return false;
    }

    private string LayChuoiNgoaiNgu()
    {
        StringBuilder sb = new StringBuilder();
        if (chkAnh.Checked) sb.Append("Anh");
        if (chkPhap.Checked)
        {
            if (sb.Length > 0) sb.Append(", ");
            sb.Append("Pháp");
        }
        if (chkHoa.Checked)
        {
            if (sb.Length > 0) sb.Append(", ");
            sb.Append("Hoa");
        }
        return sb.Length > 0 ? sb.ToString() : "Không";
    }

    private void BtnThem_Click(object? sender, EventArgs e)
    {
        string hoTen = txtHoTen.Text.Trim();
        string maSV = txtMaSV.Text.Trim();

        if (string.IsNullOrWhiteSpace(hoTen))
        {
            MessageBox.Show("Vui lòng nhập Họ và Tên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtHoTen.Focus();
            return;
        }

        if (string.IsNullOrWhiteSpace(maSV))
        {
            MessageBox.Show("Vui lòng nhập Mã sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtMaSV.Focus();
            return;
        }

        // Quy tắc: Thêm không cho trùng mã sinh viên
        if (KiemTraTrungMaSV(maSV))
        {
            MessageBox.Show($"Mã sinh viên '{maSV}' đã tồn tại! Vui lòng nhập mã khác.", "Trùng mã sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtMaSV.Focus();
            txtMaSV.SelectAll();
            return;
        }

        string gioiTinh = radNam.Checked ? "Nam" : "Nữ";
        string ngoaiNgu = LayChuoiNgoaiNgu();
        string danToc = cboDanToc.Text;

        ThemDongListView(hoTen, maSV, gioiTinh, ngoaiNgu, danToc);

        MessageBox.Show("Thêm sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        LamMoiForm();
    }

    private void BtnXoa_Click(object? sender, EventArgs e)
    {
        XoaSinhVienDangChon();
    }

    private void MnuContextXoa_Click(object? sender, EventArgs e)
    {
        XoaSinhVienDangChon();
    }

    private void XoaSinhVienDangChon()
    {
        if (lsvSinhVien.SelectedItems.Count == 0)
        {
            MessageBox.Show("Vui lòng chọn một sinh viên trong danh sách để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        ListViewItem item = lsvSinhVien.SelectedItems[0];
        string maSV = item.SubItems[1].Text;
        string hoTen = item.SubItems[0].Text;

        var result = MessageBox.Show($"Bạn có chắc chắn muốn xóa sinh viên '{hoTen}' (MSSV: {maSV})?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (result == DialogResult.Yes)
        {
            item.Remove();
            LamMoiForm();
            MessageBox.Show("Đã xóa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    private void BtnSua_Click(object? sender, EventArgs e)
    {
        if (lsvSinhVien.SelectedItems.Count == 0)
        {
            MessageBox.Show("Vui lòng chọn sinh viên cần sửa trong danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        string hoTen = txtHoTen.Text.Trim();
        if (string.IsNullOrWhiteSpace(hoTen))
        {
            MessageBox.Show("Vui lòng nhập Họ và Tên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtHoTen.Focus();
            return;
        }

        // Quy tắc đề bài: Không cho sửa Mã sinh viên
        ListViewItem item = lsvSinhVien.SelectedItems[0];
        item.SubItems[0].Text = hoTen; // Họ tên
        // SubItems[1] giữ nguyên mã sinh viên cũ
        item.SubItems[2].Text = radNam.Checked ? "Nam" : "Nữ"; // Giới tính
        item.SubItems[3].Text = LayChuoiNgoaiNgu(); // Ngoại ngữ
        item.SubItems[4].Text = cboDanToc.Text; // Dân tộc

        MessageBox.Show("Cập nhật thông tin sinh viên thành công (Mã sinh viên được giữ nguyên)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void LsvSinhVien_SelectedIndexChanged(object? sender, EventArgs e)
    {
        if (lsvSinhVien.SelectedItems.Count > 0)
        {
            ListViewItem item = lsvSinhVien.SelectedItems[0];
            txtHoTen.Text = item.SubItems[0].Text;
            txtMaSV.Text = item.SubItems[1].Text;

            // Giữ cho mã SV không bị sửa trực tiếp khi đang chọn dòng
            txtMaSV.ReadOnly = true;

            string gioiTinh = item.SubItems[2].Text;
            radNam.Checked = (gioiTinh == "Nam");
            radNu.Checked = (gioiTinh == "Nữ");

            string ngoaiNgu = item.SubItems[3].Text;
            chkAnh.Checked = ngoaiNgu.Contains("Anh");
            chkPhap.Checked = ngoaiNgu.Contains("Pháp");
            chkHoa.Checked = ngoaiNgu.Contains("Hoa");

            string danToc = item.SubItems[4].Text;
            int idx = cboDanToc.FindStringExact(danToc);
            if (idx >= 0) cboDanToc.SelectedIndex = idx;
        }
        else
        {
            txtMaSV.ReadOnly = false;
        }
    }

    private void LamMoiForm()
    {
        txtHoTen.Clear();
        txtMaSV.Clear();
        txtMaSV.ReadOnly = false;
        radNam.Checked = true;
        chkAnh.Checked = false;
        chkPhap.Checked = false;
        chkHoa.Checked = false;
        if (cboDanToc.Items.Count > 0) cboDanToc.SelectedIndex = 0;
        txtHoTen.Focus();
    }

    private void FrmThongTinSinhVien_FormClosing(object? sender, FormClosingEventArgs e)
    {
        // Quy tắc: Hỏi xác nhận trước khi đóng Form
        var r = MessageBox.Show("Bạn có chắc chắn muốn đóng form này không?", "Xác nhận đóng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (r == DialogResult.No)
        {
            e.Cancel = true;
        }
    }
}
