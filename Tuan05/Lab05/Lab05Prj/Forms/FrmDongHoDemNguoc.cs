using System;
using System.Windows.Forms;

namespace Lab05Prj.Forms;

public partial class FrmDongHoDemNguoc : Form
{
    private const int TongSoGiayMacDinh = 30 * 60; // 30 phút = 1800 giây
    private int _soGiayConLai = TongSoGiayMacDinh;
    private bool _dangChay = false;

    public FrmDongHoDemNguoc()
    {
        InitializeComponent();
        HienThiThoiGian();
    }

    private void HienThiThoiGian()
    {
        int phut = _soGiayConLai / 60;
        int giay = _soGiayConLai % 60;
        lblDemNguoc.Text = $"{phut:00}:{giay:00}";
    }

    private void BtnBatDau_Click(object? sender, EventArgs e)
    {
        if (!_dangChay)
        {
            if (_soGiayConLai <= 0)
            {
                _soGiayConLai = TongSoGiayMacDinh;
            }
            timerDemNguoc.Start();
            _dangChay = true;
            btnBatDau.Text = "Tạm dừng";
        }
        else
        {
            timerDemNguoc.Stop();
            _dangChay = false;
            btnBatDau.Text = "Tiếp tục";
        }
    }

    private void BtnDatLai_Click(object? sender, EventArgs e)
    {
        timerDemNguoc.Stop();
        _dangChay = false;
        _soGiayConLai = TongSoGiayMacDinh;
        btnBatDau.Text = "Bắt đầu";
        HienThiThoiGian();
    }

    private void TimerDemNguoc_Tick(object? sender, EventArgs e)
    {
        if (_soGiayConLai > 0)
        {
            _soGiayConLai--;
            HienThiThoiGian();
        }
        else
        {
            timerDemNguoc.Stop();
            _dangChay = false;
            btnBatDau.Text = "Bắt đầu";
            MessageBox.Show("Đã hết thời gian đếm ngược (30:00)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
