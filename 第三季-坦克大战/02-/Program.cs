using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _02_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //线程
            Thread t = Thread.CurrentThread;
            t.Name = "Test";
            Console.WriteLine(t.Name);
            //ThreadStart start = new ThreadStart(ChildThreadMethod);
            //Thread childThread= new Thread(start);

            Thread childThread = new Thread(new ThreadStart(ChildThreadMethod));

            childThread.Start();
            //Console.WriteLine("主线程");
            while (true)
            {
                Console.WriteLine("MainThread-聊天中-"); 
                Thread.Sleep(1000);//1s=1000ms
            }
        }

        private static void ChildThreadMethod()
        {
            while (true) 
            {
                Console.WriteLine("ChildThread -听歌中...");
                Thread.Sleep(1000);
            }
        }
    }
}
