using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _014_索引器
{
    internal class Test
    {
        public int this[int index]
        { 
        get
            { 
                return 100; 
            }
        set 
            { 
                Console.WriteLine(value); 
            }
        }
    }
}
