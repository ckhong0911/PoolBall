using prj2.Classes;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace prj2
{
    public partial class Form2 : Form
    {
        static Graphics g;	           // 繪圖裝置（一個就夠了）
        static int r = 10, r2 = 20;    // 半徑，直徑
        static double fr = 0;          // 摩擦力

        /// <summary>
        /// 球類別.
        /// </summary>
        class Ball
        {
            int id;                        // 球編號
            public double x = 0, y = 0;    // 球心座標
            Color c;                       // 球顏色
            SolidBrush br;                 // 刷子（畫球用）
            private double ang = 0;        // ex4：球 行進角度
            public double cosA, sinA;      // ex4：coSine 行進角度, Sine 行進角度
            public double spd = 0;         // ex5：球行進速度

            /// <summary>
            /// 建構者.
            /// </summary>
            /// <param name="bx">球心 x 坐標.</param>
            /// <param name="by">球心 y 坐標.</param>
            /// <param name="cc">球顏色.</param>
            /// <param name="i">球編號.</param>
            public Ball(int bx, int by, Color cc, int i)
            {
                x = bx;
                y = by;
                c = cc;
                br = new SolidBrush(cc);     // 球顏色的刷子
                id = i;
            }

            /// <summary>
            /// (練習3)畫球物件.
            /// </summary>
            public void draw(Graphics g)
            {
                // 畫橢圓（球刷子，左上角 坐標，直徑寬，直徑高）
                g.FillEllipse(br, (int)(x - r), (int)(y - r), r2, r2);
            }

            /// <summary>
            /// (練習4)角度改變.
            /// </summary>
            /// <param name="_ang"></param>
            public void setAng(double _ang)
            {
                ang = _ang;            // 存新角度
                cosA = Math.Cos(ang);  // 重算 coSine
                sinA = Math.Sin(ang);  // 重算 Sine
            }

            /// <summary>
            /// (練習4)畫球桿.
            /// </summary>
            public void drawStick(Graphics g)
            {
                double r12 = 12 * r;
                Pen skyBluePen = new Pen(Brushes.DeepSkyBlue);    // 宣告 + new 深藍色畫筆
                skyBluePen.Width = 3.0F;    // 改變畫筆寬度
                g.DrawLine(skyBluePen,      // 深藍色畫筆
                     (float)(x - r12 * cosA), (float)(y - r12 * sinA),   //  12 倍大的 同心圓周上的點
                     (float)(x - r * cosA), (float)(y - r * sinA)        //  球 圓周上的點
                );                                                       // - r12   -r , 使球杆 畫在滑鼠點的另一邊
            }

            /// <summary>
            /// (練習5)移動球.
            /// </summary>
            public void move()
            {
                //  速度 > 0 才移動
                if (spd > 0)
                {  
                    x += spd * cosA;   //  x 方向分量
                    y += spd * sinA;   //  y 方向分量
                    spd -= fr;         //  速度依摩擦力大小遞減
                }
                //  避免 < 0 而反向移動
                else spd = 0;
            }
        }

        Ball[] balls = new Ball[10];   // 10 顆球的陣列宣告

        /// <summary>
        /// 遊戲主畫面.
        /// </summary>
        public Form2()
        {
            InitializeComponent();

            g = pnlTable.CreateGraphics();     // 繪圖裝置初始化
            // new 每個球，ball 建構者參數見 work_note3 說明
            for (int i = 1; i < 10; i++)
                balls[i] = new Ball(200, i * (r2 + 10) + 90, Color.FromArgb(255, (i * 100) % 256, (i * 50) % 256, (i * 25) % 256), i);

            // 0號球(母球)，白色，放右邊中間
            balls[0] = new Ball(600, 230, Color.FromArgb(255, 255, 255, 255), 0);

            // ex4：0號球(母球)角度改變為 45 度
            balls[0].setAng(Math.PI / 4);
        }

        #region Panel事件
        /// <summary>
        /// Panel Paint(繪圖)事件.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlTable_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < 10; i++)    // 10 顆球
                balls[i].draw(e.Graphics);  // 每個球畫自己

            // ex4：畫指向0號球(母球)的球桿(練習5要註解掉，使用下列if判斷式)
            //balls[0].drawStick(e.Graphics);   

            // (練習5)0號球停止時才畫指向0號球(母球)的球桿
            if (balls[0].spd < 0.0001)
                balls[0].drawStick(e.Graphics);
        }

        /// <summary>
        /// (練習4)球杆，指向滑鼠點擊點.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlTable_MouseDown(object sender, MouseEventArgs e)
        {
            double a = Math.Atan2(e.Y - balls[0].y, e.X - balls[0].x);   // e:滑鼠點擊處坐標
            balls[0].setAng(a);   // 存入母球行進角度
            pnlTable.Refresh();   // 重新繪畫轉動過的球桿
            g.DrawRectangle(Pens.HotPink, e.X - 2, e.Y - 2, 4, 4);   // 點擊點畫小方塊
        }
        #endregion

        /// <summary>
        /// 計時器.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            double sum_spd = 0;    // 球速度加總
            pnlTable.Refresh();    // 呼叫panel1_Paint 事件處理副程式
            for (int i = 0; i < 10; i++)
            {
                balls[i].move();   // 移動球
                sum_spd += balls[i].spd;
            }

            // 所有球都停了
            if (sum_spd <= 0.001)
            {  
                timer1.Stop();	   // 停止計時器
                pnlTable.Refresh();
            }
        }

        #region 練習5
        private void hit_button_Click(object sender, EventArgs e)
        {
            // 每次擊球，重新初始化打擊力，摩擦力
            balls[0].spd = vScrollBar1.Maximum - vScrollBar1.Value; // 母球 加 速度
            fr = (vScrollBar2.Maximum - vScrollBar2.Value) / 50.0;  // 摩擦力
            timer1.Enabled = true;  // 開始定時 呼叫timer1_Tick
        }
        #endregion

        #region 練習2
        private void Form2_Load(object sender, EventArgs e)
        {
            lblName.Text = "歡迎━" + ((Form1)Owner).txtAccount.Text + " 你好";
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Owner.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            Owner.Show();
        }
        #endregion
    }
}
