using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Problem_25___1000_digit_Fibonacci_number
{
    /*
     * 1000-digit Fibonacci number
     * Problem 25 
     * The Fibonacci sequence is defined by the recurrence relation:
     * Fn = Fn−1 + Fn−2, where F1 = 1 and F2 = 1.
     * Hence the first 12 terms will be:
     * F1 = 1
     * F2 = 1
     * F3 = 2
     * F4 = 3
     * F5 = 5
     * F6 = 8
     * F7 = 13
     * F8 = 21
     * F9 = 34
     * F10 = 55
     * F11 = 89
     * F12 = 144
     * The 12th term, F12, is the first term to contain three digits.
     * What is the index of the first term in the Fibonacci sequence to contain 1000 digits?
    */

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(fibonacci());
            Console.ReadLine();
        }

        private static BigInteger digitsNum(BigInteger num)
        {
            BigInteger digits = 0;

            while (num != 0)
            {
                num = num / 10;
                digits++;
            }

            return digits;
        }

        private static BigInteger fibonacci()
        {
            BigInteger num1 = 1, num2 = 1;
            BigInteger temporary = 0;
            BigInteger digit = 2;

            for (;;)
            {
                temporary = num1 + num2;
                num1 = num2;
                num2 = temporary;
                digit++;

                if (digitsNum(temporary) == 1000)
                    break;
            }

            return digit;
        }
    }
}
