namespace Lab04Prj.Forms;

partial class FrmMain
{
    private System.ComponentModel.IContainer components = null!;
    private System.Windows.Forms.Label lblTitle;
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
        lblTitle = new Label();
        grpDe1 = new GroupBox();
        btnDe1_MyName = new Button();
        btnDe1_PhepTinh = new Button();
        btnDe1_DangKy = new Button();
        btnDe1_UCLN = new Button();
        btnDe1_DaySo = new Button();
        btnDe1_DocSo = new Button();
        btnDe1_BanVePhim = new Button();
        btnDe1_MayTinh = new Button();
        grpDe2 = new GroupBox();
        btnDe2_TinhToanRadio = new Button();
        btnDe2_DinhDangFont = new Button();
        btnDe2_GiaiPhuongTrinh = new Button();
        btnDe2_MangSoNguyen = new Button();
        btnDe2_CafeSinhVien = new Button();
        btnDe2_KhachSan = new Button();
        btnThoat = new Button();
        grpDe1.SuspendLayout();
        grpDe2.SuspendLayout();
        SuspendLayout();
        // 
        // lblTitle
        // 
        lblTitle.Font = new Font("Tahoma", 15F, FontStyle.Bold);
        lblTitle.ForeColor = Color.DarkBlue;
        lblTitle.Location = new Point(20, 10);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new Size(800, 35);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "BÀI TẬP THỰC HÀNH TUẦN 04";
        lblTitle.TextAlign = ContentAlignment.MiddleCenter;
        lblTitle.Click += lblTitle_Click;
        // 
        // grpDe1
        // 
        grpDe1.Controls.Add(btnDe1_MyName);
        grpDe1.Controls.Add(btnDe1_PhepTinh);
        grpDe1.Controls.Add(btnDe1_DangKy);
        grpDe1.Controls.Add(btnDe1_UCLN);
        grpDe1.Controls.Add(btnDe1_DaySo);
        grpDe1.Controls.Add(btnDe1_DocSo);
        grpDe1.Controls.Add(btnDe1_BanVePhim);
        grpDe1.Controls.Add(btnDe1_MayTinh);
        grpDe1.Font = new Font("Tahoma", 10F, FontStyle.Bold);
        grpDe1.ForeColor = Color.DarkRed;
        grpDe1.Location = new Point(30, 80);
        grpDe1.Name = "grpDe1";
        grpDe1.Size = new Size(380, 400);
        grpDe1.TabIndex = 2;
        grpDe1.TabStop = false;
        grpDe1.Text = "LAB 04_1: CONTROLS CƠ BẢN & SỰ KIỆN";
        grpDe1.Enter += grpDe1_Enter;
        // 
        // btnDe1_MyName
        // 
        btnDe1_MyName.BackColor = Color.WhiteSmoke;
        btnDe1_MyName.Font = new Font("Tahoma", 9F);
        btnDe1_MyName.ForeColor = Color.Black;
        btnDe1_MyName.Location = new Point(17, 48);
        btnDe1_MyName.Name = "btnDe1_MyName";
        btnDe1_MyName.Size = new Size(340, 36);
        btnDe1_MyName.TabIndex = 0;
        btnDe1_MyName.Text = "1. Bài Mẫu: My Name Project";
        btnDe1_MyName.TextAlign = ContentAlignment.MiddleLeft;
        btnDe1_MyName.UseVisualStyleBackColor = false;
        btnDe1_MyName.Click += BtnDe1_MyName_Click;
        // 
        // btnDe1_PhepTinh
        // 
        btnDe1_PhepTinh.BackColor = Color.WhiteSmoke;
        btnDe1_PhepTinh.Font = new Font("Tahoma", 9F);
        btnDe1_PhepTinh.ForeColor = Color.Black;
        btnDe1_PhepTinh.Location = new Point(17, 91);
        btnDe1_PhepTinh.Name = "btnDe1_PhepTinh";
        btnDe1_PhepTinh.Size = new Size(340, 36);
        btnDe1_PhepTinh.TabIndex = 1;
        btnDe1_PhepTinh.Text = "2. Bài 1: Phép Tính Số Học (+, -, *, /)";
        btnDe1_PhepTinh.TextAlign = ContentAlignment.MiddleLeft;
        btnDe1_PhepTinh.UseVisualStyleBackColor = false;
        btnDe1_PhepTinh.Click += BtnDe1_PhepTinh_Click;
        // 
        // btnDe1_DangKy
        // 
        btnDe1_DangKy.BackColor = Color.WhiteSmoke;
        btnDe1_DangKy.Font = new Font("Tahoma", 9F);
        btnDe1_DangKy.ForeColor = Color.Black;
        btnDe1_DangKy.Location = new Point(17, 134);
        btnDe1_DangKy.Name = "btnDe1_DangKy";
        btnDe1_DangKy.Size = new Size(340, 36);
        btnDe1_DangKy.TabIndex = 2;
        btnDe1_DangKy.Text = "3. Bài 2: Đăng Ký Tài Khoản";
        btnDe1_DangKy.TextAlign = ContentAlignment.MiddleLeft;
        btnDe1_DangKy.UseVisualStyleBackColor = false;
        btnDe1_DangKy.Click += BtnDe1_DangKy_Click;
        // 
        // btnDe1_UCLN
        // 
        btnDe1_UCLN.BackColor = Color.WhiteSmoke;
        btnDe1_UCLN.Font = new Font("Tahoma", 9F);
        btnDe1_UCLN.ForeColor = Color.Black;
        btnDe1_UCLN.Location = new Point(17, 177);
        btnDe1_UCLN.Name = "btnDe1_UCLN";
        btnDe1_UCLN.Size = new Size(340, 36);
        btnDe1_UCLN.TabIndex = 3;
        btnDe1_UCLN.Text = "4. Bài 3: Ước Số & Bội Số (UCLN, BCNN)";
        btnDe1_UCLN.TextAlign = ContentAlignment.MiddleLeft;
        btnDe1_UCLN.UseVisualStyleBackColor = false;
        btnDe1_UCLN.Click += BtnDe1_UCLN_Click;
        // 
        // btnDe1_DaySo
        // 
        btnDe1_DaySo.BackColor = Color.WhiteSmoke;
        btnDe1_DaySo.Font = new Font("Tahoma", 9F);
        btnDe1_DaySo.ForeColor = Color.Black;
        btnDe1_DaySo.Location = new Point(17, 220);
        btnDe1_DaySo.Name = "btnDe1_DaySo";
        btnDe1_DaySo.Size = new Size(340, 36);
        btnDe1_DaySo.TabIndex = 4;
        btnDe1_DaySo.Text = "5. Bài 4: Nhập Dãy Số & Tính Tổng";
        btnDe1_DaySo.TextAlign = ContentAlignment.MiddleLeft;
        btnDe1_DaySo.UseVisualStyleBackColor = false;
        btnDe1_DaySo.Click += BtnDe1_DaySo_Click;
        // 
        // btnDe1_DocSo
        // 
        btnDe1_DocSo.BackColor = Color.WhiteSmoke;
        btnDe1_DocSo.Font = new Font("Tahoma", 9F);
        btnDe1_DocSo.ForeColor = Color.Black;
        btnDe1_DocSo.Location = new Point(17, 263);
        btnDe1_DocSo.Name = "btnDe1_DocSo";
        btnDe1_DocSo.Size = new Size(340, 36);
        btnDe1_DocSo.TabIndex = 5;
        btnDe1_DocSo.Text = "6. Bài 5: Đọc Số Thành Chữ (1 - 999)";
        btnDe1_DocSo.TextAlign = ContentAlignment.MiddleLeft;
        btnDe1_DocSo.UseVisualStyleBackColor = false;
        btnDe1_DocSo.Click += BtnDe1_DocSo_Click;
        // 
        // btnDe1_BanVePhim
        // 
        btnDe1_BanVePhim.BackColor = Color.WhiteSmoke;
        btnDe1_BanVePhim.Font = new Font("Tahoma", 9F);
        btnDe1_BanVePhim.ForeColor = Color.Black;
        btnDe1_BanVePhim.Location = new Point(17, 306);
        btnDe1_BanVePhim.Name = "btnDe1_BanVePhim";
        btnDe1_BanVePhim.Size = new Size(340, 36);
        btnDe1_BanVePhim.TabIndex = 6;
        btnDe1_BanVePhim.Text = "7. Nâng Cao: Bán Vé Rạp Chiếu Phim";
        btnDe1_BanVePhim.TextAlign = ContentAlignment.MiddleLeft;
        btnDe1_BanVePhim.UseVisualStyleBackColor = false;
        btnDe1_BanVePhim.Click += BtnDe1_BanVePhim_Click;
        // 
        // btnDe1_MayTinh
        // 
        btnDe1_MayTinh.BackColor = Color.WhiteSmoke;
        btnDe1_MayTinh.Font = new Font("Tahoma", 9F);
        btnDe1_MayTinh.ForeColor = Color.Black;
        btnDe1_MayTinh.Location = new Point(17, 349);
        btnDe1_MayTinh.Name = "btnDe1_MayTinh";
        btnDe1_MayTinh.Size = new Size(340, 36);
        btnDe1_MayTinh.TabIndex = 7;
        btnDe1_MayTinh.Text = "8. Về Nhà: Máy Tính Bỏ Túi (Calculator)";
        btnDe1_MayTinh.TextAlign = ContentAlignment.MiddleLeft;
        btnDe1_MayTinh.UseVisualStyleBackColor = false;
        btnDe1_MayTinh.Click += BtnDe1_MayTinh_Click;
        // 
        // grpDe2
        // 
        grpDe2.Controls.Add(btnDe2_TinhToanRadio);
        grpDe2.Controls.Add(btnDe2_DinhDangFont);
        grpDe2.Controls.Add(btnDe2_GiaiPhuongTrinh);
        grpDe2.Controls.Add(btnDe2_MangSoNguyen);
        grpDe2.Controls.Add(btnDe2_CafeSinhVien);
        grpDe2.Controls.Add(btnDe2_KhachSan);
        grpDe2.Font = new Font("Tahoma", 10F, FontStyle.Bold);
        grpDe2.ForeColor = Color.DarkGreen;
        grpDe2.Location = new Point(430, 80);
        grpDe2.Name = "grpDe2";
        grpDe2.Size = new Size(380, 400);
        grpDe2.TabIndex = 3;
        grpDe2.TabStop = false;
        grpDe2.Text = "LAB 04_2: RADIOBUTTON, CHECKBOX & OOP";
        // 
        // btnDe2_TinhToanRadio
        // 
        btnDe2_TinhToanRadio.BackColor = Color.WhiteSmoke;
        btnDe2_TinhToanRadio.Font = new Font("Tahoma", 9F);
        btnDe2_TinhToanRadio.ForeColor = Color.Black;
        btnDe2_TinhToanRadio.Location = new Point(17, 48);
        btnDe2_TinhToanRadio.Name = "btnDe2_TinhToanRadio";
        btnDe2_TinhToanRadio.Size = new Size(340, 36);
        btnDe2_TinhToanRadio.TabIndex = 0;
        btnDe2_TinhToanRadio.Text = "1. Bài Mẫu 1: Phép Tính Radio + Class TinhToan";
        btnDe2_TinhToanRadio.TextAlign = ContentAlignment.MiddleLeft;
        btnDe2_TinhToanRadio.UseVisualStyleBackColor = false;
        btnDe2_TinhToanRadio.Click += BtnDe2_TinhToanRadio_Click;
        // 
        // btnDe2_DinhDangFont
        // 
        btnDe2_DinhDangFont.BackColor = Color.WhiteSmoke;
        btnDe2_DinhDangFont.Font = new Font("Tahoma", 9F);
        btnDe2_DinhDangFont.ForeColor = Color.Black;
        btnDe2_DinhDangFont.Location = new Point(17, 91);
        btnDe2_DinhDangFont.Name = "btnDe2_DinhDangFont";
        btnDe2_DinhDangFont.Size = new Size(340, 36);
        btnDe2_DinhDangFont.TabIndex = 1;
        btnDe2_DinhDangFont.Text = "2. Bài Mẫu 2: Định Dạng Font & Màu Sắc";
        btnDe2_DinhDangFont.TextAlign = ContentAlignment.MiddleLeft;
        btnDe2_DinhDangFont.UseVisualStyleBackColor = false;
        btnDe2_DinhDangFont.Click += BtnDe2_DinhDangFont_Click;
        // 
        // btnDe2_GiaiPhuongTrinh
        // 
        btnDe2_GiaiPhuongTrinh.BackColor = Color.WhiteSmoke;
        btnDe2_GiaiPhuongTrinh.Font = new Font("Tahoma", 9F);
        btnDe2_GiaiPhuongTrinh.ForeColor = Color.Black;
        btnDe2_GiaiPhuongTrinh.Location = new Point(17, 134);
        btnDe2_GiaiPhuongTrinh.Name = "btnDe2_GiaiPhuongTrinh";
        btnDe2_GiaiPhuongTrinh.Size = new Size(340, 36);
        btnDe2_GiaiPhuongTrinh.TabIndex = 2;
        btnDe2_GiaiPhuongTrinh.Text = "3. Bài 1: Giải Phương Trình Bậc 1 & 2 (OOP)";
        btnDe2_GiaiPhuongTrinh.TextAlign = ContentAlignment.MiddleLeft;
        btnDe2_GiaiPhuongTrinh.UseVisualStyleBackColor = false;
        btnDe2_GiaiPhuongTrinh.Click += BtnDe2_GiaiPhuongTrinh_Click;
        // 
        // btnDe2_MangSoNguyen
        // 
        btnDe2_MangSoNguyen.BackColor = Color.WhiteSmoke;
        btnDe2_MangSoNguyen.Font = new Font("Tahoma", 9F);
        btnDe2_MangSoNguyen.ForeColor = Color.Black;
        btnDe2_MangSoNguyen.Location = new Point(17, 177);
        btnDe2_MangSoNguyen.Name = "btnDe2_MangSoNguyen";
        btnDe2_MangSoNguyen.Size = new Size(340, 36);
        btnDe2_MangSoNguyen.TabIndex = 3;
        btnDe2_MangSoNguyen.Text = "4. Bài 2: Thao Tác Mảng Số Nguyên (OOP)";
        btnDe2_MangSoNguyen.TextAlign = ContentAlignment.MiddleLeft;
        btnDe2_MangSoNguyen.UseVisualStyleBackColor = false;
        btnDe2_MangSoNguyen.Click += BtnDe2_MangSoNguyen_Click;
        // 
        // btnDe2_CafeSinhVien
        // 
        btnDe2_CafeSinhVien.BackColor = Color.WhiteSmoke;
        btnDe2_CafeSinhVien.Font = new Font("Tahoma", 9F);
        btnDe2_CafeSinhVien.ForeColor = Color.Black;
        btnDe2_CafeSinhVien.Location = new Point(17, 220);
        btnDe2_CafeSinhVien.Name = "btnDe2_CafeSinhVien";
        btnDe2_CafeSinhVien.Size = new Size(340, 36);
        btnDe2_CafeSinhVien.TabIndex = 4;
        btnDe2_CafeSinhVien.Text = "5. Nâng Cao: Quản Lý Cafe Sinh Viên";
        btnDe2_CafeSinhVien.TextAlign = ContentAlignment.MiddleLeft;
        btnDe2_CafeSinhVien.UseVisualStyleBackColor = false;
        btnDe2_CafeSinhVien.Click += BtnDe2_CafeSinhVien_Click;
        // 
        // btnDe2_KhachSan
        // 
        btnDe2_KhachSan.BackColor = Color.WhiteSmoke;
        btnDe2_KhachSan.Font = new Font("Tahoma", 9F);
        btnDe2_KhachSan.ForeColor = Color.Black;
        btnDe2_KhachSan.Location = new Point(17, 263);
        btnDe2_KhachSan.Name = "btnDe2_KhachSan";
        btnDe2_KhachSan.Size = new Size(340, 36);
        btnDe2_KhachSan.TabIndex = 5;
        btnDe2_KhachSan.Text = "6. Về Nhà: Quản Lý Khách Sạn Thanh Thanh";
        btnDe2_KhachSan.TextAlign = ContentAlignment.MiddleLeft;
        btnDe2_KhachSan.UseVisualStyleBackColor = false;
        btnDe2_KhachSan.Click += BtnDe2_KhachSan_Click;
        // 
        // btnThoat
        // 
        btnThoat.BackColor = Color.MistyRose;
        btnThoat.Font = new Font("Tahoma", 10F, FontStyle.Bold);
        btnThoat.ForeColor = Color.Black;
        btnThoat.Location = new Point(340, 495);
        btnThoat.Name = "btnThoat";
        btnThoat.Size = new Size(160, 38);
        btnThoat.TabIndex = 4;
        btnThoat.Text = "Thoát Chương Trình";
        btnThoat.UseVisualStyleBackColor = false;
        btnThoat.Click += BtnThoat_Click;
        // 
        // FrmMain
        // 
        AutoScaleDimensions = new SizeF(9F, 19F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(844, 541);
        Controls.Add(btnThoat);
        Controls.Add(grpDe2);
        Controls.Add(grpDe1);
        Controls.Add(lblTitle);
        Font = new Font("Tahoma", 9.5F);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        Name = "FrmMain";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "BÀI TẬP THỰC HÀNH TUẦN 04 - WINDOWS FORMS (ĐỀ 1 & ĐỀ 2)";
        FormClosing += FrmMain_FormClosing;
        grpDe1.ResumeLayout(false);
        grpDe2.ResumeLayout(false);
        ResumeLayout(false);
    }
}
