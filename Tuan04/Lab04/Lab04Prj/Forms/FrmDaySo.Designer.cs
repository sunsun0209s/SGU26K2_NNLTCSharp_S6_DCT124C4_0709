namespace Lab04Prj.Forms;

partial class FrmDaySo
{
    private System.ComponentModel.IContainer components = null!;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label lblNhap;
    private System.Windows.Forms.TextBox txtNhap;
    private System.Windows.Forms.Button btnNhap;
    private System.Windows.Forms.Label lblDaySo;
    private System.Windows.Forms.TextBox txtDaySo;
    private System.Windows.Forms.Label lblTong;
    private System.Windows.Forms.TextBox txtTong;
    private System.Windows.Forms.Label lblTongChan;
    private System.Windows.Forms.TextBox txtTongChan;
    private System.Windows.Forms.Label lblTongLe;
    private System.Windows.Forms.TextBox txtTongLe;
    private System.Windows.Forms.Button btnTiepTuc;
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
        this.lblNhap = new System.Windows.Forms.Label();
        this.txtNhap = new System.Windows.Forms.TextBox();
        this.btnNhap = new System.Windows.Forms.Button();
        this.lblDaySo = new System.Windows.Forms.Label();
        this.txtDaySo = new System.Windows.Forms.TextBox();
        this.lblTong = new System.Windows.Forms.Label();
        this.txtTong = new System.Windows.Forms.TextBox();
        this.lblTongChan = new System.Windows.Forms.Label();
        this.txtTongChan = new System.Windows.Forms.TextBox();
        this.lblTongLe = new System.Windows.Forms.Label();
        this.txtTongLe = new System.Windows.Forms.TextBox();
        this.btnTiepTuc = new System.Windows.Forms.Button();
        this.btnThoat = new System.Windows.Forms.Button();
        this.SuspendLayout();

        // lblTitle
        this.lblTitle.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
        this.lblTitle.ForeColor = System.Drawing.Color.Crimson;
        this.lblTitle.Location = new System.Drawing.Point(20, 15);
        this.lblTitle.Name = "lblTitle";
        this.lblTitle.Size = new System.Drawing.Size(390, 30);
        this.lblTitle.TabIndex = 0;
        this.lblTitle.Text = "Nhập Dãy Số và Tính Tổng";
        this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

        // lblNhap
        this.lblNhap.Location = new System.Drawing.Point(30, 60);
        this.lblNhap.Name = "lblNhap";
        this.lblNhap.Size = new System.Drawing.Size(130, 25);
        this.lblNhap.TabIndex = 1;
        this.lblNhap.Text = "Nhập số:";

        // txtNhap
        this.txtNhap.Location = new System.Drawing.Point(170, 58);
        this.txtNhap.Name = "txtNhap";
        this.txtNhap.Size = new System.Drawing.Size(110, 24);
        this.txtNhap.TabIndex = 2;

        // btnNhap
        this.btnNhap.Location = new System.Drawing.Point(295, 56);
        this.btnNhap.Name = "btnNhap";
        this.btnNhap.Size = new System.Drawing.Size(90, 28);
        this.btnNhap.TabIndex = 3;
        this.btnNhap.Text = "Nhập";
        this.btnNhap.UseVisualStyleBackColor = true;
        this.btnNhap.Click += new System.EventHandler(this.BtnNhap_Click);

        // lblDaySo
        this.lblDaySo.Location = new System.Drawing.Point(30, 95);
        this.lblDaySo.Name = "lblDaySo";
        this.lblDaySo.Size = new System.Drawing.Size(130, 25);
        this.lblDaySo.TabIndex = 4;
        this.lblDaySo.Text = "Dãy vừa nhập:";

        // txtDaySo
        this.txtDaySo.Location = new System.Drawing.Point(170, 93);
        this.txtDaySo.Name = "txtDaySo";
        this.txtDaySo.ReadOnly = true;
        this.txtDaySo.Size = new System.Drawing.Size(215, 24);
        this.txtDaySo.TabIndex = 5;

