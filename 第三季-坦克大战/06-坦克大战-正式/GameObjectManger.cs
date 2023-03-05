using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _06_坦克大战_正式.Properties;

namespace _06_坦克大战_正式
{
    internal class GameObjectManger
    {
        private static List<NotMovething> walllist=new List<NotMovething>();

        public static void DrawMap()
        {
            foreach (NotMovething nm in walllist)
            { 
            nm.DrawSelf();
            }
        }
        public static void CreateMap()
        {
            CreateWall(1,1,5,walllist);
        }
        private static void CreateWall(int x, int y, int count, List<NotMovething>walllist)
        {
            int xPositrion = x * 30;
            int yPositrion = y * 30;
            for (int i = yPositrion; i < yPositrion + count * 30; i += 15)
            {
                NotMovething wall1 = new NotMovething(xPositrion,i,Resources.wall);
                NotMovething wall2 = new NotMovething(xPositrion, i, Resources.wall);
                walllist.Add(wall1);
                walllist.Add(wall2);
            }

        }
    }
}
