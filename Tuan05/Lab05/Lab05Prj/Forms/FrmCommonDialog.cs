using System;
using System.IO;
using System.Windows.Forms;

namespace Lab05Prj.Forms;

public partial class FrmCommonDialog : Form
{
    public FrmCommonDialog()
    {
        InitializeComponent();
    }

    private void BtnLuuFile_Click(object? sender, EventArgs e)
    {
        saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
        saveFileDialog1.Title = "Chọn nơi lưu tệp tin văn bản";

        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
        {
            string filename = saveFileDialog1.FileName;
            txtFilePath.Text = filename;

            try
            {
                using StreamWriter sw = File.CreateText(filename);
                sw.Write(rtbContent.Text);
                MessageBox.Show("Lưu tệp tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu tệp tin: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    private void BtnMoFile_Click(object? sender, EventArgs e)
    {
        openFileDialog1.Filter = "Text files (*.txt)|*.txt|All Document (*.pdf)|*.pdf|All files (*.*)|*.*";
        openFileDialog1.Title = "Chọn tệp tin cần mở";

        if (openFileDialog1.ShowDialog() == DialogResult.OK)
        {
            string filename = openFileDialog1.FileName;
            txtFilePath.Text = filename;

            try
            {
                using StreamReader sr = new StreamReader(filename);
                rtbContent.Text = sr.ReadToEnd();
                MessageBox.Show("Mở và nạp nội dung tệp tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đọc tệp tin: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
