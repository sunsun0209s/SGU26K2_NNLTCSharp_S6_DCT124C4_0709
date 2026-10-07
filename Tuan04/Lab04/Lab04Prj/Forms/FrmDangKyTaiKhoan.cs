using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Lab04Prj.Forms;

public class FrmDangKyTaiKhoan : Form
{
    private Label lblTitle = null!;
    private Label lblUser = null!;
    private TextBox txtUser = null!;
    private Label lblEmail = null!;
    private TextBox txtEmail = null!;
    private Label lblPass = null!;
    private TextBox txtPass = null!;
    private Label lblConfirm = null!;
    private TextBox txtConfirm = null!;
    private Button btnRegister = null!;
    private ErrorProvider errorProvider = null!;

    public FrmDangKyTaiKhoan()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        this.Text = "Đăng ký tài khoản";
        this.Font = new Font("Tahoma", 10F, FontStyle.Regular);
        this.Size = new Size(460, 320);
        this.StartPosition = FormStartPosition.CenterScreen;
        this.FormBorderStyle = FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;

        errorProvider = new ErrorProvider();

        lblTitle = new Label
        {
            Text = "ĐĂNG KÝ TÀI KHOẢN",
            Font = new Font("Tahoma", 14F, FontStyle.Bold),
            ForeColor = Color.DarkBlue,
            TextAlign = ContentAlignment.MiddleCenter,
            Location = new Point(20, 15),
            Size = new Size(400, 30)
        };

        lblUser = new Label { Text = "Tên đăng nhập (*):", Location = new Point(30, 60), Size = new Size(140, 25) };
        txtUser = new TextBox { Location = new Point(175, 58), Size = new Size(220, 25) };

        lblEmail = new Label { Text = "Địa chỉ email (*):", Location = new Point(30, 100), Size = new Size(140, 25) };
        txtEmail = new TextBox { Location = new Point(175, 98), Size = new Size(220, 25) };

        lblPass = new Label { Text = "Mật khẩu (*):", Location = new Point(30, 140), Size = new Size(140, 25) };
        txtPass = new TextBox { Location = new Point(175, 138), Size = new Size(220, 25), PasswordChar = '*' };

        lblConfirm = new Label { Text = "Xác nhận mật khẩu (*):", Location = new Point(30, 180), Size = new Size(140, 25) };
        txtConfirm = new TextBox { Location = new Point(175, 178), Size = new Size(220, 25), PasswordChar = '*' };

        btnRegister = new Button
        {
            Text = "Đăng ký",
            Font = new Font("Tahoma", 10F, FontStyle.Bold),
            Location = new Point(175, 225),
            Size = new Size(120, 35)
        };

        // Events
        txtEmail.Leave += TxtEmail_Leave;
        txtConfirm.KeyDown += (s, e) =>
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                ThucHienDangKy();
            }
        };
        btnRegister.Click += (s, e) => ThucHienDangKy();

        this.FormClosing += (s, e) =>
        {
            var r = MessageBox.Show("Bạn có muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No) e.Cancel = true;
        };

        this.Controls.AddRange(new Control[] { lblTitle, lblUser, txtUser, lblEmail, txtEmail, lblPass, txtPass, lblConfirm, txtConfirm, btnRegister });
    }

    private void TxtEmail_Leave(object? sender, EventArgs e)
    {
        string email = txtEmail.Text.Trim();
        if (!string.IsNullOrEmpty(email))
        {
            // Kiểm tra định dạng email chuẩn Regex
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(email, pattern))
            {
                errorProvider.SetError(txtEmail, "Định dạng email không hợp lệ (ví dụ: user@domain.com)");
            }
            else
            {
                errorProvider.SetError(txtEmail, string.Empty);
            }
        }
    }

    private void ThucHienDangKy()
    {
        errorProvider.Clear();
        bool hopLe = true;

        if (string.IsNullOrWhiteSpace(txtUser.Text))
        {
            errorProvider.SetError(txtUser, "Bắt buộc nhập tên đăng nhập");
            hopLe = false;
        }

        string email = txtEmail.Text.Trim();
        if (string.IsNullOrWhiteSpace(email))
        {
            errorProvider.SetError(txtEmail, "Bắt buộc nhập email");
            hopLe = false;
        }
        else if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
        {
            errorProvider.SetError(txtEmail, "Email không đúng định dạng");
            hopLe = false;
        }

        if (string.IsNullOrWhiteSpace(txtPass.Text))
        {
            errorProvider.SetError(txtPass, "Bắt buộc nhập mật khẩu");
            hopLe = false;
        }

        if (string.IsNullOrWhiteSpace(txtConfirm.Text))
        {
            errorProvider.SetError(txtConfirm, "Bắt buộc xác nhận mật khẩu");
            hopLe = false;
        }
        else if (txtPass.Text != txtConfirm.Text)
        {
            errorProvider.SetError(txtConfirm, "Mật khẩu xác nhận không trùng khớp!");
            hopLe = false;
        }

        if (!hopLe)
        {
            MessageBox.Show("Vui lòng điền đầy đủ và chính xác các thông tin có dấu (*)", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        string thongTin = $"ĐĂNG KÝ THÀNH CÔNG!\n\n" +
                          $"- Tên đăng nhập: {txtUser.Text.Trim()}\n" +
                          $"- Địa chỉ Email: {txtEmail.Text.Trim()}\n" +
                          $"- Mật khẩu: {new string('*', txtPass.Text.Length)}";

        MessageBox.Show(thongTin, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
