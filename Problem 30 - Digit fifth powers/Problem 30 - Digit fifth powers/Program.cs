using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_30___Digit_fifth_powers
{
    /*
     * Digit fifth powers
     * Problem 30 
     * Surprisingly there are only three numbers that can be written as the sum of fourth powers of their digits:
     * 1634 = 1^4 + 6^4 + 3^4 + 4^4
     * 8208 = 8^4 + 2^4 + 0^4 + 8^4
     * 9474 = 9^4 + 4^4 + 7^4 + 4^4
     * As 1 = 14 is not a sum it is not included.
     * The sum of these numbers is 1634 + 8208 + 9474 = 19316.
     * Find the sum of all the numbers that can be written as the sum of fifth powers of their digits.
     */

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(operation());

            Console.ReadLine();
        }

        private static int operation()
        {
            int sum = 0;

            for (int i = 0; i < 1000000; i++)
            {
                if (control(i))
                    sum += i;
            }

            return sum;
        }

        private static bool control(int num)
        {
            double sum = 0;

            foreach (var item in digitsNumbers(num))
            {
                sum += Math.Pow(item, 5);
            }

            if (num == sum)
                return true;

            else
                return false;
        }

        private static int[] digitsNumbers(int num)
        {
            List<int> digitsNumList = new List<int>();

            while (num != 0)
            {
                int digitsNum = num % 10;
                num = (num - digitsNum) / 10;
                digitsNumList.Add(digitsNum);
            }

            return digitsNumList.ToArray();
        }
    }
}
