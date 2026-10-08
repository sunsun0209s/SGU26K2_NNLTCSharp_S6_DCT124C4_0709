namespace Lab04Prj.Forms;

partial class FrmCafeSinhVien
{
    private System.ComponentModel.IContainer components = null!;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label lblTenKhach;
    private System.Windows.Forms.TextBox txtTenKhach;
    private System.Windows.Forms.Label lblSoKhach;
    private System.Windows.Forms.TextBox txtSoKhach;
    private System.Windows.Forms.CheckBox chkSinhVien;
    private System.Windows.Forms.GroupBox grpNuocUong;
    private System.Windows.Forms.RadioButton rdoCafeDen;
    private System.Windows.Forms.RadioButton rdoCafeDa;
    private System.Windows.Forms.RadioButton rdoCafeSua;
    private System.Windows.Forms.RadioButton rdoCafeSuaDa;
    private System.Windows.Forms.RadioButton rdoCafeKem;
    private System.Windows.Forms.GroupBox grpThucAn;
    private System.Windows.Forms.CheckBox chkBMTrung;
    private System.Windows.Forms.CheckBox chkBMCa;
    private System.Windows.Forms.CheckBox chkMyTomTrung;
    private System.Windows.Forms.CheckBox chkMyXaoBo;
    private System.Windows.Forms.CheckBox chkMyCay;
    private System.Windows.Forms.Button btnTinhTien;
    private System.Windows.Forms.Button btnNhapLai;
    private System.Windows.Forms.Button btnThanhToan;
    private System.Windows.Forms.Button btnThoat;
    private System.Windows.Forms.Label lblTongKhach;
    private System.Windows.Forms.TextBox txtTongKhach;
    private System.Windows.Forms.Label lblTongTien;
    private System.Windows.Forms.TextBox txtTongTien;

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
        this.lblTenKhach = new System.Windows.Forms.Label();
        this.txtTenKhach = new System.Windows.Forms.TextBox();
        this.lblSoKhach = new System.Windows.Forms.Label();
        this.txtSoKhach = new System.Windows.Forms.TextBox();
        this.chkSinhVien = new System.Windows.Forms.CheckBox();
        this.grpNuocUong = new System.Windows.Forms.GroupBox();
        this.rdoCafeDen = new System.Windows.Forms.RadioButton();
        this.rdoCafeDa = new System.Windows.Forms.RadioButton();
        this.rdoCafeSua = new System.Windows.Forms.RadioButton();
        this.rdoCafeSuaDa = new System.Windows.Forms.RadioButton();
        this.rdoCafeKem = new System.Windows.Forms.RadioButton();
        this.grpThucAn = new System.Windows.Forms.GroupBox();
        this.chkBMTrung = new System.Windows.Forms.CheckBox();
        this.chkBMCa = new System.Windows.Forms.CheckBox();
        this.chkMyTomTrung = new System.Windows.Forms.CheckBox();
        this.chkMyXaoBo = new System.Windows.Forms.CheckBox();
        this.chkMyCay = new System.Windows.Forms.CheckBox();
        this.btnTinhTien = new System.Windows.Forms.Button();
        this.btnNhapLai = new System.Windows.Forms.Button();
        this.btnThanhToan = new System.Windows.Forms.Button();
        this.btnThoat = new System.Windows.Forms.Button();
        this.lblTongKhach = new System.Windows.Forms.Label();
        this.txtTongKhach = new System.Windows.Forms.TextBox();
        this.lblTongTien = new System.Windows.Forms.Label();
        this.txtTongTien = new System.Windows.Forms.TextBox();
        this.grpNuocUong.SuspendLayout();
        this.grpThucAn.SuspendLayout();
        this.SuspendLayout();

        // lblTitle
        this.lblTitle.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
        this.lblTitle.ForeColor = System.Drawing.Color.DarkOrange;
        this.lblTitle.Location = new System.Drawing.Point(20, 10);
        this.lblTitle.Name = "lblTitle";
        this.lblTitle.Size = new System.Drawing.Size(480, 35);
        this.lblTitle.TabIndex = 0;
        this.lblTitle.Text = "CAFE SINH VIÊN";
        this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

        // lblTenKhach
        this.lblTenKhach.Location = new System.Drawing.Point(30, 55);
        this.lblTenKhach.Name = "lblTenKhach";
        this.lblTenKhach.Size = new System.Drawing.Size(130, 25);
        this.lblTenKhach.TabIndex = 1;
        this.lblTenKhach.Text = "Tên khách hàng:";

