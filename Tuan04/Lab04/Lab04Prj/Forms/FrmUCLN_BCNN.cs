using System;
using System.Windows.Forms;

namespace Lab04Prj.Forms;

public partial class FrmUCLN_BCNN : Form
{
    public FrmUCLN_BCNN()
    {
        InitializeComponent();
    }

    private void BtnThucHien_Click(object? sender, EventArgs e)
    {
        errorProvider.Clear();
        bool ok = true;

        if (!long.TryParse(txtA.Text.Trim(), out long a) || a <= 0)
        {
            errorProvider.SetError(txtA, "Vui lòng nhập số nguyên dương a");
            ok = false;
        }

        if (!long.TryParse(txtB.Text.Trim(), out long b) || b <= 0)
        {
            errorProvider.SetError(txtB, "Vui lòng nhập số nguyên dương b");
            ok = false;
        }

        if (!ok)
        {
            MessageBox.Show("Vui lòng nhập hai số nguyên dương hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        long ucln = TimUCLN(a, b);
        long bcnn = (a / ucln) * b;

        txtUCLN.Text = ucln.ToString();
        txtBCNN.Text = bcnn.ToString();
    }

    private void BtnTiepTuc_Click(object? sender, EventArgs e)
    {
        txtA.Clear();
        txtB.Clear();
        txtUCLN.Clear();
        txtBCNN.Clear();
        errorProvider.Clear();
        txtA.Focus();
    }

    private void BtnThoat_Click(object? sender, EventArgs e)
    {
        this.Close();
    }

    private void FrmUCLN_BCNN_FormClosing(object? sender, FormClosingEventArgs e)
    {
        var r = MessageBox.Show("Bạn có muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (r == DialogResult.No)
        {
            e.Cancel = true;
        }
    }

    private long TimUCLN(long a, long b)
    {
        while (b != 0)
        {
            long r = a % b;
            a = b;
            b = r;
        }
        return a;
    }
}
