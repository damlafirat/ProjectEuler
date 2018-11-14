using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Problem_6___Sum_square_difference
{
    /*
     * Sum square difference
     * Problem 6 
     * The sum of the squares of the first ten natural numbers is,
     * 1^2 + 2^2 + ... + 10^2 = 385
     * The square of the sum of the first ten natural numbers is,
     * (1 + 2 + ... + 10)^2 = 552 = 3025
     * Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.
     * Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
     */

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(subtraction(sumSquare(100), squareSum(100)));
            Console.ReadLine();
        }

        private static BigInteger subtraction(BigInteger num1, BigInteger num2)
        {
            return BigInteger.Abs(num1 - num2);
        }

        private static BigInteger squareSum(int num)
        {
            BigInteger sum = 0;

            for (int i = 1; i <= num; i++)
            {
                sum += BigInteger.Pow(i, 2);
            }

            return sum;
        }

        private static BigInteger sumSquare(int num)
        {
            BigInteger sum = 0;

            for (int i = 1; i <= num; i++)
            {
                sum += i;
            }

            return BigInteger.Pow(sum, 2);
        }
    }
}
