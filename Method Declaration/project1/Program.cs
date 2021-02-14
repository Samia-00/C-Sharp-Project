using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    public class Calculator
    {
        public double Add(double a,double b)
        {
            return a + b; 
        }
        public double Sub(double a, double b)
        {
            return a - b;
        }
        public double Multiply(double a, double b)
        {
            return a * b;
        }
        public double Division(double a, double b)
        {
            return a / b;
        }
        protected void Myname()
        {
            Console.WriteLine("Farjana Sultana Samia");
        }
    }
    class Program:Calculator
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Myname();
            Calculator c = new Calculator();
            double val3 = c.Add(5.5, 2.5);
            Console.WriteLine(val3);
            double val4 = c.Sub(5.5, 6.5);
            Console.WriteLine(val4);
            double val5 = c.Multiply(0.0, 4.5);
            Console.WriteLine(val5);
            double val6 = c.Division(4.5, 3.5);
            Console.WriteLine(val6);
            int val = p.Add();
            Console.WriteLine(val);
            Display();
            double val2 = Add(3.79, 7.00);
            Console.WriteLine(val2);

            Console.ReadKey();
        }

        static void Display()
        {
            Console.WriteLine("SAMIA");
        }
        private int Add()
        {
            return 10 + 4;
        }
        static double Add(double a , double b)
        {
            return a + b;
        }
    }
}
