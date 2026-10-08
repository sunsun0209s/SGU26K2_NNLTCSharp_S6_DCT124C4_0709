namespace Lab04Prj.Forms;

partial class FrmKhachSanThanhThanh
{
    private System.ComponentModel.IContainer components = null!;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label lblHoTen;
    private System.Windows.Forms.TextBox txtHoTen;
    private System.Windows.Forms.Label lblDiaChi;
    private System.Windows.Forms.TextBox txtDiaChi;
    private System.Windows.Forms.Label lblSoNgay;
    private System.Windows.Forms.TextBox txtSoNgay;
    private System.Windows.Forms.Button btnThanhToan;
    private System.Windows.Forms.Button btnNhapMoi;
    private System.Windows.Forms.Label lblThanhTien;
    private System.Windows.Forms.TextBox txtThanhTien;
    private System.Windows.Forms.GroupBox grpLoaiPhong;
    private System.Windows.Forms.RadioButton rdoDon;
    private System.Windows.Forms.RadioButton rdoDoi;
    private System.Windows.Forms.RadioButton rdoBa;
    private System.Windows.Forms.GroupBox grpTienNghi;
    private System.Windows.Forms.CheckBox chkTivi;
    private System.Windows.Forms.CheckBox chkInternet;
    private System.Windows.Forms.CheckBox chkNuocNong;
    private System.Windows.Forms.GroupBox grpDichVu;
    private System.Windows.Forms.CheckBox chkKaraoke;
    private System.Windows.Forms.CheckBox chkAnSang;
    private System.Windows.Forms.GroupBox grpTongKet;
    private System.Windows.Forms.Label lblTongLuot;
    private System.Windows.Forms.TextBox txtTongLuot;
    private System.Windows.Forms.Label lblTongTien;
    private System.Windows.Forms.TextBox txtTongTien;
    private System.Windows.Forms.Button btnTongKet;
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
        this.lblHoTen = new System.Windows.Forms.Label();
        this.txtHoTen = new System.Windows.Forms.TextBox();
        this.lblDiaChi = new System.Windows.Forms.Label();
        this.txtDiaChi = new System.Windows.Forms.TextBox();
        this.lblSoNgay = new System.Windows.Forms.Label();
        this.txtSoNgay = new System.Windows.Forms.TextBox();
        this.btnThanhToan = new System.Windows.Forms.Button();
        this.btnNhapMoi = new System.Windows.Forms.Button();
        this.lblThanhTien = new System.Windows.Forms.Label();
        this.txtThanhTien = new System.Windows.Forms.TextBox();
        this.grpLoaiPhong = new System.Windows.Forms.GroupBox();
        this.rdoDon = new System.Windows.Forms.RadioButton();
        this.rdoDoi = new System.Windows.Forms.RadioButton();
        this.rdoBa = new System.Windows.Forms.RadioButton();
        this.grpTienNghi = new System.Windows.Forms.GroupBox();
        this.chkTivi = new System.Windows.Forms.CheckBox();
        this.chkInternet = new System.Windows.Forms.CheckBox();
        this.chkNuocNong = new System.Windows.Forms.CheckBox();
        this.grpDichVu = new System.Windows.Forms.GroupBox();
        this.chkKaraoke = new System.Windows.Forms.CheckBox();
        this.chkAnSang = new System.Windows.Forms.CheckBox();
        this.grpTongKet = new System.Windows.Forms.GroupBox();
        this.lblTongLuot = new System.Windows.Forms.Label();
        this.txtTongLuot = new System.Windows.Forms.TextBox();
        this.lblTongTien = new System.Windows.Forms.Label();
        this.txtTongTien = new System.Windows.Forms.TextBox();
        this.btnTongKet = new System.Windows.Forms.Button();
        this.btnThoat = new System.Windows.Forms.Button();
        this.grpLoaiPhong.SuspendLayout();
        this.grpTienNghi.SuspendLayout();
        this.grpDichVu.SuspendLayout();
        this.grpTongKet.SuspendLayout();
        this.SuspendLayout();

        // lblTitle
        this.lblTitle.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
        this.lblTitle.ForeColor = System.Drawing.Color.DarkOrange;
        this.lblTitle.Location = new System.Drawing.Point(20, 10);
        this.lblTitle.Name = "lblTitle";
        this.lblTitle.Size = new System.Drawing.Size(560, 35);
        this.lblTitle.TabIndex = 0;
        this.lblTitle.Text = "KHÁCH SẠN THANH THANH - TRẢ PHÒNG";
        this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

