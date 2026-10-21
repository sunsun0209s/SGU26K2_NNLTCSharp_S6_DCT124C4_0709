namespace Lab05Prj.Forms;

partial class FrmDongHoDemNguoc
{
    private System.ComponentModel.IContainer components = null!;
    private System.Windows.Forms.Label lblDemNguoc;
    private System.Windows.Forms.Button btnBatDau;
    private System.Windows.Forms.Button btnDatLai;
    private System.Windows.Forms.Timer timerDemNguoc;

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
        lblDemNguoc = new Label();
        btnBatDau = new Button();
        btnDatLai = new Button();
        timerDemNguoc = new System.Windows.Forms.Timer(components);
        SuspendLayout();
        // 
        // lblDemNguoc
        // 
        lblDemNguoc.BackColor = Color.White;
        lblDemNguoc.BorderStyle = BorderStyle.FixedSingle;
        lblDemNguoc.Font = new Font("Consolas", 28F, FontStyle.Bold);
        lblDemNguoc.ForeColor = Color.Black;
        lblDemNguoc.Location = new Point(45, 25);
        lblDemNguoc.Name = "lblDemNguoc";
        lblDemNguoc.Size = new Size(240, 65);
        lblDemNguoc.TabIndex = 0;
        lblDemNguoc.Text = "30:00";
        lblDemNguoc.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // btnBatDau
        // 
        btnBatDau.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
        btnBatDau.Location = new Point(45, 105);
        btnBatDau.Name = "btnBatDau";
        btnBatDau.Size = new Size(115, 36);
        btnBatDau.TabIndex = 1;
        btnBatDau.Text = "Bắt đầu";
        btnBatDau.UseVisualStyleBackColor = true;
        btnBatDau.Click += BtnBatDau_Click;
        // 
        // btnDatLai
        // 
        btnDatLai.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
        btnDatLai.Location = new Point(170, 105);
        btnDatLai.Name = "btnDatLai";
        btnDatLai.Size = new Size(115, 36);
        btnDatLai.TabIndex = 2;
        btnDatLai.Text = "Đặt lại";
        btnDatLai.UseVisualStyleBackColor = true;
        btnDatLai.Click += BtnDatLai_Click;
        // 
        // timerDemNguoc
        // 
        timerDemNguoc.Interval = 1000;
        timerDemNguoc.Tick += TimerDemNguoc_Tick;
        // 
        // FrmDongHoDemNguoc
        // 
        AutoScaleDimensions = new SizeF(9F, 19F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(246, 248, 250);
        ClientSize = new Size(330, 165);
        Controls.Add(btnDatLai);
        Controls.Add(btnBatDau);
        Controls.Add(lblDemNguoc);
        Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Margin = new Padding(4);
        MaximizeBox = false;
        Name = "FrmDongHoDemNguoc";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Đồng hồ";
        ResumeLayout(false);
    }
}
