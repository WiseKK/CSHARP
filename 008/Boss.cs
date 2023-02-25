using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008
{
    internal class Boss:Enemy
    {
        public override void Move()//重写了继承过来的Move
        {
            Console.WriteLine("Boss特有的移动方法");
        }
        public void BossSkill()
        {
            Console.WriteLine("Boss特有的技能");
        }
        public new void AI()//隐藏重写方法 
        {
        Console.WriteLine("Boss自己的AI");
        }
    }   
}
