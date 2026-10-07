using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab04Prj.Forms;

public class FrmMyName : Form
{
    private Label lblTitle = null!;
    private Label lblName = null!;
    private TextBox txtYourName = null!;
    private Label lblYear = null!;
    private TextBox txtYear = null!;
    private Button btnShow = null!;
    private Button btnClear = null!;
    private Button btnExit = null!;
    private ErrorProvider errorProvider1 = null!;

    public FrmMyName()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        this.Text = "My name Project";
        this.Font = new Font("Tahoma", 10F, FontStyle.Regular);
        this.Size = new Size(420, 260);
        this.StartPosition = FormStartPosition.CenterScreen;
        this.FormBorderStyle = FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;

        errorProvider1 = new ErrorProvider();

        lblTitle = new Label
        {
            Text = "MY NAME PROJECT",
            Font = new Font("Tahoma", 13F, FontStyle.Bold),
            ForeColor = Color.DarkBlue,
            TextAlign = ContentAlignment.MiddleCenter,
            Location = new Point(20, 15),
            Size = new Size(360, 30)
        };

        lblName = new Label { Text = "Your Name:", Location = new Point(30, 60), Size = new Size(110, 25) };
        txtYourName = new TextBox { Location = new Point(150, 58), Size = new Size(200, 25) };

        lblYear = new Label { Text = "Year of birth:", Location = new Point(30, 100), Size = new Size(110, 25) };
        txtYear = new TextBox { Location = new Point(150, 98), Size = new Size(200, 25) };

        btnShow = new Button { Text = "&Show", Location = new Point(40, 150), Size = new Size(90, 35) };
        btnClear = new Button { Text = "&Clear", Location = new Point(150, 150), Size = new Size(90, 35) };
        btnExit = new Button { Text = "E&xit", Location = new Point(260, 150), Size = new Size(90, 35) };

        this.AcceptButton = btnShow;
        this.CancelButton = btnExit;

        // Events
        txtYourName.Leave += TxtYourName_Leave;
        txtYear.TextChanged += TxtYear_TextChanged;
        btnShow.Click += BtnShow_Click;
        btnClear.Click += BtnClear_Click;
        btnExit.Click += (s, e) => this.Close();
        this.FormClosing += FrmMyName_FormClosing;

        this.Controls.AddRange(new Control[] { lblTitle, lblName, txtYourName, lblYear, txtYear, btnShow, btnClear, btnExit });
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

    private void FrmMyName_FormClosing(object? sender, FormClosingEventArgs e)
    {
        var result = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (result == DialogResult.No)
        {
            e.Cancel = true;
        }
    }
}
