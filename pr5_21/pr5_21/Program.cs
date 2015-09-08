using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr5_21
{
    internal class Program
    {
        

        private static void Main(string[] args)
        {
            int number = 0;
            int largest = 0;

            for (int counter = 0; counter < 10; counter++)
            {
                if (counter == 0)
                {
                    Console.Write("Enter number {0} : ", counter + 1);

                }
                else
                {
                    Console.WriteLine("\nThe largest number entered so far is: {0}", largest); 
                    Console.Write("Enter number {0} : ", counter + 1);
                }

                number = Convert.ToInt32(Console.ReadLine());

                if (counter == 0)
                {
                    largest = number;
                }

                if (number > largest)
                {
                    largest = number;
                }
            }

            Console.WriteLine("\n********  The Largest number entered was: {0} *********\n\n",largest);

            Console.WriteLine("Hit enter to continue");
            Console.ReadLine();

        }

    }

}