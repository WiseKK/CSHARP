using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Boss b = new Boss();
            //b.Move();
            //Enemy c= new Enemy();
            //c.Move();

            Enemy enemy;//父类声明
            //enemy = new Boss();//子类构造
            //enemy = new Type1Enemy();//本质还是子类对象，子类特有不能调用
            enemy = new Boss();
            enemy.Move();
            //enemy.BossSkill();
            Boss b = new Boss();
            b.Move();
            enemy = new Boss();
            enemy.Move();

            Enemy enemy2 = new Boss();
            enemy2.Move();
        }
    }
}
