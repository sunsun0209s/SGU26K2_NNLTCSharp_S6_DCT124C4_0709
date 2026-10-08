namespace Lab04Prj.Forms;

partial class FrmDangKyTaiKhoan
{
    private System.ComponentModel.IContainer components = null!;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label lblUser;
    private System.Windows.Forms.TextBox txtUser;
    private System.Windows.Forms.Label lblEmail;
    private System.Windows.Forms.TextBox txtEmail;
    private System.Windows.Forms.Label lblPass;
    private System.Windows.Forms.TextBox txtPass;
    private System.Windows.Forms.Label lblConfirm;
    private System.Windows.Forms.TextBox txtConfirm;
    private System.Windows.Forms.Button btnRegister;
    private System.Windows.Forms.ErrorProvider errorProvider;

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
        this.components = new System.ComponentModel.Container();
        this.lblTitle = new System.Windows.Forms.Label();
        this.lblUser = new System.Windows.Forms.Label();
        this.txtUser = new System.Windows.Forms.TextBox();
        this.lblEmail = new System.Windows.Forms.Label();
        this.txtEmail = new System.Windows.Forms.TextBox();
        this.lblPass = new System.Windows.Forms.Label();
        this.txtPass = new System.Windows.Forms.TextBox();
        this.lblConfirm = new System.Windows.Forms.Label();
        this.txtConfirm = new System.Windows.Forms.TextBox();
        this.btnRegister = new System.Windows.Forms.Button();
        this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
        ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
        this.SuspendLayout();

        // lblTitle
        this.lblTitle.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
        this.lblTitle.ForeColor = System.Drawing.Color.DarkBlue;
        this.lblTitle.Location = new System.Drawing.Point(20, 15);
        this.lblTitle.Name = "lblTitle";
        this.lblTitle.Size = new System.Drawing.Size(400, 30);
        this.lblTitle.TabIndex = 0;
        this.lblTitle.Text = "ĐĂNG KÝ TÀI KHOẢN";
        this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

        // lblUser
        this.lblUser.Location = new System.Drawing.Point(30, 60);
        this.lblUser.Name = "lblUser";
        this.lblUser.Size = new System.Drawing.Size(140, 25);
        this.lblUser.TabIndex = 1;
        this.lblUser.Text = "Tên đăng nhập (*):";

        // txtUser
        this.txtUser.Location = new System.Drawing.Point(175, 58);
        this.txtUser.Name = "txtUser";
        this.txtUser.Size = new System.Drawing.Size(220, 24);
        this.txtUser.TabIndex = 2;

        // lblEmail
        this.lblEmail.Location = new System.Drawing.Point(30, 100);
        this.lblEmail.Name = "lblEmail";
        this.lblEmail.Size = new System.Drawing.Size(140, 25);
        this.lblEmail.TabIndex = 3;
        this.lblEmail.Text = "Địa chỉ email (*):";

        // txtEmail
        this.txtEmail.Location = new System.Drawing.Point(175, 98);
        this.txtEmail.Name = "txtEmail";
        this.txtEmail.Size = new System.Drawing.Size(220, 24);
        this.txtEmail.TabIndex = 4;
        this.txtEmail.Leave += new System.EventHandler(this.TxtEmail_Leave);

        // lblPass
        this.lblPass.Location = new System.Drawing.Point(30, 140);
        this.lblPass.Name = "lblPass";
        this.lblPass.Size = new System.Drawing.Size(140, 25);
        this.lblPass.TabIndex = 5;
        this.lblPass.Text = "Mật khẩu (*):";

        // txtPass
        this.txtPass.Location = new System.Drawing.Point(175, 138);
        this.txtPass.Name = "txtPass";
        this.txtPass.PasswordChar = '*';
        this.txtPass.Size = new System.Drawing.Size(220, 24);
        this.txtPass.TabIndex = 6;

        // lblConfirm
        this.lblConfirm.Location = new System.Drawing.Point(30, 180);
        this.lblConfirm.Name = "lblConfirm";
        this.lblConfirm.Size = new System.Drawing.Size(140, 25);
        this.lblConfirm.TabIndex = 7;
        this.lblConfirm.Text = "Xác nhận mật khẩu (*):";

        // txtConfirm
        this.txtConfirm.Location = new System.Drawing.Point(175, 178);
        this.txtConfirm.Name = "txtConfirm";
        this.txtConfirm.PasswordChar = '*';
        this.txtConfirm.Size = new System.Drawing.Size(220, 24);
        this.txtConfirm.TabIndex = 8;
        this.txtConfirm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtConfirm_KeyDown);

        // btnRegister
        this.btnRegister.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
        this.btnRegister.Location = new System.Drawing.Point(175, 225);
        this.btnRegister.Name = "btnRegister";
        this.btnRegister.Size = new System.Drawing.Size(120, 35);
        this.btnRegister.TabIndex = 9;
        this.btnRegister.Text = "Đăng ký";
        this.btnRegister.UseVisualStyleBackColor = true;
        this.btnRegister.Click += new System.EventHandler(this.BtnRegister_Click);

        // errorProvider
        this.errorProvider.ContainerControl = this;

        // FrmDangKyTaiKhoan
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(444, 281);
        this.Controls.Add(this.btnRegister);
        this.Controls.Add(this.txtConfirm);
        this.Controls.Add(this.lblConfirm);
        this.Controls.Add(this.txtPass);
        this.Controls.Add(this.lblPass);
        this.Controls.Add(this.txtEmail);
        this.Controls.Add(this.lblEmail);
        this.Controls.Add(this.txtUser);
        this.Controls.Add(this.lblUser);
        this.Controls.Add(this.lblTitle);
        this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.Name = "FrmDangKyTaiKhoan";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Đăng ký tài khoản";
        this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmDangKyTaiKhoan_FormClosing);
        ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }
}
