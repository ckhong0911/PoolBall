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
      this.pnlTable = new System.Windows.Forms.Panel();
      this.btnLogOut = new Guna.UI2.WinForms.Guna2GradientButton();
      this.lblName = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // pnlTable
      // 
      this.pnlTable.BackColor = System.Drawing.Color.Green;
      this.pnlTable.Location = new System.Drawing.Point(31, 22);
      this.pnlTable.Name = "pnlTable";
      this.pnlTable.Size = new System.Drawing.Size(801, 448);
      this.pnlTable.TabIndex = 0;
      this.pnlTable.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTable_Paint);
      this.pnlTable.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTable_MouseDown);
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
      this.btnLogOut.Location = new System.Drawing.Point(677, 498);
      this.btnLogOut.Name = "btnLogOut";
      this.btnLogOut.Size = new System.Drawing.Size(155, 41);
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
      // Form2
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.WhiteSmoke;
      this.ClientSize = new System.Drawing.Size(860, 561);
      this.Controls.Add(this.lblName);
      this.Controls.Add(this.btnLogOut);
      this.Controls.Add(this.pnlTable);
      this.Name = "Form2";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "遊戲主畫面";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
      this.Load += new System.EventHandler(this.Form2_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Panel pnlTable;
    internal Guna.UI2.WinForms.Guna2GradientButton btnLogOut;
    internal System.Windows.Forms.Label lblName;
  }
}