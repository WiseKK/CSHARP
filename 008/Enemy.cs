using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008
{
    internal class Enemy
    {  
        public virtual void Move()
        {
            Console.WriteLine("敌人进行移动");
        }
        public void AI() 
        {
            Console.WriteLine("敌人的AI");
        }
    }
}
