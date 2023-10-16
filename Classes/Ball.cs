using System;
using System.Drawing;


namespace prj2.Classes
{
  internal class Ball
  {
    // Attributes.
    int _id;                        // 球編號
    int _r = 10, _r2 = 20;          // 半徑，直徑
    private double _x = 0, _y = 0;  // 球心 坐標
    Color _c;                       // 球顏色
    SolidBrush _br;                 // 刷子（畫球用）
    private double _ang = 0;        // 球 行進角度
    private double _cosA, _sinA;    // coSine 行進角度, Sine 行進角度
    private double _spd = 0;        // 球行進速度
    private double _fr = 0;         // 摩擦力

    /// <summary>
    /// Constructors.
    /// </summary>
    /// <param name="bx"></param>
    /// <param name="by"></param>
    /// <param name="cc"></param>
    /// <param name="i"></param>
    public Ball(int bx, int by, Color cc, int i)
    {
      _x = bx;                      // 球心 x 坐標
      _y = by;                      // 球心 y 坐標
      _c = cc;                      // 球顏色    
      _br = new SolidBrush(cc);     // 球顏色的刷子
      _id = i;                      // 球編號
    }


    /* =====Public attributes===== */
    /// <summary>
    /// 球心座標 X.
    /// </summary>
    public double X => _x;

    /// <summary>
    /// 球心座標 Y.
    /// </summary>
    public double Y => _y;

    /// <summary>
    /// 球行進速度.
    /// </summary>
    public double Speed => _spd;


    /* =====Method area===== */
    /// <summary>
    /// 畫球.
    /// </summary>
    public void draw(Graphics g)
    {
      // 畫橢圓（球刷子，左上角 坐標，直徑寬，直徑高）
      g.FillEllipse(_br, (int)(_x - _r), (int)(_y - _r), _r2, _r2);
    }

    /// <summary>
    /// 角度改變.
    /// </summary>
    /// <param name="ang"></param>
    public void setAng(double ang)
    {
      _ang = ang;                // 存新角度
      _cosA = Math.Cos(_ang);    // 重算 coSine
      _sinA = Math.Sin(_ang);    // 重算 Sine
    }

    /// <summary>
    /// 畫球桿.
    /// </summary>
    public void drawStick(Graphics g)
    {
      double r12 = 12 * _r;

      // 宣告 + new 深藍色畫筆
      Pen skyBluePen = new Pen(Brushes.DeepSkyBlue);

      // 改變畫筆寬度
      skyBluePen.Width = 3.0F;   

      // 深藍色畫筆
      g.DrawLine(skyBluePen,      
           (float)(_x - r12 * _cosA), (float)(_y - r12 * _sinA),    //  12倍大的同心圓周上的點
           (float)(_x - _r * _cosA), (float)(_y - _r * _sinA)       //  球圓周上的點 - r12 -r, 使球杆畫在滑鼠點的另一邊
      );
    }

    /// <summary>
    /// 移動球.
    /// </summary>
    public void move()
    {
      //  速度大於0才移動
      if (_spd > 0)
      {  
        _x += _spd * _cosA;   //  x 方向分量
        _y += _spd * _sinA;   //  y 方向分量
        _spd -= _fr;          //  速度依摩擦力大小遞減
      }
      // 避免小於0而反向移動
      else
        _spd = 0;  
    }

    /// <summary>
    /// 變更球行進速度.
    /// </summary>
    public void setSpeed(double speed)
    {
      _spd = speed;
    }

    /// <summary>
    /// 變更摩擦力.
    /// </summary>
    /// <param name="friction"></param>
    public void setFriction(double friction)
    {
      _fr = friction;
    }
  }
}
