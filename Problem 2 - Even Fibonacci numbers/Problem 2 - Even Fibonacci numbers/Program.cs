﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2___Even_Fibonacci_numbers
{
    /*
     * Even Fibonacci numbers
     * Problem 2 
     * Each new term in the Fibonacci sequence is generated by adding the previous two terms. By starting with 1 and 2, the first 10 terms will be:
     * 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
     * By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.
     */

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(fibonacciSum());
            Console.ReadLine();
        }

        private static int fibonacciSum()
        {
            int firstNum = 1;
            int secondNum = 2;
            int sum = 3;

            for (;;)
            {
                int temporary = firstNum + secondNum;
                firstNum = secondNum;
                secondNum = temporary;

                if (secondNum <= 4000000)
                {
                    if (EvenControl(secondNum))
                        sum += secondNum;
                }

                else
                    break;
            }

            return sum - 1;
        }

        private static bool EvenControl(int num)
        {
            if (num % 2 == 0)
                return true;

            else
                return false;
        }
    }
}
