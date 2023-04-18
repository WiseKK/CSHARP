using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_匿名方法
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> plus = delegate (int a, int b)
            {
                return a + b;
            };
            Func<int, int, int> plu =  (a, b)=>{return a + b;};
            // Func<int, int, int> plu = (a, b) => a + b; 再简化版
            int res = plus(1, 2);
            int re = plu(1, 2);
            Console.WriteLine(re);
            Console.WriteLine(res);
            //lambda 
        }
    }
}
