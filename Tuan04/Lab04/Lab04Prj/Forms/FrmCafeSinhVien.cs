using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab04Prj.Forms;

public class FrmCafeSinhVien : Form
{
    private Label lblTitle = null!;
    private Label lblTenKhach = null!;
    private TextBox txtTenKhach = null!;
    private Label lblSoKhach = null!;
    private TextBox txtSoKhach = null!;
    private CheckBox chkSinhVien = null!;

    // Nước uống (RadioButtons)
    private RadioButton rdoCafeDen = null!;
    private RadioButton rdoCafeDa = null!;
    private RadioButton rdoCafeSua = null!;
    private RadioButton rdoCafeSuaDa = null!;
    private RadioButton rdoCafeKem = null!;

    // Thức ăn (CheckBoxes)
    private CheckBox chkBMTrung = null!;
    private CheckBox chkBMCa = null!;
    private CheckBox chkMyTomTrung = null!;
    private CheckBox chkMyXaoBo = null!;
    private CheckBox chkMyCay = null!;

    // Nút chức năng
    private Button btnTinhTien = null!;
    private Button btnNhapLai = null!;
    private Button btnThanhToan = null!;
    private Button btnThoat = null!;

    // Thống kê cuối ngày
    private Label lblTongKhach = null!;
    private TextBox txtTongKhach = null!;
    private Label lblTongTien = null!;
    private TextBox txtTongTien = null!;

    // Biến lưu trữ cộng dồn
    private int tongSoKhachTrongNgay = 0;
    private long tongTienTrongNgay = 0;
    private long tienHienTai = 0;

    public FrmCafeSinhVien()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        this.Text = "Thanh toán tiền";
        this.Font = new Font("Tahoma", 10F, FontStyle.Regular);
        this.Size = new Size(540, 520);
        this.StartPosition = FormStartPosition.CenterScreen;
        this.FormBorderStyle = FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;

        lblTitle = new Label
        {
            Text = "CAFE SINH VIÊN",
            Font = new Font("Tahoma", 16F, FontStyle.Bold),
            ForeColor = Color.DarkOrange,
            TextAlign = ContentAlignment.MiddleCenter,
            Location = new Point(20, 10),
            Size = new Size(480, 35)
        };

        lblTenKhach = new Label { Text = "Tên khách hàng:", Location = new Point(30, 55), Size = new Size(130, 25) };
        txtTenKhach = new TextBox { Location = new Point(170, 52), Size = new Size(320, 25) };

        lblSoKhach = new Label { Text = "Số khách hàng:", Location = new Point(30, 88), Size = new Size(130, 25) };
        txtSoKhach = new TextBox { Location = new Point(170, 85), Size = new Size(320, 25) };

        chkSinhVien = new CheckBox { Text = "Sinh viên ? (Giảm 20%)", Location = new Point(170, 118), Size = new Size(200, 25) };

        // Group nước uống
        GroupBox grpNuocUong = new GroupBox { Text = "Nước uống", Location = new Point(30, 145), Size = new Size(225, 155) };
        rdoCafeDen = new RadioButton { Text = "Cafe đen (20.000đ)", Location = new Point(15, 22), Size = new Size(190, 24) };
        rdoCafeDa = new RadioButton { Text = "Cafe đá (25.000đ)", Location = new Point(15, 47), Size = new Size(190, 24) };
        rdoCafeSua = new RadioButton { Text = "Cafe sữa (25.000đ)", Location = new Point(15, 72), Size = new Size(190, 24) };
        rdoCafeSuaDa = new RadioButton { Text = "Cafe sữa đá (30.000đ)", Location = new Point(15, 97), Size = new Size(190, 24) };
        rdoCafeKem = new RadioButton { Text = "Cafe kem (35.000đ)", Location = new Point(15, 122), Size = new Size(190, 24) };
        grpNuocUong.Controls.AddRange(new Control[] { rdoCafeDen, rdoCafeDa, rdoCafeSua, rdoCafeSuaDa, rdoCafeKem });

