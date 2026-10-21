using System;
using System.Windows.Forms;

namespace Lab05Prj.Forms;

public partial class FrmMain : Form
{
    public FrmMain()
    {
        InitializeComponent();
    }

    // Các sự kiện cho Tuần 05c (Nâng cao 1)
    private void BtnMau_ListBox_Click(object? sender, EventArgs e)
    {
        using var f = new FrmListBox();
        f.ShowDialog(this);
    }

    private void BtnMau_ComboBox_Click(object? sender, EventArgs e)
    {
        using var f = new FrmCbo_Dantoc();
        f.ShowDialog(this);
    }

    private void BtnMau_TreeView_Click(object? sender, EventArgs e)
    {
        using var f = new FrmTreeView();
        f.ShowDialog(this);
    }

    private void BtnLop_UocSo_Click(object? sender, EventArgs e)
    {
        using var f = new FrmComboboxUocSo();
        f.ShowDialog(this);
    }

    private void BtnLop_SinhVien_Click(object? sender, EventArgs e)
    {
        using var f = new FrmQuanLySinhVien();
        f.ShowDialog(this);
    }

    private void BtnNC_XuLyChuoi_Click(object? sender, EventArgs e)
    {
        using var f = new FrmXuLyChuoi();
        f.ShowDialog(this);
    }

    private void BtnVN_TuDien_Click(object? sender, EventArgs e)
    {
        using var f = new FrmTuDien();
        f.ShowDialog(this);
    }

    private void BtnVN_ListBox_Click(object? sender, EventArgs e)
    {
        using var f = new FrmListBoxSoTuNhien();
        f.ShowDialog(this);
    }

    private void BtnVN_DanhBa_Click(object? sender, EventArgs e)
    {
        using var f = new FrmDanhBa();
        f.ShowDialog(this);
    }

    // Các sự kiện cho Tuần 05d (Nâng cao 2)
    private void Btn5d_MauTimer_Click(object? sender, EventArgs e)
    {
        using var f = new FrmDemoTimer();
        f.ShowDialog(this);
    }

    private void Btn5d_MauListView_Click(object? sender, EventArgs e)
    {
        using var f = new FrmDemoListView();
        f.ShowDialog(this);
    }

    private void Btn5d_MauDialog_Click(object? sender, EventArgs e)
    {
        using var f = new FrmCommonDialog();
        f.ShowDialog(this);
    }

    private void Btn5d_LopSinhVien_Click(object? sender, EventArgs e)
    {
        using var f = new FrmThongTinSinhVien();
        f.ShowDialog(this);
    }

    private void Btn5d_LopTaiKhoan_Click(object? sender, EventArgs e)
    {
        using var f = new FrmQuanLyTaiKhoan();
        f.ShowDialog(this);
    }

    private void Btn5d_NCHocVien_Click(object? sender, EventArgs e)
    {
        using var f = new FrmQuanLyHocVien();
        f.ShowDialog(this);
    }

    private void Btn5d_VNDemNguoc_Click(object? sender, EventArgs e)
    {
        using var f = new FrmDongHoDemNguoc();
        f.ShowDialog(this);
    }

    // Sự kiện thoát chương trình
    private void BtnThoat_Click(object? sender, EventArgs e)
    {
        var r = MessageBox.Show("Bạn có muốn thoát chương trình?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (r == DialogResult.Yes)
        {
            this.Close();
        }
    }
}
