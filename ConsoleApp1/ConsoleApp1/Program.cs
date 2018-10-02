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
            Console.WriteLine("yo");
            
            string userName;
            Console.WriteLine("whats your name? ");
            userName = Console.ReadLine();
            Console.WriteLine("yo {0}", userName);
            Console.ReadLine();
        }
    }
}
