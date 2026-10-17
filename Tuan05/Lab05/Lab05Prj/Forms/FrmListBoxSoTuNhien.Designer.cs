namespace Lab05Prj.Forms;

partial class FrmListBoxSoTuNhien
{
    private System.ComponentModel.IContainer components = null!;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label lblListbox;
    private System.Windows.Forms.TextBox txtNhapSo;
    private System.Windows.Forms.Button btnNhap;
    private System.Windows.Forms.ListBox lstSo;
    private System.Windows.Forms.Label lblXuLy;
    private System.Windows.Forms.Button btnTong;
    private System.Windows.Forms.Button btnXoaDauCuoi;
    private System.Windows.Forms.Button btnXoaDangChon;
    private System.Windows.Forms.Button btnTang2;
    private System.Windows.Forms.Button btnBinhPhuong;
    private System.Windows.Forms.Button btnChonSoChan;
    private System.Windows.Forms.Button btnChonSoLe;
    private System.Windows.Forms.Button btnKetThuc;

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
        this.lblListbox = new System.Windows.Forms.Label();
        this.txtNhapSo = new System.Windows.Forms.TextBox();
        this.btnNhap = new System.Windows.Forms.Button();
        this.lstSo = new System.Windows.Forms.ListBox();
        this.lblXuLy = new System.Windows.Forms.Label();
        this.btnTong = new System.Windows.Forms.Button();
        this.btnXoaDauCuoi = new System.Windows.Forms.Button();
        this.btnXoaDangChon = new System.Windows.Forms.Button();
        this.btnTang2 = new System.Windows.Forms.Button();
        this.btnBinhPhuong = new System.Windows.Forms.Button();
        this.btnChonSoChan = new System.Windows.Forms.Button();
        this.btnChonSoLe = new System.Windows.Forms.Button();
        this.btnKetThuc = new System.Windows.Forms.Button();
        this.SuspendLayout();

        // lblTitle
        this.lblTitle.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
        this.lblTitle.ForeColor = System.Drawing.Color.DarkOrange;
        this.lblTitle.Location = new System.Drawing.Point(20, 15);
        this.lblTitle.Name = "lblTitle";
        this.lblTitle.Size = new System.Drawing.Size(460, 30);
        this.lblTitle.TabIndex = 0;
        this.lblTitle.Text = "LISTBOX";
        this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

        // lblListbox
        this.lblListbox.AutoSize = true;
        this.lblListbox.Font = new System.Drawing.Font("Tahoma", 10F);
        this.lblListbox.Location = new System.Drawing.Point(30, 55);
        this.lblListbox.Name = "lblListbox";
        this.lblListbox.Size = new System.Drawing.Size(49, 17);
        this.lblListbox.TabIndex = 1;
        this.lblListbox.Text = "Listbox";

        // txtNhapSo
        this.txtNhapSo.Font = new System.Drawing.Font("Tahoma", 10F);
        this.txtNhapSo.Location = new System.Drawing.Point(30, 78);
        this.txtNhapSo.Name = "txtNhapSo";
        this.txtNhapSo.Size = new System.Drawing.Size(160, 24);
        this.txtNhapSo.TabIndex = 2;

        // btnNhap
        this.btnNhap.Font = new System.Drawing.Font("Tahoma", 10F);
        this.btnNhap.Location = new System.Drawing.Point(30, 110);
        this.btnNhap.Name = "btnNhap";
        this.btnNhap.Size = new System.Drawing.Size(160, 28);
        this.btnNhap.TabIndex = 3;
        this.btnNhap.Text = "Nhập";
        this.btnNhap.UseVisualStyleBackColor = true;
        this.btnNhap.Click += new System.EventHandler(this.BtnNhap_Click);

        // lstSo
        this.lstSo.Font = new System.Drawing.Font("Tahoma", 10F);
        this.lstSo.FormattingEnabled = true;
        this.lstSo.ItemHeight = 16;
        this.lstSo.Location = new System.Drawing.Point(30, 145);
        this.lstSo.Name = "lstSo";
        this.lstSo.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
        this.lstSo.Size = new System.Drawing.Size(160, 180);
        this.lstSo.TabIndex = 4;

        // lblXuLy
        this.lblXuLy.AutoSize = true;
        this.lblXuLy.Font = new System.Drawing.Font("Tahoma", 10F);
        this.lblXuLy.Location = new System.Drawing.Point(220, 55);
        this.lblXuLy.Name = "lblXuLy";
        this.lblXuLy.Size = new System.Drawing.Size(89, 17);
        this.lblXuLy.TabIndex = 5;
        this.lblXuLy.Text = "Xử lý Listbox";

        // btnTong
        this.btnTong.Font = new System.Drawing.Font("Tahoma", 9.5F);
        this.btnTong.Location = new System.Drawing.Point(220, 78);
        this.btnTong.Name = "btnTong";
        this.btnTong.Size = new System.Drawing.Size(250, 28);
        this.btnTong.TabIndex = 6;
        this.btnTong.Text = "Tổng các phần tử trong List";
        this.btnTong.UseVisualStyleBackColor = true;
        this.btnTong.Click += new System.EventHandler(this.BtnTong_Click);

