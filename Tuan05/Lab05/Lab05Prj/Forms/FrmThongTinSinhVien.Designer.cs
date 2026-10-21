namespace Lab05Prj.Forms;

partial class FrmThongTinSinhVien
{
    private System.ComponentModel.IContainer components = null!;
    private System.Windows.Forms.Label lblHoTen;
    private System.Windows.Forms.TextBox txtHoTen;
    private System.Windows.Forms.Label lblMaSV;
    private System.Windows.Forms.TextBox txtMaSV;
    private System.Windows.Forms.Label lblGioiTinh;
    private System.Windows.Forms.RadioButton radNam;
    private System.Windows.Forms.RadioButton radNu;
    private System.Windows.Forms.Label lblNgoaiNgu;
    private System.Windows.Forms.CheckBox chkAnh;
    private System.Windows.Forms.CheckBox chkPhap;
    private System.Windows.Forms.CheckBox chkHoa;
    private System.Windows.Forms.Label lblDanToc;
    private System.Windows.Forms.ComboBox cboDanToc;
    private System.Windows.Forms.ListView lsvSinhVien;
    private System.Windows.Forms.ColumnHeader colHoTen;
    private System.Windows.Forms.ColumnHeader colMaSV;
    private System.Windows.Forms.ColumnHeader colGioiTinh;
    private System.Windows.Forms.ColumnHeader colNgoaiNgu;
    private System.Windows.Forms.ColumnHeader colDanToc;
    private System.Windows.Forms.Button btnThem;
    private System.Windows.Forms.Button btnXoa;
    private System.Windows.Forms.Button btnSua;
    private System.Windows.Forms.ContextMenuStrip cmsListView;
    private System.Windows.Forms.ToolStripMenuItem mnuContextXoa;

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
        components = new System.ComponentModel.Container();
        lblHoTen = new Label();
        txtHoTen = new TextBox();
        lblMaSV = new Label();
        txtMaSV = new TextBox();
        lblGioiTinh = new Label();
        radNam = new RadioButton();
        radNu = new RadioButton();
        lblNgoaiNgu = new Label();
        chkAnh = new CheckBox();
        chkPhap = new CheckBox();
        chkHoa = new CheckBox();
        lblDanToc = new Label();
        cboDanToc = new ComboBox();
        lsvSinhVien = new ListView();
        colHoTen = new ColumnHeader();
        colMaSV = new ColumnHeader();
        colGioiTinh = new ColumnHeader();
        colNgoaiNgu = new ColumnHeader();
        colDanToc = new ColumnHeader();
        cmsListView = new ContextMenuStrip(components);
        mnuContextXoa = new ToolStripMenuItem();
        btnThem = new Button();
        btnXoa = new Button();
        btnSua = new Button();
        cmsListView.SuspendLayout();
        SuspendLayout();
        // 
        // lblHoTen
        // 
        lblHoTen.AutoSize = true;
        lblHoTen.Location = new Point(40, 20);
        lblHoTen.Name = "lblHoTen";
        lblHoTen.Size = new Size(71, 17);
        lblHoTen.TabIndex = 0;
        lblHoTen.Text = "Họ và Tên:";
        // 
        // txtHoTen
        // 
        txtHoTen.Location = new Point(140, 17);
        txtHoTen.Name = "txtHoTen";
        txtHoTen.Size = new Size(380, 25);
        txtHoTen.TabIndex = 1;
        // 
        // lblMaSV
        // 
        lblMaSV.AutoSize = true;
        lblMaSV.Location = new Point(40, 58);
        lblMaSV.Name = "lblMaSV";
        lblMaSV.Size = new Size(88, 17);
        lblMaSV.TabIndex = 2;
        lblMaSV.Text = "Mã sinh viên:";
        // 
        // txtMaSV
        // 
        txtMaSV.Location = new Point(140, 55);
        txtMaSV.Name = "txtMaSV";
        txtMaSV.Size = new Size(380, 25);
        txtMaSV.TabIndex = 3;
        // 
        // lblGioiTinh
        // 
        lblGioiTinh.AutoSize = true;
        lblGioiTinh.Location = new Point(40, 96);
        lblGioiTinh.Name = "lblGioiTinh";
        lblGioiTinh.Size = new Size(62, 17);
        lblGioiTinh.TabIndex = 4;
        lblGioiTinh.Text = "Giới tính:";
        // 
        // radNam
        // 
        radNam.AutoSize = true;
        radNam.Checked = true;
        radNam.Location = new Point(140, 94);
        radNam.Name = "radNam";
        radNam.Size = new Size(55, 21);
        radNam.TabIndex = 5;
        radNam.TabStop = true;
        radNam.Text = "Nam";
        radNam.UseVisualStyleBackColor = true;
        // 
        // radNu
        // 
        radNu.AutoSize = true;
        radNu.Location = new Point(230, 94);
        radNu.Name = "radNu";
        radNu.Size = new Size(45, 21);
        radNu.TabIndex = 6;
        radNu.Text = "Nữ";
        radNu.UseVisualStyleBackColor = true;
        // 
        // lblNgoaiNgu
        // 
        lblNgoaiNgu.AutoSize = true;
        lblNgoaiNgu.Location = new Point(40, 132);
        lblNgoaiNgu.Name = "lblNgoaiNgu";
        lblNgoaiNgu.Size = new Size(71, 17);
        lblNgoaiNgu.TabIndex = 7;
        lblNgoaiNgu.Text = "Ngoại ngữ:";
        // 
        // chkAnh
        // 
        chkAnh.AutoSize = true;
        chkAnh.Location = new Point(140, 131);
        chkAnh.Name = "chkAnh";
        chkAnh.Size = new Size(52, 21);
        chkAnh.TabIndex = 8;
        chkAnh.Text = "Anh";
        chkAnh.UseVisualStyleBackColor = true;
        // 
        // chkPhap
        // 
        chkPhap.AutoSize = true;
        chkPhap.Location = new Point(230, 131);
        chkPhap.Name = "chkPhap";
        chkPhap.Size = new Size(57, 21);
        chkPhap.TabIndex = 9;
        chkPhap.Text = "Pháp";
        chkPhap.UseVisualStyleBackColor = true;
        // 
        // chkHoa
        // 
        chkHoa.AutoSize = true;
        chkHoa.Location = new Point(320, 131);
        chkHoa.Name = "chkHoa";
        chkHoa.Size = new Size(52, 21);
        chkHoa.TabIndex = 10;
        chkHoa.Text = "Hoa";
        chkHoa.UseVisualStyleBackColor = true;
        // 
        // lblDanToc
        // 
        lblDanToc.AutoSize = true;
        lblDanToc.Location = new Point(40, 170);
        lblDanToc.Name = "lblDanToc";
        lblDanToc.Size = new Size(58, 17);
        lblDanToc.TabIndex = 11;
        lblDanToc.Text = "Dân tộc:";
        // 
        // cboDanToc
        // 
        cboDanToc.DropDownStyle = ComboBoxStyle.DropDownList;
        cboDanToc.FormattingEnabled = true;
        cboDanToc.Location = new Point(140, 167);
        cboDanToc.Name = "cboDanToc";
        cboDanToc.Size = new Size(380, 25);
        cboDanToc.TabIndex = 12;
        // 
        // lsvSinhVien
        // 
        lsvSinhVien.Columns.AddRange(new ColumnHeader[] { colHoTen, colMaSV, colGioiTinh, colNgoaiNgu, colDanToc });
        lsvSinhVien.ContextMenuStrip = cmsListView;
        lsvSinhVien.FullRowSelect = true;
        lsvSinhVien.GridLines = true;
        lsvSinhVien.Location = new Point(40, 210);
        lsvSinhVien.MultiSelect = false;
        lsvSinhVien.Name = "lsvSinhVien";
        lsvSinhVien.Size = new Size(550, 190);
        lsvSinhVien.TabIndex = 13;
        lsvSinhVien.UseCompatibleStateImageBehavior = false;
        lsvSinhVien.View = View.Details;
        lsvSinhVien.SelectedIndexChanged += LsvSinhVien_SelectedIndexChanged;
        // 
        // colHoTen
        // 
        colHoTen.Text = "Họ tên";
        colHoTen.Width = 150;
        // 
        // colMaSV
        // 
        colMaSV.Text = "Mã sinh viên";
        colMaSV.Width = 100;
        // 
        // colGioiTinh
        // 
        colGioiTinh.Text = "Giới tính";
        colGioiTinh.Width = 80;
        // 
        // colNgoaiNgu
        // 
        colNgoaiNgu.Text = "Ngoại ngữ";
        colNgoaiNgu.Width = 110;
        // 
        // colDanToc
        // 
        colDanToc.Text = "Dân tộc";
        colDanToc.Width = 90;
        // 
        // cmsListView
        // 
        cmsListView.Items.AddRange(new ToolStripItem[] { mnuContextXoa });
        cmsListView.Name = "cmsListView";
        cmsListView.Size = new Size(181, 26);
        // 
        // mnuContextXoa
        // 
        mnuContextXoa.Name = "mnuContextXoa";
        mnuContextXoa.Size = new Size(180, 22);
        mnuContextXoa.Text = "Xóa sinh viên này";
        mnuContextXoa.Click += MnuContextXoa_Click;
        // 
        // btnThem
        // 
        btnThem.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
        btnThem.Location = new Point(130, 415);
        btnThem.Name = "btnThem";
        btnThem.Size = new Size(100, 34);
        btnThem.TabIndex = 14;
        btnThem.Text = "Thêm";
        btnThem.UseVisualStyleBackColor = true;
        btnThem.Click += BtnThem_Click;
        // 
        // btnXoa
        // 
        btnXoa.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
        btnXoa.Location = new Point(265, 415);
        btnXoa.Name = "btnXoa";
        btnXoa.Size = new Size(100, 34);
        btnXoa.TabIndex = 15;
        btnXoa.Text = "Xóa";
        btnXoa.UseVisualStyleBackColor = true;
        btnXoa.Click += BtnXoa_Click;
        // 
        // btnSua
        // 
        btnSua.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
        btnSua.Location = new Point(400, 415);
        btnSua.Name = "btnSua";
        btnSua.Size = new Size(100, 34);
        btnSua.TabIndex = 16;
        btnSua.Text = "Sửa";
        btnSua.UseVisualStyleBackColor = true;
        btnSua.Click += BtnSua_Click;
        // 
        // FrmThongTinSinhVien
        // 
        AutoScaleDimensions = new SizeF(8F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(246, 248, 250);
        ClientSize = new Size(630, 465);
        Controls.Add(btnSua);
        Controls.Add(btnXoa);
        Controls.Add(btnThem);
        Controls.Add(lsvSinhVien);
        Controls.Add(cboDanToc);
        Controls.Add(lblDanToc);
        Controls.Add(chkHoa);
        Controls.Add(chkPhap);
        Controls.Add(chkAnh);
        Controls.Add(lblNgoaiNgu);
        Controls.Add(radNu);
        Controls.Add(radNam);
        Controls.Add(lblGioiTinh);
        Controls.Add(txtMaSV);
        Controls.Add(lblMaSV);
        Controls.Add(txtHoTen);
        Controls.Add(lblHoTen);
        Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Margin = new Padding(4);
        MaximizeBox = false;
        Name = "FrmThongTinSinhVien";
        StartPosition = FormStartPosition.CenterParent;
        Text = "frmBaitap1";
        FormClosing += FrmThongTinSinhVien_FormClosing;
        Load += FrmThongTinSinhVien_Load;
        cmsListView.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }
}