        // Group thức ăn
        GroupBox grpThucAn = new GroupBox { Text = "Thức ăn", Location = new Point(275, 145), Size = new Size(225, 155) };
        chkBMTrung = new CheckBox { Text = "Bánh mỳ trứng (15k)", Location = new Point(15, 22), Size = new Size(190, 24) };
        chkBMCa = new CheckBox { Text = "Bánh mỳ cá (15k)", Location = new Point(15, 47), Size = new Size(190, 24) };
        chkMyTomTrung = new CheckBox { Text = "Mỳ tôm trứng (20k)", Location = new Point(15, 72), Size = new Size(190, 24) };
        chkMyXaoBo = new CheckBox { Text = "Mỳ xào bò (30k)", Location = new Point(15, 97), Size = new Size(190, 24) };
        chkMyCay = new CheckBox { Text = "Mỳ cay (50k)", Location = new Point(15, 122), Size = new Size(190, 24) };
        grpThucAn.Controls.AddRange(new Control[] { chkBMTrung, chkBMCa, chkMyTomTrung, chkMyXaoBo, chkMyCay });

        // Các nút bấm
        btnTinhTien = new Button { Text = "Tính tiền", Location = new Point(30, 315), Size = new Size(105, 35), Enabled = false };
        btnNhapLai = new Button { Text = "Nhập lại", Location = new Point(150, 315), Size = new Size(105, 35), Enabled = false };
        btnThanhToan = new Button { Text = "Thanh toán", Location = new Point(270, 315), Size = new Size(110, 35), Enabled = false };
        btnThoat = new Button { Text = "Thoát", Location = new Point(395, 315), Size = new Size(105, 35) };

        // Thống kê
        lblTongKhach = new Label { Text = "Tổng khách hàng:", Location = new Point(30, 375), Size = new Size(150, 25) };
        txtTongKhach = new TextBox { Text = "0", Location = new Point(190, 372), Size = new Size(300, 25), ReadOnly = true };

        lblTongTien = new Label { Text = "Tổng tiền thanh toán:", Location = new Point(30, 415), Size = new Size(150, 25) };
        txtTongTien = new TextBox { Text = "0 VNĐ", Location = new Point(190, 412), Size = new Size(300, 25), ReadOnly = true };

