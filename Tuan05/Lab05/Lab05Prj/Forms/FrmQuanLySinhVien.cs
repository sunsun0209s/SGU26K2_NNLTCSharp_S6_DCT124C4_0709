using System;
using System.Windows.Forms;

namespace Lab05Prj.Forms;

public partial class FrmQuanLySinhVien : Form
{
    public FrmQuanLySinhVien()
    {
        InitializeComponent();
    }

    private void FrmQuanLySinhVien_Load(object? sender, EventArgs e)
    {
        trvLop.Nodes.Clear();
        cboLop.Items.Clear();

        string[] dsLop = { "05DHTH1", "05DHTH2", "05DHTH3", "05DHTH4" };
        foreach (string lop in dsLop)
        {
            trvLop.Nodes.Add(lop);
            cboLop.Items.Add(lop);
        }

        if (cboLop.Items.Count > 0)
        {
            cboLop.SelectedIndex = 0;
        }

        chkThemLop.Checked = false;
        grpThongTinLop.Visible = false;
        trvLop.ExpandAll();
    }

    private void ChkThemLop_CheckedChanged(object? sender, EventArgs e)
    {
        grpThongTinLop.Visible = chkThemLop.Checked;
    }

    private void BtnThemLop_Click(object? sender, EventArgs e)
    {
        string tenLop = txtTenLop.Text.Trim();
        if (string.IsNullOrWhiteSpace(tenLop))
        {
            MessageBox.Show("Vui lòng nhập tên lớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtTenLop.Focus();
            return;
        }

        foreach (TreeNode node in trvLop.Nodes)
        {
            if (string.Compare(node.Text.Trim(), tenLop, true) == 0)
            {
                MessageBox.Show("Tên lớp này đã tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenLop.SelectAll();
                txtTenLop.Focus();
                return;
            }
        }

        trvLop.Nodes.Add(tenLop);
        cboLop.Items.Add(tenLop);
        cboLop.SelectedItem = tenLop;
        txtTenLop.Clear();
        MessageBox.Show($"Đã thêm lớp '{tenLop}' thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private bool KiemTraTrungMaSV(string maSV)
    {
        foreach (TreeNode lopNode in trvLop.Nodes)
        {
            foreach (TreeNode svNode in lopNode.Nodes)
            {
                string text = svNode.Text;
                int commaIdx = text.IndexOf(',');
                string ma = commaIdx >= 0 ? text.Substring(0, commaIdx).Trim() : text.Trim();
                if (string.Compare(ma, maSV.Trim(), true) == 0)
                {
                    return true;
                }
            }
        }
        return false;
    }

    private void BtnCapNhat_Click(object? sender, EventArgs e)
    {
        string maSV = txtMaSV.Text.Trim();
        string hoTen = txtHoTen.Text.Trim();
        string diaChi = txtDiaChi.Text.Trim();
        string tenLop = cboLop.Text.Trim();

        if (string.IsNullOrWhiteSpace(maSV) || string.IsNullOrWhiteSpace(hoTen) || string.IsNullOrWhiteSpace(diaChi))
        {
            MessageBox.Show("Vui lòng nhập đầy đủ Mã SV, Họ Tên và Địa Chỉ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (string.IsNullOrWhiteSpace(tenLop))
        {
            MessageBox.Show("Vui lòng chọn một lớp học!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (KiemTraTrungMaSV(maSV))
        {
            MessageBox.Show($"Mã sinh viên '{maSV}' đã tồn tại trong hệ thống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txtMaSV.SelectAll();
            txtMaSV.Focus();
            return;
        }

        TreeNode? targetLopNode = null;
        foreach (TreeNode node in trvLop.Nodes)
        {
            if (string.Compare(node.Text.Trim(), tenLop, true) == 0)
            {
                targetLopNode = node;
                break;
            }
        }

        if (targetLopNode != null)
        {
            TreeNode svNode = targetLopNode.Nodes.Add($"{maSV}, {hoTen}");
            svNode.Nodes.Add(diaChi);

            targetLopNode.Expand();
            svNode.Expand();
            trvLop.SelectedNode = svNode;

            txtMaSV.Clear();
            txtHoTen.Clear();
            txtDiaChi.Clear();
            txtMaSV.Focus();
        }
    }

    private void BtnXoa_Click(object? sender, EventArgs e)
    {
        TreeNode? selectedNode = trvLop.SelectedNode;
        if (selectedNode == null)
        {
            MessageBox.Show("Vui lòng chọn một sinh viên trên TreeView để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        if (selectedNode.Level != 1)
        {
            MessageBox.Show("Chỉ được phép xóa node sinh viên (không được xóa node lớp hoặc node địa chỉ)!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var result = MessageBox.Show($"Bạn có chắc muốn xóa sinh viên '{selectedNode.Text}'?", "Xác nhận xóa",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        if (result == DialogResult.Yes)
        {
            trvLop.Nodes.Remove(selectedNode);
            txtMaSV.Clear();
            txtHoTen.Clear();
            txtDiaChi.Clear();
        }
    }

    private void TrvLop_AfterSelect(object? sender, TreeViewEventArgs e)
    {
        if (e.Node == null) return;

        TreeNode svNode;
        if (e.Node.Level == 1)
        {
            svNode = e.Node;
        }
        else if (e.Node.Level == 2 && e.Node.Parent != null)
        {
            svNode = e.Node.Parent;
        }
        else
        {
            return;
        }

        string text = svNode.Text;
        int commaIdx = text.IndexOf(',');
        if (commaIdx >= 0)
        {
            txtMaSV.Text = text.Substring(0, commaIdx).Trim();
            txtHoTen.Text = text.Substring(commaIdx + 1).Trim();
        }
        else
        {
            txtMaSV.Text = text.Trim();
            txtHoTen.Text = string.Empty;
        }

        if (svNode.Nodes.Count > 0)
        {
            txtDiaChi.Text = svNode.Nodes[0].Text.Trim();
        }
        else
        {
            txtDiaChi.Clear();
        }

        if (svNode.Parent != null)
        {
            cboLop.SelectedItem = svNode.Parent.Text;
        }
    }

    private void FrmQuanLySinhVien_FormClosing(object? sender, FormClosingEventArgs e)
    {
        var result = MessageBox.Show("Bạn có muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (result == DialogResult.No)
        {
            e.Cancel = true;
        }
    }
}
