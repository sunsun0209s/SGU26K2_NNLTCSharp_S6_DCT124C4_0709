using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab04Prj.Forms;

public class FrmDinhDangFont : Form
{
    private Label lblSample = null!;
    private CheckBox chkBold = null!;
    private CheckBox chkItalic = null!;
    private RadioButton rdoAutoColor = null!;
    private RadioButton rdoRed = null!;
    private RadioButton rdoGreen = null!;
    private RadioButton rdoBlue = null!;
    private Button btnExit = null!;

    public FrmDinhDangFont()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        this.Text = "Định dạng Font và Color";
        this.Font = new Font("Tahoma", 10F, FontStyle.Regular);
        this.Size = new Size(460, 320);
        this.StartPosition = FormStartPosition.CenterScreen;
        this.FormBorderStyle = FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;

        lblSample = new Label
        {
            Text = "Trường Đại Học Sài Gòn\nKhoa Công Nghệ Thông Tin",
            Font = new Font("Tahoma", 13F, FontStyle.Regular),
            ForeColor = Color.Black,
            BackColor = Color.WhiteSmoke,
            BorderStyle = BorderStyle.FixedSingle,
            TextAlign = ContentAlignment.MiddleCenter,
            Location = new Point(20, 15),
            Size = new Size(405, 70)
        };

        GroupBox grpFont = new GroupBox
        {
            Text = "Font Style",
            Location = new Point(20, 100),
            Size = new Size(190, 120)
        };

        chkBold = new CheckBox { Text = "Bold", Location = new Point(25, 30), Size = new Size(130, 30) };
        chkItalic = new CheckBox { Text = "Italic", Location = new Point(25, 70), Size = new Size(130, 30) };
        grpFont.Controls.AddRange(new Control[] { chkBold, chkItalic });

        GroupBox grpColor = new GroupBox
        {
            Text = "Color",
            Location = new Point(235, 100),
            Size = new Size(190, 120)
        };

        rdoAutoColor = new RadioButton { Text = "AutoColor", Checked = true, Location = new Point(25, 20), Size = new Size(130, 22) };
        rdoRed = new RadioButton { Text = "Red", Location = new Point(25, 45), Size = new Size(130, 22) };
        rdoGreen = new RadioButton { Text = "Green", Location = new Point(25, 70), Size = new Size(130, 22) };
        rdoBlue = new RadioButton { Text = "Blue", Location = new Point(25, 95), Size = new Size(130, 22) };
        grpColor.Controls.AddRange(new Control[] { rdoAutoColor, rdoRed, rdoGreen, rdoBlue });

        btnExit = new Button { Text = "Exit", Location = new Point(175, 235), Size = new Size(100, 35) };

        chkBold.CheckedChanged += (s, e) => CapNhatDinhDang();
        chkItalic.CheckedChanged += (s, e) => CapNhatDinhDang();
        rdoAutoColor.CheckedChanged += (s, e) => CapNhatDinhDang();
        rdoRed.CheckedChanged += (s, e) => CapNhatDinhDang();
        rdoGreen.CheckedChanged += (s, e) => CapNhatDinhDang();
        rdoBlue.CheckedChanged += (s, e) => CapNhatDinhDang();

        btnExit.Click += (s, e) => this.Close();

        this.FormClosing += (s, e) =>
        {
            var r = MessageBox.Show("Bạn có muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No) e.Cancel = true;
        };

        this.Controls.AddRange(new Control[] { lblSample, grpFont, grpColor, btnExit });
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