        // lblHoTen
        this.lblHoTen.Location = new System.Drawing.Point(25, 55);
        this.lblHoTen.Name = "lblHoTen";
        this.lblHoTen.Size = new System.Drawing.Size(80, 22);
        this.lblHoTen.TabIndex = 1;
        this.lblHoTen.Text = "Họ và tên:";

        // txtHoTen
        this.txtHoTen.Location = new System.Drawing.Point(110, 52);
        this.txtHoTen.Name = "txtHoTen";
        this.txtHoTen.Size = new System.Drawing.Size(250, 24);
        this.txtHoTen.TabIndex = 2;
        this.txtHoTen.TextChanged += new System.EventHandler(this.ThongTin_Changed);

        // lblDiaChi
        this.lblDiaChi.Location = new System.Drawing.Point(25, 85);
        this.lblDiaChi.Name = "lblDiaChi";
        this.lblDiaChi.Size = new System.Drawing.Size(80, 22);
        this.lblDiaChi.TabIndex = 3;
        this.lblDiaChi.Text = "Địa chỉ:";

        // txtDiaChi
        this.txtDiaChi.Location = new System.Drawing.Point(110, 82);
        this.txtDiaChi.Name = "txtDiaChi";
        this.txtDiaChi.Size = new System.Drawing.Size(250, 24);
        this.txtDiaChi.TabIndex = 4;

        // lblSoNgay
        this.lblSoNgay.Location = new System.Drawing.Point(25, 115);
        this.lblSoNgay.Name = "lblSoNgay";
        this.lblSoNgay.Size = new System.Drawing.Size(80, 22);
        this.lblSoNgay.TabIndex = 5;
        this.lblSoNgay.Text = "Số ngày ở:";

