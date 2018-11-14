using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Problem_10___Summation_of_primes
{
    /*
     * Summation of primes
     * Problem 10 
     * The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
     * Find the sum of all the primes below two million.
     */

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(primeNumSum(2000000));
            Console.ReadLine();
        }

        private static BigInteger primeNumSum(int num)
        {
            List<int> primeNumbersList = new List<int>();

            BigInteger sum = 0;
            int counter = -1;

            for (int i = 2; ; i++)
            {
                if (primeControl(i) == true)
                {
                    primeNumbersList.Add(i);
                    counter++;

                    if (primeNumbersList[counter] < num)
                    {
                        sum += i;
                    }
                    else
                        break;
                }
            }

            return sum;
        }

        private static bool primeControl(int num)
        {
            for (BigInteger i = 2; i < num; i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }
    }
}
