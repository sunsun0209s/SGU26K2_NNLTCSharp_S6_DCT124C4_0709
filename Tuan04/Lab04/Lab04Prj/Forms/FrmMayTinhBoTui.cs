using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab04Prj.Forms;

public class FrmMayTinhBoTui : Form
{
    private TextBox txtDisplay = null!;
    private double firstOperand = 0;
    private char currentOp = ' ';
    private bool isNewEntry = true;

    public FrmMayTinhBoTui()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        this.Text = "Máy Tính Bỏ Túi";
        this.Font = new Font("Tahoma", 10F, FontStyle.Regular);
        this.Size = new Size(310, 390);
        this.StartPosition = FormStartPosition.CenterScreen;
        this.FormBorderStyle = FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;

        Label lblTitle = new Label
        {
            Text = "Máy Tính Bỏ Túi",
            Font = new Font("Tahoma", 13F, FontStyle.Bold),
            ForeColor = Color.Red,
            TextAlign = ContentAlignment.MiddleCenter,
            Location = new Point(15, 10),
            Size = new Size(265, 30)
        };

        txtDisplay = new TextBox
        {
            Text = "0",
            Font = new Font("Consolas", 16F, FontStyle.Bold),
            TextAlign = HorizontalAlignment.Right,
            ReadOnly = true,
            Location = new Point(20, 50),
            Size = new Size(255, 35),
            BackColor = Color.White
        };

        string[,] buttons = {
            { "7", "8", "9", "/" },
            { "4", "5", "6", "*" },
            { "1", "2", "3", "-" },
            { "0", "C", "=", "+" }
        };

        int startX = 20;
        int startY = 100;
        int btnW = 57;
        int btnH = 50;
        int gap = 9;

        for (int r = 0; r < 4; r++)
        {
            for (int c = 0; c < 4; c++)
            {
                string text = buttons[r, c];
                Button btn = new Button
                {
                    Text = text,
                    Font = new Font("Tahoma", 12F, FontStyle.Bold),
                    Size = new Size(btnW, btnH),
                    Location = new Point(startX + c * (btnW + gap), startY + r * (btnH + gap))
                };

                if (char.IsDigit(text[0]))
                {
                    btn.Click += (s, e) => ClickNumber(text);
                }
                else if (text == "C")
                {
                    btn.BackColor = Color.MistyRose;
                    btn.Click += (s, e) => ClickClear();
                }
                else if (text == "=")
                {
                    btn.BackColor = Color.LightGreen;
                    btn.Click += (s, e) => ClickEquals();
                }
                else
                {
                    btn.BackColor = Color.LightSkyBlue;
                    btn.Click += (s, e) => ClickOperator(text[0]);
                }

                this.Controls.Add(btn);
            }
        }

        this.Controls.Add(lblTitle);
        this.Controls.Add(txtDisplay);
    }

    private void ClickNumber(string num)
    {
        if (isNewEntry || txtDisplay.Text == "0")
        {
            txtDisplay.Text = num;
            isNewEntry = false;
        }
        else
        {
            txtDisplay.Text += num;
        }
    }

    private void ClickOperator(char op)
    {
        if (!isNewEntry && currentOp != ' ')
        {
            ClickEquals();
        }
        double.TryParse(txtDisplay.Text, out firstOperand);
        currentOp = op;
        isNewEntry = true;
    }

    private void ClickEquals()
    {
        if (currentOp == ' ') return;
        double.TryParse(txtDisplay.Text, out double secondOperand);
        double result = 0;

        switch (currentOp)
        {
            case '+': result = firstOperand + secondOperand; break;
            case '-': result = firstOperand - secondOperand; break;
            case '*': result = firstOperand * secondOperand; break;
            case '/':
                if (Math.Abs(secondOperand) < 1e-12)
                {
                    MessageBox.Show("Không thể chia cho số 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClickClear();
                    return;
                }
                result = firstOperand / secondOperand;
                break;
        }

        txtDisplay.Text = result.ToString("G");
        currentOp = ' ';
        isNewEntry = true;
    }

    private void ClickClear()
    {
        firstOperand = 0;
        currentOp = ' ';
        isNewEntry = true;
        txtDisplay.Text = "0";
    }
}