        // lblTong
        this.lblTong.Location = new System.Drawing.Point(30, 130);
        this.lblTong.Name = "lblTong";
        this.lblTong.Size = new System.Drawing.Size(130, 25);
        this.lblTong.TabIndex = 6;
        this.lblTong.Text = "Tổng các phần tử:";

        // txtTong
        this.txtTong.Location = new System.Drawing.Point(170, 128);
        this.txtTong.Name = "txtTong";
        this.txtTong.ReadOnly = true;
        this.txtTong.Size = new System.Drawing.Size(215, 24);
        this.txtTong.TabIndex = 7;

        // lblTongChan
        this.lblTongChan.Location = new System.Drawing.Point(30, 165);
        this.lblTongChan.Name = "lblTongChan";
        this.lblTongChan.Size = new System.Drawing.Size(80, 25);
        this.lblTongChan.TabIndex = 8;
        this.lblTongChan.Text = "Tổng Chẵn:";

        // txtTongChan
        this.txtTongChan.Location = new System.Drawing.Point(115, 163);
        this.txtTongChan.Name = "txtTongChan";
        this.txtTongChan.ReadOnly = true;
        this.txtTongChan.Size = new System.Drawing.Size(80, 24);
        this.txtTongChan.TabIndex = 9;

        // lblTongLe
        this.lblTongLe.Location = new System.Drawing.Point(215, 165);
        this.lblTongLe.Name = "lblTongLe";
        this.lblTongLe.Size = new System.Drawing.Size(80, 25);
        this.lblTongLe.TabIndex = 10;
        this.lblTongLe.Text = "Tổng Lẻ:";

        // txtTongLe
        this.txtTongLe.Location = new System.Drawing.Point(305, 163);
        this.txtTongLe.Name = "txtTongLe";
        this.txtTongLe.ReadOnly = true;
        this.txtTongLe.Size = new System.Drawing.Size(80, 24);
        this.txtTongLe.TabIndex = 11;

        // btnTiepTuc
        this.btnTiepTuc.Location = new System.Drawing.Point(115, 220);
        this.btnTiepTuc.Name = "btnTiepTuc";
        this.btnTiepTuc.Size = new System.Drawing.Size(100, 35);
        this.btnTiepTuc.TabIndex = 12;
        this.btnTiepTuc.Text = "Tiếp Tục";
        this.btnTiepTuc.UseVisualStyleBackColor = true;
        this.btnTiepTuc.Click += new System.EventHandler(this.BtnTiepTuc_Click);

        // btnThoat
        this.btnThoat.Location = new System.Drawing.Point(235, 220);
        this.btnThoat.Name = "btnThoat";
        this.btnThoat.Size = new System.Drawing.Size(100, 35);
        this.btnThoat.TabIndex = 13;
        this.btnThoat.Text = "Thoát";
        this.btnThoat.UseVisualStyleBackColor = true;
        this.btnThoat.Click += new System.EventHandler(this.BtnThoat_Click);

        // FrmDaySo
        this.AcceptButton = this.btnNhap;
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(434, 291);
        this.Controls.Add(this.btnThoat);
        this.Controls.Add(this.btnTiepTuc);
        this.Controls.Add(this.txtTongLe);
        this.Controls.Add(this.lblTongLe);
        this.Controls.Add(this.txtTongChan);
        this.Controls.Add(this.lblTongChan);
        this.Controls.Add(this.txtTong);
        this.Controls.Add(this.lblTong);
        this.Controls.Add(this.txtDaySo);
        this.Controls.Add(this.lblDaySo);
        this.Controls.Add(this.btnNhap);
        this.Controls.Add(this.txtNhap);
        this.Controls.Add(this.lblNhap);
        this.Controls.Add(this.lblTitle);
        this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.Name = "FrmDaySo";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Dãy số và Tính Tổng";
        this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmDaySo_FormClosing);
        this.ResumeLayout(false);
        this.PerformLayout();
    }
}
