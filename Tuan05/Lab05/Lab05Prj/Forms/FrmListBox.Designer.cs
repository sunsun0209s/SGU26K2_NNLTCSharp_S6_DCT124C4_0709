namespace Lab05Prj.Forms;

partial class FrmListBox
{
    private System.ComponentModel.IContainer components = null!;
    private System.Windows.Forms.ListBox lst_Trai;
    private System.Windows.Forms.ListBox lst_Phai;
    private System.Windows.Forms.Button btnQuaPhai;
    private System.Windows.Forms.Button btnQuaPhaiAll;
    private System.Windows.Forms.Button btnQuaTrai;
    private System.Windows.Forms.Button btnQuaTraiAll;
    private System.Windows.Forms.Button btnChuyenTuyY;

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
        this.lst_Trai = new System.Windows.Forms.ListBox();
        this.lst_Phai = new System.Windows.Forms.ListBox();
        this.btnQuaPhai = new System.Windows.Forms.Button();
        this.btnQuaPhaiAll = new System.Windows.Forms.Button();
        this.btnQuaTrai = new System.Windows.Forms.Button();
        this.btnQuaTraiAll = new System.Windows.Forms.Button();
        this.btnChuyenTuyY = new System.Windows.Forms.Button();
        this.SuspendLayout();

        // lst_Trai
        this.lst_Trai.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
        this.lst_Trai.FormattingEnabled = true;
        this.lst_Trai.ItemHeight = 18;
        this.lst_Trai.Location = new System.Drawing.Point(30, 30);
        this.lst_Trai.Name = "lst_Trai";
        this.lst_Trai.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
        this.lst_Trai.Size = new System.Drawing.Size(160, 256);
        this.lst_Trai.TabIndex = 0;

        // btnQuaPhai
        this.btnQuaPhai.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
        this.btnQuaPhai.Location = new System.Drawing.Point(210, 40);
        this.btnQuaPhai.Name = "btnQuaPhai";
        this.btnQuaPhai.Size = new System.Drawing.Size(55, 32);
        this.btnQuaPhai.TabIndex = 1;
        this.btnQuaPhai.Text = ">";
        this.btnQuaPhai.UseVisualStyleBackColor = true;
        this.btnQuaPhai.Click += new System.EventHandler(this.BtnQuaPhai_Click);

        // btnQuaPhaiAll
        this.btnQuaPhaiAll.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
        this.btnQuaPhaiAll.Location = new System.Drawing.Point(210, 85);
        this.btnQuaPhaiAll.Name = "btnQuaPhaiAll";
        this.btnQuaPhaiAll.Size = new System.Drawing.Size(55, 32);
        this.btnQuaPhaiAll.TabIndex = 2;
        this.btnQuaPhaiAll.Text = ">>";
        this.btnQuaPhaiAll.UseVisualStyleBackColor = true;
        this.btnQuaPhaiAll.Click += new System.EventHandler(this.BtnQuaPhaiAll_Click);

        // btnQuaTrai
        this.btnQuaTrai.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
        this.btnQuaTrai.Location = new System.Drawing.Point(210, 130);
        this.btnQuaTrai.Name = "btnQuaTrai";
        this.btnQuaTrai.Size = new System.Drawing.Size(55, 32);
        this.btnQuaTrai.TabIndex = 3;
        this.btnQuaTrai.Text = "<";
        this.btnQuaTrai.UseVisualStyleBackColor = true;
        this.btnQuaTrai.Click += new System.EventHandler(this.BtnQuaTrai_Click);

        // btnQuaTraiAll
        this.btnQuaTraiAll.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
        this.btnQuaTraiAll.Location = new System.Drawing.Point(210, 175);
        this.btnQuaTraiAll.Name = "btnQuaTraiAll";
        this.btnQuaTraiAll.Size = new System.Drawing.Size(55, 32);
        this.btnQuaTraiAll.TabIndex = 4;
        this.btnQuaTraiAll.Text = "<<";
        this.btnQuaTraiAll.UseVisualStyleBackColor = true;
        this.btnQuaTraiAll.Click += new System.EventHandler(this.BtnQuaTraiAll_Click);

        // lst_Phai
        this.lst_Phai.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
        this.lst_Phai.FormattingEnabled = true;
        this.lst_Phai.ItemHeight = 18;
        this.lst_Phai.Location = new System.Drawing.Point(285, 30);
        this.lst_Phai.Name = "lst_Phai";
        this.lst_Phai.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
        this.lst_Phai.Size = new System.Drawing.Size(160, 256);
        this.lst_Phai.TabIndex = 5;

        // btnChuyenTuyY
        this.btnChuyenTuyY.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
        this.btnChuyenTuyY.Location = new System.Drawing.Point(30, 305);
        this.btnChuyenTuyY.Name = "btnChuyenTuyY";
        this.btnChuyenTuyY.Size = new System.Drawing.Size(415, 36);
        this.btnChuyenTuyY.TabIndex = 6;
        this.btnChuyenTuyY.Text = "Chuyển tùy ý";
        this.btnChuyenTuyY.UseVisualStyleBackColor = true;
        this.btnChuyenTuyY.Click += new System.EventHandler(this.BtnChuyenTuyY_Click);

        // FrmListBox
        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(478, 360);
        this.Controls.Add(this.btnChuyenTuyY);
        this.Controls.Add(this.lst_Phai);
        this.Controls.Add(this.btnQuaTraiAll);
        this.Controls.Add(this.btnQuaTrai);
        this.Controls.Add(this.btnQuaPhaiAll);
        this.Controls.Add(this.btnQuaPhai);
        this.Controls.Add(this.lst_Trai);
        this.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.Name = "FrmListBox";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Sử dụng listbox";
        this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmListBox_FormClosing);
        this.Load += new System.EventHandler(this.FrmListBox_Load);
        this.ResumeLayout(false);
    }
}
