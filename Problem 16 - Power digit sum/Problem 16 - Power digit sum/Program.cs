using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Problem_16___Power_digit_sum
{
    /*
     * Power digit sum
     * Problem 16 
     * 2^15 = 32768 and the sum of its digits is 3 + 2 + 7 + 6 + 8 = 26.
     * What is the sum of the digits of the number 2^1000?
     */

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(digitsSum(2, 1000));
            Console.ReadLine();
        }

        private static int digitsSum(int num1, int num2)
        {
            int sum = 0;

            BigInteger num = BigInteger.Pow(num1, num2);

            while (num > 0)
            {
                sum += (int)(num % 10);
                num /= 10;
            }

            return sum;
        }
    }
}