        // txtTenKhach
        this.txtTenKhach.Location = new System.Drawing.Point(170, 52);
        this.txtTenKhach.Name = "txtTenKhach";
        this.txtTenKhach.Size = new System.Drawing.Size(320, 24);
        this.txtTenKhach.TabIndex = 2;
        this.txtTenKhach.TextChanged += new System.EventHandler(this.ThongTin_Changed);

        // lblSoKhach
        this.lblSoKhach.Location = new System.Drawing.Point(30, 88);
        this.lblSoKhach.Name = "lblSoKhach";
        this.lblSoKhach.Size = new System.Drawing.Size(130, 25);
        this.lblSoKhach.TabIndex = 3;
        this.lblSoKhach.Text = "Số khách hàng:";

        // txtSoKhach
        this.txtSoKhach.Location = new System.Drawing.Point(170, 85);
        this.txtSoKhach.Name = "txtSoKhach";
        this.txtSoKhach.Size = new System.Drawing.Size(320, 24);
        this.txtSoKhach.TabIndex = 4;
        this.txtSoKhach.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSoKhach_KeyPress);
        this.txtSoKhach.TextChanged += new System.EventHandler(this.ThongTin_Changed);

        // chkSinhVien
        this.chkSinhVien.Location = new System.Drawing.Point(170, 118);
        this.chkSinhVien.Name = "chkSinhVien";
        this.chkSinhVien.Size = new System.Drawing.Size(200, 25);
        this.chkSinhVien.TabIndex = 5;
        this.chkSinhVien.Text = "Sinh viên ? (Giảm 20%)";
        this.chkSinhVien.UseVisualStyleBackColor = true;

        // grpNuocUong
        this.grpNuocUong.Controls.Add(this.rdoCafeKem);
        this.grpNuocUong.Controls.Add(this.rdoCafeSuaDa);
        this.grpNuocUong.Controls.Add(this.rdoCafeSua);
        this.grpNuocUong.Controls.Add(this.rdoCafeDa);
        this.grpNuocUong.Controls.Add(this.rdoCafeDen);
        this.grpNuocUong.Location = new System.Drawing.Point(30, 145);
        this.grpNuocUong.Name = "grpNuocUong";
        this.grpNuocUong.Size = new System.Drawing.Size(225, 155);
        this.grpNuocUong.TabIndex = 6;
        this.grpNuocUong.TabStop = false;
        this.grpNuocUong.Text = "Nước uống";

        // rdoCafeDen
        this.rdoCafeDen.Location = new System.Drawing.Point(15, 22);
        this.rdoCafeDen.Name = "rdoCafeDen";
        this.rdoCafeDen.Size = new System.Drawing.Size(190, 24);
        this.rdoCafeDen.TabIndex = 0;
        this.rdoCafeDen.Text = "Cafe đen (20.000đ)";
        this.rdoCafeDen.UseVisualStyleBackColor = true;
        this.rdoCafeDen.CheckedChanged += new System.EventHandler(this.ThongTin_Changed);

        // rdoCafeDa
        this.rdoCafeDa.Location = new System.Drawing.Point(15, 47);
        this.rdoCafeDa.Name = "rdoCafeDa";
        this.rdoCafeDa.Size = new System.Drawing.Size(190, 24);
        this.rdoCafeDa.TabIndex = 1;
        this.rdoCafeDa.Text = "Cafe đá (25.000đ)";
        this.rdoCafeDa.UseVisualStyleBackColor = true;
        this.rdoCafeDa.CheckedChanged += new System.EventHandler(this.ThongTin_Changed);

        // rdoCafeSua
        this.rdoCafeSua.Location = new System.Drawing.Point(15, 72);
        this.rdoCafeSua.Name = "rdoCafeSua";
        this.rdoCafeSua.Size = new System.Drawing.Size(190, 24);
        this.rdoCafeSua.TabIndex = 2;
        this.rdoCafeSua.Text = "Cafe sữa (25.000đ)";
        this.rdoCafeSua.UseVisualStyleBackColor = true;
        this.rdoCafeSua.CheckedChanged += new System.EventHandler(this.ThongTin_Changed);

        // rdoCafeSuaDa
        this.rdoCafeSuaDa.Location = new System.Drawing.Point(15, 97);
        this.rdoCafeSuaDa.Name = "rdoCafeSuaDa";
        this.rdoCafeSuaDa.Size = new System.Drawing.Size(190, 24);
        this.rdoCafeSuaDa.TabIndex = 3;
        this.rdoCafeSuaDa.Text = "Cafe sữa đá (30.000đ)";
        this.rdoCafeSuaDa.UseVisualStyleBackColor = true;
        this.rdoCafeSuaDa.CheckedChanged += new System.EventHandler(this.ThongTin_Changed);

        // rdoCafeKem
        this.rdoCafeKem.Location = new System.Drawing.Point(15, 122);
        this.rdoCafeKem.Name = "rdoCafeKem";
        this.rdoCafeKem.Size = new System.Drawing.Size(190, 24);
        this.rdoCafeKem.TabIndex = 4;
        this.rdoCafeKem.Text = "Cafe kem (35.000đ)";
        this.rdoCafeKem.UseVisualStyleBackColor = true;
        this.rdoCafeKem.CheckedChanged += new System.EventHandler(this.ThongTin_Changed);

        // grpThucAn
        this.grpThucAn.Controls.Add(this.chkMyCay);
        this.grpThucAn.Controls.Add(this.chkMyXaoBo);
        this.grpThucAn.Controls.Add(this.chkMyTomTrung);
        this.grpThucAn.Controls.Add(this.chkBMCa);
        this.grpThucAn.Controls.Add(this.chkBMTrung);
        this.grpThucAn.Location = new System.Drawing.Point(275, 145);
        this.grpThucAn.Name = "grpThucAn";
        this.grpThucAn.Size = new System.Drawing.Size(225, 155);
        this.grpThucAn.TabIndex = 7;
        this.grpThucAn.TabStop = false;
        this.grpThucAn.Text = "Thức ăn";

        // chkBMTrung
        this.chkBMTrung.Location = new System.Drawing.Point(15, 22);
        this.chkBMTrung.Name = "chkBMTrung";
        this.chkBMTrung.Size = new System.Drawing.Size(190, 24);
        this.chkBMTrung.TabIndex = 0;
        this.chkBMTrung.Text = "Bánh mỳ trứng (15k)";
        this.chkBMTrung.UseVisualStyleBackColor = true;

        // chkBMCa
        this.chkBMCa.Location = new System.Drawing.Point(15, 47);
        this.chkBMCa.Name = "chkBMCa";
        this.chkBMCa.Size = new System.Drawing.Size(190, 24);
        this.chkBMCa.TabIndex = 1;
        this.chkBMCa.Text = "Bánh mỳ cá (15k)";
        this.chkBMCa.UseVisualStyleBackColor = true;

        // chkMyTomTrung
        this.chkMyTomTrung.Location = new System.Drawing.Point(15, 72);
        this.chkMyTomTrung.Name = "chkMyTomTrung";
        this.chkMyTomTrung.Size = new System.Drawing.Size(190, 24);
        this.chkMyTomTrung.TabIndex = 2;
        this.chkMyTomTrung.Text = "Mỳ tôm trứng (20k)";
        this.chkMyTomTrung.UseVisualStyleBackColor = true;

        // chkMyXaoBo
        this.chkMyXaoBo.Location = new System.Drawing.Point(15, 97);
        this.chkMyXaoBo.Name = "chkMyXaoBo";
        this.chkMyXaoBo.Size = new System.Drawing.Size(190, 24);
        this.chkMyXaoBo.TabIndex = 3;
        this.chkMyXaoBo.Text = "Mỳ xào bò (30k)";
        this.chkMyXaoBo.UseVisualStyleBackColor = true;

        // chkMyCay
        this.chkMyCay.Location = new System.Drawing.Point(15, 122);
        this.chkMyCay.Name = "chkMyCay";
        this.chkMyCay.Size = new System.Drawing.Size(190, 24);
        this.chkMyCay.TabIndex = 4;
        this.chkMyCay.Text = "Mỳ cay (50k)";
        this.chkMyCay.UseVisualStyleBackColor = true;

        // btnTinhTien
        this.btnTinhTien.Enabled = false;
        this.btnTinhTien.Location = new System.Drawing.Point(30, 315);
        this.btnTinhTien.Name = "btnTinhTien";
        this.btnTinhTien.Size = new System.Drawing.Size(105, 35);
        this.btnTinhTien.TabIndex = 8;
        this.btnTinhTien.Text = "Tính tiền";
        this.btnTinhTien.UseVisualStyleBackColor = true;
        this.btnTinhTien.Click += new System.EventHandler(this.BtnTinhTien_Click);

        // btnNhapLai
        this.btnNhapLai.Enabled = false;
        this.btnNhapLai.Location = new System.Drawing.Point(150, 315);
        this.btnNhapLai.Name = "btnNhapLai";
        this.btnNhapLai.Size = new System.Drawing.Size(105, 35);
        this.btnNhapLai.TabIndex = 9;
        this.btnNhapLai.Text = "Nhập lại";
        this.btnNhapLai.UseVisualStyleBackColor = true;
        this.btnNhapLai.Click += new System.EventHandler(this.BtnNhapLai_Click);

        // btnThanhToan
        this.btnThanhToan.Enabled = false;
        this.btnThanhToan.Location = new System.Drawing.Point(270, 315);
        this.btnThanhToan.Name = "btnThanhToan";
        this.btnThanhToan.Size = new System.Drawing.Size(110, 35);
        this.btnThanhToan.TabIndex = 10;
        this.btnThanhToan.Text = "Thanh toán";
        this.btnThanhToan.UseVisualStyleBackColor = true;
        this.btnThanhToan.Click += new System.EventHandler(this.BtnThanhToan_Click);

        // btnThoat
        this.btnThoat.Location = new System.Drawing.Point(395, 315);
        this.btnThoat.Name = "btnThoat";
        this.btnThoat.Size = new System.Drawing.Size(105, 35);
        this.btnThoat.TabIndex = 11;
        this.btnThoat.Text = "Thoát";
        this.btnThoat.UseVisualStyleBackColor = true;
        this.btnThoat.Click += new System.EventHandler(this.BtnThoat_Click);

        // lblTongKhach
        this.lblTongKhach.Location = new System.Drawing.Point(30, 375);
        this.lblTongKhach.Name = "lblTongKhach";
        this.lblTongKhach.Size = new System.Drawing.Size(150, 25);
        this.lblTongKhach.TabIndex = 12;
        this.lblTongKhach.Text = "Tổng khách hàng:";

        // txtTongKhach
        this.txtTongKhach.Location = new System.Drawing.Point(190, 372);
        this.txtTongKhach.Name = "txtTongKhach";
        this.txtTongKhach.ReadOnly = true;
        this.txtTongKhach.Size = new System.Drawing.Size(300, 24);
        this.txtTongKhach.TabIndex = 13;
        this.txtTongKhach.Text = "0";

        // lblTongTien
        this.lblTongTien.Location = new System.Drawing.Point(30, 415);
        this.lblTongTien.Name = "lblTongTien";
        this.lblTongTien.Size = new System.Drawing.Size(150, 25);
        this.lblTongTien.TabIndex = 14;
        this.lblTongTien.Text = "Tổng tiền thanh toán:";

        // txtTongTien
        this.txtTongTien.Location = new System.Drawing.Point(190, 412);
        this.txtTongTien.Name = "txtTongTien";
        this.txtTongTien.ReadOnly = true;
        this.txtTongTien.Size = new System.Drawing.Size(300, 24);
        this.txtTongTien.TabIndex = 15;
        this.txtTongTien.Text = "0 VNĐ";

        // FrmCafeSinhVien
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(524, 481);
        this.Controls.Add(this.txtTongTien);
        this.Controls.Add(this.lblTongTien);
        this.Controls.Add(this.txtTongKhach);
        this.Controls.Add(this.lblTongKhach);
        this.Controls.Add(this.btnThoat);
        this.Controls.Add(this.btnThanhToan);
        this.Controls.Add(this.btnNhapLai);
        this.Controls.Add(this.btnTinhTien);
        this.Controls.Add(this.grpThucAn);
        this.Controls.Add(this.grpNuocUong);
        this.Controls.Add(this.chkSinhVien);
        this.Controls.Add(this.txtSoKhach);
        this.Controls.Add(this.lblSoKhach);
        this.Controls.Add(this.txtTenKhach);
        this.Controls.Add(this.lblTenKhach);
        this.Controls.Add(this.lblTitle);
        this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.Name = "FrmCafeSinhVien";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Thanh toán tiền";
        this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCafeSinhVien_FormClosing);
        this.grpNuocUong.ResumeLayout(false);
        this.grpThucAn.ResumeLayout(false);
        this.ResumeLayout(false);
        this.PerformLayout();
    }
}
