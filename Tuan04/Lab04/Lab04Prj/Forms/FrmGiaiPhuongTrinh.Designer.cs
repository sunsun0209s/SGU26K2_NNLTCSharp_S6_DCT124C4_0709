namespace Lab04Prj.Forms;

partial class FrmGiaiPhuongTrinh
{
    private System.ComponentModel.IContainer components = null!;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.GroupBox grpLoai;
    private System.Windows.Forms.RadioButton rdoBacNhat;
    private System.Windows.Forms.RadioButton rdoBacHai;
    private System.Windows.Forms.Label lblA;
    private System.Windows.Forms.TextBox txtA;
    private System.Windows.Forms.Label lblB;
    private System.Windows.Forms.TextBox txtB;
    private System.Windows.Forms.Label lblC;
    private System.Windows.Forms.TextBox txtC;
    private System.Windows.Forms.Label lblKetQua;
    private System.Windows.Forms.TextBox txtKetQua;
    private System.Windows.Forms.Button btnGiai;
    private System.Windows.Forms.Button btnThoat;

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
        this.lblTitle = new System.Windows.Forms.Label();
        this.grpLoai = new System.Windows.Forms.GroupBox();
        this.rdoBacNhat = new System.Windows.Forms.RadioButton();
        this.rdoBacHai = new System.Windows.Forms.RadioButton();
        this.lblA = new System.Windows.Forms.Label();
        this.txtA = new System.Windows.Forms.TextBox();
        this.lblB = new System.Windows.Forms.Label();
        this.txtB = new System.Windows.Forms.TextBox();
        this.lblC = new System.Windows.Forms.Label();
        this.txtC = new System.Windows.Forms.TextBox();
        this.lblKetQua = new System.Windows.Forms.Label();
        this.txtKetQua = new System.Windows.Forms.TextBox();
        this.btnGiai = new System.Windows.Forms.Button();
        this.btnThoat = new System.Windows.Forms.Button();
        this.grpLoai.SuspendLayout();
        this.SuspendLayout();

        // lblTitle
        this.lblTitle.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
        this.lblTitle.ForeColor = System.Drawing.Color.Red;
        this.lblTitle.Location = new System.Drawing.Point(20, 15);
        this.lblTitle.Name = "lblTitle";
        this.lblTitle.Size = new System.Drawing.Size(360, 30);
        this.lblTitle.TabIndex = 0;
        this.lblTitle.Text = "GIẢI PHƯƠNG TRÌNH";
        this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

        // grpLoai
        this.grpLoai.Controls.Add(this.rdoBacHai);
        this.grpLoai.Controls.Add(this.rdoBacNhat);
        this.grpLoai.Location = new System.Drawing.Point(30, 50);
        this.grpLoai.Name = "grpLoai";
        this.grpLoai.Size = new System.Drawing.Size(345, 75);
        this.grpLoai.TabIndex = 1;
        this.grpLoai.TabStop = false;
        this.grpLoai.Text = "Bạn vui lòng chọn";

        // rdoBacNhat
        this.rdoBacNhat.Checked = true;
        this.rdoBacNhat.Location = new System.Drawing.Point(25, 20);
        this.rdoBacNhat.Name = "rdoBacNhat";
        this.rdoBacNhat.Size = new System.Drawing.Size(220, 24);
        this.rdoBacNhat.TabIndex = 0;
        this.rdoBacNhat.TabStop = true;
        this.rdoBacNhat.Text = "Phương trình bậc nhất";
        this.rdoBacNhat.UseVisualStyleBackColor = true;
        this.rdoBacNhat.CheckedChanged += new System.EventHandler(this.RdoLoai_CheckedChanged);

        // rdoBacHai
        this.rdoBacHai.Location = new System.Drawing.Point(25, 45);
        this.rdoBacHai.Name = "rdoBacHai";
        this.rdoBacHai.Size = new System.Drawing.Size(220, 24);
        this.rdoBacHai.TabIndex = 1;
        this.rdoBacHai.Text = "Phương trình bậc hai";
        this.rdoBacHai.UseVisualStyleBackColor = true;
        this.rdoBacHai.CheckedChanged += new System.EventHandler(this.RdoLoai_CheckedChanged);

