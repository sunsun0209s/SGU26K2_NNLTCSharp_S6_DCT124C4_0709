using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Lab04Prj.Forms;

public partial class FrmDaySo : Form
{
    private List<int> danhSachSo = new();

    public FrmDaySo()
    {
        InitializeComponent();
    }

    private void BtnNhap_Click(object? sender, EventArgs e)
    {
        if (int.TryParse(txtNhap.Text.Trim(), out int val))
        {
            danhSachSo.Add(val);
            txtDaySo.Text = string.Join(" ", danhSachSo);

            int tong = danhSachSo.Sum();
            int tongChan = danhSachSo.Where(x => x % 2 == 0).Sum();
            int tongLe = danhSachSo.Where(x => x % 2 != 0).Sum();

            txtTong.Text = tong.ToString();
            txtTongChan.Text = tongChan.ToString();
            txtTongLe.Text = tongLe.ToString();

            txtNhap.Clear();
            txtNhap.Focus();
        }
        else
        {
            MessageBox.Show("Vui lòng nhập một số nguyên hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtNhap.SelectAll();
            txtNhap.Focus();
        }
    }

    private void BtnTiepTuc_Click(object? sender, EventArgs e)
    {
        danhSachSo.Clear();
        txtNhap.Clear();
        txtDaySo.Clear();
        txtTong.Clear();
        txtTongChan.Clear();
        txtTongLe.Clear();
        txtNhap.Focus();
    }

    private void BtnThoat_Click(object? sender, EventArgs e)
    {
        this.Close();
    }

    private void FrmDaySo_FormClosing(object? sender, FormClosingEventArgs e)
    {
        var r = MessageBox.Show("Bạn có muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (r == DialogResult.No)
        {
            e.Cancel = true;
        }
    }
}
