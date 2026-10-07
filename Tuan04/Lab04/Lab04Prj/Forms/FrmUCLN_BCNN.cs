using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab04Prj.Forms;

public class FrmUCLN_BCNN : Form
{
    private Label lblTitle = null!;
    private Label lblA = null!;
    private TextBox txtA = null!;
    private Label lblB = null!;
    private TextBox txtB = null!;
    private Label lblUCLN = null!;
    private TextBox txtUCLN = null!;
    private Label lblBCNN = null!;
    private TextBox txtBCNN = null!;
    private Button btnThucHien = null!;
    private Button btnTiepTuc = null!;
    private Button btnThoat = null!;
    private ErrorProvider errorProvider = null!;

    public FrmUCLN_BCNN()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        this.Text = "Ước Số - Bội Số";
        this.Font = new Font("Tahoma", 10F, FontStyle.Regular);
        this.Size = new Size(420, 310);
        this.StartPosition = FormStartPosition.CenterScreen;
        this.FormBorderStyle = FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;

        errorProvider = new ErrorProvider();

        lblTitle = new Label
        {
            Text = "Ước Số Chung - Bội Số Chung",
            Font = new Font("Tahoma", 13F, FontStyle.Bold),
            ForeColor = Color.Brown,
            TextAlign = ContentAlignment.MiddleCenter,
            Location = new Point(20, 15),
            Size = new Size(360, 30)
        };

        lblA = new Label { Text = "Nhập số a:", Location = new Point(40, 60), Size = new Size(130, 25) };
        txtA = new TextBox { Location = new Point(180, 58), Size = new Size(170, 25) };

        lblB = new Label { Text = "Nhập số b:", Location = new Point(40, 95), Size = new Size(130, 25) };
        txtB = new TextBox { Location = new Point(180, 93), Size = new Size(170, 25) };

        lblUCLN = new Label { Text = "Ước số chung lớn nhất:", Location = new Point(40, 130), Size = new Size(140, 25) };
        txtUCLN = new TextBox { Location = new Point(180, 128), Size = new Size(170, 25), ReadOnly = true };

        lblBCNN = new Label { Text = "Bội số chung nhỏ nhất:", Location = new Point(40, 165), Size = new Size(140, 25) };
        txtBCNN = new TextBox { Location = new Point(180, 163), Size = new Size(170, 25), ReadOnly = true };

        btnThucHien = new Button { Text = "Thực Hiện", Location = new Point(40, 210), Size = new Size(95, 35) };
        btnTiepTuc = new Button { Text = "Tiếp Tục", Location = new Point(155, 210), Size = new Size(95, 35) };
        btnThoat = new Button { Text = "Thoát", Location = new Point(270, 210), Size = new Size(95, 35) };

        btnThucHien.Click += BtnThucHien_Click;
        btnTiepTuc.Click += (s, e) =>
        {
            txtA.Clear();
            txtB.Clear();
            txtUCLN.Clear();
            txtBCNN.Clear();
            errorProvider.Clear();
            txtA.Focus();
        };
        btnThoat.Click += (s, e) => this.Close();

        this.FormClosing += (s, e) =>
        {
            var r = MessageBox.Show("Bạn có muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No) e.Cancel = true;
        };

        this.Controls.AddRange(new Control[] { lblTitle, lblA, txtA, lblB, txtB, lblUCLN, txtUCLN, lblBCNN, txtBCNN, btnThucHien, btnTiepTuc, btnThoat });
    }

    private void BtnThucHien_Click(object? sender, EventArgs e)
    {
        errorProvider.Clear();
        bool ok = true;

        if (!long.TryParse(txtA.Text.Trim(), out long a) || a <= 0)
        {
            errorProvider.SetError(txtA, "Vui lòng nhập số nguyên dương a");
            ok = false;
        }

        if (!long.TryParse(txtB.Text.Trim(), out long b) || b <= 0)
        {
            errorProvider.SetError(txtB, "Vui lòng nhập số nguyên dương b");
            ok = false;
        }

        if (!ok)
        {
            MessageBox.Show("Vui lòng nhập hai số nguyên dương hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        long ucln = TimUCLN(a, b);
        long bcnn = (a / ucln) * b;

        txtUCLN.Text = ucln.ToString();
        txtBCNN.Text = bcnn.ToString();
    }

    private long TimUCLN(long a, long b)
    {
        while (b != 0)
        {
            long r = a % b;
            a = b;
            b = r;
        }
        return a;
    }
}
