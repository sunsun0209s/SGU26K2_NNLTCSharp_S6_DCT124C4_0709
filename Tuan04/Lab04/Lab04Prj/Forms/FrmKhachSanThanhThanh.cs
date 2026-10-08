using System;
using System.Windows.Forms;

namespace Lab04Prj.Forms;

public partial class FrmKhachSanThanhThanh : Form
{
    private long tongDoanhThuNgay = 0;
    private int tongLuotKhachNgay = 0;
    private long tienHienTai = 0;

    public FrmKhachSanThanhThanh()
    {
        InitializeComponent();
    }

    private void ThongTin_Changed(object? sender, EventArgs e) => KiemTraNhapDu();

    private void TxtSoNgay_KeyPress(object? sender, KeyPressEventArgs e)
    {
        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
        {
            e.Handled = true;
        }
    }

    private void BtnThoat_Click(object? sender, EventArgs e) => this.Close();

    private void FrmKhachSanThanhThanh_FormClosing(object? sender, FormClosingEventArgs e)
    {
        var r = MessageBox.Show("Bạn có chắc chắn muốn thoát khỏi chương trình?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (r == DialogResult.No)
        {
            e.Cancel = true;
        }
    }

    private void KiemTraNhapDu()
    {
        bool coTen = !string.IsNullOrWhiteSpace(txtHoTen.Text);
        bool coNgay = int.TryParse(txtSoNgay.Text.Trim(), out int ngay) && ngay > 0;
        bool coPhong = rdoDon.Checked || rdoDoi.Checked || rdoBa.Checked;

        btnThanhToan.Enabled = coTen && coNgay && coPhong;
    }

    private void BtnThanhToan_Click(object? sender, EventArgs e)
    {
        int soNgay = int.Parse(txtSoNgay.Text.Trim());

        // Giá phòng
        long giaPhong = 0;
        if (rdoDon.Checked) giaPhong = 300000;
        else if (rdoDoi.Checked) giaPhong = 350000;
        else if (rdoBa.Checked) giaPhong = 400000;

        // Tiện nghi (tính 1 lần theo bài học: 10k/loại)
        long tienTienNghi = 0;
        if (chkTivi.Checked) tienTienNghi += 10000;
        if (chkInternet.Checked) tienTienNghi += 10000;
        if (chkNuocNong.Checked) tienTienNghi += 10000;

        // Dịch vụ
        long tienDichVu = 0;
        if (chkKaraoke.Checked) tienDichVu += 50000;
        if (chkAnSang.Checked) tienDichVu += (15000 * soNgay);

        long tong = (giaPhong * soNgay) + tienTienNghi + tienDichVu;
        tienHienTai = tong;

        txtThanhTien.Text = $"{tienHienTai:N0} VNĐ";
        MessageBox.Show($"Khách hàng: {txtHoTen.Text.Trim()}\nSố ngày ở: {soNgay}\nTổng tiền thanh toán: {tienHienTai:N0} VNĐ", "Hóa đơn thanh toán", MessageBoxButtons.OK, MessageBoxIcon.Information);

        btnNhapMoi.Enabled = true;
        btnTongKet.Enabled = true;
    }

    private void BtnNhapMoi_Click(object? sender, EventArgs e)
    {
        tongDoanhThuNgay += tienHienTai;
        tongLuotKhachNgay++;

        txtHoTen.Clear();
        txtDiaChi.Clear();
        txtSoNgay.Clear();
        txtThanhTien.Text = "0 VNĐ";

        rdoDon.Checked = false;
        rdoDoi.Checked = false;
        rdoBa.Checked = false;

        chkTivi.Checked = false;
        chkInternet.Checked = false;
        chkNuocNong.Checked = false;

        chkKaraoke.Checked = false;
        chkAnSang.Checked = false;

        tienHienTai = 0;
        btnThanhToan.Enabled = false;
        btnNhapMoi.Enabled = false;

        txtHoTen.Focus();
    }

    private void BtnTongKet_Click(object? sender, EventArgs e)
    {
        txtTongLuot.Text = tongLuotKhachNgay.ToString();
        txtTongTien.Text = $"{tongDoanhThuNgay:N0} VNĐ";
        MessageBox.Show($"Tổng kết ngày:\n- Số lượt khách: {tongLuotKhachNgay}\n- Tổng doanh thu: {tongDoanhThuNgay:N0} VNĐ", "Tổng Kết", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