        // Xử lý chặn chỉ cho nhập số ở ô Số khách hàng
        txtSoKhach.KeyPress += (s, e) =>
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        };

        // Bật nút tính tiền khi nhập đủ thông tin
        txtTenKhach.TextChanged += (s, e) => KiemTraNhapDu();
        txtSoKhach.TextChanged += (s, e) => KiemTraNhapDu();
        rdoCafeDen.CheckedChanged += (s, e) => KiemTraNhapDu();
        rdoCafeDa.CheckedChanged += (s, e) => KiemTraNhapDu();
        rdoCafeSua.CheckedChanged += (s, e) => KiemTraNhapDu();
        rdoCafeSuaDa.CheckedChanged += (s, e) => KiemTraNhapDu();
        rdoCafeKem.CheckedChanged += (s, e) => KiemTraNhapDu();

        btnTinhTien.Click += BtnTinhTien_Click;
        btnNhapLai.Click += BtnNhapLai_Click;
        btnThanhToan.Click += BtnThanhToan_Click;
        btnThoat.Click += (s, e) => this.Close();

        this.FormClosing += (s, e) =>
        {
            var r = MessageBox.Show("Bạn có chắc chắn muốn thoát khỏi chương trình?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No) e.Cancel = true;
        };

        this.Controls.AddRange(new Control[] {
            lblTitle, lblTenKhach, txtTenKhach, lblSoKhach, txtSoKhach, chkSinhVien,
            grpNuocUong, grpThucAn, btnTinhTien, btnNhapLai, btnThanhToan, btnThoat,
            lblTongKhach, txtTongKhach, lblTongTien, txtTongTien
        });
    }

    private bool CoChonNuoc()
    {
        return rdoCafeDen.Checked || rdoCafeDa.Checked || rdoCafeSua.Checked || rdoCafeSuaDa.Checked || rdoCafeKem.Checked;
    }

    private void KiemTraNhapDu()
    {
        bool coTen = !string.IsNullOrWhiteSpace(txtTenKhach.Text);
        bool coSoKhach = int.TryParse(txtSoKhach.Text.Trim(), out int sk) && sk > 0;
        bool coNuoc = CoChonNuoc();

        btnTinhTien.Enabled = coTen && coSoKhach && coNuoc;
    }

    private void BtnTinhTien_Click(object? sender, EventArgs e)
    {
        long tienNuoc = 0;
        if (rdoCafeDen.Checked) tienNuoc = 20000;
        else if (rdoCafeDa.Checked) tienNuoc = 25000;
        else if (rdoCafeSua.Checked) tienNuoc = 25000;
        else if (rdoCafeSuaDa.Checked) tienNuoc = 30000;
        else if (rdoCafeKem.Checked) tienNuoc = 35000;

        long tienThucAn = 0;
        if (chkBMTrung.Checked) tienThucAn += 15000;
        if (chkBMCa.Checked) tienThucAn += 15000;
        if (chkMyTomTrung.Checked) tienThucAn += 20000;
        if (chkMyXaoBo.Checked) tienThucAn += 30000;
        if (chkMyCay.Checked) tienThucAn += 50000;

        long tong1Khach = tienNuoc + tienThucAn;
        int soKhach = int.Parse(txtSoKhach.Text.Trim());
        long tongTienChuaGiam = tong1Khach * soKhach;

        if (chkSinhVien.Checked)
        {
            tienHienTai = (long)(tongTienChuaGiam * 0.8); // Giảm 20%
        }
        else
        {
            tienHienTai = tongTienChuaGiam;
        }

        string msg = $"HÓA ĐƠN QUÁN CAFE SINH VIÊN\n" +
                     $"- Khách hàng: {txtTenKhach.Text.Trim()}\n" +
                     $"- Số lượng khách: {soKhach}\n" +
                     $"- Tổng tiền gốc: {tongTienChuaGiam:N0} VNĐ\n" +
                     $"- Giảm giá sinh viên: {(chkSinhVien.Checked ? "20%" : "0%")}\n" +
                     $"==> THÀNH TIỀN: {tienHienTai:N0} VNĐ";

        MessageBox.Show(msg, "Chi tiết thanh toán", MessageBoxButtons.OK, MessageBoxIcon.Information);

        btnNhapLai.Enabled = true;
        btnThanhToan.Enabled = true;
    }

    private void BtnNhapLai_Click(object? sender, EventArgs e)
    {
        txtTenKhach.Clear();
        txtSoKhach.Clear();
        chkSinhVien.Checked = false;
        rdoCafeDen.Checked = false;
        rdoCafeDa.Checked = false;
        rdoCafeSua.Checked = false;
        rdoCafeSuaDa.Checked = false;
        rdoCafeKem.Checked = false;
        chkBMTrung.Checked = false;
        chkBMCa.Checked = false;
        chkMyTomTrung.Checked = false;
        chkMyXaoBo.Checked = false;
        chkMyCay.Checked = false;

        btnTinhTien.Enabled = false;
        btnNhapLai.Enabled = false;
        btnThanhToan.Enabled = false;

        txtTenKhach.Focus();
    }

    private void BtnThanhToan_Click(object? sender, EventArgs e)
    {
        if (int.TryParse(txtSoKhach.Text.Trim(), out int sk))
        {
            tongSoKhachTrongNgay += sk;
            tongTienTrongNgay += tienHienTai;

            txtTongKhach.Text = tongSoKhachTrongNgay.ToString();
            txtTongTien.Text = $"{tongTienTrongNgay:N0} VNĐ";

            BtnNhapLai_Click(sender, e);
            btnThanhToan.Enabled = false;

            MessageBox.Show("Đã ghi nhận thanh toán vào sổ tổng kết ngày!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
