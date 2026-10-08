namespace Lab04Prj.Forms;

partial class FrmBanVePhim
{
    private System.ComponentModel.IContainer components = null!;
    private System.Windows.Forms.Label lblManAnh;
    private System.Windows.Forms.Button btnGhe1;
    private System.Windows.Forms.Button btnGhe2;
    private System.Windows.Forms.Button btnGhe3;
    private System.Windows.Forms.Button btnGhe4;
    private System.Windows.Forms.Button btnGhe5;
    private System.Windows.Forms.Button btnGhe6;
    private System.Windows.Forms.Button btnGhe7;
    private System.Windows.Forms.Button btnGhe8;
    private System.Windows.Forms.Button btnGhe9;
    private System.Windows.Forms.Button btnGhe10;
    private System.Windows.Forms.Button btnGhe11;
    private System.Windows.Forms.Button btnGhe12;
    private System.Windows.Forms.Button btnGhe13;
    private System.Windows.Forms.Button btnGhe14;
    private System.Windows.Forms.Button btnGhe15;
    private System.Windows.Forms.Label lblThanhTienLabel;
    private System.Windows.Forms.TextBox txtThanhTien;
    private System.Windows.Forms.Button btnChon;
    private System.Windows.Forms.Button btnHuyBo;
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
        this.lblManAnh = new System.Windows.Forms.Label();
        this.btnGhe1 = new System.Windows.Forms.Button();
        this.btnGhe2 = new System.Windows.Forms.Button();
        this.btnGhe3 = new System.Windows.Forms.Button();
        this.btnGhe4 = new System.Windows.Forms.Button();
        this.btnGhe5 = new System.Windows.Forms.Button();
        this.btnGhe6 = new System.Windows.Forms.Button();
        this.btnGhe7 = new System.Windows.Forms.Button();
        this.btnGhe8 = new System.Windows.Forms.Button();
        this.btnGhe9 = new System.Windows.Forms.Button();
        this.btnGhe10 = new System.Windows.Forms.Button();
        this.btnGhe11 = new System.Windows.Forms.Button();
        this.btnGhe12 = new System.Windows.Forms.Button();
        this.btnGhe13 = new System.Windows.Forms.Button();
        this.btnGhe14 = new System.Windows.Forms.Button();
        this.btnGhe15 = new System.Windows.Forms.Button();
        this.lblThanhTienLabel = new System.Windows.Forms.Label();
        this.txtThanhTien = new System.Windows.Forms.TextBox();
        this.btnChon = new System.Windows.Forms.Button();
        this.btnHuyBo = new System.Windows.Forms.Button();
        this.btnKetThuc = new System.Windows.Forms.Button();
        this.SuspendLayout();

        // lblManAnh
        this.lblManAnh.BackColor = System.Drawing.Color.LightYellow;
        this.lblManAnh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.lblManAnh.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
        this.lblManAnh.ForeColor = System.Drawing.Color.DarkOrange;
        this.lblManAnh.Location = new System.Drawing.Point(30, 15);
        this.lblManAnh.Name = "lblManAnh";
        this.lblManAnh.Size = new System.Drawing.Size(380, 40);
        this.lblManAnh.TabIndex = 0;
        this.lblManAnh.Text = "MÀN ẢNH";
        this.lblManAnh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

        // Row 1 (Ghế 1 - 5)
        this.btnGhe1.BackColor = System.Drawing.Color.White;
        this.btnGhe1.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
        this.btnGhe1.Location = new System.Drawing.Point(40, 75);
        this.btnGhe1.Name = "btnGhe1";
        this.btnGhe1.Size = new System.Drawing.Size(65, 45);
        this.btnGhe1.TabIndex = 1;
        this.btnGhe1.Text = "1";
        this.btnGhe1.UseVisualStyleBackColor = false;
        this.btnGhe1.Click += new System.EventHandler(this.BtnGhe_Click);

        this.btnGhe2.BackColor = System.Drawing.Color.White;
        this.btnGhe2.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
        this.btnGhe2.Location = new System.Drawing.Point(117, 75);
        this.btnGhe2.Name = "btnGhe2";
        this.btnGhe2.Size = new System.Drawing.Size(65, 45);
        this.btnGhe2.TabIndex = 2;
        this.btnGhe2.Text = "2";
        this.btnGhe2.UseVisualStyleBackColor = false;
        this.btnGhe2.Click += new System.EventHandler(this.BtnGhe_Click);

        this.btnGhe3.BackColor = System.Drawing.Color.White;
        this.btnGhe3.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
        this.btnGhe3.Location = new System.Drawing.Point(194, 75);
        this.btnGhe3.Name = "btnGhe3";
        this.btnGhe3.Size = new System.Drawing.Size(65, 45);
        this.btnGhe3.TabIndex = 3;
        this.btnGhe3.Text = "3";
        this.btnGhe3.UseVisualStyleBackColor = false;
        this.btnGhe3.Click += new System.EventHandler(this.BtnGhe_Click);

