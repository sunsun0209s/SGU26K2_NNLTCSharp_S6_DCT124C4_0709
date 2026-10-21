namespace Lab05Prj.Forms;

partial class FrmCommonDialog
{
    private System.ComponentModel.IContainer components = null!;
    private System.Windows.Forms.Label lblDuongDan;
    private System.Windows.Forms.TextBox txtFilePath;
    private System.Windows.Forms.Label lblNoiDung;
    private System.Windows.Forms.RichTextBox rtbContent;
    private System.Windows.Forms.Button btnLuuFile;
    private System.Windows.Forms.Button btnMoFile;
    private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    private System.Windows.Forms.OpenFileDialog openFileDialog1;

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
        lblDuongDan = new Label();
        txtFilePath = new TextBox();
        lblNoiDung = new Label();
        rtbContent = new RichTextBox();
        btnLuuFile = new Button();
        btnMoFile = new Button();
        saveFileDialog1 = new SaveFileDialog();
        openFileDialog1 = new OpenFileDialog();
        SuspendLayout();
        // 
        // lblDuongDan
        // 
        lblDuongDan.AutoSize = true;
        lblDuongDan.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
        lblDuongDan.Location = new Point(30, 20);
        lblDuongDan.Name = "lblDuongDan";
        lblDuongDan.Size = new Size(111, 17);
        lblDuongDan.TabIndex = 0;
        lblDuongDan.Text = "Đường dẫn tệp:";
        // 
        // txtFilePath
        // 
        txtFilePath.BackColor = Color.White;
        txtFilePath.Font = new Font("Times New Roman", 11.25F);
        txtFilePath.Location = new Point(30, 42);
        txtFilePath.Name = "txtFilePath";
        txtFilePath.ReadOnly = true;
        txtFilePath.Size = new Size(460, 25);
        txtFilePath.TabIndex = 1;
        // 
        // lblNoiDung
        // 
        lblNoiDung.AutoSize = true;
        lblNoiDung.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
        lblNoiDung.Location = new Point(30, 80);
        lblNoiDung.Name = "lblNoiDung";
        lblNoiDung.Size = new Size(110, 17);
        lblNoiDung.TabIndex = 2;
        lblNoiDung.Text = "Nhập đoạn text:";
        // 
        // rtbContent
        // 
        rtbContent.BorderStyle = BorderStyle.FixedSingle;
        rtbContent.Font = new Font("Times New Roman", 12F);
        rtbContent.Location = new Point(30, 105);
        rtbContent.Name = "rtbContent";
        rtbContent.Size = new Size(460, 230);
        rtbContent.TabIndex = 3;
        rtbContent.Text = "";
        // 
        // btnLuuFile
        // 
        btnLuuFile.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
        btnLuuFile.Location = new Point(240, 350);
        btnLuuFile.Name = "btnLuuFile";
        btnLuuFile.Size = new Size(120, 34);
        btnLuuFile.TabIndex = 4;
        btnLuuFile.Text = "Lưu file";
        btnLuuFile.UseVisualStyleBackColor = true;
        btnLuuFile.Click += BtnLuuFile_Click;
        // 
        // btnMoFile
        // 
        btnMoFile.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
        btnMoFile.Location = new Point(370, 350);
        btnMoFile.Name = "btnMoFile";
        btnMoFile.Size = new Size(120, 34);
        btnMoFile.TabIndex = 5;
        btnMoFile.Text = "Mở file";
        btnMoFile.UseVisualStyleBackColor = true;
        btnMoFile.Click += BtnMoFile_Click;
        // 
        // FrmCommonDialog
        // 
        AutoScaleDimensions = new SizeF(8F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(246, 248, 250);
        ClientSize = new Size(520, 400);
        Controls.Add(btnMoFile);
        Controls.Add(btnLuuFile);
        Controls.Add(rtbContent);
        Controls.Add(lblNoiDung);
        Controls.Add(txtFilePath);
        Controls.Add(lblDuongDan);
        Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(4);
        MaximizeBox = false;
        Name = "FrmCommonDialog";
        StartPosition = FormStartPosition.CenterParent;
        Text = "Save / Open File Dialog";
        ResumeLayout(false);
        PerformLayout();
    }
}
