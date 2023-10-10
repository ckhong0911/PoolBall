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
    private static Graphics _g;	            // 繪圖裝置
    public double _x = 0, _y = 0;           // 球心坐標
    int _r = 10, _r2 = 20;                  // 半徑，直徑
    private Ball[] _balls = new Ball[10];   // 10 顆球的陣列


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

      _g = pnlTable.CreateGraphics();     // 繪圖裝置 初始化

      // 實作 9 顆球
      for (int i = 1; i < 10; i++)
        _balls[i] = new Ball(200, i * (_r2 + 10) + 90, Color.FromArgb(255, (i * 100) % 256, (i * 50) % 256, (i * 25) % 256), i);

      // 0號球(母球)， 白色，放右邊中間
      _balls[0] = new Ball(600, 230, Color.FromArgb(255, 255, 255, 255), 0);

      //ex4： 0號球(母球) 角度改變為 45 度
      _balls[0].setAng(Math.PI / 4);  
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
        _balls[i].draw(e.Graphics);

      // 畫指向 0號球(母球) 的球桿
      _balls[0].drawStick(e.Graphics);     
    }

    /// <summary>
    /// 撞球桌上滑鼠點擊事件.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void pnlTable_MouseDown(object sender, MouseEventArgs e)
    {
      // 滑鼠點擊處坐標
      double a = Math.Atan2(e.Y - _balls[0]._y, e.X - _balls[0]._x); 

      // 存入母球行進角度
      _balls[0].setAng(a); 

      // 重新繪畫轉動過的球桿
      pnlTable.Refresh();

      // 點擊點畫小方塊
      _g.DrawRectangle(Pens.HotPink, e.X - 2, e.Y - 2, 4, 4); 
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
