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
        public static void CreateMap()
        {
            CreateWall(1,1,5);
        }
        private static void CreateWall(int x, int y, int count)
        {
            List<NotMovething> walllist = new List<NotMovething>();//集合
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
