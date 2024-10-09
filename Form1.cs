using System;
using System.Windows.Forms;

namespace prj2
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    /// <summary>
    /// 進入遊戲按鈕.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnLogin_Click(object sender, EventArgs e)
    {
      txtPassword.Text = ""; // 清除密碼

      // 進入遊戲主畫面
      Form2 f2 = new Form2();
      f2.Owner = this;
      this.Hide();      // 登入表單隱藏
      f2.ShowDialog();  // 執行強制回應視窗
    }

    // 帳號
    private void txtAccount_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
      {
        txtPassword.Focus();
      }
    }

    // 密碼
    private void txtPassword_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
      {
        btnLogin.Focus();
      }
    }
  }
}

