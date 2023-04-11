using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 随机数
{
    internal class Program
    {
        static void Main(string[] args)
        {            
                Random random = new Random();
                string name = "";

                for (int i = 0; i < 5; i++)
                {
                    name += random.Next(0, 10).ToString();
                }

                Console.WriteLine("随机生成的五位数名字为：" + name);
                Console.ReadLine();         
        }
    }
}
