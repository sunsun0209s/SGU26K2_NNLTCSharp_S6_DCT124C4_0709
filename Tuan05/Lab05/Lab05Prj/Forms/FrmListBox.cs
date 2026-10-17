using System;
using System.Linq;
using System.Windows.Forms;

namespace Lab05Prj.Forms;

public partial class FrmListBox : Form
{
    public FrmListBox()
    {
        InitializeComponent();
    }

    private void FrmListBox_Load(object? sender, EventArgs e)
    {
        lst_Trai.Items.Clear();
        lst_Phai.Items.Clear();
        lst_Trai.Items.AddRange(new object[] { "Cóc", "Ổi", "Xoài", "Mận", "Bưởi", "Cam" });
    }

    private void BtnQuaPhai_Click(object? sender, EventArgs e)
    {
        if (lst_Trai.SelectedItem != null)
        {
            lst_Phai.Items.Add(lst_Trai.SelectedItem);
            lst_Trai.Items.Remove(lst_Trai.SelectedItem);
        }
    }

    private void BtnQuaPhaiAll_Click(object? sender, EventArgs e)
    {
        lst_Phai.Items.AddRange(lst_Trai.Items);
        lst_Trai.Items.Clear();
    }

    private void BtnQuaTrai_Click(object? sender, EventArgs e)
    {
        if (lst_Phai.SelectedItem != null)
        {
            lst_Trai.Items.Add(lst_Phai.SelectedItem);
            lst_Phai.Items.Remove(lst_Phai.SelectedItem);
        }
    }

    private void BtnQuaTraiAll_Click(object? sender, EventArgs e)
    {
        lst_Trai.Items.AddRange(lst_Phai.Items);
        lst_Phai.Items.Clear();
    }

    private void BtnChuyenTuyY_Click(object? sender, EventArgs e)
    {
        var danhSachChon = lst_Trai.SelectedItems.Cast<object>().ToList();
        foreach (var item in danhSachChon)
        {
            lst_Phai.Items.Add(item);
            lst_Trai.Items.Remove(item);
        }
    }

    private void FrmListBox_FormClosing(object? sender, FormClosingEventArgs e)
    {
        var result = MessageBox.Show("Bạn có muốn thoát chương trình?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (result == DialogResult.No)
        {
            e.Cancel = true;
        }
    }
}
