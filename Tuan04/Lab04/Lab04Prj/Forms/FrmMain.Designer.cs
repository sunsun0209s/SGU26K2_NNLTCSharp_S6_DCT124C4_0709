namespace Lab04Prj.Forms;

partial class FrmMain
{
    private System.ComponentModel.IContainer components = null!;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label lblInfo;
    private System.Windows.Forms.GroupBox grpDe1;
    private System.Windows.Forms.GroupBox grpDe2;
    private System.Windows.Forms.Button btnDe1_MyName;
    private System.Windows.Forms.Button btnDe1_PhepTinh;
    private System.Windows.Forms.Button btnDe1_DangKy;
    private System.Windows.Forms.Button btnDe1_UCLN;
    private System.Windows.Forms.Button btnDe1_DaySo;
    private System.Windows.Forms.Button btnDe1_DocSo;
    private System.Windows.Forms.Button btnDe1_BanVePhim;
    private System.Windows.Forms.Button btnDe1_MayTinh;
    private System.Windows.Forms.Button btnDe2_TinhToanRadio;
    private System.Windows.Forms.Button btnDe2_DinhDangFont;
    private System.Windows.Forms.Button btnDe2_GiaiPhuongTrinh;
    private System.Windows.Forms.Button btnDe2_MangSoNguyen;
    private System.Windows.Forms.Button btnDe2_CafeSinhVien;
    private System.Windows.Forms.Button btnDe2_KhachSan;
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
        this.lblInfo = new System.Windows.Forms.Label();
        this.grpDe1 = new System.Windows.Forms.GroupBox();
        this.btnDe1_MyName = new System.Windows.Forms.Button();
        this.btnDe1_PhepTinh = new System.Windows.Forms.Button();
        this.btnDe1_DangKy = new System.Windows.Forms.Button();
        this.btnDe1_UCLN = new System.Windows.Forms.Button();
        this.btnDe1_DaySo = new System.Windows.Forms.Button();
        this.btnDe1_DocSo = new System.Windows.Forms.Button();
        this.btnDe1_BanVePhim = new System.Windows.Forms.Button();
        this.btnDe1_MayTinh = new System.Windows.Forms.Button();
        this.grpDe2 = new System.Windows.Forms.GroupBox();
        this.btnDe2_TinhToanRadio = new System.Windows.Forms.Button();
        this.btnDe2_DinhDangFont = new System.Windows.Forms.Button();
        this.btnDe2_GiaiPhuongTrinh = new System.Windows.Forms.Button();
        this.btnDe2_MangSoNguyen = new System.Windows.Forms.Button();
        this.btnDe2_CafeSinhVien = new System.Windows.Forms.Button();
        this.btnDe2_KhachSan = new System.Windows.Forms.Button();
        this.btnThoat = new System.Windows.Forms.Button();
        this.grpDe1.SuspendLayout();
        this.grpDe2.SuspendLayout();
        this.SuspendLayout();

        // lblTitle
        this.lblTitle.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
        this.lblTitle.ForeColor = System.Drawing.Color.DarkBlue;
        this.lblTitle.Location = new System.Drawing.Point(20, 10);
        this.lblTitle.Name = "lblTitle";
        this.lblTitle.Size = new System.Drawing.Size(800, 35);
        this.lblTitle.TabIndex = 0;
        this.lblTitle.Text = "BÀI TẬP THỰC HÀNH TUẦN 04 - WINDOWS FORMS CƠ BẢN";
        this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

