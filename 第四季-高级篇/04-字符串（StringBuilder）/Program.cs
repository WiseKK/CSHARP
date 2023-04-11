using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_字符串_StringBuilder_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("www.sikiedu.com");//可变字符字符串

            Console.WriteLine(sb.Capacity);//查看容量

            sb.Append("1231111");//从后面加

            sb.Insert(3,"lalala");//从设定位置加

            sb.Remove(3, 6);//从sb[3]开始移除n个

            sb.Replace("siki","bigubigu");//替换




            Console.WriteLine(sb);
        }
    }
}
