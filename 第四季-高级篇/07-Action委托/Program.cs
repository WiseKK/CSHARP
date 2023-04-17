﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Action委托
{
    internal class Program
    {
        private static void Test1()
        {
            Console.WriteLine("test1");
        }
        private static void Test2(int x)
        {
            Console.WriteLine("tses2"+x);
        }
        private static void Test3(int x, double y)
        {
            Console.WriteLine("tses2" + x+y);
        }
        static void Main(string[] args)
        {
            Action method = Test1;
            method();

            Action<int> method2 = Test2;
            method2(258);

            Action<int, double> method3 = Test3;
            method3(258, 144.4);
        }
    }
}
