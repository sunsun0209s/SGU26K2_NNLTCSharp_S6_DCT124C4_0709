namespace Lab05Prj.Forms;

partial class FrmQuanLySinhVien
{
    private System.ComponentModel.IContainer components = null!;
    private System.Windows.Forms.Label lblTieuDeTree;
    private System.Windows.Forms.TreeView trvLop;
    private System.Windows.Forms.Label lblChonLop;
    private System.Windows.Forms.ComboBox cboLop;
    private System.Windows.Forms.GroupBox grpThongTinSV;
    private System.Windows.Forms.Label lblMaSV;
    private System.Windows.Forms.TextBox txtMaSV;
    private System.Windows.Forms.Label lblHoTen;
    private System.Windows.Forms.TextBox txtHoTen;
    private System.Windows.Forms.Label lblDiaChi;
    private System.Windows.Forms.TextBox txtDiaChi;
    private System.Windows.Forms.Button btnCapNhat;
    private System.Windows.Forms.Button btnXoa;
    private System.Windows.Forms.CheckBox chkThemLop;
    private System.Windows.Forms.GroupBox grpThongTinLop;
    private System.Windows.Forms.Label lblTenLop;
    private System.Windows.Forms.TextBox txtTenLop;
    private System.Windows.Forms.Button btnThemLop;

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
        this.lblTieuDeTree = new System.Windows.Forms.Label();
        this.trvLop = new System.Windows.Forms.TreeView();
        this.lblChonLop = new System.Windows.Forms.Label();
        this.cboLop = new System.Windows.Forms.ComboBox();
        this.grpThongTinSV = new System.Windows.Forms.GroupBox();
        this.btnXoa = new System.Windows.Forms.Button();
        this.btnCapNhat = new System.Windows.Forms.Button();
        this.txtDiaChi = new System.Windows.Forms.TextBox();
        this.lblDiaChi = new System.Windows.Forms.Label();
        this.txtHoTen = new System.Windows.Forms.TextBox();
        this.lblHoTen = new System.Windows.Forms.Label();
        this.txtMaSV = new System.Windows.Forms.TextBox();
        this.lblMaSV = new System.Windows.Forms.Label();
        this.chkThemLop = new System.Windows.Forms.CheckBox();
        this.grpThongTinLop = new System.Windows.Forms.GroupBox();
        this.btnThemLop = new System.Windows.Forms.Button();
        this.txtTenLop = new System.Windows.Forms.TextBox();
        this.lblTenLop = new System.Windows.Forms.Label();
        this.grpThongTinSV.SuspendLayout();
        this.grpThongTinLop.SuspendLayout();
        this.SuspendLayout();

        // lblTieuDeTree
        this.lblTieuDeTree.AutoSize = true;
        this.lblTieuDeTree.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
        this.lblTieuDeTree.Location = new System.Drawing.Point(20, 15);
        this.lblTieuDeTree.Name = "lblTieuDeTree";
        this.lblTieuDeTree.Size = new System.Drawing.Size(97, 17);
        this.lblTieuDeTree.TabIndex = 0;
        this.lblTieuDeTree.Text = "Danh sách lớp";

