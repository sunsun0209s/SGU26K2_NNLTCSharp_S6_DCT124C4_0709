using System;
using System.Windows.Forms;

namespace Lab05Prj.Forms;

public partial class FrmTreeView : Form
{
    public FrmTreeView()
    {
        InitializeComponent();
    }

    private void FrmTreeView_Load(object? sender, EventArgs e)
    {
        trv_DS.Nodes.Clear();
        cbo_phongban.Items.Clear();

        string[] pb = { "Giám đốc", "Tổ chức hành chính", "Kế hoạch", "Kế Toán" };
        foreach (string s in pb)
        {
            trv_DS.Nodes.Add(s);
            cbo_phongban.Items.Add(s);
        }

        if (cbo_phongban.Items.Count > 0)
        {
            cbo_phongban.SelectedIndex = 0;
        }

        trv_DS.ExpandAll();
    }

    private bool KiemTraPhongBanTonTai(string tenPhongBan)
    {
        foreach (TreeNode node in trv_DS.Nodes)
        {
            if (string.Compare(node.Text.Trim(), tenPhongBan.Trim(), true) == 0)
            {
                return true;
            }
        }
        return false;
    }

    private void Btn_ThemPB_Click(object? sender, EventArgs e)
    {
        string tenPB = txt_phongban.Text.Trim();
        if (string.IsNullOrWhiteSpace(tenPB))
        {
            MessageBox.Show("Vui lòng nhập tên phòng ban!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txt_phongban.Focus();
            return;
        }

        if (KiemTraPhongBanTonTai(tenPB))
        {
            MessageBox.Show("Phòng ban đã tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            txt_phongban.Clear();
            txt_phongban.Focus();
            return;
        }

        trv_DS.Nodes.Add(tenPB);
        cbo_phongban.Items.Add(tenPB);
        txt_phongban.Clear();
        txt_phongban.Focus();
    }

    private void Btn_XoaPB_Click(object? sender, EventArgs e)
    {
        if (trv_DS.SelectedNode == null)
        {
            MessageBox.Show("Vui lòng chọn phòng ban trên TreeView cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        // Đảm bảo chỉ xóa node phòng ban (node gốc cấp 0)
        TreeNode node = trv_DS.SelectedNode;
        if (node.Level != 0)
        {
            MessageBox.Show("Chỉ được phép xóa phòng ban (node gốc), không được chọn nhân viên để xóa ở đây!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var result = MessageBox.Show($"Bạn có chắc muốn xóa phòng ban '{node.Text}'?", "Thông báo",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

        if (result == DialogResult.Yes)
        {
            cbo_phongban.Items.Remove(node.Text);
            trv_DS.Nodes.Remove(node);
            if (cbo_phongban.Items.Count > 0)
            {
                cbo_phongban.SelectedIndex = 0;
            }
        }
    }

    private void Btn_ThemNV_Click(object? sender, EventArgs e)
    {
        string maSo = txt_maso.Text.Trim();
        string hoTen = txt_hoten.Text.Trim();
        string diaChi = txt_diachi.Text.Trim();
        string phongBan = cbo_phongban.Text.Trim();

        if (string.IsNullOrWhiteSpace(maSo) || string.IsNullOrWhiteSpace(hoTen) || string.IsNullOrWhiteSpace(phongBan))
        {
            MessageBox.Show("Vui lòng điền đầy đủ Mã số, Họ tên và chọn Phòng ban!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        int targetIndex = -1;
        for (int i = 0; i < trv_DS.Nodes.Count; i++)
        {
            if (string.Compare(trv_DS.Nodes[i].Text.Trim(), phongBan, true) == 0)
            {
                targetIndex = i;
                break;
            }
        }

        if (targetIndex >= 0)
        {
            TreeNode pbNode = trv_DS.Nodes[targetIndex];
            string hienThiNV = $"{hoTen} ({maSo})";
            TreeNode nvNode = pbNode.Nodes.Add(hienThiNV);
            if (!string.IsNullOrWhiteSpace(diaChi))
            {
                nvNode.Nodes.Add($"Địa chỉ: {diaChi}");
            }

            pbNode.Expand();
            trv_DS.SelectedNode = nvNode;

            txt_maso.Clear();
            txt_hoten.Clear();
            txt_diachi.Clear();
            txt_maso.Focus();
        }
        else
        {
            MessageBox.Show("Không tìm thấy phòng ban tương ứng trên cây!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void Btn_Thoat_Click(object? sender, EventArgs e) => this.Close();

    private void FrmTreeView_FormClosing(object? sender, FormClosingEventArgs e)
    {
        var result = MessageBox.Show("Bạn có muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (result == DialogResult.No)
        {
            e.Cancel = true;
        }
    }
}
