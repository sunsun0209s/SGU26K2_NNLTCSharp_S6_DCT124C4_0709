using System;
using System.Windows.Forms;

namespace Lab05Prj.Forms;

public partial class FrmMain : Form
{
    public FrmMain()
    {
        InitializeComponent();
    }

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

    private void BtnThoat_Click(object? sender, EventArgs e)
    {
        var r = MessageBox.Show("Bạn có muốn thoát chương trình?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (r == DialogResult.Yes)
        {
            this.Close();
        }
    }
}
