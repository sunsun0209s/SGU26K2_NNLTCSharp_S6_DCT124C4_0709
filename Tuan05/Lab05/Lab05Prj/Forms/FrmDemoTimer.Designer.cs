namespace Lab05Prj.Forms;

partial class FrmDemoTimer
{
    private System.ComponentModel.IContainer components = null!;
    private System.Windows.Forms.Label lblDongHo;
    private System.Windows.Forms.Label lblTieuDe;
    private System.Windows.Forms.Timer timer1;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        lblDongHo = new Label();
        lblTieuDe = new Label();
        timer1 = new System.Windows.Forms.Timer(components);
        SuspendLayout();
        // 
        // lblDongHo
        // 
        lblDongHo.BorderStyle = BorderStyle.Fixed3D;
        lblDongHo.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
        lblDongHo.ForeColor = Color.DarkRed;
        lblDongHo.Location = new Point(40, 70);
        lblDongHo.Name = "lblDongHo";
        lblDongHo.Size = new Size(340, 70);
        lblDongHo.TabIndex = 0;
        lblDongHo.Text = "00/00/0000 00:00:00";
        lblDongHo.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblTieuDe
        // 
        lblTieuDe.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
        lblTieuDe.ForeColor = Color.Navy;
        lblTieuDe.Location = new Point(40, 25);
        lblTieuDe.Name = "lblTieuDe";
        lblTieuDe.Size = new Size(340, 30);
        lblTieuDe.TabIndex = 1;
        lblTieuDe.Text = "THỜI GIAN HỆ THỐNG HIỆN HÀNH";
        lblTieuDe.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // timer1
        // 
        timer1.Enabled = true;
        timer1.Interval = 1000;
        timer1.Tick += Timer1_Tick;
        // 
        // FrmDemoTimer
        // 
        AutoScaleDimensions = new SizeF(9F, 19F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(245, 248, 250);
        ClientSize = new Size(424, 181);
        Controls.Add(lblTieuDe);
        Controls.Add(lblDongHo);
        Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Margin = new Padding(4);
        MaximizeBox = false;
        Name = "FrmDemoTimer";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Demo Timer";
        Load += FrmDemoTimer_Load;
        ResumeLayout(false);
    }
}
