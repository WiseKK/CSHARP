using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_子类的构造
{
    internal class Drivedclass:BaseClass
    {
        public Drivedclass()
        {
            Console.WriteLine("构造函数，drived");
        }
        //public Drivedclass():base()
        //{
        //    Console.WriteLine("构造函数，drived");
        //}

    }
}
