﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project__003
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            do
            {

                Console.WriteLine("Value of a : {0} ", a);
                a = a + 1;
            } 
            while (a <= 20);

            Console.ReadKey();
        }
    }
}
