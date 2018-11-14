using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4___Largest_palindrome_product
{
    /*
     * Largest palindrome product
     * Problem 4 
     * A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
     * Find the largest palindrome made from the product of two 3-digit numbers.
     */

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(largestNum(threeDigitsMul()));
            Console.ReadLine();
        }

        private static int largestNum(int[] numbers)
        {
            int largest = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (largest < numbers[i])
                    largest = numbers[i];
            }

            return largest;
        }

        private static int[] threeDigitsMul()
        {
            List<int> threeDigitsMulList = new List<int>();

            for (int i = 100; i <= 999; i++)
            {
                for (int j = 100; j <= 999; j++)
                {
                    int mul = i * j;

                    if (palindromeControl(mul))
                        threeDigitsMulList.Add(mul);
                }
            }

            return threeDigitsMulList.ToArray();
        }

        private static bool palindromeControl(int num)
        {
            int reverseNum = 0;
            int temporary = num;

            while (temporary > 0)
            {
                reverseNum = reverseNum * 10 + temporary % 10;
                temporary /= 10;
            }

            if (reverseNum == num)
                return true;

            else
                return false;
        }
    }
}
