using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab04Prj.Forms;

public class FrmKhachSanThanhThanh : Form
{
    private Label lblTitle = null!;
    private Label lblHoTen = null!;
    private TextBox txtHoTen = null!;
    private Label lblDiaChi = null!;
    private TextBox txtDiaChi = null!;
    private Label lblSoNgay = null!;
    private TextBox txtSoNgay = null!;

    // Loại phòng (RadioButtons)
    private RadioButton rdoDon = null!;
    private RadioButton rdoDoi = null!;
    private RadioButton rdoBa = null!;

    // Tiện nghi (CheckBoxes)
    private CheckBox chkTivi = null!;
    private CheckBox chkInternet = null!;
    private CheckBox chkNuocNong = null!;

    // Dịch vụ (CheckBoxes)
    private CheckBox chkKaraoke = null!;
    private CheckBox chkAnSang = null!;

    // Nút chức năng
    private Button btnThanhToan = null!;
    private Button btnNhapMoi = null!;
    private Label lblThanhTien = null!;
    private TextBox txtThanhTien = null!;

    // Tổng kết
    private Button btnTongKet = null!;
    private Label lblTongLuot = null!;
    private TextBox txtTongLuot = null!;
    private Label lblTongTien = null!;
    private TextBox txtTongTien = null!;
    private Button btnThoat = null!;

    // Biến lưu trữ
    private int tongLuotKhach = 0;
    private long tongTienThuDuoc = 0;
    private long tienHienTai = 0;

    public FrmKhachSanThanhThanh()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        this.Text = "frmDangKyKS";
        this.Font = new Font("Tahoma", 9.5F, FontStyle.Regular);
        this.Size = new Size(620, 520);
        this.StartPosition = FormStartPosition.CenterScreen;
        this.FormBorderStyle = FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;

        lblTitle = new Label
        {
            Text = "KHÁCH SẠN THANH THANH - TRẢ PHÒNG",
            Font = new Font("Tahoma", 15F, FontStyle.Bold),
            ForeColor = Color.DarkOrange,
            TextAlign = ContentAlignment.MiddleCenter,
            Location = new Point(20, 10),
            Size = new Size(560, 35)
        };

        lblHoTen = new Label { Text = "Họ và tên:", Location = new Point(25, 55), Size = new Size(80, 22) };
        txtHoTen = new TextBox { Location = new Point(110, 52), Size = new Size(250, 22) };

        lblDiaChi = new Label { Text = "Địa chỉ:", Location = new Point(25, 85), Size = new Size(80, 22) };
        txtDiaChi = new TextBox { Location = new Point(110, 82), Size = new Size(250, 22) };

        lblSoNgay = new Label { Text = "Số ngày ở:", Location = new Point(25, 115), Size = new Size(80, 22) };
        txtSoNgay = new TextBox { Location = new Point(110, 112), Size = new Size(100, 22) };

        // Nút Thanh toán và Nhập mới ở góc trên bên phải
        btnThanhToan = new Button { Text = "Thanh toán", Location = new Point(380, 52), Size = new Size(95, 30), Enabled = false };
        btnNhapMoi = new Button { Text = "Nhập mới", Location = new Point(485, 52), Size = new Size(95, 30), Enabled = false };

        lblThanhTien = new Label { Text = "Thành tiền:", Location = new Point(380, 95), Size = new Size(80, 22) };
        txtThanhTien = new TextBox { Text = "0 VNĐ", Location = new Point(460, 92), Size = new Size(120, 22), ReadOnly = true, TextAlign = HorizontalAlignment.Right };

        // Group Loại phòng
        GroupBox grpLoaiPhong = new GroupBox { Text = "Loại phòng", Location = new Point(25, 150), Size = new Size(160, 140) };
        rdoDon = new RadioButton { Text = "Phòng đơn\n(300k/ngày)", Location = new Point(15, 20), Size = new Size(130, 35) };
        rdoDoi = new RadioButton { Text = "Phòng đôi\n(350k/ngày)", Location = new Point(15, 58), Size = new Size(130, 35) };
        rdoBa = new RadioButton { Text = "Phòng ba\n(400k/ngày)", Location = new Point(15, 96), Size = new Size(130, 35) };
        grpLoaiPhong.Controls.AddRange(new Control[] { rdoDon, rdoDoi, rdoBa });

        // Group Tiện nghi
        GroupBox grpTienNghi = new GroupBox { Text = "Tiện nghi (+10k/loại)", Location = new Point(200, 150), Size = new Size(175, 140) };
        chkTivi = new CheckBox { Text = "Tivi", Location = new Point(15, 25), Size = new Size(140, 25) };
        chkInternet = new CheckBox { Text = "Internet", Location = new Point(15, 60), Size = new Size(140, 25) };
        chkNuocNong = new CheckBox { Text = "Máy nước nóng", Location = new Point(15, 95), Size = new Size(140, 25) };
        grpTienNghi.Controls.AddRange(new Control[] { chkTivi, chkInternet, chkNuocNong });

        // Group Dịch vụ
        GroupBox grpDichVu = new GroupBox { Text = "Dịch vụ", Location = new Point(390, 150), Size = new Size(190, 140) };
        chkKaraoke = new CheckBox { Text = "Karaoke (50.000đ)", Location = new Point(15, 30), Size = new Size(160, 25) };
        chkAnSang = new CheckBox { Text = "Ăn sáng (15k/ngày)", Location = new Point(15, 75), Size = new Size(160, 25) };
        grpDichVu.Controls.AddRange(new Control[] { chkKaraoke, chkAnSang });

