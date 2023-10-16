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

    #region form initialize
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
    #endregion

    #region panel event
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
      //_balls[0].drawStick(e.Graphics);

      // 0號球停止時才畫指向 0號球(母球) 的球桿
      if (_balls[0].Speed < 0.0001)
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
      double a = Math.Atan2(e.Y - _balls[0].Y, e.X - _balls[0].X);

      // 存入母球行進角度
      _balls[0].setAng(a);

      // 重新繪畫轉動過的球桿
      pnlTable.Refresh();

      // 點擊點畫小方塊
      _g.DrawRectangle(Pens.HotPink, e.X - 2, e.Y - 2, 4, 4);
    }

    /// <summary>
    /// 計時器事件.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void timer1_Tick(object sender, EventArgs e)
    {
      double sum_spd = 0;  // 球速度加總
      pnlTable.Refresh();  // 呼叫 pnlTable_Paint，主要是畫面顯示球在行進

      // 移動球
      for (int i = 0; i < 10; i++)
      {
        _balls[i].move();   
        sum_spd += _balls[i].Speed;
      }

      // 所有球都停了，停止計時器
      if (sum_spd <= 0.001)
      {  
        timer1.Stop();
        pnlTable.Refresh();
      }
    }
    #endregion

    /// <summary>
    /// 每次擊球，重新初始化打擊力，摩擦力.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnHit_Click(object sender, EventArgs e)
    {
      // 母球加速度
      _balls[0].setSpeed(vScrollBar1.Maximum - vScrollBar1.Value);

      // 摩擦力
      _balls[0].setFriction((vScrollBar2.Maximum - vScrollBar2.Value) / 50.0);

      // 啟動計時器
      timer1.Start();  
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
