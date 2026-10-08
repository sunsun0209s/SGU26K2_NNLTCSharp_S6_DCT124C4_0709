namespace Lab04Prj.Forms;

partial class FrmMangSoNguyen
{
    private System.ComponentModel.IContainer components = null!;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label lblNhapMang;
    private System.Windows.Forms.TextBox txtNhapMang;
    private System.Windows.Forms.Button btnReset;
    private System.Windows.Forms.Button btnThoat;
    private System.Windows.Forms.Label lblKetQua;
    private System.Windows.Forms.TextBox txtKetQua;
    private System.Windows.Forms.GroupBox grpSapXep;
    private System.Windows.Forms.RadioButton rdoTang;
    private System.Windows.Forms.RadioButton rdoGiam;
    private System.Windows.Forms.Button btnSapXep;
    private System.Windows.Forms.GroupBox grpTong;
    private System.Windows.Forms.Label lblTongMang;
    private System.Windows.Forms.TextBox txtTongMang;
    private System.Windows.Forms.Label lblTongChan;
    private System.Windows.Forms.TextBox txtTongChan;
    private System.Windows.Forms.Label lblTongLe;
    private System.Windows.Forms.TextBox txtTongLe;
    private System.Windows.Forms.Button btnTinhTong;
    private System.Windows.Forms.GroupBox grpTimKiem;
    private System.Windows.Forms.RadioButton rdoTimGiaTri;
    private System.Windows.Forms.RadioButton rdoTimViTri;
    private System.Windows.Forms.TextBox txtGiaTriTim;
    private System.Windows.Forms.Button btnThucHienTim;
    private System.Windows.Forms.Label lblKetQuaTim;
    private System.Windows.Forms.TextBox txtKetQuaTim;
    private System.Windows.Forms.GroupBox grpMaxMin;
    private System.Windows.Forms.Label lblMax;
    private System.Windows.Forms.TextBox txtMax;
    private System.Windows.Forms.Label lblMin;
    private System.Windows.Forms.TextBox txtMin;
    private System.Windows.Forms.Button btnTimMaxMin;
    private System.Windows.Forms.GroupBox grpThem;
    private System.Windows.Forms.Label lblThemGiaTri;
    private System.Windows.Forms.TextBox txtThemGiaTri;
    private System.Windows.Forms.Label lblThemViTri;
    private System.Windows.Forms.TextBox txtThemViTri;
    private System.Windows.Forms.Button btnThem;
    private System.Windows.Forms.GroupBox grpXoa;
    private System.Windows.Forms.RadioButton rdoXoaGiaTri;
    private System.Windows.Forms.RadioButton rdoXoaViTri;
    private System.Windows.Forms.TextBox txtXoaInput;
    private System.Windows.Forms.Button btnXoa;
    private System.Windows.Forms.GroupBox grpThayThe;
    private System.Windows.Forms.Label lblCu;
    private System.Windows.Forms.TextBox txtThayGiaTriCu;
    private System.Windows.Forms.Label lblMoi;
    private System.Windows.Forms.TextBox txtThayGiaTriMoi;
    private System.Windows.Forms.Button btnThayThe;

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
        this.lblTitle = new System.Windows.Forms.Label();
        this.lblNhapMang = new System.Windows.Forms.Label();
        this.txtNhapMang = new System.Windows.Forms.TextBox();
        this.btnReset = new System.Windows.Forms.Button();
        this.btnThoat = new System.Windows.Forms.Button();
        this.lblKetQua = new System.Windows.Forms.Label();
        this.txtKetQua = new System.Windows.Forms.TextBox();
        this.grpSapXep = new System.Windows.Forms.GroupBox();
        this.rdoTang = new System.Windows.Forms.RadioButton();
        this.rdoGiam = new System.Windows.Forms.RadioButton();
        this.btnSapXep = new System.Windows.Forms.Button();
        this.grpTong = new System.Windows.Forms.GroupBox();
        this.lblTongMang = new System.Windows.Forms.Label();
        this.txtTongMang = new System.Windows.Forms.TextBox();
        this.lblTongChan = new System.Windows.Forms.Label();
        this.txtTongChan = new System.Windows.Forms.TextBox();
        this.lblTongLe = new System.Windows.Forms.Label();
        this.txtTongLe = new System.Windows.Forms.TextBox();
        this.btnTinhTong = new System.Windows.Forms.Button();
        this.grpTimKiem = new System.Windows.Forms.GroupBox();
        this.rdoTimGiaTri = new System.Windows.Forms.RadioButton();
        this.rdoTimViTri = new System.Windows.Forms.RadioButton();
        this.txtGiaTriTim = new System.Windows.Forms.TextBox();
        this.btnThucHienTim = new System.Windows.Forms.Button();
        this.lblKetQuaTim = new System.Windows.Forms.Label();
        this.txtKetQuaTim = new System.Windows.Forms.TextBox();
        this.grpMaxMin = new System.Windows.Forms.GroupBox();
        this.lblMax = new System.Windows.Forms.Label();
        this.txtMax = new System.Windows.Forms.TextBox();
        this.lblMin = new System.Windows.Forms.Label();
        this.txtMin = new System.Windows.Forms.TextBox();
        this.btnTimMaxMin = new System.Windows.Forms.Button();
        this.grpThem = new System.Windows.Forms.GroupBox();
        this.lblThemGiaTri = new System.Windows.Forms.Label();
        this.txtThemGiaTri = new System.Windows.Forms.TextBox();
        this.lblThemViTri = new System.Windows.Forms.Label();
        this.txtThemViTri = new System.Windows.Forms.TextBox();
        this.btnThem = new System.Windows.Forms.Button();
        this.grpXoa = new System.Windows.Forms.GroupBox();
        this.rdoXoaGiaTri = new System.Windows.Forms.RadioButton();
        this.rdoXoaViTri = new System.Windows.Forms.RadioButton();
        this.txtXoaInput = new System.Windows.Forms.TextBox();
        this.btnXoa = new System.Windows.Forms.Button();
        this.grpThayThe = new System.Windows.Forms.GroupBox();
        this.lblCu = new System.Windows.Forms.Label();
        this.txtThayGiaTriCu = new System.Windows.Forms.TextBox();
        this.lblMoi = new System.Windows.Forms.Label();
        this.txtThayGiaTriMoi = new System.Windows.Forms.TextBox();
        this.btnThayThe = new System.Windows.Forms.Button();
        this.grpSapXep.SuspendLayout();
        this.grpTong.SuspendLayout();
        this.grpTimKiem.SuspendLayout();
        this.grpMaxMin.SuspendLayout();
        this.grpThem.SuspendLayout();
        this.grpXoa.SuspendLayout();
        this.grpThayThe.SuspendLayout();
        this.SuspendLayout();

