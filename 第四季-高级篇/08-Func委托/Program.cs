using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Func委托
{
    internal class Program
    {
        private static string Test1()
        {
            return "siki"; 
        }
        private static string Test2(int x)
        {
            return "siki"+x;
        }
        static void Main(string[] args)
        {
            Func<string> f = Test1;
            Console.WriteLine(f());
            Func<int,string> f2 = Test2;
            Console.WriteLine(f2(5));
        }
    }
}
