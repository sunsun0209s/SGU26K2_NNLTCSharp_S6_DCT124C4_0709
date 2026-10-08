using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Lab04Prj.Forms;

public partial class FrmDangKyTaiKhoan : Form
{
    public FrmDangKyTaiKhoan()
    {
        InitializeComponent();
    }

    private void BtnRegister_Click(object? sender, EventArgs e) => ThucHienDangKy();

    private void TxtConfirm_KeyDown(object? sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            e.SuppressKeyPress = true;
            ThucHienDangKy();
        }
    }

    private void FrmDangKyTaiKhoan_FormClosing(object? sender, FormClosingEventArgs e)
    {
        var r = MessageBox.Show("Bạn có muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (r == DialogResult.No)
        {
            e.Cancel = true;
        }
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
        else
        {
            errorProvider.SetError(txtEmail, string.Empty);
        }
    }

    private void ThucHienDangKy()
    {
        errorProvider.Clear();
        bool hopLe = true;

        if (string.IsNullOrWhiteSpace(txtUser.Text))
        {
            errorProvider.SetError(txtUser, "Tên đăng nhập không được để trống");
            hopLe = false;
        }

        string email = txtEmail.Text.Trim();
        if (string.IsNullOrWhiteSpace(email))
        {
            errorProvider.SetError(txtEmail, "Email không được để trống");
            hopLe = false;
        }
        else
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(email, pattern))
            {
                errorProvider.SetError(txtEmail, "Định dạng email không hợp lệ");
                hopLe = false;
            }
        }

        if (string.IsNullOrEmpty(txtPass.Text))
        {
            errorProvider.SetError(txtPass, "Mật khẩu không được để trống");
            hopLe = false;
        }

        if (string.IsNullOrEmpty(txtConfirm.Text))
        {
            errorProvider.SetError(txtConfirm, "Vui lòng xác nhận mật khẩu");
            hopLe = false;
        }
        else if (txtPass.Text != txtConfirm.Text)
        {
            errorProvider.SetError(txtConfirm, "Mật khẩu xác nhận không khớp");
            hopLe = false;
        }

        if (!hopLe)
        {
            MessageBox.Show("Vui lòng hoàn thiện đúng các trường thông tin bắt buộc!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        MessageBox.Show("Chúc mừng! Bạn đã đăng ký tài khoản thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
