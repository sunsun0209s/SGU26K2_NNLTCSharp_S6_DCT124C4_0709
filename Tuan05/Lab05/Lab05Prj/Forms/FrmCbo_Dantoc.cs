using System;
using System.Windows.Forms;

namespace Lab05Prj.Forms;

public partial class FrmCbo_Dantoc : Form
{
    public FrmCbo_Dantoc()
    {
        InitializeComponent();
    }

    private void Btn_loadDL_Click(object? sender, EventArgs e)
    {
        cbo_dt.Items.Clear();
        string[] dt = { "Kinh", "Hoa", "K’Me", "H’Mong", "Khac" };
        foreach (string s in dt)
        {
            cbo_dt.Items.Add(s);
        }

        if (cbo_dt.Items.Count > 0)
        {
            cbo_dt.SelectedIndex = 0;
        }
    }

    private void Btn_hienthi_Click(object? sender, EventArgs e)
    {
        string s = "Dân tộc được chọn: ";
        if (cbo_dt.SelectedIndex >= 0 && cbo_dt.SelectedItem != null)
        {
            lbl_kq.Text = s + cbo_dt.SelectedItem.ToString();
        }
        else
        {
            lbl_kq.Text = "Bạn chưa chọn dân tộc";
        }
    }

    private void Cbo_dt_SelectedIndexChanged(object? sender, EventArgs e)
    {
        if (cbo_dt.SelectedItem != null)
        {
            MessageBox.Show("Dân tộc được chọn: " + cbo_dt.SelectedItem.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

    private void FrmCbo_Dantoc_FormClosing(object? sender, FormClosingEventArgs e)
    {
        var result = MessageBox.Show("Bạn có muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (result == DialogResult.No)
        {
            e.Cancel = true;
        }
    }
}
