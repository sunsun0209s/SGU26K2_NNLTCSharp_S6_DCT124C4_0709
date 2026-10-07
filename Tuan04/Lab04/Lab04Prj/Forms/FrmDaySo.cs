using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Lab04Prj.Forms;

public class FrmDaySo : Form
{
    private Label lblTitle = null!;
    private Label lblNhap = null!;
    private TextBox txtNhap = null!;
    private Button btnNhap = null!;
    private Label lblDaySo = null!;
    private TextBox txtDaySo = null!;
    private Label lblTong = null!;
    private TextBox txtTong = null!;
    private Label lblTongChan = null!;
    private TextBox txtTongChan = null!;
    private Label lblTongLe = null!;
    private TextBox txtTongLe = null!;
    private Button btnTiepTuc = null!;
    private Button btnThoat = null!;
    private List<int> danhSachSo = new();

    public FrmDaySo()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        this.Text = "Dãy số và Tính Tổng";
        this.Font = new Font("Tahoma", 10F, FontStyle.Regular);
        this.Size = new Size(450, 330);
        this.StartPosition = FormStartPosition.CenterScreen;
        this.FormBorderStyle = FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;

        lblTitle = new Label
        {
            Text = "Nhập Dãy Số và Tính Tổng",
            Font = new Font("Tahoma", 13F, FontStyle.Bold),
            ForeColor = Color.Crimson,
            TextAlign = ContentAlignment.MiddleCenter,
            Location = new Point(20, 15),
            Size = new Size(390, 30)
        };

        lblNhap = new Label { Text = "Nhập số:", Location = new Point(30, 60), Size = new Size(130, 25) };
        txtNhap = new TextBox { Location = new Point(170, 58), Size = new Size(110, 25) };
        btnNhap = new Button { Text = "Nhập", Location = new Point(295, 56), Size = new Size(90, 28) };

        lblDaySo = new Label { Text = "Dãy vừa nhập:", Location = new Point(30, 95), Size = new Size(130, 25) };
        txtDaySo = new TextBox { Location = new Point(170, 93), Size = new Size(215, 25), ReadOnly = true };

        lblTong = new Label { Text = "Tổng các phần tử:", Location = new Point(30, 130), Size = new Size(130, 25) };
        txtTong = new TextBox { Location = new Point(170, 128), Size = new Size(215, 25), ReadOnly = true };

        lblTongChan = new Label { Text = "Tổng Chẵn:", Location = new Point(30, 165), Size = new Size(80, 25) };
        txtTongChan = new TextBox { Location = new Point(115, 163), Size = new Size(80, 25), ReadOnly = true };

        lblTongLe = new Label { Text = "Tổng Lẻ:", Location = new Point(215, 165), Size = new Size(80, 25) };
        txtTongLe = new TextBox { Location = new Point(305, 163), Size = new Size(80, 25), ReadOnly = true };

        btnTiepTuc = new Button { Text = "Tiếp Tục", Location = new Point(115, 220), Size = new Size(100, 35) };
        btnThoat = new Button { Text = "Thoát", Location = new Point(235, 220), Size = new Size(100, 35) };

        this.AcceptButton = btnNhap;

        btnNhap.Click += BtnNhap_Click;
        btnTiepTuc.Click += (s, e) =>
        {
            danhSachSo.Clear();
            txtNhap.Clear();
            txtDaySo.Clear();
            txtTong.Clear();
            txtTongChan.Clear();
            txtTongLe.Clear();
            txtNhap.Focus();
        };
        btnThoat.Click += (s, e) => this.Close();

        this.FormClosing += (s, e) =>
        {
            var r = MessageBox.Show("Bạn có muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No) e.Cancel = true;
        };

        this.Controls.AddRange(new Control[] {
            lblTitle, lblNhap, txtNhap, btnNhap, lblDaySo, txtDaySo,
            lblTong, txtTong, lblTongChan, txtTongChan, lblTongLe, txtTongLe,
            btnTiepTuc, btnThoat
        });
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
}