        // lblTitle
        this.lblTitle.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
        this.lblTitle.ForeColor = System.Drawing.Color.Red;
        this.lblTitle.Location = new System.Drawing.Point(20, 10);
        this.lblTitle.Name = "lblTitle";
        this.lblTitle.Size = new System.Drawing.Size(560, 30);
        this.lblTitle.TabIndex = 0;
        this.lblTitle.Text = "Mảng Số Nguyên";
        this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

        // lblNhapMang
        this.lblNhapMang.Location = new System.Drawing.Point(20, 50);
        this.lblNhapMang.Name = "lblNhapMang";
        this.lblNhapMang.Size = new System.Drawing.Size(90, 25);
        this.lblNhapMang.TabIndex = 1;
        this.lblNhapMang.Text = "Nhập mảng:";

        // txtNhapMang
        this.txtNhapMang.Location = new System.Drawing.Point(115, 48);
        this.txtNhapMang.Name = "txtNhapMang";
        this.txtNhapMang.Size = new System.Drawing.Size(330, 23);
        this.txtNhapMang.TabIndex = 2;
        this.txtNhapMang.Text = "5 6 4 7 8 9 10 5 6 3 2 1";
        this.txtNhapMang.TextChanged += new System.EventHandler(this.TxtNhapMang_TextChanged);

