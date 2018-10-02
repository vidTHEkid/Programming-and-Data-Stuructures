using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workShop1a
{
    class Program
    {

        static void Main(string[] args)
        {
            //1.2 Using ‘escape’ characters
            /*
            Console.WriteLine("\tUnit: CMP1127M “Programming and Data Structures” \n");
            Console.WriteLine("\tMy name is Vithursan Somasegaram \n");


            DateTime today = DateTime.Today;
            Console.WriteLine("\t"+ today.ToString("dd/MM/yy"));
            Console.ReadLine();
            */




            //1.3 Using simple operators
            /*
            int x = 6;
            int y = 5;
            int z;
            z = x / y;
            Console.WriteLine("Value of x = {0}", x);
            Console.WriteLine("Value of y = {0}", y);
            Console.WriteLine("Value of z = {0}", z);

            Console.ReadLine();
            */
            //The value of Z is 1 here, this may be because of the program rounding up the result.




            /*
            //1.3 Further Tasks 1
            Console.WriteLine("Enter your first number:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your first number:");
            int y = Convert.ToInt32(Console.ReadLine());
            int z = x + y;
            Console.WriteLine("Sum = {0} ", z);
            ;
            Console.ReadLine();
            */



            //1.3 Further Tasks 2
            /*
            Console.WriteLine("Choose an operator: +, -, * or / \n");
            string userInput = Console.ReadLine();
            if(userInput == "+")
            {
                Add();
                Console.ReadLine();
            }
            else if(userInput == "-")
            {
                Sub();
                Console.ReadLine();
            }
            else if (userInput == "*")
            {
                Mul();
                Console.ReadLine();
            }
            else if (userInput == "/")
            {
                Divi();
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Invalid");
            }
            */





            //1.3 Further Tasks 3
            /*
             * Line 1: S in system should be captital
             * Line 5: M in main should be capital
             * Line 8: L in Write line should be capital
             * Line 8: " is missing
             * Line 8: ; is missing
             * Line 9: Console.ReadLine is needed to keep the console open.
             */





            //1.3 Further Tasks 4
            /*
             * 2 that I know of ReadKey and ReadLine
             * Console.Read
            */
        }
        private static void Add()
        {
            Console.WriteLine("Enter your first number:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your first number:");
            int y = Convert.ToInt32(Console.ReadLine());
            int z = x + y;
            Console.WriteLine("Sum = {0} ", z);
        }

        private static void Sub()
        {
            Console.WriteLine("Enter your first number:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your first number:");
            int y = Convert.ToInt32(Console.ReadLine());
            int z = x - y;
            Console.WriteLine("Value = {0} ", z);
        }
        private static void Mul()
        {
            Console.WriteLine("Enter your first number:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your first number:");
            int y = Convert.ToInt32(Console.ReadLine());
            int z = x * y;
            Console.WriteLine("Value = {0} ", z);
        }
        private static void Divi()
        {
            Console.WriteLine("Enter your first number:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your first number:");
            int y = Convert.ToInt32(Console.ReadLine());
            int z = x / y;
            Console.WriteLine("Value = {0} ", z);
        }
    }
}
