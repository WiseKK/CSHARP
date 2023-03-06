using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _06_坦克大战_正式.Properties;

namespace _06_坦克大战_正式
{
    internal class MyTank:Movething
    {
        public bool Ismoving { get;set;}
        public MyTank(int x,int y,int speed)
        {
        Ismoving = false;
            this.X = x; 
            this.Y = y;
            this.Speed = speed;
            this.Dir = Direction.Up;
            BitmapUp = Resources.MyTankUp;
            BitmapDown = Resources.MyTankDown;
            BitmapRight = Resources.MyTankRight;
            BitmapLeft = Resources.MyTankLeft;
        }
        public  void KeyDown(KeyEventArgs args)
        {
            switch (args.KeyCode) 
            {
                case Keys.W:
                    Dir = Direction.Up;
                    Ismoving=true;
                    Y -= Speed;
                    break;
                case Keys.S:
                    Dir = Direction.Down;
                    Ismoving = true;
                    Y += Speed;
                    break;
                case Keys.A:
                    Dir = Direction.Left;
                    Ismoving = true;
                    X -= Speed;
                    break;
                case Keys.D:
                    Dir = Direction.Right;
                    Ismoving = true;
                    X += Speed;
                    break;            
            }
        }
        public void KeyUp(KeyEventArgs args)
        {
            switch (args.KeyCode)
            {
                case Keys.W:
                    Dir = Direction.Up;
                    Ismoving = false;
                    break;
                case Keys.S:
                    Dir = Direction.Down;
                    Ismoving = false;
                    break;
                case Keys.A:
                    Dir = Direction.Left;
                    Ismoving = false;
                    break;
                case Keys.D:
                    Dir = Direction.Right;
                    Ismoving = false;
                    break;
            }
        }
    }
}
