using System;
using System.Windows.Forms;

namespace Lab04Prj.Forms;

public partial class FrmMayTinhBoTui : Form
{
    private double firstOperand = 0;
    private char currentOp = ' ';
    private bool isNewEntry = true;

    public FrmMayTinhBoTui()
    {
        InitializeComponent();
    }

    private void BtnDigit_Click(object? sender, EventArgs e)
    {
        if (sender is Button btn)
        {
            ClickNumber(btn.Text);
        }
    }

    private void BtnOp_Click(object? sender, EventArgs e)
    {
        if (sender is Button btn && btn.Text.Length > 0)
        {
            ClickOperator(btn.Text[0]);
        }
    }

    private void BtnBang_Click(object? sender, EventArgs e) => ClickEquals();
    private void BtnC_Click(object? sender, EventArgs e) => ClickClear();

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
