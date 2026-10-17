namespace Lab05Prj.Forms;

partial class FrmDanhBa
{
    private System.ComponentModel.IContainer components = null!;
    private System.Windows.Forms.TreeView trvDanhBa;
    private System.Windows.Forms.Label lblFirstName;
    private System.Windows.Forms.TextBox txtFirstName;
    private System.Windows.Forms.Label lblLastName;
    private System.Windows.Forms.TextBox txtLastName;
    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.Button btnExit;

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
        this.trvDanhBa = new System.Windows.Forms.TreeView();
        this.lblFirstName = new System.Windows.Forms.Label();
        this.txtFirstName = new System.Windows.Forms.TextBox();
        this.lblLastName = new System.Windows.Forms.Label();
        this.txtLastName = new System.Windows.Forms.TextBox();
        this.btnAdd = new System.Windows.Forms.Button();
        this.btnExit = new System.Windows.Forms.Button();
        this.SuspendLayout();

        // trvDanhBa
        this.trvDanhBa.Font = new System.Drawing.Font("Tahoma", 10F);
        this.trvDanhBa.Location = new System.Drawing.Point(20, 20);
        this.trvDanhBa.Name = "trvDanhBa";
        this.trvDanhBa.Size = new System.Drawing.Size(230, 310);
        this.trvDanhBa.TabIndex = 0;

        // lblFirstName
        this.lblFirstName.AutoSize = true;
        this.lblFirstName.Font = new System.Drawing.Font("Tahoma", 10F);
        this.lblFirstName.Location = new System.Drawing.Point(280, 40);
        this.lblFirstName.Name = "lblFirstName";
        this.lblFirstName.Size = new System.Drawing.Size(72, 17);
        this.lblFirstName.TabIndex = 1;
        this.lblFirstName.Text = "First Name";

        // txtFirstName
        this.txtFirstName.Font = new System.Drawing.Font("Tahoma", 10F);
        this.txtFirstName.Location = new System.Drawing.Point(370, 37);
        this.txtFirstName.Name = "txtFirstName";
        this.txtFirstName.Size = new System.Drawing.Size(180, 24);
        this.txtFirstName.TabIndex = 2;

        // lblLastName
        this.lblLastName.AutoSize = true;
        this.lblLastName.Font = new System.Drawing.Font("Tahoma", 10F);
        this.lblLastName.Location = new System.Drawing.Point(280, 80);
        this.lblLastName.Name = "lblLastName";
        this.lblLastName.Size = new System.Drawing.Size(72, 17);
        this.lblLastName.TabIndex = 3;
        this.lblLastName.Text = "Last Name";

        // txtLastName
        this.txtLastName.Font = new System.Drawing.Font("Tahoma", 10F);
        this.txtLastName.Location = new System.Drawing.Point(370, 77);
        this.txtLastName.Name = "txtLastName";
        this.txtLastName.Size = new System.Drawing.Size(180, 24);
        this.txtLastName.TabIndex = 4;

        // btnAdd
        this.btnAdd.Font = new System.Drawing.Font("Tahoma", 10F);
        this.btnAdd.Location = new System.Drawing.Point(450, 120);
        this.btnAdd.Name = "btnAdd";
        this.btnAdd.Size = new System.Drawing.Size(100, 32);
        this.btnAdd.TabIndex = 5;
        this.btnAdd.Text = "Add";
        this.btnAdd.UseVisualStyleBackColor = true;
        this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);

        // btnExit
        this.btnExit.Font = new System.Drawing.Font("Tahoma", 10F);
        this.btnExit.Location = new System.Drawing.Point(450, 180);
        this.btnExit.Name = "btnExit";
        this.btnExit.Size = new System.Drawing.Size(100, 32);
        this.btnExit.TabIndex = 6;
        this.btnExit.Text = "Exit";
        this.btnExit.UseVisualStyleBackColor = true;
        this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);

        // FrmDanhBa
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(580, 350);
        this.Controls.Add(this.btnExit);
        this.Controls.Add(this.btnAdd);
        this.Controls.Add(this.txtLastName);
        this.Controls.Add(this.lblLastName);
        this.Controls.Add(this.txtFirstName);
        this.Controls.Add(this.lblFirstName);
        this.Controls.Add(this.trvDanhBa);
        this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.Name = "FrmDanhBa";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "frmBTVIET2";
        this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmDanhBa_FormClosing);
        this.Load += new System.EventHandler(this.FrmDanhBa_Load);
        this.ResumeLayout(false);
        this.PerformLayout();
    }
}
