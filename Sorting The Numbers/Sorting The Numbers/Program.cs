using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_The_Numbers
{
    class Program
    {
        static void Sort(params int[] list)
        {
            Console.WriteLine("There are {0} element ", list.Length);
            Console.WriteLine("Before sort");
            foreach(var i in list)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("After sort");
           
            for ( int i=0;i<list.Length;i++)
            {
                for(int j=i+1;j<list.Length;j++)
                {
                    if (list[i]>list[j])
                    {
                        int temp = 0;
                        temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
                }
                Console.WriteLine(list[i]);
            }
            
        }

        static void Main(string[] args)
        {
            Sort(3, 44, 76, 22, 100, 29);
            Console.ReadKey();
        }
    }
}
