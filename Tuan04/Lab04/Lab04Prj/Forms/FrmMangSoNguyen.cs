using System;
using System.Windows.Forms;
using Lab04Prj.Models;

namespace Lab04Prj.Forms;

public partial class FrmMangSoNguyen : Form
{
    private MangSoNguyen mang = new();

    public FrmMangSoNguyen()
    {
        InitializeComponent();
        NapDuLieuMang();
    }

    private void TxtNhapMang_TextChanged(object? sender, EventArgs e) => NapDuLieuMang();

    private void BtnReset_Click(object? sender, EventArgs e)
    {
        txtNhapMang.Text = "5 6 4 7 8 9 10 5 6 3 2 1";
        NapDuLieuMang();
    }

    private void BtnThoat_Click(object? sender, EventArgs e) => this.Close();

    private void FrmMangSoNguyen_FormClosing(object? sender, FormClosingEventArgs e)
    {
        var r = MessageBox.Show("Bạn có muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (r == DialogResult.No)
        {
            e.Cancel = true;
        }
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
        if (rdoTimGiaTri.Checked)
        {
            if (int.TryParse(txtGiaTriTim.Text.Trim(), out int val))
            {
                int pos = mang.TimGiaTri(val);
                txtKetQuaTim.Text = pos >= 0 ? $"Tìm thấy tại vị trí: {pos}" : "Không tìm thấy";
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số cần tìm hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        else
        {
            if (int.TryParse(txtGiaTriTim.Text.Trim(), out int pos))
            {
                int? val = mang.LayTaiViTri(pos);
                txtKetQuaTim.Text = val.HasValue ? $"Giá trị tại [{pos}] là: {val.Value}" : "Vị trí ngoài phạm vi mảng";
            }
            else
            {
                MessageBox.Show("Vui lòng nhập vị trí hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }

    private void BtnTimMaxMin_Click(object? sender, EventArgs e)
    {
        int? max = mang.Max();
        int? min = mang.Min();
        txtMax.Text = max.HasValue ? max.Value.ToString() : "N/A";
        txtMin.Text = min.HasValue ? min.Value.ToString() : "N/A";
    }

    private void BtnThem_Click(object? sender, EventArgs e)
    {
        if (int.TryParse(txtThemGiaTri.Text.Trim(), out int val) && int.TryParse(txtThemViTri.Text.Trim(), out int pos))
        {
            if (mang.ThemPhanTu(val, pos))
            {
                txtKetQua.Text = mang.XuatChuoi();
            }
            else
            {
                MessageBox.Show("Vị trí chèn không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        else
        {
            MessageBox.Show("Vui lòng nhập số và vị trí hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void BtnXoa_Click(object? sender, EventArgs e)
    {
        if (rdoXoaGiaTri.Checked)
        {
            if (int.TryParse(txtXoaInput.Text.Trim(), out int val))
            {
                if (mang.XoaTheoGiaTri(val))
                {
                    txtKetQua.Text = mang.XuatChuoi();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy giá trị để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập giá trị hợp lệ để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        else
        {
            if (int.TryParse(txtXoaInput.Text.Trim(), out int pos))
            {
                if (mang.XoaTheoViTri(pos))
                {
                    txtKetQua.Text = mang.XuatChuoi();
                }
                else
                {
                    MessageBox.Show("Vị trí xóa ngoài phạm vi mảng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập vị trí hợp lệ để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }

    private void BtnThayThe_Click(object? sender, EventArgs e)
    {
        if (int.TryParse(txtThayGiaTriCu.Text.Trim(), out int cu) && int.TryParse(txtThayGiaTriMoi.Text.Trim(), out int moi))
        {
            if (mang.ThayTheTheoGiaTri(cu, moi))
            {
                txtKetQua.Text = mang.XuatChuoi();
            }
            else
            {
                MessageBox.Show("Không tìm thấy giá trị cũ trong mảng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        else
        {
            MessageBox.Show("Vui lòng nhập giá trị cũ và mới hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
