using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_利用委托升级冒泡排序
{
    internal class Employee
    {
        public string Name { get; private set; }
        public double Salary { get; private set; }

        public Employee(string name, double salary) 
        {
            Name = name;
            Salary = salary;
        }


    }
}
