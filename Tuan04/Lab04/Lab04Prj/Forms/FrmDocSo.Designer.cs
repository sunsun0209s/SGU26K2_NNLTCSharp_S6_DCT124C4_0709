namespace Lab04Prj.Forms;

partial class FrmDocSo
{
    private System.ComponentModel.IContainer components = null!;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label lblNhap;
    private System.Windows.Forms.TextBox txtNhap;
    private System.Windows.Forms.Button btnThucHien;
    private System.Windows.Forms.Button btnXoa;
    private System.Windows.Forms.Button btnThoat;
    private System.Windows.Forms.Label lblKetQua;

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
        this.lblNhap = new System.Windows.Forms.Label();
        this.txtNhap = new System.Windows.Forms.TextBox();
        this.btnThucHien = new System.Windows.Forms.Button();
        this.btnXoa = new System.Windows.Forms.Button();
        this.btnThoat = new System.Windows.Forms.Button();
        this.lblKetQua = new System.Windows.Forms.Label();
        this.SuspendLayout();

        // lblTitle
        this.lblTitle.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
        this.lblTitle.ForeColor = System.Drawing.Color.Red;
        this.lblTitle.Location = new System.Drawing.Point(20, 15);
        this.lblTitle.Name = "lblTitle";
        this.lblTitle.Size = new System.Drawing.Size(360, 30);
        this.lblTitle.TabIndex = 0;
        this.lblTitle.Text = "Đọc Số Thành Chữ";
        this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

        // lblNhap
        this.lblNhap.Location = new System.Drawing.Point(30, 60);
        this.lblNhap.Name = "lblNhap";
        this.lblNhap.Size = new System.Drawing.Size(200, 25);
        this.lblNhap.TabIndex = 1;
        this.lblNhap.Text = "Nhập dãy số: (từ 1 đến 999)";

        // txtNhap
        this.txtNhap.Location = new System.Drawing.Point(235, 58);
        this.txtNhap.Name = "txtNhap";
        this.txtNhap.Size = new System.Drawing.Size(130, 24);
        this.txtNhap.TabIndex = 2;

        // btnThucHien
        this.btnThucHien.Location = new System.Drawing.Point(40, 105);
        this.btnThucHien.Name = "btnThucHien";
        this.btnThucHien.Size = new System.Drawing.Size(95, 35);
        this.btnThucHien.TabIndex = 3;
        this.btnThucHien.Text = "Thực hiện";
        this.btnThucHien.UseVisualStyleBackColor = true;
        this.btnThucHien.Click += new System.EventHandler(this.BtnThucHien_Click);

        // btnXoa
        this.btnXoa.Location = new System.Drawing.Point(155, 105);
        this.btnXoa.Name = "btnXoa";
        this.btnXoa.Size = new System.Drawing.Size(95, 35);
        this.btnXoa.TabIndex = 4;
        this.btnXoa.Text = "Xóa";
        this.btnXoa.UseVisualStyleBackColor = true;
        this.btnXoa.Click += new System.EventHandler(this.BtnXoa_Click);

        // btnThoat
        this.btnThoat.Location = new System.Drawing.Point(270, 105);
        this.btnThoat.Name = "btnThoat";
        this.btnThoat.Size = new System.Drawing.Size(95, 35);
        this.btnThoat.TabIndex = 5;
        this.btnThoat.Text = "Thoát";
        this.btnThoat.UseVisualStyleBackColor = true;
        this.btnThoat.Click += new System.EventHandler(this.BtnThoat_Click);

        // lblKetQua
        this.lblKetQua.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
        this.lblKetQua.ForeColor = System.Drawing.Color.Blue;
        this.lblKetQua.Location = new System.Drawing.Point(20, 160);
        this.lblKetQua.Name = "lblKetQua";
        this.lblKetQua.Size = new System.Drawing.Size(360, 45);
        this.lblKetQua.TabIndex = 6;
        this.lblKetQua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

        // FrmDocSo
        this.AcceptButton = this.btnThucHien;
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(404, 221);
        this.Controls.Add(this.lblKetQua);
        this.Controls.Add(this.btnThoat);
        this.Controls.Add(this.btnXoa);
        this.Controls.Add(this.btnThucHien);
        this.Controls.Add(this.txtNhap);
        this.Controls.Add(this.lblNhap);
        this.Controls.Add(this.lblTitle);
        this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.Name = "FrmDocSo";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Đọc Chữ Số";
        this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmDocSo_FormClosing);
        this.ResumeLayout(false);
        this.PerformLayout();
    }
}
