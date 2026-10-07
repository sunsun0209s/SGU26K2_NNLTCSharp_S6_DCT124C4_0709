using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab04Prj.Forms;

public class FrmBanVePhim : Form
{
    private Label lblManAnh = null!;
    private Button[] btnGhes = new Button[15];
    private Label lblThanhTienLabel = null!;
    private TextBox txtThanhTien = null!;
    private Button btnChon = null!;
    private Button btnHuyBo = null!;
    private Button btnKetThuc = null!;

    // Trạng thái ghế: 0 = Trắng (Chưa bán), 1 = Xanh (Đang chọn), 2 = Vàng (Đã bán)
    private int[] trangThaiGhe = new int[15];

    public FrmBanVePhim()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        this.Text = "BÁN VÉ RẠP CHIẾU BÓNG";
        this.Font = new Font("Tahoma", 10F, FontStyle.Regular);
        this.Size = new Size(460, 420);
        this.StartPosition = FormStartPosition.CenterScreen;
        this.FormBorderStyle = FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;

        lblManAnh = new Label
        {
            Text = "MÀN ẢNH",
            Font = new Font("Tahoma", 14F, FontStyle.Bold),
            ForeColor = Color.DarkOrange,
            BackColor = Color.LightYellow,
            BorderStyle = BorderStyle.FixedSingle,
            TextAlign = ContentAlignment.MiddleCenter,
            Location = new Point(30, 15),
            Size = new Size(380, 40)
        };

        int startX = 40;
        int startY = 75;
        int btnWidth = 65;
        int btnHeight = 45;
        int gapX = 12;
        int gapY = 12;

        for (int i = 0; i < 15; i++)
        {
            int row = i / 5;
            int col = i % 5;
            int gheIndex = i;

            btnGhes[i] = new Button
            {
                Text = (i + 1).ToString(),
                Font = new Font("Tahoma", 11F, FontStyle.Bold),
                Size = new Size(btnWidth, btnHeight),
                Location = new Point(startX + col * (btnWidth + gapX), startY + row * (btnHeight + gapY)),
                BackColor = Color.White
            };

            btnGhes[i].Click += (s, e) => ClickGhe(gheIndex);
            this.Controls.Add(btnGhes[i]);
        }

        lblThanhTienLabel = new Label { Text = "Thành Tiền:", Location = new Point(50, 275), Size = new Size(90, 25) };
        txtThanhTien = new TextBox { Text = "0", Location = new Point(150, 272), Size = new Size(200, 25), ReadOnly = true, TextAlign = HorizontalAlignment.Right };

        btnChon = new Button { Text = "Chọn", Location = new Point(50, 320), Size = new Size(95, 35) };
        btnHuyBo = new Button { Text = "Hủy bỏ", Location = new Point(170, 320), Size = new Size(95, 35) };
        btnKetThuc = new Button { Text = "Kết thúc", Location = new Point(290, 320), Size = new Size(95, 35) };

        btnChon.Click += BtnChon_Click;
        btnHuyBo.Click += BtnHuyBo_Click;
        btnKetThuc.Click += (s, e) => this.Close();

        this.FormClosing += (s, e) =>
        {
            var r = MessageBox.Show("Bạn có muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No) e.Cancel = true;
        };

        this.Controls.AddRange(new Control[] { lblManAnh, lblThanhTienLabel, txtThanhTien, btnChon, btnHuyBo, btnKetThuc });
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
}
