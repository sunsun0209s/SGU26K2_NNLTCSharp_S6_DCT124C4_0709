using System;
using System.Windows.Forms;

namespace Lab04Prj.Forms;

public partial class FrmPhepTinhCoBan : Form
{
    public FrmPhepTinhCoBan()
    {
        InitializeComponent();
    }

    private void BtnCong_Click(object? sender, EventArgs e) => TinhToan('+');
    private void BtnTru_Click(object? sender, EventArgs e) => TinhToan('-');
    private void BtnNhan_Click(object? sender, EventArgs e) => TinhToan('*');
    private void BtnChia_Click(object? sender, EventArgs e) => TinhToan('/');

    private void FrmPhepTinhCoBan_FormClosing(object? sender, FormClosingEventArgs e)
    {
        var r = MessageBox.Show("Bạn có muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (r == DialogResult.No)
        {
            e.Cancel = true;
        }
    }

    private void FilterNumberInput(object? sender, KeyPressEventArgs e)
    {
        TextBox txt = (TextBox)sender!;
        if (char.IsControl(e.KeyChar)) return;

        // Cho phép dấu âm ở đầu
        if (e.KeyChar == '-' && txt.SelectionStart == 0 && !txt.Text.Contains('-'))
            return;

        // Cho phép dấu chấm hoặc phẩy thập phân
        if ((e.KeyChar == '.' || e.KeyChar == ',') && !txt.Text.Contains('.') && !txt.Text.Contains(','))
            return;

        if (!char.IsDigit(e.KeyChar))
        {
            e.Handled = true; // Chặn ký tự không phải số
        }
    }

    private void TinhToan(char phepToan)
    {
        errorProvider.Clear();
        bool hopLe = true;

        double a = 0;
        double b = 0;

        // Mức 1: Kiểm tra ErrorProvider
        if (string.IsNullOrWhiteSpace(txtA.Text) || !double.TryParse(txtA.Text.Trim().Replace(',', '.'), System.Globalization.CultureInfo.InvariantCulture, out a))
        {
            errorProvider.SetError(txtA, "Vui lòng nhập số hợp lệ cho a");
            hopLe = false;
        }

        if (string.IsNullOrWhiteSpace(txtB.Text) || !double.TryParse(txtB.Text.Trim().Replace(',', '.'), System.Globalization.CultureInfo.InvariantCulture, out b))
        {
            errorProvider.SetError(txtB, "Vui lòng nhập số hợp lệ cho b");
            hopLe = false;
        }

        if (!hopLe)
        {
            MessageBox.Show("Dữ liệu nhập không hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (phepToan == '/' && Math.Abs(b) < 1e-12)
        {
            errorProvider.SetError(txtB, "Số chia b phải khác 0");
            MessageBox.Show("Không thể chia cho số 0!", "Lỗi toán học", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        double ketQua = phepToan switch
        {
            '+' => a + b,
            '-' => a - b,
            '*' => a * b,
            '/' => a / b,
            _ => 0
        };

        txtKetQua.Text = ketQua.ToString("G");
    }
}
