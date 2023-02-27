using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015_运算符重载
{
    internal class Student
    {
        private int age;
        private string name;
        private long id;

        public Student(int age, string name, long id)
        {
            this.age = age;
            this.name = name;
            this.id = id;
        }
        public static bool operator ==(Student s1, Student s2)
        {
            if (s1.age == s2.age && s1.name == s2.name && s1.id == s2.id)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Student s1, Student s2)
        {
            if (s1.age == s2.age && s1.name == s2.name && s1.id == s2.id)
            {
                return false;
            }
            return true;
        }
    }
}
