using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_抽象类
{
    abstract class Enemy
    {
        public int HP;//抽象类可定义此
        public int Speed;

        public void Move()//抽象类可定义此
        {
            Console.WriteLine("输出xxx");
        }
        public abstract void Attack();//抽象类有抽象方法,而抽象方法没有函数体
    }
}
