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

        /// <summary>
        /// 球類別.
        /// </summary>
        class Ball
        {
            int id;                        // 球編號
            public double x = 0, y = 0;    // 球心座標
            Color c;                       // 球顏色
            SolidBrush br;                 // 刷子（畫球用）

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
            /// 畫球物件.
            /// </summary>
            public void draw(Graphics g)
            {
                // 畫橢圓（球刷子，左上角 坐標，直徑寬，直徑高）
                g.FillEllipse(br, (int)(x - r), (int)(y - r), r2, r2);
            }
        }

        Ball[] balls = new Ball[10];   // 10 顆球的陣列宣告

        /// <summary>
        /// 遊戲主畫面.
        /// </summary>
        public Form2()
        {
            InitializeComponent();

            g = pnlTable.CreateGraphics();     // 繪圖裝置 初始化
            // new 每個球，ball 建構者參數見 work_note3 說明
            for (int i = 1; i < 10; i++)
                balls[i] = new Ball(200, i * (r2 + 10) + 90, Color.FromArgb(255, (i * 100) % 256, (i * 50) % 256, (i * 25) % 256), i);

            // 0號球(母球)， 白色，放右邊中間
            balls[0] = new Ball(600, 230, Color.FromArgb(255, 255, 255, 255), 0);
        }

        /// <summary>
        /// Panel Paint(繪圖)事件.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pnlTable_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < 10; i++)    // 10 顆球
                balls[i].draw(e.Graphics);  // 每個球畫自己
        }

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
