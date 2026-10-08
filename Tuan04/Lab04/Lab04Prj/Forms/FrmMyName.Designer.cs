namespace Lab04Prj.Forms;

partial class FrmMyName
{
    private System.ComponentModel.IContainer components = null!;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label lblName;
    private System.Windows.Forms.TextBox txtYourName;
    private System.Windows.Forms.Label lblYear;
    private System.Windows.Forms.TextBox txtYear;
    private System.Windows.Forms.Button btnShow;
    private System.Windows.Forms.Button btnClear;
    private System.Windows.Forms.Button btnExit;
    private System.Windows.Forms.ErrorProvider errorProvider1;

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
        this.lblName = new System.Windows.Forms.Label();
        this.txtYourName = new System.Windows.Forms.TextBox();
        this.lblYear = new System.Windows.Forms.Label();
        this.txtYear = new System.Windows.Forms.TextBox();
        this.btnShow = new System.Windows.Forms.Button();
        this.btnClear = new System.Windows.Forms.Button();
        this.btnExit = new System.Windows.Forms.Button();
        this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
        ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
        this.SuspendLayout();

        // lblTitle
        this.lblTitle.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
        this.lblTitle.ForeColor = System.Drawing.Color.DarkBlue;
        this.lblTitle.Location = new System.Drawing.Point(20, 15);
        this.lblTitle.Name = "lblTitle";
        this.lblTitle.Size = new System.Drawing.Size(360, 30);
        this.lblTitle.TabIndex = 0;
        this.lblTitle.Text = "MY NAME PROJECT";
        this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

        // lblName
        this.lblName.Location = new System.Drawing.Point(30, 60);
        this.lblName.Name = "lblName";
        this.lblName.Size = new System.Drawing.Size(110, 25);
        this.lblName.TabIndex = 1;
        this.lblName.Text = "Your Name:";

        // txtYourName
        this.txtYourName.Location = new System.Drawing.Point(150, 58);
        this.txtYourName.Name = "txtYourName";
        this.txtYourName.Size = new System.Drawing.Size(200, 24);
        this.txtYourName.TabIndex = 2;
        this.txtYourName.Leave += new System.EventHandler(this.TxtYourName_Leave);

        // lblYear
        this.lblYear.Location = new System.Drawing.Point(30, 100);
        this.lblYear.Name = "lblYear";
        this.lblYear.Size = new System.Drawing.Size(110, 25);
        this.lblYear.TabIndex = 3;
        this.lblYear.Text = "Year of birth:";

        // txtYear
        this.txtYear.Location = new System.Drawing.Point(150, 98);
        this.txtYear.Name = "txtYear";
        this.txtYear.Size = new System.Drawing.Size(200, 24);
        this.txtYear.TabIndex = 4;
        this.txtYear.TextChanged += new System.EventHandler(this.TxtYear_TextChanged);

        // btnShow
        this.btnShow.Location = new System.Drawing.Point(40, 150);
        this.btnShow.Name = "btnShow";
        this.btnShow.Size = new System.Drawing.Size(90, 35);
        this.btnShow.TabIndex = 5;
        this.btnShow.Text = "&Show";
        this.btnShow.UseVisualStyleBackColor = true;
        this.btnShow.Click += new System.EventHandler(this.BtnShow_Click);

        // btnClear
        this.btnClear.Location = new System.Drawing.Point(150, 150);
        this.btnClear.Name = "btnClear";
        this.btnClear.Size = new System.Drawing.Size(90, 35);
        this.btnClear.TabIndex = 6;
        this.btnClear.Text = "&Clear";
        this.btnClear.UseVisualStyleBackColor = true;
        this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);

        // btnExit
        this.btnExit.Location = new System.Drawing.Point(260, 150);
        this.btnExit.Name = "btnExit";
        this.btnExit.Size = new System.Drawing.Size(90, 35);
        this.btnExit.TabIndex = 7;
        this.btnExit.Text = "E&xit";
        this.btnExit.UseVisualStyleBackColor = true;
        this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);

        // errorProvider1
        this.errorProvider1.ContainerControl = this;

        // FrmMyName
        this.AcceptButton = this.btnShow;
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.CancelButton = this.btnExit;
        this.ClientSize = new System.Drawing.Size(404, 221);
        this.Controls.Add(this.btnExit);
        this.Controls.Add(this.btnClear);
        this.Controls.Add(this.btnShow);
        this.Controls.Add(this.txtYear);
        this.Controls.Add(this.lblYear);
        this.Controls.Add(this.txtYourName);
        this.Controls.Add(this.lblName);
        this.Controls.Add(this.lblTitle);
        this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.Name = "FrmMyName";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "My name Project";
        this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMyName_FormClosing);
        ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }
}
