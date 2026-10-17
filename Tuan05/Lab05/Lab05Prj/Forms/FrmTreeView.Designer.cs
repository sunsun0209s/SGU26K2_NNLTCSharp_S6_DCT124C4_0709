namespace Lab05Prj.Forms;

partial class FrmTreeView
{
    private System.ComponentModel.IContainer components = null!;
    private System.Windows.Forms.Label lblHeaderPB;
    private System.Windows.Forms.TreeView trv_DS;
    private System.Windows.Forms.Label lblInputPB;
    private System.Windows.Forms.TextBox txt_phongban;
    private System.Windows.Forms.Button btn_ThemPB;
    private System.Windows.Forms.Button btn_XoaPB;
    private System.Windows.Forms.GroupBox grpHoSo;
    private System.Windows.Forms.Label lblTitleHS;
    private System.Windows.Forms.Label lblMaSo;
    private System.Windows.Forms.TextBox txt_maso;
    private System.Windows.Forms.Label lblHoTen;
    private System.Windows.Forms.TextBox txt_hoten;
    private System.Windows.Forms.Label lblDiaChi;
    private System.Windows.Forms.TextBox txt_diachi;
    private System.Windows.Forms.Label lblPhongBan;
    private System.Windows.Forms.ComboBox cbo_phongban;
    private System.Windows.Forms.Button btn_ThemNV;
    private System.Windows.Forms.Button btn_Thoat;

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
        this.lblHeaderPB = new System.Windows.Forms.Label();
        this.trv_DS = new System.Windows.Forms.TreeView();
        this.lblInputPB = new System.Windows.Forms.Label();
        this.txt_phongban = new System.Windows.Forms.TextBox();
        this.btn_ThemPB = new System.Windows.Forms.Button();
        this.btn_XoaPB = new System.Windows.Forms.Button();
        this.grpHoSo = new System.Windows.Forms.GroupBox();
        this.lblTitleHS = new System.Windows.Forms.Label();
        this.lblMaSo = new System.Windows.Forms.Label();
        this.txt_maso = new System.Windows.Forms.TextBox();
        this.lblHoTen = new System.Windows.Forms.Label();
        this.txt_hoten = new System.Windows.Forms.TextBox();
        this.lblDiaChi = new System.Windows.Forms.Label();
        this.txt_diachi = new System.Windows.Forms.TextBox();
        this.lblPhongBan = new System.Windows.Forms.Label();
        this.cbo_phongban = new System.Windows.Forms.ComboBox();
        this.btn_ThemNV = new System.Windows.Forms.Button();
        this.btn_Thoat = new System.Windows.Forms.Button();
        this.grpHoSo.SuspendLayout();
        this.SuspendLayout();

        // lblHeaderPB
        this.lblHeaderPB.AutoSize = true;
        this.lblHeaderPB.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
        this.lblHeaderPB.Location = new System.Drawing.Point(20, 15);
        this.lblHeaderPB.Name = "lblHeaderPB";
        this.lblHeaderPB.Size = new System.Drawing.Size(76, 17);
        this.lblHeaderPB.TabIndex = 0;
        this.lblHeaderPB.Text = "Phòng ban";

        // trv_DS
        this.trv_DS.Font = new System.Drawing.Font("Times New Roman", 11F);
        this.trv_DS.Location = new System.Drawing.Point(20, 38);
        this.trv_DS.Name = "trv_DS";
        this.trv_DS.Size = new System.Drawing.Size(220, 240);
        this.trv_DS.TabIndex = 1;

        // lblInputPB
        this.lblInputPB.AutoSize = true;
        this.lblInputPB.Font = new System.Drawing.Font("Times New Roman", 10F);
        this.lblInputPB.Location = new System.Drawing.Point(20, 290);
        this.lblInputPB.Name = "lblInputPB";
        this.lblInputPB.Size = new System.Drawing.Size(68, 16);
        this.lblInputPB.TabIndex = 2;
        this.lblInputPB.Text = "Phòng ban";

        // txt_phongban
        this.txt_phongban.Font = new System.Drawing.Font("Times New Roman", 10F);
        this.txt_phongban.Location = new System.Drawing.Point(95, 287);
        this.txt_phongban.Name = "txt_phongban";
        this.txt_phongban.Size = new System.Drawing.Size(145, 23);
        this.txt_phongban.TabIndex = 3;

