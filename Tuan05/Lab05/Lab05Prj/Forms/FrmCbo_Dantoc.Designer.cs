namespace Lab05Prj.Forms;

partial class FrmCbo_Dantoc
{
    private System.ComponentModel.IContainer components = null!;
    private System.Windows.Forms.Button btn_loadDL;
    private System.Windows.Forms.Label lblDanToc;
    private System.Windows.Forms.ComboBox cbo_dt;
    private System.Windows.Forms.Button btn_hienthi;
    private System.Windows.Forms.Label lbl_kq;

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
        this.btn_loadDL = new System.Windows.Forms.Button();
        this.lblDanToc = new System.Windows.Forms.Label();
        this.cbo_dt = new System.Windows.Forms.ComboBox();
        this.btn_hienthi = new System.Windows.Forms.Button();
        this.lbl_kq = new System.Windows.Forms.Label();
        this.SuspendLayout();

        // btn_loadDL
        this.btn_loadDL.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
        this.btn_loadDL.Location = new System.Drawing.Point(50, 25);
        this.btn_loadDL.Name = "btn_loadDL";
        this.btn_loadDL.Size = new System.Drawing.Size(260, 35);
        this.btn_loadDL.TabIndex = 0;
        this.btn_loadDL.Text = "Load dữ liệu Combobox";
        this.btn_loadDL.UseVisualStyleBackColor = true;
        this.btn_loadDL.Click += new System.EventHandler(this.Btn_loadDL_Click);

        // lblDanToc
        this.lblDanToc.AutoSize = true;
        this.lblDanToc.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
        this.lblDanToc.Location = new System.Drawing.Point(50, 80);
        this.lblDanToc.Name = "lblDanToc";
        this.lblDanToc.Size = new System.Drawing.Size(66, 17);
        this.lblDanToc.TabIndex = 1;
        this.lblDanToc.Text = "Dân tộc";

        // cbo_dt
        this.cbo_dt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cbo_dt.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
        this.cbo_dt.FormattingEnabled = true;
        this.cbo_dt.Location = new System.Drawing.Point(135, 77);
        this.cbo_dt.Name = "cbo_dt";
        this.cbo_dt.Size = new System.Drawing.Size(175, 24);
        this.cbo_dt.TabIndex = 2;
        this.cbo_dt.SelectedIndexChanged += new System.EventHandler(this.Cbo_dt_SelectedIndexChanged);

        // btn_hienthi
        this.btn_hienthi.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
        this.btn_hienthi.Location = new System.Drawing.Point(135, 120);
        this.btn_hienthi.Name = "btn_hienthi";
        this.btn_hienthi.Size = new System.Drawing.Size(100, 32);
        this.btn_hienthi.TabIndex = 3;
        this.btn_hienthi.Text = "Hiển thị";
        this.btn_hienthi.UseVisualStyleBackColor = true;
        this.btn_hienthi.Click += new System.EventHandler(this.Btn_hienthi_Click);

        // lbl_kq
        this.lbl_kq.AutoSize = true;
        this.lbl_kq.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
        this.lbl_kq.ForeColor = System.Drawing.Color.Red;
        this.lbl_kq.Location = new System.Drawing.Point(50, 175);
        this.lbl_kq.Name = "lbl_kq";
        this.lbl_kq.Size = new System.Drawing.Size(63, 17);
        this.lbl_kq.TabIndex = 4;
        this.lbl_kq.Text = "Kết quả";

        // FrmCbo_Dantoc
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(360, 225);
        this.Controls.Add(this.lbl_kq);
        this.Controls.Add(this.btn_hienthi);
        this.Controls.Add(this.cbo_dt);
        this.Controls.Add(this.lblDanToc);
        this.Controls.Add(this.btn_loadDL);
        this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.Name = "FrmCbo_Dantoc";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Cbo_Dantoc";
        this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCbo_Dantoc_FormClosing);
        this.ResumeLayout(false);
        this.PerformLayout();
    }
}
