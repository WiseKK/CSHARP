using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _06_坦克大战_正式.Properties;

namespace _06_坦克大战_正式
{
    internal class GameObjectManger
    {
        private static List<NotMovething> steellist = new List<NotMovething>();
        private static NotMovething bosslist;
        private static List<NotMovething> walllist = new List<NotMovething>();
        private static MyTank myTank;
        public static void Update() 
        {
            foreach (NotMovething nm in walllist)
            {
                nm.Update();
            }
            foreach (NotMovething nm in steellist)
            {
                nm.Update();
            }
            bosslist.Update();
            myTank.Update();

        }

        //public static void DrawMap()//先创建
        //{
        //    foreach (NotMovething nm in walllist)
        //    {
        //        nm.DrawSelf();
        //    }
        //    foreach (NotMovething nm in steellist)
        //    {
        //        nm.DrawSelf();
        //    }
        //    bosslist.DrawSelf();
        //}
        //public static void DrawMyTank()//绘制方法
        //{ 
        //    myTank.DrawSelf();
        //}
        public static void CreateMyTank()
        {
            int x = 5 * 30;
            int y =13* 30;

            myTank = new MyTank(x, y, 2);
        }
        public static void CreateMap()//再绘制
        {
            CreateWall(1, 1, 5, Resources.wall, walllist);
            CreateWall(3, 1, 5, Resources.wall, walllist);
            CreateWall(5, 1, 4, Resources.wall, walllist);
            CreateWall(7, 1, 3, Resources.wall, walllist);
            CreateWall(9, 1, 4, Resources.wall, walllist);
            CreateWall(11, 1, 5, Resources.wall, walllist);
            CreateWall(13, 1, 5, Resources.wall, walllist);
            CreateWall(2, 7, 1, Resources.wall, walllist);
            CreateWall(3, 7, 1, Resources.wall, walllist);
            CreateWall(4, 7, 1, Resources.wall, walllist);
            CreateWall(6, 7, 1, Resources.wall, walllist);
            CreateWall(7, 7, 1, Resources.wall, walllist);
            CreateWall(8, 7, 1, Resources.wall, walllist);
            CreateWall(10, 7, 1, Resources.wall, walllist);
            CreateWall(11, 7, 1, Resources.wall, walllist);
            CreateWall(12, 7, 1, Resources.wall, walllist);

            CreateWall(1, 9, 3, Resources.wall, walllist);
            CreateWall(3, 9, 3, Resources.wall, walllist);
            CreateWall(5, 9, 2, Resources.wall, walllist);
            CreateWall(7, 9, 2, Resources.wall, walllist);
            CreateWall(9, 9, 2, Resources.wall, walllist);
            CreateWall(11, 9, 3, Resources.wall, walllist);
            CreateWall(13, 9, 3, Resources.wall, walllist);


            CreateWall(7, 5, 1, Resources.steel, steellist);
            CreateWall(0, 7, 1, Resources.steel, steellist);
            CreateWall(13, 7, 1, Resources.steel, steellist);
            CreateWall(6, 12, 2, Resources.steel, steellist);
            CreateWall(7, 12, 1, Resources.steel, steellist);
            CreateWall(8, 12, 2, Resources.steel, steellist);

            //Createboss(7, 13, 1, Resources.Boss, bosslist);
            Createboss(7, 13,1, Resources.Boss);





        }
        private static void CreateWall(int x, int y, int count, Image img, List<NotMovething> walllist)
        {
            int xPositrion = x * 30;
            int yPositrion = y * 30;
            for (int i = yPositrion; i < yPositrion + count * 30; i += 15)
            {
                NotMovething wall1 = new NotMovething(xPositrion, i, img);
                NotMovething wall2 = new NotMovething(xPositrion + 15, i, img);
                walllist.Add(wall1);
                walllist.Add(wall2);
            }

        }
        private static void Createboss(int x, int y, int count, Image img)
        {
            int xPositrion = x * 30;
            int yPositrion = y * 30;
            bosslist = new NotMovething(xPositrion,yPositrion,img);

        }
        public static void KeyDown(KeyEventArgs args)
        {
            myTank.KeyDown(args);
        }
        public static void KeyUp(KeyEventArgs args)
        {
            myTank.KeyUp(args);
        }
    }
}
