using System;
using System.Globalization;
using System.Windows.Forms;

namespace Lab05Prj.Forms;

public partial class FrmQuanLyTaiKhoan : Form
{
    private readonly CultureInfo _vnCulture = new CultureInfo("vi-VN");

    public FrmQuanLyTaiKhoan()
    {
        InitializeComponent();
    }

    private void FrmQuanLyTaiKhoan_Load(object? sender, EventArgs e)
    {
        // Khởi tạo trạng thái ban đầu theo yêu cầu
        btnThem.Text = "Thêm";
        btnThem.Enabled = true;
        btnLuu.Enabled = false;
        btnXoa.Enabled = false;
        btnThoat.Enabled = true;

        // Nạp hai mẫu tin ban đầu như hình chụp trong tài liệu thực hành
        ThemTaiKhoanListView("0160901609", "Nguyễn Văn An", "TPHCM", 5200000);
        ThemTaiKhoanListView("0160901610", "Trần Văn Anh", "Tây Ninh", 1200000);

        CapNhatSTTVaTongTien();
    }

    private void ThemTaiKhoanListView(string soTK, string tenKH, string diaChi, decimal soTien)
    {
        ListViewItem item = new ListViewItem((lsvTaiKhoan.Items.Count + 1).ToString());
        item.SubItems.Add(soTK);
        item.SubItems.Add(tenKH);
        item.SubItems.Add(diaChi);
        item.SubItems.Add(soTien.ToString("#,##0", _vnCulture));
        item.Tag = soTien;
        lsvTaiKhoan.Items.Add(item);
    }

    private void CapNhatSTTVaTongTien()
    {
        decimal tongTien = 0;
        for (int i = 0; i < lsvTaiKhoan.Items.Count; i++)
        {
            ListViewItem item = lsvTaiKhoan.Items[i];
            item.SubItems[0].Text = (i + 1).ToString();

            if (item.Tag is decimal tien)
            {
                tongTien += tien;
            }
            else if (decimal.TryParse(item.SubItems[4].Text.Replace(".", "").Replace(",", "").Trim(), out decimal val))
            {
                tongTien += val;
            }
        }
        txtTongTien.Text = tongTien.ToString("#,##0", _vnCulture);
    }

    private bool KiemTraTrungSoTaiKhoan(string soTK)
    {
        foreach (ListViewItem item in lsvTaiKhoan.Items)
        {
            if (string.Equals(item.SubItems[1].Text.Trim(), soTK.Trim(), StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
        }
        return false;
    }

    private void XoaTrangNhapLieu()
    {
        txtSoTaiKhoan.Clear();
        txtTenKhachHang.Clear();
        txtDiaChi.Clear();
        txtSoTien.Clear();
    }

    private void BtnThem_Click(object? sender, EventArgs e)
    {
        if (btnThem.Text == "Thêm")
        {
            btnThem.Text = "Hủy";
            btnLuu.Enabled = true;
            btnXoa.Enabled = false;

            XoaTrangNhapLieu();
            txtSoTaiKhoan.Focus();
        }
        else
        {
            // Trạng thái "Hủy" -> khôi phục về trạng thái ban đầu
            btnThem.Text = "Thêm";
            btnLuu.Enabled = false;
            btnXoa.Enabled = false;
            XoaTrangNhapLieu();
        }
    }

    private void BtnLuu_Click(object? sender, EventArgs e)
    {
        string soTK = txtSoTaiKhoan.Text.Trim();
        string tenKH = txtTenKhachHang.Text.Trim();
        string diaChi = txtDiaChi.Text.Trim();
        string soTienStr = txtSoTien.Text.Trim().Replace(".", "").Replace(",", "");

        if (string.IsNullOrWhiteSpace(soTK))
        {
            MessageBox.Show("Vui lòng nhập Số tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtSoTaiKhoan.Focus();
            return;
        }

        if (string.IsNullOrWhiteSpace(tenKH))
        {
            MessageBox.Show("Vui lòng nhập Tên khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtTenKhachHang.Focus();
            return;
        }

        if (string.IsNullOrWhiteSpace(diaChi))
        {
            MessageBox.Show("Vui lòng nhập Địa chỉ khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtDiaChi.Focus();
            return;
        }

        if (!decimal.TryParse(soTienStr, out decimal soTien) || soTien < 0)
        {
            MessageBox.Show("Số tiền phải là số nguyên dương hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtSoTien.Focus();
            txtSoTien.SelectAll();
            return;
        }

        if (KiemTraTrungSoTaiKhoan(soTK))
        {
            MessageBox.Show($"Số tài khoản '{soTK}' đã tồn tại! Vui lòng kiểm tra lại.", "Trùng số tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtSoTaiKhoan.Focus();
            txtSoTaiKhoan.SelectAll();
            return;
        }

        ThemTaiKhoanListView(soTK, tenKH, diaChi, soTien);
        CapNhatSTTVaTongTien();

        MessageBox.Show("Lưu thông tin tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        // Đưa button về trạng thái ban đầu
        btnThem.Text = "Thêm";
        btnLuu.Enabled = false;
        XoaTrangNhapLieu();
        txtSoTaiKhoan.Focus();
    }

    private void BtnXoa_Click(object? sender, EventArgs e)
    {
        if (lsvTaiKhoan.SelectedItems.Count == 0)
        {
            MessageBox.Show("Vui lòng chọn một tài khoản trong danh sách để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        ListViewItem item = lsvTaiKhoan.SelectedItems[0];
        string soTK = item.SubItems[1].Text;
        string tenKH = item.SubItems[2].Text;

        var r = MessageBox.Show($"Bạn có chắc chắn muốn xóa tài khoản '{soTK}' của khách hàng '{tenKH}'?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (r == DialogResult.Yes)
        {
            item.Remove();
            CapNhatSTTVaTongTien();
            XoaTrangNhapLieu();
            btnXoa.Enabled = false;
            MessageBox.Show("Đã xóa tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    private void LsvTaiKhoan_SelectedIndexChanged(object? sender, EventArgs e)
    {
        if (lsvTaiKhoan.SelectedItems.Count > 0)
        {
            ListViewItem item = lsvTaiKhoan.SelectedItems[0];
            txtSoTaiKhoan.Text = item.SubItems[1].Text;
            txtTenKhachHang.Text = item.SubItems[2].Text;
            txtDiaChi.Text = item.SubItems[3].Text;
            txtSoTien.Text = item.SubItems[4].Text;

            // Bật nút Xóa khi có một mẫu tin được chọn
            btnXoa.Enabled = true;
        }
        else
        {
            btnXoa.Enabled = false;
        }
    }

    private void BtnThoat_Click(object? sender, EventArgs e)
    {
        var r = MessageBox.Show("Bạn có muốn thoát chương trình quản lý tài khoản?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (r == DialogResult.Yes)
        {
            this.Close();
        }
    }
}
