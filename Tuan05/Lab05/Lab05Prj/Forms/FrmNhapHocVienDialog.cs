using System;
using System.Windows.Forms;

namespace Lab05Prj.Forms;

public partial class FrmNhapHocVienDialog : Form
{
    public string HoTen { get; private set; } = string.Empty;
    public string TenLop { get; private set; } = "Lớp A";

    public FrmNhapHocVienDialog()
    {
        InitializeComponent();
        cboLop.SelectedIndex = 0;
    }

    private void BtnCapNhat_Click(object? sender, EventArgs e)
    {
        string hoTen = txtHoTen.Text.Trim();

        // Kiểm tra họ tên khác rỗng
        if (string.IsNullOrWhiteSpace(hoTen))
        {
            MessageBox.Show("Vui lòng nhập họ và tên học viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtHoTen.Focus();
            return;
        }

        HoTen = hoTen;
        TenLop = cboLop.SelectedItem?.ToString() ?? "Lớp A";
        this.DialogResult = DialogResult.OK;
        this.Close();
    }

    private void BtnTroVe_Click(object? sender, EventArgs e)
    {
        this.DialogResult = DialogResult.Cancel;
        this.Close();
    }
}
