using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biggest_Numb
{
    class Program
    {
        static void Main(string[] args)
        {
            float num;
            Console.WriteLine("Enter Three Numbers : ");
            double a= double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine("The max number is : " + a);
            }
            else if (b > a && b > c)
            {
                Console.WriteLine("The max number is : " + b);
            }
            else
            {
                Console.WriteLine("The max number is : " + c);
            }
            Console.ReadKey();
        }
    }
}
