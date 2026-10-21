namespace Lab05Prj.Forms;

partial class FrmMain
{
    private System.ComponentModel.IContainer components = null!;
    private System.Windows.Forms.MenuStrip menuStripMain;
    private System.Windows.Forms.ToolStripMenuItem mnuHeThong;
    private System.Windows.Forms.ToolStripMenuItem mnuThoat;
    private System.Windows.Forms.ToolStripMenuItem mnuTuan05c;
    private System.Windows.Forms.ToolStripMenuItem mnu5c_Mau1;
    private System.Windows.Forms.ToolStripMenuItem mnu5c_Mau2;
    private System.Windows.Forms.ToolStripMenuItem mnu5c_Mau3;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripMenuItem mnu5c_Lop1;
    private System.Windows.Forms.ToolStripMenuItem mnu5c_Lop2;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripMenuItem mnu5c_NC1;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    private System.Windows.Forms.ToolStripMenuItem mnu5c_VN1;
    private System.Windows.Forms.ToolStripMenuItem mnu5c_VN2;
    private System.Windows.Forms.ToolStripMenuItem mnu5c_VN3;
    private System.Windows.Forms.ToolStripMenuItem mnuTuan05d;
    private System.Windows.Forms.ToolStripMenuItem mnu5d_Mau1;
    private System.Windows.Forms.ToolStripMenuItem mnu5d_Mau2;
    private System.Windows.Forms.ToolStripMenuItem mnu5d_Mau3;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    private System.Windows.Forms.ToolStripMenuItem mnu5d_Lop1;
    private System.Windows.Forms.ToolStripMenuItem mnu5d_Lop2;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    private System.Windows.Forms.ToolStripMenuItem mnu5d_NC1;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
    private System.Windows.Forms.ToolStripMenuItem mnu5d_VN1;

    private System.Windows.Forms.Label lblHeaderTitle;
    private System.Windows.Forms.TabControl tabControlMain;
    private System.Windows.Forms.TabPage tabTuan05c;
    private System.Windows.Forms.TabPage tabTuan05d;

    // Controls tab 5c
    private System.Windows.Forms.GroupBox grpMau5c;
    private System.Windows.Forms.Button btnMau_ListBox;
    private System.Windows.Forms.Button btnMau_ComboBox;
    private System.Windows.Forms.Button btnMau_TreeView;
    private System.Windows.Forms.GroupBox grpTaiLop5c;
    private System.Windows.Forms.Button btnLop_UocSo;
    private System.Windows.Forms.Button btnLop_SinhVien;
    private System.Windows.Forms.GroupBox grpNangCao5c;
    private System.Windows.Forms.Button btnNC_XuLyChuoi;
    private System.Windows.Forms.GroupBox grpVeNha5c;
    private System.Windows.Forms.Button btnVN_TuDien;
    private System.Windows.Forms.Button btnVN_ListBox;
    private System.Windows.Forms.Button btnVN_DanhBa;

