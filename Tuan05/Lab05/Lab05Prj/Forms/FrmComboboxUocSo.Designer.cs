namespace Lab05Prj.Forms;

partial class FrmComboboxUocSo
{
    private System.ComponentModel.IContainer components = null!;
    private System.Windows.Forms.Label lblNhapSo;
    private System.Windows.Forms.TextBox txtNhapSo;
    private System.Windows.Forms.Button btnCapNhat;
    private System.Windows.Forms.ComboBox cboSo;
    private System.Windows.Forms.Label lblDsUocSo;
    private System.Windows.Forms.ListBox lstUocSo;
    private System.Windows.Forms.Button btnTongUocSo;
    private System.Windows.Forms.Button btnSoLuongChan;
    private System.Windows.Forms.Button btnSoLuongNguyenTo;
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
        this.lblNhapSo = new System.Windows.Forms.Label();
        this.txtNhapSo = new System.Windows.Forms.TextBox();
        this.btnCapNhat = new System.Windows.Forms.Button();
        this.cboSo = new System.Windows.Forms.ComboBox();
        this.lblDsUocSo = new System.Windows.Forms.Label();
        this.lstUocSo = new System.Windows.Forms.ListBox();
        this.btnTongUocSo = new System.Windows.Forms.Button();
        this.btnSoLuongChan = new System.Windows.Forms.Button();
        this.btnSoLuongNguyenTo = new System.Windows.Forms.Button();
        this.btnThoat = new System.Windows.Forms.Button();
        this.SuspendLayout();

        // lblNhapSo
        this.lblNhapSo.AutoSize = true;
        this.lblNhapSo.Font = new System.Drawing.Font("Tahoma", 10F);
        this.lblNhapSo.Location = new System.Drawing.Point(40, 30);
        this.lblNhapSo.Name = "lblNhapSo";
        this.lblNhapSo.Size = new System.Drawing.Size(60, 17);
        this.lblNhapSo.TabIndex = 0;
        this.lblNhapSo.Text = "Nhập Số";

        // txtNhapSo
        this.txtNhapSo.Font = new System.Drawing.Font("Tahoma", 10F);
        this.txtNhapSo.Location = new System.Drawing.Point(40, 55);
        this.txtNhapSo.Name = "txtNhapSo";
        this.txtNhapSo.Size = new System.Drawing.Size(120, 24);
        this.txtNhapSo.TabIndex = 1;

        // btnCapNhat
        this.btnCapNhat.Font = new System.Drawing.Font("Tahoma", 10F);
        this.btnCapNhat.Location = new System.Drawing.Point(175, 52);
        this.btnCapNhat.Name = "btnCapNhat";
        this.btnCapNhat.Size = new System.Drawing.Size(85, 30);
        this.btnCapNhat.TabIndex = 2;
        this.btnCapNhat.Text = "&Cập nhật";
        this.btnCapNhat.UseVisualStyleBackColor = true;
        this.btnCapNhat.Click += new System.EventHandler(this.BtnCapNhat_Click);

        // cboSo
        this.cboSo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cboSo.Font = new System.Drawing.Font("Tahoma", 10F);
        this.cboSo.FormattingEnabled = true;
        this.cboSo.Location = new System.Drawing.Point(40, 100);
        this.cboSo.Name = "cboSo";
        this.cboSo.Size = new System.Drawing.Size(220, 24);
        this.cboSo.TabIndex = 3;
        this.cboSo.SelectedIndexChanged += new System.EventHandler(this.CboSo_SelectedIndexChanged);

        // lblDsUocSo
        this.lblDsUocSo.AutoSize = true;
        this.lblDsUocSo.Font = new System.Drawing.Font("Tahoma", 10F);
        this.lblDsUocSo.Location = new System.Drawing.Point(295, 30);
        this.lblDsUocSo.Name = "lblDsUocSo";
        this.lblDsUocSo.Size = new System.Drawing.Size(139, 17);
        this.lblDsUocSo.TabIndex = 4;
        this.lblDsUocSo.Text = "Danh sách các ước số";

