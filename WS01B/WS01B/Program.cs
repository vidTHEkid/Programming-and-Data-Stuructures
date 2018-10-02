using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WS01B
{
    class Program
    {
        static void Main(string[] args)
        {
            //1b part 5
            //Calculating Mean.`
            Console.WriteLine("Enter your first number:");
            int fNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your second number:");
            int sNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your third number:");
            int tNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your forth number:");
            int foNum = Convert.ToInt32(Console.ReadLine());

            int mean = (fNum + sNum + tNum + foNum) / 4;
            Console.WriteLine("Mean of your numbers are: {0}", mean);


            Console.ReadLine();

            //Calculating Meadian
            //To calculate median find the centre numbers and then add the 2 centre numbers and devide it by 2.
            int[] unsortedArray = { fNum, sNum, tNum, foNum };
            int temp;
            foreach (int unsortedArrayunsortedArray in unsortedArray)
                for(int p = 0; p <= unsortedArray.Length - 2; p++)
                {
                    for(int i = 0; i <= unsortedArray.Length - 2; i++)
                    {
                        if(unsortedArray[i] > unsortedArray[i + 1])
                        {
                            temp = unsortedArray[i + 1];
                            unsortedArray[i + 1] = unsortedArray[i];
                            unsortedArray[i] = temp;
                        }
                    }
                }
           
            //List<int> list = new List<int>();
            List<float> fList = new List<float>();
            foreach (int i in unsortedArray)
            {
                fList.Add(i);
            }
            float mediean = ((fList[1] + fList[2]) / 2);
            Console.WriteLine("Median is: {0}", mediean);

            Console.ReadLine();

        }
    }
}
