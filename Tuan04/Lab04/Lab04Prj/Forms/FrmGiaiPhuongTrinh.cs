using System;
using System.Drawing;
using System.Windows.Forms;
using Lab04Prj.Models;

namespace Lab04Prj.Forms;

public class FrmGiaiPhuongTrinh : Form
{
    private Label lblTitle = null!;
    private RadioButton rdoBacNhat = null!;
    private RadioButton rdoBacHai = null!;
    private Label lblA = null!;
    private TextBox txtA = null!;
    private Label lblB = null!;
    private TextBox txtB = null!;
    private Label lblC = null!;
    private TextBox txtC = null!;
    private Label lblKetQua = null!;
    private TextBox txtKetQua = null!;
    private Button btnGiai = null!;
    private Button btnThoat = null!;

    public FrmGiaiPhuongTrinh()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        this.Text = "Giải phương trình bậc 1-2";
        this.Font = new Font("Tahoma", 10F, FontStyle.Regular);
        this.Size = new Size(420, 390);
        this.StartPosition = FormStartPosition.CenterScreen;
        this.FormBorderStyle = FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;

        lblTitle = new Label
        {
            Text = "GIẢI PHƯƠNG TRÌNH",
            Font = new Font("Tahoma", 14F, FontStyle.Bold),
            ForeColor = Color.Red,
            TextAlign = ContentAlignment.MiddleCenter,
            Location = new Point(20, 15),
            Size = new Size(360, 30)
        };

        GroupBox grpLoai = new GroupBox
        {
            Text = "Bạn vui lòng chọn",
            Location = new Point(30, 50),
            Size = new Size(345, 75)
        };

        rdoBacNhat = new RadioButton { Text = "Phương trình bậc nhất", Checked = true, Location = new Point(25, 20), Size = new Size(220, 24) };
        rdoBacHai = new RadioButton { Text = "Phương trình bậc hai", Location = new Point(25, 45), Size = new Size(220, 24) };
        grpLoai.Controls.AddRange(new Control[] { rdoBacNhat, rdoBacHai });

        lblA = new Label { Text = "Nhập a:", Location = new Point(35, 140), Size = new Size(70, 25) };
        txtA = new TextBox { Location = new Point(110, 138), Size = new Size(130, 25) };

        lblB = new Label { Text = "Nhập b:", Location = new Point(35, 175), Size = new Size(70, 25) };
        txtB = new TextBox { Location = new Point(110, 173), Size = new Size(130, 25) };

        lblC = new Label { Text = "Nhập c:", Location = new Point(35, 210), Size = new Size(70, 25), Visible = false };
        txtC = new TextBox { Location = new Point(110, 208), Size = new Size(130, 25), Visible = false };

        lblKetQua = new Label { Text = "Kết quả:", Location = new Point(35, 250), Size = new Size(70, 25) };
        txtKetQua = new TextBox { Location = new Point(110, 248), Size = new Size(265, 25), ReadOnly = true };

        btnGiai = new Button
        {
            Text = "Giải",
            Font = new Font("Tahoma", 10F, FontStyle.Bold),
            Location = new Point(275, 138),
            Size = new Size(95, 40),
            Enabled = false // Mờ đi khi Form load
        };

        btnThoat = new Button
        {
            Text = "Thoát",
            Location = new Point(275, 190),
            Size = new Size(95, 35)
        };

        // Events
        rdoBacNhat.CheckedChanged += (s, e) =>
        {
            bool isBacHai = rdoBacHai.Checked;
            lblC.Visible = isBacHai;
            txtC.Visible = isBacHai;
            KiemTraDieuKienGiai();
        };

        rdoBacHai.CheckedChanged += (s, e) =>
        {
            bool isBacHai = rdoBacHai.Checked;
            lblC.Visible = isBacHai;
            txtC.Visible = isBacHai;
            KiemTraDieuKienGiai();
        };

        txtA.TextChanged += (s, e) => KiemTraDieuKienGiai();
        txtB.TextChanged += (s, e) => KiemTraDieuKienGiai();
        txtC.TextChanged += (s, e) => KiemTraDieuKienGiai();

        btnGiai.Click += BtnGiai_Click;
        btnThoat.Click += (s, e) => this.Close();

        this.FormClosing += (s, e) =>
        {
            var r = MessageBox.Show("Bạn có muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No) e.Cancel = true;
        };

        this.Controls.AddRange(new Control[] { lblTitle, grpLoai, lblA, txtA, lblB, txtB, lblC, txtC, lblKetQua, txtKetQua, btnGiai, btnThoat });
    }

    private void KiemTraDieuKienGiai()
    {
        bool coDuA = double.TryParse(txtA.Text.Trim().Replace(',', '.'), System.Globalization.CultureInfo.InvariantCulture, out _);
        bool coDuB = double.TryParse(txtB.Text.Trim().Replace(',', '.'), System.Globalization.CultureInfo.InvariantCulture, out _);

        if (rdoBacNhat.Checked)
        {
            btnGiai.Enabled = coDuA && coDuB;
        }
        else
        {
            bool coDuC = double.TryParse(txtC.Text.Trim().Replace(',', '.'), System.Globalization.CultureInfo.InvariantCulture, out _);
            btnGiai.Enabled = coDuA && coDuB && coDuC;
        }
    }

    private void BtnGiai_Click(object? sender, EventArgs e)
    {
        double.TryParse(txtA.Text.Trim().Replace(',', '.'), System.Globalization.CultureInfo.InvariantCulture, out double a);
        double.TryParse(txtB.Text.Trim().Replace(',', '.'), System.Globalization.CultureInfo.InvariantCulture, out double b);

        PhuongTrinhBacHai pt;

        if (rdoBacNhat.Checked)
        {
            pt = new PhuongTrinhBacHai(a, b);
            txtKetQua.Text = pt.GiaiBacNhat();
        }
        else
        {
            double.TryParse(txtC.Text.Trim().Replace(',', '.'), System.Globalization.CultureInfo.InvariantCulture, out double c);
            pt = new PhuongTrinhBacHai(a, b, c);
            txtKetQua.Text = pt.GiaiBacHai();
        }

        // Sau khi giải xong, button Giải mờ đi như yêu cầu
        btnGiai.Enabled = false;
    }
}
