using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_34___Digit_factorials
{
    class Program
    {
        /*
         * Digit factorials
         * Problem 34
         * 145 is a curious number, as 1! + 4! + 5! = 1 + 24 + 120 = 145.
         * Find the sum of all numbers which are equal to the sum of the factorial of their digits.
         * Note: as 1! = 1 and 2! = 2 are not sums they are not included.
         */

        static void Main(string[] args)
        {
            Console.WriteLine(sumOfCurious());

            Console.ReadLine();
        }

        private static int sumOfCurious()
        {
            int sum = 0;

            for(int i = 3; i < 100000; i++)
            {
                if (curiousCheck(i))
                    sum += i;
            }

            return sum;
        }

        private static bool curiousCheck(int v)
        {
            int sum = 0;

            foreach (var item in findDigit(v))
            {
                sum += findFactorial(item);
            }

            if (v == sum)
                return true;

            else
                return false;
        }

        private static List<int> findDigit(int v)
        {
            List<int> digits = new List<int>();

            while (v != 0)
            {
                digits.Add(v % 10);
                v /= 10;
            }

            return digits;
        }

        private static int findFactorial(int v)
        {
            int result = 1;

            for (int i = 1; i <= v; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}
