namespace Lab05Prj.Forms;

partial class FrmMain
{
    private System.ComponentModel.IContainer components = null!;
    private System.Windows.Forms.Label lblHeaderTitle;
    private System.Windows.Forms.GroupBox grpMau;
    private System.Windows.Forms.Button btnMau_ListBox;
    private System.Windows.Forms.Button btnMau_ComboBox;
    private System.Windows.Forms.Button btnMau_TreeView;
    private System.Windows.Forms.GroupBox grpTaiLop;
    private System.Windows.Forms.Button btnLop_UocSo;
    private System.Windows.Forms.Button btnLop_SinhVien;
    private System.Windows.Forms.GroupBox grpNangCao;
    private System.Windows.Forms.Button btnNC_XuLyChuoi;
    private System.Windows.Forms.GroupBox grpVeNha;
    private System.Windows.Forms.Button btnVN_TuDien;
    private System.Windows.Forms.Button btnVN_ListBox;
    private System.Windows.Forms.Button btnVN_DanhBa;
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
        lblHeaderTitle = new Label();
        grpMau = new GroupBox();
        btnMau_TreeView = new Button();
        btnMau_ComboBox = new Button();
        btnMau_ListBox = new Button();
        grpTaiLop = new GroupBox();
        btnLop_SinhVien = new Button();
        btnLop_UocSo = new Button();
        grpNangCao = new GroupBox();
        btnNC_XuLyChuoi = new Button();
        grpVeNha = new GroupBox();
        btnVN_DanhBa = new Button();
        btnVN_ListBox = new Button();
        btnVN_TuDien = new Button();
        btnThoat = new Button();
        grpMau.SuspendLayout();
        grpTaiLop.SuspendLayout();
        grpNangCao.SuspendLayout();
        grpVeNha.SuspendLayout();
        SuspendLayout();
        // 
        // lblHeaderTitle
        // 
        lblHeaderTitle.Font = new Font("Tahoma", 15F, FontStyle.Bold);
        lblHeaderTitle.ForeColor = Color.DarkBlue;
        lblHeaderTitle.Location = new Point(20, 15);
        lblHeaderTitle.Name = "lblHeaderTitle";
        lblHeaderTitle.Size = new Size(640, 35);
        lblHeaderTitle.TabIndex = 0;
        lblHeaderTitle.Text = "LAB 05 - LẬP TRÌNH WINDOWS FORMS NÂNG CAO";
        lblHeaderTitle.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // grpMau
        // 
        grpMau.Controls.Add(btnMau_TreeView);
        grpMau.Controls.Add(btnMau_ComboBox);
        grpMau.Controls.Add(btnMau_ListBox);
        grpMau.Font = new Font("Tahoma", 10F, FontStyle.Bold);
        grpMau.ForeColor = Color.DarkGreen;
        grpMau.Location = new Point(25, 60);
        grpMau.Name = "grpMau";
        grpMau.Size = new Size(305, 175);
        grpMau.TabIndex = 1;
        grpMau.TabStop = false;
        grpMau.Text = "1. BÀI TẬP MẪU";
        // 
        // btnMau_TreeView
        // 
        btnMau_TreeView.Font = new Font("Tahoma", 9.5F);
        btnMau_TreeView.ForeColor = Color.Black;
        btnMau_TreeView.Location = new Point(15, 120);
        btnMau_TreeView.Name = "btnMau_TreeView";
        btnMau_TreeView.Size = new Size(275, 38);
        btnMau_TreeView.TabIndex = 2;
        btnMau_TreeView.Text = "Bài 3: Sử dụng TreeView";
        btnMau_TreeView.UseVisualStyleBackColor = true;
        btnMau_TreeView.Click += BtnMau_TreeView_Click;
        // 
        // btnMau_ComboBox
        // 
        btnMau_ComboBox.Font = new Font("Tahoma", 9.5F);
        btnMau_ComboBox.ForeColor = Color.Black;
        btnMau_ComboBox.Location = new Point(15, 74);
        btnMau_ComboBox.Name = "btnMau_ComboBox";
        btnMau_ComboBox.Size = new Size(275, 38);
        btnMau_ComboBox.TabIndex = 1;
        btnMau_ComboBox.Text = "Bài 2: Sử dụng ComboBox";
        btnMau_ComboBox.UseVisualStyleBackColor = true;
        btnMau_ComboBox.Click += BtnMau_ComboBox_Click;
        // 
        // btnMau_ListBox
        // 
        btnMau_ListBox.Font = new Font("Tahoma", 9.5F);
        btnMau_ListBox.ForeColor = Color.Black;
        btnMau_ListBox.Location = new Point(15, 28);
        btnMau_ListBox.Name = "btnMau_ListBox";
        btnMau_ListBox.Size = new Size(275, 38);
        btnMau_ListBox.TabIndex = 0;
        btnMau_ListBox.Text = "Bài 1: Sử dụng ListBox";
        btnMau_ListBox.UseVisualStyleBackColor = true;
        btnMau_ListBox.Click += BtnMau_ListBox_Click;
        // 
        // grpTaiLop
        // 
        grpTaiLop.Controls.Add(btnLop_SinhVien);
        grpTaiLop.Controls.Add(btnLop_UocSo);
        grpTaiLop.Font = new Font("Tahoma", 10F, FontStyle.Bold);
        grpTaiLop.ForeColor = Color.DarkSlateGray;
        grpTaiLop.Location = new Point(350, 60);
        grpTaiLop.Name = "grpTaiLop";
        grpTaiLop.Size = new Size(305, 130);
        grpTaiLop.TabIndex = 2;
        grpTaiLop.TabStop = false;
        grpTaiLop.Text = "2. BÀI TẬP TẠI LỚP";
        // 
        // btnLop_SinhVien
        // 
        btnLop_SinhVien.Font = new Font("Tahoma", 9.5F);
        btnLop_SinhVien.ForeColor = Color.Black;
        btnLop_SinhVien.Location = new Point(15, 74);
        btnLop_SinhVien.Name = "btnLop_SinhVien";
        btnLop_SinhVien.Size = new Size(275, 38);
        btnLop_SinhVien.TabIndex = 1;
        btnLop_SinhVien.Text = "Bài 2: Quản lý sinh viên";
        btnLop_SinhVien.UseVisualStyleBackColor = true;
        btnLop_SinhVien.Click += BtnLop_SinhVien_Click;
        // 
        // btnLop_UocSo
        // 
        btnLop_UocSo.Font = new Font("Tahoma", 9.5F);
        btnLop_UocSo.ForeColor = Color.Black;
        btnLop_UocSo.Location = new Point(15, 28);
        btnLop_UocSo.Name = "btnLop_UocSo";
        btnLop_UocSo.Size = new Size(275, 38);
        btnLop_UocSo.TabIndex = 0;
        btnLop_UocSo.Text = "Bài 1: Tìm và tính ước số";
        btnLop_UocSo.UseVisualStyleBackColor = true;
        btnLop_UocSo.Click += BtnLop_UocSo_Click;
        // 
        // grpNangCao
        // 
        grpNangCao.Controls.Add(btnNC_XuLyChuoi);
        grpNangCao.Font = new Font("Tahoma", 10F, FontStyle.Bold);
        grpNangCao.ForeColor = Color.Purple;
        grpNangCao.Location = new Point(350, 200);
        grpNangCao.Name = "grpNangCao";
        grpNangCao.Size = new Size(305, 75);
        grpNangCao.TabIndex = 3;
        grpNangCao.TabStop = false;
        grpNangCao.Text = "3. BÀI TẬP NÂNG CAO";
        // 
        // btnNC_XuLyChuoi
        // 
        btnNC_XuLyChuoi.Font = new Font("Tahoma", 9.5F);
        btnNC_XuLyChuoi.ForeColor = Color.Black;
        btnNC_XuLyChuoi.Location = new Point(15, 26);
        btnNC_XuLyChuoi.Name = "btnNC_XuLyChuoi";
        btnNC_XuLyChuoi.Size = new Size(275, 38);
        btnNC_XuLyChuoi.TabIndex = 0;
        btnNC_XuLyChuoi.Text = "Bài 1: Xử lý chuỗi trên ListBox";
        btnNC_XuLyChuoi.UseVisualStyleBackColor = true;
        btnNC_XuLyChuoi.Click += BtnNC_XuLyChuoi_Click;
        // 
        // grpVeNha
        // 
        grpVeNha.Controls.Add(btnVN_DanhBa);
        grpVeNha.Controls.Add(btnVN_ListBox);
        grpVeNha.Controls.Add(btnVN_TuDien);
        grpVeNha.Font = new Font("Tahoma", 10F, FontStyle.Bold);
        grpVeNha.ForeColor = Color.Firebrick;
        grpVeNha.Location = new Point(25, 281);
        grpVeNha.Name = "grpVeNha";
        grpVeNha.Size = new Size(630, 132);
        grpVeNha.TabIndex = 4;
        grpVeNha.TabStop = false;
        grpVeNha.Text = "4. BÀI TẬP VỀ NHÀ";
        // 
        // btnVN_DanhBa
        // 
        btnVN_DanhBa.Font = new Font("Tahoma", 9.5F);
        btnVN_DanhBa.ForeColor = Color.Black;
        btnVN_DanhBa.Location = new Point(425, 30);
        btnVN_DanhBa.Name = "btnVN_DanhBa";
        btnVN_DanhBa.Size = new Size(185, 75);
        btnVN_DanhBa.TabIndex = 2;
        btnVN_DanhBa.Text = "Bài 3:\r\nDanh bạ phân nhóm\r\ntheo bảng chữ cái A-Z";
        btnVN_DanhBa.UseVisualStyleBackColor = true;
        btnVN_DanhBa.Click += BtnVN_DanhBa_Click;
        // 
        // btnVN_ListBox
        // 
        btnVN_ListBox.Font = new Font("Tahoma", 9.5F);
        btnVN_ListBox.ForeColor = Color.Black;
        btnVN_ListBox.Location = new Point(220, 30);
        btnVN_ListBox.Name = "btnVN_ListBox";
        btnVN_ListBox.Size = new Size(185, 75);
        btnVN_ListBox.TabIndex = 1;
        btnVN_ListBox.Text = "Bài 2:\r\nXử lý ListBox\r\nsố tự nhiên đa chọn";
        btnVN_ListBox.UseVisualStyleBackColor = true;
        btnVN_ListBox.Click += BtnVN_ListBox_Click;
        // 
        // btnVN_TuDien
        // 
        btnVN_TuDien.Font = new Font("Tahoma", 9.5F);
        btnVN_TuDien.ForeColor = Color.Black;
        btnVN_TuDien.Location = new Point(15, 30);
        btnVN_TuDien.Name = "btnVN_TuDien";
        btnVN_TuDien.Size = new Size(185, 75);
        btnVN_TuDien.TabIndex = 0;
        btnVN_TuDien.Text = "Bài 1:\r\nTừ điển Anh - Việt\r\nvà Việt - Anh";
        btnVN_TuDien.UseVisualStyleBackColor = true;
        btnVN_TuDien.Click += BtnVN_TuDien_Click;
        // 
        // btnThoat
        // 
        btnThoat.Font = new Font("Tahoma", 10F, FontStyle.Bold);
        btnThoat.ForeColor = Color.DarkRed;
        btnThoat.Location = new Point(20, 419);
        btnThoat.Name = "btnThoat";
        btnThoat.Size = new Size(630, 38);
        btnThoat.TabIndex = 5;
        btnThoat.Text = "Thoát chương trình";
        btnThoat.UseVisualStyleBackColor = true;
        btnThoat.Click += BtnThoat_Click;
        // 
        // FrmMain
        // 
        AutoScaleDimensions = new SizeF(9F, 21F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(680, 467);
        Controls.Add(btnThoat);
        Controls.Add(grpVeNha);
        Controls.Add(grpNangCao);
        Controls.Add(grpTaiLop);
        Controls.Add(grpMau);
        Controls.Add(lblHeaderTitle);
        Font = new Font("Tahoma", 10F);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        Name = "FrmMain";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Lab05 - WinForms Nâng Cao";
        grpMau.ResumeLayout(false);
        grpTaiLop.ResumeLayout(false);
        grpNangCao.ResumeLayout(false);
        grpVeNha.ResumeLayout(false);
        ResumeLayout(false);
    }
}
