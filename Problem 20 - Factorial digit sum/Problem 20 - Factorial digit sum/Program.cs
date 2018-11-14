using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Problem_20___Factorial_digit_sum
{
    /*
     * Factorial digit sum
     * Problem 20
     * n! means n × (n − 1) × ... × 3 × 2 × 1
     * For example, 10! = 10 × 9 × ... × 3 × 2 × 1 = 3628800,
     * and the sum of the digits in the number 10! is 3 + 6 + 2 + 8 + 8 + 0 + 0 = 27.
     * Find the sum of the digits in the number 100!
     */

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(digitsSum(fact(100)));
            Console.ReadLine();
        }

        private static int digitsSum(BigInteger num)
        {
            int sum = 0;

            while (num > 0)
            {
                sum += (int)(num % 10);
                num /= 10;
            }

            return sum;
        }

        private static BigInteger fact(int num)
        {
            BigInteger product = 1;

            for (int i = 1; i <= num; i++)
            {
                product *= i;
            }

            return product;
        }
    }
}
