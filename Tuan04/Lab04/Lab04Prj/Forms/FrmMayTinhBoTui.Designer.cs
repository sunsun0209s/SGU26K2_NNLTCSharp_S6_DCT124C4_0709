namespace Lab04Prj.Forms;

partial class FrmMayTinhBoTui
{
    private System.ComponentModel.IContainer components = null!;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.TextBox txtDisplay;
    private System.Windows.Forms.Button btn7;
    private System.Windows.Forms.Button btn8;
    private System.Windows.Forms.Button btn9;
    private System.Windows.Forms.Button btnChia;
    private System.Windows.Forms.Button btn4;
    private System.Windows.Forms.Button btn5;
    private System.Windows.Forms.Button btn6;
    private System.Windows.Forms.Button btnNhan;
    private System.Windows.Forms.Button btn1;
    private System.Windows.Forms.Button btn2;
    private System.Windows.Forms.Button btn3;
    private System.Windows.Forms.Button btnTru;
    private System.Windows.Forms.Button btn0;
    private System.Windows.Forms.Button btnC;
    private System.Windows.Forms.Button btnBang;
    private System.Windows.Forms.Button btnCong;

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
        this.txtDisplay = new System.Windows.Forms.TextBox();
        this.btn7 = new System.Windows.Forms.Button();
        this.btn8 = new System.Windows.Forms.Button();
        this.btn9 = new System.Windows.Forms.Button();
        this.btnChia = new System.Windows.Forms.Button();
        this.btn4 = new System.Windows.Forms.Button();
        this.btn5 = new System.Windows.Forms.Button();
        this.btn6 = new System.Windows.Forms.Button();
        this.btnNhan = new System.Windows.Forms.Button();
        this.btn1 = new System.Windows.Forms.Button();
        this.btn2 = new System.Windows.Forms.Button();
        this.btn3 = new System.Windows.Forms.Button();
        this.btnTru = new System.Windows.Forms.Button();
        this.btn0 = new System.Windows.Forms.Button();
        this.btnC = new System.Windows.Forms.Button();
        this.btnBang = new System.Windows.Forms.Button();
        this.btnCong = new System.Windows.Forms.Button();
        this.SuspendLayout();

        // lblTitle
        this.lblTitle.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
        this.lblTitle.ForeColor = System.Drawing.Color.Red;
        this.lblTitle.Location = new System.Drawing.Point(15, 10);
        this.lblTitle.Name = "lblTitle";
        this.lblTitle.Size = new System.Drawing.Size(265, 30);
        this.lblTitle.TabIndex = 0;
        this.lblTitle.Text = "Máy Tính Bỏ Túi";
        this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