        // trvLop
        this.trvLop.Font = new System.Drawing.Font("Tahoma", 10F);
        this.trvLop.Location = new System.Drawing.Point(20, 38);
        this.trvLop.Name = "trvLop";
        this.trvLop.Size = new System.Drawing.Size(230, 370);
        this.trvLop.TabIndex = 1;
        this.trvLop.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TrvLop_AfterSelect);

        // lblChonLop
        this.lblChonLop.AutoSize = true;
        this.lblChonLop.Font = new System.Drawing.Font("Tahoma", 10F);
        this.lblChonLop.Location = new System.Drawing.Point(270, 20);
        this.lblChonLop.Name = "lblChonLop";
        this.lblChonLop.Size = new System.Drawing.Size(63, 17);
        this.lblChonLop.TabIndex = 2;
        this.lblChonLop.Text = "Chọn Lớp";

        // cboLop
        this.cboLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cboLop.Font = new System.Drawing.Font("Tahoma", 10F);
        this.cboLop.FormattingEnabled = true;
        this.cboLop.Location = new System.Drawing.Point(345, 17);
        this.cboLop.Name = "cboLop";
        this.cboLop.Size = new System.Drawing.Size(260, 24);
        this.cboLop.TabIndex = 3;

        // grpThongTinSV
        this.grpThongTinSV.Controls.Add(this.btnXoa);
        this.grpThongTinSV.Controls.Add(this.btnCapNhat);
        this.grpThongTinSV.Controls.Add(this.txtDiaChi);
        this.grpThongTinSV.Controls.Add(this.lblDiaChi);
        this.grpThongTinSV.Controls.Add(this.txtHoTen);
        this.grpThongTinSV.Controls.Add(this.lblHoTen);
        this.grpThongTinSV.Controls.Add(this.txtMaSV);
        this.grpThongTinSV.Controls.Add(this.lblMaSV);
        this.grpThongTinSV.Font = new System.Drawing.Font("Tahoma", 10F);
        this.grpThongTinSV.Location = new System.Drawing.Point(270, 55);
        this.grpThongTinSV.Name = "grpThongTinSV";
        this.grpThongTinSV.Size = new System.Drawing.Size(350, 210);
        this.grpThongTinSV.TabIndex = 4;
        this.grpThongTinSV.TabStop = false;
        this.grpThongTinSV.Text = "Thông tin sinh viên";

        // lblMaSV
        this.lblMaSV.AutoSize = true;
        this.lblMaSV.Location = new System.Drawing.Point(15, 30);
        this.lblMaSV.Name = "lblMaSV";
        this.lblMaSV.Size = new System.Drawing.Size(51, 17);
        this.lblMaSV.TabIndex = 0;
        this.lblMaSV.Text = "Mã SV:";

        // txtMaSV
        this.txtMaSV.Location = new System.Drawing.Point(85, 27);
        this.txtMaSV.Name = "txtMaSV";
        this.txtMaSV.Size = new System.Drawing.Size(245, 24);
        this.txtMaSV.TabIndex = 1;

        // lblHoTen
        this.lblHoTen.AutoSize = true;
        this.lblHoTen.Location = new System.Drawing.Point(15, 70);
        this.lblHoTen.Name = "lblHoTen";
        this.lblHoTen.Size = new System.Drawing.Size(56, 17);
        this.lblHoTen.TabIndex = 2;
        this.lblHoTen.Text = "Họ Tên:";

        // txtHoTen
        this.txtHoTen.Location = new System.Drawing.Point(85, 67);
        this.txtHoTen.Name = "txtHoTen";
        this.txtHoTen.Size = new System.Drawing.Size(245, 24);
        this.txtHoTen.TabIndex = 3;

        // lblDiaChi
        this.lblDiaChi.AutoSize = true;
        this.lblDiaChi.Location = new System.Drawing.Point(15, 110);
        this.lblDiaChi.Name = "lblDiaChi";
        this.lblDiaChi.Size = new System.Drawing.Size(55, 17);
        this.lblDiaChi.TabIndex = 4;
        this.lblDiaChi.Text = "Địa Chỉ:";

        // txtDiaChi
        this.txtDiaChi.Location = new System.Drawing.Point(85, 107);
        this.txtDiaChi.Name = "txtDiaChi";
        this.txtDiaChi.Size = new System.Drawing.Size(245, 24);
        this.txtDiaChi.TabIndex = 5;

        // btnCapNhat
        this.btnCapNhat.Location = new System.Drawing.Point(85, 155);
        this.btnCapNhat.Name = "btnCapNhat";
        this.btnCapNhat.Size = new System.Drawing.Size(100, 32);
        this.btnCapNhat.TabIndex = 6;
        this.btnCapNhat.Text = "Cập Nhật";
        this.btnCapNhat.UseVisualStyleBackColor = true;
        this.btnCapNhat.Click += new System.EventHandler(this.BtnCapNhat_Click);

        // btnXoa
        this.btnXoa.Location = new System.Drawing.Point(210, 155);
        this.btnXoa.Name = "btnXoa";
        this.btnXoa.Size = new System.Drawing.Size(100, 32);
        this.btnXoa.TabIndex = 7;
        this.btnXoa.Text = "Xóa";
        this.btnXoa.UseVisualStyleBackColor = true;
        this.btnXoa.Click += new System.EventHandler(this.BtnXoa_Click);

        // chkThemLop
        this.chkThemLop.AutoSize = true;
        this.chkThemLop.Font = new System.Drawing.Font("Tahoma", 10F);
        this.chkThemLop.Location = new System.Drawing.Point(270, 280);
        this.chkThemLop.Name = "chkThemLop";
        this.chkThemLop.Size = new System.Drawing.Size(86, 21);
        this.chkThemLop.TabIndex = 5;
        this.chkThemLop.Text = "Thêm lớp";
        this.chkThemLop.UseVisualStyleBackColor = true;
        this.chkThemLop.CheckedChanged += new System.EventHandler(this.ChkThemLop_CheckedChanged);

        // grpThongTinLop
        this.grpThongTinLop.Controls.Add(this.btnThemLop);
        this.grpThongTinLop.Controls.Add(this.txtTenLop);
        this.grpThongTinLop.Controls.Add(this.lblTenLop);
        this.grpThongTinLop.Font = new System.Drawing.Font("Tahoma", 10F);
        this.grpThongTinLop.Location = new System.Drawing.Point(270, 310);
        this.grpThongTinLop.Name = "grpThongTinLop";
        this.grpThongTinLop.Size = new System.Drawing.Size(350, 98);
        this.grpThongTinLop.TabIndex = 6;
        this.grpThongTinLop.TabStop = false;
        this.grpThongTinLop.Text = "Thông tin lớp";
        this.grpThongTinLop.Visible = false;

        // lblTenLop
        this.lblTenLop.AutoSize = true;
        this.lblTenLop.Location = new System.Drawing.Point(15, 30);
        this.lblTenLop.Name = "lblTenLop";
        this.lblTenLop.Size = new System.Drawing.Size(61, 17);
        this.lblTenLop.TabIndex = 0;
        this.lblTenLop.Text = "Tên lớp:";

        // txtTenLop
        this.txtTenLop.Location = new System.Drawing.Point(85, 27);
        this.txtTenLop.Name = "txtTenLop";
        this.txtTenLop.Size = new System.Drawing.Size(150, 24);
        this.txtTenLop.TabIndex = 1;

        // btnThemLop
        this.btnThemLop.Location = new System.Drawing.Point(245, 25);
        this.btnThemLop.Name = "btnThemLop";
        this.btnThemLop.Size = new System.Drawing.Size(90, 28);
        this.btnThemLop.TabIndex = 2;
        this.btnThemLop.Text = "Thêm lớp";
        this.btnThemLop.UseVisualStyleBackColor = true;
        this.btnThemLop.Click += new System.EventHandler(this.BtnThemLop_Click);

        // FrmQuanLySinhVien
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(645, 430);
        this.Controls.Add(this.grpThongTinLop);
        this.Controls.Add(this.chkThemLop);
        this.Controls.Add(this.grpThongTinSV);
        this.Controls.Add(this.cboLop);
        this.Controls.Add(this.lblChonLop);
        this.Controls.Add(this.trvLop);
        this.Controls.Add(this.lblTieuDeTree);
        this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.Name = "FrmQuanLySinhVien";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Quản lý sinh viên";
        this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmQuanLySinhVien_FormClosing);
        this.Load += new System.EventHandler(this.FrmQuanLySinhVien_Load);
        this.grpThongTinSV.ResumeLayout(false);
        this.grpThongTinSV.PerformLayout();
        this.grpThongTinLop.ResumeLayout(false);
        this.grpThongTinLop.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();
    }
}
