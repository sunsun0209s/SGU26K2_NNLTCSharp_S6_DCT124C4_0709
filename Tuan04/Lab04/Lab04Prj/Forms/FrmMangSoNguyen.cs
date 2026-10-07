using System;
using System.Drawing;
using System.Windows.Forms;
using Lab04Prj.Models;

namespace Lab04Prj.Forms;

public class FrmMangSoNguyen : Form
{
    private Label lblTitle = null!;
    private Label lblNhapMang = null!;
    private TextBox txtNhapMang = null!;
    private Button btnReset = null!;
    private Button btnThoat = null!;
    private Label lblKetQua = null!;
    private TextBox txtKetQua = null!;

    // Sắp xếp
    private Button btnSapXep = null!;
    private RadioButton rdoTang = null!;
    private RadioButton rdoGiam = null!;

    // Tìm kiếm
    private RadioButton rdoTimGiaTri = null!;
    private RadioButton rdoTimViTri = null!;
    private TextBox txtGiaTriTim = null!;
    private Label lblKetQuaTim = null!;
    private TextBox txtKetQuaTim = null!;
    private Button btnThucHienTim = null!;

    // Max Min
    private Label lblMax = null!;
    private TextBox txtMax = null!;
    private Label lblMin = null!;
    private TextBox txtMin = null!;
    private Button btnTimMaxMin = null!;

    // Tổng
    private Label lblTongMang = null!;
    private TextBox txtTongMang = null!;
    private Label lblTongChan = null!;
    private TextBox txtTongChan = null!;
    private Label lblTongLe = null!;
    private TextBox txtTongLe = null!;
    private Button btnTinhTong = null!;

    // Thêm
    private TextBox txtThemGiaTri = null!;
    private TextBox txtThemViTri = null!;
    private Button btnThem = null!;

    // Xóa
    private RadioButton rdoXoaGiaTri = null!;
    private RadioButton rdoXoaViTri = null!;
    private TextBox txtXoaInput = null!;
    private Button btnXoa = null!;

    // Thay thế
    private TextBox txtThayGiaTriCu = null!;
    private TextBox txtThayGiaTriMoi = null!;
    private Button btnThayThe = null!;

    private MangSoNguyen mang = new();

    public FrmMangSoNguyen()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        this.Text = "Mảng Số Nguyên";
        this.Font = new Font("Tahoma", 9.5F, FontStyle.Regular);
        this.Size = new Size(620, 560);
        this.StartPosition = FormStartPosition.CenterScreen;
        this.FormBorderStyle = FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;

        lblTitle = new Label
        {
            Text = "Mảng Số Nguyên",
            Font = new Font("Tahoma", 15F, FontStyle.Bold),
            ForeColor = Color.Red,
            TextAlign = ContentAlignment.MiddleCenter,
            Location = new Point(20, 10),
            Size = new Size(560, 30)
        };

        // Nhập mảng & Kết quả
        lblNhapMang = new Label { Text = "Nhập mảng:", Location = new Point(20, 50), Size = new Size(90, 25) };
        txtNhapMang = new TextBox { Text = "5 6 4 7 8 9 10 5 6 3 2 1", Location = new Point(115, 48), Size = new Size(330, 25) };
        btnReset = new Button { Text = "Reset", Location = new Point(460, 46), Size = new Size(65, 28) };
        btnThoat = new Button { Text = "Thoát", Location = new Point(530, 46), Size = new Size(65, 28) };

        lblKetQua = new Label { Text = "Kết quả mảng:", Location = new Point(20, 85), Size = new Size(90, 25) };
        txtKetQua = new TextBox { Location = new Point(115, 83), Size = new Size(480, 25), ReadOnly = true };

        // Group 1: Sắp xếp
        GroupBox grpSapXep = new GroupBox { Text = "Sắp Xếp", Location = new Point(20, 120), Size = new Size(275, 75) };
        rdoTang = new RadioButton { Text = "Sắp xếp Tăng", Checked = true, Location = new Point(15, 22), Size = new Size(110, 25) };
        rdoGiam = new RadioButton { Text = "Sắp xếp Giảm", Location = new Point(135, 22), Size = new Size(110, 25) };
        btnSapXep = new Button { Text = "Thực Hiện", Location = new Point(85, 45), Size = new Size(95, 25) };
        grpSapXep.Controls.AddRange(new Control[] { rdoTang, rdoGiam, btnSapXep });

