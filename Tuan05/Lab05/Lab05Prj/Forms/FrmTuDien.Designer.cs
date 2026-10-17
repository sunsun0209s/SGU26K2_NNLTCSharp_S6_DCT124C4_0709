namespace Lab05Prj.Forms;

partial class FrmTuDien
{
    private System.ComponentModel.IContainer components = null!;
    private System.Windows.Forms.TabControl tabTuDien;
    private System.Windows.Forms.TabPage tabAnhViet;
    private System.Windows.Forms.Label lblAnh;
    private System.Windows.Forms.ComboBox cboAnh;
    private System.Windows.Forms.ListBox lstTuAnh;
    private System.Windows.Forms.Label lblVietNghia;
    private System.Windows.Forms.TextBox txtNghiaViet;
    private System.Windows.Forms.TabPage tabVietAnh;
    private System.Windows.Forms.Label lblViet;
    private System.Windows.Forms.ComboBox cboViet;
    private System.Windows.Forms.ListBox lstTuViet;
    private System.Windows.Forms.Label lblAnhNghia;
    private System.Windows.Forms.TextBox txtNghiaAnh;
    private System.Windows.Forms.Button btnThoat;

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
        this.tabTuDien = new System.Windows.Forms.TabControl();
        this.tabAnhViet = new System.Windows.Forms.TabPage();
        this.txtNghiaViet = new System.Windows.Forms.TextBox();
        this.lblVietNghia = new System.Windows.Forms.Label();
        this.lstTuAnh = new System.Windows.Forms.ListBox();
        this.cboAnh = new System.Windows.Forms.ComboBox();
        this.lblAnh = new System.Windows.Forms.Label();
        this.tabVietAnh = new System.Windows.Forms.TabPage();
        this.txtNghiaAnh = new System.Windows.Forms.TextBox();
        this.lblAnhNghia = new System.Windows.Forms.Label();
        this.lstTuViet = new System.Windows.Forms.ListBox();
        this.cboViet = new System.Windows.Forms.ComboBox();
        this.lblViet = new System.Windows.Forms.Label();
        this.btnThoat = new System.Windows.Forms.Button();
        this.tabTuDien.SuspendLayout();
        this.tabAnhViet.SuspendLayout();
        this.tabVietAnh.SuspendLayout();
        this.SuspendLayout();

        // tabTuDien
        this.tabTuDien.Controls.Add(this.tabAnhViet);
        this.tabTuDien.Controls.Add(this.tabVietAnh);
        this.tabTuDien.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
        this.tabTuDien.Location = new System.Drawing.Point(20, 20);
        this.tabTuDien.Name = "tabTuDien";
        this.tabTuDien.SelectedIndex = 0;
        this.tabTuDien.Size = new System.Drawing.Size(530, 310);
        this.tabTuDien.TabIndex = 0;

        // tabAnhViet
        this.tabAnhViet.Controls.Add(this.txtNghiaViet);
        this.tabAnhViet.Controls.Add(this.lblVietNghia);
        this.tabAnhViet.Controls.Add(this.lstTuAnh);
        this.tabAnhViet.Controls.Add(this.cboAnh);
        this.tabAnhViet.Controls.Add(this.lblAnh);
        this.tabAnhViet.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
        this.tabAnhViet.Location = new System.Drawing.Point(4, 25);
        this.tabAnhViet.Name = "tabAnhViet";
        this.tabAnhViet.Padding = new System.Windows.Forms.Padding(3);
        this.tabAnhViet.Size = new System.Drawing.Size(522, 281);
        this.tabAnhViet.TabIndex = 0;
        this.tabAnhViet.Text = "ANH - VIỆT";
        this.tabAnhViet.UseVisualStyleBackColor = true;

        // lblAnh
        this.lblAnh.AutoSize = true;
        this.lblAnh.Location = new System.Drawing.Point(25, 20);
        this.lblAnh.Name = "lblAnh";
        this.lblAnh.Size = new System.Drawing.Size(69, 17);
        this.lblAnh.TabIndex = 0;
        this.lblAnh.Text = "Tiếng Anh";

