using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_坦克大战_正式
{
    internal class GameFramework

    {
        public static Graphics g;
        public static void Start() 
        {
            GameObjectManger.CreateMap();
            GameObjectManger.CreateMyTank();
        }
        public static void Update() 
        {
            //FPS
            GameObjectManger.DrawMap();
            GameObjectManger.DrawMyTank();
        }
        public static void KeyDown(KeyEventArgs args)
        {

        }
        public static void KeyUp(KeyEventArgs args)
        {

        }
    }
}
