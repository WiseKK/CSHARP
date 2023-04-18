#define IsShow  
//宏
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _14_特性
{
    internal class Program
    {
        [Obsolete("这个方法弃用了，请使用最新的NewTest方法")]//特性：弃用
       //[Obsolete("这个方法弃用了，请使用最新的NewTest方法", true)]//特性：弃用
        static void Test() 
        {
            Console.WriteLine("test");
        }
        static void NewTest()
        {
            Console.WriteLine("NewTest");
        }

        [Conditional("IsShow")]
        static void ShowMessage(string str)
        {
            Console.WriteLine(str);
        }
        //[DebuggerStepThrough]  //跳过后面代码
        static void ShoMessage(string message, [CallerLineNumber]int LineNumber=0, [CallerFilePath]string filepath="null", [CallerMemberName]string numbername="null")//调用者信息
        { 
            Console.WriteLine(message);
            Console.WriteLine(LineNumber);
            Console.WriteLine(filepath);
            Console.WriteLine(numbername);
        }

        static void Main(string[] args)
        {
            //Test();
            ShowMessage("start");
            Console.WriteLine("doing");
            ShowMessage("end");
            ShoMessage("hello");
        }
    }
}