        // lstUocSo
        this.lstUocSo.Font = new System.Drawing.Font("Tahoma", 10F);
        this.lstUocSo.FormattingEnabled = true;
        this.lstUocSo.ItemHeight = 16;
        this.lstUocSo.Location = new System.Drawing.Point(295, 55);
        this.lstUocSo.Name = "lstUocSo";
        this.lstUocSo.Size = new System.Drawing.Size(200, 100);
        this.lstUocSo.TabIndex = 5;

        // btnTongUocSo
        this.btnTongUocSo.Font = new System.Drawing.Font("Tahoma", 10F);
        this.btnTongUocSo.Location = new System.Drawing.Point(295, 170);
        this.btnTongUocSo.Name = "btnTongUocSo";
        this.btnTongUocSo.Size = new System.Drawing.Size(200, 32);
        this.btnTongUocSo.TabIndex = 6;
        this.btnTongUocSo.Text = "&Tổng các ước số";
        this.btnTongUocSo.UseVisualStyleBackColor = true;
        this.btnTongUocSo.Click += new System.EventHandler(this.BtnTongUocSo_Click);

        // btnSoLuongChan
        this.btnSoLuongChan.Font = new System.Drawing.Font("Tahoma", 10F);
        this.btnSoLuongChan.Location = new System.Drawing.Point(295, 210);
        this.btnSoLuongChan.Name = "btnSoLuongChan";
        this.btnSoLuongChan.Size = new System.Drawing.Size(200, 32);
        this.btnSoLuongChan.TabIndex = 7;
        this.btnSoLuongChan.Text = "Số &lượng các ước số chẵn";
        this.btnSoLuongChan.UseVisualStyleBackColor = true;
        this.btnSoLuongChan.Click += new System.EventHandler(this.BtnSoLuongChan_Click);

        // btnSoLuongNguyenTo
        this.btnSoLuongNguyenTo.Font = new System.Drawing.Font("Tahoma", 10F);
        this.btnSoLuongNguyenTo.Location = new System.Drawing.Point(295, 250);
        this.btnSoLuongNguyenTo.Name = "btnSoLuongNguyenTo";
        this.btnSoLuongNguyenTo.Size = new System.Drawing.Size(200, 32);
        this.btnSoLuongNguyenTo.TabIndex = 8;
        this.btnSoLuongNguyenTo.Text = "Số lượng các ước số &nguyên tố";
        this.btnSoLuongNguyenTo.UseVisualStyleBackColor = true;
        this.btnSoLuongNguyenTo.Click += new System.EventHandler(this.BtnSoLuongNguyenTo_Click);

        // btnThoat
        this.btnThoat.Font = new System.Drawing.Font("Tahoma", 10F);
        this.btnThoat.Location = new System.Drawing.Point(175, 250);
        this.btnThoat.Name = "btnThoat";
        this.btnThoat.Size = new System.Drawing.Size(85, 32);
        this.btnThoat.TabIndex = 9;
        this.btnThoat.Text = "T&hoát";
        this.btnThoat.UseVisualStyleBackColor = true;
        this.btnThoat.Click += new System.EventHandler(this.BtnThoat_Click);

        // FrmComboboxUocSo
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(535, 305);
        this.Controls.Add(this.btnThoat);
        this.Controls.Add(this.btnSoLuongNguyenTo);
        this.Controls.Add(this.btnSoLuongChan);
        this.Controls.Add(this.btnTongUocSo);
        this.Controls.Add(this.lstUocSo);
        this.Controls.Add(this.lblDsUocSo);
        this.Controls.Add(this.cboSo);
        this.Controls.Add(this.btnCapNhat);
        this.Controls.Add(this.txtNhapSo);
        this.Controls.Add(this.lblNhapSo);
        this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.Name = "FrmComboboxUocSo";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Combobox";
        this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmComboboxUocSo_FormClosing);
        this.ResumeLayout(false);
        this.PerformLayout();
    }
}
