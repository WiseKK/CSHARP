using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_子类的构造
{
    internal class BaseClass
    {
        public BaseClass() 
        {
            Console.WriteLine("gzhanshu1");
        }
    }


    //怎么访问别的项目下的类
    //1、添加别的项目的引用 2、引入命名空间 3、把类设置为public
}