        // lblA
        this.lblA.Location = new System.Drawing.Point(35, 140);
        this.lblA.Name = "lblA";
        this.lblA.Size = new System.Drawing.Size(70, 25);
        this.lblA.TabIndex = 2;
        this.lblA.Text = "Nhập a:";

        // txtA
        this.txtA.Location = new System.Drawing.Point(110, 138);
        this.txtA.Name = "txtA";
        this.txtA.Size = new System.Drawing.Size(130, 24);
        this.txtA.TabIndex = 3;
        this.txtA.TextChanged += new System.EventHandler(this.Input_TextChanged);

        // lblB
        this.lblB.Location = new System.Drawing.Point(35, 175);
        this.lblB.Name = "lblB";
        this.lblB.Size = new System.Drawing.Size(70, 25);
        this.lblB.TabIndex = 4;
        this.lblB.Text = "Nhập b:";

        // txtB
        this.txtB.Location = new System.Drawing.Point(110, 173);
        this.txtB.Name = "txtB";
        this.txtB.Size = new System.Drawing.Size(130, 24);
        this.txtB.TabIndex = 5;
        this.txtB.TextChanged += new System.EventHandler(this.Input_TextChanged);

        // lblC
        this.lblC.Location = new System.Drawing.Point(35, 210);
        this.lblC.Name = "lblC";
        this.lblC.Size = new System.Drawing.Size(70, 25);
        this.lblC.TabIndex = 6;
        this.lblC.Text = "Nhập c:";
        this.lblC.Visible = false;

        // txtC
        this.txtC.Location = new System.Drawing.Point(110, 208);
        this.txtC.Name = "txtC";
        this.txtC.Size = new System.Drawing.Size(130, 24);
        this.txtC.TabIndex = 7;
        this.txtC.Visible = false;
        this.txtC.TextChanged += new System.EventHandler(this.Input_TextChanged);

        // lblKetQua
        this.lblKetQua.Location = new System.Drawing.Point(35, 250);
        this.lblKetQua.Name = "lblKetQua";
        this.lblKetQua.Size = new System.Drawing.Size(70, 25);
        this.lblKetQua.TabIndex = 8;
        this.lblKetQua.Text = "Kết quả:";

        // txtKetQua
        this.txtKetQua.Location = new System.Drawing.Point(110, 248);
        this.txtKetQua.Name = "txtKetQua";
        this.txtKetQua.ReadOnly = true;
        this.txtKetQua.Size = new System.Drawing.Size(265, 24);
        this.txtKetQua.TabIndex = 9;

        // btnGiai
        this.btnGiai.Enabled = false;
        this.btnGiai.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
        this.btnGiai.Location = new System.Drawing.Point(275, 138);
        this.btnGiai.Name = "btnGiai";
        this.btnGiai.Size = new System.Drawing.Size(95, 40);
        this.btnGiai.TabIndex = 10;
        this.btnGiai.Text = "Giải";
        this.btnGiai.UseVisualStyleBackColor = true;
        this.btnGiai.Click += new System.EventHandler(this.BtnGiai_Click);

        // btnThoat
        this.btnThoat.Location = new System.Drawing.Point(275, 190);
        this.btnThoat.Name = "btnThoat";
        this.btnThoat.Size = new System.Drawing.Size(95, 35);
        this.btnThoat.TabIndex = 11;
        this.btnThoat.Text = "Thoát";
        this.btnThoat.UseVisualStyleBackColor = true;
        this.btnThoat.Click += new System.EventHandler(this.BtnThoat_Click);

        // FrmGiaiPhuongTrinh
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(404, 351);
        this.Controls.Add(this.btnThoat);
        this.Controls.Add(this.btnGiai);
        this.Controls.Add(this.txtKetQua);
        this.Controls.Add(this.lblKetQua);
        this.Controls.Add(this.txtC);
        this.Controls.Add(this.lblC);
        this.Controls.Add(this.txtB);
        this.Controls.Add(this.lblB);
        this.Controls.Add(this.txtA);
        this.Controls.Add(this.lblA);
        this.Controls.Add(this.grpLoai);
        this.Controls.Add(this.lblTitle);
        this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.Name = "FrmGiaiPhuongTrinh";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Giải phương trình bậc 1-2";
        this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmGiaiPhuongTrinh_FormClosing);
        this.grpLoai.ResumeLayout(false);
        this.ResumeLayout(false);
        this.PerformLayout();
    }
}
