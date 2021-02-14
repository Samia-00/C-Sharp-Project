using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project__004
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,result, i; 
            Console.Write("Enter a Number : ");
            a = Convert.ToInt32(Console.ReadLine());
            i = 1;
            while (i <= 10)
            {
                result = a * i;
                Console.WriteLine("{0} X {1}   = {2}", a, i, result);
                i++;
            }

            Console.ReadKey(); 
        }
    }
}
