using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_利用委托升级冒泡排序
{
    internal class Program
    {
        private static void Sort(int[] sortArray)
        {
            bool swapped = true;
            do{
               swapped = false;
               for (int i = 0; i < sortArray.Length - 1; i++)
                {
                    if (sortArray[i] > sortArray[i + 1])
                    {
                        int temp = sortArray[i];
                        sortArray[i] = sortArray[i + 1];
                        sortArray[i + 1] = temp;
                        swapped = true;
                    }
                }
            } while (swapped);
        }
        static void Main(string[] args)
        {
            //int[] sortArray = { 34, 54, 456, 28, 5454, 523 };
            //Sort(sortArray);
            //foreach (int i in sortArray) 
            //{
            //    Console.Write(i+" ");
            //}

            Employee[] employees =
            {
                new Employee("Bunny",20000),
                new Employee("Bunn",10000),
                new Employee("Bun",25000),
                new Employee("Bu",100000),
                new Employee("B",23000),
                new Employee("Bunnys",50000),
            };
        }
    }
}
