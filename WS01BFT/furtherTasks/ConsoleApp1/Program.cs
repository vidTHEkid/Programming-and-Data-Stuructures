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
            //Further task 01
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("What is your age? (in Years)");
            int ageY = Convert.ToInt32(Console.ReadLine());

            int age = ageY * 365;

            Console.WriteLine("Hello {0}. You are {1} days old.", name, age);

            //Further task 02
            List<int> numbers = new List<int>();

            Console.WriteLine("Enter the first number: ");
            int fNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            int sNum = Convert.ToInt32(Console.ReadLine());

            numbers.Add(fNum);
            numbers.Add(sNum);

            Console.WriteLine("Swapped numbers are: {0}, {1}", numbers[1], numbers[0]);

            //Further task 03


            Console.ReadLine();
        }
    }
}