        // txtDisplay
        this.txtDisplay.BackColor = System.Drawing.Color.White;
        this.txtDisplay.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold);
        this.txtDisplay.Location = new System.Drawing.Point(20, 50);
        this.txtDisplay.Name = "txtDisplay";
        this.txtDisplay.ReadOnly = true;
        this.txtDisplay.Size = new System.Drawing.Size(255, 32);
        this.txtDisplay.TabIndex = 1;
        this.txtDisplay.Text = "0";
        this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

        // Row 1
        this.btn7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
        this.btn7.Location = new System.Drawing.Point(20, 100);
        this.btn7.Name = "btn7";
        this.btn7.Size = new System.Drawing.Size(57, 50);
        this.btn7.TabIndex = 2;
        this.btn7.Text = "7";
        this.btn7.UseVisualStyleBackColor = true;
        this.btn7.Click += new System.EventHandler(this.BtnDigit_Click);

        this.btn8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
        this.btn8.Location = new System.Drawing.Point(86, 100);
        this.btn8.Name = "btn8";
        this.btn8.Size = new System.Drawing.Size(57, 50);
        this.btn8.TabIndex = 3;
        this.btn8.Text = "8";
        this.btn8.UseVisualStyleBackColor = true;
        this.btn8.Click += new System.EventHandler(this.BtnDigit_Click);

        this.btn9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
        this.btn9.Location = new System.Drawing.Point(152, 100);
        this.btn9.Name = "btn9";
        this.btn9.Size = new System.Drawing.Size(57, 50);
        this.btn9.TabIndex = 4;
        this.btn9.Text = "9";
        this.btn9.UseVisualStyleBackColor = true;
        this.btn9.Click += new System.EventHandler(this.BtnDigit_Click);

        this.btnChia.BackColor = System.Drawing.Color.LightSkyBlue;
        this.btnChia.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
        this.btnChia.Location = new System.Drawing.Point(218, 100);
        this.btnChia.Name = "btnChia";
        this.btnChia.Size = new System.Drawing.Size(57, 50);
        this.btnChia.TabIndex = 5;
        this.btnChia.Text = "/";
        this.btnChia.UseVisualStyleBackColor = false;
        this.btnChia.Click += new System.EventHandler(this.BtnOp_Click);

        // Row 2
        this.btn4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
        this.btn4.Location = new System.Drawing.Point(20, 159);
        this.btn4.Name = "btn4";
        this.btn4.Size = new System.Drawing.Size(57, 50);
        this.btn4.TabIndex = 6;
        this.btn4.Text = "4";
        this.btn4.UseVisualStyleBackColor = true;
        this.btn4.Click += new System.EventHandler(this.BtnDigit_Click);

        this.btn5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
        this.btn5.Location = new System.Drawing.Point(86, 159);
        this.btn5.Name = "btn5";
        this.btn5.Size = new System.Drawing.Size(57, 50);
        this.btn5.TabIndex = 7;
        this.btn5.Text = "5";
        this.btn5.UseVisualStyleBackColor = true;
        this.btn5.Click += new System.EventHandler(this.BtnDigit_Click);

        this.btn6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
        this.btn6.Location = new System.Drawing.Point(152, 159);
        this.btn6.Name = "btn6";
        this.btn6.Size = new System.Drawing.Size(57, 50);
        this.btn6.TabIndex = 8;
        this.btn6.Text = "6";
        this.btn6.UseVisualStyleBackColor = true;
        this.btn6.Click += new System.EventHandler(this.BtnDigit_Click);

        this.btnNhan.BackColor = System.Drawing.Color.LightSkyBlue;
        this.btnNhan.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
        this.btnNhan.Location = new System.Drawing.Point(218, 159);
        this.btnNhan.Name = "btnNhan";
        this.btnNhan.Size = new System.Drawing.Size(57, 50);
        this.btnNhan.TabIndex = 9;
        this.btnNhan.Text = "*";
        this.btnNhan.UseVisualStyleBackColor = false;
        this.btnNhan.Click += new System.EventHandler(this.BtnOp_Click);

        // Row 3
        this.btn1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
        this.btn1.Location = new System.Drawing.Point(20, 218);
        this.btn1.Name = "btn1";
        this.btn1.Size = new System.Drawing.Size(57, 50);
        this.btn1.TabIndex = 10;
        this.btn1.Text = "1";
        this.btn1.UseVisualStyleBackColor = true;
        this.btn1.Click += new System.EventHandler(this.BtnDigit_Click);

        this.btn2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
        this.btn2.Location = new System.Drawing.Point(86, 218);
        this.btn2.Name = "btn2";
        this.btn2.Size = new System.Drawing.Size(57, 50);
        this.btn2.TabIndex = 11;
        this.btn2.Text = "2";
        this.btn2.UseVisualStyleBackColor = true;
        this.btn2.Click += new System.EventHandler(this.BtnDigit_Click);

        this.btn3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
        this.btn3.Location = new System.Drawing.Point(152, 218);
        this.btn3.Name = "btn3";
        this.btn3.Size = new System.Drawing.Size(57, 50);
        this.btn3.TabIndex = 12;
        this.btn3.Text = "3";
        this.btn3.UseVisualStyleBackColor = true;
        this.btn3.Click += new System.EventHandler(this.BtnDigit_Click);

        this.btnTru.BackColor = System.Drawing.Color.LightSkyBlue;
        this.btnTru.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
        this.btnTru.Location = new System.Drawing.Point(218, 218);
        this.btnTru.Name = "btnTru";
        this.btnTru.Size = new System.Drawing.Size(57, 50);
        this.btnTru.TabIndex = 13;
        this.btnTru.Text = "-";
        this.btnTru.UseVisualStyleBackColor = false;
        this.btnTru.Click += new System.EventHandler(this.BtnOp_Click);

        // Row 4
        this.btn0.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
        this.btn0.Location = new System.Drawing.Point(20, 277);
        this.btn0.Name = "btn0";
        this.btn0.Size = new System.Drawing.Size(57, 50);
        this.btn0.TabIndex = 14;
        this.btn0.Text = "0";
        this.btn0.UseVisualStyleBackColor = true;
        this.btn0.Click += new System.EventHandler(this.BtnDigit_Click);

        this.btnC.BackColor = System.Drawing.Color.MistyRose;
        this.btnC.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
        this.btnC.Location = new System.Drawing.Point(86, 277);
        this.btnC.Name = "btnC";
        this.btnC.Size = new System.Drawing.Size(57, 50);
        this.btnC.TabIndex = 15;
        this.btnC.Text = "C";
        this.btnC.UseVisualStyleBackColor = false;
        this.btnC.Click += new System.EventHandler(this.BtnC_Click);

        this.btnBang.BackColor = System.Drawing.Color.LightGreen;
        this.btnBang.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
        this.btnBang.Location = new System.Drawing.Point(152, 277);
        this.btnBang.Name = "btnBang";
        this.btnBang.Size = new System.Drawing.Size(57, 50);
        this.btnBang.TabIndex = 16;
        this.btnBang.Text = "=";
        this.btnBang.UseVisualStyleBackColor = false;
        this.btnBang.Click += new System.EventHandler(this.BtnBang_Click);

        this.btnCong.BackColor = System.Drawing.Color.LightSkyBlue;
        this.btnCong.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
        this.btnCong.Location = new System.Drawing.Point(218, 277);
        this.btnCong.Name = "btnCong";
        this.btnCong.Size = new System.Drawing.Size(57, 50);
        this.btnCong.TabIndex = 17;
        this.btnCong.Text = "+";
        this.btnCong.UseVisualStyleBackColor = false;
        this.btnCong.Click += new System.EventHandler(this.BtnOp_Click);

        // FrmMayTinhBoTui
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(294, 351);
        this.Controls.Add(this.btnCong);
        this.Controls.Add(this.btnBang);
        this.Controls.Add(this.btnC);
        this.Controls.Add(this.btn0);
        this.Controls.Add(this.btnTru);
        this.Controls.Add(this.btn3);
        this.Controls.Add(this.btn2);
        this.Controls.Add(this.btn1);
        this.Controls.Add(this.btnNhan);
        this.Controls.Add(this.btn6);
        this.Controls.Add(this.btn5);
        this.Controls.Add(this.btn4);
        this.Controls.Add(this.btnChia);
        this.Controls.Add(this.btn9);
        this.Controls.Add(this.btn8);
        this.Controls.Add(this.btn7);
        this.Controls.Add(this.txtDisplay);
        this.Controls.Add(this.lblTitle);
        this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
        this.MaximizeBox = false;
        this.Name = "FrmMayTinhBoTui";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Máy Tính Bỏ Túi";
        this.ResumeLayout(false);
        this.PerformLayout();
    }
}
