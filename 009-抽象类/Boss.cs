using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_抽象类
{
    internal class Boss : Enemy
    {
        public override void Attack()
        {
            Console.WriteLine("Boss的攻击方式"); ;
        }
    }
}
