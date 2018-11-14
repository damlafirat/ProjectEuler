using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7___10001st_prime
{
    /*
     * 10001st prime
     * Problem 7
     * By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
     * What is the 10 001st prime number?
     */

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(primeNumbers(10001));
            Console.ReadLine();
        }

        private static int primeNumbers(int num)
        {
            List<int> primeNumList = new List<int>();

            int counter = 0;

            for (int i = 2; i < int.MaxValue; i++)
            {
                if (primeControl(i))
                {
                    primeNumList.Add(i);
                    counter++;
                }

                if (counter == num)
                    break;
            }

            return primeNumList[num - 1];
        }

        private static bool primeControl(int num)
        {
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }
    }
}
