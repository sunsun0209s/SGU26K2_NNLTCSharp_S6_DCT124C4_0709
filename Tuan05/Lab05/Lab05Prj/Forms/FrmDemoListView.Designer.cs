namespace Lab05Prj.Forms;

partial class FrmDemoListView
{
    private System.ComponentModel.IContainer components = null!;
    private System.Windows.Forms.Label lblMSSV;
    private System.Windows.Forms.Label lblHoTen;
    private System.Windows.Forms.TextBox txtMSSV;
    private System.Windows.Forms.TextBox txtHoTen;
    private System.Windows.Forms.Button btnThem;
    private System.Windows.Forms.Button btnXoa;
    private System.Windows.Forms.Button btnSua;
    private System.Windows.Forms.ListView lstv1;
    private System.Windows.Forms.ColumnHeader colMSSV;
    private System.Windows.Forms.ColumnHeader colHoTen;

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
        lblMSSV = new Label();
        lblHoTen = new Label();
        txtMSSV = new TextBox();
        txtHoTen = new TextBox();
        btnThem = new Button();
        btnXoa = new Button();
        btnSua = new Button();
        lstv1 = new ListView();
        colMSSV = new ColumnHeader();
        colHoTen = new ColumnHeader();
        SuspendLayout();
        // 
        // btnThem
        // 
        btnThem.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
        btnThem.Location = new Point(40, 15);
        btnThem.Name = "btnThem";
        btnThem.Size = new Size(110, 32);
        btnThem.TabIndex = 4;
        btnThem.Text = "Thêm";
        btnThem.UseVisualStyleBackColor = true;
        btnThem.Click += BtnThem_Click;
        // 
        // btnXoa
        // 
        btnXoa.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
        btnXoa.Location = new Point(190, 15);
        btnXoa.Name = "btnXoa";
        btnXoa.Size = new Size(110, 32);
        btnXoa.TabIndex = 5;
        btnXoa.Text = "Xóa";
        btnXoa.UseVisualStyleBackColor = true;
        btnXoa.Click += BtnXoa_Click;
        // 
        // btnSua
        // 
        btnSua.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
        btnSua.Location = new Point(340, 15);
        btnSua.Name = "btnSua";
        btnSua.Size = new Size(110, 32);
        btnSua.TabIndex = 6;
        btnSua.Text = "Sửa";
        btnSua.UseVisualStyleBackColor = true;
        btnSua.Click += BtnSua_Click;
        // 
        // lblMSSV
        // 
        lblMSSV.AutoSize = true;
        lblMSSV.Font = new Font("Times New Roman", 11.25F);
        lblMSSV.Location = new Point(40, 68);
        lblMSSV.Name = "lblMSSV";
        lblMSSV.Size = new Size(54, 17);
        lblMSSV.TabIndex = 0;
        lblMSSV.Text = "Mã SV:";
        // 
        // txtMSSV
        // 
        txtMSSV.Font = new Font("Times New Roman", 11.25F);
        txtMSSV.Location = new Point(110, 65);
        txtMSSV.Name = "txtMSSV";
        txtMSSV.Size = new Size(340, 25);
        txtMSSV.TabIndex = 1;
        // 
        // lblHoTen
        // 
        lblHoTen.AutoSize = true;
        lblHoTen.Font = new Font("Times New Roman", 11.25F);
        lblHoTen.Location = new Point(40, 108);
        lblHoTen.Name = "lblHoTen";
        lblHoTen.Size = new Size(53, 17);
        lblHoTen.TabIndex = 2;
        lblHoTen.Text = "Họ tên:";
        // 
        // txtHoTen
        // 
        txtHoTen.Font = new Font("Times New Roman", 11.25F);
        txtHoTen.Location = new Point(110, 105);
        txtHoTen.Name = "txtHoTen";
        txtHoTen.Size = new Size(340, 25);
        txtHoTen.TabIndex = 3;
        // 
        // lstv1
        // 
        lstv1.Columns.AddRange(new ColumnHeader[] { colMSSV, colHoTen });
        lstv1.Font = new Font("Times New Roman", 11.25F);
        lstv1.FullRowSelect = true;
        lstv1.GridLines = true;
        lstv1.Location = new Point(40, 150);
        lstv1.MultiSelect = true;
        lstv1.Name = "lstv1";
        lstv1.Size = new Size(410, 220);
        lstv1.TabIndex = 7;
        lstv1.UseCompatibleStateImageBehavior = false;
        lstv1.View = View.Details;
        lstv1.SelectedIndexChanged += Lstv1_SelectedIndexChanged;
        // 
        // colMSSV
        // 
        colMSSV.Text = "MÃ SỐ SV";
        colMSSV.Width = 140;
        // 
        // colHoTen
        // 
        colHoTen.Text = "HỌ VÀ TÊN";
        colHoTen.Width = 260;
        // 
        // FrmDemoListView
        // 
        AutoScaleDimensions = new SizeF(8F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(494, 395);
        Controls.Add(lstv1);
        Controls.Add(txtHoTen);
        Controls.Add(lblHoTen);
        Controls.Add(txtMSSV);
        Controls.Add(lblMSSV);
        Controls.Add(btnSua);
        Controls.Add(btnXoa);
        Controls.Add(btnThem);
        Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(4);
        MaximizeBox = false;
        Name = "FrmDemoListView";
        StartPosition = FormStartPosition.CenterParent;
        Text = "ListView";
        ResumeLayout(false);
        PerformLayout();
    }
}
