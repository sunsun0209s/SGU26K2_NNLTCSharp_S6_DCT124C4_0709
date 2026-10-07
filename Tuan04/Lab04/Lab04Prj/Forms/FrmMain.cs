using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab04Prj.Forms;

public class FrmMain : Form
{
    public FrmMain()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        this.Text = "BÀI TẬP THỰC HÀNH TUẦN 04 - WINDOWS FORMS (ĐỀ 1 & ĐỀ 2)";
        this.Font = new Font("Tahoma", 9.5F, FontStyle.Regular);
        this.Size = new Size(860, 580);
        this.StartPosition = FormStartPosition.CenterScreen;
        this.FormBorderStyle = FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;

        Label lblTitle = new Label
        {
            Text = "BÀI TẬP THỰC HÀNH TUẦN 04 - WINDOWS FORMS CƠ BẢN",
            Font = new Font("Tahoma", 15F, FontStyle.Bold),
            ForeColor = Color.DarkBlue,
            TextAlign = ContentAlignment.MiddleCenter,
            Location = new Point(20, 10),
            Size = new Size(800, 35)
        };

        Label lblInfo = new Label
        {
            Text = "Sinh viên: Trương Xuân Tâm  |  MSSV: 3124411266  |  Lớp: DCT124C4  |  Học phần: C# (841423)",
            Font = new Font("Tahoma", 10F, FontStyle.Italic),
            ForeColor = Color.DarkSlateGray,
            TextAlign = ContentAlignment.MiddleCenter,
            Location = new Point(20, 45),
            Size = new Size(800, 22)
        };

        // GROUP 1: ĐỀ LAB 04_1
        GroupBox grpDe1 = new GroupBox
        {
            Text = "ĐỀ LAB 04_1: CONTROLS CƠ BẢN & SỰ KIỆN",
            Font = new Font("Tahoma", 10F, FontStyle.Bold),
            ForeColor = Color.DarkRed,
            Location = new Point(30, 80),
            Size = new Size(380, 400)
        };

        AddMenuButton(grpDe1, "1. Bài Mẫu: My Name Project", 25, () => new FrmMyName().ShowDialog());
        AddMenuButton(grpDe1, "2. Bài 1: Phép Tính Số Học (+, -, *, /)", 68, () => new FrmPhepTinhCoBan().ShowDialog());
        AddMenuButton(grpDe1, "3. Bài 2: Đăng Ký Tài Khoản", 111, () => new FrmDangKyTaiKhoan().ShowDialog());
        AddMenuButton(grpDe1, "4. Bài 3: Ước Số & Bội Số (UCLN, BCNN)", 154, () => new FrmUCLN_BCNN().ShowDialog());
        AddMenuButton(grpDe1, "5. Bài 4: Nhập Dãy Số & Tính Tổng", 197, () => new FrmDaySo().ShowDialog());
        AddMenuButton(grpDe1, "6. Bài 5: Đọc Số Thành Chữ (1 - 999)", 240, () => new FrmDocSo().ShowDialog());
        AddMenuButton(grpDe1, "7. Nâng Cao: Bán Vé Rạp Chiếu Phim", 283, () => new FrmBanVePhim().ShowDialog());
        AddMenuButton(grpDe1, "8. Về Nhà: Máy Tính Bỏ Túi (Calculator)", 326, () => new FrmMayTinhBoTui().ShowDialog());

        // GROUP 2: ĐỀ LAB 04_2
        GroupBox grpDe2 = new GroupBox
        {
            Text = "ĐỀ LAB 04_2: RADIOBUTTON, CHECKBOX & OOP",
            Font = new Font("Tahoma", 10F, FontStyle.Bold),
            ForeColor = Color.DarkGreen,
            Location = new Point(430, 80),
            Size = new Size(380, 400)
        };

        AddMenuButton(grpDe2, "1. Bài Mẫu 1: Phép Tính Radio + Class TinhToan", 25, () => new FrmTinhToanRadio().ShowDialog());
        AddMenuButton(grpDe2, "2. Bài Mẫu 2: Định Dạng Font & Màu Sắc", 68, () => new FrmDinhDangFont().ShowDialog());
        AddMenuButton(grpDe2, "3. Bài 1: Giải Phương Trình Bậc 1 & 2 (OOP)", 111, () => new FrmGiaiPhuongTrinh().ShowDialog());
        AddMenuButton(grpDe2, "4. Bài 2: Thao Tác Mảng Số Nguyên (OOP)", 154, () => new FrmMangSoNguyen().ShowDialog());
        AddMenuButton(grpDe2, "5. Nâng Cao: Quản Lý Cafe Sinh Viên", 197, () => new FrmCafeSinhVien().ShowDialog());
        AddMenuButton(grpDe2, "6. Về Nhà: Quản Lý Khách Sạn Thanh Thanh", 240, () => new FrmKhachSanThanhThanh().ShowDialog());

        Button btnThoat = new Button
        {
            Text = "Thoát Chương Trình",
            Font = new Font("Tahoma", 10F, FontStyle.Bold),
            ForeColor = Color.Black,
            BackColor = Color.MistyRose,
            Location = new Point(340, 495),
            Size = new Size(160, 38)
        };
        btnThoat.Click += (s, e) => this.Close();

        this.FormClosing += (s, e) =>
        {
            var r = MessageBox.Show("Bạn có muốn thoát khỏi ứng dụng tổng hợp Lab 04?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No) e.Cancel = true;
        };

        this.Controls.AddRange(new Control[] { lblTitle, lblInfo, grpDe1, grpDe2, btnThoat });
    }

    private void AddMenuButton(GroupBox grp, string text, int top, Action onClick)
    {
        Button btn = new Button
        {
            Text = text,
            Font = new Font("Tahoma", 9F, FontStyle.Regular),
            ForeColor = Color.Black,
            TextAlign = ContentAlignment.MiddleLeft,
            Location = new Point(20, top),
            Size = new Size(340, 36),
            BackColor = Color.WhiteSmoke
        };
        btn.Click += (s, e) => onClick();
        grp.Controls.Add(btn);
    }
}
