using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab04Prj.Forms;

public partial class FrmBanVePhim : Form
{
    private Button[] btnGhes = null!;
    // Trạng thái ghế: 0 = Trắng (Chưa bán), 1 = Xanh (Đang chọn), 2 = Vàng (Đã bán)
    private int[] trangThaiGhe = new int[15];

    public FrmBanVePhim()
    {
        InitializeComponent();
        KhoiTaoDanhSachGhe();
    }

    private void KhoiTaoDanhSachGhe()
    {
        btnGhes = new Button[]
        {
            btnGhe1, btnGhe2, btnGhe3, btnGhe4, btnGhe5,
            btnGhe6, btnGhe7, btnGhe8, btnGhe9, btnGhe10,
            btnGhe11, btnGhe12, btnGhe13, btnGhe14, btnGhe15
        };

        for (int i = 0; i < 15; i++)
        {
            btnGhes[i].Tag = i;
        }
    }

    private void BtnGhe_Click(object? sender, EventArgs e)
    {
        if (sender is Button btn && btn.Tag is int index)
        {
            ClickGhe(index);
        }
    }

    private int LayGiaVe(int index)
    {
        // Ghế 1-5 (Lô A): 1000
        if (index < 5) return 1000;
        // Ghế 6-10 (Lô B): 1500
        if (index < 10) return 1500;
        // Ghế 11-15 (Lô C): 2000
        return 2000;
    }

    private void ClickGhe(int index)
    {
        if (trangThaiGhe[index] == 2)
        {
            MessageBox.Show($"Ghế số {index + 1} đã được bán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (trangThaiGhe[index] == 0) // Trắng -> Xanh
        {
            trangThaiGhe[index] = 1;
            btnGhes[index].BackColor = Color.DeepSkyBlue;
        }
        else if (trangThaiGhe[index] == 1) // Xanh -> Trắng
        {
            trangThaiGhe[index] = 0;
            btnGhes[index].BackColor = Color.White;
        }
    }

    private void BtnChon_Click(object? sender, EventArgs e)
    {
        long tongTien = 0;
        int count = 0;

        for (int i = 0; i < 15; i++)
        {
            if (trangThaiGhe[i] == 1) // Đang chọn
            {
                trangThaiGhe[i] = 2; // Đã bán
                btnGhes[i].BackColor = Color.Yellow;
                tongTien += LayGiaVe(i);
                count++;
            }
        }

        if (count == 0)
        {
            MessageBox.Show("Vui lòng chọn ít nhất một vị trí ghế!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        txtThanhTien.Text = $"{tongTien:N0} VNĐ";
        MessageBox.Show($"Bạn đã đặt mua thành công {count} vé.\nTổng thành tiền: {tongTien:N0} VNĐ", "Thanh toán thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void BtnHuyBo_Click(object? sender, EventArgs e)
    {
        for (int i = 0; i < 15; i++)
        {
            if (trangThaiGhe[i] == 1) // Ghế đang chọn đổi lại thành trắng
            {
                trangThaiGhe[i] = 0;
                btnGhes[i].BackColor = Color.White;
            }
        }
        txtThanhTien.Text = "0 VNĐ";
    }

    private void BtnKetThuc_Click(object? sender, EventArgs e)
    {
        this.Close();
    }

    private void FrmBanVePhim_FormClosing(object? sender, FormClosingEventArgs e)
    {
        var r = MessageBox.Show("Bạn có muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (r == DialogResult.No)
        {
            e.Cancel = true;
        }
    }
}
