using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _06_坦克大战_正式.Properties;

namespace _06_坦克大战_正式
{
    internal class MyTank:Movething
    {
        public MyTank(int x,int y,int speed)
        {
            this.X = x; 
            this.Y = y;
            this.Speed = speed;
            this.Dir = Direction.Up;
            BitmapUp = Resources.MyTankUp;
            BitmapDown = Resources.MyTankDown;
            BitmapRight = Resources.MyTankRight;
            BitmapLeft = Resources.MyTankLeft;
        } 
    }
}
