namespace prj2
{
  partial class Form1
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.Panel_Top = new Guna.UI2.WinForms.Guna2Panel();
      this.Label3 = new System.Windows.Forms.Label();
      this.txtAccount = new Guna.UI2.WinForms.Guna2TextBox();
      this.Guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
      this.lblVersion = new System.Windows.Forms.Label();
      this.btnLogin = new Guna.UI2.WinForms.Guna2GradientButton();
      this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
      this.Guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
      this.label1 = new System.Windows.Forms.Label();
      this.Guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
      this.Guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
      this.AnimateWindow = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
      this.DragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
      this.label5 = new System.Windows.Forms.Label();
      this.Label4 = new System.Windows.Forms.Label();
      this.Panel_Top.SuspendLayout();
      this.Guna2Panel2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.Guna2CirclePictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // Panel_Top
      // 
      this.Panel_Top.BackColor = System.Drawing.Color.Transparent;
      this.Panel_Top.Controls.Add(this.Label3);
      this.Panel_Top.Location = new System.Drawing.Point(0, 0);
      this.Panel_Top.Name = "Panel_Top";
      this.Panel_Top.Size = new System.Drawing.Size(702, 48);
      this.Panel_Top.TabIndex = 2;
      // 
      // Label3
      // 
      this.Label3.AutoSize = true;
      this.Label3.BackColor = System.Drawing.Color.Transparent;
      this.Label3.Font = new System.Drawing.Font("Arial Narrow", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Label3.ForeColor = System.Drawing.Color.White;
      this.Label3.Location = new System.Drawing.Point(23, 12);
      this.Label3.Name = "Label3";
      this.Label3.Size = new System.Drawing.Size(189, 31);
      this.Label3.TabIndex = 17;
      this.Label3.Text = "FJCU - WinForm";
      // 
      // txtAccount
      // 
      this.txtAccount.Cursor = System.Windows.Forms.Cursors.IBeam;
      this.txtAccount.DefaultText = "root";
      this.txtAccount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
      this.txtAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
      this.txtAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
      this.txtAccount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
      this.txtAccount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
      this.txtAccount.Font = new System.Drawing.Font("Segoe UI", 11.25F);
      this.txtAccount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
      this.txtAccount.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtAccount.IconLeft")));
      this.txtAccount.IconLeftOffset = new System.Drawing.Point(12, 0);
      this.txtAccount.Location = new System.Drawing.Point(411, 350);
      this.txtAccount.Margin = new System.Windows.Forms.Padding(4);
      this.txtAccount.Name = "txtAccount";
      this.txtAccount.PasswordChar = '\0';
      this.txtAccount.PlaceholderText = "Login Account";
      this.txtAccount.SelectedText = "";
      this.txtAccount.Size = new System.Drawing.Size(226, 42);
      this.txtAccount.TabIndex = 55;
      this.txtAccount.TextOffset = new System.Drawing.Point(12, 0);
      this.txtAccount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAccount_KeyDown);
      // 
      // Guna2Panel2
      // 
      this.Guna2Panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Guna2Panel2.BackgroundImage")));
      this.Guna2Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.Guna2Panel2.Controls.Add(this.Panel_Top);
      this.Guna2Panel2.Controls.Add(this.lblVersion);
      this.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Left;
      this.Guna2Panel2.Location = new System.Drawing.Point(0, 0);
      this.Guna2Panel2.Name = "Guna2Panel2";
      this.Guna2Panel2.Size = new System.Drawing.Size(349, 570);
      this.Guna2Panel2.TabIndex = 58;
      // 
      // lblVersion
      // 
      this.lblVersion.AutoSize = true;
      this.lblVersion.BackColor = System.Drawing.Color.Transparent;
      this.lblVersion.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.lblVersion.Font = new System.Drawing.Font("Arial Narrow", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblVersion.ForeColor = System.Drawing.Color.White;
      this.lblVersion.Location = new System.Drawing.Point(0, 539);
      this.lblVersion.Name = "lblVersion";
      this.lblVersion.Size = new System.Drawing.Size(0, 31);
      this.lblVersion.TabIndex = 19;
      // 
      // btnLogin
      // 
      this.btnLogin.Animated = true;
      this.btnLogin.AutoRoundedCorners = true;
      this.btnLogin.BorderRadius = 19;
      this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
      this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
      this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
      this.btnLogin.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
      this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
      this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 12F);
      this.btnLogin.ForeColor = System.Drawing.Color.White;
      this.btnLogin.Location = new System.Drawing.Point(451, 479);
      this.btnLogin.Name = "btnLogin";
      this.btnLogin.Size = new System.Drawing.Size(155, 41);
      this.btnLogin.TabIndex = 57;
      this.btnLogin.Text = "進入遊戲";
      this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
      // 
      // txtPassword
      // 
      this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
      this.txtPassword.DefaultText = "";
      this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
      this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
      this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
      this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
      this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
      this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 11.25F);
      this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
      this.txtPassword.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtPassword.IconLeft")));
      this.txtPassword.IconLeftOffset = new System.Drawing.Point(12, 0);
      this.txtPassword.Location = new System.Drawing.Point(411, 409);
      this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
      this.txtPassword.Name = "txtPassword";
      this.txtPassword.PasswordChar = '*';
      this.txtPassword.PlaceholderText = "Login Password";
      this.txtPassword.SelectedText = "";
      this.txtPassword.Size = new System.Drawing.Size(226, 42);
      this.txtPassword.TabIndex = 56;
      this.txtPassword.TextOffset = new System.Drawing.Point(12, 0);
      this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
      // 
      // Guna2CirclePictureBox1
      // 
      this.Guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("Guna2CirclePictureBox1.Image")));
      this.Guna2CirclePictureBox1.ImageRotate = 0F;
      this.Guna2CirclePictureBox1.Location = new System.Drawing.Point(446, 145);
      this.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1";
      this.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
      this.Guna2CirclePictureBox1.Size = new System.Drawing.Size(159, 139);
      this.Guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.Guna2CirclePictureBox1.TabIndex = 62;
      this.Guna2CirclePictureBox1.TabStop = false;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.BackColor = System.Drawing.Color.Transparent;
      this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.ForeColor = System.Drawing.Color.Black;
      this.label1.Location = new System.Drawing.Point(457, 61);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(228, 65);
      this.label1.TabIndex = 61;
      this.label1.Text = "撞球遊戲";
      // 
      // Guna2ControlBox2
      // 
      this.Guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
      this.Guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
      this.Guna2ControlBox2.IconColor = System.Drawing.Color.Black;
      this.Guna2ControlBox2.Location = new System.Drawing.Point(586, 12);
      this.Guna2ControlBox2.Name = "Guna2ControlBox2";
      this.Guna2ControlBox2.Size = new System.Drawing.Size(55, 36);
      this.Guna2ControlBox2.TabIndex = 60;
      // 
      // Guna2ControlBox1
      // 
      this.Guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.Guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
      this.Guna2ControlBox1.IconColor = System.Drawing.Color.Black;
      this.Guna2ControlBox1.Location = new System.Drawing.Point(647, 12);
      this.Guna2ControlBox1.Name = "Guna2ControlBox1";
      this.Guna2ControlBox1.Size = new System.Drawing.Size(55, 36);
      this.Guna2ControlBox1.TabIndex = 59;
      // 
      // AnimateWindow
      // 
      this.AnimateWindow.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_BLEND;
      this.AnimateWindow.TargetForm = this;
      // 
      // DragControl
      // 
      this.DragControl.DockIndicatorTransparencyValue = 0.6D;
      this.DragControl.TargetControl = this.Panel_Top;
      this.DragControl.UseTransparentDrag = true;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.BackColor = System.Drawing.Color.Transparent;
      this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
      this.label5.Location = new System.Drawing.Point(370, 61);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(104, 65);
      this.label5.TabIndex = 64;
      this.label5.Text = "FJU";
      // 
      // Label4
      // 
      this.Label4.AutoSize = true;
      this.Label4.BackColor = System.Drawing.Color.Transparent;
      this.Label4.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Label4.ForeColor = System.Drawing.Color.Black;
      this.Label4.Location = new System.Drawing.Point(428, 287);
      this.Label4.Name = "Label4";
      this.Label4.Size = new System.Drawing.Size(199, 45);
      this.Label4.TabIndex = 63;
      this.Label4.Text = " 使用者登入";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(702, 570);
      this.Controls.Add(this.txtAccount);
      this.Controls.Add(this.Guna2Panel2);
      this.Controls.Add(this.btnLogin);
      this.Controls.Add(this.txtPassword);
      this.Controls.Add(this.Guna2CirclePictureBox1);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.Guna2ControlBox2);
      this.Controls.Add(this.Guna2ControlBox1);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.Label4);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Login";
      this.Panel_Top.ResumeLayout(false);
      this.Panel_Top.PerformLayout();
      this.Guna2Panel2.ResumeLayout(false);
      this.Guna2Panel2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.Guna2CirclePictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    internal Guna.UI2.WinForms.Guna2Panel Panel_Top;
    internal System.Windows.Forms.Label Label3;
    internal Guna.UI2.WinForms.Guna2TextBox txtAccount;
    internal Guna.UI2.WinForms.Guna2Panel Guna2Panel2;
    internal System.Windows.Forms.Label lblVersion;
    internal Guna.UI2.WinForms.Guna2GradientButton btnLogin;
    internal Guna.UI2.WinForms.Guna2TextBox txtPassword;
    internal Guna.UI2.WinForms.Guna2CirclePictureBox Guna2CirclePictureBox1;
    internal System.Windows.Forms.Label label1;
    internal Guna.UI2.WinForms.Guna2ControlBox Guna2ControlBox2;
    internal Guna.UI2.WinForms.Guna2ControlBox Guna2ControlBox1;
    private Guna.UI2.WinForms.Guna2AnimateWindow AnimateWindow;
    private Guna.UI2.WinForms.Guna2DragControl DragControl;
    internal System.Windows.Forms.Label label5;
    internal System.Windows.Forms.Label Label4;
  }
}