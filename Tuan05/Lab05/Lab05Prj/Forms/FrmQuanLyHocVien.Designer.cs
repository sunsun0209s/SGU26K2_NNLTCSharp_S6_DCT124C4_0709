namespace Lab05Prj.Forms;

partial class FrmQuanLyHocVien
{
    private System.ComponentModel.IContainer components = null!;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem mnuCapNhat;
    private System.Windows.Forms.ToolStripMenuItem mnuNhapHocVien;
    private System.Windows.Forms.ToolStripMenuItem mnuChuyenSangLopB;
    private System.Windows.Forms.ToolStripMenuItem mnuChuyenSangLopA;
    private System.Windows.Forms.ToolStripMenuItem mnuXoaHocVien;
    private System.Windows.Forms.ToolStripMenuItem mnuKetThuc;
    private System.Windows.Forms.Label lblLopA;
    private System.Windows.Forms.ListBox lstLopA;
    private System.Windows.Forms.Label lblLopB;
    private System.Windows.Forms.ListBox lstLopB;

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
        menuStrip1 = new MenuStrip();
        mnuCapNhat = new ToolStripMenuItem();
        mnuNhapHocVien = new ToolStripMenuItem();
        mnuChuyenSangLopB = new ToolStripMenuItem();
        mnuChuyenSangLopA = new ToolStripMenuItem();
        mnuXoaHocVien = new ToolStripMenuItem();
        mnuKetThuc = new ToolStripMenuItem();
        lblLopA = new Label();
        lstLopA = new ListBox();
        lblLopB = new Label();
        lstLopB = new ListBox();
        menuStrip1.SuspendLayout();
        SuspendLayout();
        // 
        // menuStrip1
        // 
        menuStrip1.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        menuStrip1.Items.AddRange(new ToolStripItem[] { mnuCapNhat, mnuKetThuc });
        menuStrip1.Location = new Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Size = new Size(540, 25);
        menuStrip1.TabIndex = 0;
        menuStrip1.Text = "menuStrip1";
        // 
        // mnuCapNhat
        // 
        mnuCapNhat.DropDownItems.AddRange(new ToolStripItem[] { mnuNhapHocVien, mnuChuyenSangLopB, mnuChuyenSangLopA, mnuXoaHocVien });
        mnuCapNhat.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
        mnuCapNhat.Name = "mnuCapNhat";
        mnuCapNhat.Size = new Size(77, 21);
        mnuCapNhat.Text = "Cập nhật";
        // 
        // mnuNhapHocVien
        // 
        mnuNhapHocVien.Name = "mnuNhapHocVien";
        mnuNhapHocVien.Size = new Size(187, 22);
        mnuNhapHocVien.Text = "Nhập học viên mới";
        mnuNhapHocVien.Click += MnuNhapHocVien_Click;
        // 
        // mnuChuyenSangLopB
        // 
        mnuChuyenSangLopB.Name = "mnuChuyenSangLopB";
        mnuChuyenSangLopB.Size = new Size(187, 22);
        mnuChuyenSangLopB.Text = "Chuyển sang lớp B";
        mnuChuyenSangLopB.Click += MnuChuyenSangLopB_Click;
        // 
        // mnuChuyenSangLopA
        // 
        mnuChuyenSangLopA.Name = "mnuChuyenSangLopA";
        mnuChuyenSangLopA.Size = new Size(187, 22);
        mnuChuyenSangLopA.Text = "Chuyển sang lớp A";
        mnuChuyenSangLopA.Click += MnuChuyenSangLopA_Click;
        // 
        // mnuXoaHocVien
        // 
        mnuXoaHocVien.Name = "mnuXoaHocVien";
        mnuXoaHocVien.Size = new Size(187, 22);
        mnuXoaHocVien.Text = "Xóa học viên";
        mnuXoaHocVien.Click += MnuXoaHocVien_Click;
        // 
        // mnuKetThuc
        // 
        mnuKetThuc.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
        mnuKetThuc.Name = "mnuKetThuc";
        mnuKetThuc.Size = new Size(74, 21);
        mnuKetThuc.Text = "Kết thúc";
        mnuKetThuc.Click += MnuKetThuc_Click;
        // 
        // lblLopA
        // 
        lblLopA.AutoSize = true;
        lblLopA.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
        lblLopA.ForeColor = Color.DarkBlue;
        lblLopA.Location = new Point(40, 45);
        lblLopA.Name = "lblLopA";
        lblLopA.Size = new Size(52, 17);
        lblLopA.TabIndex = 1;
        lblLopA.Text = "Lớp A:";
        // 
        // lstLopA
        // 
        lstLopA.Font = new Font("Times New Roman", 11.25F);
        lstLopA.FormattingEnabled = true;
        lstLopA.ItemHeight = 17;
        lstLopA.Location = new Point(40, 70);
        lstLopA.Name = "lstLopA";
        lstLopA.SelectionMode = SelectionMode.MultiExtended;
        lstLopA.Size = new Size(210, 242);
        lstLopA.TabIndex = 2;
        // 
        // lblLopB
        // 
        lblLopB.AutoSize = true;
        lblLopB.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
        lblLopB.ForeColor = Color.DarkBlue;
        lblLopB.Location = new Point(290, 45);
        lblLopB.Name = "lblLopB";
        lblLopB.Size = new Size(53, 17);
        lblLopB.TabIndex = 3;
        lblLopB.Text = "Lớp B:";
        // 
        // lstLopB
        // 
        lstLopB.Font = new Font("Times New Roman", 11.25F);
        lstLopB.FormattingEnabled = true;
        lstLopB.ItemHeight = 17;
        lstLopB.Location = new Point(290, 70);
        lstLopB.Name = "lstLopB";
        lstLopB.SelectionMode = SelectionMode.MultiExtended;
        lstLopB.Size = new Size(210, 242);
        lstLopB.TabIndex = 4;
        // 
        // FrmQuanLyHocVien
        // 
        AutoScaleDimensions = new SizeF(8F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(246, 248, 250);
        ClientSize = new Size(540, 340);
        Controls.Add(lstLopB);
        Controls.Add(lblLopB);
        Controls.Add(lstLopA);
        Controls.Add(lblLopA);
        Controls.Add(menuStrip1);
        Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MainMenuStrip = menuStrip1;
        Margin = new Padding(4);
        MaximizeBox = false;
        Name = "FrmQuanLyHocVien";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Quản lý học viên";
        Load += FrmQuanLyHocVien_Load;
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }
}
