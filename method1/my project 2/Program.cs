using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_project_2
{
    class Program
    {
        string name, city;
        int age;

        public void AcceptDetails()
        {
            Console.Write("\n Enter your Name : \t");
            name = Console.ReadLine();

            Console.Write("\n Enter your city : \t");
            city = Console.ReadLine();

            Console.Write("\n Enter your Age : \t");
            age = Convert.ToInt32(Console.ReadLine());

        }
        public void PrintDetails()
        {
            Console.Write("\n\n=====================================================\n\n");
            Console.Write("\n\nName:  \t" + name);
            Console.Write("\n\nCity:  \t" + city);
            Console.Write("\n\nAge:  \t" + age);
            Console.Write("\n\n=====================================================\n\n");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.AcceptDetails();
            p.PrintDetails();
            Console.ReadKey();
        }
    }
}
