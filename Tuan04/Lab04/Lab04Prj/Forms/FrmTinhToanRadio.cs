using System;
using System.Drawing;
using System.Windows.Forms;
using Lab04Prj.Models;

namespace Lab04Prj.Forms;

public class FrmTinhToanRadio : Form
{
    private Label lblA = null!;
    private TextBox txtA = null!;
    private Label lblB = null!;
    private TextBox txtB = null!;
    private Label lblKetQua = null!;
    private TextBox txtKetQua = null!;
    private RadioButton rdoCong = null!;
    private RadioButton rdoTru = null!;
    private RadioButton rdoNhan = null!;
    private RadioButton rdoChia = null!;
    private Button btnTinh = null!;
    private ErrorProvider errorProvider = null!;

    public FrmTinhToanRadio()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        this.Text = "Cộng trừ nhân chia Radio";
        this.Font = new Font("Tahoma", 10F, FontStyle.Regular);
        this.Size = new Size(420, 260);
        this.StartPosition = FormStartPosition.CenterScreen;
        this.FormBorderStyle = FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;

        errorProvider = new ErrorProvider();

        lblA = new Label { Text = "a =", Location = new Point(30, 25), Size = new Size(40, 25) };
        txtA = new TextBox { Location = new Point(75, 22), Size = new Size(110, 25) };

        lblB = new Label { Text = "b =", Location = new Point(220, 25), Size = new Size(40, 25) };
        txtB = new TextBox { Location = new Point(265, 22), Size = new Size(110, 25) };

        lblKetQua = new Label { Text = "Kết quả", Location = new Point(30, 65), Size = new Size(60, 25) };
        txtKetQua = new TextBox { Location = new Point(100, 62), Size = new Size(275, 25), ReadOnly = true };

        GroupBox grpPhepToan = new GroupBox
        {
            Text = "Phép toán",
            Location = new Point(30, 100),
            Size = new Size(345, 55)
        };

        rdoCong = new RadioButton { Text = "+", Checked = true, Location = new Point(20, 20), Size = new Size(60, 25) };
        rdoTru = new RadioButton { Text = "-", Location = new Point(100, 20), Size = new Size(60, 25) };
        rdoNhan = new RadioButton { Text = "x", Location = new Point(180, 20), Size = new Size(60, 25) };
        rdoChia = new RadioButton { Text = "/", Location = new Point(260, 20), Size = new Size(60, 25) };

        grpPhepToan.Controls.AddRange(new Control[] { rdoCong, rdoTru, rdoNhan, rdoChia });

        btnTinh = new Button
        {
            Text = "Tính",
            Font = new Font("Tahoma", 10F, FontStyle.Bold),
            Location = new Point(155, 170),
            Size = new Size(100, 35)
        };

        btnTinh.Click += BtnTinh_Click;

        this.FormClosing += (s, e) =>
        {
            var r = MessageBox.Show("Bạn có muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No) e.Cancel = true;
        };

        this.Controls.AddRange(new Control[] { lblA, txtA, lblB, txtB, lblKetQua, txtKetQua, grpPhepToan, btnTinh });
    }

    private void BtnTinh_Click(object? sender, EventArgs e)
    {
        errorProvider.Clear();
        bool ok = true;

        if (!float.TryParse(txtA.Text.Trim().Replace(',', '.'), System.Globalization.CultureInfo.InvariantCulture, out float a))
        {
            errorProvider.SetError(txtA, "Vui lòng nhập số hợp lệ");
            ok = false;
        }

        if (!float.TryParse(txtB.Text.Trim().Replace(',', '.'), System.Globalization.CultureInfo.InvariantCulture, out float b))
        {
            errorProvider.SetError(txtB, "Vui lòng nhập số hợp lệ");
            ok = false;
        }

        if (!ok)
        {
            MessageBox.Show("Dữ liệu nhập vào chưa hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        TinhToan dt = new TinhToan(a, b);
        string msg = "Kết quả là:\n";
        float res = 0;

        if (rdoCong.Checked)
        {
            res = dt.Cong();
            msg += $"{a} + {b} = {res}";
        }
        else if (rdoTru.Checked)
        {
            res = dt.Tru();
            msg += $"{a} - {b} = {res}";
        }
        else if (rdoNhan.Checked)
        {
            res = dt.Nhan();
            msg += $"{a} * {b} = {res}";
        }
        else if (rdoChia.Checked)
        {
            if (Math.Abs(b) < 1e-6)
            {
                MessageBox.Show("Phép chia cho 0 bị lỗi!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            res = dt.Chia();
            msg += $"{a} / {b} = {res}";
        }

        txtKetQua.Text = res.ToString("G");
        MessageBox.Show(msg, "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