        // btn_ThemPB
        this.btn_ThemPB.Font = new System.Drawing.Font("Times New Roman", 10F);
        this.btn_ThemPB.Location = new System.Drawing.Point(95, 318);
        this.btn_ThemPB.Name = "btn_ThemPB";
        this.btn_ThemPB.Size = new System.Drawing.Size(145, 28);
        this.btn_ThemPB.TabIndex = 4;
        this.btn_ThemPB.Text = "Thêm phòng ban";
        this.btn_ThemPB.UseVisualStyleBackColor = true;
        this.btn_ThemPB.Click += new System.EventHandler(this.Btn_ThemPB_Click);

        // btn_XoaPB
        this.btn_XoaPB.Font = new System.Drawing.Font("Times New Roman", 10F);
        this.btn_XoaPB.Location = new System.Drawing.Point(95, 352);
        this.btn_XoaPB.Name = "btn_XoaPB";
        this.btn_XoaPB.Size = new System.Drawing.Size(145, 28);
        this.btn_XoaPB.TabIndex = 5;
        this.btn_XoaPB.Text = "Xóa phòng ban";
        this.btn_XoaPB.UseVisualStyleBackColor = true;
        this.btn_XoaPB.Click += new System.EventHandler(this.Btn_XoaPB_Click);

        // grpHoSo
        this.grpHoSo.Controls.Add(this.btn_Thoat);
        this.grpHoSo.Controls.Add(this.btn_ThemNV);
        this.grpHoSo.Controls.Add(this.cbo_phongban);
        this.grpHoSo.Controls.Add(this.lblPhongBan);
        this.grpHoSo.Controls.Add(this.txt_diachi);
        this.grpHoSo.Controls.Add(this.lblDiaChi);
        this.grpHoSo.Controls.Add(this.txt_hoten);
        this.grpHoSo.Controls.Add(this.lblHoTen);
        this.grpHoSo.Controls.Add(this.txt_maso);
        this.grpHoSo.Controls.Add(this.lblMaSo);
        this.grpHoSo.Controls.Add(this.lblTitleHS);
        this.grpHoSo.Location = new System.Drawing.Point(260, 20);
        this.grpHoSo.Name = "grpHoSo";
        this.grpHoSo.Size = new System.Drawing.Size(430, 360);
        this.grpHoSo.TabIndex = 6;
        this.grpHoSo.TabStop = false;

        // lblTitleHS
        this.lblTitleHS.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
        this.lblTitleHS.ForeColor = System.Drawing.Color.Blue;
        this.lblTitleHS.Location = new System.Drawing.Point(10, 15);
        this.lblTitleHS.Name = "lblTitleHS";
        this.lblTitleHS.Size = new System.Drawing.Size(410, 30);
        this.lblTitleHS.TabIndex = 0;
        this.lblTitleHS.Text = "HỒ SƠ NHÂN VIÊN";
        this.lblTitleHS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

        // lblMaSo
        this.lblMaSo.AutoSize = true;
        this.lblMaSo.Font = new System.Drawing.Font("Times New Roman", 10F);
        this.lblMaSo.Location = new System.Drawing.Point(20, 60);
        this.lblMaSo.Name = "lblMaSo";
        this.lblMaSo.Size = new System.Drawing.Size(44, 16);
        this.lblMaSo.TabIndex = 1;
        this.lblMaSo.Text = "Mã số";

        // txt_maso
        this.txt_maso.Font = new System.Drawing.Font("Times New Roman", 10F);
        this.txt_maso.Location = new System.Drawing.Point(90, 57);
        this.txt_maso.Name = "txt_maso";
        this.txt_maso.Size = new System.Drawing.Size(100, 23);
        this.txt_maso.TabIndex = 2;

        // lblHoTen
        this.lblHoTen.AutoSize = true;
        this.lblHoTen.Font = new System.Drawing.Font("Times New Roman", 10F);
        this.lblHoTen.Location = new System.Drawing.Point(200, 60);
        this.lblHoTen.Name = "lblHoTen";
        this.lblHoTen.Size = new System.Drawing.Size(48, 16);
        this.lblHoTen.TabIndex = 3;
        this.lblHoTen.Text = "Họ tên";

