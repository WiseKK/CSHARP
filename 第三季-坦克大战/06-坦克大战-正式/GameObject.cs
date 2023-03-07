using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _06_坦克大战_正式
{
    abstract class GameObject

    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        //等同于
        //private int X;
        //public int X { get { return x; } set { value = x; } }

        protected abstract Image GetImage();//获得图片

        public void DrawSelf()
        {
            Graphics g = GameFramework.g;
            g.DrawImage(GetImage(),X,Y);
        }
        public virtual void Update()
        {
            DrawSelf();
        }
    }
}
