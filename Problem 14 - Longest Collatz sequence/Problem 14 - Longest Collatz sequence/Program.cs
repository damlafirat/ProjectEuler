using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_14___Longest_Collatz_sequence
{
    /*
     * Longest Collatz sequence
     * Problem 14 
     * The following iterative sequence is defined for the set of positive integers:
     * n → n/2 (n is even)
     * n → 3n + 1 (n is odd)
     * Using the rule above and starting with 13, we generate the following sequence:
     * 13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1
     * It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms. Although it has not been proved yet (Collatz Problem), it is thought that all starting numbers finish at 1.
     * Which starting number, under one million, produces the longest chain?
     * NOTE: Once the chain starts the terms are allowed to go above one million.
     */

    class Program
    {
        static void Main(string[] args)
        {
            longestCollatzSequence();
            Console.ReadLine();
        }

        private static void longestCollatzSequence()
        {
            int longest = 0;
            int num = 0;
            for (int i = 1; i < 20; i++)
            {
                if (longest < collatzSequence(i))
                {
                    longest = collatzSequence(i);
                    num = i;
                }
            }

            Console.WriteLine(longest);
            Console.WriteLine(num);
        }

        private static int collatzSequence(int num)
        {
            int counter = 1;

            while (num != 1)
            {
                if (num % 2 == 0)
                    num /= 2;
                else
                    num = 3 * num + 1;

                counter++;
            }

            return counter;
        }
    }
}
