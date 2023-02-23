using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_继承
{
    internal class Enemy
    {
        protected int HP;//可在子类访问
        protected int Speed;

        public void AI()
        {
            Console.WriteLine("AI");
        }  
        public void Move()
        {
            Console.WriteLine("Move");
        }
    }
}
