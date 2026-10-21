namespace Lab05Prj.Forms;

partial class FrmQuanLyTaiKhoan
{
    private System.ComponentModel.IContainer components = null!;
    private System.Windows.Forms.Label lblHeader;
    private System.Windows.Forms.Label lblSoTaiKhoan;
    private System.Windows.Forms.TextBox txtSoTaiKhoan;
    private System.Windows.Forms.Label lblTenKhachHang;
    private System.Windows.Forms.TextBox txtTenKhachHang;
    private System.Windows.Forms.Label lblDiaChi;
    private System.Windows.Forms.TextBox txtDiaChi;
    private System.Windows.Forms.Label lblSoTien;
    private System.Windows.Forms.TextBox txtSoTien;
    private System.Windows.Forms.Button btnThem;
    private System.Windows.Forms.Button btnLuu;
    private System.Windows.Forms.Button btnXoa;
    private System.Windows.Forms.Button btnThoat;
    private System.Windows.Forms.ListView lsvTaiKhoan;
    private System.Windows.Forms.ColumnHeader colSTT;
    private System.Windows.Forms.ColumnHeader colSoTaiKhoan;
    private System.Windows.Forms.ColumnHeader colTenKhachHang;
    private System.Windows.Forms.ColumnHeader colDiaChi;
    private System.Windows.Forms.ColumnHeader colSoTien;
    private System.Windows.Forms.Label lblTongTien;
    private System.Windows.Forms.TextBox txtTongTien;

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
        lblHeader = new Label();
        lblSoTaiKhoan = new Label();
        txtSoTaiKhoan = new TextBox();
        lblTenKhachHang = new Label();
        txtTenKhachHang = new TextBox();
        lblDiaChi = new Label();
        txtDiaChi = new TextBox();
        lblSoTien = new Label();
        txtSoTien = new TextBox();
        btnThem = new Button();
        btnLuu = new Button();
        btnXoa = new Button();
        btnThoat = new Button();
        lsvTaiKhoan = new ListView();
        colSTT = new ColumnHeader();
        colSoTaiKhoan = new ColumnHeader();
        colTenKhachHang = new ColumnHeader();
        colDiaChi = new ColumnHeader();
        colSoTien = new ColumnHeader();
        lblTongTien = new Label();
        txtTongTien = new TextBox();
        SuspendLayout();
        // 
        // lblHeader
        // 
        lblHeader.Font = new Font("Times New Roman", 16F, FontStyle.Bold);
        lblHeader.ForeColor = Color.FromArgb(0, 51, 153);
        lblHeader.Location = new Point(20, 15);
        lblHeader.Name = "lblHeader";
        lblHeader.Size = new Size(580, 35);
        lblHeader.TabIndex = 0;
        lblHeader.Text = "QUẢN LÝ THÔNG TIN TÀI KHOẢN";
        lblHeader.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblSoTaiKhoan
        // 
        lblSoTaiKhoan.AutoSize = true;
        lblSoTaiKhoan.Location = new Point(45, 65);
        lblSoTaiKhoan.Name = "lblSoTaiKhoan";
        lblSoTaiKhoan.Size = new Size(86, 17);
        lblSoTaiKhoan.TabIndex = 1;
        lblSoTaiKhoan.Text = "Số tài khoản:";
        // 
        // txtSoTaiKhoan
        // 
        txtSoTaiKhoan.Location = new Point(195, 62);
        txtSoTaiKhoan.Name = "txtSoTaiKhoan";
        txtSoTaiKhoan.Size = new Size(380, 25);
        txtSoTaiKhoan.TabIndex = 2;
        // 
        // lblTenKhachHang
        // 
        lblTenKhachHang.AutoSize = true;
        lblTenKhachHang.Location = new Point(45, 103);
        lblTenKhachHang.Name = "lblTenKhachHang";
        lblTenKhachHang.Size = new Size(106, 17);
        lblTenKhachHang.TabIndex = 3;
        lblTenKhachHang.Text = "Tên khách hàng:";
        // 
        // txtTenKhachHang
        // 
        txtTenKhachHang.Location = new Point(195, 100);
        txtTenKhachHang.Name = "txtTenKhachHang";
        txtTenKhachHang.Size = new Size(380, 25);
        txtTenKhachHang.TabIndex = 4;
        // 
        // lblDiaChi
        // 
        lblDiaChi.AutoSize = true;
        lblDiaChi.Location = new Point(45, 141);
        lblDiaChi.Name = "lblDiaChi";
        lblDiaChi.Size = new Size(122, 17);
        lblDiaChi.TabIndex = 5;
        lblDiaChi.Text = "Địa chỉ khách hàng:";
        // 
        // txtDiaChi
        // 
        txtDiaChi.Location = new Point(195, 138);
        txtDiaChi.Name = "txtDiaChi";
        txtDiaChi.Size = new Size(380, 25);
        txtDiaChi.TabIndex = 6;
        // 
        // lblSoTien
        // 
        lblSoTien.AutoSize = true;
        lblSoTien.Location = new Point(45, 179);
        lblSoTien.Name = "lblSoTien";
        lblSoTien.Size = new Size(144, 17);
        lblSoTien.TabIndex = 7;
        lblSoTien.Text = "Số tiền trong tài khoản:";
        // 
        // txtSoTien
        // 
        txtSoTien.Location = new Point(195, 176);
        txtSoTien.Name = "txtSoTien";
        txtSoTien.Size = new Size(380, 25);
        txtSoTien.TabIndex = 8;
        // 
        // btnThem
        // 
        btnThem.Font = new Font("Times New Roman", 10.5F, FontStyle.Bold);
        btnThem.Location = new Point(205, 215);
        btnThem.Name = "btnThem";
        btnThem.Size = new Size(85, 30);
        btnThem.TabIndex = 9;
        btnThem.Text = "Thêm";
        btnThem.UseVisualStyleBackColor = true;
        btnThem.Click += BtnThem_Click;
        // 
        // btnLuu
        // 
        btnLuu.Enabled = false;
        btnLuu.Font = new Font("Times New Roman", 10.5F, FontStyle.Bold);
        btnLuu.Location = new Point(300, 215);
        btnLuu.Name = "btnLuu";
        btnLuu.Size = new Size(85, 30);
        btnLuu.TabIndex = 10;
        btnLuu.Text = "Lưu";
        btnLuu.UseVisualStyleBackColor = true;
        btnLuu.Click += BtnLuu_Click;
        // 
        // btnXoa
        // 
        btnXoa.Enabled = false;
        btnXoa.Font = new Font("Times New Roman", 10.5F, FontStyle.Bold);
        btnXoa.Location = new Point(395, 215);
        btnXoa.Name = "btnXoa";
        btnXoa.Size = new Size(85, 30);
        btnXoa.TabIndex = 11;
        btnXoa.Text = "Xóa";
        btnXoa.UseVisualStyleBackColor = true;
        btnXoa.Click += BtnXoa_Click;
        // 
        // btnThoat
        // 
        btnThoat.Font = new Font("Times New Roman", 10.5F, FontStyle.Bold);
        btnThoat.Location = new Point(490, 215);
        btnThoat.Name = "btnThoat";
        btnThoat.Size = new Size(85, 30);
        btnThoat.TabIndex = 12;
        btnThoat.Text = "Thoát";
        btnThoat.UseVisualStyleBackColor = true;
        btnThoat.Click += BtnThoat_Click;
        // 
        // lsvTaiKhoan
        // 
        lsvTaiKhoan.Columns.AddRange(new ColumnHeader[] { colSTT, colSoTaiKhoan, colTenKhachHang, colDiaChi, colSoTien });
        lsvTaiKhoan.FullRowSelect = true;
        lsvTaiKhoan.GridLines = true;
        lsvTaiKhoan.Location = new Point(30, 260);
        lsvTaiKhoan.MultiSelect = false;
        lsvTaiKhoan.Name = "lsvTaiKhoan";
        lsvTaiKhoan.Size = new Size(560, 180);
        lsvTaiKhoan.TabIndex = 13;
        lsvTaiKhoan.UseCompatibleStateImageBehavior = false;
        lsvTaiKhoan.View = View.Details;
        lsvTaiKhoan.SelectedIndexChanged += LsvTaiKhoan_SelectedIndexChanged;
        // 
        // colSTT
        // 
        colSTT.Text = "STT";
        colSTT.Width = 50;
        // 
        // colSoTaiKhoan
        // 
        colSoTaiKhoan.Text = "Số tài khoản";
        colSoTaiKhoan.Width = 120;
        // 
        // colTenKhachHang
        // 
        colTenKhachHang.Text = "Tên khách hàng";
        colTenKhachHang.Width = 150;
        // 
        // colDiaChi
        // 
        colDiaChi.Text = "Địa chỉ";
        colDiaChi.Width = 110;
        // 
        // colSoTien
        // 
        colSoTien.Text = "Số tiền";
        colSoTien.TextAlign = HorizontalAlignment.Right;
        colSoTien.Width = 120;
        // 
        // lblTongTien
        // 
        lblTongTien.AutoSize = true;
        lblTongTien.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
        lblTongTien.Location = new Point(300, 458);
        lblTongTien.Name = "lblTongTien";
        lblTongTien.Size = new Size(74, 17);
        lblTongTien.TabIndex = 14;
        lblTongTien.Text = "Tổng tiền:";
        // 
        // txtTongTien
        // 
        txtTongTien.BackColor = Color.White;
        txtTongTien.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
        txtTongTien.ForeColor = Color.DarkRed;
        txtTongTien.Location = new Point(380, 455);
        txtTongTien.Name = "txtTongTien";
        txtTongTien.ReadOnly = true;
        txtTongTien.Size = new Size(210, 25);
        txtTongTien.TabIndex = 15;
        txtTongTien.TextAlign = HorizontalAlignment.Right;
        // 
        // FrmQuanLyTaiKhoan
        // 
        AutoScaleDimensions = new SizeF(8F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(246, 248, 250);
        ClientSize = new Size(620, 500);
        Controls.Add(txtTongTien);
        Controls.Add(lblTongTien);
        Controls.Add(lsvTaiKhoan);
        Controls.Add(btnThoat);
        Controls.Add(btnXoa);
        Controls.Add(btnLuu);
        Controls.Add(btnThem);
        Controls.Add(txtSoTien);
        Controls.Add(lblSoTien);
        Controls.Add(txtDiaChi);
        Controls.Add(lblDiaChi);
        Controls.Add(txtTenKhachHang);
        Controls.Add(lblTenKhachHang);
        Controls.Add(txtSoTaiKhoan);
        Controls.Add(lblSoTaiKhoan);
        Controls.Add(lblHeader);
        Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Margin = new Padding(4);
        MaximizeBox = false;
        Name = "FrmQuanLyTaiKhoan";
        StartPosition = FormStartPosition.CenterParent;
        Text = "frmBaiTap2";
        Load += FrmQuanLyTaiKhoan_Load;
        ResumeLayout(false);
        PerformLayout();
    }
}