        // Group 2: Tổng
        GroupBox grpTong = new GroupBox { Text = "Tổng", Location = new Point(310, 120), Size = new Size(285, 115) };
        lblTongMang = new Label { Text = "Tổng mảng:", Location = new Point(15, 22), Size = new Size(80, 22) };
        txtTongMang = new TextBox { Location = new Point(100, 20), Size = new Size(75, 22), ReadOnly = true };
        lblTongChan = new Label { Text = "Tổng chẵn:", Location = new Point(15, 52), Size = new Size(80, 22) };
        txtTongChan = new TextBox { Location = new Point(100, 50), Size = new Size(75, 22), ReadOnly = true };
        lblTongLe = new Label { Text = "Tổng lẻ:", Location = new Point(15, 82), Size = new Size(80, 22) };
        txtTongLe = new TextBox { Location = new Point(100, 80), Size = new Size(75, 22), ReadOnly = true };
        btnTinhTong = new Button { Text = "Tổng", Location = new Point(190, 35), Size = new Size(75, 55) };
        grpTong.Controls.AddRange(new Control[] { lblTongMang, txtTongMang, lblTongChan, txtTongChan, lblTongLe, txtTongLe, btnTinhTong });

        // Group 3: Tìm kiếm
        GroupBox grpTimKiem = new GroupBox { Text = "Tìm Kiếm", Location = new Point(20, 200), Size = new Size(275, 115) };
        rdoTimGiaTri = new RadioButton { Text = "Tìm giá trị", Checked = true, Location = new Point(10, 20), Size = new Size(95, 22) };
        rdoTimViTri = new RadioButton { Text = "Tìm theo vị trí", Location = new Point(110, 20), Size = new Size(110, 22) };
        txtGiaTriTim = new TextBox { Location = new Point(10, 48), Size = new Size(80, 22) };
        btnThucHienTim = new Button { Text = "Tìm", Location = new Point(100, 46), Size = new Size(60, 25) };
        lblKetQuaTim = new Label { Text = "Kết quả:", Location = new Point(10, 82), Size = new Size(65, 22) };
        txtKetQuaTim = new TextBox { Location = new Point(80, 80), Size = new Size(180, 22), ReadOnly = true };
        grpTimKiem.Controls.AddRange(new Control[] { rdoTimGiaTri, rdoTimViTri, txtGiaTriTim, btnThucHienTim, lblKetQuaTim, txtKetQuaTim });

        // Group 4: Max - Min
        GroupBox grpMaxMin = new GroupBox { Text = "Max - Min", Location = new Point(20, 320), Size = new Size(275, 85) };
        lblMax = new Label { Text = "Lớn nhất:", Location = new Point(10, 22), Size = new Size(70, 22) };
        txtMax = new TextBox { Location = new Point(85, 20), Size = new Size(70, 22), ReadOnly = true };
        lblMin = new Label { Text = "Nhỏ nhất:", Location = new Point(10, 52), Size = new Size(70, 22) };
        txtMin = new TextBox { Location = new Point(85, 50), Size = new Size(70, 22), ReadOnly = true };
        btnTimMaxMin = new Button { Text = "Tìm", Location = new Point(175, 25), Size = new Size(80, 45) };
        grpMaxMin.Controls.AddRange(new Control[] { lblMax, txtMax, lblMin, txtMin, btnTimMaxMin });

        // Group 5: Thêm phần tử
        GroupBox grpThem = new GroupBox { Text = "Thêm phần tử", Location = new Point(310, 240), Size = new Size(285, 80) };
        Label lblThemGiaTri = new Label { Text = "Giá trị:", Location = new Point(10, 22), Size = new Size(50, 22) };
        txtThemGiaTri = new TextBox { Location = new Point(65, 20), Size = new Size(55, 22) };
        Label lblThemViTri = new Label { Text = "Vị trí:", Location = new Point(130, 22), Size = new Size(40, 22) };
        txtThemViTri = new TextBox { Location = new Point(175, 20), Size = new Size(45, 22) };
        btnThem = new Button { Text = "Thêm", Location = new Point(100, 48), Size = new Size(80, 26) };
        grpThem.Controls.AddRange(new Control[] { lblThemGiaTri, txtThemGiaTri, lblThemViTri, txtThemViTri, btnThem });

        // Group 6: Xóa phần tử
        GroupBox grpXoa = new GroupBox { Text = "Xóa phần tử", Location = new Point(310, 325), Size = new Size(285, 80) };
        rdoXoaGiaTri = new RadioButton { Text = "Xóa giá trị", Checked = true, Location = new Point(10, 18), Size = new Size(90, 22) };
        rdoXoaViTri = new RadioButton { Text = "Xóa theo vị trí", Location = new Point(110, 18), Size = new Size(110, 22) };
        txtXoaInput = new TextBox { Location = new Point(10, 45), Size = new Size(80, 22) };
        btnXoa = new Button { Text = "Xóa", Location = new Point(110, 43), Size = new Size(75, 26) };
        grpXoa.Controls.AddRange(new Control[] { rdoXoaGiaTri, rdoXoaViTri, txtXoaInput, btnXoa });

