using System;
using System.Windows.Forms;

namespace Lab04Prj.Forms;

public partial class FrmCafeSinhVien : Form
{
    private long tongTienNgay = 0;
    private int tongKhachNgay = 0;
    private long tienHienTai = 0;

    public FrmCafeSinhVien()
    {
        InitializeComponent();
    }

    private void ThongTin_Changed(object? sender, EventArgs e) => KiemTraNhapDu();

    private void TxtSoKhach_KeyPress(object? sender, KeyPressEventArgs e)
    {
        if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
        {
            e.Handled = true;
        }
    }

    private void BtnThoat_Click(object? sender, EventArgs e) => this.Close();

    private void FrmCafeSinhVien_FormClosing(object? sender, FormClosingEventArgs e)
    {
        var r = MessageBox.Show("Bạn có chắc chắn muốn thoát khỏi chương trình?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (r == DialogResult.No)
        {
            e.Cancel = true;
        }
    }

    private void KiemTraNhapDu()
    {
        bool coTen = !string.IsNullOrWhiteSpace(txtTenKhach.Text);
        bool coKhach = int.TryParse(txtSoKhach.Text.Trim(), out int sk) && sk > 0;
        bool coNuoc = rdoCafeDen.Checked || rdoCafeDa.Checked || rdoCafeSua.Checked || rdoCafeSuaDa.Checked || rdoCafeKem.Checked;

        btnTinhTien.Enabled = coTen && coKhach && coNuoc;
    }

    private void BtnTinhTien_Click(object? sender, EventArgs e)
    {
        long tienNuoc = 0;
        if (rdoCafeDen.Checked) tienNuoc = 20000;
        else if (rdoCafeDa.Checked) tienNuoc = 25000;
        else if (rdoCafeSua.Checked) tienNuoc = 25000;
        else if (rdoCafeSuaDa.Checked) tienNuoc = 30000;
        else if (rdoCafeKem.Checked) tienNuoc = 35000;

        long tienThucAn = 0;
        if (chkBMTrung.Checked) tienThucAn += 15000;
        if (chkBMCa.Checked) tienThucAn += 15000;
        if (chkMyTomTrung.Checked) tienThucAn += 20000;
        if (chkMyXaoBo.Checked) tienThucAn += 30000;
        if (chkMyCay.Checked) tienThucAn += 50000;

        long tong = tienNuoc + tienThucAn;
        if (chkSinhVien.Checked)
        {
            tong = (long)(tong * 0.8); // Giảm 20%
        }

        tienHienTai = tong;
        MessageBox.Show($"Khách hàng: {txtTenKhach.Text.Trim()}\nSố tiền phải thanh toán: {tienHienTai:N0} VNĐ", "Hóa đơn thanh toán", MessageBoxButtons.OK, MessageBoxIcon.Information);

        btnThanhToan.Enabled = true;
        btnNhapLai.Enabled = true;
    }

    private void BtnThanhToan_Click(object? sender, EventArgs e)
    {
        tongTienNgay += tienHienTai;
        tongKhachNgay++;

        txtTongKhach.Text = tongKhachNgay.ToString();
        txtTongTien.Text = $"{tongTienNgay:N0} VNĐ";

        MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        BtnNhapLai_Click(sender, e);
    }

    private void BtnNhapLai_Click(object? sender, EventArgs e)
    {
        txtTenKhach.Clear();
        txtSoKhach.Clear();
        chkSinhVien.Checked = false;

        rdoCafeDen.Checked = false;
        rdoCafeDa.Checked = false;
        rdoCafeSua.Checked = false;
        rdoCafeSuaDa.Checked = false;
        rdoCafeKem.Checked = false;

        chkBMTrung.Checked = false;
        chkBMCa.Checked = false;
        chkMyTomTrung.Checked = false;
        chkMyXaoBo.Checked = false;
        chkMyCay.Checked = false;

        tienHienTai = 0;
        btnTinhTien.Enabled = false;
        btnThanhToan.Enabled = false;
        btnNhapLai.Enabled = false;

        txtTenKhach.Focus();
    }
}
