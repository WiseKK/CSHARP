using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_继承
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DriveClass d1= new DriveClass();
            //d1.name = "xiaxia";
            //Console.WriteLine(d1.name);
            //Console.WriteLine(d1.data1);
            //d1.data1 = 15;
            //d1.Function1();

            Boss boss1=new Boss(100,200,50);
            boss1.Print();
            Console.WriteLine("slds");

        }
    }
}