        // cboAnh
        this.cboAnh.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
        this.cboAnh.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
        this.cboAnh.FormattingEnabled = true;
        this.cboAnh.Location = new System.Drawing.Point(25, 45);
        this.cboAnh.Name = "cboAnh";
        this.cboAnh.Size = new System.Drawing.Size(180, 24);
        this.cboAnh.TabIndex = 1;
        this.cboAnh.SelectedIndexChanged += new System.EventHandler(this.CboAnh_SelectedIndexChanged);
        this.cboAnh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CboAnh_KeyDown);

        // lstTuAnh
        this.lstTuAnh.FormattingEnabled = true;
        this.lstTuAnh.ItemHeight = 16;
        this.lstTuAnh.Location = new System.Drawing.Point(25, 80);
        this.lstTuAnh.Name = "lstTuAnh";
        this.lstTuAnh.Size = new System.Drawing.Size(180, 180);
        this.lstTuAnh.TabIndex = 2;
        this.lstTuAnh.SelectedIndexChanged += new System.EventHandler(this.LstTuAnh_SelectedIndexChanged);
        this.lstTuAnh.DoubleClick += new System.EventHandler(this.LstTuAnh_DoubleClick);

        // lblVietNghia
        this.lblVietNghia.AutoSize = true;
        this.lblVietNghia.Location = new System.Drawing.Point(240, 20);
        this.lblVietNghia.Name = "lblVietNghia";
        this.lblVietNghia.Size = new System.Drawing.Size(69, 17);
        this.lblVietNghia.TabIndex = 3;
        this.lblVietNghia.Text = "Tiếng Việt";

        // txtNghiaViet
        this.txtNghiaViet.BackColor = System.Drawing.Color.White;
        this.txtNghiaViet.Location = new System.Drawing.Point(240, 45);
        this.txtNghiaViet.Multiline = true;
        this.txtNghiaViet.Name = "txtNghiaViet";
        this.txtNghiaViet.ReadOnly = true;
        this.txtNghiaViet.Size = new System.Drawing.Size(255, 215);
        this.txtNghiaViet.TabIndex = 4;

        // tabVietAnh
        this.tabVietAnh.Controls.Add(this.txtNghiaAnh);
        this.tabVietAnh.Controls.Add(this.lblAnhNghia);
        this.tabVietAnh.Controls.Add(this.lstTuViet);
        this.tabVietAnh.Controls.Add(this.cboViet);
        this.tabVietAnh.Controls.Add(this.lblViet);
        this.tabVietAnh.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
        this.tabVietAnh.Location = new System.Drawing.Point(4, 25);
        this.tabVietAnh.Name = "tabVietAnh";
        this.tabVietAnh.Padding = new System.Windows.Forms.Padding(3);
        this.tabVietAnh.Size = new System.Drawing.Size(522, 281);
        this.tabVietAnh.TabIndex = 1;
        this.tabVietAnh.Text = "VIỆT - ANH";
        this.tabVietAnh.UseVisualStyleBackColor = true;

        // lblViet
        this.lblViet.AutoSize = true;
        this.lblViet.Location = new System.Drawing.Point(25, 20);
        this.lblViet.Name = "lblViet";
        this.lblViet.Size = new System.Drawing.Size(69, 17);
        this.lblViet.TabIndex = 0;
        this.lblViet.Text = "Tiếng Việt";

        // cboViet
        this.cboViet.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
        this.cboViet.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
        this.cboViet.FormattingEnabled = true;
        this.cboViet.Location = new System.Drawing.Point(25, 45);
        this.cboViet.Name = "cboViet";
        this.cboViet.Size = new System.Drawing.Size(180, 24);
        this.cboViet.TabIndex = 1;
        this.cboViet.SelectedIndexChanged += new System.EventHandler(this.CboViet_SelectedIndexChanged);
        this.cboViet.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CboViet_KeyDown);

        // lstTuViet
        this.lstTuViet.FormattingEnabled = true;
        this.lstTuViet.ItemHeight = 16;
        this.lstTuViet.Location = new System.Drawing.Point(25, 80);
        this.lstTuViet.Name = "lstTuViet";
        this.lstTuViet.Size = new System.Drawing.Size(180, 180);
        this.lstTuViet.TabIndex = 2;
        this.lstTuViet.SelectedIndexChanged += new System.EventHandler(this.LstTuViet_SelectedIndexChanged);
        this.lstTuViet.DoubleClick += new System.EventHandler(this.LstTuViet_DoubleClick);

        // lblAnhNghia
        this.lblAnhNghia.AutoSize = true;
        this.lblAnhNghia.Location = new System.Drawing.Point(240, 20);
        this.lblAnhNghia.Name = "lblAnhNghia";
        this.lblAnhNghia.Size = new System.Drawing.Size(69, 17);
        this.lblAnhNghia.TabIndex = 3;
        this.lblAnhNghia.Text = "Tiếng Anh";

        // txtNghiaAnh
        this.txtNghiaAnh.BackColor = System.Drawing.Color.White;
        this.txtNghiaAnh.Location = new System.Drawing.Point(240, 45);
        this.txtNghiaAnh.Multiline = true;
        this.txtNghiaAnh.Name = "txtNghiaAnh";
        this.txtNghiaAnh.ReadOnly = true;
        this.txtNghiaAnh.Size = new System.Drawing.Size(255, 215);
        this.txtNghiaAnh.TabIndex = 4;

        // btnThoat
        this.btnThoat.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
        this.btnThoat.Location = new System.Drawing.Point(460, 340);
        this.btnThoat.Name = "btnThoat";
        this.btnThoat.Size = new System.Drawing.Size(90, 32);
        this.btnThoat.TabIndex = 1;
        this.btnThoat.Text = "Thoát";
        this.btnThoat.UseVisualStyleBackColor = true;
        this.btnThoat.Click += new System.EventHandler(this.BtnThoat_Click);

        // FrmTuDien
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(575, 385);
        this.Controls.Add(this.btnThoat);
        this.Controls.Add(this.tabTuDien);
        this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.Name = "FrmTuDien";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "TỪ ĐIỂN ANH VIỆT - VIỆT ANH";
        this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmTuDien_FormClosing);
        this.Load += new System.EventHandler(this.FrmTuDien_Load);
        this.tabTuDien.ResumeLayout(false);
        this.tabAnhViet.ResumeLayout(false);
        this.tabAnhViet.PerformLayout();
        this.tabVietAnh.ResumeLayout(false);
        this.tabVietAnh.PerformLayout();
        this.ResumeLayout(false);
    }
}
