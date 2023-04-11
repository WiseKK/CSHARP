﻿using System;
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
            string s = "Kangkang";//创建字符串
            Console.WriteLine(s.Length);//获取，输出字符串长度
            Console.WriteLine(s=="kangkang  ");//判断是否相同
            s = "  http://" + s;//字符串链接
            Console.WriteLine(s);
            Console.WriteLine(s[3]);
            Console.WriteLine(s.Length);


            //更多字符串代码
            Console.WriteLine(s.CompareTo("kangkang"));//对比
            Console.WriteLine(s.Replace("k","l"));//替换    
            Console.WriteLine(s.Split());//拆分            
            # region  遍历拆分结果          
            string[] vs = s.Split(s[3]);
            foreach (string v in vs)
            {
                Console.WriteLine(v);
            }
            #endregion
            Console.WriteLine(s.Substring(5));//截取
            Console.WriteLine(s.Substring(4, 4));//从那里开始，截取几个
            Console.WriteLine(s.ToLower());//小写
            Console.WriteLine(s.ToUpper());//大写
            Console.WriteLine(s.Trim());//去头尾空格
            Console.WriteLine(string.Concat("123456","cadcdac"));//相加

            //char[] cA = new char[20];//字符串拷贝到（不清楚）
            //s.CopyTo(4,cA,1,8);
            //#region  遍历拆分结果          
            //foreach (char c in cA)
            //{
            //    Console.WriteLine(c);
            //}
            //#endregion







        }

    }
}
