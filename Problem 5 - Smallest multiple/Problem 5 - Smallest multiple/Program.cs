using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5___Smallest_multiple
{
    /*
     * Smallest multiple
     * Problem 5
     * 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
     * What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
     */

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(smallestCommonMultiple());
            Console.ReadLine();
        }

        private static int smallestCommonMultiple()
        {
            int num = 0;

            for (int i = 10; i < int.MaxValue; i++)
            {
                int counter = 0;
                num = i;

                for (int j = 1; j <= 20; j++)
                {
                    if (i % j == 0)
                        counter++;
                    else
                        break;
                }

                if (counter == 20)
                    break;
            }

            return num;
        }
    }
}
