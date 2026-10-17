using System;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace Lab05Prj.Forms;

public partial class FrmDanhBa : Form
{
    public FrmDanhBa()
    {
        InitializeComponent();
    }

    private void FrmDanhBa_Load(object? sender, EventArgs e)
    {
        trvDanhBa.Nodes.Clear();
        for (char c = 'A'; c <= 'Z'; c++)
        {
            trvDanhBa.Nodes.Add(c.ToString());
        }
    }

    private static char LayChuCaiGoc(string input)
    {
        if (string.IsNullOrWhiteSpace(input)) return 'A';

        char first = input.Trim()[0];
        if (first == 'Đ' || first == 'đ') return 'D';

        string normalized = input.Normalize(NormalizationForm.FormD);
        foreach (char ch in normalized)
        {
            var category = CharUnicodeInfo.GetUnicodeCategory(ch);
            if (category != UnicodeCategory.NonSpacingMark)
            {
                char upper = char.ToUpperInvariant(ch);
                if (upper >= 'A' && upper <= 'Z') return upper;
            }
        }

        char rawUpper = char.ToUpperInvariant(first);
        return (rawUpper >= 'A' && rawUpper <= 'Z') ? rawUpper : 'A';
    }

    private void ThemDanhBa(string firstName, string lastName)
    {
        char chuCai = LayChuCaiGoc(firstName);
        string nodeKey = chuCai.ToString();

        TreeNode? targetNode = null;
        foreach (TreeNode node in trvDanhBa.Nodes)
        {
            if (node.Text == nodeKey)
            {
                targetNode = node;
                break;
            }
        }

        if (targetNode != null)
        {
            string hoTen = $"{firstName}, {lastName}";
            TreeNode childNode = targetNode.Nodes.Add(hoTen);
            targetNode.Expand();
            trvDanhBa.SelectedNode = childNode;
        }
    }

    private void BtnAdd_Click(object? sender, EventArgs e)
    {
        string firstName = txtFirstName.Text.Trim();
        string lastName = txtLastName.Text.Trim();

        if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
        {
            MessageBox.Show("Vui lòng nhập đầy đủ First Name và Last Name!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        ThemDanhBa(firstName, lastName);

        txtFirstName.Clear();
        txtLastName.Clear();
        txtFirstName.Focus();
    }

    private void BtnExit_Click(object? sender, EventArgs e) => this.Close();

    private void FrmDanhBa_FormClosing(object? sender, FormClosingEventArgs e)
    {
        var result = MessageBox.Show("Bạn có muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (result == DialogResult.No)
        {
            e.Cancel = true;
        }
    }
}