        // Group 7: Thay thế
        GroupBox grpThayThe = new GroupBox { Text = "Thay Thế", Location = new Point(20, 415), Size = new Size(575, 65) };
        Label lblCu = new Label { Text = "Giá trị cũ:", Location = new Point(20, 25), Size = new Size(65, 22) };
        txtThayGiaTriCu = new TextBox { Location = new Point(90, 22), Size = new Size(70, 22) };
        Label lblMoi = new Label { Text = "Giá trị mới:", Location = new Point(190, 25), Size = new Size(75, 22) };
        txtThayGiaTriMoi = new TextBox { Location = new Point(275, 22), Size = new Size(70, 22) };
        btnThayThe = new Button { Text = "Thay Thế", Location = new Point(380, 20), Size = new Size(95, 28) };
        grpThayThe.Controls.AddRange(new Control[] { lblCu, txtThayGiaTriCu, lblMoi, txtThayGiaTriMoi, btnThayThe });

        // Gắn sự kiện
        txtNhapMang.TextChanged += (s, e) => NapDuLieuMang();
        btnReset.Click += (s, e) =>
        {
            txtNhapMang.Text = "5 6 4 7 8 9 10 5 6 3 2 1";
            NapDuLieuMang();
        };
        btnThoat.Click += (s, e) => this.Close();

        btnSapXep.Click += BtnSapXep_Click;
        btnTinhTong.Click += BtnTinhTong_Click;
        btnThucHienTim.Click += BtnThucHienTim_Click;
        btnTimMaxMin.Click += BtnTimMaxMin_Click;
        btnThem.Click += BtnThem_Click;
        btnXoa.Click += BtnXoa_Click;
        btnThayThe.Click += BtnThayThe_Click;

        this.FormClosing += (s, e) =>
        {
            var r = MessageBox.Show("Bạn có muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No) e.Cancel = true;
        };

        this.Controls.AddRange(new Control[] {
            lblTitle, lblNhapMang, txtNhapMang, btnReset, btnThoat, lblKetQua, txtKetQua,
            grpSapXep, grpTong, grpTimKiem, grpMaxMin, grpThem, grpXoa, grpThayThe
        });

        NapDuLieuMang();
    }

    private void NapDuLieuMang()
    {
        mang.NhapTuChuoi(txtNhapMang.Text);
        txtKetQua.Text = mang.XuatChuoi();
    }

    private void BtnSapXep_Click(object? sender, EventArgs e)
    {
        if (rdoTang.Checked) mang.SapXepTang();
        else mang.SapXepGiam();
        txtKetQua.Text = mang.XuatChuoi();
    }

    private void BtnTinhTong_Click(object? sender, EventArgs e)
    {
        txtTongMang.Text = mang.Tong().ToString();
        txtTongChan.Text = mang.TongChan().ToString();
        txtTongLe.Text = mang.TongLe().ToString();
    }

    private void BtnThucHienTim_Click(object? sender, EventArgs e)
    {
        if (!int.TryParse(txtGiaTriTim.Text.Trim(), out int val))
        {
            MessageBox.Show("Vui lòng nhập số hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (rdoTimGiaTri.Checked)
        {
            int idx = mang.TimGiaTri(val);
            if (idx >= 0) txtKetQuaTim.Text = $"Tìm thấy tại vị trí: {idx}";
            else txtKetQuaTim.Text = "Không tìm thấy giá trị!";
        }
        else
        {
            int? res = mang.LayTaiViTri(val);
            if (res.HasValue) txtKetQuaTim.Text = $"Giá trị tại index {val}: {res.Value}";
            else txtKetQuaTim.Text = "Vị trí vượt quá kích thước mảng!";
        }
    }

    private void BtnTimMaxMin_Click(object? sender, EventArgs e)
    {
        txtMax.Text = mang.Max()?.ToString() ?? "N/A";
        txtMin.Text = mang.Min()?.ToString() ?? "N/A";
    }

    private void BtnThem_Click(object? sender, EventArgs e)
    {
        if (int.TryParse(txtThemGiaTri.Text.Trim(), out int val) && int.TryParse(txtThemViTri.Text.Trim(), out int idx))
        {
            if (mang.ThemPhanTu(val, idx))
            {
                txtKetQua.Text = mang.XuatChuoi();
                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vị trí thêm không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }

    private void BtnXoa_Click(object? sender, EventArgs e)
    {
        if (!int.TryParse(txtXoaInput.Text.Trim(), out int val)) return;

        bool ok = rdoXoaGiaTri.Checked ? mang.XoaTheoGiaTri(val) : mang.XoaTheoViTri(val);
        if (ok)
        {
            txtKetQua.Text = mang.XuatChuoi();
            MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else
        {
            MessageBox.Show("Không tìm thấy phần tử để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void BtnThayThe_Click(object? sender, EventArgs e)
    {
        if (int.TryParse(txtThayGiaTriCu.Text.Trim(), out int oldVal) && int.TryParse(txtThayGiaTriMoi.Text.Trim(), out int newVal))
        {
            if (mang.ThayTheTheoGiaTri(oldVal, newVal))
            {
                txtKetQua.Text = mang.XuatChuoi();
                MessageBox.Show("Thay thế thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không tìm thấy giá trị cũ để thay thế!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
