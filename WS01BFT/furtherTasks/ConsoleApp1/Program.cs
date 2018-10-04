using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Further task
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("What is your age? (in Years)");
            int ageY = Convert.ToInt32(Console.ReadLine());

            int age = ageY * 365;

            Console.WriteLine("Hello {0}. You are {1} days old.", name, age);


            Console.ReadLine();
        }
    }
}
