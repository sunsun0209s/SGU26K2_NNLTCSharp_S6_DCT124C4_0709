using System;
using System.Windows.Forms;

namespace Lab04Prj.Forms;

public partial class FrmDocSo : Form
{
    public FrmDocSo()
    {
        InitializeComponent();
    }

    private void BtnThucHien_Click(object? sender, EventArgs e)
    {
        if (int.TryParse(txtNhap.Text.Trim(), out int n) && n >= 1 && n <= 999)
        {
            lblKetQua.Text = DocSoThanhChu(n);
        }
        else
        {
            MessageBox.Show("Vui lòng nhập số nguyên dương từ 1 đến 999!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtNhap.SelectAll();
            txtNhap.Focus();
        }
    }

    private void BtnXoa_Click(object? sender, EventArgs e)
    {
        txtNhap.Clear();
        lblKetQua.Text = string.Empty;
        txtNhap.Focus();
    }

    private void BtnThoat_Click(object? sender, EventArgs e)
    {
        this.Close();
    }

    private void FrmDocSo_FormClosing(object? sender, FormClosingEventArgs e)
    {
        var r = MessageBox.Show("Bạn có muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (r == DialogResult.No)
        {
            e.Cancel = true;
        }
    }

    private string DocSoThanhChu(int n)
    {
        string[] chuSo = { "Không", "Một", "Hai", "Ba", "Bốn", "Năm", "Sáu", "Bảy", "Tám", "Chín" };

        int tram = n / 100;
        int chuc = (n % 100) / 10;
        int donVi = n % 10;

        string result = "";

        if (tram > 0)
        {
            result += chuSo[tram] + " Trăm ";
            if (chuc == 0 && donVi > 0)
            {
                result += "Lẻ ";
            }
        }

        if (chuc > 0)
        {
            if (chuc == 1)
            {
                result += "Mười ";
            }
            else
            {
                result += chuSo[chuc] + " Mươi ";
            }
        }

        if (donVi > 0)
        {
            if (donVi == 1 && chuc > 1)
            {
                result += "Mốt";
            }
            else if (donVi == 5 && chuc > 0)
            {
                result += "Lăm";
            }
            else
            {
                result += chuSo[donVi];
            }
        }

        return result.Trim();
    }
}
