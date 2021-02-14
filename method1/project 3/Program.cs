using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_3
{
    class Program
    {
        static void sum(params int[] list)
        {
            Console.WriteLine("There are {0} element ", list.Length);
            int sum = 0;
            foreach (var i in list)
            {
                sum = sum + i;
            }
            Console.WriteLine("The sum amount is {0} ",sum);
        }
        static void Main(string[] args)
        {
            //int[] a={10,20,30}; //if we dont use params
            sum(10, 20, 30);// sum(a)
            Console.ReadKey();
        }
    }
}
