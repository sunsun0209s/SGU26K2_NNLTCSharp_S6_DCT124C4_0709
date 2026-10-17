namespace Lab05Prj.Forms;

partial class FrmInputNameDialog
{
    private System.ComponentModel.IContainer components = null!;
    private System.Windows.Forms.Label lblTieuDe;
    private System.Windows.Forms.TextBox txtTenMoi;
    private System.Windows.Forms.Button btnOK;
    private System.Windows.Forms.Button btnCancel;

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
        this.lblTieuDe = new System.Windows.Forms.Label();
        this.txtTenMoi = new System.Windows.Forms.TextBox();
        this.btnOK = new System.Windows.Forms.Button();
        this.btnCancel = new System.Windows.Forms.Button();
        this.SuspendLayout();

        // lblTieuDe
        this.lblTieuDe.AutoSize = true;
        this.lblTieuDe.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
        this.lblTieuDe.Location = new System.Drawing.Point(20, 20);
        this.lblTieuDe.Name = "lblTieuDe";
        this.lblTieuDe.Size = new System.Drawing.Size(126, 17);
        this.lblTieuDe.TabIndex = 0;
        this.lblTieuDe.Text = "Nhập vào tên mới:";

        // txtTenMoi
        this.txtTenMoi.Font = new System.Drawing.Font("Tahoma", 10F);
        this.txtTenMoi.Location = new System.Drawing.Point(20, 48);
        this.txtTenMoi.Name = "txtTenMoi";
        this.txtTenMoi.Size = new System.Drawing.Size(280, 24);
        this.txtTenMoi.TabIndex = 1;

        // btnOK
        this.btnOK.Font = new System.Drawing.Font("Tahoma", 10F);
        this.btnOK.Location = new System.Drawing.Point(125, 88);
        this.btnOK.Name = "btnOK";
        this.btnOK.Size = new System.Drawing.Size(80, 28);
        this.btnOK.TabIndex = 2;
        this.btnOK.Text = "OK";
        this.btnOK.UseVisualStyleBackColor = true;
        this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);

        // btnCancel
        this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        this.btnCancel.Font = new System.Drawing.Font("Tahoma", 10F);
        this.btnCancel.Location = new System.Drawing.Point(220, 88);
        this.btnCancel.Name = "btnCancel";
        this.btnCancel.Size = new System.Drawing.Size(80, 28);
        this.btnCancel.TabIndex = 3;
        this.btnCancel.Text = "Hủy";
        this.btnCancel.UseVisualStyleBackColor = true;
        this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);

        // FrmInputNameDialog
        this.AcceptButton = this.btnOK;
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.CancelButton = this.btnCancel;
        this.ClientSize = new System.Drawing.Size(325, 130);
        this.Controls.Add(this.btnCancel);
        this.Controls.Add(this.btnOK);
        this.Controls.Add(this.txtTenMoi);
        this.Controls.Add(this.lblTieuDe);
        this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.Name = "FrmInputNameDialog";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        this.Text = "Thay đổi tên";
        this.ResumeLayout(false);
        this.PerformLayout();
    }
}
