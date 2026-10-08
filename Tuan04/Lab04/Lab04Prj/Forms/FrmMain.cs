using System;
using System.Windows.Forms;

namespace Lab04Prj.Forms;

public partial class FrmMain : Form
{
    public FrmMain()
    {
        InitializeComponent();
    }

    private void BtnDe1_MyName_Click(object? sender, EventArgs e) => new FrmMyName().ShowDialog();
    private void BtnDe1_PhepTinh_Click(object? sender, EventArgs e) => new FrmPhepTinhCoBan().ShowDialog();
    private void BtnDe1_DangKy_Click(object? sender, EventArgs e) => new FrmDangKyTaiKhoan().ShowDialog();
    private void BtnDe1_UCLN_Click(object? sender, EventArgs e) => new FrmUCLN_BCNN().ShowDialog();
    private void BtnDe1_DaySo_Click(object? sender, EventArgs e) => new FrmDaySo().ShowDialog();
    private void BtnDe1_DocSo_Click(object? sender, EventArgs e) => new FrmDocSo().ShowDialog();
    private void BtnDe1_BanVePhim_Click(object? sender, EventArgs e) => new FrmBanVePhim().ShowDialog();
    private void BtnDe1_MayTinh_Click(object? sender, EventArgs e) => new FrmMayTinhBoTui().ShowDialog();

    private void BtnDe2_TinhToanRadio_Click(object? sender, EventArgs e) => new FrmTinhToanRadio().ShowDialog();
    private void BtnDe2_DinhDangFont_Click(object? sender, EventArgs e) => new FrmDinhDangFont().ShowDialog();
    private void BtnDe2_GiaiPhuongTrinh_Click(object? sender, EventArgs e) => new FrmGiaiPhuongTrinh().ShowDialog();
    private void BtnDe2_MangSoNguyen_Click(object? sender, EventArgs e) => new FrmMangSoNguyen().ShowDialog();
    private void BtnDe2_CafeSinhVien_Click(object? sender, EventArgs e) => new FrmCafeSinhVien().ShowDialog();
    private void BtnDe2_KhachSan_Click(object? sender, EventArgs e) => new FrmKhachSanThanhThanh().ShowDialog();

    private void BtnThoat_Click(object? sender, EventArgs e) => this.Close();

    private void FrmMain_FormClosing(object? sender, FormClosingEventArgs e)
    {
        var r = MessageBox.Show("Bạn có muốn thoát khỏi ứng dụng tổng hợp Lab 04?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (r == DialogResult.No)
        {
            e.Cancel = true;
        }
    }
}
