namespace Lab04Prj.Forms;

partial class FrmDinhDangFont
{
    private System.ComponentModel.IContainer components = null!;
    private System.Windows.Forms.Label lblSample;
    private System.Windows.Forms.GroupBox grpFont;
    private System.Windows.Forms.CheckBox chkBold;
    private System.Windows.Forms.CheckBox chkItalic;
    private System.Windows.Forms.GroupBox grpColor;
    private System.Windows.Forms.RadioButton rdoAutoColor;
    private System.Windows.Forms.RadioButton rdoRed;
    private System.Windows.Forms.RadioButton rdoGreen;
    private System.Windows.Forms.RadioButton rdoBlue;
    private System.Windows.Forms.Button btnExit;

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
        this.lblSample = new System.Windows.Forms.Label();
        this.grpFont = new System.Windows.Forms.GroupBox();
        this.chkBold = new System.Windows.Forms.CheckBox();
        this.chkItalic = new System.Windows.Forms.CheckBox();
        this.grpColor = new System.Windows.Forms.GroupBox();
        this.rdoAutoColor = new System.Windows.Forms.RadioButton();
        this.rdoRed = new System.Windows.Forms.RadioButton();
        this.rdoGreen = new System.Windows.Forms.RadioButton();
        this.rdoBlue = new System.Windows.Forms.RadioButton();
        this.btnExit = new System.Windows.Forms.Button();
        this.grpFont.SuspendLayout();
        this.grpColor.SuspendLayout();
        this.SuspendLayout();

        // lblSample
        this.lblSample.BackColor = System.Drawing.Color.WhiteSmoke;
        this.lblSample.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblSample.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular);
        this.lblSample.ForeColor = System.Drawing.Color.Black;
        this.lblSample.Location = new System.Drawing.Point(20, 15);
        this.lblSample.Name = "lblSample";
        this.lblSample.Size = new System.Drawing.Size(405, 70);
        this.lblSample.TabIndex = 0;
        this.lblSample.Text = "Trường Đại Học Sài Gòn\nKhoa Công Nghệ Thông Tin";
        this.lblSample.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

        // grpFont
        this.grpFont.Controls.Add(this.chkItalic);
        this.grpFont.Controls.Add(this.chkBold);
        this.grpFont.Location = new System.Drawing.Point(20, 100);
        this.grpFont.Name = "grpFont";
        this.grpFont.Size = new System.Drawing.Size(190, 120);
        this.grpFont.TabIndex = 1;
        this.grpFont.TabStop = false;
        this.grpFont.Text = "Font Style";

        // chkBold
        this.chkBold.Location = new System.Drawing.Point(25, 30);
        this.chkBold.Name = "chkBold";
        this.chkBold.Size = new System.Drawing.Size(130, 30);
        this.chkBold.TabIndex = 0;
        this.chkBold.Text = "Bold";
        this.chkBold.UseVisualStyleBackColor = true;
        this.chkBold.CheckedChanged += new System.EventHandler(this.DinhDang_Changed);

        // chkItalic
        this.chkItalic.Location = new System.Drawing.Point(25, 70);
        this.chkItalic.Name = "chkItalic";
        this.chkItalic.Size = new System.Drawing.Size(130, 30);
        this.chkItalic.TabIndex = 1;
        this.chkItalic.Text = "Italic";
        this.chkItalic.UseVisualStyleBackColor = true;
        this.chkItalic.CheckedChanged += new System.EventHandler(this.DinhDang_Changed);

        // grpColor
        this.grpColor.Controls.Add(this.rdoBlue);
        this.grpColor.Controls.Add(this.rdoGreen);
        this.grpColor.Controls.Add(this.rdoRed);
        this.grpColor.Controls.Add(this.rdoAutoColor);
        this.grpColor.Location = new System.Drawing.Point(235, 100);
        this.grpColor.Name = "grpColor";
        this.grpColor.Size = new System.Drawing.Size(190, 120);
        this.grpColor.TabIndex = 2;
        this.grpColor.TabStop = false;
        this.grpColor.Text = "Color";

        // rdoAutoColor
        this.rdoAutoColor.Checked = true;
        this.rdoAutoColor.Location = new System.Drawing.Point(25, 20);
        this.rdoAutoColor.Name = "rdoAutoColor";
        this.rdoAutoColor.Size = new System.Drawing.Size(130, 22);
        this.rdoAutoColor.TabIndex = 0;
        this.rdoAutoColor.TabStop = true;
        this.rdoAutoColor.Text = "AutoColor";
        this.rdoAutoColor.UseVisualStyleBackColor = true;
        this.rdoAutoColor.CheckedChanged += new System.EventHandler(this.DinhDang_Changed);

        // rdoRed
        this.rdoRed.Location = new System.Drawing.Point(25, 45);
        this.rdoRed.Name = "rdoRed";
        this.rdoRed.Size = new System.Drawing.Size(130, 22);
        this.rdoRed.TabIndex = 1;
        this.rdoRed.Text = "Red";
        this.rdoRed.UseVisualStyleBackColor = true;
        this.rdoRed.CheckedChanged += new System.EventHandler(this.DinhDang_Changed);

        // rdoGreen
        this.rdoGreen.Location = new System.Drawing.Point(25, 70);
        this.rdoGreen.Name = "rdoGreen";
        this.rdoGreen.Size = new System.Drawing.Size(130, 22);
        this.rdoGreen.TabIndex = 2;
        this.rdoGreen.Text = "Green";
        this.rdoGreen.UseVisualStyleBackColor = true;
        this.rdoGreen.CheckedChanged += new System.EventHandler(this.DinhDang_Changed);

        // rdoBlue
        this.rdoBlue.Location = new System.Drawing.Point(25, 95);
        this.rdoBlue.Name = "rdoBlue";
        this.rdoBlue.Size = new System.Drawing.Size(130, 22);
        this.rdoBlue.TabIndex = 3;
        this.rdoBlue.Text = "Blue";
        this.rdoBlue.UseVisualStyleBackColor = true;
        this.rdoBlue.CheckedChanged += new System.EventHandler(this.DinhDang_Changed);

        // btnExit
        this.btnExit.Location = new System.Drawing.Point(175, 235);
        this.btnExit.Name = "btnExit";
        this.btnExit.Size = new System.Drawing.Size(100, 35);
        this.btnExit.TabIndex = 3;
        this.btnExit.Text = "Exit";
        this.btnExit.UseVisualStyleBackColor = true;
        this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);

        // FrmDinhDangFont
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(444, 281);
        this.Controls.Add(this.btnExit);
        this.Controls.Add(this.grpColor);
        this.Controls.Add(this.grpFont);
        this.Controls.Add(this.lblSample);
        this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.Name = "FrmDinhDangFont";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Định dạng Font và Color";
        this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmDinhDangFont_FormClosing);
        this.grpFont.ResumeLayout(false);
        this.grpColor.ResumeLayout(false);
        this.ResumeLayout(false);
    }
}