        // btnXoaDauCuoi
        this.btnXoaDauCuoi.Font = new System.Drawing.Font("Tahoma", 9.5F);
        this.btnXoaDauCuoi.Location = new System.Drawing.Point(220, 112);
        this.btnXoaDauCuoi.Name = "btnXoaDauCuoi";
        this.btnXoaDauCuoi.Size = new System.Drawing.Size(250, 28);
        this.btnXoaDauCuoi.TabIndex = 7;
        this.btnXoaDauCuoi.Text = "Xóa Phần tử đầu và cuối";
        this.btnXoaDauCuoi.UseVisualStyleBackColor = true;
        this.btnXoaDauCuoi.Click += new System.EventHandler(this.BtnXoaDauCuoi_Click);

        // btnXoaDangChon
        this.btnXoaDangChon.Font = new System.Drawing.Font("Tahoma", 9.5F);
        this.btnXoaDangChon.Location = new System.Drawing.Point(220, 146);
        this.btnXoaDangChon.Name = "btnXoaDangChon";
        this.btnXoaDangChon.Size = new System.Drawing.Size(250, 28);
        this.btnXoaDangChon.TabIndex = 8;
        this.btnXoaDangChon.Text = "Xóa Phần tử đang chọn";
        this.btnXoaDangChon.UseVisualStyleBackColor = true;
        this.btnXoaDangChon.Click += new System.EventHandler(this.BtnXoaDangChon_Click);

        // btnTang2
        this.btnTang2.Font = new System.Drawing.Font("Tahoma", 9.5F);
        this.btnTang2.Location = new System.Drawing.Point(220, 180);
        this.btnTang2.Name = "btnTang2";
        this.btnTang2.Size = new System.Drawing.Size(250, 28);
        this.btnTang2.TabIndex = 9;
        this.btnTang2.Text = "Tăng mỗi phần tử lên 2";
        this.btnTang2.UseVisualStyleBackColor = true;
        this.btnTang2.Click += new System.EventHandler(this.BtnTang2_Click);

        // btnBinhPhuong
        this.btnBinhPhuong.Font = new System.Drawing.Font("Tahoma", 9.5F);
        this.btnBinhPhuong.Location = new System.Drawing.Point(220, 214);
        this.btnBinhPhuong.Name = "btnBinhPhuong";
        this.btnBinhPhuong.Size = new System.Drawing.Size(250, 28);
        this.btnBinhPhuong.TabIndex = 10;
        this.btnBinhPhuong.Text = "Thay bằng bình phương";
        this.btnBinhPhuong.UseVisualStyleBackColor = true;
        this.btnBinhPhuong.Click += new System.EventHandler(this.BtnBinhPhuong_Click);

        // btnChonSoChan
        this.btnChonSoChan.Font = new System.Drawing.Font("Tahoma", 9.5F);
        this.btnChonSoChan.Location = new System.Drawing.Point(220, 248);
        this.btnChonSoChan.Name = "btnChonSoChan";
        this.btnChonSoChan.Size = new System.Drawing.Size(250, 28);
        this.btnChonSoChan.TabIndex = 11;
        this.btnChonSoChan.Text = "Chọn số chẵn";
        this.btnChonSoChan.UseVisualStyleBackColor = true;
        this.btnChonSoChan.Click += new System.EventHandler(this.BtnChonSoChan_Click);

        // btnChonSoLe
        this.btnChonSoLe.Font = new System.Drawing.Font("Tahoma", 9.5F);
        this.btnChonSoLe.Location = new System.Drawing.Point(220, 282);
        this.btnChonSoLe.Name = "btnChonSoLe";
        this.btnChonSoLe.Size = new System.Drawing.Size(250, 28);
        this.btnChonSoLe.TabIndex = 12;
        this.btnChonSoLe.Text = "Chọn số lẻ";
        this.btnChonSoLe.UseVisualStyleBackColor = true;
        this.btnChonSoLe.Click += new System.EventHandler(this.BtnChonSoLe_Click);

        // btnKetThuc
        this.btnKetThuc.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
        this.btnKetThuc.Location = new System.Drawing.Point(30, 340);
        this.btnKetThuc.Name = "btnKetThuc";
        this.btnKetThuc.Size = new System.Drawing.Size(440, 35);
        this.btnKetThuc.TabIndex = 13;
        this.btnKetThuc.Text = "KẾT THÚC";
        this.btnKetThuc.UseVisualStyleBackColor = true;
        this.btnKetThuc.Click += new System.EventHandler(this.BtnKetThuc_Click);

        // FrmListBoxSoTuNhien
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(500, 395);
        this.Controls.Add(this.btnKetThuc);
        this.Controls.Add(this.btnChonSoLe);
        this.Controls.Add(this.btnChonSoChan);
        this.Controls.Add(this.btnBinhPhuong);
        this.Controls.Add(this.btnTang2);
        this.Controls.Add(this.btnXoaDangChon);
        this.Controls.Add(this.btnXoaDauCuoi);
        this.Controls.Add(this.btnTong);
        this.Controls.Add(this.lblXuLy);
        this.Controls.Add(this.lstSo);
        this.Controls.Add(this.btnNhap);
        this.Controls.Add(this.txtNhapSo);
        this.Controls.Add(this.lblListbox);
        this.Controls.Add(this.lblTitle);
        this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.Name = "FrmListBoxSoTuNhien";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "frmListbox";
        this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmListBoxSoTuNhien_FormClosing);
        this.Load += new System.EventHandler(this.FrmListBoxSoTuNhien_Load);
        this.ResumeLayout(false);
        this.PerformLayout();
    }
}