        this.btnGhe4.BackColor = System.Drawing.Color.White;
        this.btnGhe4.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
        this.btnGhe4.Location = new System.Drawing.Point(271, 75);
        this.btnGhe4.Name = "btnGhe4";
        this.btnGhe4.Size = new System.Drawing.Size(65, 45);
        this.btnGhe4.TabIndex = 4;
        this.btnGhe4.Text = "4";
        this.btnGhe4.UseVisualStyleBackColor = false;
        this.btnGhe4.Click += new System.EventHandler(this.BtnGhe_Click);

        this.btnGhe5.BackColor = System.Drawing.Color.White;
        this.btnGhe5.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
        this.btnGhe5.Location = new System.Drawing.Point(348, 75);
        this.btnGhe5.Name = "btnGhe5";
        this.btnGhe5.Size = new System.Drawing.Size(65, 45);
        this.btnGhe5.TabIndex = 5;
        this.btnGhe5.Text = "5";
        this.btnGhe5.UseVisualStyleBackColor = false;
        this.btnGhe5.Click += new System.EventHandler(this.BtnGhe_Click);

        // Row 2 (Ghế 6 - 10)
        this.btnGhe6.BackColor = System.Drawing.Color.White;
        this.btnGhe6.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
        this.btnGhe6.Location = new System.Drawing.Point(40, 132);
        this.btnGhe6.Name = "btnGhe6";
        this.btnGhe6.Size = new System.Drawing.Size(65, 45);
        this.btnGhe6.TabIndex = 6;
        this.btnGhe6.Text = "6";
        this.btnGhe6.UseVisualStyleBackColor = false;
        this.btnGhe6.Click += new System.EventHandler(this.BtnGhe_Click);

        this.btnGhe7.BackColor = System.Drawing.Color.White;
        this.btnGhe7.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
        this.btnGhe7.Location = new System.Drawing.Point(117, 132);
        this.btnGhe7.Name = "btnGhe7";
        this.btnGhe7.Size = new System.Drawing.Size(65, 45);
        this.btnGhe7.TabIndex = 7;
        this.btnGhe7.Text = "7";
        this.btnGhe7.UseVisualStyleBackColor = false;
        this.btnGhe7.Click += new System.EventHandler(this.BtnGhe_Click);

        this.btnGhe8.BackColor = System.Drawing.Color.White;
        this.btnGhe8.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
        this.btnGhe8.Location = new System.Drawing.Point(194, 132);
        this.btnGhe8.Name = "btnGhe8";
        this.btnGhe8.Size = new System.Drawing.Size(65, 45);
        this.btnGhe8.TabIndex = 8;
        this.btnGhe8.Text = "8";
        this.btnGhe8.UseVisualStyleBackColor = false;
        this.btnGhe8.Click += new System.EventHandler(this.BtnGhe_Click);

        this.btnGhe9.BackColor = System.Drawing.Color.White;
        this.btnGhe9.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
        this.btnGhe9.Location = new System.Drawing.Point(271, 132);
        this.btnGhe9.Name = "btnGhe9";
        this.btnGhe9.Size = new System.Drawing.Size(65, 45);
        this.btnGhe9.TabIndex = 9;
        this.btnGhe9.Text = "9";
        this.btnGhe9.UseVisualStyleBackColor = false;
        this.btnGhe9.Click += new System.EventHandler(this.BtnGhe_Click);

        this.btnGhe10.BackColor = System.Drawing.Color.White;
        this.btnGhe10.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
        this.btnGhe10.Location = new System.Drawing.Point(348, 132);
        this.btnGhe10.Name = "btnGhe10";
        this.btnGhe10.Size = new System.Drawing.Size(65, 45);
        this.btnGhe10.TabIndex = 10;
        this.btnGhe10.Text = "10";
        this.btnGhe10.UseVisualStyleBackColor = false;
        this.btnGhe10.Click += new System.EventHandler(this.BtnGhe_Click);

        // Row 3 (Ghế 11 - 15)
        this.btnGhe11.BackColor = System.Drawing.Color.White;
        this.btnGhe11.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
        this.btnGhe11.Location = new System.Drawing.Point(40, 189);
        this.btnGhe11.Name = "btnGhe11";
        this.btnGhe11.Size = new System.Drawing.Size(65, 45);
        this.btnGhe11.TabIndex = 11;
        this.btnGhe11.Text = "11";
        this.btnGhe11.UseVisualStyleBackColor = false;
        this.btnGhe11.Click += new System.EventHandler(this.BtnGhe_Click);

        this.btnGhe12.BackColor = System.Drawing.Color.White;
        this.btnGhe12.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
        this.btnGhe12.Location = new System.Drawing.Point(117, 189);
        this.btnGhe12.Name = "btnGhe12";
        this.btnGhe12.Size = new System.Drawing.Size(65, 45);
        this.btnGhe12.TabIndex = 12;
        this.btnGhe12.Text = "12";
        this.btnGhe12.UseVisualStyleBackColor = false;
        this.btnGhe12.Click += new System.EventHandler(this.BtnGhe_Click);

