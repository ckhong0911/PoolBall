using System.Drawing;


namespace prj2.Classes
{
  internal class Ball
  {
    // Attributes.
    int _id;                        // 球編號
    public double _x = 0, _y = 0;   // 球心 坐標
    Color _c;                       // 球顏色
    SolidBrush _br;                 // 刷子（畫球用）

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

    /// <summary>
    /// 畫球.
    /// </summary>
    public void draw(Graphics g)
    {
      int r = 10, r2 = 20;    // 半徑，直徑

      //畫橢圓（球刷子，左上角 坐標，直徑寬，直徑高）
      g.FillEllipse(_br, (int)(_x - r), (int)(_y - r), r2, r2);
    }
  }
}
