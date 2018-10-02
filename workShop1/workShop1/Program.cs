using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workShop1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Lincoln!");
            Console.ReadLine();
            Console.WriteLine("What is your name?");

            string userName;

            userName = Console.ReadLine();
            Console.WriteLine("Hello {0}!",userName);

            Console.ReadLine();
        }
    }
}
