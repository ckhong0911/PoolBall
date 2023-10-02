using prj2.Classes;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace prj2
{
  public partial class Form2 : Form
  {
    /// <summary>
    /// Login user name.
    /// </summary>
    private readonly User _user;
    private static Graphics g;	            // 繪圖裝置
    int r = 10, r2 = 20;                    // 半徑，直徑
    private Ball[] balls = new Ball[10];    // 10 顆球的陣列

    /// <summary>
    /// Constructors.
    /// </summary>
    /// <param name="user"></param>
    public Form2(User user)
    {
      InitializeComponent();

      _user = user;
    }

    /// <summary>
    /// 視窗間傳資料.
    /// </summary>
    private void Form2_Load(object sender, EventArgs e)
    {
      lblName.Text = "歡迎━" + _user.Name;

      g = pnlTable.CreateGraphics();     //繪圖裝置 初始化

      // 實作 9 顆球
      for (int i = 1; i < 10; i++)
        balls[i] = new Ball(200, i * (r2 + 10) + 90, Color.FromArgb(255, (i * 100) % 256, (i * 50) % 256, (i * 25) % 256), i);

      // 0號球(母球)， 白色，放右邊中間
      balls[0] = new Ball(600, 230, Color.FromArgb(255, 255, 255, 255), 0);
    }

    /// <summary>
    /// 按 X 關閉 form2 回 form1 
    /// </summary>
    private void Form2_FormClosing(object sender, FormClosingEventArgs e)
    {
      Owner.Show();
    }

    /// <summary>
    /// 畫出10顆球.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void pnlTable_Paint(object sender, PaintEventArgs e)
    {
      for (int i = 0; i < 10; i++)
        balls[i].draw(e.Graphics);
    }

    /// <summary>
    /// 回首頁.
    /// </summary>
    private void btnLogOut_Click(object sender, EventArgs e)
    {
      this.Hide();
      Owner.Show();
    }
  }
}
