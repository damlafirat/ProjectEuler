using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3___Largest_prime_factor
{
    /*
     * Largest prime factor
     * Problem 3 
     * The prime factors of 13195 are 5, 7, 13 and 29.
     * What is the largest prime factor of the number 600851475143 ?
     */

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(largestNum(primeDivisors(divisors(600851475143))));
            Console.ReadLine();

        }

        private static long largestNum(long[] nums)
        {
            long largest = nums[0];

            for (long i = 1; i < nums.Length; i++)
            {
                if (largest < nums[i])
                    largest = nums[i];
            }

            return largest;
        }

        private static bool primeControl(long num)
        {
            for (long i = 2; i < num; i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }

        private static long[] primeDivisors(long[] array)
        {
            List<long> primeDivList = new List<long>();

            for (long i = 0; i < array.Length; i++)
            {

                if (primeControl(array[i]) == true)
                    primeDivList.Add(array[i]);
            }

            return primeDivList.ToArray();
        }

        private static long[] divisors(long num)
        {
            List<long> divList = new List<long>();

            for (long i = 2; i < num; i++)
            {
                if (num % i == 0)
                    divList.Add(i);
            }

            return divList.ToArray();
        }
    }
}
