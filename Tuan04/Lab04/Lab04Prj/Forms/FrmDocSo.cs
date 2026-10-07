using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab04Prj.Forms;

public class FrmDocSo : Form
{
    private Label lblTitle = null!;
    private Label lblNhap = null!;
    private TextBox txtNhap = null!;
    private Button btnThucHien = null!;
    private Button btnXoa = null!;
    private Button btnThoat = null!;
    private Label lblKetQua = null!;

    public FrmDocSo()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        this.Text = "Đọc Chữ Số";
        this.Font = new Font("Tahoma", 10F, FontStyle.Regular);
        this.Size = new Size(420, 260);
        this.StartPosition = FormStartPosition.CenterScreen;
        this.FormBorderStyle = FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;

        lblTitle = new Label
        {
            Text = "Đọc Số Thành Chữ",
            Font = new Font("Tahoma", 14F, FontStyle.Bold),
            ForeColor = Color.Red,
            TextAlign = ContentAlignment.MiddleCenter,
            Location = new Point(20, 15),
            Size = new Size(360, 30)
        };

        lblNhap = new Label { Text = "Nhập dãy số: (từ 1 đến 999)", Location = new Point(30, 60), Size = new Size(200, 25) };
        txtNhap = new TextBox { Location = new Point(235, 58), Size = new Size(130, 25) };

        btnThucHien = new Button { Text = "Thực hiện", Location = new Point(40, 105), Size = new Size(95, 35) };
        btnXoa = new Button { Text = "Xóa", Location = new Point(155, 105), Size = new Size(95, 35) };
        btnThoat = new Button { Text = "Thoát", Location = new Point(270, 105), Size = new Size(95, 35) };

        lblKetQua = new Label
        {
            Text = string.Empty,
            Font = new Font("Tahoma", 11F, FontStyle.Bold),
            ForeColor = Color.Blue,
            TextAlign = ContentAlignment.MiddleCenter,
            Location = new Point(20, 160),
            Size = new Size(360, 45)
        };

        this.AcceptButton = btnThucHien;

        btnThucHien.Click += BtnThucHien_Click;
        btnXoa.Click += (s, e) =>
        {
            txtNhap.Clear();
            lblKetQua.Text = string.Empty;
            txtNhap.Focus();
        };
        btnThoat.Click += (s, e) => this.Close();

        this.FormClosing += (s, e) =>
        {
            var r = MessageBox.Show("Bạn có muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No) e.Cancel = true;
        };

        this.Controls.AddRange(new Control[] { lblTitle, lblNhap, txtNhap, btnThucHien, btnXoa, btnThoat, lblKetQua });
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
