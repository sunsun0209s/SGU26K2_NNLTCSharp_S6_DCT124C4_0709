using System;
using System.Windows.Forms;

namespace Lab05Prj.Forms;

public partial class FrmDemoTimer : Form
{
    public FrmDemoTimer()
    {
        InitializeComponent();
    }

    private void FrmDemoTimer_Load(object? sender, EventArgs e)
    {
        CapNhatThoiGian();
    }

    private void Timer1_Tick(object? sender, EventArgs e)
    {
        CapNhatThoiGian();
    }

    private void CapNhatThoiGian()
    {
        DateTime now = DateTime.Now;
        lblDongHo.Text = now.ToString("dd/MM/yyyy hh:mm:ss tt");
    }
}
