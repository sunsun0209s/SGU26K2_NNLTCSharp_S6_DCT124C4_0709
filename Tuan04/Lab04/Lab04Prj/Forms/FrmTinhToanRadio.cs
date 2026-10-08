using System;
using System.Windows.Forms;
using Lab04Prj.Models;

namespace Lab04Prj.Forms;

public partial class FrmTinhToanRadio : Form
{
    public FrmTinhToanRadio()
    {
        InitializeComponent();
    }

    private void FrmTinhToanRadio_FormClosing(object? sender, FormClosingEventArgs e)
    {
        var r = MessageBox.Show("Bạn có muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (r == DialogResult.No)
        {
            e.Cancel = true;
        }
    }

    private void BtnTinh_Click(object? sender, EventArgs e)
    {
        errorProvider.Clear();
        bool ok = true;

        if (!float.TryParse(txtA.Text.Trim().Replace(',', '.'), System.Globalization.CultureInfo.InvariantCulture, out float a))
        {
            errorProvider.SetError(txtA, "Vui lòng nhập số hợp lệ");
            ok = false;
        }

        if (!float.TryParse(txtB.Text.Trim().Replace(',', '.'), System.Globalization.CultureInfo.InvariantCulture, out float b))
        {
            errorProvider.SetError(txtB, "Vui lòng nhập số hợp lệ");
            ok = false;
        }

        if (!ok)
        {
            MessageBox.Show("Dữ liệu nhập vào chưa hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        TinhToan dt = new TinhToan(a, b);
        string msg = "Kết quả là:\n";
        float res = 0;

        if (rdoCong.Checked)
        {
            res = dt.Cong();
            msg += $"{a} + {b} = {res}";
        }
        else if (rdoTru.Checked)
        {
            res = dt.Tru();
            msg += $"{a} - {b} = {res}";
        }
        else if (rdoNhan.Checked)
        {
            res = dt.Nhan();
            msg += $"{a} * {b} = {res}";
        }
        else if (rdoChia.Checked)
        {
            if (Math.Abs(b) < 1e-6)
            {
                MessageBox.Show("Phép chia cho 0 bị lỗi!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            res = dt.Chia();
            msg += $"{a} / {b} = {res}";
        }

        txtKetQua.Text = res.ToString("G");
        MessageBox.Show(msg, "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
