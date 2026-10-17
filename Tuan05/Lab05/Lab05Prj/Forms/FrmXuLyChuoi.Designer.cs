namespace Lab05Prj.Forms;

partial class FrmXuLyChuoi
{
    private System.ComponentModel.IContainer components = null!;
    private System.Windows.Forms.Button btnNgauNhien;
    private System.Windows.Forms.ListBox lstHoTen;
    private System.Windows.Forms.Button btnXoaDangChon;
    private System.Windows.Forms.Button btnXoaTenSon;
    private System.Windows.Forms.Button btnXoaHoLe;
    private System.Windows.Forms.Button btnInHoa;
    private System.Windows.Forms.Button btnInThuong;
    private System.Windows.Forms.Button btnTitleCase;
    private System.Windows.Forms.Button btnXoaTatCa;

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
        this.btnNgauNhien = new System.Windows.Forms.Button();
        this.lstHoTen = new System.Windows.Forms.ListBox();
        this.btnXoaDangChon = new System.Windows.Forms.Button();
        this.btnXoaTenSon = new System.Windows.Forms.Button();
        this.btnXoaHoLe = new System.Windows.Forms.Button();
        this.btnInHoa = new System.Windows.Forms.Button();
        this.btnInThuong = new System.Windows.Forms.Button();
        this.btnTitleCase = new System.Windows.Forms.Button();
        this.btnXoaTatCa = new System.Windows.Forms.Button();
        this.SuspendLayout();

        // btnNgauNhien
        this.btnNgauNhien.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
        this.btnNgauNhien.Location = new System.Drawing.Point(30, 20);
        this.btnNgauNhien.Name = "btnNgauNhien";
        this.btnNgauNhien.Size = new System.Drawing.Size(220, 32);
        this.btnNgauNhien.TabIndex = 0;
        this.btnNgauNhien.Text = "Nhập tên ngẫu nhiên";
        this.btnNgauNhien.UseVisualStyleBackColor = true;
        this.btnNgauNhien.Click += new System.EventHandler(this.BtnNgauNhien_Click);

        // lstHoTen
        this.lstHoTen.Font = new System.Drawing.Font("Tahoma", 10F);
        this.lstHoTen.FormattingEnabled = true;
        this.lstHoTen.ItemHeight = 16;
        this.lstHoTen.Location = new System.Drawing.Point(30, 60);
        this.lstHoTen.Name = "lstHoTen";
        this.lstHoTen.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
        this.lstHoTen.Size = new System.Drawing.Size(220, 276);
        this.lstHoTen.TabIndex = 1;
        this.lstHoTen.DoubleClick += new System.EventHandler(this.LstHoTen_DoubleClick);

        // btnXoaDangChon
        this.btnXoaDangChon.Font = new System.Drawing.Font("Tahoma", 10F);
        this.btnXoaDangChon.Location = new System.Drawing.Point(275, 60);
        this.btnXoaDangChon.Name = "btnXoaDangChon";
        this.btnXoaDangChon.Size = new System.Drawing.Size(260, 32);
        this.btnXoaDangChon.TabIndex = 2;
        this.btnXoaDangChon.Text = "Xóa Phần tử đang chọn";
        this.btnXoaDangChon.UseVisualStyleBackColor = true;
        this.btnXoaDangChon.Click += new System.EventHandler(this.BtnXoaDangChon_Click);

        // btnXoaTenSon
        this.btnXoaTenSon.Font = new System.Drawing.Font("Tahoma", 10F);
        this.btnXoaTenSon.Location = new System.Drawing.Point(275, 100);
        this.btnXoaTenSon.Name = "btnXoaTenSon";
        this.btnXoaTenSon.Size = new System.Drawing.Size(260, 32);
        this.btnXoaTenSon.TabIndex = 3;
        this.btnXoaTenSon.Text = "Xóa phần tử có tên là Sơn";
        this.btnXoaTenSon.UseVisualStyleBackColor = true;
        this.btnXoaTenSon.Click += new System.EventHandler(this.BtnXoaTenSon_Click);