        this.btnGhe13.BackColor = System.Drawing.Color.White;
        this.btnGhe13.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
        this.btnGhe13.Location = new System.Drawing.Point(194, 189);
        this.btnGhe13.Name = "btnGhe13";
        this.btnGhe13.Size = new System.Drawing.Size(65, 45);
        this.btnGhe13.TabIndex = 13;
        this.btnGhe13.Text = "13";
        this.btnGhe13.UseVisualStyleBackColor = false;
        this.btnGhe13.Click += new System.EventHandler(this.BtnGhe_Click);

        this.btnGhe14.BackColor = System.Drawing.Color.White;
        this.btnGhe14.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
        this.btnGhe14.Location = new System.Drawing.Point(271, 189);
        this.btnGhe14.Name = "btnGhe14";
        this.btnGhe14.Size = new System.Drawing.Size(65, 45);
        this.btnGhe14.TabIndex = 14;
        this.btnGhe14.Text = "14";
        this.btnGhe14.UseVisualStyleBackColor = false;
        this.btnGhe14.Click += new System.EventHandler(this.BtnGhe_Click);

        this.btnGhe15.BackColor = System.Drawing.Color.White;
        this.btnGhe15.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
        this.btnGhe15.Location = new System.Drawing.Point(348, 189);
        this.btnGhe15.Name = "btnGhe15";
        this.btnGhe15.Size = new System.Drawing.Size(65, 45);
        this.btnGhe15.TabIndex = 15;
        this.btnGhe15.Text = "15";
        this.btnGhe15.UseVisualStyleBackColor = false;
        this.btnGhe15.Click += new System.EventHandler(this.BtnGhe_Click);

        // lblThanhTienLabel
        this.lblThanhTienLabel.Location = new System.Drawing.Point(50, 275);
        this.lblThanhTienLabel.Name = "lblThanhTienLabel";
        this.lblThanhTienLabel.Size = new System.Drawing.Size(90, 25);
        this.lblThanhTienLabel.TabIndex = 16;
        this.lblThanhTienLabel.Text = "Thành Tiền:";

        // txtThanhTien
        this.txtThanhTien.Location = new System.Drawing.Point(150, 272);
        this.txtThanhTien.Name = "txtThanhTien";
        this.txtThanhTien.ReadOnly = true;
        this.txtThanhTien.Size = new System.Drawing.Size(200, 24);
        this.txtThanhTien.TabIndex = 17;
        this.txtThanhTien.Text = "0";
        this.txtThanhTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

        // btnChon
        this.btnChon.Location = new System.Drawing.Point(50, 320);
        this.btnChon.Name = "btnChon";
        this.btnChon.Size = new System.Drawing.Size(95, 35);
        this.btnChon.TabIndex = 18;
        this.btnChon.Text = "Chọn";
        this.btnChon.UseVisualStyleBackColor = true;
        this.btnChon.Click += new System.EventHandler(this.BtnChon_Click);

        // btnHuyBo
        this.btnHuyBo.Location = new System.Drawing.Point(170, 320);
        this.btnHuyBo.Name = "btnHuyBo";
        this.btnHuyBo.Size = new System.Drawing.Size(95, 35);
        this.btnHuyBo.TabIndex = 19;
        this.btnHuyBo.Text = "Hủy bỏ";
        this.btnHuyBo.UseVisualStyleBackColor = true;
        this.btnHuyBo.Click += new System.EventHandler(this.BtnHuyBo_Click);

        // btnKetThuc
        this.btnKetThuc.Location = new System.Drawing.Point(290, 320);
        this.btnKetThuc.Name = "btnKetThuc";
        this.btnKetThuc.Size = new System.Drawing.Size(95, 35);
        this.btnKetThuc.TabIndex = 20;
        this.btnKetThuc.Text = "Kết thúc";
        this.btnKetThuc.UseVisualStyleBackColor = true;
        this.btnKetThuc.Click += new System.EventHandler(this.BtnKetThuc_Click);

        // FrmBanVePhim
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(444, 381);
        this.Controls.Add(this.btnKetThuc);
        this.Controls.Add(this.btnHuyBo);
        this.Controls.Add(this.btnChon);
        this.Controls.Add(this.txtThanhTien);
        this.Controls.Add(this.lblThanhTienLabel);
        this.Controls.Add(this.btnGhe15);
        this.Controls.Add(this.btnGhe14);
        this.Controls.Add(this.btnGhe13);
        this.Controls.Add(this.btnGhe12);
        this.Controls.Add(this.btnGhe1);
        this.Controls.Add(this.btnGhe2);
        this.Controls.Add(this.btnGhe3);
        this.Controls.Add(this.btnGhe4);
        this.Controls.Add(this.btnGhe5);
        this.Controls.Add(this.btnGhe6);
        this.Controls.Add(this.btnGhe7);
        this.Controls.Add(this.btnGhe8);
        this.Controls.Add(this.btnGhe9);
        this.Controls.Add(this.btnGhe10);
        this.Controls.Add(this.btnGhe11);
        this.Controls.Add(this.lblManAnh);
        this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.Name = "FrmBanVePhim";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "BÁN VÉ RẠP CHIẾU BÓNG";
        this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmBanVePhim_FormClosing);
        this.ResumeLayout(false);
        this.PerformLayout();
    }
}
