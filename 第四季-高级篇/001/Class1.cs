using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Mynamespace;
using System.Threading.Tasks;



namespace Mynamespace2
{
     internal class Class1
    {
        private void test()
        {
            //Program p = new Program();
            //Mynamespace.Program p = new Mynamespace.Program();
            Program program = new Program();
            Mynamespace2.Childnamespace.Class2 b = new Childnamespace.Class2();
        }

    }
}