        // txt_hoten
        this.txt_hoten.Font = new System.Drawing.Font("Times New Roman", 10F);
        this.txt_hoten.Location = new System.Drawing.Point(255, 57);
        this.txt_hoten.Name = "txt_hoten";
        this.txt_hoten.Size = new System.Drawing.Size(155, 23);
        this.txt_hoten.TabIndex = 4;

        // lblDiaChi
        this.lblDiaChi.AutoSize = true;
        this.lblDiaChi.Font = new System.Drawing.Font("Times New Roman", 10F);
        this.lblDiaChi.Location = new System.Drawing.Point(20, 100);
        this.lblDiaChi.Name = "lblDiaChi";
        this.lblDiaChi.Size = new System.Drawing.Size(48, 16);
        this.lblDiaChi.TabIndex = 5;
        this.lblDiaChi.Text = "Địa chỉ";

        // txt_diachi
        this.txt_diachi.Font = new System.Drawing.Font("Times New Roman", 10F);
        this.txt_diachi.Location = new System.Drawing.Point(90, 97);
        this.txt_diachi.Name = "txt_diachi";
        this.txt_diachi.Size = new System.Drawing.Size(320, 23);
        this.txt_diachi.TabIndex = 6;

        // lblPhongBan
        this.lblPhongBan.AutoSize = true;
        this.lblPhongBan.Font = new System.Drawing.Font("Times New Roman", 10F);
        this.lblPhongBan.Location = new System.Drawing.Point(20, 140);
        this.lblPhongBan.Name = "lblPhongBan";
        this.lblPhongBan.Size = new System.Drawing.Size(68, 16);
        this.lblPhongBan.TabIndex = 7;
        this.lblPhongBan.Text = "Phòng ban";

        // cbo_phongban
        this.cbo_phongban.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cbo_phongban.Font = new System.Drawing.Font("Times New Roman", 10F);
        this.cbo_phongban.FormattingEnabled = true;
        this.cbo_phongban.Location = new System.Drawing.Point(90, 137);
        this.cbo_phongban.Name = "cbo_phongban";
        this.cbo_phongban.Size = new System.Drawing.Size(320, 23);
        this.cbo_phongban.TabIndex = 8;

        // btn_ThemNV
        this.btn_ThemNV.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
        this.btn_ThemNV.Location = new System.Drawing.Point(140, 180);
        this.btn_ThemNV.Name = "btn_ThemNV";
        this.btn_ThemNV.Size = new System.Drawing.Size(85, 32);
        this.btn_ThemNV.TabIndex = 9;
        this.btn_ThemNV.Text = "Thêm";
        this.btn_ThemNV.UseVisualStyleBackColor = true;
        this.btn_ThemNV.Click += new System.EventHandler(this.Btn_ThemNV_Click);

        // btn_Thoat
        this.btn_Thoat.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
        this.btn_Thoat.Location = new System.Drawing.Point(245, 180);
        this.btn_Thoat.Name = "btn_Thoat";
        this.btn_Thoat.Size = new System.Drawing.Size(85, 32);
        this.btn_Thoat.TabIndex = 10;
        this.btn_Thoat.Text = "Thoát";
        this.btn_Thoat.UseVisualStyleBackColor = true;
        this.btn_Thoat.Click += new System.EventHandler(this.Btn_Thoat_Click);

        // FrmTreeView
        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(710, 400);
        this.Controls.Add(this.grpHoSo);
        this.Controls.Add(this.btn_XoaPB);
        this.Controls.Add(this.btn_ThemPB);
        this.Controls.Add(this.txt_phongban);
        this.Controls.Add(this.lblInputPB);
        this.Controls.Add(this.trv_DS);
        this.Controls.Add(this.lblHeaderPB);
        this.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.Name = "FrmTreeView";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Phòng ban –Nhân viên";
        this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmTreeView_FormClosing);
        this.Load += new System.EventHandler(this.FrmTreeView_Load);
        this.grpHoSo.ResumeLayout(false);
        this.grpHoSo.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();
    }
}
