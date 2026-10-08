namespace Lab04Prj.Forms;

partial class FrmTinhToanRadio
{
    private System.ComponentModel.IContainer components = null!;
    private System.Windows.Forms.Label lblA;
    private System.Windows.Forms.TextBox txtA;
    private System.Windows.Forms.Label lblB;
    private System.Windows.Forms.TextBox txtB;
    private System.Windows.Forms.Label lblKetQua;
    private System.Windows.Forms.TextBox txtKetQua;
    private System.Windows.Forms.GroupBox grpPhepToan;
    private System.Windows.Forms.RadioButton rdoCong;
    private System.Windows.Forms.RadioButton rdoTru;
    private System.Windows.Forms.RadioButton rdoNhan;
    private System.Windows.Forms.RadioButton rdoChia;
    private System.Windows.Forms.Button btnTinh;
    private System.Windows.Forms.ErrorProvider errorProvider;

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
        this.components = new System.ComponentModel.Container();
        this.lblA = new System.Windows.Forms.Label();
        this.txtA = new System.Windows.Forms.TextBox();
        this.lblB = new System.Windows.Forms.Label();
        this.txtB = new System.Windows.Forms.TextBox();
        this.lblKetQua = new System.Windows.Forms.Label();
        this.txtKetQua = new System.Windows.Forms.TextBox();
        this.grpPhepToan = new System.Windows.Forms.GroupBox();
        this.rdoCong = new System.Windows.Forms.RadioButton();
        this.rdoTru = new System.Windows.Forms.RadioButton();
        this.rdoNhan = new System.Windows.Forms.RadioButton();
        this.rdoChia = new System.Windows.Forms.RadioButton();
        this.btnTinh = new System.Windows.Forms.Button();
        this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
        this.grpPhepToan.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
        this.SuspendLayout();

        // lblA
        this.lblA.Location = new System.Drawing.Point(30, 25);
        this.lblA.Name = "lblA";
        this.lblA.Size = new System.Drawing.Size(40, 25);
        this.lblA.TabIndex = 0;
        this.lblA.Text = "a =";

        // txtA
        this.txtA.Location = new System.Drawing.Point(75, 22);
        this.txtA.Name = "txtA";
        this.txtA.Size = new System.Drawing.Size(110, 24);
        this.txtA.TabIndex = 1;

        // lblB
        this.lblB.Location = new System.Drawing.Point(220, 25);
        this.lblB.Name = "lblB";
        this.lblB.Size = new System.Drawing.Size(40, 25);
        this.lblB.TabIndex = 2;
        this.lblB.Text = "b =";

        // txtB
        this.txtB.Location = new System.Drawing.Point(265, 22);
        this.txtB.Name = "txtB";
        this.txtB.Size = new System.Drawing.Size(110, 24);
        this.txtB.TabIndex = 3;

        // lblKetQua
        this.lblKetQua.Location = new System.Drawing.Point(30, 65);
        this.lblKetQua.Name = "lblKetQua";
        this.lblKetQua.Size = new System.Drawing.Size(60, 25);
        this.lblKetQua.TabIndex = 4;
        this.lblKetQua.Text = "Kết quả";

        // txtKetQua
        this.txtKetQua.Location = new System.Drawing.Point(100, 62);
        this.txtKetQua.Name = "txtKetQua";
        this.txtKetQua.ReadOnly = true;
        this.txtKetQua.Size = new System.Drawing.Size(275, 24);
        this.txtKetQua.TabIndex = 5;

        // grpPhepToan
        this.grpPhepToan.Controls.Add(this.rdoChia);
        this.grpPhepToan.Controls.Add(this.rdoNhan);
        this.grpPhepToan.Controls.Add(this.rdoTru);
        this.grpPhepToan.Controls.Add(this.rdoCong);
        this.grpPhepToan.Location = new System.Drawing.Point(30, 100);
        this.grpPhepToan.Name = "grpPhepToan";
        this.grpPhepToan.Size = new System.Drawing.Size(345, 55);
        this.grpPhepToan.TabIndex = 6;
        this.grpPhepToan.TabStop = false;
        this.grpPhepToan.Text = "Phép toán";

        // rdoCong
        this.rdoCong.Checked = true;
        this.rdoCong.Location = new System.Drawing.Point(20, 20);
        this.rdoCong.Name = "rdoCong";
        this.rdoCong.Size = new System.Drawing.Size(60, 25);
        this.rdoCong.TabIndex = 0;
        this.rdoCong.TabStop = true;
        this.rdoCong.Text = "+";
        this.rdoCong.UseVisualStyleBackColor = true;

        // rdoTru
        this.rdoTru.Location = new System.Drawing.Point(100, 20);
        this.rdoTru.Name = "rdoTru";
        this.rdoTru.Size = new System.Drawing.Size(60, 25);
        this.rdoTru.TabIndex = 1;
        this.rdoTru.Text = "-";
        this.rdoTru.UseVisualStyleBackColor = true;

        // rdoNhan
        this.rdoNhan.Location = new System.Drawing.Point(180, 20);
        this.rdoNhan.Name = "rdoNhan";
        this.rdoNhan.Size = new System.Drawing.Size(60, 25);
        this.rdoNhan.TabIndex = 2;
        this.rdoNhan.Text = "x";
        this.rdoNhan.UseVisualStyleBackColor = true;

        // rdoChia
        this.rdoChia.Location = new System.Drawing.Point(260, 20);
        this.rdoChia.Name = "rdoChia";
        this.rdoChia.Size = new System.Drawing.Size(60, 25);
        this.rdoChia.TabIndex = 3;
        this.rdoChia.Text = "/";
        this.rdoChia.UseVisualStyleBackColor = true;

        // btnTinh
        this.btnTinh.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
        this.btnTinh.Location = new System.Drawing.Point(155, 170);
        this.btnTinh.Name = "btnTinh";
        this.btnTinh.Size = new System.Drawing.Size(100, 35);
        this.btnTinh.TabIndex = 7;
        this.btnTinh.Text = "Tính";
        this.btnTinh.UseVisualStyleBackColor = true;
        this.btnTinh.Click += new System.EventHandler(this.BtnTinh_Click);

        // errorProvider
        this.errorProvider.ContainerControl = this;

        // FrmTinhToanRadio
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(404, 221);
        this.Controls.Add(this.btnTinh);
        this.Controls.Add(this.grpPhepToan);
        this.Controls.Add(this.txtKetQua);
        this.Controls.Add(this.lblKetQua);
        this.Controls.Add(this.txtB);
        this.Controls.Add(this.lblB);
        this.Controls.Add(this.txtA);
        this.Controls.Add(this.lblA);
        this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.Name = "FrmTinhToanRadio";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Cộng trừ nhân chia Radio";
        this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmTinhToanRadio_FormClosing);
        this.grpPhepToan.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }
}