        // btnReset
        this.btnReset.Location = new System.Drawing.Point(460, 46);
        this.btnReset.Name = "btnReset";
        this.btnReset.Size = new System.Drawing.Size(65, 28);
        this.btnReset.TabIndex = 3;
        this.btnReset.Text = "Reset";
        this.btnReset.UseVisualStyleBackColor = true;
        this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);

        // btnThoat
        this.btnThoat.Location = new System.Drawing.Point(530, 46);
        this.btnThoat.Name = "btnThoat";
        this.btnThoat.Size = new System.Drawing.Size(65, 28);
        this.btnThoat.TabIndex = 4;
        this.btnThoat.Text = "Thoát";
        this.btnThoat.UseVisualStyleBackColor = true;
        this.btnThoat.Click += new System.EventHandler(this.BtnThoat_Click);

        // lblKetQua
        this.lblKetQua.Location = new System.Drawing.Point(20, 85);
        this.lblKetQua.Name = "lblKetQua";
        this.lblKetQua.Size = new System.Drawing.Size(90, 25);
        this.lblKetQua.TabIndex = 5;
        this.lblKetQua.Text = "Kết quả mảng:";

        // txtKetQua
        this.txtKetQua.Location = new System.Drawing.Point(115, 83);
        this.txtKetQua.Name = "txtKetQua";
        this.txtKetQua.ReadOnly = true;
        this.txtKetQua.Size = new System.Drawing.Size(480, 23);
        this.txtKetQua.TabIndex = 6;

        // grpSapXep
        this.grpSapXep.Controls.Add(this.btnSapXep);
        this.grpSapXep.Controls.Add(this.rdoGiam);
        this.grpSapXep.Controls.Add(this.rdoTang);
        this.grpSapXep.Location = new System.Drawing.Point(20, 120);
        this.grpSapXep.Name = "grpSapXep";
        this.grpSapXep.Size = new System.Drawing.Size(275, 75);
        this.grpSapXep.TabIndex = 7;
        this.grpSapXep.TabStop = false;
        this.grpSapXep.Text = "Sắp Xếp";

        // rdoTang
        this.rdoTang.Checked = true;
        this.rdoTang.Location = new System.Drawing.Point(15, 22);
        this.rdoTang.Name = "rdoTang";
        this.rdoTang.Size = new System.Drawing.Size(110, 25);
        this.rdoTang.TabIndex = 0;
        this.rdoTang.TabStop = true;
        this.rdoTang.Text = "Sắp xếp Tăng";
        this.rdoTang.UseVisualStyleBackColor = true;

        // rdoGiam
        this.rdoGiam.Location = new System.Drawing.Point(135, 22);
        this.rdoGiam.Name = "rdoGiam";
        this.rdoGiam.Size = new System.Drawing.Size(110, 25);
        this.rdoGiam.TabIndex = 1;
        this.rdoGiam.Text = "Sắp xếp Giảm";
        this.rdoGiam.UseVisualStyleBackColor = true;

        // btnSapXep
        this.btnSapXep.Location = new System.Drawing.Point(85, 45);
        this.btnSapXep.Name = "btnSapXep";
        this.btnSapXep.Size = new System.Drawing.Size(95, 25);
        this.btnSapXep.TabIndex = 2;
        this.btnSapXep.Text = "Thực Hiện";
        this.btnSapXep.UseVisualStyleBackColor = true;
        this.btnSapXep.Click += new System.EventHandler(this.BtnSapXep_Click);

        // grpTong
        this.grpTong.Controls.Add(this.btnTinhTong);
        this.grpTong.Controls.Add(this.txtTongLe);
        this.grpTong.Controls.Add(this.lblTongLe);
        this.grpTong.Controls.Add(this.txtTongChan);
        this.grpTong.Controls.Add(this.lblTongChan);
        this.grpTong.Controls.Add(this.txtTongMang);
        this.grpTong.Controls.Add(this.lblTongMang);
        this.grpTong.Location = new System.Drawing.Point(310, 120);
        this.grpTong.Name = "grpTong";
        this.grpTong.Size = new System.Drawing.Size(285, 115);
        this.grpTong.TabIndex = 8;
        this.grpTong.TabStop = false;
        this.grpTong.Text = "Tổng";

        // lblTongMang
        this.lblTongMang.Location = new System.Drawing.Point(15, 22);
        this.lblTongMang.Name = "lblTongMang";
        this.lblTongMang.Size = new System.Drawing.Size(80, 22);
        this.lblTongMang.TabIndex = 0;
        this.lblTongMang.Text = "Tổng mảng:";

        // txtTongMang
        this.txtTongMang.Location = new System.Drawing.Point(100, 20);
        this.txtTongMang.Name = "txtTongMang";
        this.txtTongMang.ReadOnly = true;
        this.txtTongMang.Size = new System.Drawing.Size(75, 23);
        this.txtTongMang.TabIndex = 1;

        // lblTongChan
        this.lblTongChan.Location = new System.Drawing.Point(15, 52);
        this.lblTongChan.Name = "lblTongChan";
        this.lblTongChan.Size = new System.Drawing.Size(80, 22);
        this.lblTongChan.TabIndex = 2;
        this.lblTongChan.Text = "Tổng chẵn:";

        // txtTongChan
        this.txtTongChan.Location = new System.Drawing.Point(100, 50);
        this.txtTongChan.Name = "txtTongChan";
        this.txtTongChan.ReadOnly = true;
        this.txtTongChan.Size = new System.Drawing.Size(75, 23);
        this.txtTongChan.TabIndex = 3;

        // lblTongLe
        this.lblTongLe.Location = new System.Drawing.Point(15, 82);
        this.lblTongLe.Name = "lblTongLe";
        this.lblTongLe.Size = new System.Drawing.Size(80, 22);
        this.lblTongLe.TabIndex = 4;
        this.lblTongLe.Text = "Tổng lẻ:";

        // txtTongLe
        this.txtTongLe.Location = new System.Drawing.Point(100, 80);
        this.txtTongLe.Name = "txtTongLe";
        this.txtTongLe.ReadOnly = true;
        this.txtTongLe.Size = new System.Drawing.Size(75, 23);
        this.txtTongLe.TabIndex = 5;

        // btnTinhTong
        this.btnTinhTong.Location = new System.Drawing.Point(190, 35);
        this.btnTinhTong.Name = "btnTinhTong";
        this.btnTinhTong.Size = new System.Drawing.Size(75, 55);
        this.btnTinhTong.TabIndex = 6;
        this.btnTinhTong.Text = "Tổng";
        this.btnTinhTong.UseVisualStyleBackColor = true;
        this.btnTinhTong.Click += new System.EventHandler(this.BtnTinhTong_Click);

        // grpTimKiem
        this.grpTimKiem.Controls.Add(this.txtKetQuaTim);
        this.grpTimKiem.Controls.Add(this.lblKetQuaTim);
        this.grpTimKiem.Controls.Add(this.btnThucHienTim);
        this.grpTimKiem.Controls.Add(this.txtGiaTriTim);
        this.grpTimKiem.Controls.Add(this.rdoTimViTri);
        this.grpTimKiem.Controls.Add(this.rdoTimGiaTri);
        this.grpTimKiem.Location = new System.Drawing.Point(20, 200);
        this.grpTimKiem.Name = "grpTimKiem";
        this.grpTimKiem.Size = new System.Drawing.Size(275, 115);
        this.grpTimKiem.TabIndex = 9;
        this.grpTimKiem.TabStop = false;
        this.grpTimKiem.Text = "Tìm Kiếm";

        // rdoTimGiaTri
        this.rdoTimGiaTri.Checked = true;
        this.rdoTimGiaTri.Location = new System.Drawing.Point(10, 20);
        this.rdoTimGiaTri.Name = "rdoTimGiaTri";
        this.rdoTimGiaTri.Size = new System.Drawing.Size(95, 22);
        this.rdoTimGiaTri.TabIndex = 0;
        this.rdoTimGiaTri.TabStop = true;
        this.rdoTimGiaTri.Text = "Tìm giá trị";
        this.rdoTimGiaTri.UseVisualStyleBackColor = true;

        // rdoTimViTri
        this.rdoTimViTri.Location = new System.Drawing.Point(110, 20);
        this.rdoTimViTri.Name = "rdoTimViTri";
        this.rdoTimViTri.Size = new System.Drawing.Size(110, 22);
        this.rdoTimViTri.TabIndex = 1;
        this.rdoTimViTri.Text = "Tìm theo vị trí";
        this.rdoTimViTri.UseVisualStyleBackColor = true;

        // txtGiaTriTim
        this.txtGiaTriTim.Location = new System.Drawing.Point(10, 48);
        this.txtGiaTriTim.Name = "txtGiaTriTim";
        this.txtGiaTriTim.Size = new System.Drawing.Size(80, 23);
        this.txtGiaTriTim.TabIndex = 2;

        // btnThucHienTim
        this.btnThucHienTim.Location = new System.Drawing.Point(100, 46);
        this.btnThucHienTim.Name = "btnThucHienTim";
        this.btnThucHienTim.Size = new System.Drawing.Size(60, 25);
        this.btnThucHienTim.TabIndex = 3;
        this.btnThucHienTim.Text = "Tìm";
        this.btnThucHienTim.UseVisualStyleBackColor = true;
        this.btnThucHienTim.Click += new System.EventHandler(this.BtnThucHienTim_Click);

        // lblKetQuaTim
        this.lblKetQuaTim.Location = new System.Drawing.Point(10, 82);
        this.lblKetQuaTim.Name = "lblKetQuaTim";
        this.lblKetQuaTim.Size = new System.Drawing.Size(65, 22);
        this.lblKetQuaTim.TabIndex = 4;
        this.lblKetQuaTim.Text = "Kết quả:";

        // txtKetQuaTim
        this.txtKetQuaTim.Location = new System.Drawing.Point(80, 80);
        this.txtKetQuaTim.Name = "txtKetQuaTim";
        this.txtKetQuaTim.ReadOnly = true;
        this.txtKetQuaTim.Size = new System.Drawing.Size(180, 23);
        this.txtKetQuaTim.TabIndex = 5;

        // grpMaxMin
        this.grpMaxMin.Controls.Add(this.btnTimMaxMin);
        this.grpMaxMin.Controls.Add(this.txtMin);
        this.grpMaxMin.Controls.Add(this.lblMin);
        this.grpMaxMin.Controls.Add(this.txtMax);
        this.grpMaxMin.Controls.Add(this.lblMax);
        this.grpMaxMin.Location = new System.Drawing.Point(20, 320);
        this.grpMaxMin.Name = "grpMaxMin";
        this.grpMaxMin.Size = new System.Drawing.Size(275, 85);
        this.grpMaxMin.TabIndex = 10;
        this.grpMaxMin.TabStop = false;
        this.grpMaxMin.Text = "Max - Min";

        // lblMax
        this.lblMax.Location = new System.Drawing.Point(10, 22);
        this.lblMax.Name = "lblMax";
        this.lblMax.Size = new System.Drawing.Size(70, 22);
        this.lblMax.TabIndex = 0;
        this.lblMax.Text = "Lớn nhất:";

        // txtMax
        this.txtMax.Location = new System.Drawing.Point(85, 20);
        this.txtMax.Name = "txtMax";
        this.txtMax.ReadOnly = true;
        this.txtMax.Size = new System.Drawing.Size(70, 23);
        this.txtMax.TabIndex = 1;

        // lblMin
        this.lblMin.Location = new System.Drawing.Point(10, 52);
        this.lblMin.Name = "lblMin";
        this.lblMin.Size = new System.Drawing.Size(70, 22);
        this.lblMin.TabIndex = 2;
        this.lblMin.Text = "Nhỏ nhất:";

        // txtMin
        this.txtMin.Location = new System.Drawing.Point(85, 50);
        this.txtMin.Name = "txtMin";
        this.txtMin.ReadOnly = true;
        this.txtMin.Size = new System.Drawing.Size(70, 23);
        this.txtMin.TabIndex = 3;

        // btnTimMaxMin
        this.btnTimMaxMin.Location = new System.Drawing.Point(175, 25);
        this.btnTimMaxMin.Name = "btnTimMaxMin";
        this.btnTimMaxMin.Size = new System.Drawing.Size(80, 45);
        this.btnTimMaxMin.TabIndex = 4;
        this.btnTimMaxMin.Text = "Tìm";
        this.btnTimMaxMin.UseVisualStyleBackColor = true;
        this.btnTimMaxMin.Click += new System.EventHandler(this.BtnTimMaxMin_Click);

        // grpThem
        this.grpThem.Controls.Add(this.btnThem);
        this.grpThem.Controls.Add(this.txtThemViTri);
        this.grpThem.Controls.Add(this.lblThemViTri);
        this.grpThem.Controls.Add(this.txtThemGiaTri);
        this.grpThem.Controls.Add(this.lblThemGiaTri);
        this.grpThem.Location = new System.Drawing.Point(310, 240);
        this.grpThem.Name = "grpThem";
        this.grpThem.Size = new System.Drawing.Size(285, 80);
        this.grpThem.TabIndex = 11;
        this.grpThem.TabStop = false;
        this.grpThem.Text = "Thêm phần tử";

        // lblThemGiaTri
        this.lblThemGiaTri.Location = new System.Drawing.Point(10, 22);
        this.lblThemGiaTri.Name = "lblThemGiaTri";
        this.lblThemGiaTri.Size = new System.Drawing.Size(50, 22);
        this.lblThemGiaTri.TabIndex = 0;
        this.lblThemGiaTri.Text = "Giá trị:";

        // txtThemGiaTri
        this.txtThemGiaTri.Location = new System.Drawing.Point(65, 20);
        this.txtThemGiaTri.Name = "txtThemGiaTri";
        this.txtThemGiaTri.Size = new System.Drawing.Size(55, 23);
        this.txtThemGiaTri.TabIndex = 1;

        // lblThemViTri
        this.lblThemViTri.Location = new System.Drawing.Point(130, 22);
        this.lblThemViTri.Name = "lblThemViTri";
        this.lblThemViTri.Size = new System.Drawing.Size(40, 22);
        this.lblThemViTri.TabIndex = 2;
        this.lblThemViTri.Text = "Vị trí:";

        // txtThemViTri
        this.txtThemViTri.Location = new System.Drawing.Point(175, 20);
        this.txtThemViTri.Name = "txtThemViTri";
        this.txtThemViTri.Size = new System.Drawing.Size(45, 23);
        this.txtThemViTri.TabIndex = 3;

        // btnThem
        this.btnThem.Location = new System.Drawing.Point(100, 48);
        this.btnThem.Name = "btnThem";
        this.btnThem.Size = new System.Drawing.Size(80, 26);
        this.btnThem.TabIndex = 4;
        this.btnThem.Text = "Thêm";
        this.btnThem.UseVisualStyleBackColor = true;
        this.btnThem.Click += new System.EventHandler(this.BtnThem_Click);

        // grpXoa
        this.grpXoa.Controls.Add(this.btnXoa);
        this.grpXoa.Controls.Add(this.txtXoaInput);
        this.grpXoa.Controls.Add(this.rdoXoaViTri);
        this.grpXoa.Controls.Add(this.rdoXoaGiaTri);
        this.grpXoa.Location = new System.Drawing.Point(310, 325);
        this.grpXoa.Name = "grpXoa";
        this.grpXoa.Size = new System.Drawing.Size(285, 80);
        this.grpXoa.TabIndex = 12;
        this.grpXoa.TabStop = false;
        this.grpXoa.Text = "Xóa phần tử";

        // rdoXoaGiaTri
        this.rdoXoaGiaTri.Checked = true;
        this.rdoXoaGiaTri.Location = new System.Drawing.Point(10, 18);
        this.rdoXoaGiaTri.Name = "rdoXoaGiaTri";
        this.rdoXoaGiaTri.Size = new System.Drawing.Size(90, 22);
        this.rdoXoaGiaTri.TabIndex = 0;
        this.rdoXoaGiaTri.TabStop = true;
        this.rdoXoaGiaTri.Text = "Xóa giá trị";
        this.rdoXoaGiaTri.UseVisualStyleBackColor = true;

        // rdoXoaViTri
        this.rdoXoaViTri.Location = new System.Drawing.Point(110, 18);
        this.rdoXoaViTri.Name = "rdoXoaViTri";
        this.rdoXoaViTri.Size = new System.Drawing.Size(110, 22);
        this.rdoXoaViTri.TabIndex = 1;
        this.rdoXoaViTri.Text = "Xóa theo vị trí";
        this.rdoXoaViTri.UseVisualStyleBackColor = true;

        // txtXoaInput
        this.txtXoaInput.Location = new System.Drawing.Point(10, 45);
        this.txtXoaInput.Name = "txtXoaInput";
        this.txtXoaInput.Size = new System.Drawing.Size(80, 23);
        this.txtXoaInput.TabIndex = 2;

        // btnXoa
        this.btnXoa.Location = new System.Drawing.Point(110, 43);
        this.btnXoa.Name = "btnXoa";
        this.btnXoa.Size = new System.Drawing.Size(75, 26);
        this.btnXoa.TabIndex = 3;
        this.btnXoa.Text = "Xóa";
        this.btnXoa.UseVisualStyleBackColor = true;
        this.btnXoa.Click += new System.EventHandler(this.BtnXoa_Click);

        // grpThayThe
        this.grpThayThe.Controls.Add(this.btnThayThe);
        this.grpThayThe.Controls.Add(this.txtThayGiaTriMoi);
        this.grpThayThe.Controls.Add(this.lblMoi);
        this.grpThayThe.Controls.Add(this.txtThayGiaTriCu);
        this.grpThayThe.Controls.Add(this.lblCu);
        this.grpThayThe.Location = new System.Drawing.Point(20, 415);
        this.grpThayThe.Name = "grpThayThe";
        this.grpThayThe.Size = new System.Drawing.Size(575, 65);
        this.grpThayThe.TabIndex = 13;
        this.grpThayThe.TabStop = false;
        this.grpThayThe.Text = "Thay Thế";

        // lblCu
        this.lblCu.Location = new System.Drawing.Point(20, 25);
        this.lblCu.Name = "lblCu";
        this.lblCu.Size = new System.Drawing.Size(65, 22);
        this.lblCu.TabIndex = 0;
        this.lblCu.Text = "Giá trị cũ:";

        // txtThayGiaTriCu
        this.txtThayGiaTriCu.Location = new System.Drawing.Point(90, 22);
        this.txtThayGiaTriCu.Name = "txtThayGiaTriCu";
        this.txtThayGiaTriCu.Size = new System.Drawing.Size(70, 23);
        this.txtThayGiaTriCu.TabIndex = 1;

        // lblMoi
        this.lblMoi.Location = new System.Drawing.Point(190, 25);
        this.lblMoi.Name = "lblMoi";
        this.lblMoi.Size = new System.Drawing.Size(75, 22);
        this.lblMoi.TabIndex = 2;
        this.lblMoi.Text = "Giá trị mới:";

        // txtThayGiaTriMoi
        this.txtThayGiaTriMoi.Location = new System.Drawing.Point(275, 22);
        this.txtThayGiaTriMoi.Name = "txtThayGiaTriMoi";
        this.txtThayGiaTriMoi.Size = new System.Drawing.Size(70, 23);
        this.txtThayGiaTriMoi.TabIndex = 3;

        // btnThayThe
        this.btnThayThe.Location = new System.Drawing.Point(380, 20);
        this.btnThayThe.Name = "btnThayThe";
        this.btnThayThe.Size = new System.Drawing.Size(95, 28);
        this.btnThayThe.TabIndex = 4;
        this.btnThayThe.Text = "Thay Thế";
        this.btnThayThe.UseVisualStyleBackColor = true;
        this.btnThayThe.Click += new System.EventHandler(this.BtnThayThe_Click);

        // FrmMangSoNguyen
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(604, 491);
        this.Controls.Add(this.grpThayThe);
        this.Controls.Add(this.grpXoa);
        this.Controls.Add(this.grpThem);
        this.Controls.Add(this.grpMaxMin);
        this.Controls.Add(this.grpTimKiem);
        this.Controls.Add(this.grpTong);
        this.Controls.Add(this.grpSapXep);
        this.Controls.Add(this.txtKetQua);
        this.Controls.Add(this.lblKetQua);
        this.Controls.Add(this.btnThoat);
        this.Controls.Add(this.btnReset);
        this.Controls.Add(this.txtNhapMang);
        this.Controls.Add(this.lblNhapMang);
        this.Controls.Add(this.lblTitle);
        this.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Regular);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.Name = "FrmMangSoNguyen";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Mảng Số Nguyên";
        this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMangSoNguyen_FormClosing);
        this.grpSapXep.ResumeLayout(false);
        this.grpTong.ResumeLayout(false);
        this.grpTong.PerformLayout();
        this.grpTimKiem.ResumeLayout(false);
        this.grpTimKiem.PerformLayout();
        this.grpMaxMin.ResumeLayout(false);
        this.grpMaxMin.PerformLayout();
        this.grpThem.ResumeLayout(false);
        this.grpThem.PerformLayout();
        this.grpXoa.ResumeLayout(false);
        this.grpXoa.PerformLayout();
        this.grpThayThe.ResumeLayout(false);
        this.grpThayThe.PerformLayout();
        this.ResumeLayout(false);
        this.PerformLayout();
    }
}
