using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_字符串
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "kangkang";
            Console.WriteLine(s.Length);
            Console.WriteLine(s=="kangkang");
            s = "http://" + s;
            Console.WriteLine(s);
            Console.WriteLine(s[3]);
            Console.WriteLine(s.Length);

        }
    }
}