        // lblInfo
        this.lblInfo.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Italic);
        this.lblInfo.ForeColor = System.Drawing.Color.DarkSlateGray;
        this.lblInfo.Location = new System.Drawing.Point(20, 45);
        this.lblInfo.Name = "lblInfo";
        this.lblInfo.Size = new System.Drawing.Size(800, 22);
        this.lblInfo.TabIndex = 1;
        this.lblInfo.Text = "Sinh viên: Trương Xuân Tâm  |  MSSV: 3124411266  |  Lớp: DCT124C4";
        this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

        // grpDe1
        this.grpDe1.Controls.Add(this.btnDe1_MyName);
        this.grpDe1.Controls.Add(this.btnDe1_PhepTinh);
        this.grpDe1.Controls.Add(this.btnDe1_DangKy);
        this.grpDe1.Controls.Add(this.btnDe1_UCLN);
        this.grpDe1.Controls.Add(this.btnDe1_DaySo);
        this.grpDe1.Controls.Add(this.btnDe1_DocSo);
        this.grpDe1.Controls.Add(this.btnDe1_BanVePhim);
        this.grpDe1.Controls.Add(this.btnDe1_MayTinh);
        this.grpDe1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
        this.grpDe1.ForeColor = System.Drawing.Color.DarkRed;
        this.grpDe1.Location = new System.Drawing.Point(30, 80);
        this.grpDe1.Name = "grpDe1";
        this.grpDe1.Size = new System.Drawing.Size(380, 400);
        this.grpDe1.TabIndex = 2;
        this.grpDe1.TabStop = false;
        this.grpDe1.Text = "ĐỀ LAB 04_1: CONTROLS CƠ BẢN & SỰ KIỆN";

        // btnDe1_MyName
        this.btnDe1_MyName.BackColor = System.Drawing.Color.WhiteSmoke;
        this.btnDe1_MyName.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
        this.btnDe1_MyName.ForeColor = System.Drawing.Color.Black;
        this.btnDe1_MyName.Location = new System.Drawing.Point(20, 25);
        this.btnDe1_MyName.Name = "btnDe1_MyName";
        this.btnDe1_MyName.Size = new System.Drawing.Size(340, 36);
        this.btnDe1_MyName.TabIndex = 0;
        this.btnDe1_MyName.Text = "1. Bài Mẫu: My Name Project";
        this.btnDe1_MyName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        this.btnDe1_MyName.UseVisualStyleBackColor = false;
        this.btnDe1_MyName.Click += new System.EventHandler(this.BtnDe1_MyName_Click);

        // btnDe1_PhepTinh
        this.btnDe1_PhepTinh.BackColor = System.Drawing.Color.WhiteSmoke;
        this.btnDe1_PhepTinh.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
        this.btnDe1_PhepTinh.ForeColor = System.Drawing.Color.Black;
        this.btnDe1_PhepTinh.Location = new System.Drawing.Point(20, 68);
        this.btnDe1_PhepTinh.Name = "btnDe1_PhepTinh";
        this.btnDe1_PhepTinh.Size = new System.Drawing.Size(340, 36);
        this.btnDe1_PhepTinh.TabIndex = 1;
        this.btnDe1_PhepTinh.Text = "2. Bài 1: Phép Tính Số Học (+, -, *, /)";
        this.btnDe1_PhepTinh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        this.btnDe1_PhepTinh.UseVisualStyleBackColor = false;
        this.btnDe1_PhepTinh.Click += new System.EventHandler(this.BtnDe1_PhepTinh_Click);

        // btnDe1_DangKy
        this.btnDe1_DangKy.BackColor = System.Drawing.Color.WhiteSmoke;
        this.btnDe1_DangKy.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
        this.btnDe1_DangKy.ForeColor = System.Drawing.Color.Black;
        this.btnDe1_DangKy.Location = new System.Drawing.Point(20, 111);
        this.btnDe1_DangKy.Name = "btnDe1_DangKy";
        this.btnDe1_DangKy.Size = new System.Drawing.Size(340, 36);
        this.btnDe1_DangKy.TabIndex = 2;
        this.btnDe1_DangKy.Text = "3. Bài 2: Đăng Ký Tài Khoản";
        this.btnDe1_DangKy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        this.btnDe1_DangKy.UseVisualStyleBackColor = false;
        this.btnDe1_DangKy.Click += new System.EventHandler(this.BtnDe1_DangKy_Click);

        // btnDe1_UCLN
        this.btnDe1_UCLN.BackColor = System.Drawing.Color.WhiteSmoke;
        this.btnDe1_UCLN.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
        this.btnDe1_UCLN.ForeColor = System.Drawing.Color.Black;
        this.btnDe1_UCLN.Location = new System.Drawing.Point(20, 154);
        this.btnDe1_UCLN.Name = "btnDe1_UCLN";
        this.btnDe1_UCLN.Size = new System.Drawing.Size(340, 36);
        this.btnDe1_UCLN.TabIndex = 3;
        this.btnDe1_UCLN.Text = "4. Bài 3: Ước Số & Bội Số (UCLN, BCNN)";
        this.btnDe1_UCLN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        this.btnDe1_UCLN.UseVisualStyleBackColor = false;
        this.btnDe1_UCLN.Click += new System.EventHandler(this.BtnDe1_UCLN_Click);

        // btnDe1_DaySo
        this.btnDe1_DaySo.BackColor = System.Drawing.Color.WhiteSmoke;
        this.btnDe1_DaySo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
        this.btnDe1_DaySo.ForeColor = System.Drawing.Color.Black;
        this.btnDe1_DaySo.Location = new System.Drawing.Point(20, 197);
        this.btnDe1_DaySo.Name = "btnDe1_DaySo";
        this.btnDe1_DaySo.Size = new System.Drawing.Size(340, 36);
        this.btnDe1_DaySo.TabIndex = 4;
        this.btnDe1_DaySo.Text = "5. Bài 4: Nhập Dãy Số & Tính Tổng";
        this.btnDe1_DaySo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        this.btnDe1_DaySo.UseVisualStyleBackColor = false;
        this.btnDe1_DaySo.Click += new System.EventHandler(this.BtnDe1_DaySo_Click);

        // btnDe1_DocSo
        this.btnDe1_DocSo.BackColor = System.Drawing.Color.WhiteSmoke;
        this.btnDe1_DocSo.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
        this.btnDe1_DocSo.ForeColor = System.Drawing.Color.Black;
        this.btnDe1_DocSo.Location = new System.Drawing.Point(20, 240);
        this.btnDe1_DocSo.Name = "btnDe1_DocSo";
        this.btnDe1_DocSo.Size = new System.Drawing.Size(340, 36);
        this.btnDe1_DocSo.TabIndex = 5;
        this.btnDe1_DocSo.Text = "6. Bài 5: Đọc Số Thành Chữ (1 - 999)";
        this.btnDe1_DocSo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        this.btnDe1_DocSo.UseVisualStyleBackColor = false;
        this.btnDe1_DocSo.Click += new System.EventHandler(this.BtnDe1_DocSo_Click);

        // btnDe1_BanVePhim
        this.btnDe1_BanVePhim.BackColor = System.Drawing.Color.WhiteSmoke;
        this.btnDe1_BanVePhim.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
        this.btnDe1_BanVePhim.ForeColor = System.Drawing.Color.Black;
        this.btnDe1_BanVePhim.Location = new System.Drawing.Point(20, 283);
        this.btnDe1_BanVePhim.Name = "btnDe1_BanVePhim";
        this.btnDe1_BanVePhim.Size = new System.Drawing.Size(340, 36);
        this.btnDe1_BanVePhim.TabIndex = 6;
        this.btnDe1_BanVePhim.Text = "7. Nâng Cao: Bán Vé Rạp Chiếu Phim";
        this.btnDe1_BanVePhim.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        this.btnDe1_BanVePhim.UseVisualStyleBackColor = false;
        this.btnDe1_BanVePhim.Click += new System.EventHandler(this.BtnDe1_BanVePhim_Click);

        // btnDe1_MayTinh
        this.btnDe1_MayTinh.BackColor = System.Drawing.Color.WhiteSmoke;
        this.btnDe1_MayTinh.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
        this.btnDe1_MayTinh.ForeColor = System.Drawing.Color.Black;
        this.btnDe1_MayTinh.Location = new System.Drawing.Point(20, 326);
        this.btnDe1_MayTinh.Name = "btnDe1_MayTinh";
        this.btnDe1_MayTinh.Size = new System.Drawing.Size(340, 36);
        this.btnDe1_MayTinh.TabIndex = 7;
        this.btnDe1_MayTinh.Text = "8. Về Nhà: Máy Tính Bỏ Túi (Calculator)";
        this.btnDe1_MayTinh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        this.btnDe1_MayTinh.UseVisualStyleBackColor = false;
        this.btnDe1_MayTinh.Click += new System.EventHandler(this.BtnDe1_MayTinh_Click);

        // grpDe2
        this.grpDe2.Controls.Add(this.btnDe2_TinhToanRadio);
        this.grpDe2.Controls.Add(this.btnDe2_DinhDangFont);
        this.grpDe2.Controls.Add(this.btnDe2_GiaiPhuongTrinh);
        this.grpDe2.Controls.Add(this.btnDe2_MangSoNguyen);
        this.grpDe2.Controls.Add(this.btnDe2_CafeSinhVien);
        this.grpDe2.Controls.Add(this.btnDe2_KhachSan);
        this.grpDe2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
        this.grpDe2.ForeColor = System.Drawing.Color.DarkGreen;
        this.grpDe2.Location = new System.Drawing.Point(430, 80);
        this.grpDe2.Name = "grpDe2";
        this.grpDe2.Size = new System.Drawing.Size(380, 400);
        this.grpDe2.TabIndex = 3;
        this.grpDe2.TabStop = false;
        this.grpDe2.Text = "ĐỀ LAB 04_2: RADIOBUTTON, CHECKBOX & OOP";

        // btnDe2_TinhToanRadio
        this.btnDe2_TinhToanRadio.BackColor = System.Drawing.Color.WhiteSmoke;
        this.btnDe2_TinhToanRadio.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
        this.btnDe2_TinhToanRadio.ForeColor = System.Drawing.Color.Black;
        this.btnDe2_TinhToanRadio.Location = new System.Drawing.Point(20, 25);
        this.btnDe2_TinhToanRadio.Name = "btnDe2_TinhToanRadio";
        this.btnDe2_TinhToanRadio.Size = new System.Drawing.Size(340, 36);
        this.btnDe2_TinhToanRadio.TabIndex = 0;
        this.btnDe2_TinhToanRadio.Text = "1. Bài Mẫu 1: Phép Tính Radio + Class TinhToan";
        this.btnDe2_TinhToanRadio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        this.btnDe2_TinhToanRadio.UseVisualStyleBackColor = false;
        this.btnDe2_TinhToanRadio.Click += new System.EventHandler(this.BtnDe2_TinhToanRadio_Click);

        // btnDe2_DinhDangFont
        this.btnDe2_DinhDangFont.BackColor = System.Drawing.Color.WhiteSmoke;
        this.btnDe2_DinhDangFont.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
        this.btnDe2_DinhDangFont.ForeColor = System.Drawing.Color.Black;
        this.btnDe2_DinhDangFont.Location = new System.Drawing.Point(20, 68);
        this.btnDe2_DinhDangFont.Name = "btnDe2_DinhDangFont";
        this.btnDe2_DinhDangFont.Size = new System.Drawing.Size(340, 36);
        this.btnDe2_DinhDangFont.TabIndex = 1;
        this.btnDe2_DinhDangFont.Text = "2. Bài Mẫu 2: Định Dạng Font & Màu Sắc";
        this.btnDe2_DinhDangFont.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        this.btnDe2_DinhDangFont.UseVisualStyleBackColor = false;
        this.btnDe2_DinhDangFont.Click += new System.EventHandler(this.BtnDe2_DinhDangFont_Click);

        // btnDe2_GiaiPhuongTrinh
        this.btnDe2_GiaiPhuongTrinh.BackColor = System.Drawing.Color.WhiteSmoke;
        this.btnDe2_GiaiPhuongTrinh.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
        this.btnDe2_GiaiPhuongTrinh.ForeColor = System.Drawing.Color.Black;
        this.btnDe2_GiaiPhuongTrinh.Location = new System.Drawing.Point(20, 111);
        this.btnDe2_GiaiPhuongTrinh.Name = "btnDe2_GiaiPhuongTrinh";
        this.btnDe2_GiaiPhuongTrinh.Size = new System.Drawing.Size(340, 36);
        this.btnDe2_GiaiPhuongTrinh.TabIndex = 2;
        this.btnDe2_GiaiPhuongTrinh.Text = "3. Bài 1: Giải Phương Trình Bậc 1 & 2 (OOP)";
        this.btnDe2_GiaiPhuongTrinh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        this.btnDe2_GiaiPhuongTrinh.UseVisualStyleBackColor = false;
        this.btnDe2_GiaiPhuongTrinh.Click += new System.EventHandler(this.BtnDe2_GiaiPhuongTrinh_Click);

        // btnDe2_MangSoNguyen
        this.btnDe2_MangSoNguyen.BackColor = System.Drawing.Color.WhiteSmoke;
        this.btnDe2_MangSoNguyen.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
        this.btnDe2_MangSoNguyen.ForeColor = System.Drawing.Color.Black;
        this.btnDe2_MangSoNguyen.Location = new System.Drawing.Point(20, 154);
        this.btnDe2_MangSoNguyen.Name = "btnDe2_MangSoNguyen";
        this.btnDe2_MangSoNguyen.Size = new System.Drawing.Size(340, 36);
        this.btnDe2_MangSoNguyen.TabIndex = 3;
        this.btnDe2_MangSoNguyen.Text = "4. Bài 2: Thao Tác Mảng Số Nguyên (OOP)";
        this.btnDe2_MangSoNguyen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        this.btnDe2_MangSoNguyen.UseVisualStyleBackColor = false;
        this.btnDe2_MangSoNguyen.Click += new System.EventHandler(this.BtnDe2_MangSoNguyen_Click);

        // btnDe2_CafeSinhVien
        this.btnDe2_CafeSinhVien.BackColor = System.Drawing.Color.WhiteSmoke;
        this.btnDe2_CafeSinhVien.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
        this.btnDe2_CafeSinhVien.ForeColor = System.Drawing.Color.Black;
        this.btnDe2_CafeSinhVien.Location = new System.Drawing.Point(20, 197);
        this.btnDe2_CafeSinhVien.Name = "btnDe2_CafeSinhVien";
        this.btnDe2_CafeSinhVien.Size = new System.Drawing.Size(340, 36);
        this.btnDe2_CafeSinhVien.TabIndex = 4;
        this.btnDe2_CafeSinhVien.Text = "5. Nâng Cao: Quản Lý Cafe Sinh Viên";
        this.btnDe2_CafeSinhVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        this.btnDe2_CafeSinhVien.UseVisualStyleBackColor = false;
        this.btnDe2_CafeSinhVien.Click += new System.EventHandler(this.BtnDe2_CafeSinhVien_Click);

        // btnDe2_KhachSan
        this.btnDe2_KhachSan.BackColor = System.Drawing.Color.WhiteSmoke;
        this.btnDe2_KhachSan.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular);
        this.btnDe2_KhachSan.ForeColor = System.Drawing.Color.Black;
        this.btnDe2_KhachSan.Location = new System.Drawing.Point(20, 240);
        this.btnDe2_KhachSan.Name = "btnDe2_KhachSan";
        this.btnDe2_KhachSan.Size = new System.Drawing.Size(340, 36);
        this.btnDe2_KhachSan.TabIndex = 5;
        this.btnDe2_KhachSan.Text = "6. Về Nhà: Quản Lý Khách Sạn Thanh Thanh";
        this.btnDe2_KhachSan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        this.btnDe2_KhachSan.UseVisualStyleBackColor = false;
        this.btnDe2_KhachSan.Click += new System.EventHandler(this.BtnDe2_KhachSan_Click);

        // btnThoat
        this.btnThoat.BackColor = System.Drawing.Color.MistyRose;
        this.btnThoat.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
        this.btnThoat.ForeColor = System.Drawing.Color.Black;
        this.btnThoat.Location = new System.Drawing.Point(340, 495);
        this.btnThoat.Name = "btnThoat";
        this.btnThoat.Size = new System.Drawing.Size(160, 38);
        this.btnThoat.TabIndex = 4;
        this.btnThoat.Text = "Thoát Chương Trình";
        this.btnThoat.UseVisualStyleBackColor = false;
        this.btnThoat.Click += new System.EventHandler(this.BtnThoat_Click);

        // FrmMain
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(844, 541);
        this.Controls.Add(this.btnThoat);
        this.Controls.Add(this.grpDe2);
        this.Controls.Add(this.grpDe1);
        this.Controls.Add(this.lblInfo);
        this.Controls.Add(this.lblTitle);
        this.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Regular);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.Name = "FrmMain";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "BÀI TẬP THỰC HÀNH TUẦN 04 - WINDOWS FORMS (ĐỀ 1 & ĐỀ 2)";
        this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
        this.grpDe1.ResumeLayout(false);
        this.grpDe2.ResumeLayout(false);
        this.ResumeLayout(false);
    }
}
