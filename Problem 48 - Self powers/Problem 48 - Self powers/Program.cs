using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Problem_48___Self_powers
{
    class Program
    {
        /*
         * Self powers
         * Problem 48
         * The series, 1^1 + 2^2 + 3^3 + ... + 10^10 = 10405071317.
         * Find the last ten digits of the series, 1^1 + 2^2 + 3^3 + ... + 1000^1000.
         */

        static void Main(string[] args)
        {
            Console.WriteLine(solution(1000));

            Console.ReadLine();
        }

        private static BigInteger solution(int v)
        {
            BigInteger sum = 0;

            for (int i = 1 ; i <= v; i++)
            {
                sum += BigInteger.Pow(i, i);
            }

            return (sum%10000000000);
        }
    }
}
