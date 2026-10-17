using System;
using System.Windows.Forms;

namespace Lab05Prj.Forms;

public partial class FrmInputNameDialog : Form
{
    public string TenNhap { get; private set; } = string.Empty;

    public FrmInputNameDialog(string tenHienTai)
    {
        InitializeComponent();
        txtTenMoi.Text = tenHienTai;
        txtTenMoi.SelectAll();
    }

    private void BtnOK_Click(object? sender, EventArgs e)
    {
        string ten = txtTenMoi.Text.Trim();
        if (string.IsNullOrWhiteSpace(ten))
        {
            MessageBox.Show("Tên không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtTenMoi.Focus();
            return;
        }

        TenNhap = ten;
        this.DialogResult = DialogResult.OK;
        this.Close();
    }

    private void BtnCancel_Click(object? sender, EventArgs e)
    {
        this.DialogResult = DialogResult.Cancel;
        this.Close();
    }
}