        // btnXoaHoLe
        this.btnXoaHoLe.Font = new System.Drawing.Font("Tahoma", 10F);
        this.btnXoaHoLe.Location = new System.Drawing.Point(275, 140);
        this.btnXoaHoLe.Name = "btnXoaHoLe";
        this.btnXoaHoLe.Size = new System.Drawing.Size(260, 32);
        this.btnXoaHoLe.TabIndex = 4;
        this.btnXoaHoLe.Text = "Xóa Phần tử có họ là Lê";
        this.btnXoaHoLe.UseVisualStyleBackColor = true;
        this.btnXoaHoLe.Click += new System.EventHandler(this.BtnXoaHoLe_Click);

        // btnInHoa
        this.btnInHoa.Font = new System.Drawing.Font("Tahoma", 10F);
        this.btnInHoa.Location = new System.Drawing.Point(275, 180);
        this.btnInHoa.Name = "btnInHoa";
        this.btnInHoa.Size = new System.Drawing.Size(260, 32);
        this.btnInHoa.TabIndex = 5;
        this.btnInHoa.Text = "Chuyển PT đang chọn thành chữ HOA";
        this.btnInHoa.UseVisualStyleBackColor = true;
        this.btnInHoa.Click += new System.EventHandler(this.BtnInHoa_Click);

        // btnInThuong
        this.btnInThuong.Font = new System.Drawing.Font("Tahoma", 10F);
        this.btnInThuong.Location = new System.Drawing.Point(275, 220);
        this.btnInThuong.Name = "btnInThuong";
        this.btnInThuong.Size = new System.Drawing.Size(260, 32);
        this.btnInThuong.TabIndex = 6;
        this.btnInThuong.Text = "Chuyển PT đang chọn thành chữ thường";
        this.btnInThuong.UseVisualStyleBackColor = true;
        this.btnInThuong.Click += new System.EventHandler(this.BtnInThuong_Click);

        // btnTitleCase
        this.btnTitleCase.Font = new System.Drawing.Font("Tahoma", 10F);
        this.btnTitleCase.Location = new System.Drawing.Point(275, 260);
        this.btnTitleCase.Name = "btnTitleCase";
        this.btnTitleCase.Size = new System.Drawing.Size(260, 42);
        this.btnTitleCase.TabIndex = 7;
        this.btnTitleCase.Text = "Chuyển PT đang chọn thành viết Hoa\r\nđầu mỗi từ";
        this.btnTitleCase.UseVisualStyleBackColor = true;
        this.btnTitleCase.Click += new System.EventHandler(this.BtnTitleCase_Click);

        // btnXoaTatCa
        this.btnXoaTatCa.Font = new System.Drawing.Font("Tahoma", 10F);
        this.btnXoaTatCa.Location = new System.Drawing.Point(275, 310);
        this.btnXoaTatCa.Name = "btnXoaTatCa";
        this.btnXoaTatCa.Size = new System.Drawing.Size(260, 32);
        this.btnXoaTatCa.TabIndex = 8;
        this.btnXoaTatCa.Text = "Xóa tất cả các Phần tử";
        this.btnXoaTatCa.UseVisualStyleBackColor = true;
        this.btnXoaTatCa.Click += new System.EventHandler(this.BtnXoaTatCa_Click);

        // FrmXuLyChuoi
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(565, 365);
        this.Controls.Add(this.btnXoaTatCa);
        this.Controls.Add(this.btnTitleCase);
        this.Controls.Add(this.btnInThuong);
        this.Controls.Add(this.btnInHoa);
        this.Controls.Add(this.btnXoaHoLe);
        this.Controls.Add(this.btnXoaTenSon);
        this.Controls.Add(this.btnXoaDangChon);
        this.Controls.Add(this.lstHoTen);
        this.Controls.Add(this.btnNgauNhien);
        this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.Name = "FrmXuLyChuoi";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "frmChuoi";
        this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmXuLyChuoi_FormClosing);
        this.ResumeLayout(false);
    }
}
