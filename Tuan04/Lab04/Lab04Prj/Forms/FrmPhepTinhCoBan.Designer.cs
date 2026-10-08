namespace Lab04Prj.Forms;

partial class FrmPhepTinhCoBan
{
    private System.ComponentModel.IContainer components = null!;
    private System.Windows.Forms.Label lblA;
    private System.Windows.Forms.TextBox txtA;
    private System.Windows.Forms.Label lblB;
    private System.Windows.Forms.TextBox txtB;
    private System.Windows.Forms.Label lblKetQua;
    private System.Windows.Forms.TextBox txtKetQua;
    private System.Windows.Forms.Button btnCong;
    private System.Windows.Forms.Button btnTru;
    private System.Windows.Forms.Button btnNhan;
    private System.Windows.Forms.Button btnChia;
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
        this.btnCong = new System.Windows.Forms.Button();
        this.btnTru = new System.Windows.Forms.Button();
        this.btnNhan = new System.Windows.Forms.Button();
        this.btnChia = new System.Windows.Forms.Button();
        this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
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
        this.txtA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FilterNumberInput);

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
        this.txtB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FilterNumberInput);

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

        // btnCong
        this.btnCong.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
        this.btnCong.Location = new System.Drawing.Point(40, 115);
        this.btnCong.Name = "btnCong";
        this.btnCong.Size = new System.Drawing.Size(65, 40);
        this.btnCong.TabIndex = 6;
        this.btnCong.Text = "+";
        this.btnCong.UseVisualStyleBackColor = true;
        this.btnCong.Click += new System.EventHandler(this.BtnCong_Click);

        // btnTru
        this.btnTru.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
        this.btnTru.Location = new System.Drawing.Point(125, 115);
        this.btnTru.Name = "btnTru";
        this.btnTru.Size = new System.Drawing.Size(65, 40);
        this.btnTru.TabIndex = 7;
        this.btnTru.Text = "-";
        this.btnTru.UseVisualStyleBackColor = true;
        this.btnTru.Click += new System.EventHandler(this.BtnTru_Click);

        // btnNhan
        this.btnNhan.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
        this.btnNhan.Location = new System.Drawing.Point(210, 115);
        this.btnNhan.Name = "btnNhan";
        this.btnNhan.Size = new System.Drawing.Size(65, 40);
        this.btnNhan.TabIndex = 8;
        this.btnNhan.Text = "x";
        this.btnNhan.UseVisualStyleBackColor = true;
        this.btnNhan.Click += new System.EventHandler(this.BtnNhan_Click);

        // btnChia
        this.btnChia.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
        this.btnChia.Location = new System.Drawing.Point(295, 115);
        this.btnChia.Name = "btnChia";
        this.btnChia.Size = new System.Drawing.Size(65, 40);
        this.btnChia.TabIndex = 9;
        this.btnChia.Text = "/";
        this.btnChia.UseVisualStyleBackColor = true;
        this.btnChia.Click += new System.EventHandler(this.BtnChia_Click);

        // errorProvider
        this.errorProvider.ContainerControl = this;

        // FrmPhepTinhCoBan
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(404, 201);
        this.Controls.Add(this.btnChia);
        this.Controls.Add(this.btnNhan);
        this.Controls.Add(this.btnTru);
        this.Controls.Add(this.btnCong);
        this.Controls.Add(this.txtKetQua);
        this.Controls.Add(this.lblKetQua);
        this.Controls.Add(this.txtB);
        this.Controls.Add(this.lblB);
        this.Controls.Add(this.txtA);
        this.Controls.Add(this.lblA);
        this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.Name = "FrmPhepTinhCoBan";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Cộng trừ nhân chia";
        this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPhepTinhCoBan_FormClosing);
        ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }
}
