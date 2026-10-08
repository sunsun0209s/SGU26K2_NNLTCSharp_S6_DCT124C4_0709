using System;
using System.Windows.Forms;

namespace Lab04Prj.Forms;

public partial class FrmMyName : Form
{
    public FrmMyName()
    {
        InitializeComponent();
    }

    private void TxtYourName_Leave(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtYourName.Text))
        {
            errorProvider1.SetError(txtYourName, "You must enter Your Name");
        }
        else
        {
            errorProvider1.SetError(txtYourName, string.Empty);
        }
    }

    private void TxtYear_TextChanged(object? sender, EventArgs e)
    {
        string text = txtYear.Text.Trim();
        if (text.Length > 0 && !int.TryParse(text, out _))
        {
            errorProvider1.SetError(txtYear, "This is not a valid number");
        }
        else
        {
            errorProvider1.SetError(txtYear, string.Empty);
        }
    }

    private void BtnShow_Click(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtYourName.Text))
        {
            errorProvider1.SetError(txtYourName, "You must enter Your Name");
            txtYourName.Focus();
            return;
        }

        if (!int.TryParse(txtYear.Text.Trim(), out int year) || year <= 1900 || year > DateTime.Now.Year)
        {
            errorProvider1.SetError(txtYear, "Năm sinh không hợp lệ!");
            txtYear.Focus();
            return;
        }

        int age = DateTime.Now.Year - year;
        string msg = $"My name is: {txtYourName.Text.Trim()}\nAge: {age}";
        MessageBox.Show(msg, "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void BtnClear_Click(object? sender, EventArgs e)
    {
        txtYourName.Clear();
        txtYear.Clear();
        errorProvider1.Clear();
        txtYourName.Focus();
    }

    private void BtnExit_Click(object? sender, EventArgs e)
    {
        this.Close();
    }

    private void FrmMyName_FormClosing(object? sender, FormClosingEventArgs e)
    {
        var result = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (result == DialogResult.No)
        {
            e.Cancel = true;
        }
    }
}
