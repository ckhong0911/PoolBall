using prj2.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    /// 關閉表單後完整退出.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Login_FormClosed(object sender, FormClosedEventArgs e)
    {
      Environment.Exit(Environment.ExitCode);
    }

    /// <summary>
    /// 登入按鈕.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnLogin_Click(object sender, EventArgs e)
    {
      if (txtAccount.Text != "root" && txtPassword.Text != "root")
      {
        Alert.wBox("密碼錯誤", "Error");
        txtPassword.Text = "";
        txtPassword.Focus();
        return;
      }

      txtPassword.Text = "";
      User user = new User(txtAccount.Text);

      // 進入主畫面
      Form2 f2 = new Form2(user);
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

