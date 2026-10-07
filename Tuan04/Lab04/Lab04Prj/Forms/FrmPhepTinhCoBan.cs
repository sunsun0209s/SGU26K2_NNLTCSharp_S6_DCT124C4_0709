using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab04Prj.Forms;

public class FrmPhepTinhCoBan : Form
{
    private Label lblA = null!;
    private TextBox txtA = null!;
    private Label lblB = null!;
    private TextBox txtB = null!;
    private Label lblKetQua = null!;
    private TextBox txtKetQua = null!;
    private Button btnCong = null!;
    private Button btnTru = null!;
    private Button btnNhan = null!;
    private Button btnChia = null!;
    private ErrorProvider errorProvider = null!;

    public FrmPhepTinhCoBan()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        this.Text = "Cộng trừ nhân chia";
        this.Font = new Font("Tahoma", 10F, FontStyle.Regular);
        this.Size = new Size(420, 240);
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

        btnCong = new Button { Text = "+", Font = new Font("Tahoma", 12F, FontStyle.Bold), Location = new Point(40, 115), Size = new Size(65, 40) };
        btnTru = new Button { Text = "-", Font = new Font("Tahoma", 12F, FontStyle.Bold), Location = new Point(125, 115), Size = new Size(65, 40) };
        btnNhan = new Button { Text = "x", Font = new Font("Tahoma", 12F, FontStyle.Bold), Location = new Point(210, 115), Size = new Size(65, 40) };
        btnChia = new Button { Text = "/", Font = new Font("Tahoma", 12F, FontStyle.Bold), Location = new Point(295, 115), Size = new Size(65, 40) };

        // Mức 2: Chặn ký tự khác số ở sự kiện KeyPress
        txtA.KeyPress += FilterNumberInput;
        txtB.KeyPress += FilterNumberInput;

        // Xử lý tính toán
        btnCong.Click += (s, e) => TinhToan('+');
        btnTru.Click += (s, e) => TinhToan('-');
        btnNhan.Click += (s, e) => TinhToan('*');
        btnChia.Click += (s, e) => TinhToan('/');

        this.FormClosing += (s, e) =>
        {
            var r = MessageBox.Show("Bạn có muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No) e.Cancel = true;
        };

        this.Controls.AddRange(new Control[] { lblA, txtA, lblB, txtB, lblKetQua, txtKetQua, btnCong, btnTru, btnNhan, btnChia });
    }

    private void FilterNumberInput(object? sender, KeyPressEventArgs e)
    {
        TextBox txt = (TextBox)sender!;
        if (char.IsControl(e.KeyChar)) return;

        // Cho phép dấu âm ở đầu
        if (e.KeyChar == '-' && txt.SelectionStart == 0 && !txt.Text.Contains('-'))
            return;

        // Cho phép dấu chấm hoặc phẩy thập phân
        if ((e.KeyChar == '.' || e.KeyChar == ',') && !txt.Text.Contains('.') && !txt.Text.Contains(','))
            return;

        if (!char.IsDigit(e.KeyChar))
        {
            e.Handled = true; // Chặn ký tự không phải số
        }
    }

    private void TinhToan(char phepToan)
    {
        errorProvider.Clear();
        bool hopLe = true;

        double a = 0;
        double b = 0;

        // Mức 1: Kiểm tra ErrorProvider
        if (string.IsNullOrWhiteSpace(txtA.Text) || !double.TryParse(txtA.Text.Trim().Replace(',', '.'), System.Globalization.CultureInfo.InvariantCulture, out a))
        {
            errorProvider.SetError(txtA, "Vui lòng nhập số hợp lệ cho a");
            hopLe = false;
        }

        if (string.IsNullOrWhiteSpace(txtB.Text) || !double.TryParse(txtB.Text.Trim().Replace(',', '.'), System.Globalization.CultureInfo.InvariantCulture, out b))
        {
            errorProvider.SetError(txtB, "Vui lòng nhập số hợp lệ cho b");
            hopLe = false;
        }

        if (!hopLe)
        {
            MessageBox.Show("Dữ liệu nhập không hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (phepToan == '/' && Math.Abs(b) < 1e-12)
        {
            errorProvider.SetError(txtB, "Số chia b phải khác 0");
            MessageBox.Show("Không thể chia cho số 0!", "Lỗi toán học", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        double ketQua = phepToan switch
        {
            '+' => a + b,
            '-' => a - b,
            '*' => a * b,
            '/' => a / b,
            _ => 0
        };

        txtKetQua.Text = ketQua.ToString("G");
    }
}
