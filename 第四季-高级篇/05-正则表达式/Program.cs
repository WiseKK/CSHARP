using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05_正则表达式
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "4544n";
            string str2 = "54551";
            Console.WriteLine(Regex.IsMatch(str1, @"\d*"));//零个或多个数字
            Console.WriteLine(Regex.IsMatch(str2, @"\d\d\d\d\d\d"));

            Console.WriteLine(Regex.IsMatch(str1,@"45*"));//*只对前一个又效
            Console.WriteLine(Regex.IsMatch(str2, @"^4"));//必须以什么开头
            Console.WriteLine(Regex.IsMatch(str2, @"4$"));//必须以什么结尾
            Console.WriteLine(Regex.IsMatch(str1, @"^\d*$"));//必须以什么开头结尾

            Console.WriteLine(Regex.IsMatch(str2, @"^\w*$"));//只能大小写字母、0-9、下划线

            //https://www.runoob.com/csharp/csharp-regular-expressions.html




        }
    }
}
