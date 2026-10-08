using System;
using System.Windows.Forms;
using Lab04Prj.Models;

namespace Lab04Prj.Forms;

public partial class FrmGiaiPhuongTrinh : Form
{
    public FrmGiaiPhuongTrinh()
    {
        InitializeComponent();
    }

    private void RdoLoai_CheckedChanged(object? sender, EventArgs e)
    {
        bool isBacHai = rdoBacHai.Checked;
        lblC.Visible = isBacHai;
        txtC.Visible = isBacHai;
        if (isBacHai)
        {
            txtC.BringToFront();
        }
        KiemTraDieuKienGiai();
    }

    private void Input_TextChanged(object? sender, EventArgs e) => KiemTraDieuKienGiai();
    private void BtnThoat_Click(object? sender, EventArgs e) => this.Close();

    private void FrmGiaiPhuongTrinh_FormClosing(object? sender, FormClosingEventArgs e)
    {
        var r = MessageBox.Show("Bạn có muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (r == DialogResult.No)
        {
            e.Cancel = true;
        }
    }

    private void KiemTraDieuKienGiai()
    {
        bool coDuA = double.TryParse(txtA.Text.Trim().Replace(',', '.'), System.Globalization.CultureInfo.InvariantCulture, out _);
        bool coDuB = double.TryParse(txtB.Text.Trim().Replace(',', '.'), System.Globalization.CultureInfo.InvariantCulture, out _);

        if (rdoBacNhat.Checked)
        {
            btnGiai.Enabled = coDuA && coDuB;
        }
        else
        {
            bool coDuC = double.TryParse(txtC.Text.Trim().Replace(',', '.'), System.Globalization.CultureInfo.InvariantCulture, out _);
            btnGiai.Enabled = coDuA && coDuB && coDuC;
        }
    }

    private void BtnGiai_Click(object? sender, EventArgs e)
    {
        double.TryParse(txtA.Text.Trim().Replace(',', '.'), System.Globalization.CultureInfo.InvariantCulture, out double a);
        double.TryParse(txtB.Text.Trim().Replace(',', '.'), System.Globalization.CultureInfo.InvariantCulture, out double b);

        PhuongTrinhBacHai pt;

        if (rdoBacNhat.Checked)
        {
            pt = new PhuongTrinhBacHai(a, b);
            txtKetQua.Text = pt.GiaiBacNhat();
        }
        else
        {
            double.TryParse(txtC.Text.Trim().Replace(',', '.'), System.Globalization.CultureInfo.InvariantCulture, out double c);
            pt = new PhuongTrinhBacHai(a, b, c);
            txtKetQua.Text = pt.GiaiBacHai();
        }

        // Sau khi giải xong, button Giải mờ đi như yêu cầu
        btnGiai.Enabled = false;
    }
}
