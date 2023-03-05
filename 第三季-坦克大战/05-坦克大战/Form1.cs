using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _05_坦克大战.Properties;

namespace _05_坦克大战
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;//窗口居中
            //this.StartPosition = FormStartPosition.Manual;
            //this.Location = new Point(400, 300);
            //GDI Craphics Device Interface//画图片            
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            #region 怎么绘制线和字符串
            //Pen P = new Pen(Color.Green);

            //g.DrawLine(P, new Point(50, 50), new Point(100, 100));

            //g.DrawString("狗蛋",
            //    new Font("宋体", 20),
            //    new SolidBrush(Color.Red),
            //    new Point(100, 100));
            #endregion
            Image image = Properties.Resources.Boss;
            Bitmap bm = Properties.Resources.Star1;
            bm.MakeTransparent(Color.Black);//让这个图片的黑色表透明

            g.DrawImage(image, new Point(50,50));
            g.DrawImage(bm, 200, 200);
        }
    }
}
    