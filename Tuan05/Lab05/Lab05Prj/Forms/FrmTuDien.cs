using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Lab05Prj.Models;

namespace Lab05Prj.Forms;

public partial class FrmTuDien : Form
{
    private readonly List<TuDienItem> dsTu = new();

    public FrmTuDien()
    {
        InitializeComponent();
    }

    private void FrmTuDien_Load(object? sender, EventArgs e)
    {
        dsTu.Clear();
        dsTu.AddRange(new TuDienItem[]
        {
            new("student", "Sinh viên, học sinh"),
            new("teacher", "Giáo viên, giảng viên"),
            new("worker", "Công nhân, người lao động"),
            new("hat", "Cái mũ, cái nón"),
            new("head", "Cái đầu, người đứng đầu"),
            new("mouse", "Con chuột, chuột máy tính"),
            new("cat", "Con mèo"),
            new("dog", "Con chó"),
            new("snake", "Con rắn"),
            new("lamb", "Cừu con, thịt cừu non"),
            new("loan", "Khoản vay, tiền vay ngân hàng"),
            new("frog", "Con ếch"),
            new("sheep", "Con cừu"),
            new("computer", "Máy vi tính"),
            new("keyboard", "Bàn phím máy tính"),
            new("screen", "Màn hình hiển thị"),
            new("book", "Quyển sách, tập sách"),
            new("pen", "Cây bút viết"),
            new("table", "Cái bàn, bảng dữ liệu"),
            new("chair", "Cái ghế ngồi")
        });

        // Nạp vào tab Anh - Việt
        cboAnh.Items.Clear();
        lstTuAnh.Items.Clear();
        foreach (var item in dsTu.OrderBy(t => t.TiengAnh))
        {
            cboAnh.Items.Add(item.TiengAnh);
            lstTuAnh.Items.Add(item.TiengAnh);
        }

        // Nạp vào tab Việt - Anh
        cboViet.Items.Clear();
        lstTuViet.Items.Clear();
        foreach (var item in dsTu.OrderBy(t => t.TiengViet))
        {
            cboViet.Items.Add(item.TiengViet);
            lstTuViet.Items.Add(item.TiengViet);
        }

        if (cboAnh.Items.Count > 0) cboAnh.SelectedIndex = 0;
        if (cboViet.Items.Count > 0) cboViet.SelectedIndex = 0;
    }

    private void TraTuAnh(string tuAnh)
    {
        var item = dsTu.FirstOrDefault(t => string.Compare(t.TiengAnh, tuAnh.Trim(), true) == 0);
        if (item != null)
        {
            txtNghiaViet.Text = item.TiengViet;
            lstTuAnh.SelectedItem = item.TiengAnh;
        }
        else
        {
            txtNghiaViet.Text = "Không tìm thấy từ này trong từ điển!";
        }
    }

    private void TraTuViet(string tuViet)
    {
        var item = dsTu.FirstOrDefault(t => string.Compare(t.TiengViet, tuViet.Trim(), true) == 0);
        if (item != null)
        {
            txtNghiaAnh.Text = item.TiengAnh;
            lstTuViet.SelectedItem = item.TiengViet;
        }
        else
        {
            txtNghiaAnh.Text = "Không tìm thấy từ này trong từ điển!";
        }
    }

    private void CboAnh_SelectedIndexChanged(object? sender, EventArgs e)
    {
        if (cboAnh.SelectedItem != null)
        {
            TraTuAnh(cboAnh.SelectedItem.ToString()!);
        }
    }

    private void CboAnh_KeyDown(object? sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            TraTuAnh(cboAnh.Text);
            e.Handled = true;
            e.SuppressKeyPress = true;
        }
    }

    private void LstTuAnh_SelectedIndexChanged(object? sender, EventArgs e)
    {
        if (lstTuAnh.SelectedItem != null)
        {
            cboAnh.SelectedItem = lstTuAnh.SelectedItem.ToString();
            TraTuAnh(lstTuAnh.SelectedItem.ToString()!);
        }
    }

    private void LstTuAnh_DoubleClick(object? sender, EventArgs e)
    {
        if (lstTuAnh.SelectedItem != null)
        {
            TraTuAnh(lstTuAnh.SelectedItem.ToString()!);
        }
    }

    private void CboViet_SelectedIndexChanged(object? sender, EventArgs e)
    {
        if (cboViet.SelectedItem != null)
        {
            TraTuViet(cboViet.SelectedItem.ToString()!);
        }
    }

    private void CboViet_KeyDown(object? sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            TraTuViet(cboViet.Text);
            e.Handled = true;
            e.SuppressKeyPress = true;
        }
    }

    private void LstTuViet_SelectedIndexChanged(object? sender, EventArgs e)
    {
        if (lstTuViet.SelectedItem != null)
        {
            cboViet.SelectedItem = lstTuViet.SelectedItem.ToString();
            TraTuViet(lstTuViet.SelectedItem.ToString()!);
        }
    }

    private void LstTuViet_DoubleClick(object? sender, EventArgs e)
    {
        if (lstTuViet.SelectedItem != null)
        {
            TraTuViet(lstTuViet.SelectedItem.ToString()!);
        }
    }

    private void BtnThoat_Click(object? sender, EventArgs e) => this.Close();

    private void FrmTuDien_FormClosing(object? sender, FormClosingEventArgs e)
    {
        var result = MessageBox.Show("Bạn có muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (result == DialogResult.No)
        {
            e.Cancel = true;
        }
    }
}
