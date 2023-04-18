using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_自定义特性
{
    [Information("siki","v1.1", "埃斯奎阿萨")]
    internal class Program
    {
        static void Main(string[] args)
        {
            Type t = typeof(Program);
            bool result = t.IsDefined(typeof(InformationAttribute), false);
            Console.WriteLine(result);

            object[] attributeArray = t.GetCustomAttributes(false);
        }
    }
}
