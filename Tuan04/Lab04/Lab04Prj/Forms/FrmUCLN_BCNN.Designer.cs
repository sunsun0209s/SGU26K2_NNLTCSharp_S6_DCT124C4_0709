namespace Lab04Prj.Forms;

partial class FrmUCLN_BCNN
{
    private System.ComponentModel.IContainer components = null!;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label lblA;
    private System.Windows.Forms.TextBox txtA;
    private System.Windows.Forms.Label lblB;
    private System.Windows.Forms.TextBox txtB;
    private System.Windows.Forms.Label lblUCLN;
    private System.Windows.Forms.TextBox txtUCLN;
    private System.Windows.Forms.Label lblBCNN;
    private System.Windows.Forms.TextBox txtBCNN;
    private System.Windows.Forms.Button btnThucHien;
    private System.Windows.Forms.Button btnTiepTuc;
    private System.Windows.Forms.Button btnThoat;
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
        this.lblTitle = new System.Windows.Forms.Label();
        this.lblA = new System.Windows.Forms.Label();
        this.txtA = new System.Windows.Forms.TextBox();
        this.lblB = new System.Windows.Forms.Label();
        this.txtB = new System.Windows.Forms.TextBox();
        this.lblUCLN = new System.Windows.Forms.Label();
        this.txtUCLN = new System.Windows.Forms.TextBox();
        this.lblBCNN = new System.Windows.Forms.Label();
        this.txtBCNN = new System.Windows.Forms.TextBox();
        this.btnThucHien = new System.Windows.Forms.Button();
        this.btnTiepTuc = new System.Windows.Forms.Button();
        this.btnThoat = new System.Windows.Forms.Button();
        this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
        ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
        this.SuspendLayout();

        // lblTitle
        this.lblTitle.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
        this.lblTitle.ForeColor = System.Drawing.Color.Brown;
        this.lblTitle.Location = new System.Drawing.Point(20, 15);
        this.lblTitle.Name = "lblTitle";
        this.lblTitle.Size = new System.Drawing.Size(360, 30);
        this.lblTitle.TabIndex = 0;
        this.lblTitle.Text = "Ước Số Chung - Bội Số Chung";
        this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

        // lblA
        this.lblA.Location = new System.Drawing.Point(40, 60);
        this.lblA.Name = "lblA";
        this.lblA.Size = new System.Drawing.Size(130, 25);
        this.lblA.TabIndex = 1;
        this.lblA.Text = "Nhập số a:";

        // txtA
        this.txtA.Location = new System.Drawing.Point(180, 58);
        this.txtA.Name = "txtA";
        this.txtA.Size = new System.Drawing.Size(170, 24);
        this.txtA.TabIndex = 2;

        // lblB
        this.lblB.Location = new System.Drawing.Point(40, 95);
        this.lblB.Name = "lblB";
        this.lblB.Size = new System.Drawing.Size(130, 25);
        this.lblB.TabIndex = 3;
        this.lblB.Text = "Nhập số b:";

        // txtB
        this.txtB.Location = new System.Drawing.Point(180, 93);
        this.txtB.Name = "txtB";
        this.txtB.Size = new System.Drawing.Size(170, 24);
        this.txtB.TabIndex = 4;

        // lblUCLN
        this.lblUCLN.Location = new System.Drawing.Point(40, 130);
        this.lblUCLN.Name = "lblUCLN";
        this.lblUCLN.Size = new System.Drawing.Size(140, 25);
        this.lblUCLN.TabIndex = 5;
        this.lblUCLN.Text = "Ước số chung lớn nhất:";

        // txtUCLN
        this.txtUCLN.Location = new System.Drawing.Point(180, 128);
        this.txtUCLN.Name = "txtUCLN";
        this.txtUCLN.ReadOnly = true;
        this.txtUCLN.Size = new System.Drawing.Size(170, 24);
        this.txtUCLN.TabIndex = 6;

        // lblBCNN
        this.lblBCNN.Location = new System.Drawing.Point(40, 165);
        this.lblBCNN.Name = "lblBCNN";
        this.lblBCNN.Size = new System.Drawing.Size(140, 25);
        this.lblBCNN.TabIndex = 7;
        this.lblBCNN.Text = "Bội số chung nhỏ nhất:";

        // txtBCNN
        this.txtBCNN.Location = new System.Drawing.Point(180, 163);
        this.txtBCNN.Name = "txtBCNN";
        this.txtBCNN.ReadOnly = true;
        this.txtBCNN.Size = new System.Drawing.Size(170, 24);
        this.txtBCNN.TabIndex = 8;

        // btnThucHien
        this.btnThucHien.Location = new System.Drawing.Point(40, 210);
        this.btnThucHien.Name = "btnThucHien";
        this.btnThucHien.Size = new System.Drawing.Size(95, 35);
        this.btnThucHien.TabIndex = 9;
        this.btnThucHien.Text = "Thực Hiện";
        this.btnThucHien.UseVisualStyleBackColor = true;
        this.btnThucHien.Click += new System.EventHandler(this.BtnThucHien_Click);

        // btnTiepTuc
        this.btnTiepTuc.Location = new System.Drawing.Point(155, 210);
        this.btnTiepTuc.Name = "btnTiepTuc";
        this.btnTiepTuc.Size = new System.Drawing.Size(95, 35);
        this.btnTiepTuc.TabIndex = 10;
        this.btnTiepTuc.Text = "Tiếp Tục";
        this.btnTiepTuc.UseVisualStyleBackColor = true;
        this.btnTiepTuc.Click += new System.EventHandler(this.BtnTiepTuc_Click);

        // btnThoat
        this.btnThoat.Location = new System.Drawing.Point(270, 210);
        this.btnThoat.Name = "btnThoat";
        this.btnThoat.Size = new System.Drawing.Size(95, 35);
        this.btnThoat.TabIndex = 11;
        this.btnThoat.Text = "Thoát";
        this.btnThoat.UseVisualStyleBackColor = true;
        this.btnThoat.Click += new System.EventHandler(this.BtnThoat_Click);

        // errorProvider
        this.errorProvider.ContainerControl = this;

        // FrmUCLN_BCNN
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(404, 271);
        this.Controls.Add(this.btnThoat);
        this.Controls.Add(this.btnTiepTuc);
        this.Controls.Add(this.btnThucHien);
        this.Controls.Add(this.txtBCNN);
        this.Controls.Add(this.lblBCNN);
        this.Controls.Add(this.txtUCLN);
        this.Controls.Add(this.lblUCLN);
        this.Controls.Add(this.txtB);
        this.Controls.Add(this.lblB);
        this.Controls.Add(this.txtA);
        this.Controls.Add(this.lblA);
        this.Controls.Add(this.lblTitle);
        this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.Name = "FrmUCLN_BCNN";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Ước Số - Bội Số";
        this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmUCLN_BCNN_FormClosing);
        ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }
}
