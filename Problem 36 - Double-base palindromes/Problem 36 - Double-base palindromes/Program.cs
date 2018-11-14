using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Problem_36___Double_base_palindromes
{
    class Program
    {
        /*
         * Double base palindromes
         * Problem 36
         * The decimal number, 585 = (1001001001)2 (binary), is palindromic in both bases.
         * Find the sum of all numbers, less than one million, which are palindromic in base 10 and base 2.
         * (Please note that the palindromic number, in either base, may not include leading zeros.)
         */

        static void Main(string[] args)
        {
            Console.WriteLine(sumOfPalindromicNumbers(generatePalindromicNumbers()));

            Console.ReadLine();
        }

        private static int sumOfPalindromicNumbers(Dictionary<int, string> dictionary)
        {
            int sum = 0;

            foreach (var item in generatePalindromicNumbers())
            {
                sum += item.Key;
            }

            return sum;
        }

        private static Dictionary<int, string> generatePalindromicNumbers()
        {
            Dictionary<int, string> palindDc = new Dictionary<int, string>();

            for (int i = 0; i < 1000000; i++)
            {
                if (palindromicCheckNumber(i) && palindromicCheckString(Convert.ToString(i, 2)))
                {
                    palindDc.Add(i, Convert.ToString(i, 2));
                }
            }

            return palindDc;
        }

        private static bool palindromicCheckNumber(int v)
        {
            int temp = v;
            int reverse = 0;

            while (temp != 0)
            {
                reverse = reverse * 10 + temp % 10;
                temp /= 10;
            }

            if (reverse == v)
                return true;

            else
                return false;
        }

        private static bool palindromicCheckString(string v)
        {
            char[] charArray = v.ToCharArray();

            Array.Reverse(charArray);

            if (v == new string(charArray))
                return true;

            else
                return false;
        }
    }
}
