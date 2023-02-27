using System;

namespace _015_运算符重载
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(100, "张三", 123564);
            Student s2 = new Student(100, "张三", 123564);
            Console.WriteLine(s1 == s2);
            Console.WriteLine(s1 == s2);
            Student s3 = s1;
            Console.WriteLine(s1 == s3);


        }
    }
}
