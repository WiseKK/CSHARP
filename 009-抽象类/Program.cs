using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace _009_抽象类
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Enemy e= new Enemy();
            //抽象类型无法创建实例（如上）
            Enemy e = new Boss();//可为子类创建实例
            e.Attack();
        }
    }
}