        // Group Tổng kết
        GroupBox grpTongKet = new GroupBox { Text = "Tổng Kết (Thông tin tổng kết cuối ngày)", Location = new Point(25, 305), Size = new Size(555, 115) };
        lblTongLuot = new Label { Text = "Số lượt người:", Location = new Point(20, 30), Size = new Size(100, 22) };
        txtTongLuot = new TextBox { Text = "0", Location = new Point(130, 28), Size = new Size(150, 22), ReadOnly = true };

        lblTongTien = new Label { Text = "Tổng số tiền:", Location = new Point(20, 68), Size = new Size(100, 22) };
        txtTongTien = new TextBox { Text = "0 VNĐ", Location = new Point(130, 66), Size = new Size(150, 22), ReadOnly = true };

        btnTongKet = new Button { Text = "Tổng Kết", Location = new Point(320, 35), Size = new Size(100, 50), Enabled = false };
        btnThoat = new Button { Text = "Thoát", Location = new Point(435, 35), Size = new Size(100, 50) };
        grpTongKet.Controls.AddRange(new Control[] { lblTongLuot, txtTongLuot, lblTongTien, txtTongTien, btnTongKet, btnThoat });

        // Chỉ cho nhập số ngày ở là số
        txtSoNgay.KeyPress += (s, e) =>
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        };

        // Kích hoạt nút thanh toán khi nhập đủ thông tin
        txtHoTen.TextChanged += (s, e) => KiemTraNhapDu();
        txtSoNgay.TextChanged += (s, e) => KiemTraNhapDu();
        rdoDon.CheckedChanged += (s, e) => KiemTraNhapDu();
        rdoDoi.CheckedChanged += (s, e) => KiemTraNhapDu();
        rdoBa.CheckedChanged += (s, e) => KiemTraNhapDu();

        btnThanhToan.Click += BtnThanhToan_Click;
        btnNhapMoi.Click += BtnNhapMoi_Click;
        btnTongKet.Click += BtnTongKet_Click;
        btnThoat.Click += (s, e) => this.Close();

        this.FormClosing += (s, e) =>
        {
            var r = MessageBox.Show("Bạn có chắc chắn muốn thoát khỏi chương trình?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No) e.Cancel = true;
        };

        this.Controls.AddRange(new Control[] {
            lblTitle, lblHoTen, txtHoTen, lblDiaChi, txtDiaChi, lblSoNgay, txtSoNgay,
            btnThanhToan, btnNhapMoi, lblThanhTien, txtThanhTien,
            grpLoaiPhong, grpTienNghi, grpDichVu, grpTongKet
        });
    }

    private void KiemTraNhapDu()
    {
        bool coTen = !string.IsNullOrWhiteSpace(txtHoTen.Text);
        bool coNgay = int.TryParse(txtSoNgay.Text.Trim(), out int ngay) && ngay > 0;
        bool coPhong = rdoDon.Checked || rdoDoi.Checked || rdoBa.Checked;

        btnThanhToan.Enabled = coTen && coNgay && coPhong;
    }

    private void BtnThanhToan_Click(object? sender, EventArgs e)
    {
        int soNgay = int.Parse(txtSoNgay.Text.Trim());

        long giaPhongNgay = 0;
        if (rdoDon.Checked) giaPhongNgay = 300000;
        else if (rdoDoi.Checked) giaPhongNgay = 350000;
        else if (rdoBa.Checked) giaPhongNgay = 400000;

        long tienTienNghi = 0;
        if (chkTivi.Checked) tienTienNghi += 10000;
        if (chkInternet.Checked) tienTienNghi += 10000;
        if (chkNuocNong.Checked) tienTienNghi += 10000;

        long tienDichVu = 0;
        if (chkKaraoke.Checked) tienDichVu += 50000;
        if (chkAnSang.Checked) tienDichVu += 15000 * soNgay;

        tienHienTai = (giaPhongNgay * soNgay) + tienTienNghi + tienDichVu;
        txtThanhTien.Text = $"{tienHienTai:N0} VNĐ";

        // Cộng dồn nội bộ
        tongLuotKhach++;
        tongTienThuDuoc += tienHienTai;

        btnNhapMoi.Enabled = true;
        btnTongKet.Enabled = true;

        MessageBox.Show($"Thanh toán thành công cho khách hàng: {txtHoTen.Text.Trim()}\nSố tiền phải trả: {tienHienTai:N0} VNĐ", "Hóa đơn thanh toán", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void BtnNhapMoi_Click(object? sender, EventArgs e)
    {
        txtHoTen.Clear();
        txtDiaChi.Clear();
        txtSoNgay.Clear();
        rdoDon.Checked = false;
        rdoDoi.Checked = false;
        rdoBa.Checked = false;
        chkTivi.Checked = false;
        chkInternet.Checked = false;
        chkNuocNong.Checked = false;
        chkKaraoke.Checked = false;
        chkAnSang.Checked = false;
        txtThanhTien.Text = "0 VNĐ";

        btnThanhToan.Enabled = false;
        btnNhapMoi.Enabled = false;

        txtHoTen.Focus();
    }

    private void BtnTongKet_Click(object? sender, EventArgs e)
    {
        txtTongLuot.Text = tongLuotKhach.ToString();
        txtTongTien.Text = $"{tongTienThuDuoc:N0} VNĐ";

        MessageBox.Show($"TỔNG KẾT DOANH THU TRONG NGÀY:\n- Tổng số lượt khách: {tongLuotKhach}\n- Tổng doanh thu: {tongTienThuDuoc:N0} VNĐ", "Báo cáo doanh thu", MessageBoxButtons.OK, MessageBoxIcon.Information);

        // Khởi tạo lại giá trị tổng theo yêu cầu đề bài
        tongLuotKhach = 0;
        tongTienThuDuoc = 0;
        btnTongKet.Enabled = false;
    }
}
