using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _01_基础知识
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a = 10;
            //double b = a;//10->10.0

            //double c = 12345678900;
            //a = (int)c;//缺少强制转换或显示转换
            //Console.WriteLine(a);//溢出

            Father f = new Son();//f只能用father内的功能，不能用son中

            Son s = (Son)f;
            s.Sonmethod();

            Son c =f as Son;//成功就成功，不成功就变null
        }    

        class Father
        { 
                
        }
        class Son:Father
        { 
            public void Sonmethod()
            { 
            
            }
        }
    }
}
