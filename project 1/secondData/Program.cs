using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secondData
{
    class Program
    {
        static void Main(string[] args)
        {
            //fraction data type
            float rate = 2.75F;
            double basic = 9800.00;
            decimal expanse = 897.23M;

            Console.WriteLine("Rate : " + rate);
            Console.WriteLine("Basic : " + basic);
            Console.WriteLine("Expanse : " +expanse);

            Console.ReadKey();
        }
    }
}
