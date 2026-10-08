using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab04Prj.Forms;

public partial class FrmDinhDangFont : Form
{
    public FrmDinhDangFont()
    {
        InitializeComponent();
    }

    private void DinhDang_Changed(object? sender, EventArgs e) => CapNhatDinhDang();
    private void BtnExit_Click(object? sender, EventArgs e) => this.Close();

    private void FrmDinhDangFont_FormClosing(object? sender, FormClosingEventArgs e)
    {
        var r = MessageBox.Show("Bạn có muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (r == DialogResult.No)
        {
            e.Cancel = true;
        }
    }

    private void CapNhatDinhDang()
    {
        // 1. Font style
        FontStyle style = FontStyle.Regular;
        if (chkBold.Checked) style |= FontStyle.Bold;
        if (chkItalic.Checked) style |= FontStyle.Italic;

        lblSample.Font = new Font(lblSample.Font.FontFamily, 13F, style);

        // 2. Color
        if (rdoRed.Checked) lblSample.ForeColor = Color.Red;
        else if (rdoGreen.Checked) lblSample.ForeColor = Color.Green;
        else if (rdoBlue.Checked) lblSample.ForeColor = Color.Blue;
        else lblSample.ForeColor = Color.Black;
    }
}
