using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_委托
{
    internal class Program
    {
        delegate void IntMethodInvoker(int x);
        delegate long TwoLong(long a, long b);
        static void Main(string[] args)
        {
            IntMethodInvoker invoker = null;
            TwoLong invoker2 = null;

            invoker = Program.test;//委托给invoker
            invoker(100);

            if (invoker2 != null)//防止为空出错
            {
                invoker2(2, 23);
            }
        }
        private static void test(int x)
        {
            Console.WriteLine("我是test方法："+ x);
        }
    }
}
