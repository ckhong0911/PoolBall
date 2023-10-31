namespace prj2
{
  partial class Form2
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.btnLogOut = new Guna.UI2.WinForms.Guna2GradientButton();
      this.lblName = new System.Windows.Forms.Label();
      this.btnHit = new System.Windows.Forms.Button();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
      this.vScrollBar2 = new System.Windows.Forms.VScrollBar();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.pnlTable = new Guna.UI2.WinForms.Guna2Panel();
      this.timer2 = new System.Windows.Forms.Timer(this.components);
      this.SuspendLayout();
      // 
      // btnLogOut
      // 
      this.btnLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnLogOut.Animated = true;
      this.btnLogOut.AutoRoundedCorners = true;
      this.btnLogOut.BorderRadius = 19;
      this.btnLogOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
      this.btnLogOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
      this.btnLogOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
      this.btnLogOut.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
      this.btnLogOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
      this.btnLogOut.FillColor = System.Drawing.Color.RoyalBlue;
      this.btnLogOut.FillColor2 = System.Drawing.Color.Blue;
      this.btnLogOut.Font = new System.Drawing.Font("Segoe UI", 12F);
      this.btnLogOut.ForeColor = System.Drawing.Color.White;
      this.btnLogOut.Location = new System.Drawing.Point(853, 498);
      this.btnLogOut.Name = "btnLogOut";
      this.btnLogOut.Size = new System.Drawing.Size(136, 41);
      this.btnLogOut.TabIndex = 58;
      this.btnLogOut.Text = "回首頁";
      this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
      // 
      // lblName
      // 
      this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.lblName.AutoSize = true;
      this.lblName.BackColor = System.Drawing.Color.Transparent;
      this.lblName.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblName.ForeColor = System.Drawing.Color.Black;
      this.lblName.Location = new System.Drawing.Point(23, 494);
      this.lblName.Name = "lblName";
      this.lblName.Size = new System.Drawing.Size(122, 45);
      this.lblName.TabIndex = 64;
      this.lblName.Text = "使用者";
      // 
      // btnHit
      // 
      this.btnHit.BackColor = System.Drawing.SystemColors.Control;
      this.btnHit.FlatStyle = System.Windows.Forms.FlatStyle.System;
      this.btnHit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnHit.Location = new System.Drawing.Point(866, 22);
      this.btnHit.Name = "btnHit";
      this.btnHit.Size = new System.Drawing.Size(123, 41);
      this.btnHit.TabIndex = 65;
      this.btnHit.Text = "Hit";
      this.btnHit.UseVisualStyleBackColor = false;
      this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
      // 
      // timer1
      // 
      this.timer1.Enabled = true;
      this.timer1.Interval = 25;
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // vScrollBar1
      // 
      this.vScrollBar1.Location = new System.Drawing.Point(869, 107);
      this.vScrollBar1.Name = "vScrollBar1";
      this.vScrollBar1.Size = new System.Drawing.Size(32, 362);
      this.vScrollBar1.SmallChange = 5;
      this.vScrollBar1.TabIndex = 66;
      // 
      // vScrollBar2
      // 
      this.vScrollBar2.Location = new System.Drawing.Point(954, 107);
      this.vScrollBar2.Name = "vScrollBar2";
      this.vScrollBar2.Size = new System.Drawing.Size(32, 362);
      this.vScrollBar2.SmallChange = 5;
      this.vScrollBar2.TabIndex = 67;
      // 
      // label1
      // 
      this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.label1.AutoSize = true;
      this.label1.BackColor = System.Drawing.Color.Transparent;
      this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.ForeColor = System.Drawing.Color.Black;
      this.label1.Location = new System.Drawing.Point(850, 75);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(67, 25);
      this.label1.TabIndex = 68;
      this.label1.Text = "Speed";
      // 
      // label2
      // 
      this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.label2.AutoSize = true;
      this.label2.BackColor = System.Drawing.Color.Transparent;
      this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.ForeColor = System.Drawing.Color.Black;
      this.label2.Location = new System.Drawing.Point(930, 75);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(80, 25);
      this.label2.TabIndex = 69;
      this.label2.Text = "Friction";
      // 
      // pnlTable
      // 
      this.pnlTable.BackColor = System.Drawing.Color.Teal;
      this.pnlTable.Location = new System.Drawing.Point(31, 22);
      this.pnlTable.Name = "pnlTable";
      this.pnlTable.Size = new System.Drawing.Size(801, 447);
      this.pnlTable.TabIndex = 70;
      this.pnlTable.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTable_Paint);
      this.pnlTable.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTable_MouseDown);
      // 
      // timer2
      // 
      this.timer2.Enabled = true;
      // 
      // Form2
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.WhiteSmoke;
      this.ClientSize = new System.Drawing.Size(1022, 561);
      this.Controls.Add(this.pnlTable);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.vScrollBar2);
      this.Controls.Add(this.vScrollBar1);
      this.Controls.Add(this.btnHit);
      this.Controls.Add(this.lblName);
      this.Controls.Add(this.btnLogOut);
      this.Name = "Form2";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "遊戲主畫面";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
      this.Load += new System.EventHandler(this.Form2_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    internal Guna.UI2.WinForms.Guna2GradientButton btnLogOut;
    internal System.Windows.Forms.Label lblName;
    private System.Windows.Forms.Button btnHit;
    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.VScrollBar vScrollBar1;
    private System.Windows.Forms.VScrollBar vScrollBar2;
    internal System.Windows.Forms.Label label1;
    internal System.Windows.Forms.Label label2;
    private Guna.UI2.WinForms.Guna2Panel pnlTable;
    private System.Windows.Forms.Timer timer2;
  }
}