using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_继承
{
    internal class Boss:Enemy
    {
        private int attack;

        public Boss(int attack, int HP, int Speed)
        {
            this.attack = attack;
            //this.HP = HP;
            //this.Speed = Speed;
            base.HP = HP;
            base.Speed = Speed;
        }

        public void Skill()
        {
            Console.WriteLine("Skill");
        }
        public void Print()
        {
            Console.WriteLine("HP:"+HP);
            Console.WriteLine("Speed:" + Speed);
            Console.WriteLine("Attack:" + attack);
        }
    }
}