        // txtSoNgay
        this.txtSoNgay.Location = new System.Drawing.Point(110, 112);
        this.txtSoNgay.Name = "txtSoNgay";
        this.txtSoNgay.Size = new System.Drawing.Size(100, 24);
        this.txtSoNgay.TabIndex = 6;
        this.txtSoNgay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSoNgay_KeyPress);
        this.txtSoNgay.TextChanged += new System.EventHandler(this.ThongTin_Changed);

        // btnThanhToan
        this.btnThanhToan.Enabled = false;
        this.btnThanhToan.Location = new System.Drawing.Point(380, 52);
        this.btnThanhToan.Name = "btnThanhToan";
        this.btnThanhToan.Size = new System.Drawing.Size(95, 30);
        this.btnThanhToan.TabIndex = 7;
        this.btnThanhToan.Text = "Thanh toán";
        this.btnThanhToan.UseVisualStyleBackColor = true;
        this.btnThanhToan.Click += new System.EventHandler(this.BtnThanhToan_Click);

        // btnNhapMoi
        this.btnNhapMoi.Enabled = false;
        this.btnNhapMoi.Location = new System.Drawing.Point(485, 52);
        this.btnNhapMoi.Name = "btnNhapMoi";
        this.btnNhapMoi.Size = new System.Drawing.Size(95, 30);
        this.btnNhapMoi.TabIndex = 8;
        this.btnNhapMoi.Text = "Nhập mới";
        this.btnNhapMoi.UseVisualStyleBackColor = true;
        this.btnNhapMoi.Click += new System.EventHandler(this.BtnNhapMoi_Click);

        // lblThanhTien
        this.lblThanhTien.Location = new System.Drawing.Point(380, 95);
        this.lblThanhTien.Name = "lblThanhTien";
        this.lblThanhTien.Size = new System.Drawing.Size(80, 22);
        this.lblThanhTien.TabIndex = 9;
        this.lblThanhTien.Text = "Thành tiền:";

        // txtThanhTien
        this.txtThanhTien.Location = new System.Drawing.Point(460, 92);
        this.txtThanhTien.Name = "txtThanhTien";
        this.txtThanhTien.ReadOnly = true;
        this.txtThanhTien.Size = new System.Drawing.Size(120, 24);
        this.txtThanhTien.TabIndex = 10;
        this.txtThanhTien.Text = "0 VNĐ";
        this.txtThanhTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

        // grpLoaiPhong
        this.grpLoaiPhong.Controls.Add(this.rdoBa);
        this.grpLoaiPhong.Controls.Add(this.rdoDoi);
        this.grpLoaiPhong.Controls.Add(this.rdoDon);
        this.grpLoaiPhong.Location = new System.Drawing.Point(25, 150);
        this.grpLoaiPhong.Name = "grpLoaiPhong";
        this.grpLoaiPhong.Size = new System.Drawing.Size(160, 140);
        this.grpLoaiPhong.TabIndex = 11;
        this.grpLoaiPhong.TabStop = false;
        this.grpLoaiPhong.Text = "Loại phòng";

        // rdoDon
        this.rdoDon.Location = new System.Drawing.Point(15, 20);
        this.rdoDon.Name = "rdoDon";
        this.rdoDon.Size = new System.Drawing.Size(130, 35);
        this.rdoDon.TabIndex = 0;
        this.rdoDon.Text = "Phòng đơn\n(300k/ngày)";
        this.rdoDon.UseVisualStyleBackColor = true;
        this.rdoDon.CheckedChanged += new System.EventHandler(this.ThongTin_Changed);

        // rdoDoi
        this.rdoDoi.Location = new System.Drawing.Point(15, 58);
        this.rdoDoi.Name = "rdoDoi";
        this.rdoDoi.Size = new System.Drawing.Size(130, 35);
        this.rdoDoi.TabIndex = 1;
        this.rdoDoi.Text = "Phòng đôi\n(350k/ngày)";
        this.rdoDoi.UseVisualStyleBackColor = true;
        this.rdoDoi.CheckedChanged += new System.EventHandler(this.ThongTin_Changed);

        // rdoBa
        this.rdoBa.Location = new System.Drawing.Point(15, 96);
        this.rdoBa.Name = "rdoBa";
        this.rdoBa.Size = new System.Drawing.Size(130, 35);
        this.rdoBa.TabIndex = 2;
        this.rdoBa.Text = "Phòng ba\n(400k/ngày)";
        this.rdoBa.UseVisualStyleBackColor = true;
        this.rdoBa.CheckedChanged += new System.EventHandler(this.ThongTin_Changed);

        // grpTienNghi
        this.grpTienNghi.Controls.Add(this.chkNuocNong);
        this.grpTienNghi.Controls.Add(this.chkInternet);
        this.grpTienNghi.Controls.Add(this.chkTivi);
        this.grpTienNghi.Location = new System.Drawing.Point(200, 150);
        this.grpTienNghi.Name = "grpTienNghi";
        this.grpTienNghi.Size = new System.Drawing.Size(175, 140);
        this.grpTienNghi.TabIndex = 12;
        this.grpTienNghi.TabStop = false;
        this.grpTienNghi.Text = "Tiện nghi (+10k/loại)";

        // chkTivi
        this.chkTivi.Location = new System.Drawing.Point(15, 25);
        this.chkTivi.Name = "chkTivi";
        this.chkTivi.Size = new System.Drawing.Size(140, 25);
        this.chkTivi.TabIndex = 0;
        this.chkTivi.Text = "Tivi";
        this.chkTivi.UseVisualStyleBackColor = true;

        // chkInternet
        this.chkInternet.Location = new System.Drawing.Point(15, 60);
        this.chkInternet.Name = "chkInternet";
        this.chkInternet.Size = new System.Drawing.Size(140, 25);
        this.chkInternet.TabIndex = 1;
        this.chkInternet.Text = "Internet";
        this.chkInternet.UseVisualStyleBackColor = true;

        // chkNuocNong
        this.chkNuocNong.Location = new System.Drawing.Point(15, 95);
        this.chkNuocNong.Name = "chkNuocNong";
        this.chkNuocNong.Size = new System.Drawing.Size(140, 25);
        this.chkNuocNong.TabIndex = 2;
        this.chkNuocNong.Text = "Máy nước nóng";
        this.chkNuocNong.UseVisualStyleBackColor = true;

        // grpDichVu
        this.grpDichVu.Controls.Add(this.chkAnSang);
        this.grpDichVu.Controls.Add(this.chkKaraoke);
        this.grpDichVu.Location = new System.Drawing.Point(390, 150);
        this.grpDichVu.Name = "grpDichVu";
        this.grpDichVu.Size = new System.Drawing.Size(190, 140);
        this.grpDichVu.TabIndex = 13;
        this.grpDichVu.TabStop = false;
        this.grpDichVu.Text = "Dịch vụ";

        // chkKaraoke
        this.chkKaraoke.Location = new System.Drawing.Point(15, 30);
        this.chkKaraoke.Name = "chkKaraoke";
        this.chkKaraoke.Size = new System.Drawing.Size(160, 25);
        this.chkKaraoke.TabIndex = 0;
        this.chkKaraoke.Text = "Karaoke (50.000đ)";
        this.chkKaraoke.UseVisualStyleBackColor = true;

        // chkAnSang
        this.chkAnSang.Location = new System.Drawing.Point(15, 75);
        this.chkAnSang.Name = "chkAnSang";
        this.chkAnSang.Size = new System.Drawing.Size(160, 25);
        this.chkAnSang.TabIndex = 1;
        this.chkAnSang.Text = "Ăn sáng (15k/ngày)";
        this.chkAnSang.UseVisualStyleBackColor = true;

        // grpTongKet
        this.grpTongKet.Controls.Add(this.btnThoat);
        this.grpTongKet.Controls.Add(this.btnTongKet);
        this.grpTongKet.Controls.Add(this.txtTongTien);
        this.grpTongKet.Controls.Add(this.lblTongTien);
        this.grpTongKet.Controls.Add(this.txtTongLuot);
        this.grpTongKet.Controls.Add(this.lblTongLuot);
        this.grpTongKet.Location = new System.Drawing.Point(25, 305);
        this.grpTongKet.Name = "grpTongKet";
        this.grpTongKet.Size = new System.Drawing.Size(555, 115);
        this.grpTongKet.TabIndex = 14;
        this.grpTongKet.TabStop = false;
        this.grpTongKet.Text = "Tổng Kết (Thông tin tổng kết cuối ngày)";

        // lblTongLuot
        this.lblTongLuot.Location = new System.Drawing.Point(20, 30);
        this.lblTongLuot.Name = "lblTongLuot";
        this.lblTongLuot.Size = new System.Drawing.Size(100, 22);
        this.lblTongLuot.TabIndex = 0;
        this.lblTongLuot.Text = "Số lượt người:";

        // txtTongLuot
        this.txtTongLuot.Location = new System.Drawing.Point(130, 28);
        this.txtTongLuot.Name = "txtTongLuot";
        this.txtTongLuot.ReadOnly = true;
        this.txtTongLuot.Size = new System.Drawing.Size(150, 24);
        this.txtTongLuot.TabIndex = 1;
        this.txtTongLuot.Text = "0";

        // lblTongTien
        this.lblTongTien.Location = new System.Drawing.Point(20, 68);
        this.lblTongTien.Name = "lblTongTien";
        this.lblTongTien.Size = new System.Drawing.Size(100, 22);
        this.lblTongTien.TabIndex = 2;
        this.lblTongTien.Text = "Tổng số tiền:";

        // txtTongTien
        this.txtTongTien.Location = new System.Drawing.Point(130, 66);
        this.txtTongTien.Name = "txtTongTien";
        this.txtTongTien.ReadOnly = true;
        this.txtTongTien.Size = new System.Drawing.Size(150, 24);
        this.txtTongTien.TabIndex = 3;
        this.txtTongTien.Text = "0 VNĐ";

        // btnTongKet
        this.btnTongKet.Enabled = false;
        this.btnTongKet.Location = new System.Drawing.Point(320, 35);
        this.btnTongKet.Name = "btnTongKet";
        this.btnTongKet.Size = new System.Drawing.Size(100, 50);
        this.btnTongKet.TabIndex = 4;
        this.btnTongKet.Text = "Tổng Kết";
        this.btnTongKet.UseVisualStyleBackColor = true;
        this.btnTongKet.Click += new System.EventHandler(this.BtnTongKet_Click);

        // btnThoat
        this.btnThoat.Location = new System.Drawing.Point(435, 35);
        this.btnThoat.Name = "btnThoat";
        this.btnThoat.Size = new System.Drawing.Size(100, 50);
        this.btnThoat.TabIndex = 5;
        this.btnThoat.Text = "Thoát";
        this.btnThoat.UseVisualStyleBackColor = true;
        this.btnThoat.Click += new System.EventHandler(this.BtnThoat_Click);

        // FrmKhachSanThanhThanh
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(604, 436);
        this.Controls.Add(this.grpTongKet);
        this.Controls.Add(this.grpDichVu);
        this.Controls.Add(this.grpTienNghi);
        this.Controls.Add(this.grpLoaiPhong);
        this.Controls.Add(this.txtThanhTien);
        this.Controls.Add(this.lblThanhTien);
        this.Controls.Add(this.btnNhapMoi);
        this.Controls.Add(this.btnThanhToan);
        this.Controls.Add(this.txtSoNgay);
        this.Controls.Add(this.lblSoNgay);
        this.Controls.Add(this.txtDiaChi);
        this.Controls.Add(this.lblDiaChi);
        this.Controls.Add(this.txtHoTen);
        this.Controls.Add(this.lblHoTen);
        this.Controls.Add(this.lblTitle);
        this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.Name = "FrmKhachSanThanhThanh";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Quản lý khách sạn Thanh Thanh";
        this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmKhachSanThanhThanh_FormClosing);
        this.grpLoaiPhong.ResumeLayout(false);
        this.grpTienNghi.ResumeLayout(false);
        this.grpDichVu.ResumeLayout(false);
        this.grpTongKet.ResumeLayout(false);
        this.grpTongKet.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();
    }
}
