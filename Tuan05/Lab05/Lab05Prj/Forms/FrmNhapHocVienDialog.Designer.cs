namespace Lab05Prj.Forms;

partial class FrmNhapHocVienDialog
{
    private System.ComponentModel.IContainer components = null!;
    private System.Windows.Forms.Label lblHoTen;
    private System.Windows.Forms.TextBox txtHoTen;
    private System.Windows.Forms.Label lblLop;
    private System.Windows.Forms.ComboBox cboLop;
    private System.Windows.Forms.Button btnCapNhat;
    private System.Windows.Forms.Button btnTroVe;

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
        lblHoTen = new Label();
        txtHoTen = new TextBox();
        lblLop = new Label();
        cboLop = new ComboBox();
        btnCapNhat = new Button();
        btnTroVe = new Button();
        SuspendLayout();
        // 
        // lblHoTen
        // 
        lblHoTen.AutoSize = true;
        lblHoTen.Location = new Point(30, 25);
        lblHoTen.Name = "lblHoTen";
        lblHoTen.Size = new Size(71, 17);
        lblHoTen.TabIndex = 0;
        lblHoTen.Text = "Họ và Tên:";
        // 
        // txtHoTen
        // 
        txtHoTen.Location = new Point(110, 22);
        txtHoTen.Name = "txtHoTen";
        txtHoTen.Size = new Size(230, 25);
        txtHoTen.TabIndex = 1;
        // 
        // lblLop
        // 
        lblLop.AutoSize = true;
        lblLop.Location = new Point(30, 68);
        lblLop.Name = "lblLop";
        lblLop.Size = new Size(35, 17);
        lblLop.TabIndex = 2;
        lblLop.Text = "Lớp:";
        // 
        // cboLop
        // 
        cboLop.DropDownStyle = ComboBoxStyle.DropDownList;
        cboLop.FormattingEnabled = true;
        cboLop.Items.AddRange(new object[] { "Lớp A", "Lớp B" });
        cboLop.Location = new Point(110, 65);
        cboLop.Name = "cboLop";
        cboLop.Size = new Size(230, 25);
        cboLop.TabIndex = 3;
        // 
        // btnCapNhat
        // 
        btnCapNhat.Font = new Font("Times New Roman", 10.5F, FontStyle.Bold);
        btnCapNhat.Location = new Point(125, 115);
        btnCapNhat.Name = "btnCapNhat";
        btnCapNhat.Size = new Size(100, 32);
        btnCapNhat.TabIndex = 4;
        btnCapNhat.Text = "Cập nhật";
        btnCapNhat.UseVisualStyleBackColor = true;
        btnCapNhat.Click += BtnCapNhat_Click;
        // 
        // btnTroVe
        // 
        btnTroVe.Font = new Font("Times New Roman", 10.5F, FontStyle.Bold);
        btnTroVe.Location = new Point(240, 115);
        btnTroVe.Name = "btnTroVe";
        btnTroVe.Size = new Size(100, 32);
        btnTroVe.TabIndex = 5;
        btnTroVe.Text = "Trở về";
        btnTroVe.UseVisualStyleBackColor = true;
        btnTroVe.Click += BtnTroVe_Click;
        // 
        // FrmNhapHocVienDialog
        // 
        AutoScaleDimensions = new SizeF(8F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(246, 248, 250);
        ClientSize = new Size(374, 166);
        Controls.Add(btnTroVe);
        Controls.Add(btnCapNhat);
        Controls.Add(cboLop);
        Controls.Add(lblLop);
        Controls.Add(txtHoTen);
        Controls.Add(lblHoTen);
        Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Margin = new Padding(4);
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "FrmNhapHocVienDialog";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Nhập học viên mới";
        ResumeLayout(false);
        PerformLayout();
    }
}
