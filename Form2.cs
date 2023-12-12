using prj2.Classes;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
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
    int _r2 = 20;                  // 半徑，直徑
    private Ball[] _balls = new Ball[10];   // 10 顆球的陣列
    //BufferedGraphicsContext currentContext;
    //BufferedGraphics gBuffer;
    int _width = 0, _height = 0;  // 球桌  寬，高
    int _b0id, _b1id;   // 用來記錄 需 拉回的球 的號碼
    Pen penRed, penGreen, penBlue;   // 宣告 3 支筆，碰撞後  暫停時 就要繪圖，固定宣告省事

    /// <summary>
    /// Constructors.
    /// </summary>
    /// <param name="user"></param>
    public Form2(User user)
    {
      InitializeComponent();

      _user = user;
      _width = pnlTable.Width;
      _height = pnlTable.Height;

      // 表單 建構者 中 將 3支筆 new, 設定 好
      penRed = new Pen(Color.Red, 3);  //（顏色 紅，線寬度3像素）
      penGreen = new Pen(Color.Green, 3);  //（顏色 綠，線寬度3像素）
      penBlue = new Pen(Color.Blue, 3);  //（顏色 藍，線寬度3像素）
      penRed.EndCap = penGreen.EndCap = penBlue.EndCap = LineCap.ArrowAnchor;  // 箭頭尾端

      //currentContext = BufferedGraphicsManager.Current;
      //gBuffer = currentContext.Allocate(this.pnlTable.CreateGraphics(), new Rectangle(0, 0, _width, _height));
      //_g = gBuffer.Graphics;
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
      //繪 背景
      //_g.Clear(pnlTable.BackColor);

      for (int i = 0; i < 10; i++)
        _balls[i].draw(e.Graphics);

      // 畫指向 0號球(母球) 的球桿
      //_balls[0].drawStick(e.Graphics);

      // 0號球停止時才畫指向 0號球(母球) 的球桿
      if (_balls[0].Speed < 0.0001)
        _balls[0].drawStick(e.Graphics);

      // 之後 送出 gBuffer 到繪圖裝置
      //gBuffer.Render(e.Graphics);
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
        _balls[i].rebound(_width, _height);

        // 應用摩擦力
        if (i != 0)  // 排除母球
        {
          double friction = 0.05;
          _balls[i].setFriction(friction);
        }

        sum_spd += _balls[i].Speed;

        // 碰撞偵測
        for (int j = i + 1; j < 10; j++)
        {
          hit(_balls[i], _balls[j]);
        }
      }
    
      // 所有球都停了，停止計時器
      if (sum_spd <= 0.001)
      {  
        timer1.Stop();
        pnlTable.Refresh();
      }
    }
    #endregion

    #region method
    private void hit(Ball b0, Ball b1)
    {
      // b1 hit  b0  速度快的撞慢的
      if (b0._spd < b1._spd)
      {
        Ball t = b0;     //  交換球，讓速度快的球成為 b0
        b0 = b1;
        b1 = t;
      }

      double dx = b1._x - b0._x;
      double dy = b1._y - b0._y;

      if (Math.Abs(dx) <= _r2 && Math.Abs(dy) <= _r2)
      {
        // 在已經偵測到 碰撞裡
        if (chkStop.Checked)
        {
          // 有打勾，計時暫停
          timer1.Stop();
          pnlTable.Refresh();  // 顯示球碰撞後重疊的情形

          // 等按 pullBackButton按鈕 才拉回
          // 記錄需 拉回的球 的號碼 給 pullBack 副程式用
          _b0id = b0.Id;
          _b1id = b1.Id;
        }
        else
        {
          //拉回到正好接觸點 後， 再去算碰撞角度 才會正確
          pullBack(b0, b1);  // 沒暫停，不等 按按鈕 就拉回
        
          // X 坐標間差距 < 球直徑
          // 而且　　y坐標間差距 < 球直徑
          double ang = Math.Atan2(dy, dx);   //  球b0 中心 到 球b1 中心 連線方向
          b1.setAng(ang);     //  球b1 被撞後方向
          b0.setAng(ang + Math.PI / 2.0);   //  球b0  碰撞 b1 后 和 b1 的夾角 90° 

          double spd_average = (b0._spd + b1._spd) / 2.0;
          b0._spd = b1._spd = spd_average;    // 碰撞後 先大略平均分配 兩球的速度
                                              // 白球速度 == 紅球速度 == 兩球的速度 和 /2
        }
      }
    }

    private void pullBack(Ball b0, Ball b1)
    {
      //用整數距離大概 回拉趨近（小於1個 像素 也無法顯示位置區別）
      int r2r2 = _r2 * _r2;    // 2顆球的距離的平方，省略開根號用
      int r4 = 2 * _r2;       // 2顆球的距離	
      for (int px = 0; px < r4; px++) // 最多回拉2顆球的距離
                                      // 平方值 相比，可以省略開根號，減少運算
        if (((b0._x - b1._x) * (b0._x - b1._x) + (b0._y - b1._y) * (b0._y - b1._y)) <= r2r2)
        { // 距離還太小，繼續回拉
          b0._x -= b0.CosA;
          b0._y -= b0.SinA;  // 每次往回移動量  == 1 像素
        }
        else break;
    }

    // 都 從 b0 球心 開始劃線，才容易看出平行4邊型
    private void ball_Line(Ball b0, Ball bx, Pen p)
    {
      double x1 = b0._x;
      double y1 = b0._y;   //  起點坐標  為 b0 球心

      double x2 = x1 + 7 * bx._spd * bx.CosA;
      double y2 = y1 + 7 * bx._spd * bx.SinA;  // spd 為 球bx的速度, 線長度 為7倍 spd

      _g.DrawLine(p, (int)x1, (int)y1, (int)x2, (int)y2);  // 從點（x1,y1）畫到 （x2,y2），箭頭在尾端（x2,y2）
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

    private void pullBackButton_Click(object sender, EventArgs e)
    {
      // 行進方向(紅色)
      pullBack(_balls[0], _balls[_b1id]);
      pnlTable.Refresh();
      ball_Line(_balls[0], _balls[0], penRed);

      // 碰撞 後 先大略平均分配 兩球的速度
      double spd_average = (_balls[0].Speed + _balls[_b1id].Speed) / 2.0;
      _balls[0].setSpeed(spd_average);
      _balls[_b1id].setSpeed(spd_average);

      // 球心互連(綠色)
      double dx = _balls[_b1id].X - _balls[0].X;
      double dy = _balls[_b1id].Y - _balls[0].Y;
      double ang = Math.Atan2(dy, dx);
      _balls[_b1id].setAng(ang);
      ball_Line(_balls[0], _balls[_b1id], penGreen);

      // 白球行進方向(藍色)
      _balls[0].setAng(ang + Math.PI / 2.0);
      ball_Line(_balls[0], _balls[0], penBlue);
    }

    /// <summary>
    /// 回首頁.
    /// </summary>
    private void btnLogOut_Click(object sender, EventArgs e)
    {
      this.Hide();
      Owner.Show();
    }

    /// <summary>
    /// 碰撞停止勾選框.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void chkStop_CheckedChanged(object sender, EventArgs e)
    {
      if (!chkStop.Checked)
        timer1.Start();
    }
  }
}