    // Controls tab 5d
    private System.Windows.Forms.GroupBox grpMau5d;
    private System.Windows.Forms.Button btn5d_MauTimer;
    private System.Windows.Forms.Button btn5d_MauListView;
    private System.Windows.Forms.Button btn5d_MauDialog;
    private System.Windows.Forms.GroupBox grpTaiLop5d;
    private System.Windows.Forms.Button btn5d_LopSinhVien;
    private System.Windows.Forms.Button btn5d_LopTaiKhoan;
    private System.Windows.Forms.GroupBox grpNangCao5d;
    private System.Windows.Forms.Button btn5d_NCHocVien;
    private System.Windows.Forms.GroupBox grpVeNha5d;
    private System.Windows.Forms.Button btn5d_VNDemNguoc;

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
        menuStripMain = new MenuStrip();
        mnuHeThong = new ToolStripMenuItem();
        mnuThoat = new ToolStripMenuItem();
        mnuTuan05c = new ToolStripMenuItem();
        mnu5c_Mau1 = new ToolStripMenuItem();
        mnu5c_Mau2 = new ToolStripMenuItem();
        mnu5c_Mau3 = new ToolStripMenuItem();
        toolStripSeparator1 = new ToolStripSeparator();
        mnu5c_Lop1 = new ToolStripMenuItem();
        mnu5c_Lop2 = new ToolStripMenuItem();
        toolStripSeparator2 = new ToolStripSeparator();
        mnu5c_NC1 = new ToolStripMenuItem();
        toolStripSeparator3 = new ToolStripSeparator();
        mnu5c_VN1 = new ToolStripMenuItem();
        mnu5c_VN2 = new ToolStripMenuItem();
        mnu5c_VN3 = new ToolStripMenuItem();
        mnuTuan05d = new ToolStripMenuItem();
        mnu5d_Mau1 = new ToolStripMenuItem();
        mnu5d_Mau2 = new ToolStripMenuItem();
        mnu5d_Mau3 = new ToolStripMenuItem();
        toolStripSeparator4 = new ToolStripSeparator();
        mnu5d_Lop1 = new ToolStripMenuItem();
        mnu5d_Lop2 = new ToolStripMenuItem();
        toolStripSeparator5 = new ToolStripSeparator();
        mnu5d_NC1 = new ToolStripMenuItem();
        toolStripSeparator6 = new ToolStripSeparator();
        mnu5d_VN1 = new ToolStripMenuItem();
        lblHeaderTitle = new Label();
        tabControlMain = new TabControl();
        tabTuan05c = new TabPage();
        grpMau5c = new GroupBox();
        btnMau_TreeView = new Button();
        btnMau_ComboBox = new Button();
        btnMau_ListBox = new Button();
        grpTaiLop5c = new GroupBox();
        btnLop_SinhVien = new Button();
        btnLop_UocSo = new Button();
        grpNangCao5c = new GroupBox();
        btnNC_XuLyChuoi = new Button();
        grpVeNha5c = new GroupBox();
        btnVN_DanhBa = new Button();
        btnVN_ListBox = new Button();
        btnVN_TuDien = new Button();
        tabTuan05d = new TabPage();
        grpMau5d = new GroupBox();
        btn5d_MauDialog = new Button();
        btn5d_MauListView = new Button();
        btn5d_MauTimer = new Button();
        grpTaiLop5d = new GroupBox();
        btn5d_LopTaiKhoan = new Button();
        btn5d_LopSinhVien = new Button();
        grpNangCao5d = new GroupBox();
        btn5d_NCHocVien = new Button();
        grpVeNha5d = new GroupBox();
        btn5d_VNDemNguoc = new Button();
        btnThoat = new Button();
        menuStripMain.SuspendLayout();
        tabControlMain.SuspendLayout();
        tabTuan05c.SuspendLayout();
        grpMau5c.SuspendLayout();
        grpTaiLop5c.SuspendLayout();
        grpNangCao5c.SuspendLayout();
        grpVeNha5c.SuspendLayout();
        tabTuan05d.SuspendLayout();
        grpMau5d.SuspendLayout();
        grpTaiLop5d.SuspendLayout();
        grpNangCao5d.SuspendLayout();
        grpVeNha5d.SuspendLayout();
        SuspendLayout();
        // 
        // menuStripMain
        // 
        menuStripMain.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        menuStripMain.Items.AddRange(new ToolStripItem[] { mnuHeThong, mnuTuan05c, mnuTuan05d });
        menuStripMain.Location = new Point(0, 0);
        menuStripMain.Name = "menuStripMain";
        menuStripMain.Size = new Size(724, 25);
        menuStripMain.TabIndex = 0;
        menuStripMain.Text = "menuStripMain";
        // 
        // mnuHeThong
        // 
        mnuHeThong.DropDownItems.AddRange(new ToolStripItem[] { mnuThoat });
        mnuHeThong.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
        mnuHeThong.Name = "mnuHeThong";
        mnuHeThong.Size = new Size(78, 21);
        mnuHeThong.Text = "Hệ thống";
        // 
        // mnuThoat
        // 
        mnuThoat.Name = "mnuThoat";
        mnuThoat.ShortcutKeys = Keys.Alt | Keys.F4;
        mnuThoat.Size = new Size(164, 22);
        mnuThoat.Text = "Thoát";
        mnuThoat.Click += BtnThoat_Click;
        // 
        // mnuTuan05c
        // 
        mnuTuan05c.DropDownItems.AddRange(new ToolStripItem[] { mnu5c_Mau1, mnu5c_Mau2, mnu5c_Mau3, toolStripSeparator1, mnu5c_Lop1, mnu5c_Lop2, toolStripSeparator2, mnu5c_NC1, toolStripSeparator3, mnu5c_VN1, mnu5c_VN2, mnu5c_VN3 });
        mnuTuan05c.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
        mnuTuan05c.Name = "mnuTuan05c";
        mnuTuan05c.Size = new Size(172, 21);
        mnuTuan05c.Text = "Thực hành 05c (Phần 1)";
        // 
        // mnu5c_Mau1
        // 
        mnu5c_Mau1.Name = "mnu5c_Mau1";
        mnu5c_Mau1.Size = new Size(278, 22);
        mnu5c_Mau1.Text = "Bài mẫu 1: Chuyển mục ListBox";
        mnu5c_Mau1.Click += BtnMau_ListBox_Click;
        // 
        // mnu5c_Mau2
        // 
        mnu5c_Mau2.Name = "mnu5c_Mau2";
        mnu5c_Mau2.Size = new Size(278, 22);
        mnu5c_Mau2.Text = "Bài mẫu 2: ComboBox Dân tộc";
        mnu5c_Mau2.Click += BtnMau_ComboBox_Click;
        // 
        // mnu5c_Mau3
        // 
        mnu5c_Mau3.Name = "mnu5c_Mau3";
        mnu5c_Mau3.Size = new Size(278, 22);
        mnu5c_Mau3.Text = "Bài mẫu 3: TreeView Phòng ban";
        mnu5c_Mau3.Click += BtnMau_TreeView_Click;
        // 
        // toolStripSeparator1
        // 
        toolStripSeparator1.Name = "toolStripSeparator1";
        toolStripSeparator1.Size = new Size(275, 6);
        // 
        // mnu5c_Lop1
        // 
        mnu5c_Lop1.Name = "mnu5c_Lop1";
        mnu5c_Lop1.Size = new Size(278, 22);
        mnu5c_Lop1.Text = "Tại lớp 1: Ước số tự nhiên";
        mnu5c_Lop1.Click += BtnLop_UocSo_Click;
        // 
        // mnu5c_Lop2
        // 
        mnu5c_Lop2.Name = "mnu5c_Lop2";
        mnu5c_Lop2.Size = new Size(278, 22);
        mnu5c_Lop2.Text = "Tại lớp 2: Quản lý sinh viên (TreeView)";
        mnu5c_Lop2.Click += BtnLop_SinhVien_Click;
        // 
        // toolStripSeparator2
        // 
        toolStripSeparator2.Name = "toolStripSeparator2";
        toolStripSeparator2.Size = new Size(275, 6);
        // 
        // mnu5c_NC1
        // 
        mnu5c_NC1.Name = "mnu5c_NC1";
        mnu5c_NC1.Size = new Size(278, 22);
        mnu5c_NC1.Text = "Nâng cao: Xử lý chuỗi ngẫu nhiên";
        mnu5c_NC1.Click += BtnNC_XuLyChuoi_Click;
        // 
        // toolStripSeparator3
        // 
        toolStripSeparator3.Name = "toolStripSeparator3";
        toolStripSeparator3.Size = new Size(275, 6);
        // 
        // mnu5c_VN1
        // 
        mnu5c_VN1.Name = "mnu5c_VN1";
        mnu5c_VN1.Size = new Size(278, 22);
        mnu5c_VN1.Text = "Về nhà 1: Từ điển Anh - Việt";
        mnu5c_VN1.Click += BtnVN_TuDien_Click;
        // 
        // mnu5c_VN2
        // 
        mnu5c_VN2.Name = "mnu5c_VN2";
        mnu5c_VN2.Size = new Size(278, 22);
        mnu5c_VN2.Text = "Về nhà 2: ListBox số tự nhiên";
        mnu5c_VN2.Click += BtnVN_ListBox_Click;
        // 
        // mnu5c_VN3
        // 
        mnu5c_VN3.Name = "mnu5c_VN3";
        mnu5c_VN3.Size = new Size(278, 22);
        mnu5c_VN3.Text = "Về nhà 3: Danh bạ điện thoại A-Z";
        mnu5c_VN3.Click += BtnVN_DanhBa_Click;
        // 
        // mnuTuan05d
        // 
        mnuTuan05d.DropDownItems.AddRange(new ToolStripItem[] { mnu5d_Mau1, mnu5d_Mau2, mnu5d_Mau3, toolStripSeparator4, mnu5d_Lop1, mnu5d_Lop2, toolStripSeparator5, mnu5d_NC1, toolStripSeparator6, mnu5d_VN1 });
        mnuTuan05d.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
        mnuTuan05d.Name = "mnuTuan05d";
        mnuTuan05d.Size = new Size(172, 21);
        mnuTuan05d.Text = "Thực hành 05d (Phần 2)";
        // 
        // mnu5d_Mau1
        // 
        mnu5d_Mau1.Name = "mnu5d_Mau1";
        mnu5d_Mau1.Size = new Size(262, 22);
        mnu5d_Mau1.Text = "Bài mẫu 1: Demo Timer hệ thống";
        mnu5d_Mau1.Click += Btn5d_MauTimer_Click;
        // 
        // mnu5d_Mau2
        // 
        mnu5d_Mau2.Name = "mnu5d_Mau2";
        mnu5d_Mau2.Size = new Size(262, 22);
        mnu5d_Mau2.Text = "Bài mẫu 2: Demo ListView";
        mnu5d_Mau2.Click += Btn5d_MauListView_Click;
        // 
        // mnu5d_Mau3
        // 
        mnu5d_Mau3.Name = "mnu5d_Mau3";
        mnu5d_Mau3.Size = new Size(262, 22);
        mnu5d_Mau3.Text = "Bài mẫu 3: Save / Open Dialog";
        mnu5d_Mau3.Click += Btn5d_MauDialog_Click;
        // 
        // toolStripSeparator4
        // 
        toolStripSeparator4.Name = "toolStripSeparator4";
        toolStripSeparator4.Size = new Size(259, 6);
        // 
        // mnu5d_Lop1
        // 
        mnu5d_Lop1.Name = "mnu5d_Lop1";
        mnu5d_Lop1.Size = new Size(262, 22);
        mnu5d_Lop1.Text = "Tại lớp 1: Thông tin sinh viên";
        mnu5d_Lop1.Click += Btn5d_LopSinhVien_Click;
        // 
        // mnu5d_Lop2
        // 
        mnu5d_Lop2.Name = "mnu5d_Lop2";
        mnu5d_Lop2.Size = new Size(262, 22);
        mnu5d_Lop2.Text = "Tại lớp 2: Quản lý tài khoản NH";
        mnu5d_Lop2.Click += Btn5d_LopTaiKhoan_Click;
        // 
        // toolStripSeparator5
        // 
        toolStripSeparator5.Name = "toolStripSeparator5";
        toolStripSeparator5.Size = new Size(259, 6);
        // 
        // mnu5d_NC1
        // 
        mnu5d_NC1.Name = "mnu5d_NC1";
        mnu5d_NC1.Size = new Size(262, 22);
        mnu5d_NC1.Text = "Nâng cao: Quản lý học viên 2 lớp";
        mnu5d_NC1.Click += Btn5d_NCHocVien_Click;
        // 
        // toolStripSeparator6
        // 
        toolStripSeparator6.Name = "toolStripSeparator6";
        toolStripSeparator6.Size = new Size(259, 6);
        // 
        // mnu5d_VN1
        // 
        mnu5d_VN1.Name = "mnu5d_VN1";
        mnu5d_VN1.Size = new Size(262, 22);
        mnu5d_VN1.Text = "Về nhà: Đồng hồ đếm ngược";
        mnu5d_VN1.Click += Btn5d_VNDemNguoc_Click;
        // 
        // lblHeaderTitle
        // 
        lblHeaderTitle.Font = new Font("Times New Roman", 15F, FontStyle.Bold);
        lblHeaderTitle.ForeColor = Color.DarkBlue;
        lblHeaderTitle.Location = new Point(20, 35);
        lblHeaderTitle.Name = "lblHeaderTitle";
        lblHeaderTitle.Size = new Size(680, 35);
        lblHeaderTitle.TabIndex = 1;
        lblHeaderTitle.Text = "BÀI TẬP THỰC HÀNH WINFORMS NÂNG CAO - TUẦN 05";
        lblHeaderTitle.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // tabControlMain
        // 
        tabControlMain.Controls.Add(tabTuan05c);
        tabControlMain.Controls.Add(tabTuan05d);
        tabControlMain.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
        tabControlMain.Location = new Point(20, 75);
        tabControlMain.Name = "tabControlMain";
        tabControlMain.SelectedIndex = 0;
        tabControlMain.Size = new Size(680, 420);
        tabControlMain.TabIndex = 2;
        // 
        // tabTuan05c
        // 
        tabTuan05c.BackColor = Color.FromArgb(246, 248, 250);
        tabTuan05c.Controls.Add(grpMau5c);
        tabTuan05c.Controls.Add(grpTaiLop5c);
        tabTuan05c.Controls.Add(grpNangCao5c);
        tabTuan05c.Controls.Add(grpVeNha5c);
        tabTuan05c.Location = new Point(4, 26);
        tabTuan05c.Name = "tabTuan05c";
        tabTuan05c.Padding = new Padding(10);
        tabTuan05c.Size = new Size(672, 390);
        tabTuan05c.TabIndex = 0;
        tabTuan05c.Text = "Thực hành 05c (Nâng cao 1)";
        // 
        // grpMau5c
        // 
        grpMau5c.Controls.Add(btnMau_TreeView);
        grpMau5c.Controls.Add(btnMau_ComboBox);
        grpMau5c.Controls.Add(btnMau_ListBox);
        grpMau5c.Font = new Font("Times New Roman", 10.5F, FontStyle.Bold);
        grpMau5c.Location = new Point(15, 15);
        grpMau5c.Name = "grpMau5c";
        grpMau5c.Size = new Size(310, 165);
        grpMau5c.TabIndex = 0;
        grpMau5c.TabStop = false;
        grpMau5c.Text = "1. Bài tập mẫu";
        // 
        // btnMau_TreeView
        // 
        btnMau_TreeView.Font = new Font("Times New Roman", 10F);
        btnMau_TreeView.Location = new Point(20, 115);
        btnMau_TreeView.Name = "btnMau_TreeView";
        btnMau_TreeView.Size = new Size(270, 35);
        btnMau_TreeView.TabIndex = 2;
        btnMau_TreeView.Text = "Bài 3: TreeView Phòng ban";
        btnMau_TreeView.UseVisualStyleBackColor = true;
        btnMau_TreeView.Click += BtnMau_TreeView_Click;
        // 
        // btnMau_ComboBox
        // 
        btnMau_ComboBox.Font = new Font("Times New Roman", 10F);
        btnMau_ComboBox.Location = new Point(20, 70);
        btnMau_ComboBox.Name = "btnMau_ComboBox";
        btnMau_ComboBox.Size = new Size(270, 35);
        btnMau_ComboBox.TabIndex = 1;
        btnMau_ComboBox.Text = "Bài 2: ComboBox Dân tộc";
        btnMau_ComboBox.UseVisualStyleBackColor = true;
        btnMau_ComboBox.Click += BtnMau_ComboBox_Click;
        // 
        // btnMau_ListBox
        // 
        btnMau_ListBox.Font = new Font("Times New Roman", 10F);
        btnMau_ListBox.Location = new Point(20, 25);
        btnMau_ListBox.Name = "btnMau_ListBox";
        btnMau_ListBox.Size = new Size(270, 35);
        btnMau_ListBox.TabIndex = 0;
        btnMau_ListBox.Text = "Bài 1: Chuyển mục ListBox";
        btnMau_ListBox.UseVisualStyleBackColor = true;
        btnMau_ListBox.Click += BtnMau_ListBox_Click;
        // 
        // grpTaiLop5c
        // 
        grpTaiLop5c.Controls.Add(btnLop_SinhVien);
        grpTaiLop5c.Controls.Add(btnLop_UocSo);
        grpTaiLop5c.Font = new Font("Times New Roman", 10.5F, FontStyle.Bold);
        grpTaiLop5c.Location = new Point(345, 15);
        grpTaiLop5c.Name = "grpTaiLop5c";
        grpTaiLop5c.Size = new Size(310, 165);
        grpTaiLop5c.TabIndex = 1;
        grpTaiLop5c.TabStop = false;
        grpTaiLop5c.Text = "2. Bài tập tại lớp";
        // 
        // btnLop_SinhVien
        // 
        btnLop_SinhVien.Font = new Font("Times New Roman", 10F);
        btnLop_SinhVien.Location = new Point(20, 75);
        btnLop_SinhVien.Name = "btnLop_SinhVien";
        btnLop_SinhVien.Size = new Size(270, 40);
        btnLop_SinhVien.TabIndex = 1;
        btnLop_SinhVien.Text = "Bài 2: TreeView Sinh viên 3 cấp";
        btnLop_SinhVien.UseVisualStyleBackColor = true;
        btnLop_SinhVien.Click += BtnLop_SinhVien_Click;
        // 
        // btnLop_UocSo
        // 
        btnLop_UocSo.Font = new Font("Times New Roman", 10F);
        btnLop_UocSo.Location = new Point(20, 25);
        btnLop_UocSo.Name = "btnLop_UocSo";
        btnLop_UocSo.Size = new Size(270, 40);
        btnLop_UocSo.TabIndex = 0;
        btnLop_UocSo.Text = "Bài 1: Ước số tự nhiên";
        btnLop_UocSo.UseVisualStyleBackColor = true;
        btnLop_UocSo.Click += BtnLop_UocSo_Click;
        // 
        // grpNangCao5c
        // 
        grpNangCao5c.Controls.Add(btnNC_XuLyChuoi);
        grpNangCao5c.Font = new Font("Times New Roman", 10.5F, FontStyle.Bold);
        grpNangCao5c.Location = new Point(15, 195);
        grpNangCao5c.Name = "grpNangCao5c";
        grpNangCao5c.Size = new Size(310, 175);
        grpNangCao5c.TabIndex = 2;
        grpNangCao5c.TabStop = false;
        grpNangCao5c.Text = "3. Bài tập nâng cao";
        // 
        // btnNC_XuLyChuoi
        // 
        btnNC_XuLyChuoi.Font = new Font("Times New Roman", 10F);
        btnNC_XuLyChuoi.Location = new Point(20, 45);
        btnNC_XuLyChuoi.Name = "btnNC_XuLyChuoi";
        btnNC_XuLyChuoi.Size = new Size(270, 45);
        btnNC_XuLyChuoi.TabIndex = 0;
        btnNC_XuLyChuoi.Text = "Bài 1: Xử lý chuỗi và tên ngẫu nhiên";
        btnNC_XuLyChuoi.UseVisualStyleBackColor = true;
        btnNC_XuLyChuoi.Click += BtnNC_XuLyChuoi_Click;
        // 
        // grpVeNha5c
        // 
        grpVeNha5c.Controls.Add(btnVN_DanhBa);
        grpVeNha5c.Controls.Add(btnVN_ListBox);
        grpVeNha5c.Controls.Add(btnVN_TuDien);
        grpVeNha5c.Font = new Font("Times New Roman", 10.5F, FontStyle.Bold);
        grpVeNha5c.Location = new Point(345, 195);
        grpVeNha5c.Name = "grpVeNha5c";
        grpVeNha5c.Size = new Size(310, 175);
        grpVeNha5c.TabIndex = 3;
        grpVeNha5c.TabStop = false;
        grpVeNha5c.Text = "4. Bài tập về nhà";
        // 
        // btnVN_DanhBa
        // 
        btnVN_DanhBa.Font = new Font("Times New Roman", 10F);
        btnVN_DanhBa.Location = new Point(20, 120);
        btnVN_DanhBa.Name = "btnVN_DanhBa";
        btnVN_DanhBa.Size = new Size(270, 35);
        btnVN_DanhBa.TabIndex = 2;
        btnVN_DanhBa.Text = "Bài 3: Nhập danh bạ A - Z";
        btnVN_DanhBa.UseVisualStyleBackColor = true;
        btnVN_DanhBa.Click += BtnVN_DanhBa_Click;
        // 
        // btnVN_ListBox
        // 
        btnVN_ListBox.Font = new Font("Times New Roman", 10F);
        btnVN_ListBox.Location = new Point(20, 72);
        btnVN_ListBox.Name = "btnVN_ListBox";
        btnVN_ListBox.Size = new Size(270, 35);
        btnVN_ListBox.TabIndex = 1;
        btnVN_ListBox.Text = "Bài 2: ListBox số tự nhiên";
        btnVN_ListBox.UseVisualStyleBackColor = true;
        btnVN_ListBox.Click += BtnVN_ListBox_Click;
        // 
        // btnVN_TuDien
        // 
        btnVN_TuDien.Font = new Font("Times New Roman", 10F);
        btnVN_TuDien.Location = new Point(20, 25);
        btnVN_TuDien.Name = "btnVN_TuDien";
        btnVN_TuDien.Size = new Size(270, 35);
        btnVN_TuDien.TabIndex = 0;
        btnVN_TuDien.Text = "Bài 1: Từ điển Anh - Việt";
        btnVN_TuDien.UseVisualStyleBackColor = true;
        btnVN_TuDien.Click += BtnVN_TuDien_Click;
        // 
        // tabTuan05d
        // 
        tabTuan05d.BackColor = Color.FromArgb(246, 248, 250);
        tabTuan05d.Controls.Add(grpMau5d);
        tabTuan05d.Controls.Add(grpTaiLop5d);
        tabTuan05d.Controls.Add(grpNangCao5d);
        tabTuan05d.Controls.Add(grpVeNha5d);
        tabTuan05d.Location = new Point(4, 26);
        tabTuan05d.Name = "tabTuan05d";
        tabTuan05d.Padding = new Padding(10);
        tabTuan05d.Size = new Size(672, 390);
        tabTuan05d.TabIndex = 1;
        tabTuan05d.Text = "Thực hành 05d (Nâng cao 2)";
        // 
        // grpMau5d
        // 
        grpMau5d.Controls.Add(btn5d_MauDialog);
        grpMau5d.Controls.Add(btn5d_MauListView);
        grpMau5d.Controls.Add(btn5d_MauTimer);
        grpMau5d.Font = new Font("Times New Roman", 10.5F, FontStyle.Bold);
        grpMau5d.Location = new Point(15, 15);
        grpMau5d.Name = "grpMau5d";
        grpMau5d.Size = new Size(310, 165);
        grpMau5d.TabIndex = 0;
        grpMau5d.TabStop = false;
        grpMau5d.Text = "1. Bài tập mẫu";
        // 
        // btn5d_MauDialog
        // 
        btn5d_MauDialog.Font = new Font("Times New Roman", 10F);
        btn5d_MauDialog.Location = new Point(20, 115);
        btn5d_MauDialog.Name = "btn5d_MauDialog";
        btn5d_MauDialog.Size = new Size(270, 35);
        btn5d_MauDialog.TabIndex = 2;
        btn5d_MauDialog.Text = "Bài 3: Save / Open Dialog";
        btn5d_MauDialog.UseVisualStyleBackColor = true;
        btn5d_MauDialog.Click += Btn5d_MauDialog_Click;
        // 
        // btn5d_MauListView
        // 
        btn5d_MauListView.Font = new Font("Times New Roman", 10F);
        btn5d_MauListView.Location = new Point(20, 70);
        btn5d_MauListView.Name = "btn5d_MauListView";
        btn5d_MauListView.Size = new Size(270, 35);
        btn5d_MauListView.TabIndex = 1;
        btn5d_MauListView.Text = "Bài 2: Demo ListView";
        btn5d_MauListView.UseVisualStyleBackColor = true;
        btn5d_MauListView.Click += Btn5d_MauListView_Click;
        // 
        // btn5d_MauTimer
        // 
        btn5d_MauTimer.Font = new Font("Times New Roman", 10F);
        btn5d_MauTimer.Location = new Point(20, 25);
        btn5d_MauTimer.Name = "btn5d_MauTimer";
        btn5d_MauTimer.Size = new Size(270, 35);
        btn5d_MauTimer.TabIndex = 0;
        btn5d_MauTimer.Text = "Bài 1: Demo Timer hệ thống";
        btn5d_MauTimer.UseVisualStyleBackColor = true;
        btn5d_MauTimer.Click += Btn5d_MauTimer_Click;
        // 
        // grpTaiLop5d
        // 
        grpTaiLop5d.Controls.Add(btn5d_LopTaiKhoan);
        grpTaiLop5d.Controls.Add(btn5d_LopSinhVien);
        grpTaiLop5d.Font = new Font("Times New Roman", 10.5F, FontStyle.Bold);
        grpTaiLop5d.Location = new Point(345, 15);
        grpTaiLop5d.Name = "grpTaiLop5d";
        grpTaiLop5d.Size = new Size(310, 165);
        grpTaiLop5d.TabIndex = 1;
        grpTaiLop5d.TabStop = false;
        grpTaiLop5d.Text = "2. Bài tập tại lớp";
        // 
        // btn5d_LopTaiKhoan
        // 
        btn5d_LopTaiKhoan.Font = new Font("Times New Roman", 10F);
        btn5d_LopTaiKhoan.Location = new Point(20, 75);
        btn5d_LopTaiKhoan.Name = "btn5d_LopTaiKhoan";
        btn5d_LopTaiKhoan.Size = new Size(270, 40);
        btn5d_LopTaiKhoan.TabIndex = 1;
        btn5d_LopTaiKhoan.Text = "Bài 2: Quản lý tài khoản NH";
        btn5d_LopTaiKhoan.UseVisualStyleBackColor = true;
        btn5d_LopTaiKhoan.Click += Btn5d_LopTaiKhoan_Click;
        // 
        // btn5d_LopSinhVien
        // 
        btn5d_LopSinhVien.Font = new Font("Times New Roman", 10F);
        btn5d_LopSinhVien.Location = new Point(20, 25);
        btn5d_LopSinhVien.Name = "btn5d_LopSinhVien";
        btn5d_LopSinhVien.Size = new Size(270, 40);
        btn5d_LopSinhVien.TabIndex = 0;
        btn5d_LopSinhVien.Text = "Bài 1: Quản lý SV (ListView)";
        btn5d_LopSinhVien.UseVisualStyleBackColor = true;
        btn5d_LopSinhVien.Click += Btn5d_LopSinhVien_Click;
        // 
        // grpNangCao5d
        // 
        grpNangCao5d.Controls.Add(btn5d_NCHocVien);
        grpNangCao5d.Font = new Font("Times New Roman", 10.5F, FontStyle.Bold);
        grpNangCao5d.Location = new Point(15, 195);
        grpNangCao5d.Name = "grpNangCao5d";
        grpNangCao5d.Size = new Size(310, 175);
        grpNangCao5d.TabIndex = 2;
        grpNangCao5d.TabStop = false;
        grpNangCao5d.Text = "3. Bài tập nâng cao";
        // 
        // btn5d_NCHocVien
        // 
        btn5d_NCHocVien.Font = new Font("Times New Roman", 10F);
        btn5d_NCHocVien.Location = new Point(20, 45);
        btn5d_NCHocVien.Name = "btn5d_NCHocVien";
        btn5d_NCHocVien.Size = new Size(270, 45);
        btn5d_NCHocVien.TabIndex = 0;
        btn5d_NCHocVien.Text = "Bài 1: Quản lý học viên 2 lớp";
        btn5d_NCHocVien.UseVisualStyleBackColor = true;
        btn5d_NCHocVien.Click += Btn5d_NCHocVien_Click;
        // 
        // grpVeNha5d
        // 
        grpVeNha5d.Controls.Add(btn5d_VNDemNguoc);
        grpVeNha5d.Font = new Font("Times New Roman", 10.5F, FontStyle.Bold);
        grpVeNha5d.Location = new Point(345, 195);
        grpVeNha5d.Name = "grpVeNha5d";
        grpVeNha5d.Size = new Size(310, 175);
        grpVeNha5d.TabIndex = 3;
        grpVeNha5d.TabStop = false;
        grpVeNha5d.Text = "4. Bài tập về nhà";
        // 
        // btn5d_VNDemNguoc
        // 
        btn5d_VNDemNguoc.Font = new Font("Times New Roman", 10F);
        btn5d_VNDemNguoc.Location = new Point(20, 45);
        btn5d_VNDemNguoc.Name = "btn5d_VNDemNguoc";
        btn5d_VNDemNguoc.Size = new Size(270, 45);
        btn5d_VNDemNguoc.TabIndex = 0;
        btn5d_VNDemNguoc.Text = "Bài 1: Đồng hồ đếm ngược";
        btn5d_VNDemNguoc.UseVisualStyleBackColor = true;
        btn5d_VNDemNguoc.Click += Btn5d_VNDemNguoc_Click;
        // 
        // btnThoat
        // 
        btnThoat.BackColor = Color.FromArgb(230, 235, 245);
        btnThoat.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
        btnThoat.ForeColor = Color.DarkRed;
        btnThoat.Location = new Point(530, 505);
        btnThoat.Name = "btnThoat";
        btnThoat.Size = new Size(170, 36);
        btnThoat.TabIndex = 3;
        btnThoat.Text = "Thoát chương trình";
        btnThoat.UseVisualStyleBackColor = false;
        btnThoat.Click += BtnThoat_Click;
        // 
        // FrmMain
        // 
        AutoScaleDimensions = new SizeF(8F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(240, 243, 246);
        ClientSize = new Size(724, 555);
        Controls.Add(btnThoat);
        Controls.Add(tabControlMain);
        Controls.Add(lblHeaderTitle);
        Controls.Add(menuStripMain);
        Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MainMenuStrip = menuStripMain;
        Margin = new Padding(4);
        MaximizeBox = false;
        Name = "FrmMain";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Bảng điều khiển - Thực hành WinForms Nâng cao";
        menuStripMain.ResumeLayout(false);
        menuStripMain.PerformLayout();
        tabControlMain.ResumeLayout(false);
        tabTuan05c.ResumeLayout(false);
        grpMau5c.ResumeLayout(false);
        grpTaiLop5c.ResumeLayout(false);
        grpNangCao5c.ResumeLayout(false);
        grpVeNha5c.ResumeLayout(false);
        tabTuan05d.ResumeLayout(false);
        grpMau5d.ResumeLayout(false);
        grpTaiLop5d.ResumeLayout(false);
        grpNangCao5d.ResumeLayout(false);
        grpVeNha5d.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }
}
